# iOSCharts

.NET for iOS binding of **[Charts](https://github.com/ChartsOrg/Charts) 5.1.0** (DGCharts), the iOS charting
library by Daniel Cohen Gindi, inspired by Philipp Jahoda's MPAndroidChart. Line, bar, horizontal bar, pie,
scatter, candle stick, bubble, radar and combined charts, with animations, highlighting, markers, legends and
value formatters.

The binding is by Lucas Teixeira ([@flash3001](https://twitter.com/flash3001)). Source and issues:
https://github.com/Flash3001/iOSCharts.Xamarin

## Requirements

| | |
|---|---|
| Target framework | `net10.0-ios` (.NET 10 SDK with the `ios` workload) |
| Xcode | 26.x. Built and verified with Xcode 26.6 |
| Minimum iOS | 12.2 (the .NET default; DGCharts itself supports iOS 12+) |
| Architectures | device `arm64`; simulator `arm64` and `x86_64` (Apple-silicon simulators included) |
| Dependencies | none. The Swift 5 ABI is stable, so the `Xamarin.Swift*` packages the 3.x versions required are gone |

The native library ships as `DGCharts.xcframework` inside a .NET binding resource package; nothing else has to
be added to your app.

## Install

```sh
dotnet add package iOSCharts
```

## Quick start

```csharp
using iOSCharts;

var chart = new LineChartView(View.Bounds);
View.AddSubview(chart);

var entries = Enumerable.Range(0, 12)
    .Select(i => new ChartDataEntry(i, Math.Sin(i / 2.0) * 10 + 20))
    .ToArray();

var set = new LineChartDataSet(entries, "Temperature")
{
    Mode = LineChartMode.CubicBezier,
    LineWidth = 2,
    DrawCirclesEnabled = false,
    DrawFilledEnabled = true,
    Fill = new ChartColorFill(UIColor.SystemBlue),
    FillAlpha = 0.3f,
};
set.Colors = ChartColorTemplates.Material;

chart.Data = new LineChartData(new IChartDataSetProtocol[] { set });
chart.XAxis.ValueFormatter = new ChartIndexAxisValueFormatter(
    new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" });
chart.LeftAxis.AddLimitLine(new ChartLimitLine(25, "target"));
chart.RightAxis.Enabled = false;
chart.Legend.Form = ChartLegendForm.Line;
chart.AnimateWithXAxisDuration(1.0, ChartEasingOption.EaseInOutQuart);
```

Every chart type follows the same shape: `XxxChartView`, `XxxChartData`, `XxxChartDataSet`, `XxxChartDataEntry`.

## Implementing the Charts protocols in C#

Charts exposes formatters, markers, delegates, highlighters and renderers as Swift protocols. In the binding each
protocol has an `I…` interface and a model base class of the same name. Subclass the model class and override
what you need; pass the instance anywhere the interface is expected.

```csharp
class CurrencyFormatter : ChartValueFormatter
{
    public override string StringForValue(double value, ChartDataEntry entry, nint dataSetIndex,
                                          ChartViewPortHandler? viewPortHandler)
        => value.ToString("C0");
}

class SelectionDelegate : ChartViewDelegate
{
    public override void ChartValueSelected(ChartViewBase chartView, ChartDataEntry entry, ChartHighlight highlight)
        => Console.WriteLine($"x={entry.X} y={entry.Y}");
    public override void ChartValueNothingSelected(ChartViewBase chartView) { }
}

class DotMarker : ChartMarker
{
    public override CGPoint Offset => CGPoint.Empty;
    public override CGPoint OffsetForDrawingAtPoint(CGPoint point) => CGPoint.Empty;
    public override void RefreshContentWithEntry(ChartDataEntry entry, ChartHighlight highlight) { }
    public override void DrawWithContext(CGContext context, CGPoint point)
    {
        context.SetFillColor(UIColor.Red.CGColor);
        context.FillEllipseInRect(new CGRect(point.X - 6, point.Y - 6, 12, 12));
    }
}

set.ValueFormatter = new CurrencyFormatter();
chart.Delegate = new SelectionDelegate();
chart.Marker = new DotMarker();
```

Available protocols: `ChartDataSetProtocol` and its per-chart specialisations (`LineChartDataSetProtocol`,
`BarChartDataSetProtocol`, …), `ChartDataProvider` and specialisations, `ChartValueFormatter`,
`ChartAxisValueFormatter`, `ChartFillFormatter`, `ChartFill`, `ChartMarker`, `ChartViewDelegate`,
`ChartAnimatorDelegate`, `ChartHighlighterProtocol`, `ChartRenderer`, `ChartDataRenderer`, `ShapeRenderer`.

## Upgrading from iOSCharts 3.2.x

Charts 5 is a breaking release upstream; see the
[Charts changelog](https://github.com/ChartsOrg/Charts/blob/master/CHANGELOG.md). On the binding side the
Swift protocols were renamed, so the old `IInterface…` names are gone:

| 3.2.x | 5.1.0 |
|---|---|
| `IInterfaceChartDataSet` / `InterfaceChartDataSet` | `IChartDataSetProtocol` / `ChartDataSetProtocol` |
| `IInterfaceLineChartDataSet`, `IInterfaceBarChartDataSet`, … | `ILineChartDataSetProtocol`, `IBarChartDataSetProtocol`, … |
| `IInterfaceChartValueFormatter` / `InterfaceChartValueFormatter` | `IChartValueFormatter` / `ChartValueFormatter` |
| `IInterfaceChartAxisValueFormatter` | `IChartAxisValueFormatter` / `ChartAxisValueFormatter` |
| `IInterfaceChartFillFormatter` | `IChartFillFormatter` / `ChartFillFormatter` |
| `IInterfaceChartMarker` / `InterfaceChartMarker` | `IChartMarker` / `ChartMarker` |
| `IInterfaceChartHighlighter` | `IChartHighlighterProtocol` / `ChartHighlighterProtocol` (the `ChartHighlighter` class is unchanged) |
| `IInterfaceShapeRenderer` | `IShapeRenderer` / `ShapeRenderer` |
| `ChartRenderer`, `ChartDataRendererBase`, `ChartAxisRendererBase` classes | `IChartRenderer` / `IChartDataRenderer` protocols; axis renderers derive from `NSObject` |
| `ChartFill` class and `ChartFillType` enum | `IChartFill` protocol with `ChartColorFill`, `ChartLinearGradientFill`, `ChartRadialGradientFill`, `ChartImageFill`, `ChartLayerFill`, `ChartEmptyFill` |
| `Xamarin.Swift` NuGet dependency | none |
| `xamarinios10` | `net10.0-ios` |

Everything else (`LineChartView`, `ChartDataEntry`, `ChartLimitLine`, `ChartLegend`, the enums, …) keeps its
name.

## License

Apache License 2.0. Copyright 2016-2026 Lucas Teixeira, Daniel Cohen Gindi & Philipp Jahoda.
