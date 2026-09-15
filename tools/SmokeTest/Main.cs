using System.Runtime.InteropServices;
using CoreGraphics;
using Foundation;
using iOSCharts;
using ObjCRuntime;
using UIKit;

UIApplication.Main(args, null, typeof(AppDelegate));

[Register("AppDelegate")]
public class AppDelegate : UIApplicationDelegate
{
    public override UIWindow? Window { get; set; }

    public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
    {
        Window = new UIWindow(UIScreen.MainScreen.Bounds);
        var vc = new UIViewController();
        Window.RootViewController = vc;
        Window.MakeKeyAndVisible();
        int failures = 0;
        try { failures = SmokeTest.Run(vc.View!); }
        catch (Exception ex) { Console.WriteLine("SMOKETEST: EXCEPTION " + ex); failures = 99; }
        Console.WriteLine(failures == 0 ? "SMOKETEST: ALL OK" : $"SMOKETEST: {failures} FAILURE(S)");
        NSTimer.CreateScheduledTimer(1.0, _ => Environment.Exit(failures == 0 ? 0 : 1));
        return true;
    }
}

class ValueFormatter : ChartValueFormatter
{
    public int Calls;
    public override string StringForValue(double value, ChartDataEntry entry, nint dataSetIndex, ChartViewPortHandler? viewPortHandler)
    { Calls++; return $"v{value:0.#}"; }
}

class AxisFormatter : ChartAxisValueFormatter
{
    public int Calls;
    public override string StringForValue(double value, ChartAxisBase? axis) { Calls++; return $"x{value:0}"; }
}

class Delegate : ChartViewDelegate
{
    public int Selected;
    public override void ChartValueSelected(ChartViewBase chartView, ChartDataEntry entry, ChartHighlight highlight)
    { Selected++; Console.WriteLine($"  delegate: selected x={entry.X} y={entry.Y} ds={highlight.DataSetIndex}"); }
    public override void ChartValueNothingSelected(ChartViewBase chartView) { }
}

class Marker : ChartMarker
{
    public int Draws;
    public override CGPoint Offset => CGPoint.Empty;
    public override CGPoint OffsetForDrawingAtPoint(CGPoint point) => CGPoint.Empty;
    public override void RefreshContentWithEntry(ChartDataEntry entry, ChartHighlight highlight) { }
    public override void DrawWithContext(CGContext context, CGPoint point) { Draws++; }
}

static class SmokeTest
{
    static int failures;
    static void Check(string what, bool ok, string? detail = null)
    {
        Console.WriteLine($"  [{(ok ? "ok" : "FAIL")}] {what}{(detail is null ? "" : " -> " + detail)}");
        if (!ok) failures++;
    }

    static UIImage Render(UIView v)
    {
        v.SetNeedsLayout(); v.LayoutIfNeeded(); v.SetNeedsDisplay();
        var r = new UIGraphicsImageRenderer(v.Bounds.Size);
        return r.CreateImage(ctx => v.Layer.RenderInContext(ctx.CGContext));
    }

    public static int Run(UIView host)
    {
        failures = 0;
        var frame = new CGRect(0, 0, 320, 240);
        Console.WriteLine($"SMOKETEST: arch={RuntimeInformation.ProcessArchitecture} os={UIDevice.CurrentDevice.SystemVersion} sim={ObjCRuntime.Runtime.Arch}");

        // ---- runtime class names (the mangled-name witchcraft)
        var line = new LineChartView(frame);
        Check("LineChartView bound to _TtC8DGCharts13LineChartView", line.Class.Handle == Class.GetHandle("_TtC8DGCharts13LineChartView"), line.Class.Name);
        var hbar = new HorizontalBarChartView(frame);
        Check("HorizontalBarChartView bound to _TtC8DGCharts22HorizontalBarChartView", hbar.Class.Handle == Class.GetHandle("_TtC8DGCharts22HorizontalBarChartView"), hbar.Class.Name);
        var fmt = new ChartDefaultValueFormatter();
        Check("ChartDefaultValueFormatter ObjC class", fmt.Class.Name == "ChartDefaultValueFormatter", fmt.Class.Name);
        Check("protocol ChartHighlighter resolves", Protocol.GetHandle("ChartHighlighter") != IntPtr.Zero && Protocol.GetHandle("_TtP8DGCharts20ChartDataSetProtocol_") != IntPtr.Zero);
        Check("LineChartView is IChartDataProvider", line is IChartDataProvider && line is ILineChartDataProvider);

        // ---- line chart with data, formatters, delegate, marker, limit line, fill
        var entries = Enumerable.Range(0, 8).Select(i => new ChartDataEntry(i, Math.Sin(i) * 10 + 20)).ToArray();
        var set = new LineChartDataSet(entries, "sin");
        Check("LineChartDataSet is IChartDataSetProtocol", set is IChartDataSetProtocol && set is ILineChartDataSetProtocol);
        Check("entryCount", set.EntryCount == 8, set.EntryCount.ToString());
        set.Mode = LineChartMode.CubicBezier;
        set.Colors = ChartColorTemplates.Material;
        set.AxisDependency = AxisDependency.Right;
        Check("AxisDependency setter", set.AxisDependency == AxisDependency.Right);
        set.DrawFilledEnabled = true;
        set.Fill = new ChartColorFill(UIColor.Red);
        Check("Fill is IChartFill", set.Fill is IChartFill, set.Fill?.GetType().Name);
        set.FillAlpha = 0.5f;
        var vf = new ValueFormatter();
        set.ValueFormatter = vf;
        Check("ValueFormatter round-trip", ReferenceEquals(set.ValueFormatter, vf) || set.ValueFormatter is ValueFormatter);
        var data = new LineChartData(new IChartDataSetProtocol[] { set });
        Check("LineChartData.DataSets", data.DataSets.Length == 1 && data.DataSets[0] is LineChartDataSet, data.DataSets[0]?.GetType().Name);
        Check("ChartData.EntryCount", data.EntryCount == 8, data.EntryCount.ToString());
        line.Data = data;
        Check("chart.Data round-trip", line.Data is LineChartData);
        var af = new AxisFormatter();
        line.XAxis.ValueFormatter = af;
        line.LeftAxis.AddLimitLine(new ChartLimitLine(25, "limit"));
        Check("limit line stored", line.LeftAxis.LimitLines.Length == 1);
        var del = new Delegate();
        line.Delegate = del;
        Check("Delegate round-trip", line.Delegate is Delegate, line.WeakDelegate?.GetType().Name);
        var marker = new Marker();
        line.Marker = marker;
        Check("Marker is IChartMarker", line.Marker is IChartMarker, line.Marker?.GetType().Name);
        Check("Highlighter is IChartHighlighterProtocol", line.Highlighter is IChartHighlighterProtocol, line.Highlighter?.GetType().Name);
        host.AddSubview(line);
        line.HighlightValue(new ChartHighlight(3, 0, -1), callDelegate: true);
        Check("delegate called on highlight", del.Selected == 1, del.Selected.ToString());
        var img = Render(line);
        Check("line chart rendered", img.Size.Width == 320 && img.Size.Height == 240, img.Size.ToString());
        Check("value formatter invoked while drawing", vf.Calls > 0, vf.Calls.ToString());
        Check("axis formatter invoked while drawing", af.Calls > 0, af.Calls.ToString());
        Check("marker drawn", marker.Draws > 0, marker.Draws.ToString());
        var h = line.Highlighter!.GetHighlightWithX(100, 100);
        Check("highlighter.GetHighlightWithX", h is null || h is ChartHighlight);
        var lbl = line.XAxis.GetLongestLabel();
        Check("XAxis.GetLongestLabel", lbl.Length > 0, lbl);

        // ---- bar chart
        var bar = new BarChartView(frame);
        var bset = new BarChartDataSet(Enumerable.Range(0, 5).Select(i => new BarChartDataEntry(i, i * 3 + 1)).ToArray(), "bars");
        var bdata = new BarChartData(new IChartDataSetProtocol[] { bset });
        bdata.BarWidth = 0.6;
        bar.Data = bdata;
        host.AddSubview(bar);
        Render(bar);
        Check("BarChartView.BarData", bar.BarData is BarChartData);
        Check("BarChartData.BarWidth", Math.Abs(bdata.BarWidth - 0.6) < 1e-9);

        // ---- pie chart
        var pie = new PieChartView(frame);
        var pset = new PieChartDataSet(new[] { new PieChartDataEntry(40, "a"), new PieChartDataEntry(60, "b") }, "pie");
        pset.Colors = ChartColorTemplates.Joyful;
        pie.Data = new PieChartData(new IChartDataSetProtocol[] { pset });
        pie.HoleRadiusPercent = 0.4f;
        host.AddSubview(pie);
        Render(pie);
        Check("PieChartView data", pie.Data!.EntryCount == 2);

        // ---- combined chart
        var combined = new CombinedChartView(frame);
        var cdata = new CombinedChartData();
        cdata.LineData = data;
        cdata.BarData = bdata;
        combined.Data = cdata;
        host.AddSubview(combined);
        Render(combined);
        Check("CombinedChartData.AllData", cdata.AllData.Length == 2, cdata.AllData.Length.ToString());

        // ---- scatter + candle + bubble + radar + horizontal bar
        var scatter = new ScatterChartView(frame);
        var sset = new ScatterChartDataSet(entries, "sc");
        sset.SetScatterShape(ScatterShape.Triangle);
        scatter.Data = new ScatterChartData(new IChartDataSetProtocol[] { sset });
        Render(scatter);
        Check("ScatterChartDataSet.ShapeRenderer", sset.ShapeRenderer is IShapeRenderer, sset.ShapeRenderer?.GetType().Name);
        var candle = new CandleStickChartView(frame);
        candle.Data = new CandleChartData(new IChartDataSetProtocol[] { new CandleChartDataSet(Enumerable.Range(0, 5).Select(i => new CandleChartDataEntry(i, 10 + i, 5 + i, 7 + i, 8 + i)).ToArray(), "cd") });
        Render(candle);
        var bubble = new BubbleChartView(frame);
        bubble.Data = new BubbleChartData(new IChartDataSetProtocol[] { new BubbleChartDataSet(Enumerable.Range(0, 5).Select(i => new BubbleChartDataEntry(i, i, 1 + i)).ToArray(), "bb") });
        Render(bubble);
        var radar = new RadarChartView(frame);
        radar.Data = new RadarChartData(new IChartDataSetProtocol[] { new RadarChartDataSet(Enumerable.Range(0, 5).Select(i => new RadarChartDataEntry(3 + i)).ToArray(), "rd") });
        Render(radar);
        hbar.Data = bdata;
        Render(hbar);
        Check("all chart types rendered", true);

        // ---- animation API + easing enum
        line.AnimateWithXAxisDuration(0.2, 0.2, ChartEasingOption.EaseInOutQuad);
        Check("animate call", true);

        return failures;
    }
}
