# iOSCharts.Xamarin

A .NET for iOS binding by Lucas Teixeira for Charts (now DGCharts) by Daniel Cohen Gindi, inspired by Philipp Jahoda.
https://github.com/ChartsOrg/Charts

## Charts 5.1.0 (package 5.1.0)

* Binds **DGCharts 5.1.0** shipped as `DGCharts.xcframework`: device `arm64`, simulator `arm64` + `x86_64`.
  Apple-silicon simulators work; `armv7`/`i386` are gone.
* Targets **net10.0-ios** (.NET 10 SDK, iOS workload 26.5). Built and verified with **Xcode 26.6**.
* No more `Xamarin.Swift*` dependencies. The Swift 5 ABI is stable and the runtime ships with iOS 12.2+.
* The native library is delivered as a .NET binding resource package (`iOSCharts.resources.zip` next to the
  dll in the NuGet), which is what `NoBindingEmbedding=true` produces.
* Breaking changes from Charts 3.x are upstream's: https://github.com/ChartsOrg/Charts/blob/master/CHANGELOG.md

### Naming changes you will hit when upgrading from 3.2.x

Charts 5 renamed its Swift protocols, and the C# names follow the Objective-C names, so the old `IInterface…`
work-around is gone:

| 3.2.x binding                                   | 5.1.0 binding                                   |
|-------------------------------------------------|-------------------------------------------------|
| `IInterfaceChartDataSet` / `InterfaceChartDataSet` | `IChartDataSetProtocol` / `ChartDataSetProtocol` |
| `IInterfaceLineChartDataSet` …                  | `ILineChartDataSetProtocol` … (same for Bar, Bubble, Candle, Pie, Radar, Scatter, LineRadar, …) |
| `IInterfaceChartValueFormatter` / `InterfaceChartValueFormatter` | `IChartValueFormatter` / `ChartValueFormatter` |
| `IInterfaceChartAxisValueFormatter`             | `IChartAxisValueFormatter` / `ChartAxisValueFormatter` |
| `IInterfaceChartFillFormatter`                  | `IChartFillFormatter` / `ChartFillFormatter`    |
| `IInterfaceChartMarker` / `InterfaceChartMarker` | `IChartMarker` / `ChartMarker`                 |
| `IInterfaceChartHighlighter`                    | `IChartHighlighterProtocol` / `ChartHighlighterProtocol` (the class is still `ChartHighlighter`) |
| `IInterfaceShapeRenderer`                       | `IShapeRenderer` / `ShapeRenderer`              |
| `ChartRenderer`, `ChartDataRendererBase`, `ChartAxisRendererBase` classes | `IChartRenderer` / `IChartDataRenderer` protocols; axis renderers derive from `NSObject` |
| `ChartFill` class + `ChartFillType` enum        | `IChartFill` protocol with `ChartColorFill`, `ChartLinearGradientFill`, `ChartRadialGradientFill`, `ChartImageFill`, `ChartLayerFill`, `ChartEmptyFill` |

To implement a protocol in C#, subclass the model class (`class MyFormatter : ChartValueFormatter { … }`) and
override its members; pass it wherever the `I…` interface is expected. Constructors take `IntPtr`-free
`NativeHandle` handles now.

```csharp
var entries = Enumerable.Range(0, 8).Select(i => new ChartDataEntry(i, Math.Sin(i) * 10 + 20)).ToArray();
var set = new LineChartDataSet(entries, "sin") { Mode = LineChartMode.CubicBezier };
set.Colors = ChartColorTemplates.Material;
set.ValueFormatter = new MyValueFormatter();        // : ChartValueFormatter
chart.Data = new LineChartData(new IChartDataSetProtocol[] { set });
chart.XAxis.ValueFormatter = new ChartIndexAxisValueFormatter(new[] { "a", "b", "c" });
chart.Delegate = new MyDelegate();                  // : ChartViewDelegate
```

## Building the binding

Requirements: .NET 10 SDK with the `ios` workload, Xcode 26.6. When more than one Xcode is installed, point
the .NET SDK at 26.6:

```sh
export MD_APPLE_SDK_ROOT=/Applications/Xcode26.6.app
dotnet build -c Release          # produces bin/Release/iOSCharts.5.1.0.nupkg
```

`../global.json` pins the .NET SDK to 10.0.302.

## Regenerating the binding for a new Charts release

All the hand tweaks the Swift → Objective-C → C# path needs are scripted in `tools/`:

1. `tools/build-xcframework.sh /path/to/Charts-x.y.z` archives the `DGCharts` scheme for iOS and the
   iOS Simulator with Xcode 26.6 and writes `DGCharts.xcframework` here.
2. `tools/sharpie.sh` runs Objective Sharpie 3.5 on `DGCharts-Swift.h`. Sharpie's clang cannot read the
   iOS 26 SDK module map, so the script imports UIKit textually through a wrapper header with `-fno-modules`
   and adds the SDK `SubFrameworks` search path; without that every `CGFloat`/`BOOL` comes out as `NSObject`.
3. `python3 tools/transform.py <ApiDefinitions.cs> <StructsAndEnums.cs> ApiDefinition.cs Structs.cs`
   re-applies the "witchcraft":
   * a dummy `interface IFoo { }` per protocol, so `IFoo` can be used as a parameter/property type;
   * every protocol is `[Protocol(Name = "_TtP8DGCharts…_"), Model]` + `[BaseType(typeof(NSObject))]`
     (Sharpie already emits the mangled `_TtC8DGCharts…` / `_TtP8DGCharts…` runtime names for the Swift
     types without an explicit `@objc(Name)`);
   * members use the `IFoo` form for protocol types, classes and protocols adopt protocols in the bare
     `interface Foo : FooProtocol` form. That bare form is what makes bgen inline the members *and* implement
     `IFooProtocol`; with the `I` form bgen sees only the dummy interface and the class does not implement
     the protocol at all;
   * get-only protocol properties that the concrete classes expose as settable get a `set;` (`data`,
     `axisDependency`, `colors`, `barData`, …), otherwise the copy re-inlined into every subclass hides the
     settable one of the base class and `lineChart.Data = …` stops compiling;
   * the protocol `ChartHighlighter` shares its Objective-C name with the class, so the C# protocol is
     `ChartHighlighterProtocol`;
   * Sharpie's odd protocol member names (`Axis`, `Y`, `Rect`, `DataSet`, `Entry`, `DataProvider`) become the
     class member names, `chartView:animatorDidStop:` becomes `ChartViewAnimatorDidStop`;
   * `copyWithZone:` (`INSCopying` stays), `initWithCoder:` (bgen adds it for `UIView` subclasses),
     `observeValueForKeyPath:…`, `[Verify]`, and the `nsui*` UIKit helper categories are dropped; the
     in-module Swift extension categories are folded into their classes; `NSTextAlignment` → `UITextAlignment`.
4. `dotnet build -c Release`, then `tools/SmokeTest` (a .NET iOS app; `dotnet build` it and run on an
   arm64 simulator) exercises every chart type, formatter/delegate/marker subclasses and the mangled names.

## Binding Swift Libraries

If you got here after googling for a way to bind Swift libraries in Xamarin / .NET for iOS, the steps above
are the whole recipe. Feel free to reach out: https://twitter.com/flash3001

## License

Copyright 2016-2026 Lucas Teixeira, Daniel Cohen Gindi & Philipp Jahoda

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
