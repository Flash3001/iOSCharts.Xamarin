using System;
using ObjCRuntime;

namespace iOSCharts
{
	[Native]
	public enum ChartDataSetRounding : ulong
	{
		Up = 0,
		Down = 1,
		Closest = 2
	}

	[Native]
	public enum ChartEasingOption : ulong
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
	public enum ChartLimitLabelPosition : ulong
	{
		LeftTop = 0,
		LeftBottom = 1,
		RightTop = 2,
		RightBottom = 3
	}

	[Native]
	public enum CombinedChartDrawOrder : ulong
	{
		Bar = 0,
		Bubble = 1,
		Line = 2,
		Candle = 3,
		Scatter = 4
	}

	[Native]
	public enum ChartFillType : ulong
	{
		Empty = 0,
		Color = 1,
		LinearGradient = 2,
		RadialGradient = 3,
		Image = 4,
		TiledImage = 5,
		Layer = 6
	}

	[Native]
	public enum ChartLegendPosition : ulong
	{
		RightOfChart = 0,
		RightOfChartCenter = 1,
		RightOfChartInside = 2,
		LeftOfChart = 3,
		LeftOfChartCenter = 4,
		LeftOfChartInside = 5,
		BelowChartLeft = 6,
		BelowChartRight = 7,
		BelowChartCenter = 8,
		AboveChartLeft = 9,
		AboveChartRight = 10,
		AboveChartCenter = 11,
		PiechartCenter = 12
	}

	[Native]
	public enum ChartLegendForm : ulong
	{
		None = 0,
		Empty = 1,
		Default = 2,
		Square = 3,
		Circle = 4,
		Line = 5
	}

	[Native]
	public enum ChartLegendHorizontalAlignment : ulong
	{
		Left = 0,
		Center = 1,
		Right = 2
	}

	[Native]
	public enum ChartLegendVerticalAlignment : ulong
	{
		Top = 0,
		Center = 1,
		Bottom = 2
	}

	[Native]
	public enum ChartLegendOrientation : ulong
	{
		Horizontal = 0,
		Vertical = 1
	}

	[Native]
	public enum ChartLegendDirection : ulong
	{
		LeftToRight = 0,
		RightToLeft = 1
	}

	[Native]
	public enum LineChartMode : ulong
	{
		Linear = 0,
		Stepped = 1,
		CubicBezier = 2,
		HorizontalBezier = 3
	}

	[Native]
	public enum PieChartValuePosition : ulong
	{
		InsideSlice = 0,
		OutsideSlice = 1
	}

	[Native]
	public enum ScatterShape : ulong
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
	public enum XAxisLabelPosition : ulong
	{
		Top = 0,
		Bottom = 1,
		BothSided = 2,
		TopInside = 3,
		BottomInside = 4
	}

	[Native]
	public enum YAxisLabelPosition : ulong
	{
		OutsideChart = 0,
		InsideChart = 1
	}

	[Native]
	public enum AxisDependency : ulong
	{
		Left = 0,
		Right = 1
	}
}