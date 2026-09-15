#!/bin/zsh
# Runs Objective Sharpie 3.5 against the DGCharts-Swift.h of the device slice of DGCharts.xcframework.
#
#   tools/sharpie.sh [DGCharts.xcframework] [output-dir]
#
# Sharpie's bundled clang cannot build the module map of the iOS 16.3+/26 SDKs ("module
# '_c_standard_library_obsolete' requires feature ...", "unknown type name 'size_t'"), which silently degrades
# CGFloat/BOOL/NSTimeInterval to NSObject. The workaround: import UIKit textually through a wrapper header,
# disable modules, and add the SDK's SubFrameworks dir (UIKit 26 includes <UIUtilities/UIDefines.h> from there).
set -euo pipefail
XCF=${1:-$(cd "$(dirname "$0")/.." && pwd)/DGCharts.xcframework}
OUT=${2:-$(mktemp -d)}
export DEVELOPER_DIR=${DEVELOPER_DIR:-/Applications/Xcode26.6.app/Contents/Developer}
SDKVER=$(xcodebuild -showsdks | sed -n 's/.*-sdk iphoneos\([0-9.]*\).*/\1/p' | head -1)
SDK=$DEVELOPER_DIR/Platforms/iPhoneOS.platform/Developer/SDKs/iPhoneOS$SDKVER.sdk
HDRS=$(mktemp -d)/Headers
cp -R "$XCF/ios-arm64/DGCharts.framework/Headers" "$HDRS"
cat > "$HDRS/Wrapper.h" <<'H'
#import <Foundation/Foundation.h>
#import <CoreGraphics/CoreGraphics.h>
#import <QuartzCore/QuartzCore.h>
#import <UIKit/UIKit.h>
#import "DGCharts-Swift.h"
H
sharpie bind -sdk "iphoneos$SDKVER" -output "$OUT" -namespace iOSCharts -scope "$HDRS" "$HDRS/Wrapper.h" \
  -c -fno-modules "-F$SDK/System/Library/SubFrameworks"
echo "raw Sharpie output in $OUT (ApiDefinitions.cs, StructsAndEnums.cs); now run tools/transform.py"
