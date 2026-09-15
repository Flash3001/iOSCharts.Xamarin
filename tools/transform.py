#!/usr/bin/env python3
"""Turn Objective Sharpie's raw DGCharts output into the iOSCharts ApiDefinition,
re-applying the same hand tweaks the 3.x binding needed.

    python3 tools/transform.py <sharpie>/ApiDefinitions.cs <sharpie>/StructsAndEnums.cs ApiDefinition.cs Structs.cs


 * dummy `interface IFoo { }` for every protocol, so IFoo can be used as a type
 * every protocol becomes [Protocol, Model] + [BaseType(typeof(NSObject))]
 * protocol-typed members use the IFoo form, class/protocol inheritance uses the bare Foo form
 * protocol `ChartHighlighter` (same ObjC name as the class) -> ChartHighlighterProtocol
 * Sharpie's odd protocol member names (Axis, Y, Rect, ...) -> the class member names
 * drop copyWithZone:, initWithCoder: (bgen adds it for UIView subclasses), observeValueForKeyPath:, [Verify], nsui* UIKit categories
 * fold in-module Swift extension categories into their classes
 * NSTextAlignment -> UITextAlignment
"""
import re, sys

SRC, ENUMS, OUT_API, OUT_STRUCTS = sys.argv[1:5]

text = open(SRC).read()
lines = text.split('\n')

# ---------------------------------------------------------------- parse blocks
blocks = []  # dicts: pre (list of comment/attr lines), decl, body (list of lines), post
i = 0
while i < len(lines):
    l = lines[i]
    if re.match(r'\tinterface\s+\w+', l):
        # walk back to collect attrs / comments belonging to this block
        pre = []
        k = i - 1
        while k >= 0 and (lines[k].strip().startswith('[') or lines[k].strip().startswith('//') or lines[k].strip().startswith('*/') or lines[k].strip().startswith('/*') or (lines[k].strip() and not lines[k].startswith('\t}') and not lines[k].strip().startswith('{') and lines[k].startswith('  '))):
            pre.insert(0, lines[k]); k -= 1
        body = []
        i += 1
        assert lines[i].strip() == '{', (i, lines[i])
        i += 1
        while not lines[i].startswith('\t}'):
            body.append(lines[i]); i += 1
        blocks.append({'pre': pre, 'decl': l, 'body': body})
        i += 1
        continue
    i += 1

def block_name(b):
    return re.match(r'\tinterface\s+(\w+)', b['decl']).group(1)

def block_bases(b):
    m = re.match(r'\tinterface\s+\w+\s*:\s*(.*)$', b['decl'])
    return [x.strip() for x in m.group(1).split(',')] if m else []

def is_protocol(b):
    return any('[Protocol' in p for p in b['pre'])

def is_category(b):
    return any(p.strip() == '[Category]' for p in b['pre'])

protocols = {block_name(b) for b in blocks if is_protocol(b)}
RENAME = {'ChartHighlighter': 'ChartHighlighterProtocol'}   # protocol C# names that collide with classes
def pname(p): return RENAME.get(p, p)

# ------------------------------------------------------------- member parsing
def members(body):
    """split a body into members: each is list of lines (comment, attrs, decl)"""
    out, cur = [], []
    for l in body:
        if l.strip() == '':
            if cur: out.append(cur); cur = []
        else:
            cur.append(l)
    if cur: out.append(cur)
    return out

def member_selector(m):
    for l in m:
        mm = re.search(r'Export \("([^"]+)"', l)
        if mm: return mm.group(1)
    return None

def member_comment(m):
    return '\n'.join(l for l in m if l.strip().startswith('//'))

def member_decl_index(m):
    for idx in range(len(m) - 1, -1, -1):
        s = m[idx].strip()
        if not s.startswith('[') and not s.startswith('//'):
            return idx
    return None

ODD_NAMES = {   # selector -> proper C# name (Sharpie picked a later selector part)
    'stringForValue:axis:': 'StringForValue',
    'getHighlightWithX:y:': 'GetHighlightWithX',
    'renderShapeWithContext:dataSet:viewPortHandler:point:color:': 'RenderShapeWithContext',
    'fillPathWithContext:rect:': 'FillPathWithContext',
    'getFillLinePositionWithDataSet:dataProvider:': 'GetFillLinePositionWithDataSet',
    'stringForValue:entry:dataSetIndex:viewPortHandler:': 'StringForValue',
    'chartView:animatorDidStop:': 'ChartViewAnimatorDidStop',
}
VERIFY_TO_METHOD = {'getLongestLabel', 'removeFirst', 'removeLast', 'valuesToHighlight',
                    'getGreatestShapeSize', 'resetZoom', 'fitScreen', 'getRequiredHeightSpace'}
DROP_SELECTORS = {'copyWithZone:', 'initWithCoder:', 'observeValueForKeyPath:ofObject:change:context:', 'isEqual:', 'new'}

def pascal(s):
    return s[0].upper() + s[1:]

def fix_member(m):
    sel = member_selector(m)
    if sel in DROP_SELECTORS:
        return None
    m = [l for l in m if not l.strip().startswith('[Verify')]
    # strip trailing Verify from combined attribute lines
    m = [re.sub(r'\[Verify \([^)]*\)(, Verify \([^)]*\))*\]', '', l) for l in m]
    m = [l for l in m if l.strip() != '']
    di = member_decl_index(m)
    if di is None:
        return m
    decl = m[di]
    comment = member_comment(m)
    # protocol types in member signatures -> I-form ([Wrap("WeakDelegate")] members have no ObjC comment)
    is_wrap = any('[Wrap' in l for l in m)
    def to_iform(types):
        for p in protocols:
            if f'id<{p}>' in comment or f'id <{p}>' in comment or is_wrap:
                types = re.sub(r'(?<![\w])' + re.escape(p) + r'(?![\w])', 'I' + pname(p), types)
        return types
    # only touch type positions, never the member name (e.g. `ShapeRenderer ShapeRenderer { get; set; }`)
    mm = re.match(r'^(\s*)(.+?)\s+(\w+)\s*\((.*)\)\s*;\s*$', decl)
    if mm:
        decl = f'{mm.group(1)}{to_iform(mm.group(2))} {mm.group(3)}({to_iform(mm.group(4))});'
    else:
        mm = re.match(r'^(\s*)(.+?)\s+(\w+)\s*(\{.*)$', decl)
        if mm:
            decl = f'{mm.group(1)}{to_iform(mm.group(2))} {mm.group(3)} {mm.group(4)}'
    # odd names
    if sel in ODD_NAMES:
        decl = re.sub(r'(\s)(\w+)(\s*\()', lambda mm: mm.group(1) + ODD_NAMES[sel] + mm.group(3), decl, count=1)
    # Verify(MethodToProperty) -> real method for the getters that are really methods
    if sel in VERIFY_TO_METHOD:
        mm = re.match(r'(\s*)(\S+)\s+(\w+)\s*\{\s*get;\s*\}', decl)
        if mm:
            decl = f'{mm.group(1)}{mm.group(2)} {pascal(sel)} ();'
    decl = decl.replace('NSTextAlignment', 'UITextAlignment')
    m[di] = decl
    return m

# ------------------------------------------------------------- build output
class_by_name = {block_name(b): b for b in blocks if not is_protocol(b) and not is_category(b)}

# Protocol properties are re-inlined into every adopting subclass by bgen. A get-only protocol property
# would then hide the settable property of the base class (e.g. ChartDataProvider.data vs ChartViewBase.data),
# so promote it to { get; set; } whenever some class declares the same selector with a setter.
settable_selectors = set()
for b in blocks:
    if is_protocol(b): continue
    for m in members(b['body']):
        di = member_decl_index(m)
        if di is not None and re.search(r'\{\s*get;\s*set;\s*\}', m[di]):
            settable_selectors.add(member_selector(m))
promoted = []
for b in blocks:
    if not is_protocol(b): continue
    body = b['body']
    for m in members(body):
        di = member_decl_index(m)
        sel = member_selector(m)
        if di is not None and sel in settable_selectors and re.search(r'\{\s*get;\s*\}', m[di]):
            new_line = re.sub(r'\{\s*get;\s*\}', '{ get; set; }', m[di])
            body[body.index(m[di])] = new_line
            promoted.append(f'{block_name(b)}.{sel}')
print('promoted to get/set:', promoted)

# fold categories into their classes
for b in blocks:
    if not is_category(b): continue
    target = None
    for p in b['pre']:
        mm = re.search(r'BaseType \(typeof\((\w+)\)\)', p)
        if mm: target = mm.group(1)
    if target not in class_by_name:
        continue  # UIKit / NSUIView helper extensions: dropped
    tgt = class_by_name[target]
    existing = {member_selector(m) for m in members(tgt['body'])}
    for m in members(b['body']):
        sel = member_selector(m)
        if sel in DROP_SELECTORS or sel in existing: continue
        tgt['body'].append('')
        tgt['body'].extend(m)
        existing.add(sel)

out = []
out.append('''using System;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace iOSCharts
{''')

def clean_attr(l):
    l = re.sub(r'\[(\w+) \(', r'[\1(', l)
    l = re.sub(r', (\w+) \(', r', \1(', l)
    l = l.replace('typeof (', 'typeof(')
    return l

def fmt(l):
    # tabs -> 4 spaces; Sharpie's `Name (` -> `Name(` on declarations
    l = l.replace('\t', '    ')
    if l.strip().startswith('//'):
        return l
    if l.strip().startswith('['):
        return clean_attr(l)
    l = re.sub(r'(\w) \(', r'\1(', l)
    return l

first = True
for b in blocks:
    if is_category(b):
        continue
    name = block_name(b)
    if not first: out.append('')
    first = False
    comments = [p for p in b['pre'] if p.strip().startswith('//')]
    attrs = [p for p in b['pre'] if p.strip().startswith('[') or p.strip().startswith('*/[')]
    if is_protocol(b):
        cs = pname(name)
        proto_attr = next(a for a in attrs if '[Protocol' in a)
        mm = re.search(r'Name = "([^"]+)"', proto_attr)
        objc_name = mm.group(1) if mm else (name if cs != name else None)
        out.append(f'    interface I{cs} {{ }}')
        out.append('')
        out.extend(fmt(c) for c in comments)
        if objc_name:
            out.append(f'    [Protocol(Name = "{objc_name}"), Model]')
        else:
            out.append('    [Protocol, Model]')
        out.append('    [BaseType(typeof(NSObject))]')
        bases = block_bases(b)
        bare = []
        for x in bases:
            if x.startswith('I') and x[1:] in protocols: bare.append(pname(x[1:]))
            elif x in protocols: bare.append(pname(x))
            else: bare.append(x)
        out.append(f'    interface {cs}' + (f' : {", ".join(bare)}' if bare else ''))
    else:
        out.extend(fmt(c) for c in comments)
        for a in attrs:
            out.append(fmt(a))
        bases = block_bases(b)
        bare = []
        for x in bases:
            if x.startswith('I') and x[1:] in protocols: bare.append(pname(x[1:]))
            else: bare.append(x)
        out.append(f'    interface {name}' + (f' : {", ".join(bare)}' if bare else ''))
    out.append('    {')
    ms = [fix_member(m) for m in members(b['body'])]
    ms = [m for m in ms if m]
    for idx, m in enumerate(ms):
        if idx: out.append('')
        out.extend(fmt(l) for l in m)
    out.append('    }')
out.append('}')
open(OUT_API, 'w').write('\n'.join(out) + '\n')

# ------------------------------------------------------------------ enums
e = open(ENUMS).read().replace('\t', '    ')
e = e.replace('using ObjCRuntime;', 'using System;\nusing ObjCRuntime;')
open(OUT_STRUCTS, 'w').write(e)

print('protocols:', sorted(pname(p) for p in protocols))
print('blocks written:', sum(1 for b in blocks if not is_category(b)))
