using System;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace iOSCharts
{
	// @interface ChartViewPortJob : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ChartViewPortJob
	{
		// -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler xValue:(double)xValue yValue:(double)yValue transformer:(ChartTransformer * _Nonnull)transformer view:(ChartViewBase * _Nonnull)view __attribute__((objc_designated_initializer));
		[Export("initWithViewPortHandler:xValue:yValue:transformer:view:")]
		[DesignatedInitializer]
		IntPtr Constructor(ChartViewPortHandler viewPortHandler, double xValue, double yValue, ChartTransformer transformer, ChartViewBase view);

		// -(void)doJob;
		[Export("doJob")]
		void DoJob();
	}

	// @interface AnimatedViewPortJob : ChartViewPortJob
	[BaseType(typeof(ChartViewPortJob), Name = "_TtC6Charts19AnimatedViewPortJob")]
	interface AnimatedViewPortJob
	{
		// -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler xValue:(double)xValue yValue:(double)yValue transformer:(ChartTransformer * _Nonnull)transformer view:(ChartViewBase * _Nonnull)view xOrigin:(CGFloat)xOrigin yOrigin:(CGFloat)yOrigin duration:(NSTimeInterval)duration easing:(double (^ _Nullable)(NSTimeInterval, NSTimeInterval))easing __attribute__((objc_designated_initializer));
		[Export("initWithViewPortHandler:xValue:yValue:transformer:view:xOrigin:yOrigin:duration:easing:")]
		[DesignatedInitializer]
		IntPtr Constructor(ChartViewPortHandler viewPortHandler, double xValue, double yValue, ChartTransformer transformer, ChartViewBase view, nfloat xOrigin, nfloat yOrigin, double duration, [NullAllowed] Func<double, double, double> easing);

		// -(void)doJob;
		[Export("doJob")]
		void DoJob();

		// -(void)start;
		[Export("start")]
		void Start();

		// -(void)stopWithFinish:(BOOL)finish;
		[Export("stopWithFinish:")]
		void StopWithFinish(bool finish);
	}

	// @interface AnimatedMoveViewJob : AnimatedViewPortJob
	[BaseType(typeof(AnimatedViewPortJob), Name = "_TtC6Charts19AnimatedMoveViewJob")]
	interface AnimatedMoveViewJob
	{
		// -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler xValue:(double)xValue yValue:(double)yValue transformer:(ChartTransformer * _Nonnull)transformer view:(ChartViewBase * _Nonnull)view xOrigin:(CGFloat)xOrigin yOrigin:(CGFloat)yOrigin duration:(NSTimeInterval)duration easing:(double (^ _Nullable)(NSTimeInterval, NSTimeInterval))easing __attribute__((objc_designated_initializer));
		[Export("initWithViewPortHandler:xValue:yValue:transformer:view:xOrigin:yOrigin:duration:easing:")]
		[DesignatedInitializer]
		IntPtr Constructor(ChartViewPortHandler viewPortHandler, double xValue, double yValue, ChartTransformer transformer, ChartViewBase view, nfloat xOrigin, nfloat yOrigin, double duration, [NullAllowed] Func<double, double, double> easing);
	}

	// @interface AnimatedZoomViewJob : AnimatedViewPortJob
	[BaseType(typeof(AnimatedViewPortJob), Name = "_TtC6Charts19AnimatedZoomViewJob")]
	interface AnimatedZoomViewJob
	{
		// -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler transformer:(ChartTransformer * _Nonnull)transformer view:(ChartViewBase * _Nonnull)view yAxis:(ChartYAxis * _Nonnull)yAxis xAxisRange:(double)xAxisRange scaleX:(CGFloat)scaleX scaleY:(CGFloat)scaleY xOrigin:(CGFloat)xOrigin yOrigin:(CGFloat)yOrigin zoomCenterX:(CGFloat)zoomCenterX zoomCenterY:(CGFloat)zoomCenterY zoomOriginX:(CGFloat)zoomOriginX zoomOriginY:(CGFloat)zoomOriginY duration:(NSTimeInterval)duration easing:(double (^ _Nullable)(NSTimeInterval, NSTimeInterval))easing __attribute__((objc_designated_initializer));
		[Export("initWithViewPortHandler:transformer:view:yAxis:xAxisRange:scaleX:scaleY:xOrigin:yOrigin:zoomCenterX:zoomCenterY:zoomOriginX:zoomOriginY:duration:easing:")]
		[DesignatedInitializer]
		IntPtr Constructor(ChartViewPortHandler viewPortHandler, ChartTransformer transformer, ChartViewBase view, ChartYAxis yAxis, double xAxisRange, nfloat scaleX, nfloat scaleY, nfloat xOrigin, nfloat yOrigin, nfloat zoomCenterX, nfloat zoomCenterY, nfloat zoomOriginX, nfloat zoomOriginY, double duration, [NullAllowed] Func<double, double, double> easing);
	}

	// @interface ChartAnimator : NSObject
	[BaseType(typeof(NSObject))]
	interface ChartAnimator
	{
		[Wrap("WeakDelegate")]
		[NullAllowed]
		ChartAnimatorDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<ChartAnimatorDelegate> _Nullable delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (copy, nonatomic) void (^ _Nullable)(void) updateBlock;
		[NullAllowed, Export("updateBlock", ArgumentSemantic.Copy)]
		Action UpdateBlock { get; set; }

		// @property (copy, nonatomic) void (^ _Nullable)(void) stopBlock;
		[NullAllowed, Export("stopBlock", ArgumentSemantic.Copy)]
		Action StopBlock { get; set; }

		// @property (nonatomic) double phaseX;
		[Export("phaseX")]
		double PhaseX { get; set; }

		// @property (nonatomic) double phaseY;
		[Export("phaseY")]
		double PhaseY { get; set; }

		// -(void)stop;
		[Export("stop")]
		void Stop();

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration yAxisDuration:(NSTimeInterval)yAxisDuration easingX:(double (^ _Nullable)(NSTimeInterval, NSTimeInterval))easingX easingY:(double (^ _Nullable)(NSTimeInterval, NSTimeInterval))easingY;
		[Export("animateWithXAxisDuration:yAxisDuration:easingX:easingY:")]
		void AnimateWithXAxisDuration(double xAxisDuration, double yAxisDuration, [NullAllowed] Func<double, double, double> easingX, [NullAllowed] Func<double, double, double> easingY);

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration yAxisDuration:(NSTimeInterval)yAxisDuration easingOptionX:(enum ChartEasingOption)easingOptionX easingOptionY:(enum ChartEasingOption)easingOptionY;
		[Export("animateWithXAxisDuration:yAxisDuration:easingOptionX:easingOptionY:")]
		void AnimateWithXAxisDuration(double xAxisDuration, double yAxisDuration, ChartEasingOption easingOptionX, ChartEasingOption easingOptionY);

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration yAxisDuration:(NSTimeInterval)yAxisDuration easing:(double (^ _Nullable)(NSTimeInterval, NSTimeInterval))easing;
		[Export("animateWithXAxisDuration:yAxisDuration:easing:")]
		void AnimateWithXAxisDuration(double xAxisDuration, double yAxisDuration, [NullAllowed] Func<double, double, double> easing);

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration yAxisDuration:(NSTimeInterval)yAxisDuration easingOption:(enum ChartEasingOption)easingOption;
		[Export("animateWithXAxisDuration:yAxisDuration:easingOption:")]
		void AnimateWithXAxisDuration(double xAxisDuration, double yAxisDuration, ChartEasingOption easingOption);

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration yAxisDuration:(NSTimeInterval)yAxisDuration;
		[Export("animateWithXAxisDuration:yAxisDuration:")]
		void AnimateWithXAxisDuration(double xAxisDuration, double yAxisDuration);

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration easing:(double (^ _Nullable)(NSTimeInterval, NSTimeInterval))easing;
		[Export("animateWithXAxisDuration:easing:")]
		void AnimateWithXAxisDuration(double xAxisDuration, [NullAllowed] Func<double, double, double> easing);

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration easingOption:(enum ChartEasingOption)easingOption;
		[Export("animateWithXAxisDuration:easingOption:")]
		void AnimateWithXAxisDuration(double xAxisDuration, ChartEasingOption easingOption);

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration;
		[Export("animateWithXAxisDuration:")]
		void AnimateWithXAxisDuration(double xAxisDuration);

		// -(void)animateWithYAxisDuration:(NSTimeInterval)yAxisDuration easing:(double (^ _Nullable)(NSTimeInterval, NSTimeInterval))easing;
		[Export("animateWithYAxisDuration:easing:")]
		void AnimateWithYAxisDuration(double yAxisDuration, [NullAllowed] Func<double, double, double> easing);

		// -(void)animateWithYAxisDuration:(NSTimeInterval)yAxisDuration easingOption:(enum ChartEasingOption)easingOption;
		[Export("animateWithYAxisDuration:easingOption:")]
		void AnimateWithYAxisDuration(double yAxisDuration, ChartEasingOption easingOption);

		// -(void)animateWithYAxisDuration:(NSTimeInterval)yAxisDuration;
		[Export("animateWithYAxisDuration:")]
		void AnimateWithYAxisDuration(double yAxisDuration);
	}

	interface IChartAnimatorDelegate { }

	// @protocol ChartAnimatorDelegate
	[BaseType(typeof(NSObject))]
	[Protocol, Model]
	interface ChartAnimatorDelegate
	{
		// @required -(void)animatorUpdated:(ChartAnimator * _Nonnull)animator;
		[Abstract]
		[Export("animatorUpdated:")]
		void AnimatorUpdated(ChartAnimator animator);

		// @required -(void)animatorStopped:(ChartAnimator * _Nonnull)animator;
		[Abstract]
		[Export("animatorStopped:")]
		void AnimatorStopped(ChartAnimator animator);
	}

	// @interface ChartComponentBase : NSObject
	[BaseType(typeof(NSObject))]
	interface ChartComponentBase
	{
		// @property (nonatomic) BOOL enabled;
		[Export("enabled")]
		bool Enabled { get; set; }

		// @property (nonatomic) CGFloat xOffset;
		[Export("xOffset")]
		nfloat XOffset { get; set; }

		// @property (nonatomic) CGFloat yOffset;
		[Export("yOffset")]
		nfloat YOffset { get; set; }

		// @property (readonly, nonatomic) BOOL isEnabled;
		[Export("isEnabled")]
		bool IsEnabled { get; }
	}

	// @interface ChartAxisBase : ChartComponentBase
	[BaseType(typeof(ChartComponentBase))]
	interface ChartAxisBase
	{
		// @property (nonatomic, strong) UIFont * _Nonnull labelFont;
		[Export("labelFont", ArgumentSemantic.Strong)]
		UIFont LabelFont { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull labelTextColor;
		[Export("labelTextColor", ArgumentSemantic.Strong)]
		UIColor LabelTextColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull axisLineColor;
		[Export("axisLineColor", ArgumentSemantic.Strong)]
		UIColor AxisLineColor { get; set; }

		// @property (nonatomic) CGFloat axisLineWidth;
		[Export("axisLineWidth")]
		nfloat AxisLineWidth { get; set; }

		// @property (nonatomic) CGFloat axisLineDashPhase;
		[Export("axisLineDashPhase")]
		nfloat AxisLineDashPhase { get; set; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * _Null_unspecified axisLineDashLengths;
		[Export("axisLineDashLengths", ArgumentSemantic.Copy)]
		NSNumber[] AxisLineDashLengths { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull gridColor;
		[Export("gridColor", ArgumentSemantic.Strong)]
		UIColor GridColor { get; set; }

		// @property (nonatomic) CGFloat gridLineWidth;
		[Export("gridLineWidth")]
		nfloat GridLineWidth { get; set; }

		// @property (nonatomic) CGFloat gridLineDashPhase;
		[Export("gridLineDashPhase")]
		nfloat GridLineDashPhase { get; set; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * _Null_unspecified gridLineDashLengths;
		[Export("gridLineDashLengths", ArgumentSemantic.Copy)]
		NSNumber[] GridLineDashLengths { get; set; }

		// @property (nonatomic) CGLineCap gridLineCap;
		[Export("gridLineCap", ArgumentSemantic.Assign)]
		CGLineCap GridLineCap { get; set; }

		// @property (nonatomic) BOOL drawGridLinesEnabled;
		[Export("drawGridLinesEnabled")]
		bool DrawGridLinesEnabled { get; set; }

		// @property (nonatomic) BOOL drawAxisLineEnabled;
		[Export("drawAxisLineEnabled")]
		bool DrawAxisLineEnabled { get; set; }

		// @property (nonatomic) BOOL drawLabelsEnabled;
		[Export("drawLabelsEnabled")]
		bool DrawLabelsEnabled { get; set; }

		// @property (nonatomic) BOOL centerAxisLabelsEnabled;
		[Export("centerAxisLabelsEnabled")]
		bool CenterAxisLabelsEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isCenterAxisLabelsEnabled;
		[Export("isCenterAxisLabelsEnabled")]
		bool IsCenterAxisLabelsEnabled { get; }

		// @property (nonatomic) BOOL drawLimitLinesBehindDataEnabled;
		[Export("drawLimitLinesBehindDataEnabled")]
		bool DrawLimitLinesBehindDataEnabled { get; set; }

		// @property (nonatomic) BOOL gridAntialiasEnabled;
		[Export("gridAntialiasEnabled")]
		bool GridAntialiasEnabled { get; set; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nonnull entries;
		[Export("entries", ArgumentSemantic.Copy)]
		NSNumber[] Entries { get; set; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nonnull centeredEntries;
		[Export("centeredEntries", ArgumentSemantic.Copy)]
		NSNumber[] CenteredEntries { get; set; }

		// @property (readonly, nonatomic) NSInteger entryCount;
		[Export("entryCount")]
		nint EntryCount { get; }

		// @property (nonatomic) NSInteger decimals;
		[Export("decimals")]
		nint Decimals { get; set; }

		// @property (nonatomic) BOOL granularityEnabled;
		[Export("granularityEnabled")]
		bool GranularityEnabled { get; set; }

		// @property (nonatomic) double granularity;
		[Export("granularity")]
		double Granularity { get; set; }

		// @property (readonly, nonatomic) BOOL isGranularityEnabled;
		[Export("isGranularityEnabled")]
		bool IsGranularityEnabled { get; }

		// @property (nonatomic) BOOL forceLabelsEnabled;
		[Export("forceLabelsEnabled")]
		bool ForceLabelsEnabled { get; set; }

		// -(NSString * _Nonnull)getLongestLabel;
		[Export("getLongestLabel")]
		string LongestLabel { get; }

		// -(NSString * _Nonnull)getFormattedLabel:(NSInteger)index;
		[Export("getFormattedLabel:")]
		string GetFormattedLabel(nint index);

		// @property (nonatomic, strong) id<InterfaceChartAxisValueFormatter> _Nullable valueFormatter;
		[NullAllowed, Export("valueFormatter", ArgumentSemantic.Strong)]
		IInterfaceChartAxisValueFormatter ValueFormatter { get; set; }

		// @property (readonly, nonatomic) BOOL isDrawGridLinesEnabled;
		[Export("isDrawGridLinesEnabled")]
		bool IsDrawGridLinesEnabled { get; }

		// @property (readonly, nonatomic) BOOL isDrawAxisLineEnabled;
		[Export("isDrawAxisLineEnabled")]
		bool IsDrawAxisLineEnabled { get; }

		// @property (readonly, nonatomic) BOOL isDrawLabelsEnabled;
		[Export("isDrawLabelsEnabled")]
		bool IsDrawLabelsEnabled { get; }

		// @property (readonly, nonatomic) BOOL isDrawLimitLinesBehindDataEnabled;
		[Export("isDrawLimitLinesBehindDataEnabled")]
		bool IsDrawLimitLinesBehindDataEnabled { get; }

		// @property (nonatomic) double spaceMin;
		[Export("spaceMin")]
		double SpaceMin { get; set; }

		// @property (nonatomic) double spaceMax;
		[Export("spaceMax")]
		double SpaceMax { get; set; }

		// @property (nonatomic) double axisRange;
		[Export("axisRange")]
		double AxisRange { get; set; }

		// @property (nonatomic) NSInteger labelCount;
		[Export("labelCount")]
		nint LabelCount { get; set; }

		// -(void)setLabelCount:(NSInteger)count force:(BOOL)force;
		[Export("setLabelCount:force:")]
		void SetLabelCount(nint count, bool force);

		// @property (readonly, nonatomic) BOOL isForceLabelsEnabled;
		[Export("isForceLabelsEnabled")]
		bool IsForceLabelsEnabled { get; }

		// -(void)addLimitLine:(ChartLimitLine * _Nonnull)line;
		[Export("addLimitLine:")]
		void AddLimitLine(ChartLimitLine line);

		// -(void)removeLimitLine:(ChartLimitLine * _Nonnull)line;
		[Export("removeLimitLine:")]
		void RemoveLimitLine(ChartLimitLine line);

		// -(void)removeAllLimitLines;
		[Export("removeAllLimitLines")]
		void RemoveAllLimitLines();

		// @property (readonly, copy, nonatomic) NSArray<ChartLimitLine *> * _Nonnull limitLines;
		[Export("limitLines", ArgumentSemantic.Copy)]
		ChartLimitLine[] LimitLines { get; }

		// -(void)resetCustomAxisMin;
		[Export("resetCustomAxisMin")]
		void ResetCustomAxisMin();

		// @property (readonly, nonatomic) BOOL isAxisMinCustom;
		[Export("isAxisMinCustom")]
		bool IsAxisMinCustom { get; }

		// -(void)resetCustomAxisMax;
		[Export("resetCustomAxisMax")]
		void ResetCustomAxisMax();

		// @property (readonly, nonatomic) BOOL isAxisMaxCustom;
		[Export("isAxisMaxCustom")]
		bool IsAxisMaxCustom { get; }

		// @property (nonatomic) double axisMinValue;
		[Export("axisMinValue")]
		double AxisMinValue { get; set; }

		// @property (nonatomic) double axisMaxValue;
		[Export("axisMaxValue")]
		double AxisMaxValue { get; set; }

		// @property (nonatomic) double axisMinimum;
		[Export("axisMinimum")]
		double AxisMinimum { get; set; }

		// @property (nonatomic) double axisMaximum;
		[Export("axisMaximum")]
		double AxisMaximum { get; set; }

		// -(void)calculateWithMin:(double)dataMin max:(double)dataMax;
		[Export("calculateWithMin:max:")]
		void CalculateWithMin(double dataMin, double dataMax);
	}

	// @interface ChartRenderer : NSObject
	[BaseType(typeof(NSObject))]
	interface ChartRenderer
	{
		// @property (nonatomic, strong) ChartViewPortHandler * _Nullable viewPortHandler;
		[NullAllowed, Export("viewPortHandler", ArgumentSemantic.Strong)]
		ChartViewPortHandler ViewPortHandler { get; set; }

		// -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nullable)viewPortHandler __attribute__((objc_designated_initializer));
		[Export("initWithViewPortHandler:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] ChartViewPortHandler viewPortHandler);
	}

	// @interface ChartAxisRendererBase : ChartRenderer
	[BaseType(typeof(ChartRenderer))]
	interface ChartAxisRendererBase
	{
		// @property (nonatomic, strong) ChartAxisBase * _Nullable axis;
		[NullAllowed, Export("axis", ArgumentSemantic.Strong)]
		ChartAxisBase Axis { get; set; }

		// @property (nonatomic, strong) ChartTransformer * _Nullable transformer;
		[NullAllowed, Export("transformer", ArgumentSemantic.Strong)]
		ChartTransformer Transformer { get; set; }

		// -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nullable)viewPortHandler transformer:(ChartTransformer * _Nullable)transformer axis:(ChartAxisBase * _Nullable)axis __attribute__((objc_designated_initializer));
		[Export("initWithViewPortHandler:transformer:axis:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] ChartViewPortHandler viewPortHandler, [NullAllowed] ChartTransformer transformer, [NullAllowed] ChartAxisBase axis);

		//u-n-safe void RenderAxisLabelsWithContext(CGContextRef* context);

		//u-n-safe void RenderGridLinesWithContext(CGContextRef* context);

		//u-n-safe void RenderAxisLineWithContext(CGContextRef* context);

		//u-n-safe void RenderLimitLinesWithContext(CGContextRef* context);

		// -(void)computeAxisWithMin:(double)min max:(double)max inverted:(BOOL)inverted;
		[Export("computeAxisWithMin:max:inverted:")]
		void ComputeAxisWithMin(double min, double max, bool inverted);

		// -(void)computeAxisValuesWithMin:(double)min max:(double)max;
		[Export("computeAxisValuesWithMin:max:")]
		void ComputeAxisValuesWithMin(double min, double max);
	}

	// @interface ChartData : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC6Charts9ChartData")]
	interface ChartData
	{
		// -(instancetype _Nonnull)initWithDataSets:(NSArray<id<IInterfaceChartDataSet>> * _Nullable)dataSets __attribute__((objc_designated_initializer));
		[Export("initWithDataSets:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] IInterfaceChartDataSet[] dataSets);

		// -(instancetype _Nonnull)initWithDataSet:(id<IInterfaceChartDataSet> _Nullable)dataSet;
		[Export("initWithDataSet:")]
		IntPtr Constructor([NullAllowed] IInterfaceChartDataSet dataSet);

		// -(void)notifyDataChanged;
		[Export("notifyDataChanged")]
		void NotifyDataChanged();

		// -(void)calcMinMaxYFromX:(double)fromX toX:(double)toX;
		[Export("calcMinMaxYFromX:toX:")]
		void CalcMinMaxYFromX(double fromX, double toX);

		// -(void)calcMinMax;
		[Export("calcMinMax")]
		void CalcMinMax();

		// -(void)calcMinMaxWithEntry:(ChartDataEntry * _Nonnull)e axis:(enum AxisDependency)axis;
		[Export("calcMinMaxWithEntry:axis:")]
		void CalcMinMaxWithEntry(ChartDataEntry e, AxisDependency axis);

		// -(void)calcMinMaxWithDataSet:(id<IInterfaceChartDataSet> _Nonnull)d;
		[Export("calcMinMaxWithDataSet:")]
		void CalcMinMaxWithDataSet(IInterfaceChartDataSet d);

		// @property (readonly, nonatomic) NSInteger dataSetCount;
		[Export("dataSetCount")]
		nint DataSetCount { get; }

		// @property (readonly, nonatomic) double yMin;
		[Export("yMin")]
		double YMin { get; }

		// -(double)getYMinWithAxis:(enum AxisDependency)axis;
		[Export("getYMinWithAxis:")]
		double GetYMinWithAxis(AxisDependency axis);

		// @property (readonly, nonatomic) double yMax;
		[Export("yMax")]
		double YMax { get; }

		// -(double)getYMaxWithAxis:(enum AxisDependency)axis;
		[Export("getYMaxWithAxis:")]
		double GetYMaxWithAxis(AxisDependency axis);

		// @property (readonly, nonatomic) double xMin;
		[Export("xMin")]
		double XMin { get; }

		// @property (readonly, nonatomic) double xMax;
		[Export("xMax")]
		double XMax { get; }

		// @property (copy, nonatomic) NSArray<id<IInterfaceChartDataSet>> * _Nonnull dataSets;
		[Export("dataSets", ArgumentSemantic.Copy)]
		IInterfaceChartDataSet[] DataSets { get; set; }

		// -(ChartDataEntry * _Nullable)entryForHighlight:(ChartHighlight * _Nonnull)highlight;
		[Export("entryForHighlight:")]
		[return: NullAllowed]
		ChartDataEntry EntryForHighlight(ChartHighlight highlight);

		// -(id<IInterfaceChartDataSet> _Nullable)getDataSetByLabel:(NSString * _Nonnull)label ignorecase:(BOOL)ignorecase;
		[Export("getDataSetByLabel:ignorecase:")]
		[return: NullAllowed]
		IInterfaceChartDataSet GetDataSetByLabel(string label, bool ignorecase);

		// -(id<IInterfaceChartDataSet> _Null_unspecified)getDataSetByIndex:(NSInteger)index;
		[Export("getDataSetByIndex:")]
		IInterfaceChartDataSet GetDataSetByIndex(nint index);

		// -(void)addDataSet:(id<IInterfaceChartDataSet> _Null_unspecified)dataSet;
		[Export("addDataSet:")]
		void AddDataSet(IInterfaceChartDataSet dataSet);

		// -(BOOL)removeDataSet:(id<IInterfaceChartDataSet> _Null_unspecified)dataSet;
		[Export("removeDataSet:")]
		bool RemoveDataSet(IInterfaceChartDataSet dataSet);

		// -(BOOL)removeDataSetByIndex:(NSInteger)index;
		[Export("removeDataSetByIndex:")]
		bool RemoveDataSetByIndex(nint index);

		// -(void)addEntry:(ChartDataEntry * _Nonnull)e dataSetIndex:(NSInteger)dataSetIndex;
		[Export("addEntry:dataSetIndex:")]
		void AddEntry(ChartDataEntry e, nint dataSetIndex);

		// -(BOOL)removeEntry:(ChartDataEntry * _Nonnull)entry dataSetIndex:(NSInteger)dataSetIndex;
		[Export("removeEntry:dataSetIndex:")]
		bool RemoveEntry(ChartDataEntry entry, nint dataSetIndex);

		// -(BOOL)removeEntryWithXValue:(double)xValue dataSetIndex:(NSInteger)dataSetIndex;
		[Export("removeEntryWithXValue:dataSetIndex:")]
		bool RemoveEntryWithXValue(double xValue, nint dataSetIndex);

		// -(id<IInterfaceChartDataSet> _Nullable)getDataSetForEntry:(ChartDataEntry * _Null_unspecified)e;
		[Export("getDataSetForEntry:")]
		[return: NullAllowed]
		IInterfaceChartDataSet GetDataSetForEntry(ChartDataEntry e);

		// -(NSInteger)indexOfDataSet:(id<IInterfaceChartDataSet> _Nonnull)dataSet;
		[Export("indexOfDataSet:")]
		nint IndexOfDataSet(IInterfaceChartDataSet dataSet);

		// -(id<IInterfaceChartDataSet> _Nullable)getFirstLeftWithDataSets:(NSArray<id<IInterfaceChartDataSet>> * _Nonnull)dataSets;
		[Export("getFirstLeftWithDataSets:")]
		[return: NullAllowed]
		IInterfaceChartDataSet GetFirstLeftWithDataSets(IInterfaceChartDataSet[] dataSets);

		// -(id<IInterfaceChartDataSet> _Nullable)getFirstRightWithDataSets:(NSArray<id<IInterfaceChartDataSet>> * _Nonnull)dataSets;
		[Export("getFirstRightWithDataSets:")]
		[return: NullAllowed]
		IInterfaceChartDataSet GetFirstRightWithDataSets(IInterfaceChartDataSet[] dataSets);

		// -(NSArray<UIColor *> * _Nullable)getColors;
		[NullAllowed, Export("getColors")]
		UIColor[] Colors { get; }

		// -(void)setValueFormatter:(id<InterfaceChartValueFormatter> _Nullable)formatter;
		[Export("setValueFormatter:")]
		void SetValueFormatter([NullAllowed] InterfaceChartValueFormatter formatter);

		// -(void)setValueTextColor:(UIColor * _Null_unspecified)color;
		[Export("setValueTextColor:")]
		void SetValueTextColor(UIColor color);

		// -(void)setValueFont:(UIFont * _Null_unspecified)font;
		[Export("setValueFont:")]
		void SetValueFont(UIFont font);

		// -(void)setDrawValues:(BOOL)enabled;
		[Export("setDrawValues:")]
		void SetDrawValues(bool enabled);

		// @property (nonatomic) BOOL highlightEnabled;
		[Export("highlightEnabled")]
		bool HighlightEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isHighlightEnabled;
		[Export("isHighlightEnabled")]
		bool IsHighlightEnabled { get; }

		// -(void)clearValues;
		[Export("clearValues")]
		void ClearValues();

		// -(BOOL)containsWithDataSet:(id<IInterfaceChartDataSet> _Nonnull)dataSet;
		[Export("containsWithDataSet:")]
		bool ContainsWithDataSet(IInterfaceChartDataSet dataSet);

		// @property (readonly, nonatomic) NSInteger entryCount;
		[Export("entryCount")]
		nint EntryCount { get; }

		// @property (readonly, nonatomic, strong) id<IInterfaceChartDataSet> _Nullable maxEntryCountSet;
		[NullAllowed, Export("maxEntryCountSet", ArgumentSemantic.Strong)]
		IInterfaceChartDataSet MaxEntryCountSet { get; }
	}

	// @interface BarLineScatterCandleBubbleChartData : ChartData
	[BaseType(typeof(ChartData), Name = "_TtC6Charts35BarLineScatterCandleBubbleChartData")]
	interface BarLineScatterCandleBubbleChartData
	{
		// -(instancetype _Nonnull)initWithDataSets:(NSArray<id<IInterfaceChartDataSet>> * _Nullable)dataSets __attribute__((objc_designated_initializer));
		[Export("initWithDataSets:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] IInterfaceChartDataSet[] dataSets);
	}

	// @interface BarChartData : BarLineScatterCandleBubbleChartData
	[BaseType(typeof(BarLineScatterCandleBubbleChartData), Name = "_TtC6Charts12BarChartData")]
	interface BarChartData
	{
		// -(instancetype _Nonnull)initWithDataSets:(NSArray<id<IInterfaceChartDataSet>> * _Nullable)dataSets __attribute__((objc_designated_initializer));
		[Export("initWithDataSets:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] IInterfaceChartDataSet[] dataSets);

		// @property (nonatomic) double barWidth;
		[Export("barWidth")]
		double BarWidth { get; set; }

		// -(void)groupBarsFromX:(double)fromX groupSpace:(double)groupSpace barSpace:(double)barSpace;
		[Export("groupBarsFromX:groupSpace:barSpace:")]
		void GroupBarsFromX(double fromX, double groupSpace, double barSpace);

		// -(double)groupWidthWithGroupSpace:(double)groupSpace barSpace:(double)barSpace;
		[Export("groupWidthWithGroupSpace:barSpace:")]
		double GroupWidthWithGroupSpace(double groupSpace, double barSpace);
	}

	// @interface ChartDataEntryBase : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC6Charts18ChartDataEntryBase")]
	interface ChartDataEntryBase
	{
		// @property (nonatomic) double y;
		[Export("y")]
		double Y { get; set; }

		// @property (nonatomic, strong) id _Nullable data;
		[NullAllowed, Export("data", ArgumentSemantic.Strong)]
		NSObject Data { get; set; }

		// -(instancetype _Nonnull)initWithY:(double)y __attribute__((objc_designated_initializer));
		[Export("initWithY:")]
		[DesignatedInitializer]
		IntPtr Constructor(double y);

		// -(instancetype _Nonnull)initWithY:(double)y data:(id _Nullable)data __attribute__((objc_designated_initializer));
		[Export("initWithY:data:")]
		[DesignatedInitializer]
		IntPtr Constructor(double y, [NullAllowed] NSObject data);

		// -(BOOL)isEqual:(id _Nullable)object;
		[Export("isEqual:")]
		bool IsEqual([NullAllowed] NSObject @object);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export("description")]
		string Description { get; }
	}

	// @interface ChartDataEntry : ChartDataEntryBase
	[BaseType(typeof(ChartDataEntryBase), Name = "_TtC6Charts14ChartDataEntry")]
	interface ChartDataEntry
	{
		// @property (nonatomic) double x;
		[Export("x")]
		double X { get; set; }

		// -(instancetype _Nonnull)initWithX:(double)x y:(double)y __attribute__((objc_designated_initializer));
		[Export("initWithX:y:")]
		[DesignatedInitializer]
		IntPtr Constructor(double x, double y);

		// -(instancetype _Nonnull)initWithX:(double)x y:(double)y data:(id _Nullable)data __attribute__((objc_designated_initializer));
		[Export("initWithX:y:data:")]
		[DesignatedInitializer]
		IntPtr Constructor(double x, double y, [NullAllowed] NSObject data);

		// -(BOOL)isEqual:(id _Nullable)object;
		[Export("isEqual:")]
		bool IsEqual([NullAllowed] NSObject @object);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export("description")]
		string Description { get; }

		//u-n-safe NSObject CopyWithZone([NullAllowed] _NSZone* zone);
	}

	// @interface BarChartDataEntry : ChartDataEntry
	[BaseType(typeof(ChartDataEntry), Name = "_TtC6Charts17BarChartDataEntry")]
	interface BarChartDataEntry
	{
		// -(instancetype _Nonnull)initWithX:(double)x yValues:(NSArray<NSNumber *> * _Nonnull)yValues __attribute__((objc_designated_initializer));
		[Export("initWithX:yValues:")]
		[DesignatedInitializer]
		IntPtr Constructor(double x, NSNumber[] yValues);

		// -(instancetype _Nonnull)initWithX:(double)x y:(double)y __attribute__((objc_designated_initializer));
		[Export("initWithX:y:")]
		[DesignatedInitializer]
		IntPtr Constructor(double x, double y);

		// -(instancetype _Nonnull)initWithX:(double)x yValues:(NSArray<NSNumber *> * _Nonnull)yValues label:(NSString * _Nonnull)label __attribute__((objc_designated_initializer));
		[Export("initWithX:yValues:label:")]
		[DesignatedInitializer]
		IntPtr Constructor(double x, NSNumber[] yValues, string label);

		// -(instancetype _Nonnull)initWithX:(double)x y:(double)y data:(id _Nullable)data __attribute__((objc_designated_initializer));
		[Export("initWithX:y:data:")]
		[DesignatedInitializer]
		IntPtr Constructor(double x, double y, [NullAllowed] NSObject data);

		// -(double)sumBelowStackIndex:(NSInteger)stackIndex;
		[Export("sumBelowStackIndex:")]
		double SumBelowStackIndex(nint stackIndex);

		// @property (readonly, nonatomic) double negativeSum;
		[Export("negativeSum")]
		double NegativeSum { get; }

		// @property (readonly, nonatomic) double positiveSum;
		[Export("positiveSum")]
		double PositiveSum { get; }

		// -(void)calcPosNegSum;
		[Export("calcPosNegSum")]
		void CalcPosNegSum();

		// -(void)calcRanges;
		[Export("calcRanges")]
		void CalcRanges();

		// @property (readonly, nonatomic) BOOL isStacked;
		[Export("isStacked")]
		bool IsStacked { get; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nullable yValues;
		[NullAllowed, Export("yValues", ArgumentSemantic.Copy)]
		NSNumber[] YValues { get; set; }

		// @property (readonly, copy, nonatomic) NSArray<ChartRange *> * _Nullable ranges;
		[NullAllowed, Export("ranges", ArgumentSemantic.Copy)]
		ChartRange[] Ranges { get; }

		//u-n-safe NSObject CopyWithZone([NullAllowed] _NSZone* zone);
	}

	interface IChartDataProvider { }

	// @protocol ChartDataProvider
	[Protocol(Name = "_TtP6Charts17ChartDataProvider_"), Model]
	interface ChartDataProvider
	{
		// @required @property (readonly, nonatomic) double chartXMin;
		[Abstract]
		[Export("chartXMin")]
		double ChartXMin { get; }

		// @required @property (readonly, nonatomic) double chartXMax;
		[Abstract]
		[Export("chartXMax")]
		double ChartXMax { get; }

		// @required @property (readonly, nonatomic) double chartYMin;
		[Abstract]
		[Export("chartYMin")]
		double ChartYMin { get; }

		// @required @property (readonly, nonatomic) double chartYMax;
		[Abstract]
		[Export("chartYMax")]
		double ChartYMax { get; }

		// @required @property (readonly, nonatomic) CGFloat maxHighlightDistance;
		[Abstract]
		[Export("maxHighlightDistance")]
		nfloat MaxHighlightDistance { get; }

		// @required @property (readonly, nonatomic) double xRange;
		[Abstract]
		[Export("xRange")]
		double XRange { get; }

		// @required @property (readonly, nonatomic) CGPoint centerOffsets;
		[Abstract]
		[Export("centerOffsets")]
		CGPoint CenterOffsets { get; }

		// @required @property (readonly, nonatomic, strong) ChartData * _Nullable data;
		[Abstract]
		[NullAllowed, Export("data", ArgumentSemantic.Strong)]
		ChartData Data { get; set; }

		// @required @property (readonly, nonatomic) NSInteger maxVisibleCount;
		[Abstract]
		[Export("maxVisibleCount")]
		nint MaxVisibleCount { get; }
	}

	interface IBarLineScatterCandleBubbleChartDataProvider { }

	// @protocol BarLineScatterCandleBubbleChartDataProvider <ChartDataProvider>
	[Protocol(Name = "_TtP6Charts43BarLineScatterCandleBubbleChartDataProvider_"), Model]
	interface BarLineScatterCandleBubbleChartDataProvider : ChartDataProvider
	{
		// @required -(ChartTransformer * _Nonnull)getTransformerForAxis:(enum AxisDependency)forAxis;
		[Abstract]
		[Export("getTransformerForAxis:")]
		ChartTransformer GetTransformerForAxis(AxisDependency forAxis);

		// @required -(BOOL)isInvertedWithAxis:(enum AxisDependency)axis;
		[Abstract]
		[Export("isInvertedWithAxis:")]
		bool IsInvertedWithAxis(AxisDependency axis);

		// @required @property (readonly, nonatomic) double lowestVisibleX;
		[Abstract]
		[Export("lowestVisibleX")]
		double LowestVisibleX { get; }

		// @required @property (readonly, nonatomic) double highestVisibleX;
		[Abstract]
		[Export("highestVisibleX")]
		double HighestVisibleX { get; }
	}

	interface IBarChartDataProvider { }

	// @protocol BarChartDataProvider <BarLineScatterCandleBubbleChartDataProvider>
	[Protocol(Name = "_TtP6Charts20BarChartDataProvider_"), Model]
	interface BarChartDataProvider : BarLineScatterCandleBubbleChartDataProvider
	{
		// @required @property (readonly, nonatomic, strong) BarChartData * _Nullable barData;
		[Abstract]
		[NullAllowed, Export("barData", ArgumentSemantic.Strong)]
		BarChartData BarData { get; }

		// @required @property (readonly, nonatomic) BOOL isDrawBarShadowEnabled;
		[Abstract]
		[Export("isDrawBarShadowEnabled")]
		bool IsDrawBarShadowEnabled { get; }

		// @required @property (readonly, nonatomic) BOOL isDrawValueAboveBarEnabled;
		[Abstract]
		[Export("isDrawValueAboveBarEnabled")]
		bool IsDrawValueAboveBarEnabled { get; }

		// @required @property (readonly, nonatomic) BOOL isHighlightFullBarEnabled;
		[Abstract]
		[Export("isHighlightFullBarEnabled")]
		bool IsHighlightFullBarEnabled { get; }
	}

	interface IInterfaceChartDataSet { }

	// @protocol IInterfaceChartDataSet
	[Protocol(Name = "_TtP6Charts13IChartDataSet_"), Model]
	interface InterfaceChartDataSet
	{
		// @required -(void)notifyDataSetChanged;
		[Abstract]
		[Export("notifyDataSetChanged")]
		void NotifyDataSetChanged();

		// @required -(void)calcMinMax;
		[Abstract]
		[Export("calcMinMax")]
		void CalcMinMax();

		// @required -(void)calcMinMaxYFromX:(double)fromX toX:(double)toX;
		[Abstract]
		[Export("calcMinMaxYFromX:toX:")]
		void CalcMinMaxYFromX(double fromX, double toX);

		// @required @property (readonly, nonatomic) double yMin;
		[Abstract]
		[Export("yMin")]
		double YMin { get; }

		// @required @property (readonly, nonatomic) double yMax;
		[Abstract]
		[Export("yMax")]
		double YMax { get; }

		// @required @property (readonly, nonatomic) double xMin;
		[Abstract]
		[Export("xMin")]
		double XMin { get; }

		// @required @property (readonly, nonatomic) double xMax;
		[Abstract]
		[Export("xMax")]
		double XMax { get; }

		// @required @property (readonly, nonatomic) NSInteger entryCount;
		[Abstract]
		[Export("entryCount")]
		nint EntryCount { get; }

		// @required -(ChartDataEntry * _Nullable)entryForIndex:(NSInteger)i;
		[Abstract]
		[Export("entryForIndex:")]
		[return: NullAllowed]
		ChartDataEntry EntryForIndex(nint i);

		// @required -(ChartDataEntry * _Nullable)entryForXValue:(double)xValue closestToY:(double)yValue rounding:(enum ChartDataSetRounding)rounding;
		[Abstract]
		[Export("entryForXValue:closestToY:rounding:")]
		[return: NullAllowed]
		ChartDataEntry EntryForXValue(double xValue, double yValue, ChartDataSetRounding rounding);

		// @required -(ChartDataEntry * _Nullable)entryForXValue:(double)xValue closestToY:(double)yValue;
		[Abstract]
		[Export("entryForXValue:closestToY:")]
		[return: NullAllowed]
		ChartDataEntry EntryForXValue(double xValue, double yValue);

		// @required -(NSArray<ChartDataEntry *> * _Nonnull)entriesForXValue:(double)xValue;
		[Abstract]
		[Export("entriesForXValue:")]
		ChartDataEntry[] EntriesForXValue(double xValue);

		// @required -(NSInteger)entryIndexWithX:(double)xValue closestToY:(double)yValue rounding:(enum ChartDataSetRounding)rounding;
		[Abstract]
		[Export("entryIndexWithX:closestToY:rounding:")]
		nint EntryIndexWithX(double xValue, double yValue, ChartDataSetRounding rounding);

		// @required -(NSInteger)entryIndexWithEntry:(ChartDataEntry * _Nonnull)e;
		[Abstract]
		[Export("entryIndexWithEntry:")]
		nint EntryIndexWithEntry(ChartDataEntry e);

		// @required -(BOOL)addEntry:(ChartDataEntry * _Nonnull)e;
		[Abstract]
		[Export("addEntry:")]
		bool AddEntry(ChartDataEntry e);

		// @required -(BOOL)addEntryOrdered:(ChartDataEntry * _Nonnull)e;
		[Abstract]
		[Export("addEntryOrdered:")]
		bool AddEntryOrdered(ChartDataEntry e);

		// @required -(BOOL)removeEntry:(ChartDataEntry * _Nonnull)entry;
		[Abstract]
		[Export("removeEntry:")]
		bool RemoveEntry(ChartDataEntry entry);

		// @required -(BOOL)removeEntryWithIndex:(NSInteger)index;
		[Abstract]
		[Export("removeEntryWithIndex:")]
		bool RemoveEntryWithIndex(nint index);

		// @required -(BOOL)removeEntryWithX:(double)x;
		[Abstract]
		[Export("removeEntryWithX:")]
		bool RemoveEntryWithX(double x);

		// @required -(BOOL)removeFirst;
		[Abstract]
		[Export("removeFirst")]
		bool RemoveFirst { get; }

		// @required -(BOOL)removeLast;
		[Abstract]
		[Export("removeLast")]
		bool RemoveLast { get; }

		// @required -(BOOL)contains:(ChartDataEntry * _Nonnull)e;
		[Abstract]
		[Export("contains:")]
		bool Contains(ChartDataEntry e);

		// @required -(void)clear;
		[Abstract]
		[Export("clear")]
		void Clear();

		// @required @property (readonly, copy, nonatomic) NSString * _Nullable label;
		[Abstract]
		[NullAllowed, Export("label")]
		string Label { get; }

		// @required @property (readonly, nonatomic) enum AxisDependency axisDependency;
		[Abstract]
		[Export("axisDependency")]
		AxisDependency AxisDependency { get; set; }

		// @required @property (readonly, copy, nonatomic) NSArray<UIColor *> * _Nonnull valueColors;
		[Abstract]
		[Export("valueColors", ArgumentSemantic.Copy)]
		UIColor[] ValueColors { get; }

		// @required @property (readonly, copy, nonatomic) NSArray<UIColor *> * _Nonnull colors;
		[Abstract]
		[Export("colors", ArgumentSemantic.Copy)]
		UIColor[] Colors { get; set; }

		// @required -(UIColor * _Nonnull)colorAtIndex:(NSInteger)atIndex;
		[Abstract]
		[Export("colorAtIndex:")]
		UIColor ColorAtIndex(nint atIndex);

		// @required -(void)resetColors;
		[Abstract]
		[Export("resetColors")]
		void ResetColors();

		// @required -(void)addColor:(UIColor * _Nonnull)color;
		[Abstract]
		[Export("addColor:")]
		void AddColor(UIColor color);

		// @required -(void)setColor:(UIColor * _Nonnull)color;
		[Abstract]
		[Export("setColor:")]
		void SetColor(UIColor color);

		// @required @property (nonatomic) BOOL highlightEnabled;
		[Abstract]
		[Export("highlightEnabled")]
		bool HighlightEnabled { get; set; }

		// @required @property (readonly, nonatomic) BOOL isHighlightEnabled;
		[Abstract]
		[Export("isHighlightEnabled")]
		bool IsHighlightEnabled { get; }

		// @required @property (nonatomic, strong) id<InterfaceChartValueFormatter> _Nullable valueFormatter;
		[Abstract]
		[NullAllowed, Export("valueFormatter", ArgumentSemantic.Strong)]
		IInterfaceChartValueFormatter ValueFormatter { get; set; }

		// @required @property (readonly, nonatomic) BOOL needsFormatter;
		[Abstract]
		[Export("needsFormatter")]
		bool NeedsFormatter { get; }

		// @required @property (nonatomic, strong) UIColor * _Nonnull valueTextColor;
		[Abstract]
		[Export("valueTextColor", ArgumentSemantic.Strong)]
		UIColor ValueTextColor { get; set; }

		// @required -(UIColor * _Nonnull)valueTextColorAt:(NSInteger)index;
		[Abstract]
		[Export("valueTextColorAt:")]
		UIColor ValueTextColorAt(nint index);

		// @required @property (nonatomic, strong) UIFont * _Nonnull valueFont;
		[Abstract]
		[Export("valueFont", ArgumentSemantic.Strong)]
		UIFont ValueFont { get; set; }

		// @required @property (readonly, nonatomic) enum ChartLegendForm form;
		[Abstract]
		[Export("form")]
		ChartLegendForm Form { get; }

		// @required @property (readonly, nonatomic) CGFloat formSize;
		[Abstract]
		[Export("formSize")]
		nfloat FormSize { get; }

		// @required @property (readonly, nonatomic) CGFloat formLineWidth;
		[Abstract]
		[Export("formLineWidth")]
		nfloat FormLineWidth { get; }

		// @required @property (readonly, nonatomic) CGFloat formLineDashPhase;
		[Abstract]
		[Export("formLineDashPhase")]
		nfloat FormLineDashPhase { get; }

		// @required @property (readonly, copy, nonatomic) NSArray<NSNumber *> * _Nullable formLineDashLengths;
		[Abstract]
		[NullAllowed, Export("formLineDashLengths", ArgumentSemantic.Copy)]
		NSNumber[] FormLineDashLengths { get; }

		// @required @property (nonatomic) BOOL drawValuesEnabled;
		[Abstract]
		[Export("drawValuesEnabled")]
		bool DrawValuesEnabled { get; set; }

		// @required @property (readonly, nonatomic) BOOL isDrawValuesEnabled;
		[Abstract]
		[Export("isDrawValuesEnabled")]
		bool IsDrawValuesEnabled { get; }

		// @required @property (nonatomic) BOOL visible;
		[Abstract]
		[Export("visible")]
		bool Visible { get; set; }

		// @required @property (readonly, nonatomic) BOOL isVisible;
		[Abstract]
		[Export("isVisible")]
		bool IsVisible { get; }
	}

	interface IInterfaceBarLineScatterCandleBubbleChartDataSet { }

	// @protocol IInterfaceBarLineScatterCandleBubbleChartDataSet <IInterfaceChartDataSet>
	[Protocol(Name = "_TtP6Charts39IBarLineScatterCandleBubbleChartDataSet_"), Model]
	interface InterfaceBarLineScatterCandleBubbleChartDataSet : InterfaceChartDataSet
	{
		// @required @property (nonatomic, strong) UIColor * _Nonnull highlightColor;
		[Abstract]
		[Export("highlightColor", ArgumentSemantic.Strong)]
		UIColor HighlightColor { get; set; }

		// @required @property (nonatomic) CGFloat highlightLineWidth;
		[Abstract]
		[Export("highlightLineWidth")]
		nfloat HighlightLineWidth { get; set; }

		// @required @property (nonatomic) CGFloat highlightLineDashPhase;
		[Abstract]
		[Export("highlightLineDashPhase")]
		nfloat HighlightLineDashPhase { get; set; }

		// @required @property (copy, nonatomic) NSArray<NSNumber *> * _Nullable highlightLineDashLengths;
		[Abstract]
		[NullAllowed, Export("highlightLineDashLengths", ArgumentSemantic.Copy)]
		NSNumber[] HighlightLineDashLengths { get; set; }
	}

	interface IInterfaceBarChartDataSet { }

	// @protocol IInterfaceBarChartDataSet <IInterfaceBarLineScatterCandleBubbleChartDataSet>
	[Protocol(Name = "_TtP6Charts16IBarChartDataSet_"), Model]
	interface InterfaceBarChartDataSet : InterfaceBarLineScatterCandleBubbleChartDataSet
	{
		// @required @property (readonly, nonatomic) BOOL isStacked;
		[Abstract]
		[Export("isStacked")]
		bool IsStacked { get; }

		// @required @property (readonly, nonatomic) NSInteger stackSize;
		[Abstract]
		[Export("stackSize")]
		nint StackSize { get; }

		// @required @property (nonatomic, strong) UIColor * _Nonnull barShadowColor;
		[Abstract]
		[Export("barShadowColor", ArgumentSemantic.Strong)]
		UIColor BarShadowColor { get; set; }

		// @required @property (nonatomic) CGFloat barBorderWidth;
		[Abstract]
		[Export("barBorderWidth")]
		nfloat BarBorderWidth { get; set; }

		// @required @property (nonatomic, strong) UIColor * _Nonnull barBorderColor;
		[Abstract]
		[Export("barBorderColor", ArgumentSemantic.Strong)]
		UIColor BarBorderColor { get; set; }

		// @required @property (nonatomic) CGFloat highlightAlpha;
		[Abstract]
		[Export("highlightAlpha")]
		nfloat HighlightAlpha { get; set; }

		// @required @property (copy, nonatomic) NSArray<NSString *> * _Nonnull stackLabels;
		[Abstract]
		[Export("stackLabels", ArgumentSemantic.Copy)]
		string[] StackLabels { get; set; }
	}

	// @interface ChartBaseDataSet : NSObject <IInterfaceChartDataSet>
	[BaseType(typeof(NSObject), Name = "_TtC6Charts16ChartBaseDataSet")]
	interface ChartBaseDataSet : InterfaceChartDataSet
	{
		// -(instancetype _Nonnull)initWithLabel:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
		[Export("initWithLabel:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] string label);

		// -(void)notifyDataSetChanged;
		[Export("notifyDataSetChanged")]
		void NotifyDataSetChanged();

		// -(void)calcMinMax;
		[Export("calcMinMax")]
		void CalcMinMax();

		// -(void)calcMinMaxYFromX:(double)fromX toX:(double)toX;
		[Export("calcMinMaxYFromX:toX:")]
		void CalcMinMaxYFromX(double fromX, double toX);

		// @property (readonly, nonatomic) double yMin;
		[Export("yMin")]
		double YMin { get; }

		// @property (readonly, nonatomic) double yMax;
		[Export("yMax")]
		double YMax { get; }

		// @property (readonly, nonatomic) double xMin;
		[Export("xMin")]
		double XMin { get; }

		// @property (readonly, nonatomic) double xMax;
		[Export("xMax")]
		double XMax { get; }

		// @property (readonly, nonatomic) NSInteger entryCount;
		[Export("entryCount")]
		nint EntryCount { get; }

		// -(ChartDataEntry * _Nullable)entryForIndex:(NSInteger)i;
		[Export("entryForIndex:")]
		[return: NullAllowed]
		ChartDataEntry EntryForIndex(nint i);

		// -(ChartDataEntry * _Nullable)entryForXValue:(double)x closestToY:(double)y rounding:(enum ChartDataSetRounding)rounding;
		[Export("entryForXValue:closestToY:rounding:")]
		[return: NullAllowed]
		ChartDataEntry EntryForXValue(double x, double y, ChartDataSetRounding rounding);

		// -(ChartDataEntry * _Nullable)entryForXValue:(double)x closestToY:(double)y;
		[Export("entryForXValue:closestToY:")]
		[return: NullAllowed]
		ChartDataEntry EntryForXValue(double x, double y);

		// -(NSArray<ChartDataEntry *> * _Nonnull)entriesForXValue:(double)x;
		[Export("entriesForXValue:")]
		ChartDataEntry[] EntriesForXValue(double x);

		// -(NSInteger)entryIndexWithX:(double)xValue closestToY:(double)y rounding:(enum ChartDataSetRounding)rounding;
		[Export("entryIndexWithX:closestToY:rounding:")]
		nint EntryIndexWithX(double xValue, double y, ChartDataSetRounding rounding);

		// -(NSInteger)entryIndexWithEntry:(ChartDataEntry * _Nonnull)e;
		[Export("entryIndexWithEntry:")]
		nint EntryIndexWithEntry(ChartDataEntry e);

		// -(BOOL)addEntry:(ChartDataEntry * _Nonnull)e;
		[Export("addEntry:")]
		bool AddEntry(ChartDataEntry e);

		// -(BOOL)addEntryOrdered:(ChartDataEntry * _Nonnull)e;
		[Export("addEntryOrdered:")]
		bool AddEntryOrdered(ChartDataEntry e);

		// -(BOOL)removeEntry:(ChartDataEntry * _Nonnull)entry;
		[Export("removeEntry:")]
		bool RemoveEntry(ChartDataEntry entry);

		// -(BOOL)removeEntryWithIndex:(NSInteger)index;
		[Export("removeEntryWithIndex:")]
		bool RemoveEntryWithIndex(nint index);

		// -(BOOL)removeEntryWithX:(double)x;
		[Export("removeEntryWithX:")]
		bool RemoveEntryWithX(double x);

		// -(BOOL)removeFirst;
		[Export("removeFirst")]
		bool RemoveFirst { get; }

		// -(BOOL)removeLast;
		[Export("removeLast")]
		bool RemoveLast { get; }

		// -(BOOL)contains:(ChartDataEntry * _Nonnull)e;
		[Export("contains:")]
		bool Contains(ChartDataEntry e);

		// -(void)clear;
		[Export("clear")]
		void Clear();

		// @property (copy, nonatomic) NSArray<UIColor *> * _Nonnull colors;
		[Export("colors", ArgumentSemantic.Copy)]
		UIColor[] Colors { get; set; }

		// @property (copy, nonatomic) NSArray<UIColor *> * _Nonnull valueColors;
		[Export("valueColors", ArgumentSemantic.Copy)]
		UIColor[] ValueColors { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable label;
		[NullAllowed, Export("label")]
		string Label { get; set; }

		// @property (nonatomic) enum AxisDependency axisDependency;
		[Export("axisDependency", ArgumentSemantic.Assign)]
		AxisDependency AxisDependency { get; set; }

		// -(UIColor * _Nonnull)colorAtIndex:(NSInteger)index;
		[Export("colorAtIndex:")]
		UIColor ColorAtIndex(nint index);

		// -(void)resetColors;
		[Export("resetColors")]
		void ResetColors();

		// -(void)addColor:(UIColor * _Nonnull)color;
		[Export("addColor:")]
		void AddColor(UIColor color);

		// -(void)setColor:(UIColor * _Nonnull)color;
		[Export("setColor:")]
		void SetColor(UIColor color);

		// -(void)setColor:(UIColor * _Nonnull)color alpha:(CGFloat)alpha;
		[Export("setColor:alpha:")]
		void SetColor(UIColor color, nfloat alpha);

		// -(void)setColors:(NSArray<UIColor *> * _Nonnull)colors alpha:(CGFloat)alpha;
		[Export("setColors:alpha:")]
		void SetColors(UIColor[] colors, nfloat alpha);

		// @property (nonatomic) BOOL highlightEnabled;
		[Export("highlightEnabled")]
		bool HighlightEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isHighlightEnabled;
		[Export("isHighlightEnabled")]
		bool IsHighlightEnabled { get; }

		// @property (nonatomic, strong) id<InterfaceChartValueFormatter> _Nullable valueFormatter;
		[NullAllowed, Export("valueFormatter", ArgumentSemantic.Strong)]
		IInterfaceChartValueFormatter ValueFormatter { get; set; }

		// @property (readonly, nonatomic) BOOL needsFormatter;
		[Export("needsFormatter")]
		bool NeedsFormatter { get; }

		// @property (nonatomic, strong) UIColor * _Nonnull valueTextColor;
		[Export("valueTextColor", ArgumentSemantic.Strong)]
		UIColor ValueTextColor { get; set; }

		// -(UIColor * _Nonnull)valueTextColorAt:(NSInteger)index;
		[Export("valueTextColorAt:")]
		UIColor ValueTextColorAt(nint index);

		// @property (nonatomic, strong) UIFont * _Nonnull valueFont;
		[Export("valueFont", ArgumentSemantic.Strong)]
		UIFont ValueFont { get; set; }

		// @property (nonatomic) enum ChartLegendForm form;
		[Export("form", ArgumentSemantic.Assign)]
		ChartLegendForm Form { get; set; }

		// @property (nonatomic) CGFloat formSize;
		[Export("formSize")]
		nfloat FormSize { get; set; }

		// @property (nonatomic) CGFloat formLineWidth;
		[Export("formLineWidth")]
		nfloat FormLineWidth { get; set; }

		// @property (nonatomic) CGFloat formLineDashPhase;
		[Export("formLineDashPhase")]
		nfloat FormLineDashPhase { get; set; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nullable formLineDashLengths;
		[NullAllowed, Export("formLineDashLengths", ArgumentSemantic.Copy)]
		NSNumber[] FormLineDashLengths { get; set; }

		// @property (nonatomic) BOOL drawValuesEnabled;
		[Export("drawValuesEnabled")]
		bool DrawValuesEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isDrawValuesEnabled;
		[Export("isDrawValuesEnabled")]
		bool IsDrawValuesEnabled { get; }

		// @property (nonatomic) BOOL visible;
		[Export("visible")]
		bool Visible { get; set; }

		// @property (readonly, nonatomic) BOOL isVisible;
		[Export("isVisible")]
		bool IsVisible { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export("description")]
		string Description { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
		[Export("debugDescription")]
		string DebugDescription { get; }

		//u-n-safe NSObject CopyWithZone([NullAllowed] _NSZone* zone);
	}

	// @interface ChartDataSet : ChartBaseDataSet
	[BaseType(typeof(ChartBaseDataSet), Name = "_TtC6Charts12ChartDataSet")]
	interface ChartDataSet
	{
		// -(instancetype _Nonnull)initWithLabel:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
		[Export("initWithLabel:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] string label);

		// -(instancetype _Nonnull)initWithValues:(NSArray<ChartDataEntry *> * _Nullable)values label:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
		[Export("initWithValues:label:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] ChartDataEntry[] values, [NullAllowed] string label);

		// -(instancetype _Nonnull)initWithValues:(NSArray<ChartDataEntry *> * _Nullable)values;
		[Export("initWithValues:")]
		IntPtr Constructor([NullAllowed] ChartDataEntry[] values);

		// @property (copy, nonatomic) NSArray<ChartDataEntry *> * _Nonnull values;
		[Export("values", ArgumentSemantic.Copy)]
		ChartDataEntry[] Values { get; set; }

		// -(void)notifyDataSetChanged;
		[Export("notifyDataSetChanged")]
		void NotifyDataSetChanged();

		// -(void)calcMinMax;
		[Export("calcMinMax")]
		void CalcMinMax();

		// -(void)calcMinMaxYFromX:(double)fromX toX:(double)toX;
		[Export("calcMinMaxYFromX:toX:")]
		void CalcMinMaxYFromX(double fromX, double toX);

		// -(void)calcMinMaxXWithEntry:(ChartDataEntry * _Nonnull)e;
		[Export("calcMinMaxXWithEntry:")]
		void CalcMinMaxXWithEntry(ChartDataEntry e);

		// -(void)calcMinMaxYWithEntry:(ChartDataEntry * _Nonnull)e;
		[Export("calcMinMaxYWithEntry:")]
		void CalcMinMaxYWithEntry(ChartDataEntry e);

		// @property (readonly, nonatomic) double yMin;
		[Export("yMin")]
		double YMin { get; }

		// @property (readonly, nonatomic) double yMax;
		[Export("yMax")]
		double YMax { get; }

		// @property (readonly, nonatomic) double xMin;
		[Export("xMin")]
		double XMin { get; }

		// @property (readonly, nonatomic) double xMax;
		[Export("xMax")]
		double XMax { get; }

		// @property (readonly, nonatomic) NSInteger entryCount;
		[Export("entryCount")]
		nint EntryCount { get; }

		// -(ChartDataEntry * _Nullable)entryForIndex:(NSInteger)i;
		[Export("entryForIndex:")]
		[return: NullAllowed]
		ChartDataEntry EntryForIndex(nint i);

		// -(ChartDataEntry * _Nullable)entryForXValue:(double)xValue closestToY:(double)yValue rounding:(enum ChartDataSetRounding)rounding;
		[Export("entryForXValue:closestToY:rounding:")]
		[return: NullAllowed]
		ChartDataEntry EntryForXValue(double xValue, double yValue, ChartDataSetRounding rounding);

		// -(ChartDataEntry * _Nullable)entryForXValue:(double)xValue closestToY:(double)yValue;
		[Export("entryForXValue:closestToY:")]
		[return: NullAllowed]
		ChartDataEntry EntryForXValue(double xValue, double yValue);

		// -(NSArray<ChartDataEntry *> * _Nonnull)entriesForXValue:(double)xValue;
		[Export("entriesForXValue:")]
		ChartDataEntry[] EntriesForXValue(double xValue);

		// -(NSInteger)entryIndexWithX:(double)xValue closestToY:(double)yValue rounding:(enum ChartDataSetRounding)rounding;
		[Export("entryIndexWithX:closestToY:rounding:")]
		nint EntryIndexWithX(double xValue, double yValue, ChartDataSetRounding rounding);

		// -(NSInteger)entryIndexWithEntry:(ChartDataEntry * _Nonnull)e;
		[Export("entryIndexWithEntry:")]
		nint EntryIndexWithEntry(ChartDataEntry e);

		// -(BOOL)addEntry:(ChartDataEntry * _Nonnull)e;
		[Export("addEntry:")]
		bool AddEntry(ChartDataEntry e);

		// -(BOOL)addEntryOrdered:(ChartDataEntry * _Nonnull)e;
		[Export("addEntryOrdered:")]
		bool AddEntryOrdered(ChartDataEntry e);

		// -(BOOL)removeEntry:(ChartDataEntry * _Nonnull)entry;
		[Export("removeEntry:")]
		bool RemoveEntry(ChartDataEntry entry);

		// -(BOOL)removeFirst;
		[Export("removeFirst")]
		bool RemoveFirst { get; }

		// -(BOOL)removeLast;
		[Export("removeLast")]
		bool RemoveLast { get; }

		// -(BOOL)contains:(ChartDataEntry * _Nonnull)e;
		[Export("contains:")]
		bool Contains(ChartDataEntry e);

		// -(void)clear;
		[Export("clear")]
		void Clear();

		//u-n-safe NSObject CopyWithZone([NullAllowed] _NSZone* zone);
	}

	// @interface BarLineScatterCandleBubbleChartDataSet : ChartDataSet <IInterfaceBarLineScatterCandleBubbleChartDataSet>
	[BaseType(typeof(ChartDataSet), Name = "_TtC6Charts38BarLineScatterCandleBubbleChartDataSet")]
	interface BarLineScatterCandleBubbleChartDataSet : InterfaceBarLineScatterCandleBubbleChartDataSet
	{
		// @property (nonatomic, strong) UIColor * _Nonnull highlightColor;
		[Export("highlightColor", ArgumentSemantic.Strong)]
		UIColor HighlightColor { get; set; }

		// @property (nonatomic) CGFloat highlightLineWidth;
		[Export("highlightLineWidth")]
		nfloat HighlightLineWidth { get; set; }

		// @property (nonatomic) CGFloat highlightLineDashPhase;
		[Export("highlightLineDashPhase")]
		nfloat HighlightLineDashPhase { get; set; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nullable highlightLineDashLengths;
		[NullAllowed, Export("highlightLineDashLengths", ArgumentSemantic.Copy)]
		NSNumber[] HighlightLineDashLengths { get; set; }

		//u-n-safe NSObject CopyWithZone([NullAllowed] _NSZone* zone);

		// -(instancetype _Nonnull)initWithLabel:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
		[Export("initWithLabel:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] string label);

		// -(instancetype _Nonnull)initWithValues:(NSArray<ChartDataEntry *> * _Nullable)values label:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
		[Export("initWithValues:label:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] ChartDataEntry[] values, [NullAllowed] string label);
	}

	// @interface BarChartDataSet : BarLineScatterCandleBubbleChartDataSet <IInterfaceBarChartDataSet>
	[BaseType(typeof(BarLineScatterCandleBubbleChartDataSet), Name = "_TtC6Charts15BarChartDataSet")]
	interface BarChartDataSet : InterfaceBarChartDataSet
	{
		// -(instancetype _Nonnull)initWithValues:(NSArray<ChartDataEntry *> * _Nullable)values label:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
		[Export("initWithValues:label:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] ChartDataEntry[] values, [NullAllowed] string label);

		// -(void)calcMinMaxWithEntry:(ChartDataEntry * _Nonnull)e;
		[Export("calcMinMaxWithEntry:")]
		void CalcMinMaxWithEntry(ChartDataEntry e);

		// @property (readonly, nonatomic) NSInteger stackSize;
		[Export("stackSize")]
		nint StackSize { get; }

		// @property (readonly, nonatomic) BOOL isStacked;
		[Export("isStacked")]
		bool IsStacked { get; }

		// @property (readonly, nonatomic) NSInteger entryCountStacks;
		[Export("entryCountStacks")]
		nint EntryCountStacks { get; }

		// @property (copy, nonatomic) NSArray<NSString *> * _Nonnull stackLabels;
		[Export("stackLabels", ArgumentSemantic.Copy)]
		string[] StackLabels { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull barShadowColor;
		[Export("barShadowColor", ArgumentSemantic.Strong)]
		UIColor BarShadowColor { get; set; }

		// @property (nonatomic) CGFloat barBorderWidth;
		[Export("barBorderWidth")]
		nfloat BarBorderWidth { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull barBorderColor;
		[Export("barBorderColor", ArgumentSemantic.Strong)]
		UIColor BarBorderColor { get; set; }

		// @property (nonatomic) CGFloat highlightAlpha;
		[Export("highlightAlpha")]
		nfloat HighlightAlpha { get; set; }

		//u-n-safe NSObject CopyWithZone([NullAllowed] _NSZone* zone);
	}

	// @interface ChartDataRendererBase : ChartRenderer
	[BaseType(typeof(ChartRenderer))]
	[DisableDefaultCtor]
	interface ChartDataRendererBase
	{
		// @property (nonatomic, strong) ChartAnimator * _Nullable animator;
		[NullAllowed, Export("animator", ArgumentSemantic.Strong)]
		ChartAnimator Animator { get; set; }

		// -(instancetype _Nonnull)initWithAnimator:(ChartAnimator * _Nullable)animator viewPortHandler:(ChartViewPortHandler * _Nullable)viewPortHandler __attribute__((objc_designated_initializer));
		[Export("initWithAnimator:viewPortHandler:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] ChartAnimator animator, [NullAllowed] ChartViewPortHandler viewPortHandler);

		//u-n-safe void DrawDataWithContext(CGContextRef* context);

		//u-n-safe void DrawValuesWithContext(CGContextRef* context);

		//u-n-safe void DrawExtrasWithContext(CGContextRef* context);

		//u-n-safe void DrawHighlightedWithContext(CGContextRef* context, ChartHighlight[] indices);

		// -(void)initBuffers __attribute__((objc_method_family("none")));
		[Export("initBuffers")]
		void InitBuffers();

		// -(BOOL)isDrawingValuesAllowedWithDataProvider:(id<ChartDataProvider> _Nullable)dataProvider;
		[Export("isDrawingValuesAllowedWithDataProvider:")]
		bool IsDrawingValuesAllowedWithDataProvider([NullAllowed] IChartDataProvider dataProvider);
	}

	// @interface BarLineScatterCandleBubbleChartRenderer : ChartDataRendererBase
	[BaseType(typeof(ChartDataRendererBase))]
	interface BarLineScatterCandleBubbleChartRenderer
	{
		// -(instancetype _Nonnull)initWithAnimator:(ChartAnimator * _Nullable)animator viewPortHandler:(ChartViewPortHandler * _Nullable)viewPortHandler __attribute__((objc_designated_initializer));
		[Export("initWithAnimator:viewPortHandler:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] ChartAnimator animator, [NullAllowed] ChartViewPortHandler viewPortHandler);
	}

	// @interface BarChartRenderer : BarLineScatterCandleBubbleChartRenderer
	[BaseType(typeof(BarLineScatterCandleBubbleChartRenderer), Name = "_TtC6Charts16BarChartRenderer")]
	interface BarChartRenderer
	{
		// @property (nonatomic, weak) id<BarChartDataProvider> _Nullable dataProvider;
		[NullAllowed, Export("dataProvider", ArgumentSemantic.Weak)]
		IBarChartDataProvider DataProvider { get; set; }

		// -(instancetype _Nonnull)initWithDataProvider:(id<BarChartDataProvider> _Nullable)dataProvider animator:(ChartAnimator * _Nullable)animator viewPortHandler:(ChartViewPortHandler * _Nullable)viewPortHandler __attribute__((objc_designated_initializer));
		[Export("initWithDataProvider:animator:viewPortHandler:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] IBarChartDataProvider dataProvider, [NullAllowed] ChartAnimator animator, [NullAllowed] ChartViewPortHandler viewPortHandler);

		// -(void)initBuffers __attribute__((objc_method_family("none")));
		[Export("initBuffers")]
		void InitBuffers();

		//u-n-safe void DrawDataWithContext(CGContextRef* context);

		//u-n-safe void DrawDataSetWithContext(CGContextRef* context, IInterfaceBarChartDataSet dataSet, nint index);

		//u-n-safe void DrawValuesWithContext(CGContextRef* context);

		//u-n-safe void DrawValueWithContext(CGContextRef* context, string value, nfloat xPos, nfloat yPos, UIFont font, NSTextAlignment align, UIColor color);

		//u-n-safe void DrawExtrasWithContext(CGContextRef* context);

		//u-n-safe void DrawHighlightedWithContext(CGContextRef* context, ChartHighlight[] indices);
	}

	// @interface NSUIView : UIView
	[BaseType(typeof(UIView), Name = "_TtC6Charts8NSUIView")]
	interface NSUIView
	{
		// -(void)touchesBegan:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event;
		[Export("touchesBegan:withEvent:")]
		void TouchesBegan(NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

		// -(void)touchesMoved:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event;
		[Export("touchesMoved:withEvent:")]
		void TouchesMoved(NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

		// -(void)touchesEnded:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event;
		[Export("touchesEnded:withEvent:")]
		void TouchesEnded(NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

		// -(void)touchesCancelled:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event;
		[Export("touchesCancelled:withEvent:")]
		void TouchesCancelled(NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

		// -(void)nsuiTouchesBegan:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event;
		[Export("nsuiTouchesBegan:withEvent:")]
		void NsuiTouchesBegan(NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

		// -(void)nsuiTouchesMoved:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event;
		[Export("nsuiTouchesMoved:withEvent:")]
		void NsuiTouchesMoved(NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

		// -(void)nsuiTouchesEnded:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event;
		[Export("nsuiTouchesEnded:withEvent:")]
		void NsuiTouchesEnded(NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

		// -(void)nsuiTouchesCancelled:(NSSet<UITouch *> * _Nullable)touches withEvent:(UIEvent * _Nullable)event;
		[Export("nsuiTouchesCancelled:withEvent:")]
		void NsuiTouchesCancelled([NullAllowed] NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor(CGRect frame);

		//// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		//[Export("initWithCoder:")]
		//[DesignatedInitializer]
		//IntPtr Constructor(NSCoder aDecoder);
	}

	// @interface ChartViewBase : NSUIView <ChartDataProvider, ChartAnimatorDelegate>
	[BaseType(typeof(NSUIView), Name = "_TtC6Charts13ChartViewBase")]
	interface ChartViewBase : IChartDataProvider, IChartAnimatorDelegate
	{
		// @property (readonly, nonatomic, strong) ChartXAxis * _Nonnull xAxis;
		[Export("xAxis", ArgumentSemantic.Strong)]
		ChartXAxis XAxis { get; }

		// @property (nonatomic) BOOL dragDecelerationEnabled;
		[Export("dragDecelerationEnabled")]
		bool DragDecelerationEnabled { get; set; }

		// @property (nonatomic, strong) ChartDescription * _Nullable chartDescription;
		[NullAllowed, Export("chartDescription", ArgumentSemantic.Strong)]
		ChartDescription ChartDescription { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull descriptionText;
		[Export("descriptionText")]
		string DescriptionText { get; set; }

		// @property (nonatomic, strong) UIFont * _Nullable descriptionFont;
		[NullAllowed, Export("descriptionFont", ArgumentSemantic.Strong)]
		UIFont DescriptionFont { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable descriptionTextColor;
		[NullAllowed, Export("descriptionTextColor", ArgumentSemantic.Strong)]
		UIColor DescriptionTextColor { get; set; }

		//// @property (nonatomic) NSTextAlignment descriptionTextAlign;
		//[Export("descriptionTextAlign", ArgumentSemantic.Assign)]
		//NSTextAlignment DescriptionTextAlign { get; set; }

		[Wrap("WeakDelegate")]
		[NullAllowed]
		ChartViewDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<ChartViewDelegate> _Nullable delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull noDataText;
		[Export("noDataText")]
		string NoDataText { get; set; }

		// @property (nonatomic, strong) UIFont * _Null_unspecified noDataFont;
		[Export("noDataFont", ArgumentSemantic.Strong)]
		UIFont NoDataFont { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull noDataTextColor;
		[Export("noDataTextColor", ArgumentSemantic.Strong)]
		UIColor NoDataTextColor { get; set; }

		// @property (nonatomic, strong) ChartDataRendererBase * _Nullable renderer;
		[NullAllowed, Export("renderer", ArgumentSemantic.Strong)]
		ChartDataRendererBase Renderer { get; set; }

		// @property (nonatomic, strong) id<IInterfaceChartHighlighter> _Nullable highlighter;
		[NullAllowed, Export("highlighter", ArgumentSemantic.Strong)]
		IInterfaceChartHighlighter Highlighter { get; set; }

		// @property (nonatomic) BOOL drawMarkers;
		[Export("drawMarkers")]
		bool DrawMarkers { get; set; }

		// @property (readonly, nonatomic) BOOL isDrawMarkersEnabled;
		[Export("isDrawMarkersEnabled")]
		bool IsDrawMarkersEnabled { get; }

		// @property (nonatomic, strong) id<InterfaceChartMarker> _Nullable marker;
		[NullAllowed, Export("marker", ArgumentSemantic.Strong)]
		IInterfaceChartMarker Marker { get; set; }

		// @property (nonatomic) CGFloat extraTopOffset;
		[Export("extraTopOffset")]
		nfloat ExtraTopOffset { get; set; }

		// @property (nonatomic) CGFloat extraRightOffset;
		[Export("extraRightOffset")]
		nfloat ExtraRightOffset { get; set; }

		// @property (nonatomic) CGFloat extraBottomOffset;
		[Export("extraBottomOffset")]
		nfloat ExtraBottomOffset { get; set; }

		// @property (nonatomic) CGFloat extraLeftOffset;
		[Export("extraLeftOffset")]
		nfloat ExtraLeftOffset { get; set; }

		// -(void)setExtraOffsetsWithLeft:(CGFloat)left top:(CGFloat)top right:(CGFloat)right bottom:(CGFloat)bottom;
		[Export("setExtraOffsetsWithLeft:top:right:bottom:")]
		void SetExtraOffsetsWithLeft(nfloat left, nfloat top, nfloat right, nfloat bottom);

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor(CGRect frame);

		//// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		//[Export("initWithCoder:")]
		//[DesignatedInitializer]
		//IntPtr Constructor(NSCoder aDecoder);

		// @property (nonatomic, strong) ChartData * _Nullable data;
		[NullAllowed, Export("data", ArgumentSemantic.Strong)]
		ChartData Data { get; set; }

		// -(void)clear;
		[Export("clear")]
		void Clear();

		// -(void)clearValues;
		[Export("clearValues")]
		void ClearValues();

		// -(BOOL)isEmpty;
		[Export("isEmpty")]
		bool IsEmpty { get; }

		// -(void)notifyDataSetChanged;
		[Export("notifyDataSetChanged")]
		void NotifyDataSetChanged();

		// -(void)drawRect:(CGRect)rect;
		[Export("drawRect:")]
		void DrawRect(CGRect rect);

		// @property (readonly, copy, nonatomic) NSArray<ChartHighlight *> * _Nonnull highlighted;
		[Export("highlighted", ArgumentSemantic.Copy)]
		ChartHighlight[] Highlighted { get; }

		// @property (nonatomic) BOOL highlightPerTapEnabled;
		[Export("highlightPerTapEnabled")]
		bool HighlightPerTapEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isHighLightPerTapEnabled;
		[Export("isHighLightPerTapEnabled")]
		bool IsHighLightPerTapEnabled { get; }

		// -(BOOL)valuesToHighlight;
		[Export("valuesToHighlight")]
		bool ValuesToHighlight { get; }

		// -(void)highlightValues:(NSArray<ChartHighlight *> * _Nullable)highs;
		[Export("highlightValues:")]
		void HighlightValues([NullAllowed] ChartHighlight[] highs);

		// -(void)highlightValueWithX:(double)x dataSetIndex:(NSInteger)dataSetIndex;
		[Export("highlightValueWithX:dataSetIndex:")]
		void HighlightValueWithX(double x, nint dataSetIndex);

		// -(void)highlightValueWithX:(double)x y:(double)y dataSetIndex:(NSInteger)dataSetIndex;
		[Export("highlightValueWithX:y:dataSetIndex:")]
		void HighlightValueWithX(double x, double y, nint dataSetIndex);

		// -(void)highlightValueWithX:(double)x dataSetIndex:(NSInteger)dataSetIndex callDelegate:(BOOL)callDelegate;
		[Export("highlightValueWithX:dataSetIndex:callDelegate:")]
		void HighlightValueWithX(double x, nint dataSetIndex, bool callDelegate);

		// -(void)highlightValueWithX:(double)x y:(double)y dataSetIndex:(NSInteger)dataSetIndex callDelegate:(BOOL)callDelegate;
		[Export("highlightValueWithX:y:dataSetIndex:callDelegate:")]
		void HighlightValueWithX(double x, double y, nint dataSetIndex, bool callDelegate);

		// -(void)highlightValue:(ChartHighlight * _Nullable)highlight;
		[Export("highlightValue:")]
		void HighlightValue([NullAllowed] ChartHighlight highlight);

		// -(void)highlightValue:(ChartHighlight * _Nullable)highlight callDelegate:(BOOL)callDelegate;
		[Export("highlightValue:callDelegate:")]
		void HighlightValue([NullAllowed] ChartHighlight highlight, bool callDelegate);

		// -(ChartHighlight * _Nullable)getHighlightByTouchPoint:(CGPoint)pt;
		[Export("getHighlightByTouchPoint:")]
		[return: NullAllowed]
		ChartHighlight GetHighlightByTouchPoint(CGPoint pt);

		// @property (nonatomic, strong) ChartHighlight * _Nullable lastHighlighted;
		[NullAllowed, Export("lastHighlighted", ArgumentSemantic.Strong)]
		ChartHighlight LastHighlighted { get; set; }

		// -(CGPoint)getMarkerPositionWithHighlight:(ChartHighlight * _Nonnull)highlight;
		[Export("getMarkerPositionWithHighlight:")]
		CGPoint GetMarkerPositionWithHighlight(ChartHighlight highlight);

		// @property (readonly, nonatomic, strong) ChartAnimator * _Null_unspecified chartAnimator;
		[Export("chartAnimator", ArgumentSemantic.Strong)]
		ChartAnimator ChartAnimator { get; }

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration yAxisDuration:(NSTimeInterval)yAxisDuration easingX:(double (^ _Nullable)(NSTimeInterval, NSTimeInterval))easingX easingY:(double (^ _Nullable)(NSTimeInterval, NSTimeInterval))easingY;
		[Export("animateWithXAxisDuration:yAxisDuration:easingX:easingY:")]
		void AnimateWithXAxisDuration(double xAxisDuration, double yAxisDuration, [NullAllowed] Func<double, double, double> easingX, [NullAllowed] Func<double, double, double> easingY);

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration yAxisDuration:(NSTimeInterval)yAxisDuration easingOptionX:(enum ChartEasingOption)easingOptionX easingOptionY:(enum ChartEasingOption)easingOptionY;
		[Export("animateWithXAxisDuration:yAxisDuration:easingOptionX:easingOptionY:")]
		void AnimateWithXAxisDuration(double xAxisDuration, double yAxisDuration, ChartEasingOption easingOptionX, ChartEasingOption easingOptionY);

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration yAxisDuration:(NSTimeInterval)yAxisDuration easing:(double (^ _Nullable)(NSTimeInterval, NSTimeInterval))easing;
		[Export("animateWithXAxisDuration:yAxisDuration:easing:")]
		void AnimateWithXAxisDuration(double xAxisDuration, double yAxisDuration, [NullAllowed] Func<double, double, double> easing);

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration yAxisDuration:(NSTimeInterval)yAxisDuration easingOption:(enum ChartEasingOption)easingOption;
		[Export("animateWithXAxisDuration:yAxisDuration:easingOption:")]
		void AnimateWithXAxisDuration(double xAxisDuration, double yAxisDuration, ChartEasingOption easingOption);

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration yAxisDuration:(NSTimeInterval)yAxisDuration;
		[Export("animateWithXAxisDuration:yAxisDuration:")]
		void AnimateWithXAxisDuration(double xAxisDuration, double yAxisDuration);

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration easing:(double (^ _Nullable)(NSTimeInterval, NSTimeInterval))easing;
		[Export("animateWithXAxisDuration:easing:")]
		void AnimateWithXAxisDuration(double xAxisDuration, [NullAllowed] Func<double, double, double> easing);

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration easingOption:(enum ChartEasingOption)easingOption;
		[Export("animateWithXAxisDuration:easingOption:")]
		void AnimateWithXAxisDuration(double xAxisDuration, ChartEasingOption easingOption);

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration;
		[Export("animateWithXAxisDuration:")]
		void AnimateWithXAxisDuration(double xAxisDuration);

		// -(void)animateWithYAxisDuration:(NSTimeInterval)yAxisDuration easing:(double (^ _Nullable)(NSTimeInterval, NSTimeInterval))easing;
		[Export("animateWithYAxisDuration:easing:")]
		void AnimateWithYAxisDuration(double yAxisDuration, [NullAllowed] Func<double, double, double> easing);

		// -(void)animateWithYAxisDuration:(NSTimeInterval)yAxisDuration easingOption:(enum ChartEasingOption)easingOption;
		[Export("animateWithYAxisDuration:easingOption:")]
		void AnimateWithYAxisDuration(double yAxisDuration, ChartEasingOption easingOption);

		// -(void)animateWithYAxisDuration:(NSTimeInterval)yAxisDuration;
		[Export("animateWithYAxisDuration:")]
		void AnimateWithYAxisDuration(double yAxisDuration);

		// @property (readonly, nonatomic) double chartYMax;
		[Export("chartYMax")]
		double ChartYMax { get; }

		// @property (readonly, nonatomic) double chartYMin;
		[Export("chartYMin")]
		double ChartYMin { get; }

		// @property (readonly, nonatomic) double chartXMax;
		[Export("chartXMax")]
		double ChartXMax { get; }

		// @property (readonly, nonatomic) double chartXMin;
		[Export("chartXMin")]
		double ChartXMin { get; }

		// @property (readonly, nonatomic) double xRange;
		[Export("xRange")]
		double XRange { get; }

		// @property (readonly, nonatomic) CGPoint midPoint;
		[Export("midPoint")]
		CGPoint MidPoint { get; }

		// @property (readonly, nonatomic) CGPoint centerOffsets;
		[Export("centerOffsets")]
		CGPoint CenterOffsets { get; }

		// @property (readonly, nonatomic, strong) ChartLegend * _Nonnull legend;
		[Export("legend", ArgumentSemantic.Strong)]
		ChartLegend Legend { get; }

		// @property (readonly, nonatomic, strong) ChartLegendRenderer * _Null_unspecified legendRenderer;
		[Export("legendRenderer", ArgumentSemantic.Strong)]
		ChartLegendRenderer LegendRenderer { get; }

		// @property (readonly, nonatomic) CGRect contentRect;
		[Export("contentRect")]
		CGRect ContentRect { get; }

		// @property (readonly, nonatomic, strong) ChartViewPortHandler * _Null_unspecified viewPortHandler;
		[Export("viewPortHandler", ArgumentSemantic.Strong)]
		ChartViewPortHandler ViewPortHandler { get; }

		// -(UIImage * _Nullable)getChartImageWithTransparent:(BOOL)transparent;
		[Export("getChartImageWithTransparent:")]
		[return: NullAllowed]
		UIImage GetChartImageWithTransparent(bool transparent);

		//u-n-safe void ObserveValueForKeyPath([NullAllowed] string keyPath, [NullAllowed] NSObject @object, [NullAllowed] NSDictionary<NSString, NSObject> change, [NullAllowed] void* context);

		// -(void)removeViewportJob:(ChartViewPortJob * _Nonnull)job;
		[Export("removeViewportJob:")]
		void RemoveViewportJob(ChartViewPortJob job);

		// -(void)clearAllViewportJobs;
		[Export("clearAllViewportJobs")]
		void ClearAllViewportJobs();

		// -(void)addViewportJob:(ChartViewPortJob * _Nonnull)job;
		[Export("addViewportJob:")]
		void AddViewportJob(ChartViewPortJob job);

		// @property (readonly, nonatomic) BOOL isDragDecelerationEnabled;
		[Export("isDragDecelerationEnabled")]
		bool IsDragDecelerationEnabled { get; }

		// @property (nonatomic) CGFloat dragDecelerationFrictionCoef;
		[Export("dragDecelerationFrictionCoef")]
		nfloat DragDecelerationFrictionCoef { get; set; }

		// @property (nonatomic) CGFloat maxHighlightDistance;
		[Export("maxHighlightDistance")]
		nfloat MaxHighlightDistance { get; set; }

		// @property (readonly, nonatomic) NSInteger maxVisibleCount;
		[Export("maxVisibleCount")]
		nint MaxVisibleCount { get; }

		// -(void)animatorUpdated:(ChartAnimator * _Nonnull)chartAnimator;
		[Export("animatorUpdated:")]
		void AnimatorUpdated(ChartAnimator chartAnimator);

		// -(void)animatorStopped:(ChartAnimator * _Nonnull)chartAnimator;
		[Export("animatorStopped:")]
		void AnimatorStopped(ChartAnimator chartAnimator);

		// -(void)nsuiTouchesBegan:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event;
		[Export("nsuiTouchesBegan:withEvent:")]
		void NsuiTouchesBegan(NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

		// -(void)nsuiTouchesMoved:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event;
		[Export("nsuiTouchesMoved:withEvent:")]
		void NsuiTouchesMoved(NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

		// -(void)nsuiTouchesEnded:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event;
		[Export("nsuiTouchesEnded:withEvent:")]
		void NsuiTouchesEnded(NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

		// -(void)nsuiTouchesCancelled:(NSSet<UITouch *> * _Nullable)touches withEvent:(UIEvent * _Nullable)event;
		[Export("nsuiTouchesCancelled:withEvent:")]
		void NsuiTouchesCancelled([NullAllowed] NSSet<UITouch> touches, [NullAllowed] UIEvent @event);
	}

	// @interface BarLineChartViewBase : ChartViewBase <BarLineScatterCandleBubbleChartDataProvider, UIGestureRecognizerDelegate>
	[BaseType(typeof(ChartViewBase), Name = "_TtC6Charts20BarLineChartViewBase")]
	interface BarLineChartViewBase : BarLineScatterCandleBubbleChartDataProvider, IUIGestureRecognizerDelegate
	{
		// @property (nonatomic, strong) UIColor * _Nonnull gridBackgroundColor;
		[Export("gridBackgroundColor", ArgumentSemantic.Strong)]
		UIColor GridBackgroundColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull borderColor;
		[Export("borderColor", ArgumentSemantic.Strong)]
		UIColor BorderColor { get; set; }

		// @property (nonatomic) CGFloat borderLineWidth;
		[Export("borderLineWidth")]
		nfloat BorderLineWidth { get; set; }

		// @property (nonatomic) BOOL drawGridBackgroundEnabled;
		[Export("drawGridBackgroundEnabled")]
		bool DrawGridBackgroundEnabled { get; set; }

		// @property (nonatomic) BOOL drawBordersEnabled;
		[Export("drawBordersEnabled")]
		bool DrawBordersEnabled { get; set; }

		// @property (nonatomic) BOOL clipValuesToContentEnabled;
		[Export("clipValuesToContentEnabled")]
		bool ClipValuesToContentEnabled { get; set; }

		// @property (nonatomic) CGFloat minOffset;
		[Export("minOffset")]
		nfloat MinOffset { get; set; }

		// @property (nonatomic) BOOL keepPositionOnRotation;
		[Export("keepPositionOnRotation")]
		bool KeepPositionOnRotation { get; set; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor(CGRect frame);

		//// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		//[Export("initWithCoder:")]
		//[DesignatedInitializer]
		//IntPtr Constructor(NSCoder aDecoder);

		//u-n-safe void ObserveValueForKeyPath([NullAllowed] string keyPath, [NullAllowed] NSObject @object, [NullAllowed] NSDictionary<NSString, NSObject> change, [NullAllowed] void* context);

		// -(void)drawRect:(CGRect)rect;
		[Export("drawRect:")]
		void DrawRect(CGRect rect);

		// -(void)notifyDataSetChanged;
		[Export("notifyDataSetChanged")]
		void NotifyDataSetChanged();

		// -(void)stopDeceleration;
		[Export("stopDeceleration")]
		void StopDeceleration();

		// -(BOOL)gestureRecognizerShouldBegin:(UIGestureRecognizer * _Nonnull)gestureRecognizer;
		[Export("gestureRecognizerShouldBegin:")]
		bool GestureRecognizerShouldBegin(UIGestureRecognizer gestureRecognizer);

		// -(BOOL)gestureRecognizer:(UIGestureRecognizer * _Nonnull)gestureRecognizer shouldRecognizeSimultaneouslyWithGestureRecognizer:(UIGestureRecognizer * _Nonnull)otherGestureRecognizer;
		[Export("gestureRecognizer:shouldRecognizeSimultaneouslyWithGestureRecognizer:")]
		bool GestureRecognizer(UIGestureRecognizer gestureRecognizer, UIGestureRecognizer otherGestureRecognizer);

		// -(void)zoomIn;
		[Export("zoomIn")]
		void ZoomIn();

		// -(void)zoomOut;
		[Export("zoomOut")]
		void ZoomOut();

		// -(void)zoomWithScaleX:(CGFloat)scaleX scaleY:(CGFloat)scaleY x:(CGFloat)x y:(CGFloat)y;
		[Export("zoomWithScaleX:scaleY:x:y:")]
		void ZoomWithScaleX(nfloat scaleX, nfloat scaleY, nfloat x, nfloat y);

		// -(void)zoomWithScaleX:(CGFloat)scaleX scaleY:(CGFloat)scaleY xValue:(double)xValue yValue:(double)yValue axis:(enum AxisDependency)axis;
		[Export("zoomWithScaleX:scaleY:xValue:yValue:axis:")]
		void ZoomWithScaleX(nfloat scaleX, nfloat scaleY, double xValue, double yValue, AxisDependency axis);

		// -(void)zoomToCenterWithScaleX:(CGFloat)scaleX scaleY:(CGFloat)scaleY;
		[Export("zoomToCenterWithScaleX:scaleY:")]
		void ZoomToCenterWithScaleX(nfloat scaleX, nfloat scaleY);

		// -(void)zoomAndCenterViewAnimatedWithScaleX:(CGFloat)scaleX scaleY:(CGFloat)scaleY xValue:(double)xValue yValue:(double)yValue axis:(enum AxisDependency)axis duration:(NSTimeInterval)duration easing:(double (^ _Nullable)(NSTimeInterval, NSTimeInterval))easing;
		[Export("zoomAndCenterViewAnimatedWithScaleX:scaleY:xValue:yValue:axis:duration:easing:")]
		void ZoomAndCenterViewAnimatedWithScaleX(nfloat scaleX, nfloat scaleY, double xValue, double yValue, AxisDependency axis, double duration, [NullAllowed] Func<double, double, double> easing);

		// -(void)zoomAndCenterViewAnimatedWithScaleX:(CGFloat)scaleX scaleY:(CGFloat)scaleY xValue:(double)xValue yValue:(double)yValue axis:(enum AxisDependency)axis duration:(NSTimeInterval)duration easingOption:(enum ChartEasingOption)easingOption;
		[Export("zoomAndCenterViewAnimatedWithScaleX:scaleY:xValue:yValue:axis:duration:easingOption:")]
		void ZoomAndCenterViewAnimatedWithScaleX(nfloat scaleX, nfloat scaleY, double xValue, double yValue, AxisDependency axis, double duration, ChartEasingOption easingOption);

		// -(void)zoomAndCenterViewAnimatedWithScaleX:(CGFloat)scaleX scaleY:(CGFloat)scaleY xValue:(double)xValue yValue:(double)yValue axis:(enum AxisDependency)axis duration:(NSTimeInterval)duration;
		[Export("zoomAndCenterViewAnimatedWithScaleX:scaleY:xValue:yValue:axis:duration:")]
		void ZoomAndCenterViewAnimatedWithScaleX(nfloat scaleX, nfloat scaleY, double xValue, double yValue, AxisDependency axis, double duration);

		// -(void)fitScreen;
		[Export("fitScreen")]
		void FitScreen();

		// -(void)setScaleMinima:(CGFloat)scaleX scaleY:(CGFloat)scaleY;
		[Export("setScaleMinima:scaleY:")]
		void SetScaleMinima(nfloat scaleX, nfloat scaleY);

		// @property (readonly, nonatomic) double visibleXRange;
		[Export("visibleXRange")]
		double VisibleXRange { get; }

		// -(void)setVisibleXRangeMaximum:(double)maxXRange;
		[Export("setVisibleXRangeMaximum:")]
		void SetVisibleXRangeMaximum(double maxXRange);

		// -(void)setVisibleXRangeMinimum:(double)minXRange;
		[Export("setVisibleXRangeMinimum:")]
		void SetVisibleXRangeMinimum(double minXRange);

		// -(void)setVisibleXRangeWithMinXRange:(double)minXRange maxXRange:(double)maxXRange;
		[Export("setVisibleXRangeWithMinXRange:maxXRange:")]
		void SetVisibleXRangeWithMinXRange(double minXRange, double maxXRange);

		// -(void)setVisibleYRangeMaximum:(double)maxYRange axis:(enum AxisDependency)axis;
		[Export("setVisibleYRangeMaximum:axis:")]
		void SetVisibleYRangeMaximum(double maxYRange, AxisDependency axis);

		// -(void)setVisibleYRangeMinimum:(double)minYRange axis:(enum AxisDependency)axis;
		[Export("setVisibleYRangeMinimum:axis:")]
		void SetVisibleYRangeMinimum(double minYRange, AxisDependency axis);

		// -(void)setVisibleYRangeWithMinYRange:(double)minYRange maxYRange:(double)maxYRange axis:(enum AxisDependency)axis;
		[Export("setVisibleYRangeWithMinYRange:maxYRange:axis:")]
		void SetVisibleYRangeWithMinYRange(double minYRange, double maxYRange, AxisDependency axis);

		// -(void)moveViewToX:(double)xValue;
		[Export("moveViewToX:")]
		void MoveViewToX(double xValue);

		// -(void)moveViewToY:(double)yValue axis:(enum AxisDependency)axis;
		[Export("moveViewToY:axis:")]
		void MoveViewToY(double yValue, AxisDependency axis);

		// -(void)moveViewToXValue:(double)xValue yValue:(double)yValue axis:(enum AxisDependency)axis;
		[Export("moveViewToXValue:yValue:axis:")]
		void MoveViewToXValue(double xValue, double yValue, AxisDependency axis);

		// -(void)moveViewToAnimatedWithXValue:(double)xValue yValue:(double)yValue axis:(enum AxisDependency)axis duration:(NSTimeInterval)duration easing:(double (^ _Nullable)(NSTimeInterval, NSTimeInterval))easing;
		[Export("moveViewToAnimatedWithXValue:yValue:axis:duration:easing:")]
		void MoveViewToAnimatedWithXValue(double xValue, double yValue, AxisDependency axis, double duration, [NullAllowed] Func<double, double, double> easing);

		// -(void)moveViewToAnimatedWithXValue:(double)xValue yValue:(double)yValue axis:(enum AxisDependency)axis duration:(NSTimeInterval)duration easingOption:(enum ChartEasingOption)easingOption;
		[Export("moveViewToAnimatedWithXValue:yValue:axis:duration:easingOption:")]
		void MoveViewToAnimatedWithXValue(double xValue, double yValue, AxisDependency axis, double duration, ChartEasingOption easingOption);

		// -(void)moveViewToAnimatedWithXValue:(double)xValue yValue:(double)yValue axis:(enum AxisDependency)axis duration:(NSTimeInterval)duration;
		[Export("moveViewToAnimatedWithXValue:yValue:axis:duration:")]
		void MoveViewToAnimatedWithXValue(double xValue, double yValue, AxisDependency axis, double duration);

		// -(void)centerViewToXValue:(double)xValue yValue:(double)yValue axis:(enum AxisDependency)axis;
		[Export("centerViewToXValue:yValue:axis:")]
		void CenterViewToXValue(double xValue, double yValue, AxisDependency axis);

		// -(void)centerViewToAnimatedWithXValue:(double)xValue yValue:(double)yValue axis:(enum AxisDependency)axis duration:(NSTimeInterval)duration easing:(double (^ _Nullable)(NSTimeInterval, NSTimeInterval))easing;
		[Export("centerViewToAnimatedWithXValue:yValue:axis:duration:easing:")]
		void CenterViewToAnimatedWithXValue(double xValue, double yValue, AxisDependency axis, double duration, [NullAllowed] Func<double, double, double> easing);

		// -(void)centerViewToAnimatedWithXValue:(double)xValue yValue:(double)yValue axis:(enum AxisDependency)axis duration:(NSTimeInterval)duration easingOption:(enum ChartEasingOption)easingOption;
		[Export("centerViewToAnimatedWithXValue:yValue:axis:duration:easingOption:")]
		void CenterViewToAnimatedWithXValue(double xValue, double yValue, AxisDependency axis, double duration, ChartEasingOption easingOption);

		// -(void)centerViewToAnimatedWithXValue:(double)xValue yValue:(double)yValue axis:(enum AxisDependency)axis duration:(NSTimeInterval)duration;
		[Export("centerViewToAnimatedWithXValue:yValue:axis:duration:")]
		void CenterViewToAnimatedWithXValue(double xValue, double yValue, AxisDependency axis, double duration);

		// -(void)setViewPortOffsetsWithLeft:(CGFloat)left top:(CGFloat)top right:(CGFloat)right bottom:(CGFloat)bottom;
		[Export("setViewPortOffsetsWithLeft:top:right:bottom:")]
		void SetViewPortOffsetsWithLeft(nfloat left, nfloat top, nfloat right, nfloat bottom);

		// -(void)resetViewPortOffsets;
		[Export("resetViewPortOffsets")]
		void ResetViewPortOffsets();

		// -(double)getAxisRangeWithAxis:(enum AxisDependency)axis;
		[Export("getAxisRangeWithAxis:")]
		double GetAxisRangeWithAxis(AxisDependency axis);

		// -(CGPoint)getPositionWithEntry:(ChartDataEntry * _Nonnull)e axis:(enum AxisDependency)axis;
		[Export("getPositionWithEntry:axis:")]
		CGPoint GetPositionWithEntry(ChartDataEntry e, AxisDependency axis);

		// @property (nonatomic) BOOL dragEnabled;
		[Export("dragEnabled")]
		bool DragEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isDragEnabled;
		[Export("isDragEnabled")]
		bool IsDragEnabled { get; }

		// -(void)setScaleEnabled:(BOOL)enabled;
		[Export("setScaleEnabled:")]
		void SetScaleEnabled(bool enabled);

		// @property (nonatomic) BOOL scaleXEnabled;
		[Export("scaleXEnabled")]
		bool ScaleXEnabled { get; set; }

		// @property (nonatomic) BOOL scaleYEnabled;
		[Export("scaleYEnabled")]
		bool ScaleYEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isScaleXEnabled;
		[Export("isScaleXEnabled")]
		bool IsScaleXEnabled { get; }

		// @property (readonly, nonatomic) BOOL isScaleYEnabled;
		[Export("isScaleYEnabled")]
		bool IsScaleYEnabled { get; }

		// @property (nonatomic) BOOL doubleTapToZoomEnabled;
		[Export("doubleTapToZoomEnabled")]
		bool DoubleTapToZoomEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isDoubleTapToZoomEnabled;
		[Export("isDoubleTapToZoomEnabled")]
		bool IsDoubleTapToZoomEnabled { get; }

		// @property (nonatomic) BOOL highlightPerDragEnabled;
		[Export("highlightPerDragEnabled")]
		bool HighlightPerDragEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isHighlightPerDragEnabled;
		[Export("isHighlightPerDragEnabled")]
		bool IsHighlightPerDragEnabled { get; }

		// @property (readonly, nonatomic) BOOL isDrawGridBackgroundEnabled;
		[Export("isDrawGridBackgroundEnabled")]
		bool IsDrawGridBackgroundEnabled { get; }

		// @property (readonly, nonatomic) BOOL isDrawBordersEnabled;
		[Export("isDrawBordersEnabled")]
		bool IsDrawBordersEnabled { get; }

		// -(CGPoint)valueForTouchPointWithPoint:(CGPoint)pt axis:(enum AxisDependency)axis;
		[Export("valueForTouchPointWithPoint:axis:")]
		CGPoint ValueForTouchPointWithPoint(CGPoint pt, AxisDependency axis);

		// -(CGPoint)pixelForValuesWithX:(double)x y:(double)y axis:(enum AxisDependency)axis;
		[Export("pixelForValuesWithX:y:axis:")]
		CGPoint PixelForValuesWithX(double x, double y, AxisDependency axis);

		// -(ChartDataEntry * _Null_unspecified)getEntryByTouchPointWithPoint:(CGPoint)pt;
		[Export("getEntryByTouchPointWithPoint:")]
		ChartDataEntry GetEntryByTouchPointWithPoint(CGPoint pt);

		// -(id<IInterfaceBarLineScatterCandleBubbleChartDataSet> _Null_unspecified)getDataSetByTouchPointWithPoint:(CGPoint)pt;
		[Export("getDataSetByTouchPointWithPoint:")]
		IInterfaceBarLineScatterCandleBubbleChartDataSet GetDataSetByTouchPointWithPoint(CGPoint pt);

		// @property (readonly, nonatomic) CGFloat scaleX;
		[Export("scaleX")]
		nfloat ScaleX { get; }

		// @property (readonly, nonatomic) CGFloat scaleY;
		[Export("scaleY")]
		nfloat ScaleY { get; }

		// @property (readonly, nonatomic) BOOL isFullyZoomedOut;
		[Export("isFullyZoomedOut")]
		bool IsFullyZoomedOut { get; }

		// @property (readonly, nonatomic, strong) ChartYAxis * _Nonnull leftAxis;
		[Export("leftAxis", ArgumentSemantic.Strong)]
		ChartYAxis LeftAxis { get; }

		// @property (readonly, nonatomic, strong) ChartYAxis * _Nonnull rightAxis;
		[Export("rightAxis", ArgumentSemantic.Strong)]
		ChartYAxis RightAxis { get; }

		// -(ChartYAxis * _Nonnull)getAxis:(enum AxisDependency)axis;
		[Export("getAxis:")]
		ChartYAxis GetAxis(AxisDependency axis);

		// @property (nonatomic) BOOL pinchZoomEnabled;
		[Export("pinchZoomEnabled")]
		bool PinchZoomEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isPinchZoomEnabled;
		[Export("isPinchZoomEnabled")]
		bool IsPinchZoomEnabled { get; }

		// -(void)setDragOffsetX:(CGFloat)offset;
		[Export("setDragOffsetX:")]
		void SetDragOffsetX(nfloat offset);

		// -(void)setDragOffsetY:(CGFloat)offset;
		[Export("setDragOffsetY:")]
		void SetDragOffsetY(nfloat offset);

		// @property (readonly, nonatomic) BOOL hasNoDragOffset;
		[Export("hasNoDragOffset")]
		bool HasNoDragOffset { get; }

		// @property (nonatomic, strong) ChartXAxisRenderer * _Nonnull xAxisRenderer;
		[Export("xAxisRenderer", ArgumentSemantic.Strong)]
		ChartXAxisRenderer XAxisRenderer { get; set; }

		// @property (nonatomic, strong) ChartYAxisRenderer * _Nonnull leftYAxisRenderer;
		[Export("leftYAxisRenderer", ArgumentSemantic.Strong)]
		ChartYAxisRenderer LeftYAxisRenderer { get; set; }

		// @property (nonatomic, strong) ChartYAxisRenderer * _Nonnull rightYAxisRenderer;
		[Export("rightYAxisRenderer", ArgumentSemantic.Strong)]
		ChartYAxisRenderer RightYAxisRenderer { get; set; }

		// @property (readonly, nonatomic) double chartYMax;
		[Export("chartYMax")]
		double ChartYMax { get; }

		// @property (readonly, nonatomic) double chartYMin;
		[Export("chartYMin")]
		double ChartYMin { get; }

		// @property (readonly, nonatomic) BOOL isAnyAxisInverted;
		[Export("isAnyAxisInverted")]
		bool IsAnyAxisInverted { get; }

		// @property (nonatomic) BOOL autoScaleMinMaxEnabled;
		[Export("autoScaleMinMaxEnabled")]
		bool AutoScaleMinMaxEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isAutoScaleMinMaxEnabled;
		[Export("isAutoScaleMinMaxEnabled")]
		bool IsAutoScaleMinMaxEnabled { get; }

		// -(void)setYAxisMinWidth:(enum AxisDependency)axis width:(CGFloat)width;
		[Export("setYAxisMinWidth:width:")]
		void SetYAxisMinWidth(AxisDependency axis, nfloat width);

		// -(CGFloat)getYAxisMinWidth:(enum AxisDependency)axis;
		[Export("getYAxisMinWidth:")]
		nfloat GetYAxisMinWidth(AxisDependency axis);

		// -(void)setYAxisMaxWidth:(enum AxisDependency)axis width:(CGFloat)width;
		[Export("setYAxisMaxWidth:width:")]
		void SetYAxisMaxWidth(AxisDependency axis, nfloat width);

		// -(CGFloat)getYAxisMaxWidth:(enum AxisDependency)axis;
		[Export("getYAxisMaxWidth:")]
		nfloat GetYAxisMaxWidth(AxisDependency axis);

		// -(CGFloat)getYAxisWidth:(enum AxisDependency)axis;
		[Export("getYAxisWidth:")]
		nfloat GetYAxisWidth(AxisDependency axis);

		// -(ChartTransformer * _Nonnull)getTransformerForAxis:(enum AxisDependency)axis;
		[Export("getTransformerForAxis:")]
		ChartTransformer GetTransformerForAxis(AxisDependency axis);

		// @property (nonatomic) NSInteger maxVisibleCount;
		[Export("maxVisibleCount")]
		nint MaxVisibleCount { get; set; }

		// -(BOOL)isInvertedWithAxis:(enum AxisDependency)axis;
		[Export("isInvertedWithAxis:")]
		bool IsInvertedWithAxis(AxisDependency axis);

		// @property (readonly, nonatomic) double lowestVisibleX;
		[Export("lowestVisibleX")]
		double LowestVisibleX { get; }

		// @property (readonly, nonatomic) double highestVisibleX;
		[Export("highestVisibleX")]
		double HighestVisibleX { get; }
	}

	// @interface BarChartView : BarLineChartViewBase <BarChartDataProvider>
	[BaseType(typeof(BarLineChartViewBase), Name = "_TtC6Charts12BarChartView")]
	interface BarChartView : BarChartDataProvider
	{
		// -(ChartHighlight * _Nullable)getHighlightByTouchPoint:(CGPoint)pt;
		[Export("getHighlightByTouchPoint:")]
		[return: NullAllowed]
		ChartHighlight GetHighlightByTouchPoint(CGPoint pt);

		// -(CGRect)getBarBoundsWithEntry:(BarChartDataEntry * _Nonnull)e;
		[Export("getBarBoundsWithEntry:")]
		CGRect GetBarBoundsWithEntry(BarChartDataEntry e);

		// -(void)groupBarsFromX:(double)fromX groupSpace:(double)groupSpace barSpace:(double)barSpace;
		[Export("groupBarsFromX:groupSpace:barSpace:")]
		void GroupBarsFromX(double fromX, double groupSpace, double barSpace);

		// -(void)highlightValueWithX:(double)x dataSetIndex:(NSInteger)dataSetIndex stackIndex:(NSInteger)stackIndex;
		[Export("highlightValueWithX:dataSetIndex:stackIndex:")]
		void HighlightValueWithX(double x, nint dataSetIndex, nint stackIndex);

		// @property (nonatomic) BOOL drawValueAboveBarEnabled;
		[Export("drawValueAboveBarEnabled")]
		bool DrawValueAboveBarEnabled { get; set; }

		// @property (nonatomic) BOOL drawBarShadowEnabled;
		[Export("drawBarShadowEnabled")]
		bool DrawBarShadowEnabled { get; set; }

		// @property (nonatomic) BOOL fitBars;
		[Export("fitBars")]
		bool FitBars { get; set; }

		// @property (nonatomic) BOOL highlightFullBarEnabled;
		[Export("highlightFullBarEnabled")]
		bool HighlightFullBarEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isHighlightFullBarEnabled;
		[Export("isHighlightFullBarEnabled")]
		bool IsHighlightFullBarEnabled { get; }

		// @property (readonly, nonatomic, strong) BarChartData * _Nullable barData;
		[NullAllowed, Export("barData", ArgumentSemantic.Strong)]
		BarChartData BarData { get; }

		// @property (readonly, nonatomic) BOOL isDrawValueAboveBarEnabled;
		[Export("isDrawValueAboveBarEnabled")]
		bool IsDrawValueAboveBarEnabled { get; }

		// @property (readonly, nonatomic) BOOL isDrawBarShadowEnabled;
		[Export("isDrawBarShadowEnabled")]
		bool IsDrawBarShadowEnabled { get; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor(CGRect frame);

		//// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		//[Export("initWithCoder:")]
		//[DesignatedInitializer]
		//IntPtr Constructor(NSCoder aDecoder);
	}

	interface IInterfaceChartHighlighter { }

	// @protocol IInterfaceChartHighlighter <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject), Name = "IChartHighlighter")]
	interface InterfaceChartHighlighter
	{
		// @required -(ChartHighlight * _Nullable)getHighlightWithX:(CGFloat)x y:(CGFloat)y;
		[Abstract]
		[Export("getHighlightWithX:y:")]
		[return: NullAllowed]
		ChartHighlight GetHighlightWithX(nfloat x, nfloat y);
	}

	// @interface ChartHighlighter : NSObject <IInterfaceChartHighlighter>
	[BaseType(typeof(NSObject), Name = "_TtC6Charts16ChartHighlighter")]
	[DisableDefaultCtor]
	interface ChartHighlighter : InterfaceChartHighlighter
	{
		// @property (nonatomic, weak) id<ChartDataProvider> _Nullable chart;
		[NullAllowed, Export("chart", ArgumentSemantic.Weak)]
		IChartDataProvider Chart { get; set; }

		// -(instancetype _Nonnull)initWithChart:(id<ChartDataProvider> _Nonnull)chart __attribute__((objc_designated_initializer));
		[Export("initWithChart:")]
		[DesignatedInitializer]
		IntPtr Constructor(IChartDataProvider chart);

		// -(ChartHighlight * _Nullable)getHighlightWithX:(CGFloat)x y:(CGFloat)y;
		[Export("getHighlightWithX:y:")]
		[return: NullAllowed]
		ChartHighlight GetHighlightWithX(nfloat x, nfloat y);

		// -(CGPoint)getValsForTouchWithX:(CGFloat)x y:(CGFloat)y;
		[Export("getValsForTouchWithX:y:")]
		CGPoint GetValsForTouchWithX(nfloat x, nfloat y);

		// -(ChartHighlight * _Nullable)getHighlightWithXValue:(double)xVal x:(CGFloat)x y:(CGFloat)y;
		[Export("getHighlightWithXValue:x:y:")]
		[return: NullAllowed]
		ChartHighlight GetHighlightWithXValue(double xVal, nfloat x, nfloat y);

		// -(NSArray<ChartHighlight *> * _Nonnull)getHighlightsWithXValue:(double)xValue x:(CGFloat)x y:(CGFloat)y;
		[Export("getHighlightsWithXValue:x:y:")]
		ChartHighlight[] GetHighlightsWithXValue(double xValue, nfloat x, nfloat y);
	}

	// @interface BarChartHighlighter : ChartHighlighter
	[BaseType(typeof(ChartHighlighter))]
	interface BarChartHighlighter
	{
		// -(ChartHighlight * _Nullable)getHighlightWithX:(CGFloat)x y:(CGFloat)y;
		[Export("getHighlightWithX:y:")]
		[return: NullAllowed]
		ChartHighlight GetHighlightWithX(nfloat x, nfloat y);

		// -(ChartHighlight * _Nullable)getStackedHighlightWithHigh:(ChartHighlight * _Nonnull)high set:(id<IInterfaceBarChartDataSet> _Nonnull)set xValue:(double)xValue yValue:(double)yValue;
		[Export("getStackedHighlightWithHigh:set:xValue:yValue:")]
		[return: NullAllowed]
		ChartHighlight GetStackedHighlightWithHigh(ChartHighlight high, IInterfaceBarChartDataSet set, double xValue, double yValue);

		// -(NSInteger)getClosestStackIndexWithRanges:(NSArray<ChartRange *> * _Nullable)ranges value:(double)value;
		[Export("getClosestStackIndexWithRanges:value:")]
		nint GetClosestStackIndexWithRanges([NullAllowed] ChartRange[] ranges, double value);

		// -(instancetype _Nonnull)initWithChart:(id<ChartDataProvider> _Nonnull)chart __attribute__((objc_designated_initializer));
		[Export("initWithChart:")]
		[DesignatedInitializer]
		IntPtr Constructor(IChartDataProvider chart);
	}

	// @interface BubbleChartData : BarLineScatterCandleBubbleChartData
	[BaseType(typeof(BarLineScatterCandleBubbleChartData), Name = "_TtC6Charts15BubbleChartData")]
	interface BubbleChartData
	{
		// -(instancetype _Nonnull)initWithDataSets:(NSArray<id<IInterfaceChartDataSet>> * _Nullable)dataSets __attribute__((objc_designated_initializer));
		[Export("initWithDataSets:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] IInterfaceChartDataSet[] dataSets);

		// -(void)setHighlightCircleWidth:(CGFloat)width;
		[Export("setHighlightCircleWidth:")]
		void SetHighlightCircleWidth(nfloat width);
	}

	// @interface BubbleChartDataEntry : ChartDataEntry
	[BaseType(typeof(ChartDataEntry), Name = "_TtC6Charts20BubbleChartDataEntry")]
	interface BubbleChartDataEntry
	{
		// @property (nonatomic) CGFloat size;
		[Export("size")]
		nfloat Size { get; set; }

		// -(instancetype _Nonnull)initWithX:(double)x y:(double)y size:(CGFloat)size __attribute__((objc_designated_initializer));
		[Export("initWithX:y:size:")]
		[DesignatedInitializer]
		IntPtr Constructor(double x, double y, nfloat size);

		// -(instancetype _Nonnull)initWithX:(double)x y:(double)y size:(CGFloat)size data:(id _Nullable)data __attribute__((objc_designated_initializer));
		[Export("initWithX:y:size:data:")]
		[DesignatedInitializer]
		IntPtr Constructor(double x, double y, nfloat size, [NullAllowed] NSObject data);

		//u-n-safe NSObject CopyWithZone([NullAllowed] _NSZone* zone);
	}

	interface IBubbleChartDataProvider { }

	// @protocol BubbleChartDataProvider <BarLineScatterCandleBubbleChartDataProvider>
	[Protocol(Name = "_TtP6Charts23BubbleChartDataProvider_"), Model]
	interface BubbleChartDataProvider : BarLineScatterCandleBubbleChartDataProvider
	{
		// @required @property (readonly, nonatomic, strong) BubbleChartData * _Nullable bubbleData;
		[Abstract]
		[NullAllowed, Export("bubbleData", ArgumentSemantic.Strong)]
		BubbleChartData BubbleData { get; }
	}

	interface IInterfaceBubbleChartDataSet { }

	// @protocol IInterfaceBubbleChartDataSet <IInterfaceBarLineScatterCandleBubbleChartDataSet>
	[Protocol(Name = "_TtP6Charts19IBubbleChartDataSet_"), Model]
	interface InterfaceBubbleChartDataSet : InterfaceBarLineScatterCandleBubbleChartDataSet
	{
		// @required @property (readonly, nonatomic) CGFloat maxSize;
		[Abstract]
		[Export("maxSize")]
		nfloat MaxSize { get; }

		// @required @property (readonly, nonatomic) BOOL isNormalizeSizeEnabled;
		[Abstract]
		[Export("isNormalizeSizeEnabled")]
		bool IsNormalizeSizeEnabled { get; }

		// @required @property (nonatomic) CGFloat highlightCircleWidth;
		[Abstract]
		[Export("highlightCircleWidth")]
		nfloat HighlightCircleWidth { get; set; }
	}

	// @interface BubbleChartDataSet : BarLineScatterCandleBubbleChartDataSet <IInterfaceBubbleChartDataSet>
	[BaseType(typeof(BarLineScatterCandleBubbleChartDataSet), Name = "_TtC6Charts18BubbleChartDataSet")]
	interface BubbleChartDataSet : InterfaceBubbleChartDataSet
	{
		// @property (readonly, nonatomic) CGFloat maxSize;
		[Export("maxSize")]
		nfloat MaxSize { get; }

		// @property (nonatomic) BOOL normalizeSizeEnabled;
		[Export("normalizeSizeEnabled")]
		bool NormalizeSizeEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isNormalizeSizeEnabled;
		[Export("isNormalizeSizeEnabled")]
		bool IsNormalizeSizeEnabled { get; }

		// -(void)calcMinMaxWithEntry:(ChartDataEntry * _Nonnull)e;
		[Export("calcMinMaxWithEntry:")]
		void CalcMinMaxWithEntry(ChartDataEntry e);

		// @property (nonatomic) CGFloat highlightCircleWidth;
		[Export("highlightCircleWidth")]
		nfloat HighlightCircleWidth { get; set; }

		//u-n-safe NSObject CopyWithZone([NullAllowed] _NSZone* zone);

		// -(instancetype _Nonnull)initWithLabel:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
		[Export("initWithLabel:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] string label);

		// -(instancetype _Nonnull)initWithValues:(NSArray<ChartDataEntry *> * _Nullable)values label:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
		[Export("initWithValues:label:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] ChartDataEntry[] values, [NullAllowed] string label);
	}

	// @interface BubbleChartRenderer : BarLineScatterCandleBubbleChartRenderer
	[BaseType(typeof(BarLineScatterCandleBubbleChartRenderer), Name = "_TtC6Charts19BubbleChartRenderer")]
	interface BubbleChartRenderer
	{
		// @property (nonatomic, weak) id<BubbleChartDataProvider> _Nullable dataProvider;
		[NullAllowed, Export("dataProvider", ArgumentSemantic.Weak)]
		IBubbleChartDataProvider DataProvider { get; set; }

		// -(instancetype _Nonnull)initWithDataProvider:(id<BubbleChartDataProvider> _Nullable)dataProvider animator:(ChartAnimator * _Nullable)animator viewPortHandler:(ChartViewPortHandler * _Nullable)viewPortHandler __attribute__((objc_designated_initializer));
		[Export("initWithDataProvider:animator:viewPortHandler:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] IBubbleChartDataProvider dataProvider, [NullAllowed] ChartAnimator animator, [NullAllowed] ChartViewPortHandler viewPortHandler);

		//u-n-safe void DrawDataWithContext(CGContextRef* context);

		//u-n-safe void DrawDataSetWithContext(CGContextRef* context, IInterfaceBubbleChartDataSet dataSet);

		//u-n-safe void DrawValuesWithContext(CGContextRef* context);

		//u-n-safe void DrawExtrasWithContext(CGContextRef* context);

		//u-n-safe void DrawHighlightedWithContext(CGContextRef* context, ChartHighlight[] indices);
	}

	// @interface BubbleChartView : BarLineChartViewBase <BubbleChartDataProvider>
	[BaseType(typeof(BarLineChartViewBase), Name = "_TtC6Charts15BubbleChartView")]
	interface BubbleChartView : IBubbleChartDataProvider
	{
		// -(void)initialize __attribute__((objc_method_family("none")));
		[Export("initialize")]
		void Initialize();

		// @property (readonly, nonatomic, strong) BubbleChartData * _Nullable bubbleData;
		[NullAllowed, Export("bubbleData", ArgumentSemantic.Strong)]
		BubbleChartData BubbleData { get; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor(CGRect frame);

		//// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		//[Export("initWithCoder:")]
		//[DesignatedInitializer]
		//IntPtr Constructor(NSCoder aDecoder);
	}

	// @interface CandleChartData : BarLineScatterCandleBubbleChartData
	[BaseType(typeof(BarLineScatterCandleBubbleChartData), Name = "_TtC6Charts15CandleChartData")]
	interface CandleChartData
	{
		// -(instancetype _Nonnull)initWithDataSets:(NSArray<id<IInterfaceChartDataSet>> * _Nullable)dataSets __attribute__((objc_designated_initializer));
		[Export("initWithDataSets:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] IInterfaceChartDataSet[] dataSets);
	}

	// @interface CandleChartDataEntry : ChartDataEntry
	[BaseType(typeof(ChartDataEntry), Name = "_TtC6Charts20CandleChartDataEntry")]
	interface CandleChartDataEntry
	{
		// @property (nonatomic) double high;
		[Export("high")]
		double High { get; set; }

		// @property (nonatomic) double low;
		[Export("low")]
		double Low { get; set; }

		// @property (nonatomic) double close;
		[Export("close")]
		double Close { get; set; }

		// @property (nonatomic) double open;
		[Export("open")]
		double Open { get; set; }

		// -(instancetype _Nonnull)initWithX:(double)x shadowH:(double)shadowH shadowL:(double)shadowL open:(double)open close:(double)close __attribute__((objc_designated_initializer));
		[Export("initWithX:shadowH:shadowL:open:close:")]
		[DesignatedInitializer]
		IntPtr Constructor(double x, double shadowH, double shadowL, double open, double close);

		// -(instancetype _Nonnull)initWithX:(double)x shadowH:(double)shadowH shadowL:(double)shadowL open:(double)open close:(double)close data:(id _Nullable)data __attribute__((objc_designated_initializer));
		[Export("initWithX:shadowH:shadowL:open:close:data:")]
		[DesignatedInitializer]
		IntPtr Constructor(double x, double shadowH, double shadowL, double open, double close, [NullAllowed] NSObject data);

		// @property (readonly, nonatomic) double shadowRange;
		[Export("shadowRange")]
		double ShadowRange { get; }

		// @property (readonly, nonatomic) double bodyRange;
		[Export("bodyRange")]
		double BodyRange { get; }

		// @property (nonatomic) double y;
		[Export("y")]
		double Y { get; set; }

		//u-n-safe NSObject CopyWithZone([NullAllowed] _NSZone* zone);
	}

	interface ICandleChartDataProvider { }

	// @protocol CandleChartDataProvider <BarLineScatterCandleBubbleChartDataProvider>
	[Protocol(Name = "_TtP6Charts23CandleChartDataProvider_"), Model]
	interface CandleChartDataProvider : BarLineScatterCandleBubbleChartDataProvider
	{
		// @required @property (readonly, nonatomic, strong) CandleChartData * _Nullable candleData;
		[Abstract]
		[NullAllowed, Export("candleData", ArgumentSemantic.Strong)]
		CandleChartData CandleData { get; }
	}

	interface IInterfaceLineScatterCandleRadarChartDataSet { }

	// @protocol IInterfaceLineScatterCandleRadarChartDataSet <IInterfaceBarLineScatterCandleBubbleChartDataSet>
	[Protocol(Name = "_TtP6Charts35ILineScatterCandleRadarChartDataSet_"), Model]
	interface InterfaceLineScatterCandleRadarChartDataSet : InterfaceBarLineScatterCandleBubbleChartDataSet
	{
		// @required @property (nonatomic) BOOL drawHorizontalHighlightIndicatorEnabled;
		[Abstract]
		[Export("drawHorizontalHighlightIndicatorEnabled")]
		bool DrawHorizontalHighlightIndicatorEnabled { get; set; }

		// @required @property (nonatomic) BOOL drawVerticalHighlightIndicatorEnabled;
		[Abstract]
		[Export("drawVerticalHighlightIndicatorEnabled")]
		bool DrawVerticalHighlightIndicatorEnabled { get; set; }

		// @required @property (readonly, nonatomic) BOOL isHorizontalHighlightIndicatorEnabled;
		[Abstract]
		[Export("isHorizontalHighlightIndicatorEnabled")]
		bool IsHorizontalHighlightIndicatorEnabled { get; }

		// @required @property (readonly, nonatomic) BOOL isVerticalHighlightIndicatorEnabled;
		[Abstract]
		[Export("isVerticalHighlightIndicatorEnabled")]
		bool IsVerticalHighlightIndicatorEnabled { get; }

		// @required -(void)setDrawHighlightIndicators:(BOOL)enabled;
		[Abstract]
		[Export("setDrawHighlightIndicators:")]
		void SetDrawHighlightIndicators(bool enabled);
	}

	interface IInterfaceCandleChartDataSet { }

	// @protocol IInterfaceCandleChartDataSet <IInterfaceLineScatterCandleRadarChartDataSet>
	[Protocol(Name = "_TtP6Charts19ICandleChartDataSet_"), Model]
	interface InterfaceCandleChartDataSet : InterfaceLineScatterCandleRadarChartDataSet
	{
		// @required @property (nonatomic) CGFloat barSpace;
		[Abstract]
		[Export("barSpace")]
		nfloat BarSpace { get; set; }

		// @required @property (nonatomic) BOOL showCandleBar;
		[Abstract]
		[Export("showCandleBar")]
		bool ShowCandleBar { get; set; }

		// @required @property (nonatomic) CGFloat shadowWidth;
		[Abstract]
		[Export("shadowWidth")]
		nfloat ShadowWidth { get; set; }

		// @required @property (nonatomic, strong) UIColor * _Nullable shadowColor;
		[Abstract]
		[NullAllowed, Export("shadowColor", ArgumentSemantic.Strong)]
		UIColor ShadowColor { get; set; }

		// @required @property (nonatomic) BOOL shadowColorSameAsCandle;
		[Abstract]
		[Export("shadowColorSameAsCandle")]
		bool ShadowColorSameAsCandle { get; set; }

		// @required @property (readonly, nonatomic) BOOL isShadowColorSameAsCandle;
		[Abstract]
		[Export("isShadowColorSameAsCandle")]
		bool IsShadowColorSameAsCandle { get; }

		// @required @property (nonatomic, strong) UIColor * _Nullable neutralColor;
		[Abstract]
		[NullAllowed, Export("neutralColor", ArgumentSemantic.Strong)]
		UIColor NeutralColor { get; set; }

		// @required @property (nonatomic, strong) UIColor * _Nullable increasingColor;
		[Abstract]
		[NullAllowed, Export("increasingColor", ArgumentSemantic.Strong)]
		UIColor IncreasingColor { get; set; }

		// @required @property (nonatomic, strong) UIColor * _Nullable decreasingColor;
		[Abstract]
		[NullAllowed, Export("decreasingColor", ArgumentSemantic.Strong)]
		UIColor DecreasingColor { get; set; }

		// @required @property (nonatomic) BOOL increasingFilled;
		[Abstract]
		[Export("increasingFilled")]
		bool IncreasingFilled { get; set; }

		// @required @property (readonly, nonatomic) BOOL isIncreasingFilled;
		[Abstract]
		[Export("isIncreasingFilled")]
		bool IsIncreasingFilled { get; }

		// @required @property (nonatomic) BOOL decreasingFilled;
		[Abstract]
		[Export("decreasingFilled")]
		bool DecreasingFilled { get; set; }

		// @required @property (readonly, nonatomic) BOOL isDecreasingFilled;
		[Abstract]
		[Export("isDecreasingFilled")]
		bool IsDecreasingFilled { get; }
	}

	// @interface LineScatterCandleRadarChartDataSet : BarLineScatterCandleBubbleChartDataSet <IInterfaceLineScatterCandleRadarChartDataSet>
	[BaseType(typeof(BarLineScatterCandleBubbleChartDataSet), Name = "_TtC6Charts34LineScatterCandleRadarChartDataSet")]
	interface LineScatterCandleRadarChartDataSet : InterfaceLineScatterCandleRadarChartDataSet
	{
		// @property (nonatomic) BOOL drawHorizontalHighlightIndicatorEnabled;
		[Export("drawHorizontalHighlightIndicatorEnabled")]
		bool DrawHorizontalHighlightIndicatorEnabled { get; set; }

		// @property (nonatomic) BOOL drawVerticalHighlightIndicatorEnabled;
		[Export("drawVerticalHighlightIndicatorEnabled")]
		bool DrawVerticalHighlightIndicatorEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isHorizontalHighlightIndicatorEnabled;
		[Export("isHorizontalHighlightIndicatorEnabled")]
		bool IsHorizontalHighlightIndicatorEnabled { get; }

		// @property (readonly, nonatomic) BOOL isVerticalHighlightIndicatorEnabled;
		[Export("isVerticalHighlightIndicatorEnabled")]
		bool IsVerticalHighlightIndicatorEnabled { get; }

		// -(void)setDrawHighlightIndicators:(BOOL)enabled;
		[Export("setDrawHighlightIndicators:")]
		void SetDrawHighlightIndicators(bool enabled);

		//u-n-safe NSObject CopyWithZone([NullAllowed] _NSZone* zone);

		// -(instancetype _Nonnull)initWithLabel:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
		[Export("initWithLabel:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] string label);

		// -(instancetype _Nonnull)initWithValues:(NSArray<ChartDataEntry *> * _Nullable)values label:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
		[Export("initWithValues:label:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] ChartDataEntry[] values, [NullAllowed] string label);
	}

	// @interface CandleChartDataSet : LineScatterCandleRadarChartDataSet <IInterfaceCandleChartDataSet>
	[BaseType(typeof(LineScatterCandleRadarChartDataSet), Name = "_TtC6Charts18CandleChartDataSet")]
	interface CandleChartDataSet : InterfaceCandleChartDataSet
	{
		// -(instancetype _Nonnull)initWithValues:(NSArray<ChartDataEntry *> * _Nullable)values label:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
		[Export("initWithValues:label:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] ChartDataEntry[] values, [NullAllowed] string label);

		// -(void)calcMinMaxWithEntry:(ChartDataEntry * _Nonnull)e;
		[Export("calcMinMaxWithEntry:")]
		void CalcMinMaxWithEntry(ChartDataEntry e);

		// -(void)calcMinMaxYWithEntry:(ChartDataEntry * _Nonnull)e;
		[Export("calcMinMaxYWithEntry:")]
		void CalcMinMaxYWithEntry(ChartDataEntry e);

		// @property (nonatomic) CGFloat barSpace;
		[Export("barSpace")]
		nfloat BarSpace { get; set; }

		// @property (nonatomic) BOOL showCandleBar;
		[Export("showCandleBar")]
		bool ShowCandleBar { get; set; }

		// @property (nonatomic) CGFloat shadowWidth;
		[Export("shadowWidth")]
		nfloat ShadowWidth { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable shadowColor;
		[NullAllowed, Export("shadowColor", ArgumentSemantic.Strong)]
		UIColor ShadowColor { get; set; }

		// @property (nonatomic) BOOL shadowColorSameAsCandle;
		[Export("shadowColorSameAsCandle")]
		bool ShadowColorSameAsCandle { get; set; }

		// @property (readonly, nonatomic) BOOL isShadowColorSameAsCandle;
		[Export("isShadowColorSameAsCandle")]
		bool IsShadowColorSameAsCandle { get; }

		// @property (nonatomic, strong) UIColor * _Nullable neutralColor;
		[NullAllowed, Export("neutralColor", ArgumentSemantic.Strong)]
		UIColor NeutralColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable increasingColor;
		[NullAllowed, Export("increasingColor", ArgumentSemantic.Strong)]
		UIColor IncreasingColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable decreasingColor;
		[NullAllowed, Export("decreasingColor", ArgumentSemantic.Strong)]
		UIColor DecreasingColor { get; set; }

		// @property (nonatomic) BOOL increasingFilled;
		[Export("increasingFilled")]
		bool IncreasingFilled { get; set; }

		// @property (readonly, nonatomic) BOOL isIncreasingFilled;
		[Export("isIncreasingFilled")]
		bool IsIncreasingFilled { get; }

		// @property (nonatomic) BOOL decreasingFilled;
		[Export("decreasingFilled")]
		bool DecreasingFilled { get; set; }

		// @property (readonly, nonatomic) BOOL isDecreasingFilled;
		[Export("isDecreasingFilled")]
		bool IsDecreasingFilled { get; }
	}

	// @interface LineScatterCandleRadarChartRenderer : BarLineScatterCandleBubbleChartRenderer
	[BaseType(typeof(BarLineScatterCandleBubbleChartRenderer))]
	interface LineScatterCandleRadarChartRenderer
	{
		// -(instancetype _Nonnull)initWithAnimator:(ChartAnimator * _Nullable)animator viewPortHandler:(ChartViewPortHandler * _Nullable)viewPortHandler __attribute__((objc_designated_initializer));
		[Export("initWithAnimator:viewPortHandler:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] ChartAnimator animator, [NullAllowed] ChartViewPortHandler viewPortHandler);

		//u-n-safe void DrawHighlightLinesWithContext(CGContextRef* context, CGPoint point, IInterfaceLineScatterCandleRadarChartDataSet set);
	}

	// @interface CandleStickChartRenderer : LineScatterCandleRadarChartRenderer
	[BaseType(typeof(LineScatterCandleRadarChartRenderer), Name = "_TtC6Charts24CandleStickChartRenderer")]
	interface CandleStickChartRenderer
	{
		// @property (nonatomic, weak) id<CandleChartDataProvider> _Nullable dataProvider;
		[NullAllowed, Export("dataProvider", ArgumentSemantic.Weak)]
		ICandleChartDataProvider DataProvider { get; set; }

		// -(instancetype _Nonnull)initWithDataProvider:(id<CandleChartDataProvider> _Nullable)dataProvider animator:(ChartAnimator * _Nullable)animator viewPortHandler:(ChartViewPortHandler * _Nullable)viewPortHandler __attribute__((objc_designated_initializer));
		[Export("initWithDataProvider:animator:viewPortHandler:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] ICandleChartDataProvider dataProvider, [NullAllowed] ChartAnimator animator, [NullAllowed] ChartViewPortHandler viewPortHandler);

		//u-n-safe void DrawDataWithContext(CGContextRef* context);

		//u-n-safe void DrawDataSetWithContext(CGContextRef* context, IInterfaceCandleChartDataSet dataSet);

		//u-n-safe void DrawValuesWithContext(CGContextRef* context);

		//u-n-safe void DrawExtrasWithContext(CGContextRef* context);

		//u-n-safe void DrawHighlightedWithContext(CGContextRef* context, ChartHighlight[] indices);
	}

	// @interface CandleStickChartView : BarLineChartViewBase <CandleChartDataProvider>
	[BaseType(typeof(BarLineChartViewBase), Name = "_TtC6Charts20CandleStickChartView")]
	interface CandleStickChartView : ICandleChartDataProvider
	{
		// @property (readonly, nonatomic, strong) CandleChartData * _Nullable candleData;
		[NullAllowed, Export("candleData", ArgumentSemantic.Strong)]
		CandleChartData CandleData { get; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor(CGRect frame);

		//// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		//[Export("initWithCoder:")]
		//[DesignatedInitializer]
		//IntPtr Constructor(NSCoder aDecoder);
	}

	// @interface ChartColorTemplates : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC6Charts19ChartColorTemplates")]
	interface ChartColorTemplates
	{
		// +(NSArray<UIColor *> * _Nonnull)liberty;
		[Static]
		[Export("liberty")]
		UIColor[] Liberty { get; }

		// +(NSArray<UIColor *> * _Nonnull)joyful;
		[Static]
		[Export("joyful")]
		UIColor[] Joyful { get; }

		// +(NSArray<UIColor *> * _Nonnull)pastel;
		[Static]
		[Export("pastel")]
		UIColor[] Pastel { get; }

		// +(NSArray<UIColor *> * _Nonnull)colorful;
		[Static]
		[Export("colorful")]
		UIColor[] Colorful { get; }

		// +(NSArray<UIColor *> * _Nonnull)vordiplom;
		[Static]
		[Export("vordiplom")]
		UIColor[] Vordiplom { get; }

		// +(NSArray<UIColor *> * _Nonnull)material;
		[Static]
		[Export("material")]
		UIColor[] Material { get; }

		// +(UIColor * _Nonnull)colorFromString:(NSString * _Nonnull)colorString;
		[Static]
		[Export("colorFromString:")]
		UIColor ColorFromString(string colorString);
	}

	// @interface ChartLimitLine : ChartComponentBase
	[BaseType(typeof(ChartComponentBase), Name = "_TtC6Charts14ChartLimitLine")]
	interface ChartLimitLine
	{
		// @property (nonatomic) double limit;
		[Export("limit")]
		double Limit { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull lineColor;
		[Export("lineColor", ArgumentSemantic.Strong)]
		UIColor LineColor { get; set; }

		// @property (nonatomic) CGFloat lineDashPhase;
		[Export("lineDashPhase")]
		nfloat LineDashPhase { get; set; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nullable lineDashLengths;
		[NullAllowed, Export("lineDashLengths", ArgumentSemantic.Copy)]
		NSNumber[] LineDashLengths { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull valueTextColor;
		[Export("valueTextColor", ArgumentSemantic.Strong)]
		UIColor ValueTextColor { get; set; }

		// @property (nonatomic, strong) UIFont * _Nonnull valueFont;
		[Export("valueFont", ArgumentSemantic.Strong)]
		UIFont ValueFont { get; set; }

		// @property (nonatomic) BOOL drawLabelEnabled;
		[Export("drawLabelEnabled")]
		bool DrawLabelEnabled { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull label;
		[Export("label")]
		string Label { get; set; }

		// @property (nonatomic) enum ChartLimitLabelPosition labelPosition;
		[Export("labelPosition", ArgumentSemantic.Assign)]
		ChartLimitLabelPosition LabelPosition { get; set; }

		// -(instancetype _Nonnull)initWithLimit:(double)limit __attribute__((objc_designated_initializer));
		[Export("initWithLimit:")]
		[DesignatedInitializer]
		IntPtr Constructor(double limit);

		// -(instancetype _Nonnull)initWithLimit:(double)limit label:(NSString * _Nonnull)label __attribute__((objc_designated_initializer));
		[Export("initWithLimit:label:")]
		[DesignatedInitializer]
		IntPtr Constructor(double limit, string label);

		// @property (nonatomic) CGFloat lineWidth;
		[Export("lineWidth")]
		nfloat LineWidth { get; set; }
	}

	interface IChartViewDelegate { }

	// @protocol ChartViewDelegate
	[BaseType(typeof(NSObject), Name = "_TtP6Charts17ChartViewDelegate_")]
	[Protocol(Name = "_TtP6Charts17ChartViewDelegate_"), Model]
	interface ChartViewDelegate
	{
		// @optional -(void)chartValueSelected:(ChartViewBase * _Nonnull)chartView entry:(ChartDataEntry * _Nonnull)entry highlight:(ChartHighlight * _Nonnull)highlight;
		[Export("chartValueSelected:entry:highlight:")]
		void ChartValueSelected(ChartViewBase chartView, ChartDataEntry entry, ChartHighlight highlight);

		// @optional -(void)chartValueNothingSelected:(ChartViewBase * _Nonnull)chartView;
		[Export("chartValueNothingSelected:")]
		void ChartValueNothingSelected(ChartViewBase chartView);

		// @optional -(void)chartScaled:(ChartViewBase * _Nonnull)chartView scaleX:(CGFloat)scaleX scaleY:(CGFloat)scaleY;
		[Export("chartScaled:scaleX:scaleY:")]
		void ChartScaled(ChartViewBase chartView, nfloat scaleX, nfloat scaleY);

		// @optional -(void)chartTranslated:(ChartViewBase * _Nonnull)chartView dX:(CGFloat)dX dY:(CGFloat)dY;
		[Export("chartTranslated:dX:dY:")]
		void ChartTranslated(ChartViewBase chartView, nfloat dX, nfloat dY);
	}

	interface IInterfaceShapeRenderer { }

	// @protocol InterfaceShapeRenderer <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject), Name = "_TtP6Charts14IShapeRenderer_")]
	interface InterfaceShapeRenderer
	{
		//u-n-safe void DataSet(CGContextRef* context, IInterfaceScatterChartDataSet dataSet, ChartViewPortHandler viewPortHandler, CGPoint point, UIColor color);
	}

	// @interface ChevronDownShapeRenderer : NSObject <InterfaceShapeRenderer>
	[BaseType(typeof(NSObject), Name = "_TtC6Charts24ChevronDownShapeRenderer")]
	interface ChevronDownShapeRenderer : InterfaceShapeRenderer
	{
		//u-n-safe void RenderShapeWithContext(CGContextRef* context, IInterfaceScatterChartDataSet dataSet, ChartViewPortHandler viewPortHandler, CGPoint point, UIColor color);
	}

	// @interface ChevronUpShapeRenderer : NSObject <InterfaceShapeRenderer>
	[BaseType(typeof(NSObject), Name = "_TtC6Charts22ChevronUpShapeRenderer")]
	interface ChevronUpShapeRenderer : InterfaceShapeRenderer
	{
		//u-n-safe void RenderShapeWithContext(CGContextRef* context, IInterfaceScatterChartDataSet dataSet, ChartViewPortHandler viewPortHandler, CGPoint point, UIColor color);
	}

	// @interface CircleShapeRenderer : NSObject <InterfaceShapeRenderer>
	[BaseType(typeof(NSObject), Name = "_TtC6Charts19CircleShapeRenderer")]
	interface CircleShapeRenderer : InterfaceShapeRenderer
	{
		//u-n-safe void RenderShapeWithContext(CGContextRef* context, IInterfaceScatterChartDataSet dataSet, ChartViewPortHandler viewPortHandler, CGPoint point, UIColor color);
	}

	// @interface CombinedChartData : BarLineScatterCandleBubbleChartData
	[BaseType(typeof(BarLineScatterCandleBubbleChartData), Name = "_TtC6Charts17CombinedChartData")]
	interface CombinedChartData
	{
		// -(instancetype _Nonnull)initWithDataSets:(NSArray<id<IInterfaceChartDataSet>> * _Nullable)dataSets __attribute__((objc_designated_initializer));
		[Export("initWithDataSets:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] IInterfaceChartDataSet[] dataSets);

		// @property (nonatomic, strong) LineChartData * _Null_unspecified lineData;
		[Export("lineData", ArgumentSemantic.Strong)]
		LineChartData LineData { get; set; }

		// @property (nonatomic, strong) BarChartData * _Null_unspecified barData;
		[Export("barData", ArgumentSemantic.Strong)]
		BarChartData BarData { get; set; }

		// @property (nonatomic, strong) ScatterChartData * _Null_unspecified scatterData;
		[Export("scatterData", ArgumentSemantic.Strong)]
		ScatterChartData ScatterData { get; set; }

		// @property (nonatomic, strong) CandleChartData * _Null_unspecified candleData;
		[Export("candleData", ArgumentSemantic.Strong)]
		CandleChartData CandleData { get; set; }

		// @property (nonatomic, strong) BubbleChartData * _Null_unspecified bubbleData;
		[Export("bubbleData", ArgumentSemantic.Strong)]
		BubbleChartData BubbleData { get; set; }

		// -(void)calcMinMax;
		[Export("calcMinMax")]
		void CalcMinMax();

		// @property (readonly, copy, nonatomic) NSArray<ChartData *> * _Nonnull allData;
		[Export("allData", ArgumentSemantic.Copy)]
		ChartData[] AllData { get; }

		// -(ChartData * _Nonnull)dataByIndex:(NSInteger)index;
		[Export("dataByIndex:")]
		ChartData DataByIndex(nint index);

		// -(BOOL)removeDataSet:(id<IInterfaceChartDataSet> _Null_unspecified)dataSet;
		[Export("removeDataSet:")]
		bool RemoveDataSet(IInterfaceChartDataSet dataSet);

		// -(BOOL)removeDataSetByIndex:(NSInteger)index;
		[Export("removeDataSetByIndex:")]
		bool RemoveDataSetByIndex(nint index);

		// -(BOOL)removeEntry:(ChartDataEntry * _Nonnull)entry dataSetIndex:(NSInteger)dataSetIndex;
		[Export("removeEntry:dataSetIndex:")]
		bool RemoveEntry(ChartDataEntry entry, nint dataSetIndex);

		// -(BOOL)removeEntryWithXValue:(double)xValue dataSetIndex:(NSInteger)dataSetIndex;
		[Export("removeEntryWithXValue:dataSetIndex:")]
		bool RemoveEntryWithXValue(double xValue, nint dataSetIndex);

		// -(void)notifyDataChanged;
		[Export("notifyDataChanged")]
		void NotifyDataChanged();

		// -(ChartDataEntry * _Nullable)entryForHighlight:(ChartHighlight * _Nonnull)highlight;
		[Export("entryForHighlight:")]
		[return: NullAllowed]
		ChartDataEntry EntryForHighlight(ChartHighlight highlight);
	}

	interface IScatterChartDataProvider { }

	// @protocol ScatterChartDataProvider <BarLineScatterCandleBubbleChartDataProvider>
	[Protocol(Name = "_TtP6Charts24ScatterChartDataProvider_"), Model]
	interface ScatterChartDataProvider : BarLineScatterCandleBubbleChartDataProvider
	{
		// @required @property (readonly, nonatomic, strong) ScatterChartData * _Nullable scatterData;
		[Abstract]
		[NullAllowed, Export("scatterData", ArgumentSemantic.Strong)]
		ScatterChartData ScatterData { get; }
	}

	interface ILineChartDataProvider { }

	// @protocol LineChartDataProvider <BarLineScatterCandleBubbleChartDataProvider>
	[Protocol(Name = "_TtP6Charts21LineChartDataProvider_"), Model]
	interface LineChartDataProvider : BarLineScatterCandleBubbleChartDataProvider
	{
		// @required @property (readonly, nonatomic, strong) LineChartData * _Nullable lineData;
		[Abstract]
		[NullAllowed, Export("lineData", ArgumentSemantic.Strong)]
		LineChartData LineData { get; }

		// @required -(ChartYAxis * _Nonnull)getAxis:(enum AxisDependency)axis;
		[Abstract]
		[Export("getAxis:")]
		ChartYAxis GetAxis(AxisDependency axis);
	}

	interface ICombinedChartDataProvider { }

	// @protocol CombinedChartDataProvider <LineChartDataProvider, BarChartDataProvider, BubbleChartDataProvider, CandleChartDataProvider, ScatterChartDataProvider>
	[Protocol(Name = "_TtP6Charts25CombinedChartDataProvider_"), Model]
	interface CombinedChartDataProvider : LineChartDataProvider, BarChartDataProvider, BubbleChartDataProvider, CandleChartDataProvider, ScatterChartDataProvider
	{
		// @required @property (readonly, nonatomic, strong) CombinedChartData * _Nullable combinedData;
		[Abstract]
		[NullAllowed, Export("combinedData", ArgumentSemantic.Strong)]
		CombinedChartData CombinedData { get; }
	}

	// @interface CombinedChartRenderer : ChartDataRendererBase
	[BaseType(typeof(ChartDataRendererBase), Name = "_TtC6Charts21CombinedChartRenderer")]
	interface CombinedChartRenderer
	{
		// @property (nonatomic, weak) CombinedChartView * _Nullable chart;
		[NullAllowed, Export("chart", ArgumentSemantic.Weak)]
		CombinedChartView Chart { get; set; }

		// @property (nonatomic) BOOL drawValueAboveBarEnabled;
		[Export("drawValueAboveBarEnabled")]
		bool DrawValueAboveBarEnabled { get; set; }

		// @property (nonatomic) BOOL drawBarShadowEnabled;
		[Export("drawBarShadowEnabled")]
		bool DrawBarShadowEnabled { get; set; }

		// -(instancetype _Nonnull)initWithChart:(CombinedChartView * _Nullable)chart animator:(ChartAnimator * _Nonnull)animator viewPortHandler:(ChartViewPortHandler * _Nullable)viewPortHandler __attribute__((objc_designated_initializer));
		[Export("initWithChart:animator:viewPortHandler:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] CombinedChartView chart, ChartAnimator animator, [NullAllowed] ChartViewPortHandler viewPortHandler);

		// -(void)initBuffers __attribute__((objc_method_family("none")));
		[Export("initBuffers")]
		void InitBuffers();

		//u-n-safe void DrawDataWithContext(CGContextRef* context);

		//u-n-safe void DrawValuesWithContext(CGContextRef* context);

		//u-n-safe void DrawExtrasWithContext(CGContextRef* context);

		//u-n-safe void DrawHighlightedWithContext(CGContextRef* context, ChartHighlight[] indices);

		// -(ChartDataRendererBase * _Nullable)getSubRendererWithIndex:(NSInteger)index;
		[Export("getSubRendererWithIndex:")]
		[return: NullAllowed]
		ChartDataRendererBase GetSubRendererWithIndex(nint index);

		// @property (copy, nonatomic) NSArray<ChartDataRendererBase *> * _Nonnull subRenderers;
		[Export("subRenderers", ArgumentSemantic.Copy)]
		ChartDataRendererBase[] SubRenderers { get; set; }

		// @property (readonly, nonatomic) BOOL isDrawValueAboveBarEnabled;
		[Export("isDrawValueAboveBarEnabled")]
		bool IsDrawValueAboveBarEnabled { get; }

		// @property (readonly, nonatomic) BOOL isDrawBarShadowEnabled;
		[Export("isDrawBarShadowEnabled")]
		bool IsDrawBarShadowEnabled { get; }
	}

	// @interface CombinedChartView : BarLineChartViewBase <CombinedChartDataProvider>
	[BaseType(typeof(BarLineChartViewBase), Name = "_TtC6Charts17CombinedChartView")]
	interface CombinedChartView : ICombinedChartDataProvider
	{
		// -(void)initialize __attribute__((objc_method_family("none")));
		[Export("initialize")]
		void Initialize();

		// @property (nonatomic, strong) ChartData * _Nullable data;
		[NullAllowed, Export("data", ArgumentSemantic.Strong)]
		ChartData Data { get; set; }

		// @property (nonatomic, strong) id<InterfaceChartFillFormatter> _Nonnull fillFormatter;
		[Export("fillFormatter", ArgumentSemantic.Strong)]
		IInterfaceChartFillFormatter FillFormatter { get; set; }

		// -(ChartHighlight * _Nullable)getHighlightByTouchPoint:(CGPoint)pt;
		[Export("getHighlightByTouchPoint:")]
		[return: NullAllowed]
		ChartHighlight GetHighlightByTouchPoint(CGPoint pt);

		// @property (readonly, nonatomic, strong) CombinedChartData * _Nullable combinedData;
		[NullAllowed, Export("combinedData", ArgumentSemantic.Strong)]
		CombinedChartData CombinedData { get; }

		// @property (readonly, nonatomic, strong) LineChartData * _Nullable lineData;
		[NullAllowed, Export("lineData", ArgumentSemantic.Strong)]
		LineChartData LineData { get; }

		// @property (readonly, nonatomic, strong) BarChartData * _Nullable barData;
		[NullAllowed, Export("barData", ArgumentSemantic.Strong)]
		BarChartData BarData { get; }

		// @property (readonly, nonatomic, strong) ScatterChartData * _Nullable scatterData;
		[NullAllowed, Export("scatterData", ArgumentSemantic.Strong)]
		ScatterChartData ScatterData { get; }

		// @property (readonly, nonatomic, strong) CandleChartData * _Nullable candleData;
		[NullAllowed, Export("candleData", ArgumentSemantic.Strong)]
		CandleChartData CandleData { get; }

		// @property (readonly, nonatomic, strong) BubbleChartData * _Nullable bubbleData;
		[NullAllowed, Export("bubbleData", ArgumentSemantic.Strong)]
		BubbleChartData BubbleData { get; }

		// @property (nonatomic) BOOL drawValueAboveBarEnabled;
		[Export("drawValueAboveBarEnabled")]
		bool DrawValueAboveBarEnabled { get; set; }

		// @property (nonatomic) BOOL drawBarShadowEnabled;
		[Export("drawBarShadowEnabled")]
		bool DrawBarShadowEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isDrawValueAboveBarEnabled;
		[Export("isDrawValueAboveBarEnabled")]
		bool IsDrawValueAboveBarEnabled { get; }

		// @property (readonly, nonatomic) BOOL isDrawBarShadowEnabled;
		[Export("isDrawBarShadowEnabled")]
		bool IsDrawBarShadowEnabled { get; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nonnull drawOrder;
		[Export("drawOrder", ArgumentSemantic.Copy)]
		NSNumber[] DrawOrder { get; set; }

		// @property (nonatomic) BOOL highlightFullBarEnabled;
		[Export("highlightFullBarEnabled")]
		bool HighlightFullBarEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isHighlightFullBarEnabled;
		[Export("isHighlightFullBarEnabled")]
		bool IsHighlightFullBarEnabled { get; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor(CGRect frame);

		//// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		//[Export("initWithCoder:")]
		//[DesignatedInitializer]
		//IntPtr Constructor(NSCoder aDecoder);
	}

	// @interface CombinedChartHighlighter : ChartHighlighter
	[BaseType(typeof(ChartHighlighter))]
	interface CombinedChartHighlighter
	{
		// -(instancetype _Nonnull)initWithChart:(id<CombinedChartDataProvider> _Nonnull)chart barDataProvider:(id<BarChartDataProvider> _Nonnull)barDataProvider __attribute__((objc_designated_initializer));
		[Export("initWithChart:barDataProvider:")]
		[DesignatedInitializer]
		IntPtr Constructor(ICombinedChartDataProvider chart, IBarChartDataProvider barDataProvider);

		// -(NSArray<ChartHighlight *> * _Nonnull)getHighlightsWithXValue:(double)xValue x:(CGFloat)x y:(CGFloat)y;
		[Export("getHighlightsWithXValue:x:y:")]
		ChartHighlight[] GetHighlightsWithXValue(double xValue, nfloat x, nfloat y);
	}

	// @interface CrossShapeRenderer : NSObject <InterfaceShapeRenderer>
	[BaseType(typeof(NSObject), Name = "_TtC6Charts18CrossShapeRenderer")]
	interface CrossShapeRenderer : InterfaceShapeRenderer
	{
		//u-n-safe void RenderShapeWithContext(CGContextRef* context, IInterfaceScatterChartDataSet dataSet, ChartViewPortHandler viewPortHandler, CGPoint point, UIColor color);
	}

	// @interface ChartDataApproximator : NSObject
	[BaseType(typeof(NSObject))]
	interface ChartDataApproximator
	{
		[Static]
		[Export("reduceWithDouglasPeuker:tolerance:")]
		NSValue[] ReduceWithDouglasPeuker(NSValue[] points, nfloat tolerance);
	}

	interface IInterfaceChartAxisValueFormatter { }

	// @protocol InterfaceChartAxisValueFormatter <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject), Name = "IChartAxisValueFormatter")]
	interface InterfaceChartAxisValueFormatter
	{
		// @required -(NSString * _Nonnull)stringForValue:(double)value axis:(ChartAxisBase * _Nullable)axis;
		[Abstract]
		[Export("stringForValue:axis:")]
		string Axis(double value, [NullAllowed] ChartAxisBase axis);
	}

	// @interface ChartDefaultAxisValueFormatter : NSObject <InterfaceChartAxisValueFormatter>
	[BaseType(typeof(NSObject))]
	interface ChartDefaultAxisValueFormatter : InterfaceChartAxisValueFormatter
	{
		// @property (copy, nonatomic) NSString * _Nonnull (^ _Nullable)(double, ChartAxisBase * _Nullable) block;
		[NullAllowed, Export("block", ArgumentSemantic.Copy)]
		Func<double, ChartAxisBase, NSString> Block { get; set; }

		// @property (nonatomic) BOOL hasAutoDecimals;
		[Export("hasAutoDecimals")]
		bool HasAutoDecimals { get; set; }

		// @property (nonatomic, strong) NSNumberFormatter * _Nullable formatter;
		[NullAllowed, Export("formatter", ArgumentSemantic.Strong)]
		NSNumberFormatter Formatter { get; set; }

		// -(instancetype _Nonnull)initWithFormatter:(NSNumberFormatter * _Nonnull)formatter __attribute__((objc_designated_initializer));
		[Export("initWithFormatter:")]
		[DesignatedInitializer]
		IntPtr Constructor(NSNumberFormatter formatter);

		// -(instancetype _Nonnull)initWithDecimals:(NSInteger)decimals __attribute__((objc_designated_initializer));
		[Export("initWithDecimals:")]
		[DesignatedInitializer]
		IntPtr Constructor(nint decimals);

		// -(instancetype _Nonnull)initWithBlock:(NSString * _Nonnull (^ _Nonnull)(double, ChartAxisBase * _Nullable))block __attribute__((objc_designated_initializer));
		[Export("initWithBlock:")]
		[DesignatedInitializer]
		IntPtr Constructor(Func<double, ChartAxisBase, NSString> block);

		// +(ChartDefaultAxisValueFormatter * _Nullable)withBlock:(NSString * _Nonnull (^ _Nonnull)(double, ChartAxisBase * _Nullable))block;
		[Static]
		[Export("withBlock:")]
		[return: NullAllowed]
		ChartDefaultAxisValueFormatter WithBlock(Func<double, ChartAxisBase, NSString> block);

		// -(NSString * _Nonnull)stringForValue:(double)value axis:(ChartAxisBase * _Nullable)axis;
		[Export("stringForValue:axis:")]
		string Axis(double value, [NullAllowed] ChartAxisBase axis);
	}

	interface IInterfaceChartFillFormatter { }

	// @protocol InterfaceChartFillFormatter
	[Protocol(Name = "IChartFillFormatter"), Model]
	interface InterfaceChartFillFormatter
	{
		// @required -(CGFloat)getFillLinePositionWithDataSet:(id<IInterfaceLineChartDataSet> _Nonnull)dataSet dataProvider:(id<LineChartDataProvider> _Nonnull)dataProvider;
		[Abstract]
		[Export("getFillLinePositionWithDataSet:dataProvider:")]
		nfloat DataProvider(IInterfaceLineChartDataSet dataSet, ILineChartDataProvider dataProvider);
	}

	// @interface ChartDefaultFillFormatter : NSObject <InterfaceChartFillFormatter>
	[BaseType(typeof(NSObject))]
	interface ChartDefaultFillFormatter : InterfaceChartFillFormatter
	{
		// @property (copy, nonatomic) CGFloat (^ _Nullable)(id<IInterfaceLineChartDataSet> _Nonnull, id<LineChartDataProvider> _Nonnull) block;
		[NullAllowed, Export("block", ArgumentSemantic.Copy)]
		Func<IInterfaceLineChartDataSet, ILineChartDataProvider, nfloat> Block { get; set; }

		// -(instancetype _Nonnull)initWithBlock:(CGFloat (^ _Nonnull)(id<IInterfaceLineChartDataSet> _Nonnull, id<LineChartDataProvider> _Nonnull))block __attribute__((objc_designated_initializer));
		[Export("initWithBlock:")]
		[DesignatedInitializer]
		IntPtr Constructor(Func<IInterfaceLineChartDataSet, ILineChartDataProvider, nfloat> block);

		// +(ChartDefaultFillFormatter * _Nullable)withBlock:(CGFloat (^ _Nonnull)(id<IInterfaceLineChartDataSet> _Nonnull, id<LineChartDataProvider> _Nonnull))block;
		[Static]
		[Export("withBlock:")]
		[return: NullAllowed]
		ChartDefaultFillFormatter WithBlock(Func<IInterfaceLineChartDataSet, ILineChartDataProvider, nfloat> block);

		//// -(CGFloat)getFillLinePositionWithDataSet:(id<IInterfaceLineChartDataSet> _Nonnull)dataSet dataProvider:(id<LineChartDataProvider> _Nonnull)dataProvider;
		//[Export("getFillLinePositionWithDataSet:dataProvider:")]
		//nfloat GetFillLinePositionWithDataSet(IInterfaceLineChartDataSet dataSet, ILineChartDataProvider dataProvider);
	}

	interface IInterfaceChartValueFormatter { }

	// @protocol InterfaceChartValueFormatter <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject), Name = "IChartValueFormatter")]
	interface InterfaceChartValueFormatter
	{
		// @required -(NSString * _Nonnull)stringForValue:(double)value entry:(ChartDataEntry * _Nonnull)entry dataSetIndex:(NSInteger)dataSetIndex viewPortHandler:(ChartViewPortHandler * _Nullable)viewPortHandler;
		[Abstract]
		[Export("stringForValue:entry:dataSetIndex:viewPortHandler:")]
		string Entry(double value, ChartDataEntry entry, nint dataSetIndex, [NullAllowed] ChartViewPortHandler viewPortHandler);
	}

	// @interface ChartDefaultValueFormatter : NSObject <InterfaceChartValueFormatter>
	[BaseType(typeof(NSObject))]
	interface ChartDefaultValueFormatter : InterfaceChartValueFormatter
	{
		// @property (copy, nonatomic) NSString * _Nonnull (^ _Nullable)(double, ChartDataEntry * _Nonnull, NSInteger, ChartViewPortHandler * _Nullable) block;
		[NullAllowed, Export("block", ArgumentSemantic.Copy)]
		Func<double, ChartDataEntry, nint, ChartViewPortHandler, NSString> Block { get; set; }

		// @property (nonatomic) BOOL hasAutoDecimals;
		[Export("hasAutoDecimals")]
		bool HasAutoDecimals { get; set; }

		// @property (nonatomic, strong) NSNumberFormatter * _Nullable formatter;
		[NullAllowed, Export("formatter", ArgumentSemantic.Strong)]
		NSNumberFormatter Formatter { get; set; }

		// -(instancetype _Nonnull)initWithFormatter:(NSNumberFormatter * _Nonnull)formatter __attribute__((objc_designated_initializer));
		[Export("initWithFormatter:")]
		[DesignatedInitializer]
		IntPtr Constructor(NSNumberFormatter formatter);

		// -(instancetype _Nonnull)initWithDecimals:(NSInteger)decimals __attribute__((objc_designated_initializer));
		[Export("initWithDecimals:")]
		[DesignatedInitializer]
		IntPtr Constructor(nint decimals);

		// -(instancetype _Nonnull)initWithBlock:(NSString * _Nonnull (^ _Nonnull)(double, ChartDataEntry * _Nonnull, NSInteger, ChartViewPortHandler * _Nullable))block __attribute__((objc_designated_initializer));
		[Export("initWithBlock:")]
		[DesignatedInitializer]
		IntPtr Constructor(Func<double, ChartDataEntry, nint, ChartViewPortHandler, NSString> block);

		// +(ChartDefaultValueFormatter * _Nullable)withBlock:(NSString * _Nonnull (^ _Nonnull)(double, ChartDataEntry * _Nonnull, NSInteger, ChartViewPortHandler * _Nullable))block;
		[Static]
		[Export("withBlock:")]
		[return: NullAllowed]
		ChartDefaultValueFormatter WithBlock(Func<double, ChartDataEntry, nint, ChartViewPortHandler, NSString> block);

		//// -(NSString * _Nonnull)stringForValue:(double)value entry:(ChartDataEntry * _Nonnull)entry dataSetIndex:(NSInteger)dataSetIndex viewPortHandler:(ChartViewPortHandler * _Nullable)viewPortHandler;
		//[Export("stringForValue:entry:dataSetIndex:viewPortHandler:")]
		//string StringForValue(double value, ChartDataEntry entry, nint dataSetIndex, [NullAllowed] ChartViewPortHandler viewPortHandler);
	}

	// @interface ChartDescription : ChartComponentBase
	[BaseType(typeof(ChartComponentBase))]
	interface ChartDescription
	{
		// @property (copy, nonatomic) NSString * _Nullable text;
		[NullAllowed, Export("text")]
		string Text { get; set; }

		//// @property (nonatomic) NSTextAlignment textAlign;
		//[Export("textAlign", ArgumentSemantic.Assign)]
		//NSTextAlignment TextAlign { get; set; }

		// @property (nonatomic, strong) UIFont * _Nonnull font;
		[Export("font", ArgumentSemantic.Strong)]
		UIFont Font { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull textColor;
		[Export("textColor", ArgumentSemantic.Strong)]
		UIColor TextColor { get; set; }
	}

	// @interface ChartFill : NSObject
	[BaseType(typeof(NSObject))]
	interface ChartFill
	{
		// @property (readonly, nonatomic) enum ChartFillType type;
		[Export("type")]
		ChartFillType Type { get; }

		//u-n-safe CGColorRef* Color { get; }

		//u-n-safe CGGradientRef* Gradient { get; }

		// @property (readonly, nonatomic) CGFloat gradientAngle;
		[Export("gradientAngle")]
		nfloat GradientAngle { get; }

		// @property (readonly, nonatomic) CGPoint gradientStartOffsetPercent;
		[Export("gradientStartOffsetPercent")]
		CGPoint GradientStartOffsetPercent { get; }

		// @property (readonly, nonatomic) CGFloat gradientStartRadiusPercent;
		[Export("gradientStartRadiusPercent")]
		nfloat GradientStartRadiusPercent { get; }

		// @property (readonly, nonatomic) CGPoint gradientEndOffsetPercent;
		[Export("gradientEndOffsetPercent")]
		CGPoint GradientEndOffsetPercent { get; }

		// @property (readonly, nonatomic) CGFloat gradientEndRadiusPercent;
		[Export("gradientEndRadiusPercent")]
		nfloat GradientEndRadiusPercent { get; }

		//u-n-safe CGImageRef* Image { get; }

		//u-n-safe CGLayerRef* Layer { get; }

		//u-n-safe IntPtr Constructor(CGColorRef* CGColor);

		// -(instancetype _Nonnull)initWithColor:(UIColor * _Nonnull)color;
		[Export("initWithColor:")]
		IntPtr Constructor(UIColor color);

		//u-n-safe IntPtr Constructor(CGGradientRef* linearGradient, nfloat angle);

		//u-n-safe IntPtr Constructor(CGGradientRef* radialGradient, CGPoint startOffsetPercent, nfloat startRadiusPercent, CGPoint endOffsetPercent, nfloat endRadiusPercent);

		//u-n-safe IntPtr Constructor(CGGradientRef* radialGradient);

		//u-n-safe IntPtr Constructor(CGImageRef* CGImage, bool tiled);

		// -(instancetype _Nonnull)initWithImage:(UIImage * _Nonnull)image tiled:(BOOL)tiled;
		[Export("initWithImage:tiled:")]
		IntPtr Constructor(UIImage image, bool tiled);

		//u-n-safe IntPtr Constructor(CGImageRef* CGImage);

		// -(instancetype _Nonnull)initWithImage:(UIImage * _Nonnull)image;
		[Export("initWithImage:")]
		IntPtr Constructor(UIImage image);

		//u-n-safe IntPtr Constructor(CGLayerRef* CGLayer);

		//u-n-safe ChartFill FillWithCGColor(CGColorRef* CGColor);

		// +(ChartFill * _Nonnull)fillWithColor:(UIColor * _Nonnull)color;
		[Static]
		[Export("fillWithColor:")]
		ChartFill FillWithColor(UIColor color);

		//u-n-safe ChartFill FillWithLinearGradient(CGGradientRef* linearGradient, nfloat angle);

		//u-n-safe ChartFill FillWithRadialGradient(CGGradientRef* radialGradient, CGPoint startOffsetPercent, nfloat startRadiusPercent, CGPoint endOffsetPercent, nfloat endRadiusPercent);

		//u-n-safe ChartFill FillWithRadialGradient(CGGradientRef* radialGradient);

		//u-n-safe ChartFill FillWithCGImage(CGImageRef* CGImage, bool tiled);

		// +(ChartFill * _Nonnull)fillWithImage:(UIImage * _Nonnull)image tiled:(BOOL)tiled;
		[Static]
		[Export("fillWithImage:tiled:")]
		ChartFill FillWithImage(UIImage image, bool tiled);

		//u-n-safe ChartFill FillWithCGImage(CGImageRef* CGImage);

		// +(ChartFill * _Nonnull)fillWithImage:(UIImage * _Nonnull)image;
		[Static]
		[Export("fillWithImage:")]
		ChartFill FillWithImage(UIImage image);

		//u-n-safe ChartFill FillWithCGLayer(CGLayerRef* CGLayer);

		//u-n-safe void FillPathWithContext(CGContextRef* context, CGRect rect);
	}

	// @interface ChartHighlight : NSObject
	[BaseType(typeof(NSObject))]
	interface ChartHighlight
	{
		// @property (nonatomic) NSInteger dataIndex;
		[Export("dataIndex")]
		nint DataIndex { get; set; }

		// @property (nonatomic) CGFloat drawX;
		[Export("drawX")]
		nfloat DrawX { get; set; }

		// @property (nonatomic) CGFloat drawY;
		[Export("drawY")]
		nfloat DrawY { get; set; }

		// -(instancetype _Nonnull)initWithX:(double)x y:(double)y xPx:(CGFloat)xPx yPx:(CGFloat)yPx dataIndex:(NSInteger)dataIndex dataSetIndex:(NSInteger)dataSetIndex stackIndex:(NSInteger)stackIndex axis:(enum AxisDependency)axis __attribute__((objc_designated_initializer));
		[Export("initWithX:y:xPx:yPx:dataIndex:dataSetIndex:stackIndex:axis:")]
		[DesignatedInitializer]
		IntPtr Constructor(double x, double y, nfloat xPx, nfloat yPx, nint dataIndex, nint dataSetIndex, nint stackIndex, AxisDependency axis);

		// -(instancetype _Nonnull)initWithX:(double)x y:(double)y xPx:(CGFloat)xPx yPx:(CGFloat)yPx dataSetIndex:(NSInteger)dataSetIndex stackIndex:(NSInteger)stackIndex axis:(enum AxisDependency)axis;
		[Export("initWithX:y:xPx:yPx:dataSetIndex:stackIndex:axis:")]
		IntPtr Constructor(double x, double y, nfloat xPx, nfloat yPx, nint dataSetIndex, nint stackIndex, AxisDependency axis);

		// -(instancetype _Nonnull)initWithX:(double)x y:(double)y xPx:(CGFloat)xPx yPx:(CGFloat)yPx dataSetIndex:(NSInteger)dataSetIndex axis:(enum AxisDependency)axis __attribute__((objc_designated_initializer));
		[Export("initWithX:y:xPx:yPx:dataSetIndex:axis:")]
		[DesignatedInitializer]
		IntPtr Constructor(double x, double y, nfloat xPx, nfloat yPx, nint dataSetIndex, AxisDependency axis);

		// -(instancetype _Nonnull)initWithX:(double)x y:(double)y dataSetIndex:(NSInteger)dataSetIndex __attribute__((objc_designated_initializer));
		[Export("initWithX:y:dataSetIndex:")]
		[DesignatedInitializer]
		IntPtr Constructor(double x, double y, nint dataSetIndex);

		// -(instancetype _Nonnull)initWithX:(double)x dataSetIndex:(NSInteger)dataSetIndex stackIndex:(NSInteger)stackIndex;
		[Export("initWithX:dataSetIndex:stackIndex:")]
		IntPtr Constructor(double x, nint dataSetIndex, nint stackIndex);

		// @property (readonly, nonatomic) double x;
		[Export("x")]
		double X { get; }

		// @property (readonly, nonatomic) double y;
		[Export("y")]
		double Y { get; }

		// @property (readonly, nonatomic) CGFloat xPx;
		[Export("xPx")]
		nfloat XPx { get; }

		// @property (readonly, nonatomic) CGFloat yPx;
		[Export("yPx")]
		nfloat YPx { get; }

		// @property (readonly, nonatomic) NSInteger dataSetIndex;
		[Export("dataSetIndex")]
		nint DataSetIndex { get; }

		// @property (readonly, nonatomic) NSInteger stackIndex;
		[Export("stackIndex")]
		nint StackIndex { get; }

		// @property (readonly, nonatomic) enum AxisDependency axis;
		[Export("axis")]
		AxisDependency Axis { get; }

		// @property (readonly, nonatomic) BOOL isStacked;
		[Export("isStacked")]
		bool IsStacked { get; }

		// -(void)setDrawWithX:(CGFloat)x y:(CGFloat)y;
		[Export("setDrawWithX:y:")]
		void SetDrawWithX(nfloat x, nfloat y);

		// -(void)setDrawWithPt:(CGPoint)pt;
		[Export("setDrawWithPt:")]
		void SetDrawWithPt(CGPoint pt);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export("description")]
		string Description { get; }

		// -(BOOL)isEqual:(id _Nullable)object;
		[Export("isEqual:")]
		bool IsEqual([NullAllowed] NSObject @object);
	}

	// @interface HorizontalBarChartRenderer : BarChartRenderer
	[BaseType(typeof(BarChartRenderer), Name = "_TtC6Charts26HorizontalBarChartRenderer")]
	interface HorizontalBarChartRenderer
	{
		// -(instancetype _Nonnull)initWithDataProvider:(id<BarChartDataProvider> _Nullable)dataProvider animator:(ChartAnimator * _Nullable)animator viewPortHandler:(ChartViewPortHandler * _Nullable)viewPortHandler __attribute__((objc_designated_initializer));
		[Export("initWithDataProvider:animator:viewPortHandler:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] IBarChartDataProvider dataProvider, [NullAllowed] ChartAnimator animator, [NullAllowed] ChartViewPortHandler viewPortHandler);

		// -(void)initBuffers __attribute__((objc_method_family("none")));
		[Export("initBuffers")]
		void InitBuffers();

		//u-n-safe void DrawDataSetWithContext(CGContextRef* context, IInterfaceBarChartDataSet dataSet, nint index);

		//u-n-safe void DrawValuesWithContext(CGContextRef* context);

		// -(BOOL)isDrawingValuesAllowedWithDataProvider:(id<ChartDataProvider> _Nullable)dataProvider;
		[Export("isDrawingValuesAllowedWithDataProvider:")]
		bool IsDrawingValuesAllowedWithDataProvider([NullAllowed] IChartDataProvider dataProvider);
	}

	// @interface HorizontalBarChartView : BarChartView
	[BaseType(typeof(BarChartView), Name = "_TtC6Charts22HorizontalBarChartView")]
	interface HorizontalBarChartView
	{
		// -(CGPoint)getMarkerPositionWithHighlight:(ChartHighlight * _Nonnull)highlight;
		[Export("getMarkerPositionWithHighlight:")]
		CGPoint GetMarkerPositionWithHighlight(ChartHighlight highlight);

		// -(CGRect)getBarBoundsWithEntry:(BarChartDataEntry * _Nonnull)e;
		[Export("getBarBoundsWithEntry:")]
		CGRect GetBarBoundsWithEntry(BarChartDataEntry e);

		// -(CGPoint)getPositionWithEntry:(ChartDataEntry * _Nonnull)e axis:(enum AxisDependency)axis;
		[Export("getPositionWithEntry:axis:")]
		CGPoint GetPositionWithEntry(ChartDataEntry e, AxisDependency axis);

		// -(ChartHighlight * _Nullable)getHighlightByTouchPoint:(CGPoint)pt;
		[Export("getHighlightByTouchPoint:")]
		[return: NullAllowed]
		ChartHighlight GetHighlightByTouchPoint(CGPoint pt);

		// @property (readonly, nonatomic) double lowestVisibleX;
		[Export("lowestVisibleX")]
		double LowestVisibleX { get; }

		// @property (readonly, nonatomic) double highestVisibleX;
		[Export("highestVisibleX")]
		double HighestVisibleX { get; }

		// -(void)setVisibleXRangeMaximum:(double)maxXRange;
		[Export("setVisibleXRangeMaximum:")]
		void SetVisibleXRangeMaximum(double maxXRange);

		// -(void)setVisibleXRangeMinimum:(double)minXRange;
		[Export("setVisibleXRangeMinimum:")]
		void SetVisibleXRangeMinimum(double minXRange);

		// -(void)setVisibleXRangeWithMinXRange:(double)minXRange maxXRange:(double)maxXRange;
		[Export("setVisibleXRangeWithMinXRange:maxXRange:")]
		void SetVisibleXRangeWithMinXRange(double minXRange, double maxXRange);

		// -(void)setVisibleYRangeMaximum:(double)maxYRange axis:(enum AxisDependency)axis;
		[Export("setVisibleYRangeMaximum:axis:")]
		void SetVisibleYRangeMaximum(double maxYRange, AxisDependency axis);

		// -(void)setVisibleYRangeMinimum:(double)minYRange axis:(enum AxisDependency)axis;
		[Export("setVisibleYRangeMinimum:axis:")]
		void SetVisibleYRangeMinimum(double minYRange, AxisDependency axis);

		// -(void)setVisibleYRangeWithMinYRange:(double)minYRange maxYRange:(double)maxYRange axis:(enum AxisDependency)axis;
		[Export("setVisibleYRangeWithMinYRange:maxYRange:axis:")]
		void SetVisibleYRangeWithMinYRange(double minYRange, double maxYRange, AxisDependency axis);

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor(CGRect frame);

		//// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		//[Export("initWithCoder:")]
		//[DesignatedInitializer]
		//IntPtr Constructor(NSCoder aDecoder);
	}

	// @interface HorizontalBarChartHighlighter : BarChartHighlighter
	[BaseType(typeof(BarChartHighlighter))]
	interface HorizontalBarChartHighlighter
	{
		// -(ChartHighlight * _Nullable)getHighlightWithX:(CGFloat)x y:(CGFloat)y;
		[Export("getHighlightWithX:y:")]
		[return: NullAllowed]
		ChartHighlight GetHighlightWithX(nfloat x, nfloat y);

		// -(instancetype _Nonnull)initWithChart:(id<ChartDataProvider> _Nonnull)chart __attribute__((objc_designated_initializer));
		[Export("initWithChart:")]
		[DesignatedInitializer]
		IntPtr Constructor(IChartDataProvider chart);
	}

	interface IInterfaceLineRadarChartDataSet { }

	// @protocol IInterfaceLineRadarChartDataSet <IInterfaceLineScatterCandleRadarChartDataSet>
	[Protocol(Name = "_TtP6Charts22ILineRadarChartDataSet_"), Model]
	interface InterfaceLineRadarChartDataSet : InterfaceLineScatterCandleRadarChartDataSet
	{
		// @required @property (nonatomic, strong) UIColor * _Nonnull fillColor;
		[Abstract]
		[Export("fillColor", ArgumentSemantic.Strong)]
		UIColor FillColor { get; set; }

		// @required @property (nonatomic, strong) ChartFill * _Nullable fill;
		[Abstract]
		[NullAllowed, Export("fill", ArgumentSemantic.Strong)]
		ChartFill Fill { get; set; }

		// @required @property (nonatomic) CGFloat fillAlpha;
		[Abstract]
		[Export("fillAlpha")]
		nfloat FillAlpha { get; set; }

		// @required @property (nonatomic) CGFloat lineWidth;
		[Abstract]
		[Export("lineWidth")]
		nfloat LineWidth { get; set; }

		// @required @property (nonatomic) BOOL drawFilledEnabled;
		[Abstract]
		[Export("drawFilledEnabled")]
		bool DrawFilledEnabled { get; set; }

		// @required @property (readonly, nonatomic) BOOL isDrawFilledEnabled;
		[Abstract]
		[Export("isDrawFilledEnabled")]
		bool IsDrawFilledEnabled { get; }
	}

	interface IInterfaceLineChartDataSet { }

	// @protocol IInterfaceLineChartDataSet <IInterfaceLineRadarChartDataSet>
	[Protocol(Name = "_TtP6Charts17ILineChartDataSet_"), Model]
	interface InterfaceLineChartDataSet : InterfaceLineRadarChartDataSet
	{
		// @required @property (nonatomic) enum LineChartMode mode;
		[Abstract]
		[Export("mode", ArgumentSemantic.Assign)]
		LineChartMode Mode { get; set; }

		// @required @property (nonatomic) CGFloat cubicIntensity;
		[Abstract]
		[Export("cubicIntensity")]
		nfloat CubicIntensity { get; set; }

		// @required @property (nonatomic) BOOL drawCubicEnabled;
		[Abstract]
		[Export("drawCubicEnabled")]
		bool DrawCubicEnabled { get; set; }

		// @required @property (readonly, nonatomic) BOOL isDrawCubicEnabled;
		[Abstract]
		[Export("isDrawCubicEnabled")]
		bool IsDrawCubicEnabled { get; }

		// @required @property (nonatomic) BOOL drawSteppedEnabled;
		[Abstract]
		[Export("drawSteppedEnabled")]
		bool DrawSteppedEnabled { get; set; }

		// @required @property (readonly, nonatomic) BOOL isDrawSteppedEnabled;
		[Abstract]
		[Export("isDrawSteppedEnabled")]
		bool IsDrawSteppedEnabled { get; }

		// @required @property (nonatomic) CGFloat circleRadius;
		[Abstract]
		[Export("circleRadius")]
		nfloat CircleRadius { get; set; }

		// @required @property (nonatomic) CGFloat circleHoleRadius;
		[Abstract]
		[Export("circleHoleRadius")]
		nfloat CircleHoleRadius { get; set; }

		// @required @property (copy, nonatomic) NSArray<UIColor *> * _Nonnull circleColors;
		[Abstract]
		[Export("circleColors", ArgumentSemantic.Copy)]
		UIColor[] CircleColors { get; set; }

		// @required -(UIColor * _Nullable)getCircleColorAtIndex:(NSInteger)atIndex;
		[Abstract]
		[Export("getCircleColorAtIndex:")]
		[return: NullAllowed]
		UIColor GetCircleColorAtIndex(nint atIndex);

		// @required -(void)setCircleColor:(UIColor * _Nonnull)color;
		[Abstract]
		[Export("setCircleColor:")]
		void SetCircleColor(UIColor color);

		// @required -(void)resetCircleColors:(NSInteger)index;
		[Abstract]
		[Export("resetCircleColors:")]
		void ResetCircleColors(nint index);

		// @required @property (nonatomic) BOOL drawCirclesEnabled;
		[Abstract]
		[Export("drawCirclesEnabled")]
		bool DrawCirclesEnabled { get; set; }

		// @required @property (readonly, nonatomic) BOOL isDrawCirclesEnabled;
		[Abstract]
		[Export("isDrawCirclesEnabled")]
		bool IsDrawCirclesEnabled { get; }

		// @required @property (nonatomic, strong) UIColor * _Nullable circleHoleColor;
		[Abstract]
		[NullAllowed, Export("circleHoleColor", ArgumentSemantic.Strong)]
		UIColor CircleHoleColor { get; set; }

		// @required @property (nonatomic) BOOL drawCircleHoleEnabled;
		[Abstract]
		[Export("drawCircleHoleEnabled")]
		bool DrawCircleHoleEnabled { get; set; }

		// @required @property (readonly, nonatomic) BOOL isDrawCircleHoleEnabled;
		[Abstract]
		[Export("isDrawCircleHoleEnabled")]
		bool IsDrawCircleHoleEnabled { get; }

		// @required @property (readonly, nonatomic) CGFloat lineDashPhase;
		[Abstract]
		[Export("lineDashPhase")]
		nfloat LineDashPhase { get; }

		// @required @property (copy, nonatomic) NSArray<NSNumber *> * _Nullable lineDashLengths;
		[Abstract]
		[NullAllowed, Export("lineDashLengths", ArgumentSemantic.Copy)]
		NSNumber[] LineDashLengths { get; set; }

		// @required @property (nonatomic) CGLineCap lineCapType;
		[Abstract]
		[Export("lineCapType", ArgumentSemantic.Assign)]
		CGLineCap LineCapType { get; set; }

		// @required @property (nonatomic, strong) id<InterfaceChartFillFormatter> _Nullable fillFormatter;
		[Abstract]
		[NullAllowed, Export("fillFormatter", ArgumentSemantic.Strong)]
		IInterfaceChartFillFormatter FillFormatter { get; set; }
	}

	interface IInterfaceChartMarker { }

	// @protocol InterfaceChartMarker <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject), Name = "IChartMarker")]
	interface InterfaceChartMarker
	{
		// @required @property (readonly, nonatomic) CGPoint offset;
		[Abstract]
		[Export("offset")]
		CGPoint Offset { get; }

		// @required -(CGPoint)offsetForDrawingAtPoint:(CGPoint)atPoint;
		[Abstract]
		[Export("offsetForDrawingAtPoint:")]
		CGPoint OffsetForDrawingAtPoint(CGPoint atPoint);

		// @required -(void)refreshContentWithEntry:(ChartDataEntry * _Nonnull)entry highlight:(ChartHighlight * _Nonnull)highlight;
		[Abstract]
		[Export("refreshContentWithEntry:highlight:")]
		void RefreshContentWithEntry(ChartDataEntry entry, ChartHighlight highlight);

		//u-n-safe void DrawWithContext(CGContextRef* context, CGPoint point);
	}

	interface IInterfacePieChartDataSet { }

	// @protocol IInterfacePieChartDataSet <IInterfaceChartDataSet>
	[Protocol(Name = "_TtP6Charts16IPieChartDataSet_"), Model]
	interface InterfacePieChartDataSet : InterfaceChartDataSet
	{
		// @required @property (nonatomic) CGFloat sliceSpace;
		[Abstract]
		[Export("sliceSpace")]
		nfloat SliceSpace { get; set; }

		// @required @property (nonatomic) BOOL automaticallyDisableSliceSpacing;
		[Abstract]
		[Export("automaticallyDisableSliceSpacing")]
		bool AutomaticallyDisableSliceSpacing { get; set; }

		// @required @property (nonatomic) CGFloat selectionShift;
		[Abstract]
		[Export("selectionShift")]
		nfloat SelectionShift { get; set; }

		// @required @property (nonatomic) enum PieChartValuePosition xValuePosition;
		[Abstract]
		[Export("xValuePosition", ArgumentSemantic.Assign)]
		PieChartValuePosition XValuePosition { get; set; }

		// @required @property (nonatomic) enum PieChartValuePosition yValuePosition;
		[Abstract]
		[Export("yValuePosition", ArgumentSemantic.Assign)]
		PieChartValuePosition YValuePosition { get; set; }

		// @required @property (nonatomic, strong) UIColor * _Nullable valueLineColor;
		[Abstract]
		[NullAllowed, Export("valueLineColor", ArgumentSemantic.Strong)]
		UIColor ValueLineColor { get; set; }

		// @required @property (nonatomic) CGFloat valueLineWidth;
		[Abstract]
		[Export("valueLineWidth")]
		nfloat ValueLineWidth { get; set; }

		// @required @property (nonatomic) CGFloat valueLinePart1OffsetPercentage;
		[Abstract]
		[Export("valueLinePart1OffsetPercentage")]
		nfloat ValueLinePart1OffsetPercentage { get; set; }

		// @required @property (nonatomic) CGFloat valueLinePart1Length;
		[Abstract]
		[Export("valueLinePart1Length")]
		nfloat ValueLinePart1Length { get; set; }

		// @required @property (nonatomic) CGFloat valueLinePart2Length;
		[Abstract]
		[Export("valueLinePart2Length")]
		nfloat ValueLinePart2Length { get; set; }

		// @required @property (nonatomic) BOOL valueLineVariableLength;
		[Abstract]
		[Export("valueLineVariableLength")]
		bool ValueLineVariableLength { get; set; }

		// @required @property (nonatomic, strong) UIFont * _Nullable entryLabelFont;
		[Abstract]
		[NullAllowed, Export("entryLabelFont", ArgumentSemantic.Strong)]
		UIFont EntryLabelFont { get; set; }

		// @required @property (nonatomic, strong) UIColor * _Nullable entryLabelColor;
		[Abstract]
		[NullAllowed, Export("entryLabelColor", ArgumentSemantic.Strong)]
		UIColor EntryLabelColor { get; set; }
	}

	interface IInterfaceRadarChartDataSet { }

	// @protocol IInterfaceRadarChartDataSet <IInterfaceLineRadarChartDataSet>
	[Protocol(Name = "_TtP6Charts18IRadarChartDataSet_"), Model]
	interface InterfaceRadarChartDataSet : InterfaceLineRadarChartDataSet
	{
		// @required @property (nonatomic) BOOL drawHighlightCircleEnabled;
		[Abstract]
		[Export("drawHighlightCircleEnabled")]
		bool DrawHighlightCircleEnabled { get; set; }

		// @required @property (readonly, nonatomic) BOOL isDrawHighlightCircleEnabled;
		[Abstract]
		[Export("isDrawHighlightCircleEnabled")]
		bool IsDrawHighlightCircleEnabled { get; }

		// @required @property (nonatomic, strong) UIColor * _Nullable highlightCircleFillColor;
		[Abstract]
		[NullAllowed, Export("highlightCircleFillColor", ArgumentSemantic.Strong)]
		UIColor HighlightCircleFillColor { get; set; }

		// @required @property (nonatomic, strong) UIColor * _Nullable highlightCircleStrokeColor;
		[Abstract]
		[NullAllowed, Export("highlightCircleStrokeColor", ArgumentSemantic.Strong)]
		UIColor HighlightCircleStrokeColor { get; set; }

		// @required @property (nonatomic) CGFloat highlightCircleStrokeAlpha;
		[Abstract]
		[Export("highlightCircleStrokeAlpha")]
		nfloat HighlightCircleStrokeAlpha { get; set; }

		// @required @property (nonatomic) CGFloat highlightCircleInnerRadius;
		[Abstract]
		[Export("highlightCircleInnerRadius")]
		nfloat HighlightCircleInnerRadius { get; set; }

		// @required @property (nonatomic) CGFloat highlightCircleOuterRadius;
		[Abstract]
		[Export("highlightCircleOuterRadius")]
		nfloat HighlightCircleOuterRadius { get; set; }

		// @required @property (nonatomic) CGFloat highlightCircleStrokeWidth;
		[Abstract]
		[Export("highlightCircleStrokeWidth")]
		nfloat HighlightCircleStrokeWidth { get; set; }
	}

	interface IInterfaceScatterChartDataSet { }

	// @protocol IInterfaceScatterChartDataSet <IInterfaceLineScatterCandleRadarChartDataSet>
	[Protocol(Name = "_TtP6Charts20IScatterChartDataSet_"), Model]
	interface InterfaceScatterChartDataSet : InterfaceLineScatterCandleRadarChartDataSet
	{
		// @required @property (readonly, nonatomic) CGFloat scatterShapeSize;
		[Abstract]
		[Export("scatterShapeSize")]
		nfloat ScatterShapeSize { get; }

		// @required @property (readonly, nonatomic) CGFloat scatterShapeHoleRadius;
		[Abstract]
		[Export("scatterShapeHoleRadius")]
		nfloat ScatterShapeHoleRadius { get; }

		// @required @property (readonly, nonatomic, strong) UIColor * _Nullable scatterShapeHoleColor;
		[Abstract]
		[NullAllowed, Export("scatterShapeHoleColor", ArgumentSemantic.Strong)]
		UIColor ScatterShapeHoleColor { get; }

		// @required @property (readonly, nonatomic, strong) id<InterfaceShapeRenderer> _Nullable shapeRenderer;
		[Abstract]
		[NullAllowed, Export("shapeRenderer", ArgumentSemantic.Strong)]
		IInterfaceShapeRenderer ShapeRenderer { get; }
	}

	// @interface ChartIndexAxisValueFormatter : NSObject <IChartAxisValueFormatter>
	[BaseType(typeof(NSObject))]
	interface ChartIndexAxisValueFormatter : InterfaceChartAxisValueFormatter
	{
		// @property (copy, nonatomic) NSArray<NSString *> * _Nonnull values;
		[Export("values", ArgumentSemantic.Copy)]
		string[] Values { get; set; }

		// -(instancetype _Nonnull)initWithValues:(NSArray<NSString *> * _Nonnull)values __attribute__((objc_designated_initializer));
		[Export("initWithValues:")]
		[DesignatedInitializer]
		IntPtr Constructor(string[] values);

		// +(ChartIndexAxisValueFormatter * _Nullable)withValues:(NSArray<NSString *> * _Nonnull)values;
		[Static]
		[Export("withValues:")]
		[return: NullAllowed]
		ChartIndexAxisValueFormatter WithValues(string[] values);

		// -(NSString * _Nonnull)stringForValue:(double)value axis:(ChartAxisBase * _Nullable)axis;
		[Export("stringForValue:axis:")]
		string Axis(double value, [NullAllowed] ChartAxisBase axis);
	}

	// @interface ChartLegend : ChartComponentBase
	[BaseType(typeof(ChartComponentBase))]
	interface ChartLegend
	{
		// @property (copy, nonatomic) NSArray<ChartLegendEntry *> * _Nonnull entries;
		[Export("entries", ArgumentSemantic.Copy)]
		ChartLegendEntry[] Entries { get; set; }

		// @property (copy, nonatomic) NSArray<ChartLegendEntry *> * _Nonnull extraEntries;
		[Export("extraEntries", ArgumentSemantic.Copy)]
		ChartLegendEntry[] ExtraEntries { get; set; }

		// @property (nonatomic) enum ChartLegendPosition position;
		[Export("position", ArgumentSemantic.Assign)]
		ChartLegendPosition Position { get; set; }

		// @property (nonatomic) enum ChartLegendHorizontalAlignment horizontalAlignment;
		[Export("horizontalAlignment", ArgumentSemantic.Assign)]
		ChartLegendHorizontalAlignment HorizontalAlignment { get; set; }

		// @property (nonatomic) enum ChartLegendVerticalAlignment verticalAlignment;
		[Export("verticalAlignment", ArgumentSemantic.Assign)]
		ChartLegendVerticalAlignment VerticalAlignment { get; set; }

		// @property (nonatomic) enum ChartLegendOrientation orientation;
		[Export("orientation", ArgumentSemantic.Assign)]
		ChartLegendOrientation Orientation { get; set; }

		// @property (nonatomic) BOOL drawInside;
		[Export("drawInside")]
		bool DrawInside { get; set; }

		// @property (readonly, nonatomic) BOOL isDrawInsideEnabled;
		[Export("isDrawInsideEnabled")]
		bool IsDrawInsideEnabled { get; }

		// @property (nonatomic) enum ChartLegendDirection direction;
		[Export("direction", ArgumentSemantic.Assign)]
		ChartLegendDirection Direction { get; set; }

		// @property (nonatomic, strong) UIFont * _Nonnull font;
		[Export("font", ArgumentSemantic.Strong)]
		UIFont Font { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull textColor;
		[Export("textColor", ArgumentSemantic.Strong)]
		UIColor TextColor { get; set; }

		// @property (nonatomic) enum ChartLegendForm form;
		[Export("form", ArgumentSemantic.Assign)]
		ChartLegendForm Form { get; set; }

		// @property (nonatomic) CGFloat formSize;
		[Export("formSize")]
		nfloat FormSize { get; set; }

		// @property (nonatomic) CGFloat formLineWidth;
		[Export("formLineWidth")]
		nfloat FormLineWidth { get; set; }

		// @property (nonatomic) CGFloat formLineDashPhase;
		[Export("formLineDashPhase")]
		nfloat FormLineDashPhase { get; set; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nullable formLineDashLengths;
		[NullAllowed, Export("formLineDashLengths", ArgumentSemantic.Copy)]
		NSNumber[] FormLineDashLengths { get; set; }

		// @property (nonatomic) CGFloat xEntrySpace;
		[Export("xEntrySpace")]
		nfloat XEntrySpace { get; set; }

		// @property (nonatomic) CGFloat yEntrySpace;
		[Export("yEntrySpace")]
		nfloat YEntrySpace { get; set; }

		// @property (nonatomic) CGFloat formToTextSpace;
		[Export("formToTextSpace")]
		nfloat FormToTextSpace { get; set; }

		// @property (nonatomic) CGFloat stackSpace;
		[Export("stackSpace")]
		nfloat StackSpace { get; set; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nonnull calculatedLabelBreakPoints;
		[Export("calculatedLabelBreakPoints", ArgumentSemantic.Copy)]
		NSNumber[] CalculatedLabelBreakPoints { get; set; }

		// @property (copy, nonatomic) NSArray<NSValue *> * _Nonnull calculatedLineSizes;
		[Export("calculatedLineSizes", ArgumentSemantic.Copy)]
		NSValue[] CalculatedLineSizes { get; set; }

		// -(instancetype _Nonnull)initWithEntries:(NSArray<ChartLegendEntry *> * _Nonnull)entries __attribute__((objc_designated_initializer));
		[Export("initWithEntries:")]
		[DesignatedInitializer]
		IntPtr Constructor(ChartLegendEntry[] entries);

		// -(CGSize)getMaximumEntrySizeWithFont:(UIFont * _Nonnull)font;
		[Export("getMaximumEntrySizeWithFont:")]
		CGSize GetMaximumEntrySizeWithFont(UIFont font);

		// @property (nonatomic) CGFloat neededWidth;
		[Export("neededWidth")]
		nfloat NeededWidth { get; set; }

		// @property (nonatomic) CGFloat neededHeight;
		[Export("neededHeight")]
		nfloat NeededHeight { get; set; }

		// @property (nonatomic) CGFloat textWidthMax;
		[Export("textWidthMax")]
		nfloat TextWidthMax { get; set; }

		// @property (nonatomic) CGFloat textHeightMax;
		[Export("textHeightMax")]
		nfloat TextHeightMax { get; set; }

		// @property (nonatomic) BOOL wordWrapEnabled;
		[Export("wordWrapEnabled")]
		bool WordWrapEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isWordWrapEnabled;
		[Export("isWordWrapEnabled")]
		bool IsWordWrapEnabled { get; }

		// @property (nonatomic) CGFloat maxSizePercent;
		[Export("maxSizePercent")]
		nfloat MaxSizePercent { get; set; }

		// -(void)calculateDimensionsWithLabelFont:(UIFont * _Nonnull)labelFont viewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler;
		[Export("calculateDimensionsWithLabelFont:viewPortHandler:")]
		void CalculateDimensionsWithLabelFont(UIFont labelFont, ChartViewPortHandler viewPortHandler);

		// -(void)setCustomWithEntries:(NSArray<ChartLegendEntry *> * _Nonnull)entries;
		[Export("setCustomWithEntries:")]
		void SetCustomWithEntries(ChartLegendEntry[] entries);

		// -(void)resetCustom;
		[Export("resetCustom")]
		void ResetCustom();

		// @property (readonly, nonatomic) BOOL isLegendCustom;
		[Export("isLegendCustom")]
		bool IsLegendCustom { get; }

		// -(instancetype _Nonnull)initWithColors:(NSArray<NSObject *> * _Nonnull)colors labels:(NSArray<NSObject *> * _Nonnull)labels __attribute__((objc_designated_initializer));
		[Export("initWithColors:labels:")]
		[DesignatedInitializer]
		IntPtr Constructor(NSObject[] colors, NSObject[] labels);

		// @property (readonly, copy, nonatomic) NSArray<NSObject *> * _Nonnull extraColorsObjc;
		[Export("extraColorsObjc", ArgumentSemantic.Copy)]
		NSObject[] ExtraColorsObjc { get; }

		// @property (readonly, copy, nonatomic) NSArray<NSObject *> * _Nonnull extraLabelsObjc;
		[Export("extraLabelsObjc", ArgumentSemantic.Copy)]
		NSObject[] ExtraLabelsObjc { get; }

		// @property (copy, nonatomic) NSArray<NSObject *> * _Nonnull colorsObjc;
		[Export("colorsObjc", ArgumentSemantic.Copy)]
		NSObject[] ColorsObjc { get; set; }

		// @property (copy, nonatomic) NSArray<NSObject *> * _Nonnull labelsObjc;
		[Export("labelsObjc", ArgumentSemantic.Copy)]
		NSObject[] LabelsObjc { get; set; }

		// -(NSString * _Nullable)getLabel:(NSInteger)index;
		[Export("getLabel:")]
		[return: NullAllowed]
		string GetLabel(nint index);

		// -(void)setExtraWithColors:(NSArray<NSObject *> * _Nonnull)colors labels:(NSArray<NSObject *> * _Nonnull)labels;
		[Export("setExtraWithColors:labels:")]
		void SetExtraWithColors(NSObject[] colors, NSObject[] labels);

		// -(void)setCustomWithColors:(NSArray<NSObject *> * _Nonnull)colors labels:(NSArray<NSObject *> * _Nonnull)labels;
		[Export("setCustomWithColors:labels:")]
		void SetCustomWithColors(NSObject[] colors, NSObject[] labels);
	}

	// @interface ChartLegendEntry : NSObject
	[BaseType(typeof(NSObject))]
	interface ChartLegendEntry
	{
		// -(instancetype _Nonnull)initWithLabel:(NSString * _Nullable)label form:(enum ChartLegendForm)form formSize:(CGFloat)formSize formLineWidth:(CGFloat)formLineWidth formLineDashPhase:(CGFloat)formLineDashPhase formLineDashLengths:(NSArray<NSNumber *> * _Nullable)formLineDashLengths formColor:(UIColor * _Nullable)formColor __attribute__((objc_designated_initializer));
		[Export("initWithLabel:form:formSize:formLineWidth:formLineDashPhase:formLineDashLengths:formColor:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] string label, ChartLegendForm form, nfloat formSize, nfloat formLineWidth, nfloat formLineDashPhase, [NullAllowed] NSNumber[] formLineDashLengths, [NullAllowed] UIColor formColor);

		// @property (copy, nonatomic) NSString * _Nullable label;
		[NullAllowed, Export("label")]
		string Label { get; set; }

		// @property (nonatomic) enum ChartLegendForm form;
		[Export("form", ArgumentSemantic.Assign)]
		ChartLegendForm Form { get; set; }

		// @property (nonatomic) CGFloat formSize;
		[Export("formSize")]
		nfloat FormSize { get; set; }

		// @property (nonatomic) CGFloat formLineWidth;
		[Export("formLineWidth")]
		nfloat FormLineWidth { get; set; }

		// @property (nonatomic) CGFloat formLineDashPhase;
		[Export("formLineDashPhase")]
		nfloat FormLineDashPhase { get; set; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nullable formLineDashLengths;
		[NullAllowed, Export("formLineDashLengths", ArgumentSemantic.Copy)]
		NSNumber[] FormLineDashLengths { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable formColor;
		[NullAllowed, Export("formColor", ArgumentSemantic.Strong)]
		UIColor FormColor { get; set; }
	}

	// @interface ChartLegendRenderer : ChartRenderer
	[BaseType(typeof(ChartRenderer))]
	[DisableDefaultCtor]
	interface ChartLegendRenderer
	{
		// @property (nonatomic, strong) ChartLegend * _Nullable legend;
		[NullAllowed, Export("legend", ArgumentSemantic.Strong)]
		ChartLegend Legend { get; set; }

		// -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nullable)viewPortHandler legend:(ChartLegend * _Nullable)legend __attribute__((objc_designated_initializer));
		[Export("initWithViewPortHandler:legend:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] ChartViewPortHandler viewPortHandler, [NullAllowed] ChartLegend legend);

		// -(void)computeLegendWithData:(ChartData * _Nonnull)data;
		[Export("computeLegendWithData:")]
		void ComputeLegendWithData(ChartData data);

		//u-n-safe void RenderLegendWithContext(CGContextRef* context);

		//u-n-safe void DrawFormWithContext(CGContextRef* context, nfloat x, nfloat y, ChartLegendEntry entry, ChartLegend legend);

		//u-n-safe void DrawLabelWithContext(CGContextRef* context, nfloat x, nfloat y, string label, UIFont font, UIColor textColor);
	}

	// @interface LineChartData : ChartData
	[BaseType(typeof(ChartData), Name = "_TtC6Charts13LineChartData")]
	interface LineChartData
	{
		// -(instancetype _Nonnull)initWithDataSets:(NSArray<id<IInterfaceChartDataSet>> * _Nullable)dataSets __attribute__((objc_designated_initializer));
		[Export("initWithDataSets:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] IInterfaceChartDataSet[] dataSets);
	}

	// @interface LineRadarChartDataSet : LineScatterCandleRadarChartDataSet <IInterfaceLineRadarChartDataSet>
	[BaseType(typeof(LineScatterCandleRadarChartDataSet), Name = "_TtC6Charts21LineRadarChartDataSet")]
	interface LineRadarChartDataSet : InterfaceLineRadarChartDataSet
	{
		// @property (nonatomic, strong) UIColor * _Nonnull fillColor;
		[Export("fillColor", ArgumentSemantic.Strong)]
		UIColor FillColor { get; set; }

		// @property (nonatomic, strong) ChartFill * _Nullable fill;
		[NullAllowed, Export("fill", ArgumentSemantic.Strong)]
		ChartFill Fill { get; set; }

		// @property (nonatomic) CGFloat fillAlpha;
		[Export("fillAlpha")]
		nfloat FillAlpha { get; set; }

		// @property (nonatomic) CGFloat lineWidth;
		[Export("lineWidth")]
		nfloat LineWidth { get; set; }

		// @property (nonatomic) BOOL drawFilledEnabled;
		[Export("drawFilledEnabled")]
		bool DrawFilledEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isDrawFilledEnabled;
		[Export("isDrawFilledEnabled")]
		bool IsDrawFilledEnabled { get; }

		//u-n-safe NSObject CopyWithZone([NullAllowed] _NSZone* zone);

		// -(instancetype _Nonnull)initWithLabel:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
		[Export("initWithLabel:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] string label);

		// -(instancetype _Nonnull)initWithValues:(NSArray<ChartDataEntry *> * _Nullable)values label:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
		[Export("initWithValues:label:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] ChartDataEntry[] values, [NullAllowed] string label);
	}

	// @interface LineChartDataSet : LineRadarChartDataSet <IInterfaceLineChartDataSet>
	[BaseType(typeof(LineRadarChartDataSet), Name = "_TtC6Charts16LineChartDataSet")]
	interface LineChartDataSet : InterfaceLineChartDataSet
	{
		// -(instancetype _Nonnull)initWithValues:(NSArray<ChartDataEntry *> * _Nullable)values label:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
		[Export("initWithValues:label:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] ChartDataEntry[] values, [NullAllowed] string label);

		// @property (nonatomic) enum LineChartMode mode;
		[Export("mode", ArgumentSemantic.Assign)]
		LineChartMode Mode { get; set; }

		// @property (nonatomic) CGFloat cubicIntensity;
		[Export("cubicIntensity")]
		nfloat CubicIntensity { get; set; }

		// @property (nonatomic) BOOL drawCubicEnabled;
		[Export("drawCubicEnabled")]
		bool DrawCubicEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isDrawCubicEnabled;
		[Export("isDrawCubicEnabled")]
		bool IsDrawCubicEnabled { get; }

		// @property (nonatomic) BOOL drawSteppedEnabled;
		[Export("drawSteppedEnabled")]
		bool DrawSteppedEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isDrawSteppedEnabled;
		[Export("isDrawSteppedEnabled")]
		bool IsDrawSteppedEnabled { get; }

		// @property (nonatomic) CGFloat circleRadius;
		[Export("circleRadius")]
		nfloat CircleRadius { get; set; }

		// @property (nonatomic) CGFloat circleHoleRadius;
		[Export("circleHoleRadius")]
		nfloat CircleHoleRadius { get; set; }

		// @property (copy, nonatomic) NSArray<UIColor *> * _Nonnull circleColors;
		[Export("circleColors", ArgumentSemantic.Copy)]
		UIColor[] CircleColors { get; set; }

		// -(UIColor * _Nullable)getCircleColorAtIndex:(NSInteger)index;
		[Export("getCircleColorAtIndex:")]
		[return: NullAllowed]
		UIColor GetCircleColorAtIndex(nint index);

		// -(void)setCircleColor:(UIColor * _Nonnull)color;
		[Export("setCircleColor:")]
		void SetCircleColor(UIColor color);

		// -(void)resetCircleColors:(NSInteger)index;
		[Export("resetCircleColors:")]
		void ResetCircleColors(nint index);

		// @property (nonatomic) BOOL drawCirclesEnabled;
		[Export("drawCirclesEnabled")]
		bool DrawCirclesEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isDrawCirclesEnabled;
		[Export("isDrawCirclesEnabled")]
		bool IsDrawCirclesEnabled { get; }

		// @property (nonatomic, strong) UIColor * _Nullable circleHoleColor;
		[NullAllowed, Export("circleHoleColor", ArgumentSemantic.Strong)]
		UIColor CircleHoleColor { get; set; }

		// @property (nonatomic) BOOL drawCircleHoleEnabled;
		[Export("drawCircleHoleEnabled")]
		bool DrawCircleHoleEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isDrawCircleHoleEnabled;
		[Export("isDrawCircleHoleEnabled")]
		bool IsDrawCircleHoleEnabled { get; }

		// @property (nonatomic) CGFloat lineDashPhase;
		[Export("lineDashPhase")]
		nfloat LineDashPhase { get; set; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nullable lineDashLengths;
		[NullAllowed, Export("lineDashLengths", ArgumentSemantic.Copy)]
		NSNumber[] LineDashLengths { get; set; }

		// @property (nonatomic) CGLineCap lineCapType;
		[Export("lineCapType", ArgumentSemantic.Assign)]
		CGLineCap LineCapType { get; set; }

		// @property (nonatomic, strong) id<InterfaceChartFillFormatter> _Nullable fillFormatter;
		[NullAllowed, Export("fillFormatter", ArgumentSemantic.Strong)]
		IInterfaceChartFillFormatter FillFormatter { get; set; }

		//u-n-safe NSObject CopyWithZone([NullAllowed] _NSZone* zone);
	}

	// @interface LineRadarChartRenderer : LineScatterCandleRadarChartRenderer
	[BaseType(typeof(LineScatterCandleRadarChartRenderer))]
	interface LineRadarChartRenderer
	{
		// -(instancetype _Nonnull)initWithAnimator:(ChartAnimator * _Nullable)animator viewPortHandler:(ChartViewPortHandler * _Nullable)viewPortHandler __attribute__((objc_designated_initializer));
		[Export("initWithAnimator:viewPortHandler:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] ChartAnimator animator, [NullAllowed] ChartViewPortHandler viewPortHandler);

		//u-n-safe void DrawFilledPathWithContext(CGContextRef* context, CGPathRef* path, ChartFill fill, nfloat fillAlpha);

		//u-n-safe void DrawFilledPathWithContext(CGContextRef* context, CGPathRef* path, UIColor fillColor, nfloat fillAlpha);
	}

	// @interface LineChartRenderer : LineRadarChartRenderer
	[BaseType(typeof(LineRadarChartRenderer), Name = "_TtC6Charts17LineChartRenderer")]
	interface LineChartRenderer
	{
		// @property (nonatomic, weak) id<LineChartDataProvider> _Nullable dataProvider;
		[NullAllowed, Export("dataProvider", ArgumentSemantic.Weak)]
		ILineChartDataProvider DataProvider { get; set; }

		// -(instancetype _Nonnull)initWithDataProvider:(id<LineChartDataProvider> _Nullable)dataProvider animator:(ChartAnimator * _Nullable)animator viewPortHandler:(ChartViewPortHandler * _Nullable)viewPortHandler __attribute__((objc_designated_initializer));
		[Export("initWithDataProvider:animator:viewPortHandler:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] ILineChartDataProvider dataProvider, [NullAllowed] ChartAnimator animator, [NullAllowed] ChartViewPortHandler viewPortHandler);

		//u-n-safe void DrawDataWithContext(CGContextRef* context);

		//u-n-safe void DrawDataSetWithContext(CGContextRef* context, IInterfaceLineChartDataSet dataSet);

		//u-n-safe void DrawCubicBezierWithContext(CGContextRef* context, IInterfaceLineChartDataSet dataSet);

		//u-n-safe void DrawHorizontalBezierWithContext(CGContextRef* context, IInterfaceLineChartDataSet dataSet);

		//u-n-safe void DrawLinearWithContext(CGContextRef* context, IInterfaceLineChartDataSet dataSet);

		//u-n-safe void DrawValuesWithContext(CGContextRef* context);

		//u-n-safe void DrawExtrasWithContext(CGContextRef* context);

		//u-n-safe void DrawHighlightedWithContext(CGContextRef* context, ChartHighlight[] indices);
	}

	// @interface LineChartView : BarLineChartViewBase <LineChartDataProvider>
	[BaseType(typeof(BarLineChartViewBase), Name = "_TtC6Charts13LineChartView")]
	interface LineChartView : ILineChartDataProvider
	{
		// @property (readonly, nonatomic, strong) LineChartData * _Nullable lineData;
		[NullAllowed, Export("lineData", ArgumentSemantic.Strong)]
		LineChartData LineData { get; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor(CGRect frame);

		//// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		//[Export("initWithCoder:")]
		//[DesignatedInitializer]
		//IntPtr Constructor(NSCoder aDecoder);
	}

	// @interface ChartMarkerImage : NSObject <InterfaceChartMarker>
	[BaseType(typeof(NSObject))]
	interface ChartMarkerImage : InterfaceChartMarker
	{
		// @property (nonatomic, strong) UIImage * _Nullable image;
		[NullAllowed, Export("image", ArgumentSemantic.Strong)]
		UIImage Image { get; set; }

		// @property (nonatomic) CGPoint offset;
		[Export("offset", ArgumentSemantic.Assign)]
		CGPoint Offset { get; set; }

		// @property (nonatomic, weak) ChartViewBase * _Nullable chartView;
		[NullAllowed, Export("chartView", ArgumentSemantic.Weak)]
		ChartViewBase ChartView { get; set; }

		// @property (nonatomic) CGSize size;
		[Export("size", ArgumentSemantic.Assign)]
		CGSize Size { get; set; }

		// -(CGPoint)offsetForDrawingAtPoint:(CGPoint)point;
		[Export("offsetForDrawingAtPoint:")]
		CGPoint OffsetForDrawingAtPoint(CGPoint point);

		// -(void)refreshContentWithEntry:(ChartDataEntry * _Nonnull)entry highlight:(ChartHighlight * _Nonnull)highlight;
		[Export("refreshContentWithEntry:highlight:")]
		void RefreshContentWithEntry(ChartDataEntry entry, ChartHighlight highlight);

		//u-n-safe void DrawWithContext(CGContextRef* context, CGPoint point);
	}

	// @interface ChartMarkerView : NSUIView <InterfaceChartMarker>
	[BaseType(typeof(NSUIView))]
	interface ChartMarkerView : InterfaceChartMarker
	{
		// @property (nonatomic) CGPoint offset;
		[Export("offset", ArgumentSemantic.Assign)]
		CGPoint Offset { get; set; }

		// @property (nonatomic, weak) ChartViewBase * _Nullable chartView;
		[NullAllowed, Export("chartView", ArgumentSemantic.Weak)]
		ChartViewBase ChartView { get; set; }

		// -(CGPoint)offsetForDrawingAtPoint:(CGPoint)point;
		[Export("offsetForDrawingAtPoint:")]
		CGPoint OffsetForDrawingAtPoint(CGPoint point);

		// -(void)refreshContentWithEntry:(ChartDataEntry * _Nonnull)entry highlight:(ChartHighlight * _Nonnull)highlight;
		[Export("refreshContentWithEntry:highlight:")]
		void RefreshContentWithEntry(ChartDataEntry entry, ChartHighlight highlight);

		//u-n-safe void DrawWithContext(CGContextRef* context, CGPoint point);

		// +(ChartMarkerView * _Nullable)viewFromXib;
		[Static]
		[NullAllowed, Export("viewFromXib")]
		ChartMarkerView ViewFromXib { get; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor(CGRect frame);

		//// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		//[Export("initWithCoder:")]
		//[DesignatedInitializer]
		//IntPtr Constructor(NSCoder aDecoder);
	}

	// @interface MoveChartViewJob : ChartViewPortJob
	[BaseType(typeof(ChartViewPortJob))]
	interface MoveChartViewJob
	{
		// -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler xValue:(double)xValue yValue:(double)yValue transformer:(ChartTransformer * _Nonnull)transformer view:(ChartViewBase * _Nonnull)view __attribute__((objc_designated_initializer));
		[Export("initWithViewPortHandler:xValue:yValue:transformer:view:")]
		[DesignatedInitializer]
		IntPtr Constructor(ChartViewPortHandler viewPortHandler, double xValue, double yValue, ChartTransformer transformer, ChartViewBase view);

		// -(void)doJob;
		[Export("doJob")]
		void DoJob();
	}

	// @interface PieChartData : ChartData
	[BaseType(typeof(ChartData), Name = "_TtC6Charts12PieChartData")]
	interface PieChartData
	{
		// -(instancetype _Nonnull)initWithDataSets:(NSArray<id<IInterfaceChartDataSet>> * _Nullable)dataSets __attribute__((objc_designated_initializer));
		[Export("initWithDataSets:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] IInterfaceChartDataSet[] dataSets);

		// -(id<IInterfaceChartDataSet> _Nullable)getDataSetByIndex:(NSInteger)index;
		[Export("getDataSetByIndex:")]
		[return: NullAllowed]
		IInterfaceChartDataSet GetDataSetByIndex(nint index);

		// -(id<IInterfaceChartDataSet> _Nullable)getDataSetByLabel:(NSString * _Nonnull)label ignorecase:(BOOL)ignorecase;
		[Export("getDataSetByLabel:ignorecase:")]
		[return: NullAllowed]
		IInterfaceChartDataSet GetDataSetByLabel(string label, bool ignorecase);

		// -(ChartDataEntry * _Nullable)entryForHighlight:(ChartHighlight * _Nonnull)highlight;
		[Export("entryForHighlight:")]
		[return: NullAllowed]
		ChartDataEntry EntryForHighlight(ChartHighlight highlight);

		// -(void)addDataSet:(id<IInterfaceChartDataSet> _Null_unspecified)d;
		[Export("addDataSet:")]
		void AddDataSet(IInterfaceChartDataSet d);

		// -(BOOL)removeDataSetByIndex:(NSInteger)index;
		[Export("removeDataSetByIndex:")]
		bool RemoveDataSetByIndex(nint index);

		// @property (readonly, nonatomic) double yValueSum;
		[Export("yValueSum")]
		double YValueSum { get; }
	}

	// @interface PieChartDataEntry : ChartDataEntry
	[BaseType(typeof(ChartDataEntry), Name = "_TtC6Charts17PieChartDataEntry")]
	interface PieChartDataEntry
	{
		// -(instancetype _Nonnull)initWithValue:(double)value label:(NSString * _Nullable)label data:(id _Nullable)data __attribute__((objc_designated_initializer));
		[Export("initWithValue:label:data:")]
		[DesignatedInitializer]
		IntPtr Constructor(double value, [NullAllowed] string label, [NullAllowed] NSObject data);

		// -(instancetype _Nonnull)initWithValue:(double)value label:(NSString * _Nullable)label;
		[Export("initWithValue:label:")]
		IntPtr Constructor(double value, [NullAllowed] string label);

		// -(instancetype _Nonnull)initWithValue:(double)value data:(id _Nullable)data;
		[Export("initWithValue:data:")]
		IntPtr Constructor(double value, [NullAllowed] NSObject data);

		// -(instancetype _Nonnull)initWithValue:(double)value;
		[Export("initWithValue:")]
		IntPtr Constructor(double value);

		// @property (copy, nonatomic) NSString * _Nullable label;
		[NullAllowed, Export("label")]
		string Label { get; set; }

		// @property (nonatomic) double value;
		[Export("value")]
		double Value { get; set; }

		// @property (nonatomic) double x;
		[Export("x")]
		double X { get; set; }

		//u-n-safe NSObject CopyWithZone([NullAllowed] _NSZone* zone);
	}

	// @interface PieChartDataSet : ChartDataSet <IInterfacePieChartDataSet>
	[BaseType(typeof(ChartDataSet), Name = "_TtC6Charts15PieChartDataSet")]
	interface PieChartDataSet : InterfacePieChartDataSet
	{
		// -(instancetype _Nonnull)initWithValues:(NSArray<ChartDataEntry *> * _Nullable)values label:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
		[Export("initWithValues:label:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] ChartDataEntry[] values, [NullAllowed] string label);

		// @property (nonatomic) CGFloat sliceSpace;
		[Export("sliceSpace")]
		nfloat SliceSpace { get; set; }

		// @required @property (nonatomic) BOOL automaticallyDisableSliceSpacing;
		[Export("automaticallyDisableSliceSpacing")]
		bool AutomaticallyDisableSliceSpacing { get; set; }

		// @property (nonatomic) CGFloat selectionShift;
		[Export("selectionShift")]
		nfloat SelectionShift { get; set; }

		// @property (nonatomic) enum PieChartValuePosition xValuePosition;
		[Export("xValuePosition", ArgumentSemantic.Assign)]
		PieChartValuePosition XValuePosition { get; set; }

		// @property (nonatomic) enum PieChartValuePosition yValuePosition;
		[Export("yValuePosition", ArgumentSemantic.Assign)]
		PieChartValuePosition YValuePosition { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable valueLineColor;
		[NullAllowed, Export("valueLineColor", ArgumentSemantic.Strong)]
		UIColor ValueLineColor { get; set; }

		// @property (nonatomic) CGFloat valueLineWidth;
		[Export("valueLineWidth")]
		nfloat ValueLineWidth { get; set; }

		// @property (nonatomic) CGFloat valueLinePart1OffsetPercentage;
		[Export("valueLinePart1OffsetPercentage")]
		nfloat ValueLinePart1OffsetPercentage { get; set; }

		// @property (nonatomic) CGFloat valueLinePart1Length;
		[Export("valueLinePart1Length")]
		nfloat ValueLinePart1Length { get; set; }

		// @property (nonatomic) CGFloat valueLinePart2Length;
		[Export("valueLinePart2Length")]
		nfloat ValueLinePart2Length { get; set; }

		// @property (nonatomic) BOOL valueLineVariableLength;
		[Export("valueLineVariableLength")]
		bool ValueLineVariableLength { get; set; }

		// @property (nonatomic, strong) UIFont * _Nullable entryLabelFont;
		[NullAllowed, Export("entryLabelFont", ArgumentSemantic.Strong)]
		UIFont EntryLabelFont { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable entryLabelColor;
		[NullAllowed, Export("entryLabelColor", ArgumentSemantic.Strong)]
		UIColor EntryLabelColor { get; set; }

		//u-n-safe NSObject CopyWithZone([NullAllowed] _NSZone* zone);
	}

	// @interface PieChartRenderer : ChartDataRendererBase
	[BaseType(typeof(ChartDataRendererBase), Name = "_TtC6Charts16PieChartRenderer")]
	interface PieChartRenderer
	{
		// @property (nonatomic, weak) PieChartView * _Nullable chart;
		[NullAllowed, Export("chart", ArgumentSemantic.Weak)]
		PieChartView Chart { get; set; }

		// -(instancetype _Nonnull)initWithChart:(PieChartView * _Nullable)chart animator:(ChartAnimator * _Nullable)animator viewPortHandler:(ChartViewPortHandler * _Nullable)viewPortHandler __attribute__((objc_designated_initializer));
		[Export("initWithChart:animator:viewPortHandler:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] PieChartView chart, [NullAllowed] ChartAnimator animator, [NullAllowed] ChartViewPortHandler viewPortHandler);

		//u-n-safe void DrawDataWithContext(CGContextRef* context);

		// -(CGFloat)calculateMinimumRadiusForSpacedSliceWithCenter:(CGPoint)center radius:(CGFloat)radius angle:(CGFloat)angle arcStartPointX:(CGFloat)arcStartPointX arcStartPointY:(CGFloat)arcStartPointY startAngle:(CGFloat)startAngle sweepAngle:(CGFloat)sweepAngle;
		[Export("calculateMinimumRadiusForSpacedSliceWithCenter:radius:angle:arcStartPointX:arcStartPointY:startAngle:sweepAngle:")]
		nfloat CalculateMinimumRadiusForSpacedSliceWithCenter(CGPoint center, nfloat radius, nfloat angle, nfloat arcStartPointX, nfloat arcStartPointY, nfloat startAngle, nfloat sweepAngle);

		// -(CGFloat)getSliceSpaceWithDataSet:(id<IInterfacePieChartDataSet> _Nonnull)dataSet;
		[Export("getSliceSpaceWithDataSet:")]
		nfloat GetSliceSpaceWithDataSet(IInterfacePieChartDataSet dataSet);

		//u-n-safe void DrawDataSetWithContext(CGContextRef* context, IInterfacePieChartDataSet dataSet);

		//u-n-safe void DrawValuesWithContext(CGContextRef* context);

		//u-n-safe void DrawExtrasWithContext(CGContextRef* context);

		//u-n-safe void DrawHighlightedWithContext(CGContextRef* context, ChartHighlight[] indices);
	}

	// @interface PieRadarChartViewBase : ChartViewBase
	[BaseType(typeof(ChartViewBase), Name = "_TtC6Charts21PieRadarChartViewBase")]
	interface PieRadarChartViewBase
	{
		// @property (nonatomic) BOOL rotationEnabled;
		[Export("rotationEnabled")]
		bool RotationEnabled { get; set; }

		// @property (nonatomic) CGFloat minOffset;
		[Export("minOffset")]
		nfloat MinOffset { get; set; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor(CGRect frame);

		//// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		//[Export("initWithCoder:")]
		//[DesignatedInitializer]
		//IntPtr Constructor(NSCoder aDecoder);

		// @property (readonly, nonatomic) NSInteger maxVisibleCount;
		[Export("maxVisibleCount")]
		nint MaxVisibleCount { get; }

		// -(void)notifyDataSetChanged;
		[Export("notifyDataSetChanged")]
		void NotifyDataSetChanged();

		// -(CGFloat)angleForPointWithX:(CGFloat)x y:(CGFloat)y;
		[Export("angleForPointWithX:y:")]
		nfloat AngleForPointWithX(nfloat x, nfloat y);

		// -(CGPoint)getPositionWithCenter:(CGPoint)center dist:(CGFloat)dist angle:(CGFloat)angle;
		[Export("getPositionWithCenter:dist:angle:")]
		CGPoint GetPositionWithCenter(CGPoint center, nfloat dist, nfloat angle);

		// -(CGFloat)distanceToCenterWithX:(CGFloat)x y:(CGFloat)y;
		[Export("distanceToCenterWithX:y:")]
		nfloat DistanceToCenterWithX(nfloat x, nfloat y);

		// -(NSInteger)indexForAngle:(CGFloat)angle;
		[Export("indexForAngle:")]
		nint IndexForAngle(nfloat angle);

		// @property (nonatomic) CGFloat rotationAngle;
		[Export("rotationAngle")]
		nfloat RotationAngle { get; set; }

		// @property (readonly, nonatomic) CGFloat rawRotationAngle;
		[Export("rawRotationAngle")]
		nfloat RawRotationAngle { get; }

		// @property (readonly, nonatomic) CGFloat diameter;
		[Export("diameter")]
		nfloat Diameter { get; }

		// @property (readonly, nonatomic) CGFloat radius;
		[Export("radius")]
		nfloat Radius { get; }

		// @property (readonly, nonatomic) double chartYMax;
		[Export("chartYMax")]
		double ChartYMax { get; }

		// @property (readonly, nonatomic) double chartYMin;
		[Export("chartYMin")]
		double ChartYMin { get; }

		// @property (readonly, nonatomic) BOOL isRotationEnabled;
		[Export("isRotationEnabled")]
		bool IsRotationEnabled { get; }

		// @property (nonatomic) BOOL rotationWithTwoFingers;
		[Export("rotationWithTwoFingers")]
		bool RotationWithTwoFingers { get; set; }

		// @property (readonly, nonatomic) BOOL isRotationWithTwoFingers;
		[Export("isRotationWithTwoFingers")]
		bool IsRotationWithTwoFingers { get; }

		// -(void)spinWithDuration:(NSTimeInterval)duration fromAngle:(CGFloat)fromAngle toAngle:(CGFloat)toAngle easing:(double (^ _Nullable)(NSTimeInterval, NSTimeInterval))easing;
		[Export("spinWithDuration:fromAngle:toAngle:easing:")]
		void SpinWithDuration(double duration, nfloat fromAngle, nfloat toAngle, [NullAllowed] Func<double, double, double> easing);

		// -(void)spinWithDuration:(NSTimeInterval)duration fromAngle:(CGFloat)fromAngle toAngle:(CGFloat)toAngle easingOption:(enum ChartEasingOption)easingOption;
		[Export("spinWithDuration:fromAngle:toAngle:easingOption:")]
		void SpinWithDuration(double duration, nfloat fromAngle, nfloat toAngle, ChartEasingOption easingOption);

		// -(void)spinWithDuration:(NSTimeInterval)duration fromAngle:(CGFloat)fromAngle toAngle:(CGFloat)toAngle;
		[Export("spinWithDuration:fromAngle:toAngle:")]
		void SpinWithDuration(double duration, nfloat fromAngle, nfloat toAngle);

		// -(void)stopSpinAnimation;
		[Export("stopSpinAnimation")]
		void StopSpinAnimation();

		// -(void)nsuiTouchesBegan:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event;
		[Export("nsuiTouchesBegan:withEvent:")]
		void NsuiTouchesBegan(NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

		// -(void)nsuiTouchesMoved:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event;
		[Export("nsuiTouchesMoved:withEvent:")]
		void NsuiTouchesMoved(NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

		// -(void)nsuiTouchesEnded:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event;
		[Export("nsuiTouchesEnded:withEvent:")]
		void NsuiTouchesEnded(NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

		// -(void)nsuiTouchesCancelled:(NSSet<UITouch *> * _Nullable)touches withEvent:(UIEvent * _Nullable)event;
		[Export("nsuiTouchesCancelled:withEvent:")]
		void NsuiTouchesCancelled([NullAllowed] NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

		// -(void)stopDeceleration;
		[Export("stopDeceleration")]
		void StopDeceleration();
	}

	// @interface PieChartView : PieRadarChartViewBase
	[BaseType(typeof(PieRadarChartViewBase), Name = "_TtC6Charts12PieChartView")]
	interface PieChartView
	{
		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor(CGRect frame);

		//// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		//[Export("initWithCoder:")]
		//[DesignatedInitializer]
		//IntPtr Constructor(NSCoder aDecoder);

		// -(void)drawRect:(CGRect)rect;
		[Export("drawRect:")]
		void DrawRect(CGRect rect);

		// -(CGPoint)getMarkerPositionWithHighlight:(ChartHighlight * _Nonnull)highlight;
		[Export("getMarkerPositionWithHighlight:")]
		CGPoint GetMarkerPositionWithHighlight(ChartHighlight highlight);

		// -(BOOL)needsHighlightWithIndex:(NSInteger)index;
		[Export("needsHighlightWithIndex:")]
		bool NeedsHighlightWithIndex(nint index);

		// @property (readonly, nonatomic, strong) ChartXAxis * _Nonnull xAxis;
		[Export("xAxis", ArgumentSemantic.Strong)]
		ChartXAxis XAxis { get; }

		// -(NSInteger)indexForAngle:(CGFloat)angle;
		[Export("indexForAngle:")]
		nint IndexForAngle(nfloat angle);

		// -(NSInteger)dataSetIndexForIndex:(double)xValue;
		[Export("dataSetIndexForIndex:")]
		nint DataSetIndexForIndex(double xValue);

		// @property (readonly, copy, nonatomic) NSArray<NSNumber *> * _Nonnull drawAngles;
		[Export("drawAngles", ArgumentSemantic.Copy)]
		NSNumber[] DrawAngles { get; }

		// @property (readonly, copy, nonatomic) NSArray<NSNumber *> * _Nonnull absoluteAngles;
		[Export("absoluteAngles", ArgumentSemantic.Copy)]
		NSNumber[] AbsoluteAngles { get; }

		// @property (nonatomic, strong) UIColor * _Nullable holeColor;
		[NullAllowed, Export("holeColor", ArgumentSemantic.Strong)]
		UIColor HoleColor { get; set; }

		// @property (nonatomic) BOOL drawSlicesUnderHoleEnabled;
		[Export("drawSlicesUnderHoleEnabled")]
		bool DrawSlicesUnderHoleEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isDrawSlicesUnderHoleEnabled;
		[Export("isDrawSlicesUnderHoleEnabled")]
		bool IsDrawSlicesUnderHoleEnabled { get; }

		// @property (nonatomic) BOOL drawHoleEnabled;
		[Export("drawHoleEnabled")]
		bool DrawHoleEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isDrawHoleEnabled;
		[Export("isDrawHoleEnabled")]
		bool IsDrawHoleEnabled { get; }

		// @property (copy, nonatomic) NSString * _Nullable centerText;
		[NullAllowed, Export("centerText")]
		string CenterText { get; set; }

		// @property (nonatomic, strong) NSAttributedString * _Nullable centerAttributedText;
		[NullAllowed, Export("centerAttributedText", ArgumentSemantic.Strong)]
		NSAttributedString CenterAttributedText { get; set; }

		// @property (nonatomic) CGPoint centerTextOffset;
		[Export("centerTextOffset", ArgumentSemantic.Assign)]
		CGPoint CenterTextOffset { get; set; }

		// @property (nonatomic) BOOL drawCenterTextEnabled;
		[Export("drawCenterTextEnabled")]
		bool DrawCenterTextEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isDrawCenterTextEnabled;
		[Export("isDrawCenterTextEnabled")]
		bool IsDrawCenterTextEnabled { get; }

		// @property (readonly, nonatomic) CGFloat radius;
		[Export("radius")]
		nfloat Radius { get; }

		// @property (readonly, nonatomic) CGRect circleBox;
		[Export("circleBox")]
		CGRect CircleBox { get; }

		// @property (readonly, nonatomic) CGPoint centerCircleBox;
		[Export("centerCircleBox")]
		CGPoint CenterCircleBox { get; }

		// @property (nonatomic) CGFloat holeRadiusPercent;
		[Export("holeRadiusPercent")]
		nfloat HoleRadiusPercent { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable transparentCircleColor;
		[NullAllowed, Export("transparentCircleColor", ArgumentSemantic.Strong)]
		UIColor TransparentCircleColor { get; set; }

		// @property (nonatomic) CGFloat transparentCircleRadiusPercent;
		[Export("transparentCircleRadiusPercent")]
		nfloat TransparentCircleRadiusPercent { get; set; }

		// @property (nonatomic) BOOL drawSliceTextEnabled;
		[Export("drawSliceTextEnabled")]
		bool DrawSliceTextEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isDrawSliceTextEnabled;
		[Export("isDrawSliceTextEnabled")]
		bool IsDrawSliceTextEnabled { get; }

		// @property (nonatomic, strong) UIColor * _Nullable entryLabelColor;
		[NullAllowed, Export("entryLabelColor", ArgumentSemantic.Strong)]
		UIColor EntryLabelColor { get; set; }

		// @property (nonatomic, strong) UIFont * _Nullable entryLabelFont;
		[NullAllowed, Export("entryLabelFont", ArgumentSemantic.Strong)]
		UIFont EntryLabelFont { get; set; }

		// @property (nonatomic) BOOL drawEntryLabelsEnabled;
		[Export("drawEntryLabelsEnabled")]
		bool DrawEntryLabelsEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isDrawEntryLabelsEnabled;
		[Export("isDrawEntryLabelsEnabled")]
		bool IsDrawEntryLabelsEnabled { get; }

		// @property (nonatomic) BOOL usePercentValuesEnabled;
		[Export("usePercentValuesEnabled")]
		bool UsePercentValuesEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isUsePercentValuesEnabled;
		[Export("isUsePercentValuesEnabled")]
		bool IsUsePercentValuesEnabled { get; }

		// @property (nonatomic) CGFloat centerTextRadiusPercent;
		[Export("centerTextRadiusPercent")]
		nfloat CenterTextRadiusPercent { get; set; }

		// @property (nonatomic) CGFloat maxAngle;
		[Export("maxAngle")]
		nfloat MaxAngle { get; set; }
	}

	// @interface PieRadarChartHighlighter : ChartHighlighter
	[BaseType(typeof(ChartHighlighter))]
	interface PieRadarChartHighlighter
	{
		// -(ChartHighlight * _Nullable)getHighlightWithX:(CGFloat)x y:(CGFloat)y;
		[Export("getHighlightWithX:y:")]
		[return: NullAllowed]
		ChartHighlight GetHighlightWithX(nfloat x, nfloat y);

		// -(ChartHighlight * _Nullable)closestHighlightWithIndex:(NSInteger)index x:(CGFloat)x y:(CGFloat)y;
		[Export("closestHighlightWithIndex:x:y:")]
		[return: NullAllowed]
		ChartHighlight ClosestHighlightWithIndex(nint index, nfloat x, nfloat y);

		// -(instancetype _Nonnull)initWithChart:(id<ChartDataProvider> _Nonnull)chart __attribute__((objc_designated_initializer));
		[Export("initWithChart:")]
		[DesignatedInitializer]
		IntPtr Constructor(IChartDataProvider chart);
	}

	// @interface PieChartHighlighter : PieRadarChartHighlighter
	[BaseType(typeof(PieRadarChartHighlighter))]
	interface PieChartHighlighter
	{
		// -(ChartHighlight * _Nullable)closestHighlightWithIndex:(NSInteger)index x:(CGFloat)x y:(CGFloat)y;
		[Export("closestHighlightWithIndex:x:y:")]
		[return: NullAllowed]
		ChartHighlight ClosestHighlightWithIndex(nint index, nfloat x, nfloat y);

		// -(instancetype _Nonnull)initWithChart:(id<ChartDataProvider> _Nonnull)chart __attribute__((objc_designated_initializer));
		[Export("initWithChart:")]
		[DesignatedInitializer]
		IntPtr Constructor(IChartDataProvider chart);
	}

	// @interface RadarChartData : ChartData
	[BaseType(typeof(ChartData), Name = "_TtC6Charts14RadarChartData")]
	interface RadarChartData
	{
		// @property (nonatomic, strong) UIColor * _Nonnull highlightColor;
		[Export("highlightColor", ArgumentSemantic.Strong)]
		UIColor HighlightColor { get; set; }

		// @property (nonatomic) CGFloat highlightLineWidth;
		[Export("highlightLineWidth")]
		nfloat HighlightLineWidth { get; set; }

		// @property (nonatomic) CGFloat highlightLineDashPhase;
		[Export("highlightLineDashPhase")]
		nfloat HighlightLineDashPhase { get; set; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nullable highlightLineDashLengths;
		[NullAllowed, Export("highlightLineDashLengths", ArgumentSemantic.Copy)]
		NSNumber[] HighlightLineDashLengths { get; set; }

		// @property (copy, nonatomic) NSArray<NSString *> * _Nonnull labels;
		[Export("labels", ArgumentSemantic.Copy)]
		string[] Labels { get; set; }

		// -(instancetype _Nonnull)initWithDataSets:(NSArray<id<IInterfaceChartDataSet>> * _Nullable)dataSets __attribute__((objc_designated_initializer));
		[Export("initWithDataSets:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] IInterfaceChartDataSet[] dataSets);

		// -(ChartDataEntry * _Nullable)entryForHighlight:(ChartHighlight * _Nonnull)highlight;
		[Export("entryForHighlight:")]
		[return: NullAllowed]
		ChartDataEntry EntryForHighlight(ChartHighlight highlight);
	}

	// @interface RadarChartDataEntry : ChartDataEntry
	[BaseType(typeof(ChartDataEntry), Name = "_TtC6Charts19RadarChartDataEntry")]
	interface RadarChartDataEntry
	{
		// -(instancetype _Nonnull)initWithValue:(double)value data:(id _Nullable)data __attribute__((objc_designated_initializer));
		[Export("initWithValue:data:")]
		[DesignatedInitializer]
		IntPtr Constructor(double value, [NullAllowed] NSObject data);

		// -(instancetype _Nonnull)initWithValue:(double)value;
		[Export("initWithValue:")]
		IntPtr Constructor(double value);

		// @property (nonatomic) double value;
		[Export("value")]
		double Value { get; set; }

		//u-n-safe NSObject CopyWithZone([NullAllowed] _NSZone* zone);
	}

	// @interface RadarChartDataSet : LineRadarChartDataSet <IInterfaceRadarChartDataSet>
	[BaseType(typeof(LineRadarChartDataSet), Name = "_TtC6Charts17RadarChartDataSet")]
	interface RadarChartDataSet : InterfaceRadarChartDataSet
	{
		// -(instancetype _Nonnull)initWithValues:(NSArray<ChartDataEntry *> * _Nullable)values label:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
		[Export("initWithValues:label:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] ChartDataEntry[] values, [NullAllowed] string label);

		// @property (nonatomic) BOOL drawHighlightCircleEnabled;
		[Export("drawHighlightCircleEnabled")]
		bool DrawHighlightCircleEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isDrawHighlightCircleEnabled;
		[Export("isDrawHighlightCircleEnabled")]
		bool IsDrawHighlightCircleEnabled { get; }

		// @property (nonatomic, strong) UIColor * _Nullable highlightCircleFillColor;
		[NullAllowed, Export("highlightCircleFillColor", ArgumentSemantic.Strong)]
		UIColor HighlightCircleFillColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable highlightCircleStrokeColor;
		[NullAllowed, Export("highlightCircleStrokeColor", ArgumentSemantic.Strong)]
		UIColor HighlightCircleStrokeColor { get; set; }

		// @property (nonatomic) CGFloat highlightCircleStrokeAlpha;
		[Export("highlightCircleStrokeAlpha")]
		nfloat HighlightCircleStrokeAlpha { get; set; }

		// @property (nonatomic) CGFloat highlightCircleInnerRadius;
		[Export("highlightCircleInnerRadius")]
		nfloat HighlightCircleInnerRadius { get; set; }

		// @property (nonatomic) CGFloat highlightCircleOuterRadius;
		[Export("highlightCircleOuterRadius")]
		nfloat HighlightCircleOuterRadius { get; set; }

		// @property (nonatomic) CGFloat highlightCircleStrokeWidth;
		[Export("highlightCircleStrokeWidth")]
		nfloat HighlightCircleStrokeWidth { get; set; }
	}

	// @interface RadarChartRenderer : LineRadarChartRenderer
	[BaseType(typeof(LineRadarChartRenderer), Name = "_TtC6Charts18RadarChartRenderer")]
	interface RadarChartRenderer
	{
		// @property (nonatomic, weak) RadarChartView * _Nullable chart;
		[NullAllowed, Export("chart", ArgumentSemantic.Weak)]
		RadarChartView Chart { get; set; }

		// -(instancetype _Nonnull)initWithChart:(RadarChartView * _Nullable)chart animator:(ChartAnimator * _Nullable)animator viewPortHandler:(ChartViewPortHandler * _Nullable)viewPortHandler __attribute__((objc_designated_initializer));
		[Export("initWithChart:animator:viewPortHandler:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] RadarChartView chart, [NullAllowed] ChartAnimator animator, [NullAllowed] ChartViewPortHandler viewPortHandler);

		//u-n-safe void DrawDataWithContext(CGContextRef* context);

		//u-n-safe void DrawValuesWithContext(CGContextRef* context);

		//u-n-safe void DrawExtrasWithContext(CGContextRef* context);

		//u-n-safe void DrawWebWithContext(CGContextRef* context);

		//u-n-safe void DrawHighlightedWithContext(CGContextRef* context, ChartHighlight[] indices);
	}

	// @interface RadarChartView : PieRadarChartViewBase
	[BaseType(typeof(PieRadarChartViewBase), Name = "_TtC6Charts14RadarChartView")]
	interface RadarChartView
	{
		// @property (nonatomic) CGFloat webLineWidth;
		[Export("webLineWidth")]
		nfloat WebLineWidth { get; set; }

		// @property (nonatomic) CGFloat innerWebLineWidth;
		[Export("innerWebLineWidth")]
		nfloat InnerWebLineWidth { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull webColor;
		[Export("webColor", ArgumentSemantic.Strong)]
		UIColor WebColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull innerWebColor;
		[Export("innerWebColor", ArgumentSemantic.Strong)]
		UIColor InnerWebColor { get; set; }

		// @property (nonatomic) CGFloat webAlpha;
		[Export("webAlpha")]
		nfloat WebAlpha { get; set; }

		// @property (nonatomic) BOOL drawWeb;
		[Export("drawWeb")]
		bool DrawWeb { get; set; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor(CGRect frame);

		//// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		//[Export("initWithCoder:")]
		//[DesignatedInitializer]
		//IntPtr Constructor(NSCoder aDecoder);

		// -(void)notifyDataSetChanged;
		[Export("notifyDataSetChanged")]
		void NotifyDataSetChanged();

		// -(void)drawRect:(CGRect)rect;
		[Export("drawRect:")]
		void DrawRect(CGRect rect);

		// @property (readonly, nonatomic) CGFloat factor;
		[Export("factor")]
		nfloat Factor { get; }

		// @property (readonly, nonatomic) CGFloat sliceAngle;
		[Export("sliceAngle")]
		nfloat SliceAngle { get; }

		// -(NSInteger)indexForAngle:(CGFloat)angle;
		[Export("indexForAngle:")]
		nint IndexForAngle(nfloat angle);

		// @property (readonly, nonatomic, strong) ChartYAxis * _Nonnull yAxis;
		[Export("yAxis", ArgumentSemantic.Strong)]
		ChartYAxis YAxis { get; }

		// @property (nonatomic) NSInteger skipWebLineCount;
		[Export("skipWebLineCount")]
		nint SkipWebLineCount { get; set; }

		// @property (readonly, nonatomic) CGFloat radius;
		[Export("radius")]
		nfloat Radius { get; }

		// @property (readonly, nonatomic) double chartYMax;
		[Export("chartYMax")]
		double ChartYMax { get; }

		// @property (readonly, nonatomic) double chartYMin;
		[Export("chartYMin")]
		double ChartYMin { get; }

		// @property (readonly, nonatomic) double yRange;
		[Export("yRange")]
		double YRange { get; }
	}

	// @interface RadarChartHighlighter : PieRadarChartHighlighter
	[BaseType(typeof(PieRadarChartHighlighter))]
	interface RadarChartHighlighter
	{
		// -(ChartHighlight * _Nullable)closestHighlightWithIndex:(NSInteger)index x:(CGFloat)x y:(CGFloat)y;
		[Export("closestHighlightWithIndex:x:y:")]
		[return: NullAllowed]
		ChartHighlight ClosestHighlightWithIndex(nint index, nfloat x, nfloat y);

		// -(instancetype _Nonnull)initWithChart:(id<ChartDataProvider> _Nonnull)chart __attribute__((objc_designated_initializer));
		[Export("initWithChart:")]
		[DesignatedInitializer]
		IntPtr Constructor(IChartDataProvider chart);
	}

	// @interface ChartRange : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ChartRange
	{
		// @property (nonatomic) double from;
		[Export("from")]
		double From { get; set; }

		// @property (nonatomic) double to;
		[Export("to")]
		double To { get; set; }

		// -(instancetype _Nonnull)initFrom:(double)from to:(double)to __attribute__((objc_designated_initializer));
		[Export("initFrom:to:")]
		[DesignatedInitializer]
		IntPtr Constructor(double from, double to);

		// -(BOOL)contains:(double)value;
		[Export("contains:")]
		bool Contains(double value);

		// -(BOOL)isLarger:(double)value;
		[Export("isLarger:")]
		bool IsLarger(double value);

		// -(BOOL)isSmaller:(double)value;
		[Export("isSmaller:")]
		bool IsSmaller(double value);
	}

	// @interface ScatterChartData : BarLineScatterCandleBubbleChartData
	[BaseType(typeof(BarLineScatterCandleBubbleChartData), Name = "_TtC6Charts16ScatterChartData")]
	interface ScatterChartData
	{
		// -(instancetype _Nonnull)initWithDataSets:(NSArray<id<IInterfaceChartDataSet>> * _Nullable)dataSets __attribute__((objc_designated_initializer));
		[Export("initWithDataSets:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] IInterfaceChartDataSet[] dataSets);

		// -(CGFloat)getGreatestShapeSize;
		[Export("getGreatestShapeSize")]
		nfloat GreatestShapeSize { get; }
	}

	// @interface ScatterChartDataSet : LineScatterCandleRadarChartDataSet <IInterfaceScatterChartDataSet>
	[BaseType(typeof(LineScatterCandleRadarChartDataSet), Name = "_TtC6Charts19ScatterChartDataSet")]
	interface ScatterChartDataSet : InterfaceScatterChartDataSet
	{
		// @property (nonatomic) CGFloat scatterShapeSize;
		[Export("scatterShapeSize")]
		nfloat ScatterShapeSize { get; set; }

		// @property (nonatomic) CGFloat scatterShapeHoleRadius;
		[Export("scatterShapeHoleRadius")]
		nfloat ScatterShapeHoleRadius { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable scatterShapeHoleColor;
		[NullAllowed, Export("scatterShapeHoleColor", ArgumentSemantic.Strong)]
		UIColor ScatterShapeHoleColor { get; set; }

		// -(void)setScatterShape:(enum ScatterShape)shape;
		[Export("setScatterShape:")]
		void SetScatterShape(ScatterShape shape);

		// @property (nonatomic, strong) id<InterfaceShapeRenderer> _Nullable shapeRenderer;
		[NullAllowed, Export("shapeRenderer", ArgumentSemantic.Strong)]
		IInterfaceShapeRenderer ShapeRenderer { get; set; }

		// +(id<InterfaceShapeRenderer> _Nonnull)rendererForShape:(enum ScatterShape)shape;
		[Static]
		[Export("rendererForShape:")]
		InterfaceShapeRenderer RendererForShape(ScatterShape shape);

		//u-n-safe NSObject CopyWithZone([NullAllowed] _NSZone* zone);

		// -(instancetype _Nonnull)initWithLabel:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
		[Export("initWithLabel:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] string label);

		// -(instancetype _Nonnull)initWithValues:(NSArray<ChartDataEntry *> * _Nullable)values label:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
		[Export("initWithValues:label:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] ChartDataEntry[] values, [NullAllowed] string label);
	}

	// @interface ScatterChartRenderer : LineScatterCandleRadarChartRenderer
	[BaseType(typeof(LineScatterCandleRadarChartRenderer), Name = "_TtC6Charts20ScatterChartRenderer")]
	interface ScatterChartRenderer
	{
		// @property (nonatomic, weak) id<ScatterChartDataProvider> _Nullable dataProvider;
		[NullAllowed, Export("dataProvider", ArgumentSemantic.Weak)]
		IScatterChartDataProvider DataProvider { get; set; }

		// -(instancetype _Nonnull)initWithDataProvider:(id<ScatterChartDataProvider> _Nullable)dataProvider animator:(ChartAnimator * _Nullable)animator viewPortHandler:(ChartViewPortHandler * _Nullable)viewPortHandler __attribute__((objc_designated_initializer));
		[Export("initWithDataProvider:animator:viewPortHandler:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] IScatterChartDataProvider dataProvider, [NullAllowed] ChartAnimator animator, [NullAllowed] ChartViewPortHandler viewPortHandler);

		//u-n-safe void DrawDataWithContext(CGContextRef* context);

		//u-n-safe void DrawDataSetWithContext(CGContextRef* context, IInterfaceScatterChartDataSet dataSet);

		//u-n-safe void DrawValuesWithContext(CGContextRef* context);

		//u-n-safe void DrawExtrasWithContext(CGContextRef* context);

		//u-n-safe void DrawHighlightedWithContext(CGContextRef* context, ChartHighlight[] indices);
	}

	// @interface ScatterChartView : BarLineChartViewBase <ScatterChartDataProvider>
	[BaseType(typeof(BarLineChartViewBase), Name = "_TtC6Charts16ScatterChartView")]
	interface ScatterChartView : IScatterChartDataProvider
	{
		// -(void)initialize __attribute__((objc_method_family("none")));
		[Export("initialize")]
		void Initialize();

		// @property (readonly, nonatomic, strong) ScatterChartData * _Nullable scatterData;
		[NullAllowed, Export("scatterData", ArgumentSemantic.Strong)]
		ScatterChartData ScatterData { get; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor(CGRect frame);

		//// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		//[Export("initWithCoder:")]
		//[DesignatedInitializer]
		//IntPtr Constructor(NSCoder aDecoder);
	}

	// @interface SquareShapeRenderer : NSObject <InterfaceShapeRenderer>
	[BaseType(typeof(NSObject), Name = "_TtC6Charts19SquareShapeRenderer")]
	interface SquareShapeRenderer : InterfaceShapeRenderer
	{
		//u-n-safe void RenderShapeWithContext(CGContextRef* context, IInterfaceScatterChartDataSet dataSet, ChartViewPortHandler viewPortHandler, CGPoint point, UIColor color);
	}

	// @interface ChartTransformer : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ChartTransformer
	{
		// -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler __attribute__((objc_designated_initializer));
		[Export("initWithViewPortHandler:")]
		[DesignatedInitializer]
		IntPtr Constructor(ChartViewPortHandler viewPortHandler);

		// -(void)prepareMatrixValuePxWithChartXMin:(double)chartXMin deltaX:(CGFloat)deltaX deltaY:(CGFloat)deltaY chartYMin:(double)chartYMin;
		[Export("prepareMatrixValuePxWithChartXMin:deltaX:deltaY:chartYMin:")]
		void PrepareMatrixValuePxWithChartXMin(double chartXMin, nfloat deltaX, nfloat deltaY, double chartYMin);

		// -(void)prepareMatrixOffsetWithInverted:(BOOL)inverted;
		[Export("prepareMatrixOffsetWithInverted:")]
		void PrepareMatrixOffsetWithInverted(bool inverted);

		// -(CGPoint)pixelForValuesWithX:(double)x y:(double)y;
		[Export("pixelForValuesWithX:y:")]
		CGPoint PixelForValuesWithX(double x, double y);

		// -(CGPoint)valueForTouchPoint:(CGPoint)point;
		[Export("valueForTouchPoint:")]
		CGPoint ValueForTouchPoint(CGPoint point);

		// -(CGPoint)valueForTouchPointWithX:(CGFloat)x y:(CGFloat)y;
		[Export("valueForTouchPointWithX:y:")]
		CGPoint ValueForTouchPointWithX(nfloat x, nfloat y);

		// @property (readonly, nonatomic) CGAffineTransform valueToPixelMatrix;
		[Export("valueToPixelMatrix")]
		CGAffineTransform ValueToPixelMatrix { get; }

		// @property (readonly, nonatomic) CGAffineTransform pixelToValueMatrix;
		[Export("pixelToValueMatrix")]
		CGAffineTransform PixelToValueMatrix { get; }
	}

	// @interface ChartTransformerHorizontalBarChart : ChartTransformer
	[BaseType(typeof(ChartTransformer))]
	interface ChartTransformerHorizontalBarChart
	{
		// -(void)prepareMatrixOffsetWithInverted:(BOOL)inverted;
		[Export("prepareMatrixOffsetWithInverted:")]
		void PrepareMatrixOffsetWithInverted(bool inverted);

		// -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler __attribute__((objc_designated_initializer));
		[Export("initWithViewPortHandler:")]
		[DesignatedInitializer]
		IntPtr Constructor(ChartViewPortHandler viewPortHandler);
	}

	// @interface TriangleShapeRenderer : NSObject <InterfaceShapeRenderer>
	[BaseType(typeof(NSObject), Name = "_TtC6Charts21TriangleShapeRenderer")]
	interface TriangleShapeRenderer : InterfaceShapeRenderer
	{
		//u-n-safe void RenderShapeWithContext(CGContextRef* context, IInterfaceScatterChartDataSet dataSet, ChartViewPortHandler viewPortHandler, CGPoint point, UIColor color);
	}

	// @interface Charts_Swift_6204 (UIPanGestureRecognizer)
	[Category]
	[BaseType(typeof(UIPanGestureRecognizer))]
	interface UIPanGestureRecognizer_Charts_Swift_6204
	{
	}

	// @interface Charts_Swift_6208 (UIPinchGestureRecognizer)
	[Category]
	[BaseType(typeof(UIPinchGestureRecognizer))]
	interface UIPinchGestureRecognizer_Charts_Swift_6208
	{
	}

	// @interface Charts_Swift_6212 (UIRotationGestureRecognizer)
	[Category]
	[BaseType(typeof(UIRotationGestureRecognizer))]
	interface UIRotationGestureRecognizer_Charts_Swift_6212
	{
	}

	// @interface Charts_Swift_6216 (UIScreen)
	[Category]
	[BaseType(typeof(UIScreen))]
	interface UIScreen_Charts_Swift_6216
	{
	}

	// @interface Charts_Swift_6220 (UIScrollView)
	[Category]
	[BaseType(typeof(UIScrollView))]
	interface UIScrollView_Charts_Swift_6220
	{
	}

	// @interface Charts_Swift_6224 (UITapGestureRecognizer)
	[Category]
	[BaseType(typeof(UITapGestureRecognizer))]
	interface UITapGestureRecognizer_Charts_Swift_6224
	{
	}

	// @interface Charts_Swift_6228 (UIView)
	[Category]
	[BaseType(typeof(UIView))]
	interface UIView_Charts_Swift_6228
	{
	}

	// @interface ChartViewPortHandler : NSObject
	[BaseType(typeof(NSObject))]
	interface ChartViewPortHandler
	{
		// -(instancetype _Nonnull)initWithWidth:(CGFloat)width height:(CGFloat)height __attribute__((objc_designated_initializer));
		[Export("initWithWidth:height:")]
		[DesignatedInitializer]
		IntPtr Constructor(nfloat width, nfloat height);

		// -(void)setChartDimensWithWidth:(CGFloat)width height:(CGFloat)height;
		[Export("setChartDimensWithWidth:height:")]
		void SetChartDimensWithWidth(nfloat width, nfloat height);

		// @property (readonly, nonatomic) BOOL hasChartDimens;
		[Export("hasChartDimens")]
		bool HasChartDimens { get; }

		// -(void)restrainViewPortWithOffsetLeft:(CGFloat)offsetLeft offsetTop:(CGFloat)offsetTop offsetRight:(CGFloat)offsetRight offsetBottom:(CGFloat)offsetBottom;
		[Export("restrainViewPortWithOffsetLeft:offsetTop:offsetRight:offsetBottom:")]
		void RestrainViewPortWithOffsetLeft(nfloat offsetLeft, nfloat offsetTop, nfloat offsetRight, nfloat offsetBottom);

		// @property (readonly, nonatomic) CGFloat offsetLeft;
		[Export("offsetLeft")]
		nfloat OffsetLeft { get; }

		// @property (readonly, nonatomic) CGFloat offsetRight;
		[Export("offsetRight")]
		nfloat OffsetRight { get; }

		// @property (readonly, nonatomic) CGFloat offsetTop;
		[Export("offsetTop")]
		nfloat OffsetTop { get; }

		// @property (readonly, nonatomic) CGFloat offsetBottom;
		[Export("offsetBottom")]
		nfloat OffsetBottom { get; }

		// @property (readonly, nonatomic) CGFloat contentTop;
		[Export("contentTop")]
		nfloat ContentTop { get; }

		// @property (readonly, nonatomic) CGFloat contentLeft;
		[Export("contentLeft")]
		nfloat ContentLeft { get; }

		// @property (readonly, nonatomic) CGFloat contentRight;
		[Export("contentRight")]
		nfloat ContentRight { get; }

		// @property (readonly, nonatomic) CGFloat contentBottom;
		[Export("contentBottom")]
		nfloat ContentBottom { get; }

		// @property (readonly, nonatomic) CGFloat contentWidth;
		[Export("contentWidth")]
		nfloat ContentWidth { get; }

		// @property (readonly, nonatomic) CGFloat contentHeight;
		[Export("contentHeight")]
		nfloat ContentHeight { get; }

		// @property (readonly, nonatomic) CGRect contentRect;
		[Export("contentRect")]
		CGRect ContentRect { get; }

		// @property (readonly, nonatomic) CGPoint contentCenter;
		[Export("contentCenter")]
		CGPoint ContentCenter { get; }

		// @property (readonly, nonatomic) CGFloat chartHeight;
		[Export("chartHeight")]
		nfloat ChartHeight { get; }

		// @property (readonly, nonatomic) CGFloat chartWidth;
		[Export("chartWidth")]
		nfloat ChartWidth { get; }

		// -(CGAffineTransform)zoomWithScaleX:(CGFloat)scaleX scaleY:(CGFloat)scaleY;
		[Export("zoomWithScaleX:scaleY:")]
		CGAffineTransform ZoomWithScaleX(nfloat scaleX, nfloat scaleY);

		// -(CGAffineTransform)zoomWithScaleX:(CGFloat)scaleX scaleY:(CGFloat)scaleY x:(CGFloat)x y:(CGFloat)y;
		[Export("zoomWithScaleX:scaleY:x:y:")]
		CGAffineTransform ZoomWithScaleX(nfloat scaleX, nfloat scaleY, nfloat x, nfloat y);

		// -(CGAffineTransform)zoomInX:(CGFloat)x y:(CGFloat)y;
		[Export("zoomInX:y:")]
		CGAffineTransform ZoomInX(nfloat x, nfloat y);

		// -(CGAffineTransform)zoomOutWithX:(CGFloat)x y:(CGFloat)y;
		[Export("zoomOutWithX:y:")]
		CGAffineTransform ZoomOutWithX(nfloat x, nfloat y);

		// -(CGAffineTransform)setZoomWithScaleX:(CGFloat)scaleX scaleY:(CGFloat)scaleY;
		[Export("setZoomWithScaleX:scaleY:")]
		CGAffineTransform SetZoomWithScaleX(nfloat scaleX, nfloat scaleY);

		// -(CGAffineTransform)setZoomWithScaleX:(CGFloat)scaleX scaleY:(CGFloat)scaleY x:(CGFloat)x y:(CGFloat)y;
		[Export("setZoomWithScaleX:scaleY:x:y:")]
		CGAffineTransform SetZoomWithScaleX(nfloat scaleX, nfloat scaleY, nfloat x, nfloat y);

		// -(CGAffineTransform)fitScreen;
		[Export("fitScreen")]
		CGAffineTransform FitScreen { get; }

		// -(CGAffineTransform)translateWithPt:(CGPoint)pt;
		[Export("translateWithPt:")]
		CGAffineTransform TranslateWithPt(CGPoint pt);

		// -(void)centerViewPortWithPt:(CGPoint)pt chart:(ChartViewBase * _Nonnull)chart;
		[Export("centerViewPortWithPt:chart:")]
		void CenterViewPortWithPt(CGPoint pt, ChartViewBase chart);

		// -(CGAffineTransform)refreshWithNewMatrix:(CGAffineTransform)newMatrix chart:(ChartViewBase * _Nonnull)chart invalidate:(BOOL)invalidate;
		[Export("refreshWithNewMatrix:chart:invalidate:")]
		CGAffineTransform RefreshWithNewMatrix(CGAffineTransform newMatrix, ChartViewBase chart, bool invalidate);

		// -(void)setMinimumScaleX:(CGFloat)xScale;
		[Export("setMinimumScaleX:")]
		void SetMinimumScaleX(nfloat xScale);

		// -(void)setMaximumScaleX:(CGFloat)xScale;
		[Export("setMaximumScaleX:")]
		void SetMaximumScaleX(nfloat xScale);

		// -(void)setMinMaxScaleXWithMinScaleX:(CGFloat)minScaleX maxScaleX:(CGFloat)maxScaleX;
		[Export("setMinMaxScaleXWithMinScaleX:maxScaleX:")]
		void SetMinMaxScaleXWithMinScaleX(nfloat minScaleX, nfloat maxScaleX);

		// -(void)setMinimumScaleY:(CGFloat)yScale;
		[Export("setMinimumScaleY:")]
		void SetMinimumScaleY(nfloat yScale);

		// -(void)setMaximumScaleY:(CGFloat)yScale;
		[Export("setMaximumScaleY:")]
		void SetMaximumScaleY(nfloat yScale);

		// -(void)setMinMaxScaleYWithMinScaleY:(CGFloat)minScaleY maxScaleY:(CGFloat)maxScaleY;
		[Export("setMinMaxScaleYWithMinScaleY:maxScaleY:")]
		void SetMinMaxScaleYWithMinScaleY(nfloat minScaleY, nfloat maxScaleY);

		// @property (readonly, nonatomic) CGAffineTransform touchMatrix;
		[Export("touchMatrix")]
		CGAffineTransform TouchMatrix { get; }

		// -(BOOL)isInBoundsX:(CGFloat)x;
		[Export("isInBoundsX:")]
		bool IsInBoundsX(nfloat x);

		// -(BOOL)isInBoundsY:(CGFloat)y;
		[Export("isInBoundsY:")]
		bool IsInBoundsY(nfloat y);

		// -(BOOL)isInBoundsWithX:(CGFloat)x y:(CGFloat)y;
		[Export("isInBoundsWithX:y:")]
		bool IsInBoundsWithX(nfloat x, nfloat y);

		// -(BOOL)isInBoundsLeft:(CGFloat)x;
		[Export("isInBoundsLeft:")]
		bool IsInBoundsLeft(nfloat x);

		// -(BOOL)isInBoundsRight:(CGFloat)x;
		[Export("isInBoundsRight:")]
		bool IsInBoundsRight(nfloat x);

		// -(BOOL)isInBoundsTop:(CGFloat)y;
		[Export("isInBoundsTop:")]
		bool IsInBoundsTop(nfloat y);

		// -(BOOL)isInBoundsBottom:(CGFloat)y;
		[Export("isInBoundsBottom:")]
		bool IsInBoundsBottom(nfloat y);

		// @property (readonly, nonatomic) CGFloat scaleX;
		[Export("scaleX")]
		nfloat ScaleX { get; }

		// @property (readonly, nonatomic) CGFloat scaleY;
		[Export("scaleY")]
		nfloat ScaleY { get; }

		// @property (readonly, nonatomic) CGFloat minScaleX;
		[Export("minScaleX")]
		nfloat MinScaleX { get; }

		// @property (readonly, nonatomic) CGFloat minScaleY;
		[Export("minScaleY")]
		nfloat MinScaleY { get; }

		// @property (readonly, nonatomic) CGFloat maxScaleX;
		[Export("maxScaleX")]
		nfloat MaxScaleX { get; }

		// @property (readonly, nonatomic) CGFloat maxScaleY;
		[Export("maxScaleY")]
		nfloat MaxScaleY { get; }

		// @property (readonly, nonatomic) CGFloat transX;
		[Export("transX")]
		nfloat TransX { get; }

		// @property (readonly, nonatomic) CGFloat transY;
		[Export("transY")]
		nfloat TransY { get; }

		// @property (readonly, nonatomic) BOOL isFullyZoomedOut;
		[Export("isFullyZoomedOut")]
		bool IsFullyZoomedOut { get; }

		// @property (readonly, nonatomic) BOOL isFullyZoomedOutY;
		[Export("isFullyZoomedOutY")]
		bool IsFullyZoomedOutY { get; }

		// @property (readonly, nonatomic) BOOL isFullyZoomedOutX;
		[Export("isFullyZoomedOutX")]
		bool IsFullyZoomedOutX { get; }

		// -(void)setDragOffsetX:(CGFloat)offset;
		[Export("setDragOffsetX:")]
		void SetDragOffsetX(nfloat offset);

		// -(void)setDragOffsetY:(CGFloat)offset;
		[Export("setDragOffsetY:")]
		void SetDragOffsetY(nfloat offset);

		// @property (readonly, nonatomic) BOOL hasNoDragOffset;
		[Export("hasNoDragOffset")]
		bool HasNoDragOffset { get; }

		// @property (readonly, nonatomic) BOOL canZoomOutMoreX;
		[Export("canZoomOutMoreX")]
		bool CanZoomOutMoreX { get; }

		// @property (readonly, nonatomic) BOOL canZoomInMoreX;
		[Export("canZoomInMoreX")]
		bool CanZoomInMoreX { get; }

		// @property (readonly, nonatomic) BOOL canZoomOutMoreY;
		[Export("canZoomOutMoreY")]
		bool CanZoomOutMoreY { get; }

		// @property (readonly, nonatomic) BOOL canZoomInMoreY;
		[Export("canZoomInMoreY")]
		bool CanZoomInMoreY { get; }
	}

	// @interface ChartXAxis : ChartAxisBase
	[BaseType(typeof(ChartAxisBase))]
	interface ChartXAxis
	{
		// @property (nonatomic) CGFloat labelWidth;
		[Export("labelWidth")]
		nfloat LabelWidth { get; set; }

		// @property (nonatomic) CGFloat labelHeight;
		[Export("labelHeight")]
		nfloat LabelHeight { get; set; }

		// @property (nonatomic) CGFloat labelRotatedWidth;
		[Export("labelRotatedWidth")]
		nfloat LabelRotatedWidth { get; set; }

		// @property (nonatomic) CGFloat labelRotatedHeight;
		[Export("labelRotatedHeight")]
		nfloat LabelRotatedHeight { get; set; }

		// @property (nonatomic) CGFloat labelRotationAngle;
		[Export("labelRotationAngle")]
		nfloat LabelRotationAngle { get; set; }

		// @property (nonatomic) BOOL avoidFirstLastClippingEnabled;
		[Export("avoidFirstLastClippingEnabled")]
		bool AvoidFirstLastClippingEnabled { get; set; }

		// @property (nonatomic) enum XAxisLabelPosition labelPosition;
		[Export("labelPosition", ArgumentSemantic.Assign)]
		XAxisLabelPosition LabelPosition { get; set; }

		// @property (nonatomic) BOOL wordWrapEnabled;
		[Export("wordWrapEnabled")]
		bool WordWrapEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isWordWrapEnabled;
		[Export("isWordWrapEnabled")]
		bool IsWordWrapEnabled { get; }

		// @property (nonatomic) CGFloat wordWrapWidthPercent;
		[Export("wordWrapWidthPercent")]
		nfloat WordWrapWidthPercent { get; set; }

		// @property (readonly, nonatomic) BOOL isAvoidFirstLastClippingEnabled;
		[Export("isAvoidFirstLastClippingEnabled")]
		bool IsAvoidFirstLastClippingEnabled { get; }
	}

	// @interface ChartXAxisRenderer : ChartAxisRendererBase
	[BaseType(typeof(ChartAxisRendererBase))]
	[DisableDefaultCtor]
	interface ChartXAxisRenderer
	{
		// -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nullable)viewPortHandler xAxis:(ChartXAxis * _Nullable)xAxis transformer:(ChartTransformer * _Nullable)transformer __attribute__((objc_designated_initializer));
		[Export("initWithViewPortHandler:xAxis:transformer:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] ChartViewPortHandler viewPortHandler, [NullAllowed] ChartXAxis xAxis, [NullAllowed] ChartTransformer transformer);

		// -(void)computeAxisWithMin:(double)min max:(double)max inverted:(BOOL)inverted;
		[Export("computeAxisWithMin:max:inverted:")]
		void ComputeAxisWithMin(double min, double max, bool inverted);

		// -(void)computeAxisValuesWithMin:(double)min max:(double)max;
		[Export("computeAxisValuesWithMin:max:")]
		void ComputeAxisValuesWithMin(double min, double max);

		// -(void)computeSize;
		[Export("computeSize")]
		void ComputeSize();

		//u-n-safe void RenderAxisLabelsWithContext(CGContextRef* context);

		//u-n-safe void RenderAxisLineWithContext(CGContextRef* context);

		//u-n-safe void DrawLabelsWithContext(CGContextRef* context, nfloat pos, CGPoint anchor);

		//u-n-safe void DrawLabelWithContext(CGContextRef* context, string formattedLabel, nfloat x, nfloat y, NSDictionary<NSString, NSObject> attributes, CGSize constrainedToSize, CGPoint anchor, nfloat angleRadians);

		//u-n-safe void RenderGridLinesWithContext(CGContextRef* context);

		// @property (readonly, nonatomic) CGRect gridClippingRect;
		[Export("gridClippingRect")]
		CGRect GridClippingRect { get; }

		//u-n-safe void DrawGridLineWithContext(CGContextRef* context, nfloat x, nfloat y);

		//u-n-safe void RenderLimitLinesWithContext(CGContextRef* context);

		//u-n-safe void RenderLimitLineLineWithContext(CGContextRef* context, ChartLimitLine limitLine, CGPoint position);

		//u-n-safe void RenderLimitLineLabelWithContext(CGContextRef* context, ChartLimitLine limitLine, CGPoint position, nfloat yOffset);
	}

	// @interface XAxisRendererHorizontalBarChart : ChartXAxisRenderer
	[BaseType(typeof(ChartXAxisRenderer), Name = "_TtC6Charts31XAxisRendererHorizontalBarChart")]
	interface XAxisRendererHorizontalBarChart
	{
		// -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nullable)viewPortHandler xAxis:(ChartXAxis * _Nullable)xAxis transformer:(ChartTransformer * _Nullable)transformer chart:(BarChartView * _Nullable)chart __attribute__((objc_designated_initializer));
		[Export("initWithViewPortHandler:xAxis:transformer:chart:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] ChartViewPortHandler viewPortHandler, [NullAllowed] ChartXAxis xAxis, [NullAllowed] ChartTransformer transformer, [NullAllowed] BarChartView chart);

		// -(void)computeAxisWithMin:(double)min max:(double)max inverted:(BOOL)inverted;
		[Export("computeAxisWithMin:max:inverted:")]
		void ComputeAxisWithMin(double min, double max, bool inverted);

		// -(void)computeSize;
		[Export("computeSize")]
		void ComputeSize();

		//u-n-safe void RenderAxisLabelsWithContext(CGContextRef* context);

		//u-n-safe void DrawLabelsWithContext(CGContextRef* context, nfloat pos, CGPoint anchor);

		//u-n-safe void DrawLabelWithContext(CGContextRef* context, string formattedLabel, nfloat x, nfloat y, NSDictionary<NSString, NSObject> attributes, CGPoint anchor, nfloat angleRadians);

		// @property (readonly, nonatomic) CGRect gridClippingRect;
		[Export("gridClippingRect")]
		CGRect GridClippingRect { get; }

		//u-n-safe void DrawGridLineWithContext(CGContextRef* context, nfloat x, nfloat y);

		//u-n-safe void RenderAxisLineWithContext(CGContextRef* context);

		//u-n-safe void RenderLimitLinesWithContext(CGContextRef* context);
	}

	// @interface XAxisRendererRadarChart : ChartXAxisRenderer
	[BaseType(typeof(ChartXAxisRenderer), Name = "_TtC6Charts23XAxisRendererRadarChart")]
	interface XAxisRendererRadarChart
	{
		// @property (nonatomic, weak) RadarChartView * _Nullable chart;
		[NullAllowed, Export("chart", ArgumentSemantic.Weak)]
		RadarChartView Chart { get; set; }

		// -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nullable)viewPortHandler xAxis:(ChartXAxis * _Nullable)xAxis chart:(RadarChartView * _Nullable)chart __attribute__((objc_designated_initializer));
		[Export("initWithViewPortHandler:xAxis:chart:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] ChartViewPortHandler viewPortHandler, [NullAllowed] ChartXAxis xAxis, [NullAllowed] RadarChartView chart);

		//u-n-safe void RenderAxisLabelsWithContext(CGContextRef* context);

		//u-n-safe void DrawLabelWithContext(CGContextRef* context, string formattedLabel, nfloat x, nfloat y, NSDictionary<NSString, NSObject> attributes, CGPoint anchor, nfloat angleRadians);

		//u-n-safe void RenderLimitLinesWithContext(CGContextRef* context);
	}

	// @interface XShapeRenderer : NSObject <InterfaceShapeRenderer>
	[BaseType(typeof(NSObject), Name = "_TtC6Charts14XShapeRenderer")]
	interface XShapeRenderer : InterfaceShapeRenderer
	{
		//u-n-safe void RenderShapeWithContext(CGContextRef* context, IInterfaceScatterChartDataSet dataSet, ChartViewPortHandler viewPortHandler, CGPoint point, UIColor color);
	}

	// @interface ChartYAxis : ChartAxisBase
	[BaseType(typeof(ChartAxisBase))]
	interface ChartYAxis
	{
		// @property (nonatomic) BOOL drawTopYLabelEntryEnabled;
		[Export("drawTopYLabelEntryEnabled")]
		bool DrawTopYLabelEntryEnabled { get; set; }

		// @property (nonatomic) BOOL inverted;
		[Export("inverted")]
		bool Inverted { get; set; }

		// @property (nonatomic) BOOL drawZeroLineEnabled;
		[Export("drawZeroLineEnabled")]
		bool DrawZeroLineEnabled { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable zeroLineColor;
		[NullAllowed, Export("zeroLineColor", ArgumentSemantic.Strong)]
		UIColor ZeroLineColor { get; set; }

		// @property (nonatomic) CGFloat zeroLineWidth;
		[Export("zeroLineWidth")]
		nfloat ZeroLineWidth { get; set; }

		// @property (nonatomic) CGFloat zeroLineDashPhase;
		[Export("zeroLineDashPhase")]
		nfloat ZeroLineDashPhase { get; set; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nullable zeroLineDashLengths;
		[NullAllowed, Export("zeroLineDashLengths", ArgumentSemantic.Copy)]
		NSNumber[] ZeroLineDashLengths { get; set; }

		// @property (nonatomic) CGFloat spaceTop;
		[Export("spaceTop")]
		nfloat SpaceTop { get; set; }

		// @property (nonatomic) CGFloat spaceBottom;
		[Export("spaceBottom")]
		nfloat SpaceBottom { get; set; }

		// @property (nonatomic) enum YAxisLabelPosition labelPosition;
		[Export("labelPosition", ArgumentSemantic.Assign)]
		YAxisLabelPosition LabelPosition { get; set; }

		// @property (nonatomic) CGFloat minWidth;
		[Export("minWidth")]
		nfloat MinWidth { get; set; }

		// @property (nonatomic) CGFloat maxWidth;
		[Export("maxWidth")]
		nfloat MaxWidth { get; set; }

		// -(instancetype _Nonnull)initWithPosition:(enum AxisDependency)position __attribute__((objc_designated_initializer));
		[Export("initWithPosition:")]
		[DesignatedInitializer]
		IntPtr Constructor(AxisDependency position);

		// @property (readonly, nonatomic) enum AxisDependency axisDependency;
		[Export("axisDependency")]
		AxisDependency AxisDependency { get; }

		// -(CGSize)requiredSize;
		[Export("requiredSize")]
		CGSize RequiredSize { get; }

		// -(CGFloat)getRequiredHeightSpace;
		[Export("getRequiredHeightSpace")]
		nfloat RequiredHeightSpace { get; }

		// @property (readonly, nonatomic) BOOL needsOffset;
		[Export("needsOffset")]
		bool NeedsOffset { get; }

		// @property (readonly, nonatomic) BOOL isInverted;
		[Export("isInverted")]
		bool IsInverted { get; }

		// -(void)calculateWithMin:(double)dataMin max:(double)dataMax;
		[Export("calculateWithMin:max:")]
		void CalculateWithMin(double dataMin, double dataMax);

		// @property (readonly, nonatomic) BOOL isDrawTopYLabelEntryEnabled;
		[Export("isDrawTopYLabelEntryEnabled")]
		bool IsDrawTopYLabelEntryEnabled { get; }
	}

	// @interface ChartYAxisRenderer : ChartAxisRendererBase
	[BaseType(typeof(ChartAxisRendererBase))]
	[DisableDefaultCtor]
	interface ChartYAxisRenderer
	{
		// -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nullable)viewPortHandler yAxis:(ChartYAxis * _Nullable)yAxis transformer:(ChartTransformer * _Nullable)transformer __attribute__((objc_designated_initializer));
		[Export("initWithViewPortHandler:yAxis:transformer:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] ChartViewPortHandler viewPortHandler, [NullAllowed] ChartYAxis yAxis, [NullAllowed] ChartTransformer transformer);

		//u-n-safe void RenderAxisLabelsWithContext(CGContextRef* context);

		//u-n-safe void RenderAxisLineWithContext(CGContextRef* context);

		//u-n-safe void RenderGridLinesWithContext(CGContextRef* context);

		// @property (readonly, nonatomic) CGRect gridClippingRect;
		[Export("gridClippingRect")]
		CGRect GridClippingRect { get; }

		//u-n-safe void DrawGridLineWithContext(CGContextRef* context, CGPoint position);


		// -(NSArray<NSValue *> * _Nonnull)transformedPositions;
		[Export ("transformedPositions")]
		NSValue[] TransformedPositions { get; }

		//u-n-safe void DrawZeroLineWithContext(CGContextRef* context);

		//u-n-safe void RenderLimitLinesWithContext(CGContextRef* context);
	}

	// @interface YAxisRendererHorizontalBarChart : ChartYAxisRenderer
	[BaseType(typeof(ChartYAxisRenderer), Name = "_TtC6Charts31YAxisRendererHorizontalBarChart")]
	interface YAxisRendererHorizontalBarChart
	{
		// -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nullable)viewPortHandler yAxis:(ChartYAxis * _Nullable)yAxis transformer:(ChartTransformer * _Nullable)transformer __attribute__((objc_designated_initializer));
		[Export("initWithViewPortHandler:yAxis:transformer:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] ChartViewPortHandler viewPortHandler, [NullAllowed] ChartYAxis yAxis, [NullAllowed] ChartTransformer transformer);

		// -(void)computeAxisWithMin:(double)min max:(double)max inverted:(BOOL)inverted;
		[Export("computeAxisWithMin:max:inverted:")]
		void ComputeAxisWithMin(double min, double max, bool inverted);

		// @property (readonly, nonatomic) CGRect gridClippingRect;
		[Export ("gridClippingRect")]
		CGRect GridClippingRect { get; }

		// -(NSArray<NSValue *> * _Nonnull)transformedPositions;
		[Export ("transformedPositions")]
		NSValue[] TransformedPositions { get; }
	}

	// @interface YAxisRendererRadarChart : ChartYAxisRenderer
	[BaseType (typeof(ChartYAxisRenderer), Name = "_TtC6Charts23YAxisRendererRadarChart")]
	interface YAxisRendererRadarChart
	{
		// -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nullable)viewPortHandler yAxis:(ChartYAxis * _Nullable)yAxis chart:(RadarChartView * _Nullable)chart __attribute__((objc_designated_initializer));
		[Export ("initWithViewPortHandler:yAxis:chart:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] ChartViewPortHandler viewPortHandler, [NullAllowed] ChartYAxis yAxis, [NullAllowed] RadarChartView chart);

		// -(void)computeAxisValuesWithMin:(double)yMin max:(double)yMax;
		[Export ("computeAxisValuesWithMin:max:")]
		void ComputeAxisValuesWithMin (double yMin, double yMax);
	}

	// @interface ZoomChartViewJob : ChartViewPortJob
	[BaseType (typeof(ChartViewPortJob))]
	interface ZoomChartViewJob
	{
		// -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler scaleX:(CGFloat)scaleX scaleY:(CGFloat)scaleY xValue:(double)xValue yValue:(double)yValue transformer:(ChartTransformer * _Nonnull)transformer axis:(enum AxisDependency)axis view:(ChartViewBase * _Nonnull)view __attribute__((objc_designated_initializer));
		[Export ("initWithViewPortHandler:scaleX:scaleY:xValue:yValue:transformer:axis:view:")]
		[DesignatedInitializer]
		IntPtr Constructor (ChartViewPortHandler viewPortHandler, nfloat scaleX, nfloat scaleY, double xValue, double yValue, ChartTransformer transformer, AxisDependency axis, ChartViewBase view);

		// -(void)doJob;
		[Export ("doJob")]
		void DoJob ();
	}
}