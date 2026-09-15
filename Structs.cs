using System;
using ObjCRuntime;

namespace iOSCharts
{
    [Native]
    public enum ChartDataSetRounding : long
    {
        Up = 0,
        Down = 1,
        Closest = 2
    }

    [Native]
    public enum ChartEasingOption : long
    {
        Linear = 0,
        EaseInQuad = 1,
        EaseOutQuad = 2,
        EaseInOutQuad = 3,
        EaseInCubic = 4,
        EaseOutCubic = 5,
        EaseInOutCubic = 6,
        EaseInQuart = 7,
        EaseOutQuart = 8,
        EaseInOutQuart = 9,
        EaseInQuint = 10,
        EaseOutQuint = 11,
        EaseInOutQuint = 12,
        EaseInSine = 13,
        EaseOutSine = 14,
        EaseInOutSine = 15,
        EaseInExpo = 16,
        EaseOutExpo = 17,
        EaseInOutExpo = 18,
        EaseInCirc = 19,
        EaseOutCirc = 20,
        EaseInOutCirc = 21,
        EaseInElastic = 22,
        EaseOutElastic = 23,
        EaseInOutElastic = 24,
        EaseInBack = 25,
        EaseOutBack = 26,
        EaseInOutBack = 27,
        EaseInBounce = 28,
        EaseOutBounce = 29,
        EaseInOutBounce = 30
    }

    [Native]
    public enum ChartLimitLabelPosition : long
    {
        LeftTop = 0,
        LeftBottom = 1,
        RightTop = 2,
        RightBottom = 3
    }

    [Native]
    public enum CombinedChartDrawOrder : long
    {
        Bar = 0,
        Bubble = 1,
        Line = 2,
        Candle = 3,
        Scatter = 4
    }

    [Native]
    public enum ChartLegendForm : long
    {
        None = 0,
        Empty = 1,
        Default = 2,
        Square = 3,
        Circle = 4,
        Line = 5
    }

    [Native]
    public enum ChartLegendHorizontalAlignment : long
    {
        Left = 0,
        Center = 1,
        Right = 2
    }

    [Native]
    public enum ChartLegendVerticalAlignment : long
    {
        Top = 0,
        Center = 1,
        Bottom = 2
    }

    [Native]
    public enum ChartLegendOrientation : long
    {
        Horizontal = 0,
        Vertical = 1
    }

    [Native]
    public enum ChartLegendDirection : long
    {
        LeftToRight = 0,
        RightToLeft = 1
    }

    [Native]
    public enum LineChartMode : long
    {
        Linear = 0,
        Stepped = 1,
        CubicBezier = 2,
        HorizontalBezier = 3
    }

    [Native]
    public enum PieChartValuePosition : long
    {
        InsideSlice = 0,
        OutsideSlice = 1
    }

    [Native]
    public enum ScatterShape : long
    {
        Square = 0,
        Circle = 1,
        Triangle = 2,
        Cross = 3,
        X = 4,
        ChevronUp = 5,
        ChevronDown = 6
    }

    [Native]
    public enum XAxisLabelPosition : long
    {
        Top = 0,
        Bottom = 1,
        BothSided = 2,
        TopInside = 3,
        BottomInside = 4
    }

    [Native]
    public enum YAxisLabelPosition : long
    {
        OutsideChart = 0,
        InsideChart = 1
    }

    [Native]
    public enum AxisDependency : long
    {
        Left = 0,
        Right = 1
    }
}
