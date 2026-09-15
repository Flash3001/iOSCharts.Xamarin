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
        NativeHandle Constructor(ChartViewPortHandler viewPortHandler, double xValue, double yValue, ChartTransformer transformer, ChartViewBase view);

        // -(void)doJob;
        [Export("doJob")]
        void DoJob();
    }

    // @interface AnimatedViewPortJob : ChartViewPortJob
    [BaseType(typeof(ChartViewPortJob), Name = "_TtC8DGCharts19AnimatedViewPortJob")]
    interface AnimatedViewPortJob
    {
        // -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler xValue:(double)xValue yValue:(double)yValue transformer:(ChartTransformer * _Nonnull)transformer view:(ChartViewBase * _Nonnull)view xOrigin:(CGFloat)xOrigin yOrigin:(CGFloat)yOrigin duration:(NSTimeInterval)duration easing:(double (^ _Nullable)(NSTimeInterval, NSTimeInterval))easing __attribute__((objc_designated_initializer));
        [Export("initWithViewPortHandler:xValue:yValue:transformer:view:xOrigin:yOrigin:duration:easing:")]
        [DesignatedInitializer]
        NativeHandle Constructor(ChartViewPortHandler viewPortHandler, double xValue, double yValue, ChartTransformer transformer, ChartViewBase view, nfloat xOrigin, nfloat yOrigin, double duration, [NullAllowed] Func<double, double, double> easing);

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
    [BaseType(typeof(AnimatedViewPortJob), Name = "_TtC8DGCharts19AnimatedMoveViewJob")]
    interface AnimatedMoveViewJob
    {
        // -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler xValue:(double)xValue yValue:(double)yValue transformer:(ChartTransformer * _Nonnull)transformer view:(ChartViewBase * _Nonnull)view xOrigin:(CGFloat)xOrigin yOrigin:(CGFloat)yOrigin duration:(NSTimeInterval)duration easing:(double (^ _Nullable)(NSTimeInterval, NSTimeInterval))easing __attribute__((objc_designated_initializer));
        [Export("initWithViewPortHandler:xValue:yValue:transformer:view:xOrigin:yOrigin:duration:easing:")]
        [DesignatedInitializer]
        NativeHandle Constructor(ChartViewPortHandler viewPortHandler, double xValue, double yValue, ChartTransformer transformer, ChartViewBase view, nfloat xOrigin, nfloat yOrigin, double duration, [NullAllowed] Func<double, double, double> easing);
    }

    // @interface AnimatedZoomViewJob : AnimatedViewPortJob
    [BaseType(typeof(AnimatedViewPortJob), Name = "_TtC8DGCharts19AnimatedZoomViewJob")]
    interface AnimatedZoomViewJob
    {
        // -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler transformer:(ChartTransformer * _Nonnull)transformer view:(ChartViewBase * _Nonnull)view yAxis:(ChartYAxis * _Nonnull)yAxis xAxisRange:(double)xAxisRange scaleX:(CGFloat)scaleX scaleY:(CGFloat)scaleY xOrigin:(CGFloat)xOrigin yOrigin:(CGFloat)yOrigin zoomCenterX:(CGFloat)zoomCenterX zoomCenterY:(CGFloat)zoomCenterY zoomOriginX:(CGFloat)zoomOriginX zoomOriginY:(CGFloat)zoomOriginY duration:(NSTimeInterval)duration easing:(double (^ _Nullable)(NSTimeInterval, NSTimeInterval))easing __attribute__((objc_designated_initializer));
        [Export("initWithViewPortHandler:transformer:view:yAxis:xAxisRange:scaleX:scaleY:xOrigin:yOrigin:zoomCenterX:zoomCenterY:zoomOriginX:zoomOriginY:duration:easing:")]
        [DesignatedInitializer]
        NativeHandle Constructor(ChartViewPortHandler viewPortHandler, ChartTransformer transformer, ChartViewBase view, ChartYAxis yAxis, double xAxisRange, nfloat scaleX, nfloat scaleY, nfloat xOrigin, nfloat yOrigin, nfloat zoomCenterX, nfloat zoomCenterY, nfloat zoomOriginX, nfloat zoomOriginY, double duration, [NullAllowed] Func<double, double, double> easing);
    }

    // @interface ChartAnimator : NSObject
    [BaseType(typeof(NSObject))]
    interface ChartAnimator
    {
        [Wrap("WeakDelegate")]
        [NullAllowed]
        IChartAnimatorDelegate Delegate { get; set; }

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

        // -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration easing:(double (^ _Nullable)(NSTimeInterval, NSTimeInterval))easing;
        [Export("animateWithXAxisDuration:easing:")]
        void AnimateWithXAxisDuration(double xAxisDuration, [NullAllowed] Func<double, double, double> easing);

        // -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration easingOption:(enum ChartEasingOption)easingOption;
        [Export("animateWithXAxisDuration:easingOption:")]
        void AnimateWithXAxisDuration(double xAxisDuration, ChartEasingOption easingOption);

        // -(void)animateWithYAxisDuration:(NSTimeInterval)yAxisDuration easing:(double (^ _Nullable)(NSTimeInterval, NSTimeInterval))easing;
        [Export("animateWithYAxisDuration:easing:")]
        void AnimateWithYAxisDuration(double yAxisDuration, [NullAllowed] Func<double, double, double> easing);

        // -(void)animateWithYAxisDuration:(NSTimeInterval)yAxisDuration easingOption:(enum ChartEasingOption)easingOption;
        [Export("animateWithYAxisDuration:easingOption:")]
        void AnimateWithYAxisDuration(double yAxisDuration, ChartEasingOption easingOption);
    }

    interface IChartAnimatorDelegate { }

    // @protocol ChartAnimatorDelegate
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
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

        // @property (nonatomic) BOOL drawGridLinesBehindDataEnabled;
        [Export("drawGridLinesBehindDataEnabled")]
        bool DrawGridLinesBehindDataEnabled { get; set; }

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

        // -(NSString * _Nonnull)getLongestLabel __attribute__((warn_unused_result("")));
        [Export("getLongestLabel")]
        string GetLongestLabel();

        // -(NSString * _Nonnull)getFormattedLabel:(NSInteger)index __attribute__((warn_unused_result("")));
        [Export("getFormattedLabel:")]
        string GetFormattedLabel(nint index);

        // @property (nonatomic, strong) id<ChartAxisValueFormatter> _Nullable valueFormatter;
        [NullAllowed, Export("valueFormatter", ArgumentSemantic.Strong)]
        IChartAxisValueFormatter ValueFormatter { get; set; }

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

        // @property (readonly, nonatomic) BOOL isDrawGridLinesBehindDataEnabled;
        [Export("isDrawGridLinesBehindDataEnabled")]
        bool IsDrawGridLinesBehindDataEnabled { get; }

        // @property (nonatomic) double spaceMin;
        [Export("spaceMin")]
        double SpaceMin { get; set; }

        // @property (nonatomic) double spaceMax;
        [Export("spaceMax")]
        double SpaceMax { get; set; }

        // @property (nonatomic) double axisRange;
        [Export("axisRange")]
        double AxisRange { get; set; }

        // @property (nonatomic) NSInteger axisMinLabels;
        [Export("axisMinLabels")]
        nint AxisMinLabels { get; set; }

        // @property (nonatomic) NSInteger axisMaxLabels;
        [Export("axisMaxLabels")]
        nint AxisMaxLabels { get; set; }

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

    interface IChartAxisValueFormatter { }

    // @protocol ChartAxisValueFormatter
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface ChartAxisValueFormatter
    {
        // @required -(NSString * _Nonnull)stringForValue:(double)value axis:(ChartAxisBase * _Nullable)axis __attribute__((warn_unused_result("")));
        [Abstract]
        [Export("stringForValue:axis:")]
        string StringForValue(double value, [NullAllowed] ChartAxisBase axis);
    }

    // @interface ChartData : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC8DGCharts9ChartData")]
    interface ChartData
    {
        // @property (nonatomic) double xMax;
        [Export("xMax")]
        double XMax { get; set; }

        // @property (nonatomic) double xMin;
        [Export("xMin")]
        double XMin { get; set; }

        // @property (nonatomic) double yMax;
        [Export("yMax")]
        double YMax { get; set; }

        // @property (nonatomic) double yMin;
        [Export("yMin")]
        double YMin { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable accessibilityEntryLabelPrefix;
        [NullAllowed, Export("accessibilityEntryLabelPrefix")]
        string AccessibilityEntryLabelPrefix { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable accessibilityEntryLabelSuffix;
        [NullAllowed, Export("accessibilityEntryLabelSuffix")]
        string AccessibilityEntryLabelSuffix { get; set; }

        // @property (nonatomic) BOOL accessibilityEntryLabelSuffixIsCount;
        [Export("accessibilityEntryLabelSuffixIsCount")]
        bool AccessibilityEntryLabelSuffixIsCount { get; set; }

        // -(instancetype _Nonnull)initWithDataSets:(NSArray<id<ChartDataSetProtocol>> * _Nonnull)dataSets __attribute__((objc_designated_initializer));
        [Export("initWithDataSets:")]
        [DesignatedInitializer]
        NativeHandle Constructor(IChartDataSetProtocol[] dataSets);

        // -(instancetype _Nonnull)initWithDataSet:(id<ChartDataSetProtocol> _Nonnull)dataSet;
        [Export("initWithDataSet:")]
        NativeHandle Constructor(IChartDataSetProtocol dataSet);

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

        // -(void)calcMinMaxWithDataSet:(id<ChartDataSetProtocol> _Nonnull)d;
        [Export("calcMinMaxWithDataSet:")]
        void CalcMinMaxWithDataSet(IChartDataSetProtocol d);

        // @property (readonly, nonatomic) NSInteger dataSetCount;
        [Export("dataSetCount")]
        nint DataSetCount { get; }

        // -(double)getYMinWithAxis:(enum AxisDependency)axis __attribute__((warn_unused_result("")));
        [Export("getYMinWithAxis:")]
        double GetYMinWithAxis(AxisDependency axis);

        // -(double)getYMaxWithAxis:(enum AxisDependency)axis __attribute__((warn_unused_result("")));
        [Export("getYMaxWithAxis:")]
        double GetYMaxWithAxis(AxisDependency axis);

        // @property (copy, nonatomic) NSArray<id<ChartDataSetProtocol>> * _Nonnull dataSets;
        [Export("dataSets", ArgumentSemantic.Copy)]
        IChartDataSetProtocol[] DataSets { get; set; }

        // -(ChartDataEntry * _Nullable)entryFor:(ChartHighlight * _Nonnull)highlight __attribute__((warn_unused_result("")));
        [Export("entryFor:")]
        [return: NullAllowed]
        ChartDataEntry EntryFor(ChartHighlight highlight);

        // -(id<ChartDataSetProtocol> _Nullable)dataSetForLabel:(NSString * _Nonnull)label ignorecase:(BOOL)ignorecase __attribute__((warn_unused_result("")));
        [Export("dataSetForLabel:ignorecase:")]
        [return: NullAllowed]
        IChartDataSetProtocol DataSetForLabel(string label, bool ignorecase);

        // -(id<ChartDataSetProtocol> _Nullable)dataSetAtIndex:(NSInteger)index __attribute__((warn_unused_result("")));
        [Export("dataSetAtIndex:")]
        [return: NullAllowed]
        IChartDataSetProtocol DataSetAtIndex(nint index);

        // -(id<ChartDataSetProtocol> _Nullable)removeDataSet:(id<ChartDataSetProtocol> _Nonnull)dataSet;
        [Export("removeDataSet:")]
        [return: NullAllowed]
        IChartDataSetProtocol RemoveDataSet(IChartDataSetProtocol dataSet);

        // -(void)addEntry:(ChartDataEntry * _Nonnull)e dataSetIndex:(NSInteger)dataSetIndex;
        [Export("addEntry:dataSetIndex:")]
        void AddEntry(ChartDataEntry e, nint dataSetIndex);

        // -(BOOL)removeEntry:(ChartDataEntry * _Nonnull)entry dataSetIndex:(NSInteger)dataSetIndex;
        [Export("removeEntry:dataSetIndex:")]
        bool RemoveEntry(ChartDataEntry entry, nint dataSetIndex);

        // -(BOOL)removeEntryWithXValue:(double)xValue dataSetIndex:(NSInteger)dataSetIndex;
        [Export("removeEntryWithXValue:dataSetIndex:")]
        bool RemoveEntryWithXValue(double xValue, nint dataSetIndex);

        // -(id<ChartDataSetProtocol> _Nullable)getDataSetForEntry:(ChartDataEntry * _Nonnull)e __attribute__((warn_unused_result("")));
        [Export("getDataSetForEntry:")]
        [return: NullAllowed]
        IChartDataSetProtocol GetDataSetForEntry(ChartDataEntry e);

        // -(NSInteger)indexOf:(id<ChartDataSetProtocol> _Nonnull)dataSet __attribute__((warn_unused_result("")));
        [Export("indexOf:")]
        nint IndexOf(IChartDataSetProtocol dataSet);

        // -(id<ChartDataSetProtocol> _Nullable)getFirstLeftWithDataSets:(NSArray<id<ChartDataSetProtocol>> * _Nonnull)dataSets __attribute__((warn_unused_result("")));
        [Export("getFirstLeftWithDataSets:")]
        [return: NullAllowed]
        IChartDataSetProtocol GetFirstLeftWithDataSets(IChartDataSetProtocol[] dataSets);

        // -(id<ChartDataSetProtocol> _Nullable)getFirstRightWithDataSets:(NSArray<id<ChartDataSetProtocol>> * _Nonnull)dataSets __attribute__((warn_unused_result("")));
        [Export("getFirstRightWithDataSets:")]
        [return: NullAllowed]
        IChartDataSetProtocol GetFirstRightWithDataSets(IChartDataSetProtocol[] dataSets);

        // @property (readonly, copy, nonatomic) NSArray<UIColor *> * _Nonnull colors;
        [Export("colors", ArgumentSemantic.Copy)]
        UIColor[] Colors { get; }

        // -(void)setValueFormatter:(id<ChartValueFormatter> _Nonnull)formatter;
        [Export("setValueFormatter:")]
        void SetValueFormatter(IChartValueFormatter formatter);

        // -(void)setValueTextColor:(UIColor * _Nonnull)color;
        [Export("setValueTextColor:")]
        void SetValueTextColor(UIColor color);

        // -(void)setValueFont:(UIFont * _Nonnull)font;
        [Export("setValueFont:")]
        void SetValueFont(UIFont font);

        // -(void)setDrawValues:(BOOL)enabled;
        [Export("setDrawValues:")]
        void SetDrawValues(bool enabled);

        // @property (nonatomic) BOOL isHighlightEnabled;
        [Export("isHighlightEnabled")]
        bool IsHighlightEnabled { get; set; }

        // -(void)clearValues;
        [Export("clearValues")]
        void ClearValues();

        // -(BOOL)containsWithDataSet:(id<ChartDataSetProtocol> _Nonnull)dataSet __attribute__((warn_unused_result("")));
        [Export("containsWithDataSet:")]
        bool ContainsWithDataSet(IChartDataSetProtocol dataSet);

        // @property (readonly, nonatomic) NSInteger entryCount;
        [Export("entryCount")]
        nint EntryCount { get; }

        // @property (readonly, nonatomic, strong) id<ChartDataSetProtocol> _Nullable maxEntryCountSet;
        [NullAllowed, Export("maxEntryCountSet", ArgumentSemantic.Strong)]
        IChartDataSetProtocol MaxEntryCountSet { get; }

        // -(void)addDataSet:(id<ChartDataSetProtocol> _Nonnull)newElement;
        [Export("addDataSet:")]
        void AddDataSet(IChartDataSetProtocol newElement);

        // -(id<ChartDataSetProtocol> _Nonnull)removeDataSetByIndex:(NSInteger)position __attribute__((warn_unused_result("")));
        [Export("removeDataSetByIndex:")]
        IChartDataSetProtocol RemoveDataSetByIndex(nint position);
    }

    // @interface BarLineScatterCandleBubbleChartData : ChartData
    [BaseType(typeof(ChartData), Name = "_TtC8DGCharts35BarLineScatterCandleBubbleChartData")]
    interface BarLineScatterCandleBubbleChartData
    {
        // -(instancetype _Nonnull)initWithDataSets:(NSArray<id<ChartDataSetProtocol>> * _Nonnull)dataSets __attribute__((objc_designated_initializer));
        [Export("initWithDataSets:")]
        [DesignatedInitializer]
        NativeHandle Constructor(IChartDataSetProtocol[] dataSets);
    }

    // @interface BarChartData : BarLineScatterCandleBubbleChartData
    [BaseType(typeof(BarLineScatterCandleBubbleChartData), Name = "_TtC8DGCharts12BarChartData")]
    interface BarChartData
    {
        // -(instancetype _Nonnull)initWithDataSets:(NSArray<id<ChartDataSetProtocol>> * _Nonnull)dataSets __attribute__((objc_designated_initializer));
        [Export("initWithDataSets:")]
        [DesignatedInitializer]
        NativeHandle Constructor(IChartDataSetProtocol[] dataSets);

        // @property (nonatomic) double barWidth;
        [Export("barWidth")]
        double BarWidth { get; set; }

        // -(void)groupBarsFromX:(double)fromX groupSpace:(double)groupSpace barSpace:(double)barSpace;
        [Export("groupBarsFromX:groupSpace:barSpace:")]
        void GroupBarsFromX(double fromX, double groupSpace, double barSpace);

        // -(double)groupWidthWithGroupSpace:(double)groupSpace barSpace:(double)barSpace __attribute__((warn_unused_result("")));
        [Export("groupWidthWithGroupSpace:barSpace:")]
        double GroupWidthWithGroupSpace(double groupSpace, double barSpace);
    }

    // @interface ChartDataEntryBase : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC8DGCharts18ChartDataEntryBase")]
    interface ChartDataEntryBase
    {
        // @property (nonatomic) double y;
        [Export("y")]
        double Y { get; set; }

        // @property (nonatomic) id _Nullable data;
        [NullAllowed, Export("data", ArgumentSemantic.Assign)]
        NSObject Data { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable icon;
        [NullAllowed, Export("icon", ArgumentSemantic.Strong)]
        UIImage Icon { get; set; }

        // -(instancetype _Nonnull)initWithY:(double)y __attribute__((objc_designated_initializer));
        [Export("initWithY:")]
        [DesignatedInitializer]
        NativeHandle Constructor(double y);

        // -(instancetype _Nonnull)initWithY:(double)y data:(id _Nullable)data;
        [Export("initWithY:data:")]
        NativeHandle Constructor(double y, [NullAllowed] NSObject data);

        // -(instancetype _Nonnull)initWithY:(double)y icon:(UIImage * _Nullable)icon;
        [Export("initWithY:icon:")]
        NativeHandle Constructor(double y, [NullAllowed] UIImage icon);

        // -(instancetype _Nonnull)initWithY:(double)y icon:(UIImage * _Nullable)icon data:(id _Nullable)data;
        [Export("initWithY:icon:data:")]
        NativeHandle Constructor(double y, [NullAllowed] UIImage icon, [NullAllowed] NSObject data);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }
    }

    // @interface ChartDataEntry : ChartDataEntryBase <NSCopying>
    [BaseType(typeof(ChartDataEntryBase), Name = "_TtC8DGCharts14ChartDataEntry")]
    interface ChartDataEntry : INSCopying
    {
        // @property (nonatomic) double x;
        [Export("x")]
        double X { get; set; }

        // -(instancetype _Nonnull)initWithX:(double)x y:(double)y __attribute__((objc_designated_initializer));
        [Export("initWithX:y:")]
        [DesignatedInitializer]
        NativeHandle Constructor(double x, double y);

        // -(instancetype _Nonnull)initWithX:(double)x y:(double)y data:(id _Nullable)data;
        [Export("initWithX:y:data:")]
        NativeHandle Constructor(double x, double y, [NullAllowed] NSObject data);

        // -(instancetype _Nonnull)initWithX:(double)x y:(double)y icon:(UIImage * _Nullable)icon;
        [Export("initWithX:y:icon:")]
        NativeHandle Constructor(double x, double y, [NullAllowed] UIImage icon);

        // -(instancetype _Nonnull)initWithX:(double)x y:(double)y icon:(UIImage * _Nullable)icon data:(id _Nullable)data;
        [Export("initWithX:y:icon:data:")]
        NativeHandle Constructor(double x, double y, [NullAllowed] UIImage icon, [NullAllowed] NSObject data);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }
    }

    // @interface BarChartDataEntry : ChartDataEntry
    [BaseType(typeof(ChartDataEntry), Name = "_TtC8DGCharts17BarChartDataEntry")]
    interface BarChartDataEntry
    {
        // -(instancetype _Nonnull)initWithX:(double)x y:(double)y __attribute__((objc_designated_initializer));
        [Export("initWithX:y:")]
        [DesignatedInitializer]
        NativeHandle Constructor(double x, double y);

        // -(instancetype _Nonnull)initWithX:(double)x y:(double)y data:(id _Nullable)data;
        [Export("initWithX:y:data:")]
        NativeHandle Constructor(double x, double y, [NullAllowed] NSObject data);

        // -(instancetype _Nonnull)initWithX:(double)x y:(double)y icon:(UIImage * _Nullable)icon;
        [Export("initWithX:y:icon:")]
        NativeHandle Constructor(double x, double y, [NullAllowed] UIImage icon);

        // -(instancetype _Nonnull)initWithX:(double)x y:(double)y icon:(UIImage * _Nullable)icon data:(id _Nullable)data;
        [Export("initWithX:y:icon:data:")]
        NativeHandle Constructor(double x, double y, [NullAllowed] UIImage icon, [NullAllowed] NSObject data);

        // -(instancetype _Nonnull)initWithX:(double)x yValues:(NSArray<NSNumber *> * _Nonnull)yValues __attribute__((objc_designated_initializer));
        [Export("initWithX:yValues:")]
        [DesignatedInitializer]
        NativeHandle Constructor(double x, NSNumber[] yValues);

        // -(instancetype _Nonnull)initWithX:(double)x yValues:(NSArray<NSNumber *> * _Nonnull)yValues icon:(UIImage * _Nullable)icon;
        [Export("initWithX:yValues:icon:")]
        NativeHandle Constructor(double x, NSNumber[] yValues, [NullAllowed] UIImage icon);

        // -(instancetype _Nonnull)initWithX:(double)x yValues:(NSArray<NSNumber *> * _Nonnull)yValues data:(id _Nullable)data;
        [Export("initWithX:yValues:data:")]
        NativeHandle Constructor(double x, NSNumber[] yValues, [NullAllowed] NSObject data);

        // -(instancetype _Nonnull)initWithX:(double)x yValues:(NSArray<NSNumber *> * _Nonnull)yValues icon:(UIImage * _Nullable)icon data:(id _Nullable)data;
        [Export("initWithX:yValues:icon:data:")]
        NativeHandle Constructor(double x, NSNumber[] yValues, [NullAllowed] UIImage icon, [NullAllowed] NSObject data);

        // -(double)sumBelowStackIndex:(NSInteger)stackIndex __attribute__((warn_unused_result("")));
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
    }

    interface IChartDataProvider { }

    // @protocol ChartDataProvider
    [Protocol(Name = "_TtP8DGCharts17ChartDataProvider_"), Model]
    [BaseType(typeof(NSObject))]
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
        nfloat MaxHighlightDistance { get; set; }

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
        nint MaxVisibleCount { get; set; }
    }

    interface IBarLineScatterCandleBubbleChartDataProvider { }

    // @protocol BarLineScatterCandleBubbleChartDataProvider <ChartDataProvider>
    [Protocol(Name = "_TtP8DGCharts43BarLineScatterCandleBubbleChartDataProvider_"), Model]
    [BaseType(typeof(NSObject))]
    interface BarLineScatterCandleBubbleChartDataProvider : ChartDataProvider
    {
        // @required -(ChartTransformer * _Nonnull)getTransformerForAxis:(enum AxisDependency)forAxis __attribute__((warn_unused_result("")));
        [Abstract]
        [Export("getTransformerForAxis:")]
        ChartTransformer GetTransformerForAxis(AxisDependency forAxis);

        // @required -(BOOL)isInvertedWithAxis:(enum AxisDependency)axis __attribute__((warn_unused_result("")));
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
    [Protocol(Name = "_TtP8DGCharts20BarChartDataProvider_"), Model]
    [BaseType(typeof(NSObject))]
    interface BarChartDataProvider : BarLineScatterCandleBubbleChartDataProvider
    {
        // @required @property (readonly, nonatomic, strong) BarChartData * _Nullable barData;
        [Abstract]
        [NullAllowed, Export("barData", ArgumentSemantic.Strong)]
        BarChartData BarData { get; set; }

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

    interface IChartDataSetProtocol { }

    // @protocol ChartDataSetProtocol
    [Protocol(Name = "_TtP8DGCharts20ChartDataSetProtocol_"), Model]
    [BaseType(typeof(NSObject))]
    interface ChartDataSetProtocol
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
        double YMin { get; set; }

        // @required @property (readonly, nonatomic) double yMax;
        [Abstract]
        [Export("yMax")]
        double YMax { get; set; }

        // @required @property (readonly, nonatomic) double xMin;
        [Abstract]
        [Export("xMin")]
        double XMin { get; set; }

        // @required @property (readonly, nonatomic) double xMax;
        [Abstract]
        [Export("xMax")]
        double XMax { get; set; }

        // @required @property (readonly, nonatomic) NSInteger entryCount;
        [Abstract]
        [Export("entryCount")]
        nint EntryCount { get; }

        // @required -(ChartDataEntry * _Nullable)entryForIndex:(NSInteger)i __attribute__((warn_unused_result("")));
        [Abstract]
        [Export("entryForIndex:")]
        [return: NullAllowed]
        ChartDataEntry EntryForIndex(nint i);

        // @required -(ChartDataEntry * _Nullable)entryForXValue:(double)xValue closestToY:(double)yValue rounding:(enum ChartDataSetRounding)rounding __attribute__((warn_unused_result("")));
        [Abstract]
        [Export("entryForXValue:closestToY:rounding:")]
        [return: NullAllowed]
        ChartDataEntry EntryForXValue(double xValue, double yValue, ChartDataSetRounding rounding);

        // @required -(ChartDataEntry * _Nullable)entryForXValue:(double)xValue closestToY:(double)yValue __attribute__((warn_unused_result("")));
        [Abstract]
        [Export("entryForXValue:closestToY:")]
        [return: NullAllowed]
        ChartDataEntry EntryForXValue(double xValue, double yValue);

        // @required -(NSArray<ChartDataEntry *> * _Nonnull)entriesForXValue:(double)xValue __attribute__((warn_unused_result("")));
        [Abstract]
        [Export("entriesForXValue:")]
        ChartDataEntry[] EntriesForXValue(double xValue);

        // @required -(NSInteger)entryIndexWithX:(double)xValue closestToY:(double)yValue rounding:(enum ChartDataSetRounding)rounding __attribute__((warn_unused_result("")));
        [Abstract]
        [Export("entryIndexWithX:closestToY:rounding:")]
        nint EntryIndexWithX(double xValue, double yValue, ChartDataSetRounding rounding);

        // @required -(NSInteger)entryIndexWithEntry:(ChartDataEntry * _Nonnull)e __attribute__((warn_unused_result("")));
        [Abstract]
        [Export("entryIndexWithEntry:")]
        nint EntryIndexWithEntry(ChartDataEntry e);

        // @required -(BOOL)addEntry:(ChartDataEntry * _Nonnull)e __attribute__((warn_unused_result("")));
        [Abstract]
        [Export("addEntry:")]
        bool AddEntry(ChartDataEntry e);

        // @required -(BOOL)addEntryOrdered:(ChartDataEntry * _Nonnull)e __attribute__((warn_unused_result("")));
        [Abstract]
        [Export("addEntryOrdered:")]
        bool AddEntryOrdered(ChartDataEntry e);

        // @required -(BOOL)removeEntry:(ChartDataEntry * _Nonnull)entry __attribute__((warn_unused_result("")));
        [Abstract]
        [Export("removeEntry:")]
        bool RemoveEntry(ChartDataEntry entry);

        // @required -(BOOL)removeEntryWithIndex:(NSInteger)index __attribute__((warn_unused_result("")));
        [Abstract]
        [Export("removeEntryWithIndex:")]
        bool RemoveEntryWithIndex(nint index);

        // @required -(BOOL)removeEntryWithX:(double)x __attribute__((warn_unused_result("")));
        [Abstract]
        [Export("removeEntryWithX:")]
        bool RemoveEntryWithX(double x);

        // @required -(BOOL)removeFirst __attribute__((warn_unused_result("")));
        [Abstract]
        [Export("removeFirst")]
        bool RemoveFirst();

        // @required -(BOOL)removeLast __attribute__((warn_unused_result("")));
        [Abstract]
        [Export("removeLast")]
        bool RemoveLast();

        // @required -(BOOL)contains:(ChartDataEntry * _Nonnull)e __attribute__((warn_unused_result("")));
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
        string Label { get; set; }

        // @required @property (readonly, nonatomic) enum AxisDependency axisDependency;
        [Abstract]
        [Export("axisDependency")]
        AxisDependency AxisDependency { get; set; }

        // @required @property (readonly, copy, nonatomic) NSArray<UIColor *> * _Nonnull valueColors;
        [Abstract]
        [Export("valueColors", ArgumentSemantic.Copy)]
        UIColor[] ValueColors { get; set; }

        // @required @property (readonly, copy, nonatomic) NSArray<UIColor *> * _Nonnull colors;
        [Abstract]
        [Export("colors", ArgumentSemantic.Copy)]
        UIColor[] Colors { get; set; }

        // @required -(UIColor * _Nonnull)colorAtIndex:(NSInteger)atIndex __attribute__((warn_unused_result("")));
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
        bool IsHighlightEnabled { get; set; }

        // @required @property (nonatomic, strong) id<ChartValueFormatter> _Nonnull valueFormatter;
        [Abstract]
        [Export("valueFormatter", ArgumentSemantic.Strong)]
        IChartValueFormatter ValueFormatter { get; set; }

        // @required @property (nonatomic, strong) UIColor * _Nonnull valueTextColor;
        [Abstract]
        [Export("valueTextColor", ArgumentSemantic.Strong)]
        UIColor ValueTextColor { get; set; }

        // @required -(UIColor * _Nonnull)valueTextColorAt:(NSInteger)index __attribute__((warn_unused_result("")));
        [Abstract]
        [Export("valueTextColorAt:")]
        UIColor ValueTextColorAt(nint index);

        // @required @property (nonatomic, strong) UIFont * _Nonnull valueFont;
        [Abstract]
        [Export("valueFont", ArgumentSemantic.Strong)]
        UIFont ValueFont { get; set; }

        // @required @property (nonatomic) CGFloat valueLabelAngle;
        [Abstract]
        [Export("valueLabelAngle")]
        nfloat ValueLabelAngle { get; set; }

        // @required @property (readonly, nonatomic) enum ChartLegendForm form;
        [Abstract]
        [Export("form")]
        ChartLegendForm Form { get; set; }

        // @required @property (readonly, nonatomic) CGFloat formSize;
        [Abstract]
        [Export("formSize")]
        nfloat FormSize { get; set; }

        // @required @property (readonly, nonatomic) CGFloat formLineWidth;
        [Abstract]
        [Export("formLineWidth")]
        nfloat FormLineWidth { get; set; }

        // @required @property (readonly, nonatomic) CGFloat formLineDashPhase;
        [Abstract]
        [Export("formLineDashPhase")]
        nfloat FormLineDashPhase { get; set; }

        // @required @property (readonly, copy, nonatomic) NSArray<NSNumber *> * _Nullable formLineDashLengths;
        [Abstract]
        [NullAllowed, Export("formLineDashLengths", ArgumentSemantic.Copy)]
        NSNumber[] FormLineDashLengths { get; set; }

        // @required @property (nonatomic) BOOL drawValuesEnabled;
        [Abstract]
        [Export("drawValuesEnabled")]
        bool DrawValuesEnabled { get; set; }

        // @required @property (readonly, nonatomic) BOOL isDrawValuesEnabled;
        [Abstract]
        [Export("isDrawValuesEnabled")]
        bool IsDrawValuesEnabled { get; }

        // @required @property (nonatomic) BOOL drawIconsEnabled;
        [Abstract]
        [Export("drawIconsEnabled")]
        bool DrawIconsEnabled { get; set; }

        // @required @property (readonly, nonatomic) BOOL isDrawIconsEnabled;
        [Abstract]
        [Export("isDrawIconsEnabled")]
        bool IsDrawIconsEnabled { get; }

        // @required @property (nonatomic) CGPoint iconsOffset;
        [Abstract]
        [Export("iconsOffset", ArgumentSemantic.Assign)]
        CGPoint IconsOffset { get; set; }

        // @required @property (nonatomic) BOOL visible;
        [Abstract]
        [Export("visible")]
        bool Visible { get; set; }

        // @required @property (readonly, nonatomic) BOOL isVisible;
        [Abstract]
        [Export("isVisible")]
        bool IsVisible { get; }
    }

    interface IBarLineScatterCandleBubbleChartDataSetProtocol { }

    // @protocol BarLineScatterCandleBubbleChartDataSetProtocol <ChartDataSetProtocol>
    [Protocol(Name = "_TtP8DGCharts46BarLineScatterCandleBubbleChartDataSetProtocol_"), Model]
    [BaseType(typeof(NSObject))]
    interface BarLineScatterCandleBubbleChartDataSetProtocol : ChartDataSetProtocol
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

    interface IBarChartDataSetProtocol { }

    // @protocol BarChartDataSetProtocol <BarLineScatterCandleBubbleChartDataSetProtocol>
    [Protocol(Name = "_TtP8DGCharts23BarChartDataSetProtocol_"), Model]
    [BaseType(typeof(NSObject))]
    interface BarChartDataSetProtocol : BarLineScatterCandleBubbleChartDataSetProtocol
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

    // @interface ChartBaseDataSet : NSObject <ChartDataSetProtocol, NSCopying>
    [BaseType(typeof(NSObject), Name = "_TtC8DGCharts16ChartBaseDataSet")]
    interface ChartBaseDataSet : ChartDataSetProtocol, INSCopying
    {
        // -(instancetype _Nonnull)initWithLabel:(NSString * _Nonnull)label __attribute__((objc_designated_initializer));
        [Export("initWithLabel:")]
        [DesignatedInitializer]
        NativeHandle Constructor(string label);

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

        // -(ChartDataEntry * _Nullable)entryForIndex:(NSInteger)i __attribute__((warn_unused_result("")));
        [Export("entryForIndex:")]
        [return: NullAllowed]
        ChartDataEntry EntryForIndex(nint i);

        // -(ChartDataEntry * _Nullable)entryForXValue:(double)x closestToY:(double)y rounding:(enum ChartDataSetRounding)rounding __attribute__((warn_unused_result("")));
        [Export("entryForXValue:closestToY:rounding:")]
        [return: NullAllowed]
        ChartDataEntry EntryForXValue(double x, double y, ChartDataSetRounding rounding);

        // -(ChartDataEntry * _Nullable)entryForXValue:(double)x closestToY:(double)y __attribute__((warn_unused_result("")));
        [Export("entryForXValue:closestToY:")]
        [return: NullAllowed]
        ChartDataEntry EntryForXValue(double x, double y);

        // -(NSArray<ChartDataEntry *> * _Nonnull)entriesForXValue:(double)x __attribute__((warn_unused_result("")));
        [Export("entriesForXValue:")]
        ChartDataEntry[] EntriesForXValue(double x);

        // -(NSInteger)entryIndexWithX:(double)xValue closestToY:(double)y rounding:(enum ChartDataSetRounding)rounding __attribute__((warn_unused_result("")));
        [Export("entryIndexWithX:closestToY:rounding:")]
        nint EntryIndexWithX(double xValue, double y, ChartDataSetRounding rounding);

        // -(NSInteger)entryIndexWithEntry:(ChartDataEntry * _Nonnull)e __attribute__((warn_unused_result("")));
        [Export("entryIndexWithEntry:")]
        nint EntryIndexWithEntry(ChartDataEntry e);

        // -(BOOL)addEntry:(ChartDataEntry * _Nonnull)e __attribute__((warn_unused_result("")));
        [Export("addEntry:")]
        bool AddEntry(ChartDataEntry e);

        // -(BOOL)addEntryOrdered:(ChartDataEntry * _Nonnull)e __attribute__((warn_unused_result("")));
        [Export("addEntryOrdered:")]
        bool AddEntryOrdered(ChartDataEntry e);

        // -(BOOL)removeEntry:(ChartDataEntry * _Nonnull)entry __attribute__((warn_unused_result("")));
        [Export("removeEntry:")]
        bool RemoveEntry(ChartDataEntry entry);

        // -(BOOL)removeEntryWithIndex:(NSInteger)index __attribute__((warn_unused_result("")));
        [Export("removeEntryWithIndex:")]
        bool RemoveEntryWithIndex(nint index);

        // -(BOOL)removeEntryWithX:(double)x __attribute__((warn_unused_result("")));
        [Export("removeEntryWithX:")]
        bool RemoveEntryWithX(double x);

        // -(BOOL)removeFirst __attribute__((warn_unused_result("")));
        [Export("removeFirst")]
        bool RemoveFirst();

        // -(BOOL)removeLast __attribute__((warn_unused_result("")));
        [Export("removeLast")]
        bool RemoveLast();

        // -(BOOL)contains:(ChartDataEntry * _Nonnull)e __attribute__((warn_unused_result("")));
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

        // -(UIColor * _Nonnull)colorAtIndex:(NSInteger)index __attribute__((warn_unused_result("")));
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

        // @property (nonatomic, strong) id<ChartValueFormatter> _Nonnull valueFormatter;
        [Export("valueFormatter", ArgumentSemantic.Strong)]
        IChartValueFormatter ValueFormatter { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull valueTextColor;
        [Export("valueTextColor", ArgumentSemantic.Strong)]
        UIColor ValueTextColor { get; set; }

        // -(UIColor * _Nonnull)valueTextColorAt:(NSInteger)index __attribute__((warn_unused_result("")));
        [Export("valueTextColorAt:")]
        UIColor ValueTextColorAt(nint index);

        // @property (nonatomic, strong) UIFont * _Nonnull valueFont;
        [Export("valueFont", ArgumentSemantic.Strong)]
        UIFont ValueFont { get; set; }

        // @property (nonatomic) CGFloat valueLabelAngle;
        [Export("valueLabelAngle")]
        nfloat ValueLabelAngle { get; set; }

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

        // @property (nonatomic) BOOL drawIconsEnabled;
        [Export("drawIconsEnabled")]
        bool DrawIconsEnabled { get; set; }

        // @property (readonly, nonatomic) BOOL isDrawIconsEnabled;
        [Export("isDrawIconsEnabled")]
        bool IsDrawIconsEnabled { get; }

        // @property (nonatomic) CGPoint iconsOffset;
        [Export("iconsOffset", ArgumentSemantic.Assign)]
        CGPoint IconsOffset { get; set; }

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
    }

    // @interface ChartDataSet : ChartBaseDataSet
    [BaseType(typeof(ChartBaseDataSet), Name = "_TtC8DGCharts12ChartDataSet")]
    interface ChartDataSet
    {
        // -(instancetype _Nonnull)initWithLabel:(NSString * _Nonnull)label;
        [Export("initWithLabel:")]
        NativeHandle Constructor(string label);

        // -(instancetype _Nonnull)initWithEntries:(NSArray<ChartDataEntry *> * _Nonnull)entries label:(NSString * _Nonnull)label __attribute__((objc_designated_initializer));
        [Export("initWithEntries:label:")]
        [DesignatedInitializer]
        NativeHandle Constructor(ChartDataEntry[] entries, string label);

        // -(instancetype _Nonnull)initWithEntries:(NSArray<ChartDataEntry *> * _Nonnull)entries;
        [Export("initWithEntries:")]
        NativeHandle Constructor(ChartDataEntry[] entries);

        // @property (readonly, copy, nonatomic) NSArray<ChartDataEntry *> * _Nonnull entries;
        [Export("entries", ArgumentSemantic.Copy)]
        ChartDataEntry[] Entries { get; }

        // -(void)replaceEntries:(NSArray<ChartDataEntry *> * _Nonnull)entries;
        [Export("replaceEntries:")]
        void ReplaceEntries(ChartDataEntry[] entries);

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

        // @property (readonly, nonatomic) NSInteger entryCount __attribute__((deprecated("Use `count` instead")));
        [Export("entryCount")]
        nint EntryCount { get; }

        // -(ChartDataEntry * _Nullable)entryForIndex:(NSInteger)i __attribute__((warn_unused_result(""))) __attribute__((deprecated("Use `subscript(index:)` instead.")));
        [Export("entryForIndex:")]
        [return: NullAllowed]
        ChartDataEntry EntryForIndex(nint i);

        // -(ChartDataEntry * _Nullable)entryForXValue:(double)xValue closestToY:(double)yValue rounding:(enum ChartDataSetRounding)rounding __attribute__((warn_unused_result("")));
        [Export("entryForXValue:closestToY:rounding:")]
        [return: NullAllowed]
        ChartDataEntry EntryForXValue(double xValue, double yValue, ChartDataSetRounding rounding);

        // -(ChartDataEntry * _Nullable)entryForXValue:(double)xValue closestToY:(double)yValue __attribute__((warn_unused_result("")));
        [Export("entryForXValue:closestToY:")]
        [return: NullAllowed]
        ChartDataEntry EntryForXValue(double xValue, double yValue);

        // -(NSArray<ChartDataEntry *> * _Nonnull)entriesForXValue:(double)xValue __attribute__((warn_unused_result("")));
        [Export("entriesForXValue:")]
        ChartDataEntry[] EntriesForXValue(double xValue);

        // -(NSInteger)entryIndexWithX:(double)xValue closestToY:(double)yValue rounding:(enum ChartDataSetRounding)rounding __attribute__((warn_unused_result("")));
        [Export("entryIndexWithX:closestToY:rounding:")]
        nint EntryIndexWithX(double xValue, double yValue, ChartDataSetRounding rounding);

        // -(NSInteger)entryIndexWithEntry:(ChartDataEntry * _Nonnull)e __attribute__((warn_unused_result(""))) __attribute__((deprecated("Use `firstIndex(of:)` or `lastIndex(of:)`")));
        [Export("entryIndexWithEntry:")]
        nint EntryIndexWithEntry(ChartDataEntry e);

        // -(BOOL)addEntry:(ChartDataEntry * _Nonnull)e __attribute__((warn_unused_result(""))) __attribute__((deprecated("Use `append(_:)` instead", "append(_:)")));
        [Export("addEntry:")]
        bool AddEntry(ChartDataEntry e);

        // -(BOOL)addEntryOrdered:(ChartDataEntry * _Nonnull)e __attribute__((warn_unused_result("")));
        [Export("addEntryOrdered:")]
        bool AddEntryOrdered(ChartDataEntry e);

        // -(BOOL)removeEntry:(ChartDataEntry * _Nonnull)entry __attribute__((warn_unused_result("")));
        [Export("removeEntry:")]
        bool RemoveEntry(ChartDataEntry entry);

        // -(BOOL)removeFirst __attribute__((warn_unused_result(""))) __attribute__((deprecated("Use `func removeFirst() -> ChartDataEntry` instead.")));
        [Export("removeFirst")]
        bool RemoveFirst();

        // -(BOOL)removeLast __attribute__((warn_unused_result(""))) __attribute__((deprecated("Use `func removeLast() -> ChartDataEntry` instead.")));
        [Export("removeLast")]
        bool RemoveLast();

        // -(void)clear __attribute__((deprecated("Use `removeAll(keepingCapacity:)` instead.")));
        [Export("clear")]
        void Clear();

        // -(void)removeAllWithKeepingCapacity:(BOOL)keepCapacity;
        [Export("removeAllWithKeepingCapacity:")]
        void RemoveAllWithKeepingCapacity(bool keepCapacity);

        // -(ChartDataEntry * _Nonnull)objectAtIndexedSubscript:(NSInteger)position __attribute__((warn_unused_result("")));
        [Export("objectAtIndexedSubscript:")]
        ChartDataEntry ObjectAtIndexedSubscript(nint position);

        // -(void)setObject:(ChartDataEntry * _Nonnull)newValue atIndexedSubscript:(NSInteger)position;
        [Export("setObject:atIndexedSubscript:")]
        void SetObject(ChartDataEntry newValue, nint position);
    }

    // @interface BarLineScatterCandleBubbleChartDataSet : ChartDataSet <BarLineScatterCandleBubbleChartDataSetProtocol>
    [BaseType(typeof(ChartDataSet), Name = "_TtC8DGCharts38BarLineScatterCandleBubbleChartDataSet")]
    interface BarLineScatterCandleBubbleChartDataSet : BarLineScatterCandleBubbleChartDataSetProtocol
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

        // -(instancetype _Nonnull)initWithEntries:(NSArray<ChartDataEntry *> * _Nonnull)entries label:(NSString * _Nonnull)label __attribute__((objc_designated_initializer));
        [Export("initWithEntries:label:")]
        [DesignatedInitializer]
        NativeHandle Constructor(ChartDataEntry[] entries, string label);
    }

    // @interface BarChartDataSet : BarLineScatterCandleBubbleChartDataSet <BarChartDataSetProtocol>
    [BaseType(typeof(BarLineScatterCandleBubbleChartDataSet), Name = "_TtC8DGCharts15BarChartDataSet")]
    interface BarChartDataSet : BarChartDataSetProtocol
    {
        // -(instancetype _Nonnull)initWithEntries:(NSArray<ChartDataEntry *> * _Nonnull)entries label:(NSString * _Nonnull)label __attribute__((objc_designated_initializer));
        [Export("initWithEntries:label:")]
        [DesignatedInitializer]
        NativeHandle Constructor(ChartDataEntry[] entries, string label);

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
    }

    interface IChartRenderer { }

    // @protocol ChartRenderer
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface ChartRenderer
    {
        // @required @property (readonly, nonatomic, strong) ChartViewPortHandler * _Nonnull viewPortHandler;
        [Abstract]
        [Export("viewPortHandler", ArgumentSemantic.Strong)]
        ChartViewPortHandler ViewPortHandler { get; set; }
    }

    interface IChartDataRenderer { }

    // @protocol ChartDataRenderer <ChartRenderer>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface ChartDataRenderer : ChartRenderer
    {
        // @required @property (readonly, copy, nonatomic) NSArray<NSUIAccessibilityElement *> * _Nonnull accessibleChartElements;
        [Abstract]
        [Export("accessibleChartElements", ArgumentSemantic.Copy)]
        NSUIAccessibilityElement[] AccessibleChartElements { get; set; }

        // @required @property (readonly, nonatomic, strong) ChartAnimator * _Nonnull animator;
        [Abstract]
        [Export("animator", ArgumentSemantic.Strong)]
        ChartAnimator Animator { get; }

        // @required -(void)drawDataWithContext:(CGContextRef _Nonnull)context;
        [Abstract]
        [Export("drawDataWithContext:")]
        void DrawDataWithContext(CGContext context);

        // @required -(void)drawValuesWithContext:(CGContextRef _Nonnull)context;
        [Abstract]
        [Export("drawValuesWithContext:")]
        void DrawValuesWithContext(CGContext context);

        // @required -(void)drawExtrasWithContext:(CGContextRef _Nonnull)context;
        [Abstract]
        [Export("drawExtrasWithContext:")]
        void DrawExtrasWithContext(CGContext context);

        // @required -(void)drawHighlightedWithContext:(CGContextRef _Nonnull)context indices:(NSArray<ChartHighlight *> * _Nonnull)indices;
        [Abstract]
        [Export("drawHighlightedWithContext:indices:")]
        void DrawHighlightedWithContext(CGContext context, ChartHighlight[] indices);

        // @required -(void)initBuffers __attribute__((objc_method_family("none")));
        [Abstract]
        [Export("initBuffers")]
        void InitBuffers();

        // @required -(BOOL)isDrawingValuesAllowedWithDataProvider:(id<ChartDataProvider> _Nullable)dataProvider __attribute__((warn_unused_result("")));
        [Abstract]
        [Export("isDrawingValuesAllowedWithDataProvider:")]
        bool IsDrawingValuesAllowedWithDataProvider([NullAllowed] IChartDataProvider dataProvider);

        // @required -(NSUIAccessibilityElement * _Nonnull)createAccessibleHeaderUsingChart:(ChartViewBase * _Nonnull)chart andData:(ChartData * _Nonnull)data withDefaultDescription:(NSString * _Nonnull)defaultDescription __attribute__((warn_unused_result("")));
        [Abstract]
        [Export("createAccessibleHeaderUsingChart:andData:withDefaultDescription:")]
        NSUIAccessibilityElement CreateAccessibleHeaderUsingChart(ChartViewBase chart, ChartData data, string defaultDescription);
    }

    // @interface BarLineScatterCandleBubbleChartRenderer : NSObject <ChartDataRenderer>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface BarLineScatterCandleBubbleChartRenderer : ChartDataRenderer
    {
        // @property (readonly, nonatomic, strong) ChartViewPortHandler * _Nonnull viewPortHandler;
        [Export("viewPortHandler", ArgumentSemantic.Strong)]
        ChartViewPortHandler ViewPortHandler { get; }

        // @property (copy, nonatomic) NSArray<NSUIAccessibilityElement *> * _Nonnull accessibleChartElements;
        [Export("accessibleChartElements", ArgumentSemantic.Copy)]
        NSUIAccessibilityElement[] AccessibleChartElements { get; set; }

        // @property (readonly, nonatomic, strong) ChartAnimator * _Nonnull animator;
        [Export("animator", ArgumentSemantic.Strong)]
        ChartAnimator Animator { get; }

        // -(void)drawDataWithContext:(CGContextRef _Nonnull)context;
        [Export("drawDataWithContext:")]
        void DrawDataWithContext(CGContext context);

        // -(void)drawValuesWithContext:(CGContextRef _Nonnull)context;
        [Export("drawValuesWithContext:")]
        void DrawValuesWithContext(CGContext context);

        // -(void)drawExtrasWithContext:(CGContextRef _Nonnull)context;
        [Export("drawExtrasWithContext:")]
        void DrawExtrasWithContext(CGContext context);

        // -(void)drawHighlightedWithContext:(CGContextRef _Nonnull)context indices:(NSArray<ChartHighlight *> * _Nonnull)indices;
        [Export("drawHighlightedWithContext:indices:")]
        void DrawHighlightedWithContext(CGContext context, ChartHighlight[] indices);

        // -(void)initBuffers __attribute__((objc_method_family("none")));
        [Export("initBuffers")]
        void InitBuffers();

        // -(BOOL)isDrawingValuesAllowedWithDataProvider:(id<ChartDataProvider> _Nullable)dataProvider __attribute__((warn_unused_result("")));
        [Export("isDrawingValuesAllowedWithDataProvider:")]
        bool IsDrawingValuesAllowedWithDataProvider([NullAllowed] IChartDataProvider dataProvider);

        // -(NSUIAccessibilityElement * _Nonnull)createAccessibleHeaderUsingChart:(ChartViewBase * _Nonnull)chart andData:(ChartData * _Nonnull)data withDefaultDescription:(NSString * _Nonnull)defaultDescription __attribute__((warn_unused_result("")));
        [Export("createAccessibleHeaderUsingChart:andData:withDefaultDescription:")]
        NSUIAccessibilityElement CreateAccessibleHeaderUsingChart(ChartViewBase chart, ChartData data, string defaultDescription);
    }

    // @interface BarChartRenderer : BarLineScatterCandleBubbleChartRenderer
    [BaseType(typeof(BarLineScatterCandleBubbleChartRenderer), Name = "_TtC8DGCharts16BarChartRenderer")]
    interface BarChartRenderer
    {
        // @property (nonatomic, weak) id<BarChartDataProvider> _Nullable dataProvider;
        [NullAllowed, Export("dataProvider", ArgumentSemantic.Weak)]
        IBarChartDataProvider DataProvider { get; set; }

        // -(instancetype _Nonnull)initWithDataProvider:(id<BarChartDataProvider> _Nonnull)dataProvider animator:(ChartAnimator * _Nonnull)animator viewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler __attribute__((objc_designated_initializer));
        [Export("initWithDataProvider:animator:viewPortHandler:")]
        [DesignatedInitializer]
        NativeHandle Constructor(IBarChartDataProvider dataProvider, ChartAnimator animator, ChartViewPortHandler viewPortHandler);

        // -(void)initBuffers __attribute__((objc_method_family("none")));
        [Export("initBuffers")]
        void InitBuffers();

        // -(void)drawDataWithContext:(CGContextRef _Nonnull)context;
        [Export("drawDataWithContext:")]
        void DrawDataWithContext(CGContext context);

        // -(void)drawDataSetWithContext:(CGContextRef _Nonnull)context dataSet:(id<BarChartDataSetProtocol> _Nonnull)dataSet index:(NSInteger)index;
        [Export("drawDataSetWithContext:dataSet:index:")]
        void DrawDataSetWithContext(CGContext context, IBarChartDataSetProtocol dataSet, nint index);

        // -(void)drawValuesWithContext:(CGContextRef _Nonnull)context;
        [Export("drawValuesWithContext:")]
        void DrawValuesWithContext(CGContext context);

        // -(void)drawValueWithContext:(CGContextRef _Nonnull)context value:(NSString * _Nonnull)value xPos:(CGFloat)xPos yPos:(CGFloat)yPos font:(UIFont * _Nonnull)font align:(NSTextAlignment)align color:(UIColor * _Nonnull)color anchor:(CGPoint)anchor angleRadians:(CGFloat)angleRadians;
        [Export("drawValueWithContext:value:xPos:yPos:font:align:color:anchor:angleRadians:")]
        void DrawValueWithContext(CGContext context, string value, nfloat xPos, nfloat yPos, UIFont font, UITextAlignment align, UIColor color, CGPoint anchor, nfloat angleRadians);

        // -(void)drawExtrasWithContext:(CGContextRef _Nonnull)context;
        [Export("drawExtrasWithContext:")]
        void DrawExtrasWithContext(CGContext context);

        // -(void)drawHighlightedWithContext:(CGContextRef _Nonnull)context indices:(NSArray<ChartHighlight *> * _Nonnull)indices;
        [Export("drawHighlightedWithContext:indices:")]
        void DrawHighlightedWithContext(CGContext context, ChartHighlight[] indices);
    }

    // @interface NSUIView : UIView
    [BaseType(typeof(UIView), Name = "_TtC8DGCharts8NSUIView")]
    interface NSUIView
    {
        // @property (readonly, nonatomic, strong) CALayer * _Nullable nsuiLayer;
        [NullAllowed, Export("nsuiLayer", ArgumentSemantic.Strong)]
        CALayer NsuiLayer { get; }

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        NativeHandle Constructor(CGRect frame);

        // -(NSArray * _Nullable)accessibilityChildren __attribute__((warn_unused_result("")));
        [NullAllowed, Export("accessibilityChildren")]
        NSObject[] AccessibilityChildren { get; }

        // @property (nonatomic) BOOL isAccessibilityElement;
        [Export("isAccessibilityElement")]
        bool IsAccessibilityElement { get; set; }

        // -(NSInteger)accessibilityElementCount __attribute__((swift_attr("@MainActor"))) __attribute__((warn_unused_result("")));
        [Export("accessibilityElementCount")]
        nint AccessibilityElementCount { get; }

        // -(id _Nullable)accessibilityElementAtIndex:(NSInteger)index __attribute__((swift_attr("@MainActor"))) __attribute__((warn_unused_result("")));
        [Export("accessibilityElementAtIndex:")]
        [return: NullAllowed]
        NSObject AccessibilityElementAtIndex(nint index);

        // -(NSInteger)indexOfAccessibilityElement:(id _Nonnull)element __attribute__((swift_attr("@MainActor"))) __attribute__((warn_unused_result("")));
        [Export("indexOfAccessibilityElement:")]
        nint IndexOfAccessibilityElement(NSObject element);

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
    }

    // @interface ChartViewBase : NSUIView <ChartAnimatorDelegate, ChartDataProvider>
    [BaseType(typeof(NSUIView), Name = "_TtC8DGCharts13ChartViewBase")]
    interface ChartViewBase : ChartAnimatorDelegate, ChartDataProvider
    {
        // @property (nonatomic, strong) ChartData * _Nullable data;
        [NullAllowed, Export("data", ArgumentSemantic.Strong)]
        ChartData Data { get; set; }

        // @property (nonatomic) BOOL dragDecelerationEnabled;
        [Export("dragDecelerationEnabled")]
        bool DragDecelerationEnabled { get; set; }

        // @property (nonatomic, strong) ChartXAxis * _Nonnull xAxis;
        [Export("xAxis", ArgumentSemantic.Strong)]
        ChartXAxis XAxis { get; set; }

        // @property (nonatomic, strong) ChartDescription * _Nonnull chartDescription;
        [Export("chartDescription", ArgumentSemantic.Strong)]
        ChartDescription ChartDescription { get; set; }

        // @property (nonatomic, strong) ChartLegend * _Nonnull legend;
        [Export("legend", ArgumentSemantic.Strong)]
        ChartLegend Legend { get; set; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        IChartViewDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<ChartViewDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull noDataText;
        [Export("noDataText")]
        string NoDataText { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull noDataFont;
        [Export("noDataFont", ArgumentSemantic.Strong)]
        UIFont NoDataFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull noDataTextColor;
        [Export("noDataTextColor", ArgumentSemantic.Strong)]
        UIColor NoDataTextColor { get; set; }

        // @property (nonatomic) NSTextAlignment noDataTextAlignment;
        [Export("noDataTextAlignment", ArgumentSemantic.Assign)]
        UITextAlignment NoDataTextAlignment { get; set; }

        // @property (nonatomic, strong) ChartLegendRenderer * _Nonnull legendRenderer;
        [Export("legendRenderer", ArgumentSemantic.Strong)]
        ChartLegendRenderer LegendRenderer { get; set; }

        // @property (nonatomic, strong) id<ChartDataRenderer> _Nullable renderer;
        [NullAllowed, Export("renderer", ArgumentSemantic.Strong)]
        IChartDataRenderer Renderer { get; set; }

        // @property (nonatomic, strong) id<ChartHighlighter> _Nullable highlighter;
        [NullAllowed, Export("highlighter", ArgumentSemantic.Strong)]
        IChartHighlighterProtocol Highlighter { get; set; }

        // @property (nonatomic, strong) ChartViewPortHandler * _Nonnull viewPortHandler;
        [Export("viewPortHandler", ArgumentSemantic.Strong)]
        ChartViewPortHandler ViewPortHandler { get; set; }

        // @property (nonatomic, strong) ChartAnimator * _Nonnull chartAnimator;
        [Export("chartAnimator", ArgumentSemantic.Strong)]
        ChartAnimator ChartAnimator { get; set; }

        // @property (copy, nonatomic) NSArray<ChartHighlight *> * _Nonnull highlighted;
        [Export("highlighted", ArgumentSemantic.Copy)]
        ChartHighlight[] Highlighted { get; set; }

        // @property (nonatomic) BOOL drawMarkers;
        [Export("drawMarkers")]
        bool DrawMarkers { get; set; }

        // @property (readonly, nonatomic) BOOL isDrawMarkersEnabled;
        [Export("isDrawMarkersEnabled")]
        bool IsDrawMarkersEnabled { get; }

        // @property (nonatomic, strong) id<ChartMarker> _Nullable marker;
        [NullAllowed, Export("marker", ArgumentSemantic.Strong)]
        IChartMarker Marker { get; set; }

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
        NativeHandle Constructor(CGRect frame);

        // -(void)clear;
        [Export("clear")]
        void Clear();

        // -(void)clearValues;
        [Export("clearValues")]
        void ClearValues();

        // -(BOOL)isEmpty __attribute__((warn_unused_result("")));
        [Export("isEmpty")]
        bool IsEmpty { get; }

        // -(void)notifyDataSetChanged;
        [Export("notifyDataSetChanged")]
        void NotifyDataSetChanged();

        // -(void)drawRect:(CGRect)rect;
        [Export("drawRect:")]
        void DrawRect(CGRect rect);

        // -(NSArray * _Nullable)accessibilityChildren __attribute__((warn_unused_result("")));
        [NullAllowed, Export("accessibilityChildren")]
        NSObject[] AccessibilityChildren { get; }

        // @property (nonatomic) BOOL highlightPerTapEnabled;
        [Export("highlightPerTapEnabled")]
        bool HighlightPerTapEnabled { get; set; }

        // @property (readonly, nonatomic) BOOL isHighLightPerTapEnabled;
        [Export("isHighLightPerTapEnabled")]
        bool IsHighLightPerTapEnabled { get; }

        // -(BOOL)valuesToHighlight __attribute__((warn_unused_result("")));
        [Export("valuesToHighlight")]
        bool ValuesToHighlight();

        // -(void)highlightValues:(NSArray<ChartHighlight *> * _Nullable)highs;
        [Export("highlightValues:")]
        void HighlightValues([NullAllowed] ChartHighlight[] highs);

        // -(void)highlightValueWithX:(double)x dataSetIndex:(NSInteger)dataSetIndex dataIndex:(NSInteger)dataIndex;
        [Export("highlightValueWithX:dataSetIndex:dataIndex:")]
        void HighlightValueWithX(double x, nint dataSetIndex, nint dataIndex);

        // -(void)highlightValueWithX:(double)x y:(double)y dataSetIndex:(NSInteger)dataSetIndex dataIndex:(NSInteger)dataIndex;
        [Export("highlightValueWithX:y:dataSetIndex:dataIndex:")]
        void HighlightValueWithX(double x, double y, nint dataSetIndex, nint dataIndex);

        // -(void)highlightValueWithX:(double)x dataSetIndex:(NSInteger)dataSetIndex dataIndex:(NSInteger)dataIndex callDelegate:(BOOL)callDelegate;
        [Export("highlightValueWithX:dataSetIndex:dataIndex:callDelegate:")]
        void HighlightValueWithX(double x, nint dataSetIndex, nint dataIndex, bool callDelegate);

        // -(void)highlightValueWithX:(double)x y:(double)y dataSetIndex:(NSInteger)dataSetIndex dataIndex:(NSInteger)dataIndex callDelegate:(BOOL)callDelegate;
        [Export("highlightValueWithX:y:dataSetIndex:dataIndex:callDelegate:")]
        void HighlightValueWithX(double x, double y, nint dataSetIndex, nint dataIndex, bool callDelegate);

        // -(void)highlightValue:(ChartHighlight * _Nullable)highlight;
        [Export("highlightValue:")]
        void HighlightValue([NullAllowed] ChartHighlight highlight);

        // -(void)highlightValue:(ChartHighlight * _Nullable)highlight callDelegate:(BOOL)callDelegate;
        [Export("highlightValue:callDelegate:")]
        void HighlightValue([NullAllowed] ChartHighlight highlight, bool callDelegate);

        // -(ChartHighlight * _Nullable)getHighlightByTouchPoint:(CGPoint)pt __attribute__((warn_unused_result("")));
        [Export("getHighlightByTouchPoint:")]
        [return: NullAllowed]
        ChartHighlight GetHighlightByTouchPoint(CGPoint pt);

        // @property (nonatomic, strong) ChartHighlight * _Nullable lastHighlighted;
        [NullAllowed, Export("lastHighlighted", ArgumentSemantic.Strong)]
        ChartHighlight LastHighlighted { get; set; }

        // -(CGPoint)getMarkerPositionWithHighlight:(ChartHighlight * _Nonnull)highlight __attribute__((warn_unused_result("")));
        [Export("getMarkerPositionWithHighlight:")]
        CGPoint GetMarkerPositionWithHighlight(ChartHighlight highlight);

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

        // @property (readonly, nonatomic) CGRect contentRect;
        [Export("contentRect")]
        CGRect ContentRect { get; }

        // -(UIImage * _Nullable)getChartImageWithTransparent:(BOOL)transparent __attribute__((warn_unused_result("")));
        [Export("getChartImageWithTransparent:")]
        [return: NullAllowed]
        UIImage GetChartImageWithTransparent(bool transparent);

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
    [BaseType(typeof(ChartViewBase), Name = "_TtC8DGCharts20BarLineChartViewBase")]
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

        // @property (nonatomic) BOOL clipDataToContentEnabled;
        [Export("clipDataToContentEnabled")]
        bool ClipDataToContentEnabled { get; set; }

        // @property (nonatomic) CGFloat minOffset;
        [Export("minOffset")]
        nfloat MinOffset { get; set; }

        // @property (nonatomic) BOOL keepPositionOnRotation;
        [Export("keepPositionOnRotation")]
        bool KeepPositionOnRotation { get; set; }

        // @property (nonatomic, strong) ChartYAxis * _Nonnull leftAxis;
        [Export("leftAxis", ArgumentSemantic.Strong)]
        ChartYAxis LeftAxis { get; set; }

        // @property (nonatomic, strong) ChartYAxis * _Nonnull rightAxis;
        [Export("rightAxis", ArgumentSemantic.Strong)]
        ChartYAxis RightAxis { get; set; }

        // @property (nonatomic, strong) ChartYAxisRenderer * _Nonnull leftYAxisRenderer;
        [Export("leftYAxisRenderer", ArgumentSemantic.Strong)]
        ChartYAxisRenderer LeftYAxisRenderer { get; set; }

        // @property (nonatomic, strong) ChartYAxisRenderer * _Nonnull rightYAxisRenderer;
        [Export("rightYAxisRenderer", ArgumentSemantic.Strong)]
        ChartYAxisRenderer RightYAxisRenderer { get; set; }

        // @property (nonatomic, strong) ChartXAxisRenderer * _Nonnull xAxisRenderer;
        [Export("xAxisRenderer", ArgumentSemantic.Strong)]
        ChartXAxisRenderer XAxisRenderer { get; set; }

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        NativeHandle Constructor(CGRect frame);

        // -(void)drawRect:(CGRect)rect;
        [Export("drawRect:")]
        void DrawRect(CGRect rect);

        // -(void)notifyDataSetChanged;
        [Export("notifyDataSetChanged")]
        void NotifyDataSetChanged();

        // -(void)stopDeceleration;
        [Export("stopDeceleration")]
        void StopDeceleration();

        // -(BOOL)gestureRecognizerShouldBegin:(UIGestureRecognizer * _Nonnull)gestureRecognizer __attribute__((warn_unused_result("")));
        [Export("gestureRecognizerShouldBegin:")]
        bool GestureRecognizerShouldBegin(UIGestureRecognizer gestureRecognizer);

        // -(BOOL)gestureRecognizer:(UIGestureRecognizer * _Nonnull)gestureRecognizer shouldRecognizeSimultaneouslyWithGestureRecognizer:(UIGestureRecognizer * _Nonnull)otherGestureRecognizer __attribute__((warn_unused_result("")));
        [Export("gestureRecognizer:shouldRecognizeSimultaneouslyWithGestureRecognizer:")]
        bool GestureRecognizer(UIGestureRecognizer gestureRecognizer, UIGestureRecognizer otherGestureRecognizer);

        // -(void)zoomIn;
        [Export("zoomIn")]
        void ZoomIn();

        // -(void)zoomOut;
        [Export("zoomOut")]
        void ZoomOut();

        // -(void)resetZoom;
        [Export("resetZoom")]
        void ResetZoom();

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

        // -(double)getAxisRangeWithAxis:(enum AxisDependency)axis __attribute__((warn_unused_result("")));
        [Export("getAxisRangeWithAxis:")]
        double GetAxisRangeWithAxis(AxisDependency axis);

        // -(CGPoint)getPositionWithEntry:(ChartDataEntry * _Nonnull)e axis:(enum AxisDependency)axis __attribute__((warn_unused_result("")));
        [Export("getPositionWithEntry:axis:")]
        CGPoint GetPositionWithEntry(ChartDataEntry e, AxisDependency axis);

        // @property (nonatomic) BOOL dragEnabled;
        [Export("dragEnabled")]
        bool DragEnabled { get; set; }

        // @property (readonly, nonatomic) BOOL isDragEnabled;
        [Export("isDragEnabled")]
        bool IsDragEnabled { get; }

        // @property (nonatomic) BOOL dragXEnabled;
        [Export("dragXEnabled")]
        bool DragXEnabled { get; set; }

        // @property (nonatomic) BOOL dragYEnabled;
        [Export("dragYEnabled")]
        bool DragYEnabled { get; set; }

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

        // -(CGPoint)valueForTouchPointWithPoint:(CGPoint)pt axis:(enum AxisDependency)axis __attribute__((warn_unused_result("")));
        [Export("valueForTouchPointWithPoint:axis:")]
        CGPoint ValueForTouchPointWithPoint(CGPoint pt, AxisDependency axis);

        // -(CGPoint)pixelForValuesWithX:(double)x y:(double)y axis:(enum AxisDependency)axis __attribute__((warn_unused_result("")));
        [Export("pixelForValuesWithX:y:axis:")]
        CGPoint PixelForValuesWithX(double x, double y, AxisDependency axis);

        // -(ChartDataEntry * _Null_unspecified)getEntryByTouchPointWithPoint:(CGPoint)pt __attribute__((warn_unused_result("")));
        [Export("getEntryByTouchPointWithPoint:")]
        ChartDataEntry GetEntryByTouchPointWithPoint(CGPoint pt);

        // -(id<BarLineScatterCandleBubbleChartDataSetProtocol> _Nullable)getDataSetByTouchPointWithPoint:(CGPoint)pt __attribute__((warn_unused_result("")));
        [Export("getDataSetByTouchPointWithPoint:")]
        [return: NullAllowed]
        IBarLineScatterCandleBubbleChartDataSetProtocol GetDataSetByTouchPointWithPoint(CGPoint pt);

        // @property (readonly, nonatomic) CGFloat scaleX;
        [Export("scaleX")]
        nfloat ScaleX { get; }

        // @property (readonly, nonatomic) CGFloat scaleY;
        [Export("scaleY")]
        nfloat ScaleY { get; }

        // @property (readonly, nonatomic) BOOL isFullyZoomedOut;
        [Export("isFullyZoomedOut")]
        bool IsFullyZoomedOut { get; }

        // -(ChartYAxis * _Nonnull)getAxis:(enum AxisDependency)axis __attribute__((warn_unused_result("")));
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

        // -(CGFloat)getYAxisMinWidth:(enum AxisDependency)axis __attribute__((warn_unused_result("")));
        [Export("getYAxisMinWidth:")]
        nfloat GetYAxisMinWidth(AxisDependency axis);

        // -(void)setYAxisMaxWidth:(enum AxisDependency)axis width:(CGFloat)width;
        [Export("setYAxisMaxWidth:width:")]
        void SetYAxisMaxWidth(AxisDependency axis, nfloat width);

        // -(CGFloat)getYAxisMaxWidth:(enum AxisDependency)axis __attribute__((warn_unused_result("")));
        [Export("getYAxisMaxWidth:")]
        nfloat GetYAxisMaxWidth(AxisDependency axis);

        // -(CGFloat)getYAxisWidth:(enum AxisDependency)axis __attribute__((warn_unused_result("")));
        [Export("getYAxisWidth:")]
        nfloat GetYAxisWidth(AxisDependency axis);

        // -(ChartTransformer * _Nonnull)getTransformerForAxis:(enum AxisDependency)axis __attribute__((warn_unused_result("")));
        [Export("getTransformerForAxis:")]
        ChartTransformer GetTransformerForAxis(AxisDependency axis);

        // @property (nonatomic) NSInteger maxVisibleCount;
        [Export("maxVisibleCount")]
        nint MaxVisibleCount { get; set; }

        // -(BOOL)isInvertedWithAxis:(enum AxisDependency)axis __attribute__((warn_unused_result("")));
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
    [BaseType(typeof(BarLineChartViewBase), Name = "_TtC8DGCharts12BarChartView")]
    interface BarChartView : BarChartDataProvider
    {
        // -(ChartHighlight * _Nullable)getHighlightByTouchPoint:(CGPoint)pt __attribute__((warn_unused_result("")));
        [Export("getHighlightByTouchPoint:")]
        [return: NullAllowed]
        ChartHighlight GetHighlightByTouchPoint(CGPoint pt);

        // -(CGRect)getBarBoundsWithEntry:(BarChartDataEntry * _Nonnull)e __attribute__((warn_unused_result("")));
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
        NativeHandle Constructor(CGRect frame);
    }

    interface IChartHighlighterProtocol { }

    // @protocol ChartHighlighter
    [Protocol(Name = "ChartHighlighter"), Model]
    [BaseType(typeof(NSObject))]
    interface ChartHighlighterProtocol
    {
        // @required -(ChartHighlight * _Nullable)getHighlightWithX:(CGFloat)x y:(CGFloat)y __attribute__((warn_unused_result("")));
        [Abstract]
        [Export("getHighlightWithX:y:")]
        [return: NullAllowed]
        ChartHighlight GetHighlightWithX(nfloat x, nfloat y);
    }

    // @interface ChartHighlighter : NSObject <ChartHighlighter>
    [BaseType(typeof(NSObject), Name = "_TtC8DGCharts16ChartHighlighter")]
    [DisableDefaultCtor]
    interface ChartHighlighter : ChartHighlighterProtocol
    {
        // @property (nonatomic, weak) id<ChartDataProvider> _Nullable chart;
        [NullAllowed, Export("chart", ArgumentSemantic.Weak)]
        IChartDataProvider Chart { get; set; }

        // -(instancetype _Nonnull)initWithChart:(id<ChartDataProvider> _Nonnull)chart __attribute__((objc_designated_initializer));
        [Export("initWithChart:")]
        [DesignatedInitializer]
        NativeHandle Constructor(IChartDataProvider chart);

        // -(ChartHighlight * _Nullable)getHighlightWithX:(CGFloat)x y:(CGFloat)y __attribute__((warn_unused_result("")));
        [Export("getHighlightWithX:y:")]
        [return: NullAllowed]
        ChartHighlight GetHighlightWithX(nfloat x, nfloat y);

        // -(CGPoint)getValsForTouchWithX:(CGFloat)x y:(CGFloat)y __attribute__((warn_unused_result("")));
        [Export("getValsForTouchWithX:y:")]
        CGPoint GetValsForTouchWithX(nfloat x, nfloat y);

        // -(ChartHighlight * _Nullable)getHighlightWithXValue:(double)xVal x:(CGFloat)x y:(CGFloat)y __attribute__((warn_unused_result("")));
        [Export("getHighlightWithXValue:x:y:")]
        [return: NullAllowed]
        ChartHighlight GetHighlightWithXValue(double xVal, nfloat x, nfloat y);

        // -(NSArray<ChartHighlight *> * _Nonnull)getHighlightsWithXValue:(double)xValue x:(CGFloat)x y:(CGFloat)y __attribute__((warn_unused_result("")));
        [Export("getHighlightsWithXValue:x:y:")]
        ChartHighlight[] GetHighlightsWithXValue(double xValue, nfloat x, nfloat y);
    }

    // @interface BarChartHighlighter : ChartHighlighter
    [BaseType(typeof(ChartHighlighter))]
    interface BarChartHighlighter
    {
        // -(ChartHighlight * _Nullable)getHighlightWithX:(CGFloat)x y:(CGFloat)y __attribute__((warn_unused_result("")));
        [Export("getHighlightWithX:y:")]
        [return: NullAllowed]
        ChartHighlight GetHighlightWithX(nfloat x, nfloat y);

        // -(ChartHighlight * _Nullable)getStackedHighlightWithHigh:(ChartHighlight * _Nonnull)high set:(id<BarChartDataSetProtocol> _Nonnull)set xValue:(double)xValue yValue:(double)yValue __attribute__((warn_unused_result("")));
        [Export("getStackedHighlightWithHigh:set:xValue:yValue:")]
        [return: NullAllowed]
        ChartHighlight GetStackedHighlightWithHigh(ChartHighlight high, IBarChartDataSetProtocol set, double xValue, double yValue);

        // -(NSInteger)getClosestStackIndexWithRanges:(NSArray<ChartRange *> * _Nullable)ranges value:(double)value __attribute__((warn_unused_result("")));
        [Export("getClosestStackIndexWithRanges:value:")]
        nint GetClosestStackIndexWithRanges([NullAllowed] ChartRange[] ranges, double value);

        // -(instancetype _Nonnull)initWithChart:(id<ChartDataProvider> _Nonnull)chart __attribute__((objc_designated_initializer));
        [Export("initWithChart:")]
        [DesignatedInitializer]
        NativeHandle Constructor(IChartDataProvider chart);
    }

    // @interface BubbleChartData : BarLineScatterCandleBubbleChartData
    [BaseType(typeof(BarLineScatterCandleBubbleChartData), Name = "_TtC8DGCharts15BubbleChartData")]
    interface BubbleChartData
    {
        // -(instancetype _Nonnull)initWithDataSets:(NSArray<id<ChartDataSetProtocol>> * _Nonnull)dataSets __attribute__((objc_designated_initializer));
        [Export("initWithDataSets:")]
        [DesignatedInitializer]
        NativeHandle Constructor(IChartDataSetProtocol[] dataSets);

        // -(void)setHighlightCircleWidth:(CGFloat)width;
        [Export("setHighlightCircleWidth:")]
        void SetHighlightCircleWidth(nfloat width);
    }

    // @interface BubbleChartDataEntry : ChartDataEntry
    [BaseType(typeof(ChartDataEntry), Name = "_TtC8DGCharts20BubbleChartDataEntry")]
    interface BubbleChartDataEntry
    {
        // @property (nonatomic) CGFloat size;
        [Export("size")]
        nfloat Size { get; set; }

        // -(instancetype _Nonnull)initWithX:(double)x y:(double)y size:(CGFloat)size __attribute__((objc_designated_initializer));
        [Export("initWithX:y:size:")]
        [DesignatedInitializer]
        NativeHandle Constructor(double x, double y, nfloat size);

        // -(instancetype _Nonnull)initWithX:(double)x y:(double)y size:(CGFloat)size data:(id _Nullable)data;
        [Export("initWithX:y:size:data:")]
        NativeHandle Constructor(double x, double y, nfloat size, [NullAllowed] NSObject data);

        // -(instancetype _Nonnull)initWithX:(double)x y:(double)y size:(CGFloat)size icon:(UIImage * _Nullable)icon;
        [Export("initWithX:y:size:icon:")]
        NativeHandle Constructor(double x, double y, nfloat size, [NullAllowed] UIImage icon);

        // -(instancetype _Nonnull)initWithX:(double)x y:(double)y size:(CGFloat)size icon:(UIImage * _Nullable)icon data:(id _Nullable)data;
        [Export("initWithX:y:size:icon:data:")]
        NativeHandle Constructor(double x, double y, nfloat size, [NullAllowed] UIImage icon, [NullAllowed] NSObject data);
    }

    interface IBubbleChartDataProvider { }

    // @protocol BubbleChartDataProvider <BarLineScatterCandleBubbleChartDataProvider>
    [Protocol(Name = "_TtP8DGCharts23BubbleChartDataProvider_"), Model]
    [BaseType(typeof(NSObject))]
    interface BubbleChartDataProvider : BarLineScatterCandleBubbleChartDataProvider
    {
        // @required @property (readonly, nonatomic, strong) BubbleChartData * _Nullable bubbleData;
        [Abstract]
        [NullAllowed, Export("bubbleData", ArgumentSemantic.Strong)]
        BubbleChartData BubbleData { get; set; }
    }

    interface IBubbleChartDataSetProtocol { }

    // @protocol BubbleChartDataSetProtocol <BarLineScatterCandleBubbleChartDataSetProtocol>
    [Protocol(Name = "_TtP8DGCharts26BubbleChartDataSetProtocol_"), Model]
    [BaseType(typeof(NSObject))]
    interface BubbleChartDataSetProtocol : BarLineScatterCandleBubbleChartDataSetProtocol
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

    // @interface BubbleChartDataSet : BarLineScatterCandleBubbleChartDataSet <BubbleChartDataSetProtocol>
    [BaseType(typeof(BarLineScatterCandleBubbleChartDataSet), Name = "_TtC8DGCharts18BubbleChartDataSet")]
    interface BubbleChartDataSet : BubbleChartDataSetProtocol
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

        // @property (nonatomic) CGFloat highlightCircleWidth;
        [Export("highlightCircleWidth")]
        nfloat HighlightCircleWidth { get; set; }

        // -(instancetype _Nonnull)initWithEntries:(NSArray<ChartDataEntry *> * _Nonnull)entries label:(NSString * _Nonnull)label __attribute__((objc_designated_initializer));
        [Export("initWithEntries:label:")]
        [DesignatedInitializer]
        NativeHandle Constructor(ChartDataEntry[] entries, string label);
    }

    // @interface BubbleChartRenderer : BarLineScatterCandleBubbleChartRenderer
    [BaseType(typeof(BarLineScatterCandleBubbleChartRenderer), Name = "_TtC8DGCharts19BubbleChartRenderer")]
    interface BubbleChartRenderer
    {
        // @property (nonatomic, weak) id<BubbleChartDataProvider> _Nullable dataProvider;
        [NullAllowed, Export("dataProvider", ArgumentSemantic.Weak)]
        IBubbleChartDataProvider DataProvider { get; set; }

        // -(instancetype _Nonnull)initWithDataProvider:(id<BubbleChartDataProvider> _Nonnull)dataProvider animator:(ChartAnimator * _Nonnull)animator viewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler __attribute__((objc_designated_initializer));
        [Export("initWithDataProvider:animator:viewPortHandler:")]
        [DesignatedInitializer]
        NativeHandle Constructor(IBubbleChartDataProvider dataProvider, ChartAnimator animator, ChartViewPortHandler viewPortHandler);

        // -(void)drawDataWithContext:(CGContextRef _Nonnull)context;
        [Export("drawDataWithContext:")]
        void DrawDataWithContext(CGContext context);

        // -(void)drawDataSetWithContext:(CGContextRef _Nonnull)context dataSet:(id<BubbleChartDataSetProtocol> _Nonnull)dataSet dataSetIndex:(NSInteger)dataSetIndex;
        [Export("drawDataSetWithContext:dataSet:dataSetIndex:")]
        void DrawDataSetWithContext(CGContext context, IBubbleChartDataSetProtocol dataSet, nint dataSetIndex);

        // -(void)drawValuesWithContext:(CGContextRef _Nonnull)context;
        [Export("drawValuesWithContext:")]
        void DrawValuesWithContext(CGContext context);

        // -(void)drawExtrasWithContext:(CGContextRef _Nonnull)context;
        [Export("drawExtrasWithContext:")]
        void DrawExtrasWithContext(CGContext context);

        // -(void)drawHighlightedWithContext:(CGContextRef _Nonnull)context indices:(NSArray<ChartHighlight *> * _Nonnull)indices;
        [Export("drawHighlightedWithContext:indices:")]
        void DrawHighlightedWithContext(CGContext context, ChartHighlight[] indices);
    }

    // @interface BubbleChartView : BarLineChartViewBase <BubbleChartDataProvider>
    [BaseType(typeof(BarLineChartViewBase), Name = "_TtC8DGCharts15BubbleChartView")]
    interface BubbleChartView : BubbleChartDataProvider
    {
        // @property (readonly, nonatomic, strong) BubbleChartData * _Nullable bubbleData;
        [NullAllowed, Export("bubbleData", ArgumentSemantic.Strong)]
        BubbleChartData BubbleData { get; }

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        NativeHandle Constructor(CGRect frame);
    }

    // @interface CandleChartData : BarLineScatterCandleBubbleChartData
    [BaseType(typeof(BarLineScatterCandleBubbleChartData), Name = "_TtC8DGCharts15CandleChartData")]
    interface CandleChartData
    {
        // -(instancetype _Nonnull)initWithDataSets:(NSArray<id<ChartDataSetProtocol>> * _Nonnull)dataSets __attribute__((objc_designated_initializer));
        [Export("initWithDataSets:")]
        [DesignatedInitializer]
        NativeHandle Constructor(IChartDataSetProtocol[] dataSets);
    }

    // @interface CandleChartDataEntry : ChartDataEntry
    [BaseType(typeof(ChartDataEntry), Name = "_TtC8DGCharts20CandleChartDataEntry")]
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
        NativeHandle Constructor(double x, double shadowH, double shadowL, double open, double close);

        // -(instancetype _Nonnull)initWithX:(double)x shadowH:(double)shadowH shadowL:(double)shadowL open:(double)open close:(double)close icon:(UIImage * _Nullable)icon;
        [Export("initWithX:shadowH:shadowL:open:close:icon:")]
        NativeHandle Constructor(double x, double shadowH, double shadowL, double open, double close, [NullAllowed] UIImage icon);

        // -(instancetype _Nonnull)initWithX:(double)x shadowH:(double)shadowH shadowL:(double)shadowL open:(double)open close:(double)close data:(id _Nullable)data;
        [Export("initWithX:shadowH:shadowL:open:close:data:")]
        NativeHandle Constructor(double x, double shadowH, double shadowL, double open, double close, [NullAllowed] NSObject data);

        // -(instancetype _Nonnull)initWithX:(double)x shadowH:(double)shadowH shadowL:(double)shadowL open:(double)open close:(double)close icon:(UIImage * _Nullable)icon data:(id _Nullable)data;
        [Export("initWithX:shadowH:shadowL:open:close:icon:data:")]
        NativeHandle Constructor(double x, double shadowH, double shadowL, double open, double close, [NullAllowed] UIImage icon, [NullAllowed] NSObject data);

        // @property (readonly, nonatomic) double shadowRange;
        [Export("shadowRange")]
        double ShadowRange { get; }

        // @property (readonly, nonatomic) double bodyRange;
        [Export("bodyRange")]
        double BodyRange { get; }

        // @property (nonatomic) double y;
        [Export("y")]
        double Y { get; set; }
    }

    interface ICandleChartDataProvider { }

    // @protocol CandleChartDataProvider <BarLineScatterCandleBubbleChartDataProvider>
    [Protocol(Name = "_TtP8DGCharts23CandleChartDataProvider_"), Model]
    [BaseType(typeof(NSObject))]
    interface CandleChartDataProvider : BarLineScatterCandleBubbleChartDataProvider
    {
        // @required @property (readonly, nonatomic, strong) CandleChartData * _Nullable candleData;
        [Abstract]
        [NullAllowed, Export("candleData", ArgumentSemantic.Strong)]
        CandleChartData CandleData { get; set; }
    }

    interface ILineScatterCandleRadarChartDataSetProtocol { }

    // @protocol LineScatterCandleRadarChartDataSetProtocol <BarLineScatterCandleBubbleChartDataSetProtocol>
    [Protocol(Name = "_TtP8DGCharts42LineScatterCandleRadarChartDataSetProtocol_"), Model]
    [BaseType(typeof(NSObject))]
    interface LineScatterCandleRadarChartDataSetProtocol : BarLineScatterCandleBubbleChartDataSetProtocol
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

    interface ICandleChartDataSetProtocol { }

    // @protocol CandleChartDataSetProtocol <LineScatterCandleRadarChartDataSetProtocol>
    [Protocol(Name = "_TtP8DGCharts26CandleChartDataSetProtocol_"), Model]
    [BaseType(typeof(NSObject))]
    interface CandleChartDataSetProtocol : LineScatterCandleRadarChartDataSetProtocol
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

    // @interface LineScatterCandleRadarChartDataSet : BarLineScatterCandleBubbleChartDataSet <LineScatterCandleRadarChartDataSetProtocol>
    [BaseType(typeof(BarLineScatterCandleBubbleChartDataSet), Name = "_TtC8DGCharts34LineScatterCandleRadarChartDataSet")]
    interface LineScatterCandleRadarChartDataSet : LineScatterCandleRadarChartDataSetProtocol
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

        // -(instancetype _Nonnull)initWithEntries:(NSArray<ChartDataEntry *> * _Nonnull)entries label:(NSString * _Nonnull)label __attribute__((objc_designated_initializer));
        [Export("initWithEntries:label:")]
        [DesignatedInitializer]
        NativeHandle Constructor(ChartDataEntry[] entries, string label);
    }

    // @interface CandleChartDataSet : LineScatterCandleRadarChartDataSet <CandleChartDataSetProtocol>
    [BaseType(typeof(LineScatterCandleRadarChartDataSet), Name = "_TtC8DGCharts18CandleChartDataSet")]
    interface CandleChartDataSet : CandleChartDataSetProtocol
    {
        // -(instancetype _Nonnull)initWithEntries:(NSArray<ChartDataEntry *> * _Nonnull)entries label:(NSString * _Nonnull)label __attribute__((objc_designated_initializer));
        [Export("initWithEntries:label:")]
        [DesignatedInitializer]
        NativeHandle Constructor(ChartDataEntry[] entries, string label);

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
        // -(void)drawHighlightLinesWithContext:(CGContextRef _Nonnull)context point:(CGPoint)point set:(id<LineScatterCandleRadarChartDataSetProtocol> _Nonnull)set;
        [Export("drawHighlightLinesWithContext:point:set:")]
        void DrawHighlightLinesWithContext(CGContext context, CGPoint point, ILineScatterCandleRadarChartDataSetProtocol set);
    }

    // @interface CandleStickChartRenderer : LineScatterCandleRadarChartRenderer
    [BaseType(typeof(LineScatterCandleRadarChartRenderer), Name = "_TtC8DGCharts24CandleStickChartRenderer")]
    interface CandleStickChartRenderer
    {
        // @property (nonatomic, weak) id<CandleChartDataProvider> _Nullable dataProvider;
        [NullAllowed, Export("dataProvider", ArgumentSemantic.Weak)]
        ICandleChartDataProvider DataProvider { get; set; }

        // -(instancetype _Nonnull)initWithDataProvider:(id<CandleChartDataProvider> _Nonnull)dataProvider animator:(ChartAnimator * _Nonnull)animator viewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler __attribute__((objc_designated_initializer));
        [Export("initWithDataProvider:animator:viewPortHandler:")]
        [DesignatedInitializer]
        NativeHandle Constructor(ICandleChartDataProvider dataProvider, ChartAnimator animator, ChartViewPortHandler viewPortHandler);

        // -(void)drawDataWithContext:(CGContextRef _Nonnull)context;
        [Export("drawDataWithContext:")]
        void DrawDataWithContext(CGContext context);

        // -(void)drawDataSetWithContext:(CGContextRef _Nonnull)context dataSet:(id<CandleChartDataSetProtocol> _Nonnull)dataSet;
        [Export("drawDataSetWithContext:dataSet:")]
        void DrawDataSetWithContext(CGContext context, ICandleChartDataSetProtocol dataSet);

        // -(void)drawValuesWithContext:(CGContextRef _Nonnull)context;
        [Export("drawValuesWithContext:")]
        void DrawValuesWithContext(CGContext context);

        // -(void)drawExtrasWithContext:(CGContextRef _Nonnull)context;
        [Export("drawExtrasWithContext:")]
        void DrawExtrasWithContext(CGContext context);

        // -(void)drawHighlightedWithContext:(CGContextRef _Nonnull)context indices:(NSArray<ChartHighlight *> * _Nonnull)indices;
        [Export("drawHighlightedWithContext:indices:")]
        void DrawHighlightedWithContext(CGContext context, ChartHighlight[] indices);
    }

    // @interface CandleStickChartView : BarLineChartViewBase <CandleChartDataProvider>
    [BaseType(typeof(BarLineChartViewBase), Name = "_TtC8DGCharts20CandleStickChartView")]
    interface CandleStickChartView : CandleChartDataProvider
    {
        // @property (readonly, nonatomic, strong) CandleChartData * _Nullable candleData;
        [NullAllowed, Export("candleData", ArgumentSemantic.Strong)]
        CandleChartData CandleData { get; }

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        NativeHandle Constructor(CGRect frame);
    }

    // @interface ChartColorTemplates : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC8DGCharts19ChartColorTemplates")]
    interface ChartColorTemplates
    {
        // +(NSArray<UIColor *> * _Nonnull)liberty __attribute__((warn_unused_result("")));
        [Static]
        [Export("liberty")]
        UIColor[] Liberty { get; }

        // +(NSArray<UIColor *> * _Nonnull)joyful __attribute__((warn_unused_result("")));
        [Static]
        [Export("joyful")]
        UIColor[] Joyful { get; }

        // +(NSArray<UIColor *> * _Nonnull)pastel __attribute__((warn_unused_result("")));
        [Static]
        [Export("pastel")]
        UIColor[] Pastel { get; }

        // +(NSArray<UIColor *> * _Nonnull)colorful __attribute__((warn_unused_result("")));
        [Static]
        [Export("colorful")]
        UIColor[] Colorful { get; }

        // +(NSArray<UIColor *> * _Nonnull)vordiplom __attribute__((warn_unused_result("")));
        [Static]
        [Export("vordiplom")]
        UIColor[] Vordiplom { get; }

        // +(NSArray<UIColor *> * _Nonnull)material __attribute__((warn_unused_result("")));
        [Static]
        [Export("material")]
        UIColor[] Material { get; }

        // +(UIColor * _Nonnull)colorFromString:(NSString * _Nonnull)colorString __attribute__((warn_unused_result("")));
        [Static]
        [Export("colorFromString:")]
        UIColor ColorFromString(string colorString);
    }

    // @interface ChartLimitLine : ChartComponentBase
    [BaseType(typeof(ChartComponentBase), Name = "_TtC8DGCharts14ChartLimitLine")]
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

        // @property (nonatomic) CGFloat labelRotationAngle;
        [Export("labelRotationAngle")]
        nfloat LabelRotationAngle { get; set; }

        // -(instancetype _Nonnull)initWithLimit:(double)limit __attribute__((objc_designated_initializer));
        [Export("initWithLimit:")]
        [DesignatedInitializer]
        NativeHandle Constructor(double limit);

        // -(instancetype _Nonnull)initWithLimit:(double)limit label:(NSString * _Nonnull)label __attribute__((objc_designated_initializer));
        [Export("initWithLimit:label:")]
        [DesignatedInitializer]
        NativeHandle Constructor(double limit, string label);

        // @property (nonatomic) CGFloat lineWidth;
        [Export("lineWidth")]
        nfloat LineWidth { get; set; }
    }

    interface IChartViewDelegate { }

    // @protocol ChartViewDelegate
    [Protocol(Name = "_TtP8DGCharts17ChartViewDelegate_"), Model]
    [BaseType(typeof(NSObject))]
    interface ChartViewDelegate
    {
        // @optional -(void)chartValueSelected:(ChartViewBase * _Nonnull)chartView entry:(ChartDataEntry * _Nonnull)entry highlight:(ChartHighlight * _Nonnull)highlight;
        [Export("chartValueSelected:entry:highlight:")]
        void ChartValueSelected(ChartViewBase chartView, ChartDataEntry entry, ChartHighlight highlight);

        // @optional -(void)chartViewDidEndPanning:(ChartViewBase * _Nonnull)chartView;
        [Export("chartViewDidEndPanning:")]
        void ChartViewDidEndPanning(ChartViewBase chartView);

        // @optional -(void)chartValueNothingSelected:(ChartViewBase * _Nonnull)chartView;
        [Export("chartValueNothingSelected:")]
        void ChartValueNothingSelected(ChartViewBase chartView);

        // @optional -(void)chartScaled:(ChartViewBase * _Nonnull)chartView scaleX:(CGFloat)scaleX scaleY:(CGFloat)scaleY;
        [Export("chartScaled:scaleX:scaleY:")]
        void ChartScaled(ChartViewBase chartView, nfloat scaleX, nfloat scaleY);

        // @optional -(void)chartTranslated:(ChartViewBase * _Nonnull)chartView dX:(CGFloat)dX dY:(CGFloat)dY;
        [Export("chartTranslated:dX:dY:")]
        void ChartTranslated(ChartViewBase chartView, nfloat dX, nfloat dY);

        // @optional -(void)chartView:(ChartViewBase * _Nonnull)chartView animatorDidStop:(ChartAnimator * _Nonnull)animator;
        [Export("chartView:animatorDidStop:")]
        void ChartViewAnimatorDidStop(ChartViewBase chartView, ChartAnimator animator);
    }

    interface IShapeRenderer { }

    // @protocol ShapeRenderer
    [Protocol(Name = "_TtP8DGCharts13ShapeRenderer_"), Model]
    [BaseType(typeof(NSObject))]
    interface ShapeRenderer
    {
        // @required -(void)renderShapeWithContext:(CGContextRef _Nonnull)context dataSet:(id<ScatterChartDataSetProtocol> _Nonnull)dataSet viewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler point:(CGPoint)point color:(UIColor * _Nonnull)color;
        [Abstract]
        [Export("renderShapeWithContext:dataSet:viewPortHandler:point:color:")]
        void RenderShapeWithContext(CGContext context, IScatterChartDataSetProtocol dataSet, ChartViewPortHandler viewPortHandler, CGPoint point, UIColor color);
    }

    // @interface ChevronDownShapeRenderer : NSObject <ShapeRenderer>
    [BaseType(typeof(NSObject), Name = "_TtC8DGCharts24ChevronDownShapeRenderer")]
    interface ChevronDownShapeRenderer : ShapeRenderer
    {
        // -(void)renderShapeWithContext:(CGContextRef _Nonnull)context dataSet:(id<ScatterChartDataSetProtocol> _Nonnull)dataSet viewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler point:(CGPoint)point color:(UIColor * _Nonnull)color;
        [Export("renderShapeWithContext:dataSet:viewPortHandler:point:color:")]
        void RenderShapeWithContext(CGContext context, IScatterChartDataSetProtocol dataSet, ChartViewPortHandler viewPortHandler, CGPoint point, UIColor color);
    }

    // @interface ChevronUpShapeRenderer : NSObject <ShapeRenderer>
    [BaseType(typeof(NSObject), Name = "_TtC8DGCharts22ChevronUpShapeRenderer")]
    interface ChevronUpShapeRenderer : ShapeRenderer
    {
        // -(void)renderShapeWithContext:(CGContextRef _Nonnull)context dataSet:(id<ScatterChartDataSetProtocol> _Nonnull)dataSet viewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler point:(CGPoint)point color:(UIColor * _Nonnull)color;
        [Export("renderShapeWithContext:dataSet:viewPortHandler:point:color:")]
        void RenderShapeWithContext(CGContext context, IScatterChartDataSetProtocol dataSet, ChartViewPortHandler viewPortHandler, CGPoint point, UIColor color);
    }

    // @interface CircleShapeRenderer : NSObject <ShapeRenderer>
    [BaseType(typeof(NSObject), Name = "_TtC8DGCharts19CircleShapeRenderer")]
    interface CircleShapeRenderer : ShapeRenderer
    {
        // -(void)renderShapeWithContext:(CGContextRef _Nonnull)context dataSet:(id<ScatterChartDataSetProtocol> _Nonnull)dataSet viewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler point:(CGPoint)point color:(UIColor * _Nonnull)color;
        [Export("renderShapeWithContext:dataSet:viewPortHandler:point:color:")]
        void RenderShapeWithContext(CGContext context, IScatterChartDataSetProtocol dataSet, ChartViewPortHandler viewPortHandler, CGPoint point, UIColor color);
    }

    interface IChartFill { }

    // @protocol ChartFill
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface ChartFill
    {
        // @required -(void)fillPathWithContext:(CGContextRef _Nonnull)context rect:(CGRect)rect;
        [Abstract]
        [Export("fillPathWithContext:rect:")]
        void FillPathWithContext(CGContext context, CGRect rect);
    }

    // @interface ChartColorFill : NSObject <ChartFill>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ChartColorFill : ChartFill
    {
        // @property (readonly, nonatomic) CGColorRef _Nonnull color;
        [Export("color")]
        CGColor Color { get; }

        // -(instancetype _Nonnull)initWithCgColor:(CGColorRef _Nonnull)cgColor __attribute__((objc_designated_initializer));
        [Export("initWithCgColor:")]
        [DesignatedInitializer]
        NativeHandle Constructor(CGColor cgColor);

        // -(instancetype _Nonnull)initWithColor:(UIColor * _Nonnull)color;
        [Export("initWithColor:")]
        NativeHandle Constructor(UIColor color);

        // -(void)fillPathWithContext:(CGContextRef _Nonnull)context rect:(CGRect)rect;
        [Export("fillPathWithContext:rect:")]
        void FillPathWithContext(CGContext context, CGRect rect);
    }

    // @interface CombinedChartData : BarLineScatterCandleBubbleChartData
    [BaseType(typeof(BarLineScatterCandleBubbleChartData), Name = "_TtC8DGCharts17CombinedChartData")]
    interface CombinedChartData
    {
        // -(instancetype _Nonnull)initWithDataSets:(NSArray<id<ChartDataSetProtocol>> * _Nonnull)dataSets __attribute__((objc_designated_initializer));
        [Export("initWithDataSets:")]
        [DesignatedInitializer]
        NativeHandle Constructor(IChartDataSetProtocol[] dataSets);

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

        // -(ChartData * _Nonnull)dataByIndex:(NSInteger)index __attribute__((warn_unused_result("")));
        [Export("dataByIndex:")]
        ChartData DataByIndex(nint index);

        // -(id<ChartDataSetProtocol> _Nullable)removeDataSet:(id<ChartDataSetProtocol> _Nonnull)dataSet __attribute__((warn_unused_result("")));
        [Export("removeDataSet:")]
        [return: NullAllowed]
        IChartDataSetProtocol RemoveDataSet(IChartDataSetProtocol dataSet);

        // -(BOOL)removeEntry:(ChartDataEntry * _Nonnull)entry dataSetIndex:(NSInteger)dataSetIndex __attribute__((warn_unused_result("")));
        [Export("removeEntry:dataSetIndex:")]
        bool RemoveEntry(ChartDataEntry entry, nint dataSetIndex);

        // -(BOOL)removeEntryWithXValue:(double)xValue dataSetIndex:(NSInteger)dataSetIndex __attribute__((warn_unused_result("")));
        [Export("removeEntryWithXValue:dataSetIndex:")]
        bool RemoveEntryWithXValue(double xValue, nint dataSetIndex);

        // -(void)notifyDataChanged;
        [Export("notifyDataChanged")]
        void NotifyDataChanged();

        // -(ChartDataEntry * _Nullable)entryFor:(ChartHighlight * _Nonnull)highlight __attribute__((warn_unused_result("")));
        [Export("entryFor:")]
        [return: NullAllowed]
        ChartDataEntry EntryFor(ChartHighlight highlight);

        // -(id<ChartDataSetProtocol> _Null_unspecified)getDataSetByHighlight:(ChartHighlight * _Nonnull)highlight __attribute__((warn_unused_result("")));
        [Export("getDataSetByHighlight:")]
        IChartDataSetProtocol GetDataSetByHighlight(ChartHighlight highlight);

        // -(void)addDataSet:(id<ChartDataSetProtocol> _Nonnull)newElement;
        [Export("addDataSet:")]
        void AddDataSet(IChartDataSetProtocol newElement);

        // -(id<ChartDataSetProtocol> _Nonnull)removeDataSetByIndex:(NSInteger)i __attribute__((warn_unused_result("")));
        [Export("removeDataSetByIndex:")]
        IChartDataSetProtocol RemoveDataSetByIndex(nint i);
    }

    interface IScatterChartDataProvider { }

    // @protocol ScatterChartDataProvider <BarLineScatterCandleBubbleChartDataProvider>
    [Protocol(Name = "_TtP8DGCharts24ScatterChartDataProvider_"), Model]
    [BaseType(typeof(NSObject))]
    interface ScatterChartDataProvider : BarLineScatterCandleBubbleChartDataProvider
    {
        // @required @property (readonly, nonatomic, strong) ScatterChartData * _Nullable scatterData;
        [Abstract]
        [NullAllowed, Export("scatterData", ArgumentSemantic.Strong)]
        ScatterChartData ScatterData { get; set; }
    }

    interface ILineChartDataProvider { }

    // @protocol LineChartDataProvider <BarLineScatterCandleBubbleChartDataProvider>
    [Protocol(Name = "_TtP8DGCharts21LineChartDataProvider_"), Model]
    [BaseType(typeof(NSObject))]
    interface LineChartDataProvider : BarLineScatterCandleBubbleChartDataProvider
    {
        // @required @property (readonly, nonatomic, strong) LineChartData * _Nullable lineData;
        [Abstract]
        [NullAllowed, Export("lineData", ArgumentSemantic.Strong)]
        LineChartData LineData { get; set; }

        // @required -(ChartYAxis * _Nonnull)getAxis:(enum AxisDependency)axis __attribute__((warn_unused_result("")));
        [Abstract]
        [Export("getAxis:")]
        ChartYAxis GetAxis(AxisDependency axis);
    }

    interface ICombinedChartDataProvider { }

    // @protocol CombinedChartDataProvider <BarChartDataProvider, BubbleChartDataProvider, CandleChartDataProvider, LineChartDataProvider, ScatterChartDataProvider>
    [Protocol(Name = "_TtP8DGCharts25CombinedChartDataProvider_"), Model]
    [BaseType(typeof(NSObject))]
    interface CombinedChartDataProvider : BarChartDataProvider, BubbleChartDataProvider, CandleChartDataProvider, LineChartDataProvider, ScatterChartDataProvider
    {
        // @required @property (readonly, nonatomic, strong) CombinedChartData * _Nullable combinedData;
        [Abstract]
        [NullAllowed, Export("combinedData", ArgumentSemantic.Strong)]
        CombinedChartData CombinedData { get; }
    }

    // @interface CombinedChartRenderer : NSObject <ChartDataRenderer>
    [BaseType(typeof(NSObject), Name = "_TtC8DGCharts21CombinedChartRenderer")]
    [DisableDefaultCtor]
    interface CombinedChartRenderer : ChartDataRenderer
    {
        // @property (readonly, nonatomic, strong) ChartViewPortHandler * _Nonnull viewPortHandler;
        [Export("viewPortHandler", ArgumentSemantic.Strong)]
        ChartViewPortHandler ViewPortHandler { get; }

        // @property (copy, nonatomic) NSArray<NSUIAccessibilityElement *> * _Nonnull accessibleChartElements;
        [Export("accessibleChartElements", ArgumentSemantic.Copy)]
        NSUIAccessibilityElement[] AccessibleChartElements { get; set; }

        // @property (readonly, nonatomic, strong) ChartAnimator * _Nonnull animator;
        [Export("animator", ArgumentSemantic.Strong)]
        ChartAnimator Animator { get; }

        // @property (nonatomic, weak) CombinedChartView * _Nullable chart;
        [NullAllowed, Export("chart", ArgumentSemantic.Weak)]
        CombinedChartView Chart { get; set; }

        // @property (nonatomic) BOOL drawValueAboveBarEnabled;
        [Export("drawValueAboveBarEnabled")]
        bool DrawValueAboveBarEnabled { get; set; }

        // @property (nonatomic) BOOL drawBarShadowEnabled;
        [Export("drawBarShadowEnabled")]
        bool DrawBarShadowEnabled { get; set; }

        // -(instancetype _Nonnull)initWithChart:(CombinedChartView * _Nonnull)chart animator:(ChartAnimator * _Nonnull)animator viewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler __attribute__((objc_designated_initializer));
        [Export("initWithChart:animator:viewPortHandler:")]
        [DesignatedInitializer]
        NativeHandle Constructor(CombinedChartView chart, ChartAnimator animator, ChartViewPortHandler viewPortHandler);

        // -(void)initBuffers __attribute__((objc_method_family("none")));
        [Export("initBuffers")]
        void InitBuffers();

        // -(void)drawDataWithContext:(CGContextRef _Nonnull)context;
        [Export("drawDataWithContext:")]
        void DrawDataWithContext(CGContext context);

        // -(void)drawValuesWithContext:(CGContextRef _Nonnull)context;
        [Export("drawValuesWithContext:")]
        void DrawValuesWithContext(CGContext context);

        // -(void)drawExtrasWithContext:(CGContextRef _Nonnull)context;
        [Export("drawExtrasWithContext:")]
        void DrawExtrasWithContext(CGContext context);

        // -(void)drawHighlightedWithContext:(CGContextRef _Nonnull)context indices:(NSArray<ChartHighlight *> * _Nonnull)indices;
        [Export("drawHighlightedWithContext:indices:")]
        void DrawHighlightedWithContext(CGContext context, ChartHighlight[] indices);

        // -(BOOL)isDrawingValuesAllowedWithDataProvider:(id<ChartDataProvider> _Nullable)dataProvider __attribute__((warn_unused_result("")));
        [Export("isDrawingValuesAllowedWithDataProvider:")]
        bool IsDrawingValuesAllowedWithDataProvider([NullAllowed] IChartDataProvider dataProvider);

        // @property (copy, nonatomic) NSArray<id<ChartDataRenderer>> * _Nonnull subRenderers;
        [Export("subRenderers", ArgumentSemantic.Copy)]
        IChartDataRenderer[] SubRenderers { get; set; }

        // @property (readonly, nonatomic) BOOL isDrawValueAboveBarEnabled;
        [Export("isDrawValueAboveBarEnabled")]
        bool IsDrawValueAboveBarEnabled { get; }

        // @property (readonly, nonatomic) BOOL isDrawBarShadowEnabled;
        [Export("isDrawBarShadowEnabled")]
        bool IsDrawBarShadowEnabled { get; }

        // -(NSUIAccessibilityElement * _Nonnull)createAccessibleHeaderUsingChart:(ChartViewBase * _Nonnull)chart andData:(ChartData * _Nonnull)data withDefaultDescription:(NSString * _Nonnull)defaultDescription __attribute__((warn_unused_result("")));
        [Export("createAccessibleHeaderUsingChart:andData:withDefaultDescription:")]
        NSUIAccessibilityElement CreateAccessibleHeaderUsingChart(ChartViewBase chart, ChartData data, string defaultDescription);
    }

    // @interface CombinedChartView : BarLineChartViewBase <CombinedChartDataProvider>
    [BaseType(typeof(BarLineChartViewBase), Name = "_TtC8DGCharts17CombinedChartView")]
    interface CombinedChartView : CombinedChartDataProvider
    {
        // @property (nonatomic, strong) ChartData * _Nullable data;
        [NullAllowed, Export("data", ArgumentSemantic.Strong)]
        ChartData Data { get; set; }

        // @property (nonatomic, strong) id<ChartFillFormatter> _Nonnull fillFormatter;
        [Export("fillFormatter", ArgumentSemantic.Strong)]
        IChartFillFormatter FillFormatter { get; set; }

        // -(ChartHighlight * _Nullable)getHighlightByTouchPoint:(CGPoint)pt __attribute__((warn_unused_result("")));
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
        NativeHandle Constructor(CGRect frame);
    }

    // @interface CombinedChartHighlighter : ChartHighlighter
    [BaseType(typeof(ChartHighlighter))]
    interface CombinedChartHighlighter
    {
        // -(instancetype _Nonnull)initWithChart:(id<CombinedChartDataProvider> _Nonnull)chart barDataProvider:(id<BarChartDataProvider> _Nonnull)barDataProvider __attribute__((objc_designated_initializer));
        [Export("initWithChart:barDataProvider:")]
        [DesignatedInitializer]
        NativeHandle Constructor(ICombinedChartDataProvider chart, IBarChartDataProvider barDataProvider);

        // -(NSArray<ChartHighlight *> * _Nonnull)getHighlightsWithXValue:(double)xValue x:(CGFloat)x y:(CGFloat)y __attribute__((warn_unused_result("")));
        [Export("getHighlightsWithXValue:x:y:")]
        ChartHighlight[] GetHighlightsWithXValue(double xValue, nfloat x, nfloat y);
    }

    // @interface CrossShapeRenderer : NSObject <ShapeRenderer>
    [BaseType(typeof(NSObject), Name = "_TtC8DGCharts18CrossShapeRenderer")]
    interface CrossShapeRenderer : ShapeRenderer
    {
        // -(void)renderShapeWithContext:(CGContextRef _Nonnull)context dataSet:(id<ScatterChartDataSetProtocol> _Nonnull)dataSet viewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler point:(CGPoint)point color:(UIColor * _Nonnull)color;
        [Export("renderShapeWithContext:dataSet:viewPortHandler:point:color:")]
        void RenderShapeWithContext(CGContext context, IScatterChartDataSetProtocol dataSet, ChartViewPortHandler viewPortHandler, CGPoint point, UIColor color);
    }

    // @interface ChartDataApproximator : NSObject
    [BaseType(typeof(NSObject))]
    interface ChartDataApproximator
    {
        // +(NSArray<NSValue *> * _Nonnull)reduceWithDouglasPeuker:(NSArray<NSValue *> * _Nonnull)points tolerance:(CGFloat)tolerance __attribute__((warn_unused_result("")));
        [Static]
        [Export("reduceWithDouglasPeuker:tolerance:")]
        NSValue[] ReduceWithDouglasPeuker(NSValue[] points, nfloat tolerance);

        // +(NSArray<NSValue *> * _Nonnull)reduceWithDouglasPeukerN:(NSArray<NSValue *> * _Nonnull)points resultCount:(NSInteger)resultCount __attribute__((warn_unused_result("")));
        [Static]
        [Export("reduceWithDouglasPeukerN:resultCount:")]
        NSValue[] ReduceWithDouglasPeukerN(NSValue[] points, nint resultCount);
    }

    // @interface ChartDefaultAxisValueFormatter : NSObject <ChartAxisValueFormatter>
    [BaseType(typeof(NSObject))]
    interface ChartDefaultAxisValueFormatter : ChartAxisValueFormatter
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
        NativeHandle Constructor(NSNumberFormatter formatter);

        // -(instancetype _Nonnull)initWithDecimals:(NSInteger)decimals __attribute__((objc_designated_initializer));
        [Export("initWithDecimals:")]
        [DesignatedInitializer]
        NativeHandle Constructor(nint decimals);

        // -(instancetype _Nonnull)initWithBlock:(NSString * _Nonnull (^ _Nonnull)(double, ChartAxisBase * _Nullable))block __attribute__((objc_designated_initializer));
        [Export("initWithBlock:")]
        [DesignatedInitializer]
        NativeHandle Constructor(Func<double, ChartAxisBase, NSString> block);

        // +(ChartDefaultAxisValueFormatter * _Nullable)withBlock:(NSString * _Nonnull (^ _Nonnull)(double, ChartAxisBase * _Nullable))block __attribute__((warn_unused_result("")));
        [Static]
        [Export("withBlock:")]
        [return: NullAllowed]
        ChartDefaultAxisValueFormatter WithBlock(Func<double, ChartAxisBase, NSString> block);

        // -(NSString * _Nonnull)stringForValue:(double)value axis:(ChartAxisBase * _Nullable)axis __attribute__((warn_unused_result("")));
        [Export("stringForValue:axis:")]
        string StringForValue(double value, [NullAllowed] ChartAxisBase axis);
    }

    interface IChartFillFormatter { }

    // @protocol ChartFillFormatter
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface ChartFillFormatter
    {
        // @required -(CGFloat)getFillLinePositionWithDataSet:(id<LineChartDataSetProtocol> _Nonnull)dataSet dataProvider:(id<LineChartDataProvider> _Nonnull)dataProvider __attribute__((warn_unused_result("")));
        [Abstract]
        [Export("getFillLinePositionWithDataSet:dataProvider:")]
        nfloat GetFillLinePositionWithDataSet(ILineChartDataSetProtocol dataSet, ILineChartDataProvider dataProvider);
    }

    // @interface ChartDefaultFillFormatter : NSObject <ChartFillFormatter>
    [BaseType(typeof(NSObject))]
    interface ChartDefaultFillFormatter : ChartFillFormatter
    {
        // @property (copy, nonatomic) CGFloat (^ _Nullable)(id<LineChartDataSetProtocol> _Nonnull, id<LineChartDataProvider> _Nonnull) block;
        [NullAllowed, Export("block", ArgumentSemantic.Copy)]
        Func<ILineChartDataSetProtocol, ILineChartDataProvider, nfloat> Block { get; set; }

        // -(instancetype _Nonnull)initWithBlock:(CGFloat (^ _Nonnull)(id<LineChartDataSetProtocol> _Nonnull, id<LineChartDataProvider> _Nonnull))block __attribute__((objc_designated_initializer));
        [Export("initWithBlock:")]
        [DesignatedInitializer]
        NativeHandle Constructor(Func<ILineChartDataSetProtocol, ILineChartDataProvider, nfloat> block);

        // +(ChartDefaultFillFormatter * _Nullable)withBlock:(CGFloat (^ _Nonnull)(id<LineChartDataSetProtocol> _Nonnull, id<LineChartDataProvider> _Nonnull))block __attribute__((warn_unused_result("")));
        [Static]
        [Export("withBlock:")]
        [return: NullAllowed]
        ChartDefaultFillFormatter WithBlock(Func<ILineChartDataSetProtocol, ILineChartDataProvider, nfloat> block);

        // -(CGFloat)getFillLinePositionWithDataSet:(id<LineChartDataSetProtocol> _Nonnull)dataSet dataProvider:(id<LineChartDataProvider> _Nonnull)dataProvider __attribute__((warn_unused_result("")));
        [Export("getFillLinePositionWithDataSet:dataProvider:")]
        nfloat GetFillLinePositionWithDataSet(ILineChartDataSetProtocol dataSet, ILineChartDataProvider dataProvider);
    }

    interface IChartValueFormatter { }

    // @protocol ChartValueFormatter
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface ChartValueFormatter
    {
        // @required -(NSString * _Nonnull)stringForValue:(double)value entry:(ChartDataEntry * _Nonnull)entry dataSetIndex:(NSInteger)dataSetIndex viewPortHandler:(ChartViewPortHandler * _Nullable)viewPortHandler __attribute__((warn_unused_result("")));
        [Abstract]
        [Export("stringForValue:entry:dataSetIndex:viewPortHandler:")]
        string StringForValue(double value, ChartDataEntry entry, nint dataSetIndex, [NullAllowed] ChartViewPortHandler viewPortHandler);
    }

    // @interface ChartDefaultValueFormatter : NSObject <ChartValueFormatter>
    [BaseType(typeof(NSObject))]
    interface ChartDefaultValueFormatter : ChartValueFormatter
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
        NativeHandle Constructor(NSNumberFormatter formatter);

        // -(instancetype _Nonnull)initWithDecimals:(NSInteger)decimals __attribute__((objc_designated_initializer));
        [Export("initWithDecimals:")]
        [DesignatedInitializer]
        NativeHandle Constructor(nint decimals);

        // -(instancetype _Nonnull)initWithBlock:(NSString * _Nonnull (^ _Nonnull)(double, ChartDataEntry * _Nonnull, NSInteger, ChartViewPortHandler * _Nullable))block __attribute__((objc_designated_initializer));
        [Export("initWithBlock:")]
        [DesignatedInitializer]
        NativeHandle Constructor(Func<double, ChartDataEntry, nint, ChartViewPortHandler, NSString> block);

        // +(ChartDefaultValueFormatter * _Nonnull)withBlock:(NSString * _Nonnull (^ _Nonnull)(double, ChartDataEntry * _Nonnull, NSInteger, ChartViewPortHandler * _Nullable))block __attribute__((warn_unused_result(""))) __attribute__((deprecated("Use `init(block:)` instead.")));
        [Static]
        [Export("withBlock:")]
        ChartDefaultValueFormatter WithBlock(Func<double, ChartDataEntry, nint, ChartViewPortHandler, NSString> block);

        // -(NSString * _Nonnull)stringForValue:(double)value entry:(ChartDataEntry * _Nonnull)entry dataSetIndex:(NSInteger)dataSetIndex viewPortHandler:(ChartViewPortHandler * _Nullable)viewPortHandler __attribute__((warn_unused_result("")));
        [Export("stringForValue:entry:dataSetIndex:viewPortHandler:")]
        string StringForValue(double value, ChartDataEntry entry, nint dataSetIndex, [NullAllowed] ChartViewPortHandler viewPortHandler);
    }

    // @interface ChartDescription : ChartComponentBase
    [BaseType(typeof(ChartComponentBase))]
    interface ChartDescription
    {
        // @property (copy, nonatomic) NSString * _Nullable text;
        [NullAllowed, Export("text")]
        string Text { get; set; }

        // @property (nonatomic) NSTextAlignment textAlign;
        [Export("textAlign", ArgumentSemantic.Assign)]
        UITextAlignment TextAlign { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull font;
        [Export("font", ArgumentSemantic.Strong)]
        UIFont Font { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull textColor;
        [Export("textColor", ArgumentSemantic.Strong)]
        UIColor TextColor { get; set; }
    }

    // @interface ChartEmptyFill : NSObject <ChartFill>
    [BaseType(typeof(NSObject))]
    interface ChartEmptyFill : ChartFill
    {
        // -(void)fillPathWithContext:(CGContextRef _Nonnull)context rect:(CGRect)rect;
        [Export("fillPathWithContext:rect:")]
        void FillPathWithContext(CGContext context, CGRect rect);
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
        NativeHandle Constructor(double x, double y, nfloat xPx, nfloat yPx, nint dataIndex, nint dataSetIndex, nint stackIndex, AxisDependency axis);

        // -(instancetype _Nonnull)initWithX:(double)x y:(double)y xPx:(CGFloat)xPx yPx:(CGFloat)yPx dataSetIndex:(NSInteger)dataSetIndex stackIndex:(NSInteger)stackIndex axis:(enum AxisDependency)axis;
        [Export("initWithX:y:xPx:yPx:dataSetIndex:stackIndex:axis:")]
        NativeHandle Constructor(double x, double y, nfloat xPx, nfloat yPx, nint dataSetIndex, nint stackIndex, AxisDependency axis);

        // -(instancetype _Nonnull)initWithX:(double)x y:(double)y xPx:(CGFloat)xPx yPx:(CGFloat)yPx dataSetIndex:(NSInteger)dataSetIndex axis:(enum AxisDependency)axis __attribute__((objc_designated_initializer));
        [Export("initWithX:y:xPx:yPx:dataSetIndex:axis:")]
        [DesignatedInitializer]
        NativeHandle Constructor(double x, double y, nfloat xPx, nfloat yPx, nint dataSetIndex, AxisDependency axis);

        // -(instancetype _Nonnull)initWithX:(double)x y:(double)y dataSetIndex:(NSInteger)dataSetIndex dataIndex:(NSInteger)dataIndex __attribute__((objc_designated_initializer));
        [Export("initWithX:y:dataSetIndex:dataIndex:")]
        [DesignatedInitializer]
        NativeHandle Constructor(double x, double y, nint dataSetIndex, nint dataIndex);

        // -(instancetype _Nonnull)initWithX:(double)x dataSetIndex:(NSInteger)dataSetIndex stackIndex:(NSInteger)stackIndex;
        [Export("initWithX:dataSetIndex:stackIndex:")]
        NativeHandle Constructor(double x, nint dataSetIndex, nint stackIndex);

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
    }

    // @interface HorizontalBarChartRenderer : BarChartRenderer
    [BaseType(typeof(BarChartRenderer), Name = "_TtC8DGCharts26HorizontalBarChartRenderer")]
    interface HorizontalBarChartRenderer
    {
        // -(instancetype _Nonnull)initWithDataProvider:(id<BarChartDataProvider> _Nonnull)dataProvider animator:(ChartAnimator * _Nonnull)animator viewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler __attribute__((objc_designated_initializer));
        [Export("initWithDataProvider:animator:viewPortHandler:")]
        [DesignatedInitializer]
        NativeHandle Constructor(IBarChartDataProvider dataProvider, ChartAnimator animator, ChartViewPortHandler viewPortHandler);

        // -(void)initBuffers __attribute__((objc_method_family("none")));
        [Export("initBuffers")]
        void InitBuffers();

        // -(void)drawDataSetWithContext:(CGContextRef _Nonnull)context dataSet:(id<BarChartDataSetProtocol> _Nonnull)dataSet index:(NSInteger)index;
        [Export("drawDataSetWithContext:dataSet:index:")]
        void DrawDataSetWithContext(CGContext context, IBarChartDataSetProtocol dataSet, nint index);

        // -(void)drawValuesWithContext:(CGContextRef _Nonnull)context;
        [Export("drawValuesWithContext:")]
        void DrawValuesWithContext(CGContext context);

        // -(BOOL)isDrawingValuesAllowedWithDataProvider:(id<ChartDataProvider> _Nullable)dataProvider __attribute__((warn_unused_result("")));
        [Export("isDrawingValuesAllowedWithDataProvider:")]
        bool IsDrawingValuesAllowedWithDataProvider([NullAllowed] IChartDataProvider dataProvider);
    }

    // @interface HorizontalBarChartView : BarChartView
    [BaseType(typeof(BarChartView), Name = "_TtC8DGCharts22HorizontalBarChartView")]
    interface HorizontalBarChartView
    {
        // -(CGPoint)getMarkerPositionWithHighlight:(ChartHighlight * _Nonnull)highlight __attribute__((warn_unused_result("")));
        [Export("getMarkerPositionWithHighlight:")]
        CGPoint GetMarkerPositionWithHighlight(ChartHighlight highlight);

        // -(CGRect)getBarBoundsWithEntry:(BarChartDataEntry * _Nonnull)e __attribute__((warn_unused_result("")));
        [Export("getBarBoundsWithEntry:")]
        CGRect GetBarBoundsWithEntry(BarChartDataEntry e);

        // -(CGPoint)getPositionWithEntry:(ChartDataEntry * _Nonnull)e axis:(enum AxisDependency)axis __attribute__((warn_unused_result("")));
        [Export("getPositionWithEntry:axis:")]
        CGPoint GetPositionWithEntry(ChartDataEntry e, AxisDependency axis);

        // -(ChartHighlight * _Nullable)getHighlightByTouchPoint:(CGPoint)pt __attribute__((warn_unused_result("")));
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
        NativeHandle Constructor(CGRect frame);
    }

    // @interface HorizontalBarChartHighlighter : BarChartHighlighter
    [BaseType(typeof(BarChartHighlighter))]
    interface HorizontalBarChartHighlighter
    {
        // -(ChartHighlight * _Nullable)getHighlightWithX:(CGFloat)x y:(CGFloat)y __attribute__((warn_unused_result("")));
        [Export("getHighlightWithX:y:")]
        [return: NullAllowed]
        ChartHighlight GetHighlightWithX(nfloat x, nfloat y);

        // -(instancetype _Nonnull)initWithChart:(id<ChartDataProvider> _Nonnull)chart __attribute__((objc_designated_initializer));
        [Export("initWithChart:")]
        [DesignatedInitializer]
        NativeHandle Constructor(IChartDataProvider chart);
    }

    // @interface ChartImageFill : NSObject <ChartFill>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ChartImageFill : ChartFill
    {
        // @property (readonly, nonatomic) CGImageRef _Nonnull image;
        [Export("image")]
        CGImage Image { get; }

        // @property (readonly, nonatomic) BOOL isTiled;
        [Export("isTiled")]
        bool IsTiled { get; }

        // -(instancetype _Nonnull)initWithCgImage:(CGImageRef _Nonnull)cgImage isTiled:(BOOL)isTiled __attribute__((objc_designated_initializer));
        [Export("initWithCgImage:isTiled:")]
        [DesignatedInitializer]
        NativeHandle Constructor(CGImage cgImage, bool isTiled);

        // -(instancetype _Nonnull)initWithImage:(UIImage * _Nonnull)image isTiled:(BOOL)isTiled;
        [Export("initWithImage:isTiled:")]
        NativeHandle Constructor(UIImage image, bool isTiled);

        // -(void)fillPathWithContext:(CGContextRef _Nonnull)context rect:(CGRect)rect;
        [Export("fillPathWithContext:rect:")]
        void FillPathWithContext(CGContext context, CGRect rect);
    }

    // @interface ChartIndexAxisValueFormatter : NSObject <ChartAxisValueFormatter>
    [BaseType(typeof(NSObject))]
    interface ChartIndexAxisValueFormatter : ChartAxisValueFormatter
    {
        // @property (copy, nonatomic) NSArray<NSString *> * _Nonnull values;
        [Export("values", ArgumentSemantic.Copy)]
        string[] Values { get; set; }

        // -(instancetype _Nonnull)initWithValues:(NSArray<NSString *> * _Nonnull)values __attribute__((objc_designated_initializer));
        [Export("initWithValues:")]
        [DesignatedInitializer]
        NativeHandle Constructor(string[] values);

        // +(ChartIndexAxisValueFormatter * _Nullable)withValues:(NSArray<NSString *> * _Nonnull)values __attribute__((warn_unused_result("")));
        [Static]
        [Export("withValues:")]
        [return: NullAllowed]
        ChartIndexAxisValueFormatter WithValues(string[] values);

        // -(NSString * _Nonnull)stringForValue:(double)value axis:(ChartAxisBase * _Nullable)axis __attribute__((warn_unused_result("")));
        [Export("stringForValue:axis:")]
        string StringForValue(double value, [NullAllowed] ChartAxisBase axis);
    }

    // @interface ChartLayerFill : NSObject <ChartFill>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ChartLayerFill : ChartFill
    {
        // @property (readonly, nonatomic) CGLayerRef _Nonnull layer;
        [Export("layer")]
        CGLayer Layer { get; }

        // -(instancetype _Nonnull)initWithLayer:(CGLayerRef _Nonnull)layer __attribute__((objc_designated_initializer));
        [Export("initWithLayer:")]
        [DesignatedInitializer]
        NativeHandle Constructor(CGLayer layer);

        // -(void)fillPathWithContext:(CGContextRef _Nonnull)context rect:(CGRect)rect;
        [Export("fillPathWithContext:rect:")]
        void FillPathWithContext(CGContext context, CGRect rect);
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

        // @property (copy, nonatomic) NSArray<NSValue *> * _Nonnull calculatedLabelSizes;
        [Export("calculatedLabelSizes", ArgumentSemantic.Copy)]
        NSValue[] CalculatedLabelSizes { get; set; }

        // @property (copy, nonatomic) NSArray<NSNumber *> * _Nonnull calculatedLabelBreakPoints;
        [Export("calculatedLabelBreakPoints", ArgumentSemantic.Copy)]
        NSNumber[] CalculatedLabelBreakPoints { get; set; }

        // @property (copy, nonatomic) NSArray<NSValue *> * _Nonnull calculatedLineSizes;
        [Export("calculatedLineSizes", ArgumentSemantic.Copy)]
        NSValue[] CalculatedLineSizes { get; set; }

        // -(instancetype _Nonnull)initWithEntries:(NSArray<ChartLegendEntry *> * _Nonnull)entries __attribute__((objc_designated_initializer));
        [Export("initWithEntries:")]
        [DesignatedInitializer]
        NativeHandle Constructor(ChartLegendEntry[] entries);

        // -(CGSize)getMaximumEntrySizeWithFont:(UIFont * _Nonnull)font __attribute__((warn_unused_result("")));
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
    }

    // @interface ChartLegendEntry : NSObject
    [BaseType(typeof(NSObject))]
    interface ChartLegendEntry
    {
        // -(instancetype _Nonnull)initWithLabel:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
        [Export("initWithLabel:")]
        [DesignatedInitializer]
        NativeHandle Constructor([NullAllowed] string label);

        // @property (copy, nonatomic) NSString * _Nullable label;
        [NullAllowed, Export("label")]
        string Label { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable labelColor;
        [NullAllowed, Export("labelColor", ArgumentSemantic.Strong)]
        UIColor LabelColor { get; set; }

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

    // @interface ChartLegendRenderer : NSObject <ChartRenderer>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ChartLegendRenderer : ChartRenderer
    {
        // @property (readonly, nonatomic, strong) ChartViewPortHandler * _Nonnull viewPortHandler;
        [Export("viewPortHandler", ArgumentSemantic.Strong)]
        ChartViewPortHandler ViewPortHandler { get; }

        // @property (nonatomic, strong) ChartLegend * _Nullable legend;
        [NullAllowed, Export("legend", ArgumentSemantic.Strong)]
        ChartLegend Legend { get; set; }

        // -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler legend:(ChartLegend * _Nullable)legend __attribute__((objc_designated_initializer));
        [Export("initWithViewPortHandler:legend:")]
        [DesignatedInitializer]
        NativeHandle Constructor(ChartViewPortHandler viewPortHandler, [NullAllowed] ChartLegend legend);

        // -(void)computeLegendWithData:(ChartData * _Nonnull)data;
        [Export("computeLegendWithData:")]
        void ComputeLegendWithData(ChartData data);

        // -(void)renderLegendWithContext:(CGContextRef _Nonnull)context;
        [Export("renderLegendWithContext:")]
        void RenderLegendWithContext(CGContext context);

        // -(void)drawFormWithContext:(CGContextRef _Nonnull)context x:(CGFloat)x y:(CGFloat)y entry:(ChartLegendEntry * _Nonnull)entry legend:(ChartLegend * _Nonnull)legend;
        [Export("drawFormWithContext:x:y:entry:legend:")]
        void DrawFormWithContext(CGContext context, nfloat x, nfloat y, ChartLegendEntry entry, ChartLegend legend);

        // -(void)drawLabelWithContext:(CGContextRef _Nonnull)context x:(CGFloat)x y:(CGFloat)y label:(NSString * _Nonnull)label font:(UIFont * _Nonnull)font textColor:(UIColor * _Nonnull)textColor;
        [Export("drawLabelWithContext:x:y:label:font:textColor:")]
        void DrawLabelWithContext(CGContext context, nfloat x, nfloat y, string label, UIFont font, UIColor textColor);
    }

    // @interface LineChartData : ChartData
    [BaseType(typeof(ChartData), Name = "_TtC8DGCharts13LineChartData")]
    interface LineChartData
    {
        // -(instancetype _Nonnull)initWithDataSets:(NSArray<id<ChartDataSetProtocol>> * _Nonnull)dataSets __attribute__((objc_designated_initializer));
        [Export("initWithDataSets:")]
        [DesignatedInitializer]
        NativeHandle Constructor(IChartDataSetProtocol[] dataSets);
    }

    interface ILineRadarChartDataSetProtocol { }

    // @protocol LineRadarChartDataSetProtocol <LineScatterCandleRadarChartDataSetProtocol>
    [Protocol(Name = "_TtP8DGCharts29LineRadarChartDataSetProtocol_"), Model]
    [BaseType(typeof(NSObject))]
    interface LineRadarChartDataSetProtocol : LineScatterCandleRadarChartDataSetProtocol
    {
        // @required @property (nonatomic, strong) UIColor * _Nonnull fillColor;
        [Abstract]
        [Export("fillColor", ArgumentSemantic.Strong)]
        UIColor FillColor { get; set; }

        // @required @property (nonatomic, strong) id<ChartFill> _Nullable fill;
        [Abstract]
        [NullAllowed, Export("fill", ArgumentSemantic.Strong)]
        IChartFill Fill { get; set; }

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

    interface ILineChartDataSetProtocol { }

    // @protocol LineChartDataSetProtocol <LineRadarChartDataSetProtocol>
    [Protocol(Name = "_TtP8DGCharts24LineChartDataSetProtocol_"), Model]
    [BaseType(typeof(NSObject))]
    interface LineChartDataSetProtocol : LineRadarChartDataSetProtocol
    {
        // @required @property (nonatomic) enum LineChartMode mode;
        [Abstract]
        [Export("mode", ArgumentSemantic.Assign)]
        LineChartMode Mode { get; set; }

        // @required @property (nonatomic) CGFloat cubicIntensity;
        [Abstract]
        [Export("cubicIntensity")]
        nfloat CubicIntensity { get; set; }

        // @required @property (nonatomic) BOOL isDrawLineWithGradientEnabled;
        [Abstract]
        [Export("isDrawLineWithGradientEnabled")]
        bool IsDrawLineWithGradientEnabled { get; set; }

        // @required @property (copy, nonatomic) NSArray<NSNumber *> * _Nullable gradientPositions;
        [Abstract]
        [NullAllowed, Export("gradientPositions", ArgumentSemantic.Copy)]
        NSNumber[] GradientPositions { get; set; }

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

        // @required -(UIColor * _Nullable)getCircleColorAtIndex:(NSInteger)atIndex __attribute__((warn_unused_result("")));
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
        nfloat LineDashPhase { get; set; }

        // @required @property (copy, nonatomic) NSArray<NSNumber *> * _Nullable lineDashLengths;
        [Abstract]
        [NullAllowed, Export("lineDashLengths", ArgumentSemantic.Copy)]
        NSNumber[] LineDashLengths { get; set; }

        // @required @property (nonatomic) CGLineCap lineCapType;
        [Abstract]
        [Export("lineCapType", ArgumentSemantic.Assign)]
        CGLineCap LineCapType { get; set; }

        // @required @property (nonatomic, strong) id<ChartFillFormatter> _Nullable fillFormatter;
        [Abstract]
        [NullAllowed, Export("fillFormatter", ArgumentSemantic.Strong)]
        IChartFillFormatter FillFormatter { get; set; }
    }

    // @interface LineRadarChartDataSet : LineScatterCandleRadarChartDataSet <LineRadarChartDataSetProtocol>
    [BaseType(typeof(LineScatterCandleRadarChartDataSet), Name = "_TtC8DGCharts21LineRadarChartDataSet")]
    interface LineRadarChartDataSet : LineRadarChartDataSetProtocol
    {
        // @property (nonatomic, strong) UIColor * _Nonnull fillColor;
        [Export("fillColor", ArgumentSemantic.Strong)]
        UIColor FillColor { get; set; }

        // @property (nonatomic, strong) id<ChartFill> _Nullable fill;
        [NullAllowed, Export("fill", ArgumentSemantic.Strong)]
        IChartFill Fill { get; set; }

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

        // -(instancetype _Nonnull)initWithEntries:(NSArray<ChartDataEntry *> * _Nonnull)entries label:(NSString * _Nonnull)label __attribute__((objc_designated_initializer));
        [Export("initWithEntries:label:")]
        [DesignatedInitializer]
        NativeHandle Constructor(ChartDataEntry[] entries, string label);
    }

    // @interface LineChartDataSet : LineRadarChartDataSet <LineChartDataSetProtocol>
    [BaseType(typeof(LineRadarChartDataSet), Name = "_TtC8DGCharts16LineChartDataSet")]
    interface LineChartDataSet : LineChartDataSetProtocol
    {
        // -(instancetype _Nonnull)initWithEntries:(NSArray<ChartDataEntry *> * _Nonnull)entries label:(NSString * _Nonnull)label __attribute__((objc_designated_initializer));
        [Export("initWithEntries:label:")]
        [DesignatedInitializer]
        NativeHandle Constructor(ChartDataEntry[] entries, string label);

        // @property (nonatomic) enum LineChartMode mode;
        [Export("mode", ArgumentSemantic.Assign)]
        LineChartMode Mode { get; set; }

        // @property (nonatomic) CGFloat cubicIntensity;
        [Export("cubicIntensity")]
        nfloat CubicIntensity { get; set; }

        // @property (nonatomic) BOOL isDrawLineWithGradientEnabled;
        [Export("isDrawLineWithGradientEnabled")]
        bool IsDrawLineWithGradientEnabled { get; set; }

        // @property (copy, nonatomic) NSArray<NSNumber *> * _Nullable gradientPositions;
        [NullAllowed, Export("gradientPositions", ArgumentSemantic.Copy)]
        NSNumber[] GradientPositions { get; set; }

        // @property (nonatomic) CGFloat circleRadius;
        [Export("circleRadius")]
        nfloat CircleRadius { get; set; }

        // @property (nonatomic) CGFloat circleHoleRadius;
        [Export("circleHoleRadius")]
        nfloat CircleHoleRadius { get; set; }

        // @property (copy, nonatomic) NSArray<UIColor *> * _Nonnull circleColors;
        [Export("circleColors", ArgumentSemantic.Copy)]
        UIColor[] CircleColors { get; set; }

        // -(UIColor * _Nullable)getCircleColorAtIndex:(NSInteger)index __attribute__((warn_unused_result("")));
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

        // @property (nonatomic, strong) id<ChartFillFormatter> _Nullable fillFormatter;
        [NullAllowed, Export("fillFormatter", ArgumentSemantic.Strong)]
        IChartFillFormatter FillFormatter { get; set; }
    }

    // @interface LineRadarChartRenderer : LineScatterCandleRadarChartRenderer
    [BaseType(typeof(LineScatterCandleRadarChartRenderer))]
    interface LineRadarChartRenderer
    {
        // -(void)drawFilledPathWithContext:(CGContextRef _Nonnull)context path:(CGPathRef _Nonnull)path fill:(id<ChartFill> _Nonnull)fill fillAlpha:(CGFloat)fillAlpha;
        [Export("drawFilledPathWithContext:path:fill:fillAlpha:")]
        void DrawFilledPathWithContext(CGContext context, CGPath path, IChartFill fill, nfloat fillAlpha);

        // -(void)drawFilledPathWithContext:(CGContextRef _Nonnull)context path:(CGPathRef _Nonnull)path fillColor:(UIColor * _Nonnull)fillColor fillAlpha:(CGFloat)fillAlpha;
        [Export("drawFilledPathWithContext:path:fillColor:fillAlpha:")]
        void DrawFilledPathWithContext(CGContext context, CGPath path, UIColor fillColor, nfloat fillAlpha);
    }

    // @interface LineChartRenderer : LineRadarChartRenderer
    [BaseType(typeof(LineRadarChartRenderer), Name = "_TtC8DGCharts17LineChartRenderer")]
    interface LineChartRenderer
    {
        // @property (nonatomic, weak) id<LineChartDataProvider> _Nullable dataProvider;
        [NullAllowed, Export("dataProvider", ArgumentSemantic.Weak)]
        ILineChartDataProvider DataProvider { get; set; }

        // -(instancetype _Nonnull)initWithDataProvider:(id<LineChartDataProvider> _Nonnull)dataProvider animator:(ChartAnimator * _Nonnull)animator viewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler __attribute__((objc_designated_initializer));
        [Export("initWithDataProvider:animator:viewPortHandler:")]
        [DesignatedInitializer]
        NativeHandle Constructor(ILineChartDataProvider dataProvider, ChartAnimator animator, ChartViewPortHandler viewPortHandler);

        // -(void)drawDataWithContext:(CGContextRef _Nonnull)context;
        [Export("drawDataWithContext:")]
        void DrawDataWithContext(CGContext context);

        // -(void)drawDataSetWithContext:(CGContextRef _Nonnull)context dataSet:(id<LineChartDataSetProtocol> _Nonnull)dataSet;
        [Export("drawDataSetWithContext:dataSet:")]
        void DrawDataSetWithContext(CGContext context, ILineChartDataSetProtocol dataSet);

        // -(void)drawCubicBezierWithContext:(CGContextRef _Nonnull)context dataSet:(id<LineChartDataSetProtocol> _Nonnull)dataSet;
        [Export("drawCubicBezierWithContext:dataSet:")]
        void DrawCubicBezierWithContext(CGContext context, ILineChartDataSetProtocol dataSet);

        // -(void)drawHorizontalBezierWithContext:(CGContextRef _Nonnull)context dataSet:(id<LineChartDataSetProtocol> _Nonnull)dataSet;
        [Export("drawHorizontalBezierWithContext:dataSet:")]
        void DrawHorizontalBezierWithContext(CGContext context, ILineChartDataSetProtocol dataSet);

        // -(void)drawLinearWithContext:(CGContextRef _Nonnull)context dataSet:(id<LineChartDataSetProtocol> _Nonnull)dataSet;
        [Export("drawLinearWithContext:dataSet:")]
        void DrawLinearWithContext(CGContext context, ILineChartDataSetProtocol dataSet);

        // -(void)drawValuesWithContext:(CGContextRef _Nonnull)context;
        [Export("drawValuesWithContext:")]
        void DrawValuesWithContext(CGContext context);

        // -(void)drawExtrasWithContext:(CGContextRef _Nonnull)context;
        [Export("drawExtrasWithContext:")]
        void DrawExtrasWithContext(CGContext context);

        // -(void)drawHighlightedWithContext:(CGContextRef _Nonnull)context indices:(NSArray<ChartHighlight *> * _Nonnull)indices;
        [Export("drawHighlightedWithContext:indices:")]
        void DrawHighlightedWithContext(CGContext context, ChartHighlight[] indices);
    }

    // @interface LineChartView : BarLineChartViewBase <LineChartDataProvider>
    [BaseType(typeof(BarLineChartViewBase), Name = "_TtC8DGCharts13LineChartView")]
    interface LineChartView : LineChartDataProvider
    {
        // @property (readonly, nonatomic, strong) LineChartData * _Nullable lineData;
        [NullAllowed, Export("lineData", ArgumentSemantic.Strong)]
        LineChartData LineData { get; }

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        NativeHandle Constructor(CGRect frame);
    }

    // @interface ChartLinearGradientFill : NSObject <ChartFill>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ChartLinearGradientFill : ChartFill
    {
        // @property (readonly, nonatomic) CGGradientRef _Nonnull gradient;
        [Export("gradient")]
        CGGradient Gradient { get; }

        // @property (readonly, nonatomic) CGFloat angle;
        [Export("angle")]
        nfloat Angle { get; }

        // -(instancetype _Nonnull)initWithGradient:(CGGradientRef _Nonnull)gradient angle:(CGFloat)angle __attribute__((objc_designated_initializer));
        [Export("initWithGradient:angle:")]
        [DesignatedInitializer]
        NativeHandle Constructor(CGGradient gradient, nfloat angle);

        // -(void)fillPathWithContext:(CGContextRef _Nonnull)context rect:(CGRect)rect;
        [Export("fillPathWithContext:rect:")]
        void FillPathWithContext(CGContext context, CGRect rect);
    }

    interface IChartMarker { }

    // @protocol ChartMarker
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface ChartMarker
    {
        // @required @property (readonly, nonatomic) CGPoint offset;
        [Abstract]
        [Export("offset")]
        CGPoint Offset { get; set; }

        // @required -(CGPoint)offsetForDrawingAtPoint:(CGPoint)atPoint __attribute__((warn_unused_result("")));
        [Abstract]
        [Export("offsetForDrawingAtPoint:")]
        CGPoint OffsetForDrawingAtPoint(CGPoint atPoint);

        // @required -(void)refreshContentWithEntry:(ChartDataEntry * _Nonnull)entry highlight:(ChartHighlight * _Nonnull)highlight;
        [Abstract]
        [Export("refreshContentWithEntry:highlight:")]
        void RefreshContentWithEntry(ChartDataEntry entry, ChartHighlight highlight);

        // @required -(void)drawWithContext:(CGContextRef _Nonnull)context point:(CGPoint)point;
        [Abstract]
        [Export("drawWithContext:point:")]
        void DrawWithContext(CGContext context, CGPoint point);
    }

    // @interface ChartMarkerImage : NSObject <ChartMarker>
    [BaseType(typeof(NSObject))]
    interface ChartMarkerImage : ChartMarker
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

        // -(CGPoint)offsetForDrawingAtPoint:(CGPoint)point __attribute__((warn_unused_result("")));
        [Export("offsetForDrawingAtPoint:")]
        CGPoint OffsetForDrawingAtPoint(CGPoint point);

        // -(void)refreshContentWithEntry:(ChartDataEntry * _Nonnull)entry highlight:(ChartHighlight * _Nonnull)highlight;
        [Export("refreshContentWithEntry:highlight:")]
        void RefreshContentWithEntry(ChartDataEntry entry, ChartHighlight highlight);

        // -(void)drawWithContext:(CGContextRef _Nonnull)context point:(CGPoint)point;
        [Export("drawWithContext:point:")]
        void DrawWithContext(CGContext context, CGPoint point);
    }

    // @interface ChartMarkerView : NSUIView <ChartMarker>
    [BaseType(typeof(NSUIView))]
    interface ChartMarkerView : ChartMarker
    {
        // @property (nonatomic) CGPoint offset;
        [Export("offset", ArgumentSemantic.Assign)]
        CGPoint Offset { get; set; }

        // @property (nonatomic, weak) ChartViewBase * _Nullable chartView;
        [NullAllowed, Export("chartView", ArgumentSemantic.Weak)]
        ChartViewBase ChartView { get; set; }

        // -(CGPoint)offsetForDrawingAtPoint:(CGPoint)point __attribute__((warn_unused_result("")));
        [Export("offsetForDrawingAtPoint:")]
        CGPoint OffsetForDrawingAtPoint(CGPoint point);

        // -(void)refreshContentWithEntry:(ChartDataEntry * _Nonnull)entry highlight:(ChartHighlight * _Nonnull)highlight;
        [Export("refreshContentWithEntry:highlight:")]
        void RefreshContentWithEntry(ChartDataEntry entry, ChartHighlight highlight);

        // -(void)drawWithContext:(CGContextRef _Nonnull)context point:(CGPoint)point;
        [Export("drawWithContext:point:")]
        void DrawWithContext(CGContext context, CGPoint point);

        // +(ChartMarkerView * _Nullable)viewFromXibIn:(NSBundle * _Nonnull)bundle __attribute__((warn_unused_result("")));
        [Static]
        [Export("viewFromXibIn:")]
        [return: NullAllowed]
        ChartMarkerView ViewFromXibIn(NSBundle bundle);

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        NativeHandle Constructor(CGRect frame);
    }

    // @interface MoveChartViewJob : ChartViewPortJob
    [BaseType(typeof(ChartViewPortJob))]
    interface MoveChartViewJob
    {
        // -(void)doJob;
        [Export("doJob")]
        void DoJob();

        // -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler xValue:(double)xValue yValue:(double)yValue transformer:(ChartTransformer * _Nonnull)transformer view:(ChartViewBase * _Nonnull)view __attribute__((objc_designated_initializer));
        [Export("initWithViewPortHandler:xValue:yValue:transformer:view:")]
        [DesignatedInitializer]
        NativeHandle Constructor(ChartViewPortHandler viewPortHandler, double xValue, double yValue, ChartTransformer transformer, ChartViewBase view);
    }

    // @interface NSUIAccessibilityElement : UIAccessibilityElement
    [BaseType(typeof(UIAccessibilityElement), Name = "_TtC8DGCharts24NSUIAccessibilityElement")]
    [DisableDefaultCtor]
    interface NSUIAccessibilityElement
    {
        // -(instancetype _Nonnull)initWithAccessibilityContainer:(id _Nonnull)container __attribute__((objc_designated_initializer));
        [Export("initWithAccessibilityContainer:")]
        [DesignatedInitializer]
        NativeHandle Constructor(NSObject container);

        // @property (nonatomic) CGRect accessibilityFrame;
        [Export("accessibilityFrame", ArgumentSemantic.Assign)]
        CGRect AccessibilityFrame { get; set; }
    }

    // @interface PieChartData : ChartData
    [BaseType(typeof(ChartData), Name = "_TtC8DGCharts12PieChartData")]
    interface PieChartData
    {
        // -(instancetype _Nonnull)initWithDataSets:(NSArray<id<ChartDataSetProtocol>> * _Nonnull)dataSets __attribute__((objc_designated_initializer));
        [Export("initWithDataSets:")]
        [DesignatedInitializer]
        NativeHandle Constructor(IChartDataSetProtocol[] dataSets);

        // @property (nonatomic, strong) id<PieChartDataSetProtocol> _Nullable dataSet;
        [NullAllowed, Export("dataSet", ArgumentSemantic.Strong)]
        IPieChartDataSetProtocol DataSet { get; set; }

        // @property (copy, nonatomic) NSArray<id<ChartDataSetProtocol>> * _Nonnull dataSets;
        [Export("dataSets", ArgumentSemantic.Copy)]
        IChartDataSetProtocol[] DataSets { get; set; }

        // -(id<ChartDataSetProtocol> _Nullable)dataSetAtIndex:(NSInteger)index __attribute__((warn_unused_result("")));
        [Export("dataSetAtIndex:")]
        [return: NullAllowed]
        IChartDataSetProtocol DataSetAtIndex(nint index);

        // -(id<ChartDataSetProtocol> _Nullable)dataSetForLabel:(NSString * _Nonnull)label ignorecase:(BOOL)ignorecase __attribute__((warn_unused_result("")));
        [Export("dataSetForLabel:ignorecase:")]
        [return: NullAllowed]
        IChartDataSetProtocol DataSetForLabel(string label, bool ignorecase);

        // -(ChartDataEntry * _Nullable)entryFor:(ChartHighlight * _Nonnull)highlight __attribute__((warn_unused_result("")));
        [Export("entryFor:")]
        [return: NullAllowed]
        ChartDataEntry EntryFor(ChartHighlight highlight);

        // @property (readonly, nonatomic) double yValueSum;
        [Export("yValueSum")]
        double YValueSum { get; }
    }

    // @interface PieChartDataEntry : ChartDataEntry
    [BaseType(typeof(ChartDataEntry), Name = "_TtC8DGCharts17PieChartDataEntry")]
    interface PieChartDataEntry
    {
        // -(instancetype _Nonnull)initWithValue:(double)value __attribute__((objc_designated_initializer));
        [Export("initWithValue:")]
        [DesignatedInitializer]
        NativeHandle Constructor(double value);

        // -(instancetype _Nonnull)initWithValue:(double)value label:(NSString * _Nullable)label;
        [Export("initWithValue:label:")]
        NativeHandle Constructor(double value, [NullAllowed] string label);

        // -(instancetype _Nonnull)initWithValue:(double)value label:(NSString * _Nullable)label data:(id _Nullable)data;
        [Export("initWithValue:label:data:")]
        NativeHandle Constructor(double value, [NullAllowed] string label, [NullAllowed] NSObject data);

        // -(instancetype _Nonnull)initWithValue:(double)value label:(NSString * _Nullable)label icon:(UIImage * _Nullable)icon;
        [Export("initWithValue:label:icon:")]
        NativeHandle Constructor(double value, [NullAllowed] string label, [NullAllowed] UIImage icon);

        // -(instancetype _Nonnull)initWithValue:(double)value label:(NSString * _Nullable)label icon:(UIImage * _Nullable)icon data:(id _Nullable)data;
        [Export("initWithValue:label:icon:data:")]
        NativeHandle Constructor(double value, [NullAllowed] string label, [NullAllowed] UIImage icon, [NullAllowed] NSObject data);

        // -(instancetype _Nonnull)initWithValue:(double)value data:(id _Nullable)data;
        [Export("initWithValue:data:")]
        NativeHandle Constructor(double value, [NullAllowed] NSObject data);

        // -(instancetype _Nonnull)initWithValue:(double)value icon:(UIImage * _Nullable)icon;
        [Export("initWithValue:icon:")]
        NativeHandle Constructor(double value, [NullAllowed] UIImage icon);

        // -(instancetype _Nonnull)initWithValue:(double)value icon:(UIImage * _Nullable)icon data:(id _Nullable)data;
        [Export("initWithValue:icon:data:")]
        NativeHandle Constructor(double value, [NullAllowed] UIImage icon, [NullAllowed] NSObject data);

        // @property (copy, nonatomic) NSString * _Nullable label;
        [NullAllowed, Export("label")]
        string Label { get; set; }

        // @property (nonatomic) double value;
        [Export("value")]
        double Value { get; set; }
    }

    interface IPieChartDataSetProtocol { }

    // @protocol PieChartDataSetProtocol <ChartDataSetProtocol>
    [Protocol(Name = "_TtP8DGCharts23PieChartDataSetProtocol_"), Model]
    [BaseType(typeof(NSObject))]
    interface PieChartDataSetProtocol : ChartDataSetProtocol
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

        // @required @property (nonatomic) BOOL useValueColorForLine;
        [Abstract]
        [Export("useValueColorForLine")]
        bool UseValueColorForLine { get; set; }

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

        // @required @property (nonatomic, strong) UIColor * _Nullable highlightColor;
        [Abstract]
        [NullAllowed, Export("highlightColor", ArgumentSemantic.Strong)]
        UIColor HighlightColor { get; set; }
    }

    // @interface PieChartDataSet : ChartDataSet <PieChartDataSetProtocol>
    [BaseType(typeof(ChartDataSet), Name = "_TtC8DGCharts15PieChartDataSet")]
    interface PieChartDataSet : PieChartDataSetProtocol
    {
        // -(instancetype _Nonnull)initWithEntries:(NSArray<ChartDataEntry *> * _Nonnull)entries label:(NSString * _Nonnull)label __attribute__((objc_designated_initializer));
        [Export("initWithEntries:label:")]
        [DesignatedInitializer]
        NativeHandle Constructor(ChartDataEntry[] entries, string label);

        // @property (nonatomic) CGFloat sliceSpace;
        [Export("sliceSpace")]
        nfloat SliceSpace { get; set; }

        // @property (nonatomic) BOOL automaticallyDisableSliceSpacing;
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

        // @property (nonatomic) BOOL useValueColorForLine;
        [Export("useValueColorForLine")]
        bool UseValueColorForLine { get; set; }

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

        // @property (nonatomic, strong) UIColor * _Nullable highlightColor;
        [NullAllowed, Export("highlightColor", ArgumentSemantic.Strong)]
        UIColor HighlightColor { get; set; }
    }

    // @interface PieChartRenderer : NSObject <ChartDataRenderer>
    [BaseType(typeof(NSObject), Name = "_TtC8DGCharts16PieChartRenderer")]
    [DisableDefaultCtor]
    interface PieChartRenderer : ChartDataRenderer
    {
        // @property (readonly, nonatomic, strong) ChartViewPortHandler * _Nonnull viewPortHandler;
        [Export("viewPortHandler", ArgumentSemantic.Strong)]
        ChartViewPortHandler ViewPortHandler { get; }

        // @property (copy, nonatomic) NSArray<NSUIAccessibilityElement *> * _Nonnull accessibleChartElements;
        [Export("accessibleChartElements", ArgumentSemantic.Copy)]
        NSUIAccessibilityElement[] AccessibleChartElements { get; set; }

        // @property (readonly, nonatomic, strong) ChartAnimator * _Nonnull animator;
        [Export("animator", ArgumentSemantic.Strong)]
        ChartAnimator Animator { get; }

        // @property (nonatomic, weak) PieChartView * _Nullable chart;
        [NullAllowed, Export("chart", ArgumentSemantic.Weak)]
        PieChartView Chart { get; set; }

        // -(instancetype _Nonnull)initWithChart:(PieChartView * _Nonnull)chart animator:(ChartAnimator * _Nonnull)animator viewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler __attribute__((objc_designated_initializer));
        [Export("initWithChart:animator:viewPortHandler:")]
        [DesignatedInitializer]
        NativeHandle Constructor(PieChartView chart, ChartAnimator animator, ChartViewPortHandler viewPortHandler);

        // -(void)drawDataWithContext:(CGContextRef _Nonnull)context;
        [Export("drawDataWithContext:")]
        void DrawDataWithContext(CGContext context);

        // -(CGFloat)calculateMinimumRadiusForSpacedSliceWithCenter:(CGPoint)center radius:(CGFloat)radius angle:(CGFloat)angle arcStartPointX:(CGFloat)arcStartPointX arcStartPointY:(CGFloat)arcStartPointY startAngle:(CGFloat)startAngle sweepAngle:(CGFloat)sweepAngle __attribute__((warn_unused_result("")));
        [Export("calculateMinimumRadiusForSpacedSliceWithCenter:radius:angle:arcStartPointX:arcStartPointY:startAngle:sweepAngle:")]
        nfloat CalculateMinimumRadiusForSpacedSliceWithCenter(CGPoint center, nfloat radius, nfloat angle, nfloat arcStartPointX, nfloat arcStartPointY, nfloat startAngle, nfloat sweepAngle);

        // -(CGFloat)getSliceSpaceWithDataSet:(id<PieChartDataSetProtocol> _Nonnull)dataSet __attribute__((warn_unused_result("")));
        [Export("getSliceSpaceWithDataSet:")]
        nfloat GetSliceSpaceWithDataSet(IPieChartDataSetProtocol dataSet);

        // -(void)drawDataSetWithContext:(CGContextRef _Nonnull)context dataSet:(id<PieChartDataSetProtocol> _Nonnull)dataSet;
        [Export("drawDataSetWithContext:dataSet:")]
        void DrawDataSetWithContext(CGContext context, IPieChartDataSetProtocol dataSet);

        // -(void)drawValuesWithContext:(CGContextRef _Nonnull)context;
        [Export("drawValuesWithContext:")]
        void DrawValuesWithContext(CGContext context);

        // -(void)drawExtrasWithContext:(CGContextRef _Nonnull)context;
        [Export("drawExtrasWithContext:")]
        void DrawExtrasWithContext(CGContext context);

        // -(void)initBuffers __attribute__((objc_method_family("none")));
        [Export("initBuffers")]
        void InitBuffers();

        // -(BOOL)isDrawingValuesAllowedWithDataProvider:(id<ChartDataProvider> _Nullable)dataProvider __attribute__((warn_unused_result("")));
        [Export("isDrawingValuesAllowedWithDataProvider:")]
        bool IsDrawingValuesAllowedWithDataProvider([NullAllowed] IChartDataProvider dataProvider);

        // -(void)drawHighlightedWithContext:(CGContextRef _Nonnull)context indices:(NSArray<ChartHighlight *> * _Nonnull)highlights;
        [Export("drawHighlightedWithContext:indices:")]
        void DrawHighlightedWithContext(CGContext context, ChartHighlight[] highlights);

        // -(NSUIAccessibilityElement * _Nonnull)createAccessibleHeaderUsingChart:(ChartViewBase * _Nonnull)chart andData:(ChartData * _Nonnull)data withDefaultDescription:(NSString * _Nonnull)defaultDescription __attribute__((warn_unused_result("")));
        [Export("createAccessibleHeaderUsingChart:andData:withDefaultDescription:")]
        NSUIAccessibilityElement CreateAccessibleHeaderUsingChart(ChartViewBase chart, ChartData data, string defaultDescription);
    }

    // @interface PieRadarChartViewBase : ChartViewBase
    [BaseType(typeof(ChartViewBase), Name = "_TtC8DGCharts21PieRadarChartViewBase")]
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
        NativeHandle Constructor(CGRect frame);

        // @property (readonly, nonatomic) NSInteger maxVisibleCount;
        [Export("maxVisibleCount")]
        nint MaxVisibleCount { get; }

        // -(void)notifyDataSetChanged;
        [Export("notifyDataSetChanged")]
        void NotifyDataSetChanged();

        // -(CGFloat)angleForPointWithX:(CGFloat)x y:(CGFloat)y __attribute__((warn_unused_result("")));
        [Export("angleForPointWithX:y:")]
        nfloat AngleForPointWithX(nfloat x, nfloat y);

        // -(CGPoint)getPositionWithCenter:(CGPoint)center dist:(CGFloat)dist angle:(CGFloat)angle __attribute__((warn_unused_result("")));
        [Export("getPositionWithCenter:dist:angle:")]
        CGPoint GetPositionWithCenter(CGPoint center, nfloat dist, nfloat angle);

        // -(CGFloat)distanceToCenterWithX:(CGFloat)x y:(CGFloat)y __attribute__((warn_unused_result("")));
        [Export("distanceToCenterWithX:y:")]
        nfloat DistanceToCenterWithX(nfloat x, nfloat y);

        // -(NSInteger)indexForAngle:(CGFloat)angle __attribute__((warn_unused_result("")));
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
    [BaseType(typeof(PieRadarChartViewBase), Name = "_TtC8DGCharts12PieChartView")]
    interface PieChartView
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        NativeHandle Constructor(CGRect frame);

        // -(void)drawRect:(CGRect)rect;
        [Export("drawRect:")]
        void DrawRect(CGRect rect);

        // -(CGFloat)angleForPointWithX:(CGFloat)x y:(CGFloat)y __attribute__((warn_unused_result("")));
        [Export("angleForPointWithX:y:")]
        nfloat AngleForPointWithX(nfloat x, nfloat y);

        // -(CGFloat)distanceToCenterWithX:(CGFloat)x y:(CGFloat)y __attribute__((warn_unused_result("")));
        [Export("distanceToCenterWithX:y:")]
        nfloat DistanceToCenterWithX(nfloat x, nfloat y);

        // -(CGPoint)getMarkerPositionWithHighlight:(ChartHighlight * _Nonnull)highlight __attribute__((warn_unused_result("")));
        [Export("getMarkerPositionWithHighlight:")]
        CGPoint GetMarkerPositionWithHighlight(ChartHighlight highlight);

        // -(BOOL)needsHighlightWithIndex:(NSInteger)index __attribute__((warn_unused_result("")));
        [Export("needsHighlightWithIndex:")]
        bool NeedsHighlightWithIndex(nint index);

        // @property (nonatomic, strong) ChartXAxis * _Nonnull xAxis;
        [Export("xAxis", ArgumentSemantic.Strong)]
        ChartXAxis XAxis { get; set; }

        // -(NSInteger)indexForAngle:(CGFloat)angle __attribute__((warn_unused_result("")));
        [Export("indexForAngle:")]
        nint IndexForAngle(nfloat angle);

        // -(NSInteger)dataSetIndexForIndex:(double)xValue __attribute__((warn_unused_result("")));
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

        // @property (nonatomic) CGFloat sliceTextDrawingThreshold;
        [Export("sliceTextDrawingThreshold")]
        nfloat SliceTextDrawingThreshold { get; set; }
    }

    // @interface PieRadarChartHighlighter : ChartHighlighter
    [BaseType(typeof(ChartHighlighter))]
    interface PieRadarChartHighlighter
    {
        // -(ChartHighlight * _Nullable)getHighlightWithX:(CGFloat)x y:(CGFloat)y __attribute__((warn_unused_result("")));
        [Export("getHighlightWithX:y:")]
        [return: NullAllowed]
        ChartHighlight GetHighlightWithX(nfloat x, nfloat y);

        // -(ChartHighlight * _Nullable)closestHighlightWithIndex:(NSInteger)index x:(CGFloat)x y:(CGFloat)y __attribute__((warn_unused_result("")));
        [Export("closestHighlightWithIndex:x:y:")]
        [return: NullAllowed]
        ChartHighlight ClosestHighlightWithIndex(nint index, nfloat x, nfloat y);

        // -(instancetype _Nonnull)initWithChart:(id<ChartDataProvider> _Nonnull)chart __attribute__((objc_designated_initializer));
        [Export("initWithChart:")]
        [DesignatedInitializer]
        NativeHandle Constructor(IChartDataProvider chart);
    }

    // @interface PieChartHighlighter : PieRadarChartHighlighter
    [BaseType(typeof(PieRadarChartHighlighter))]
    interface PieChartHighlighter
    {
        // -(ChartHighlight * _Nullable)closestHighlightWithIndex:(NSInteger)index x:(CGFloat)x y:(CGFloat)y __attribute__((warn_unused_result("")));
        [Export("closestHighlightWithIndex:x:y:")]
        [return: NullAllowed]
        ChartHighlight ClosestHighlightWithIndex(nint index, nfloat x, nfloat y);

        // -(instancetype _Nonnull)initWithChart:(id<ChartDataProvider> _Nonnull)chart __attribute__((objc_designated_initializer));
        [Export("initWithChart:")]
        [DesignatedInitializer]
        NativeHandle Constructor(IChartDataProvider chart);
    }

    // @interface RadarChartData : ChartData
    [BaseType(typeof(ChartData), Name = "_TtC8DGCharts14RadarChartData")]
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

        // -(instancetype _Nonnull)initWithDataSets:(NSArray<id<ChartDataSetProtocol>> * _Nonnull)dataSets __attribute__((objc_designated_initializer));
        [Export("initWithDataSets:")]
        [DesignatedInitializer]
        NativeHandle Constructor(IChartDataSetProtocol[] dataSets);

        // -(ChartDataEntry * _Nullable)entryFor:(ChartHighlight * _Nonnull)highlight __attribute__((warn_unused_result("")));
        [Export("entryFor:")]
        [return: NullAllowed]
        ChartDataEntry EntryFor(ChartHighlight highlight);
    }

    // @interface RadarChartDataEntry : ChartDataEntry
    [BaseType(typeof(ChartDataEntry), Name = "_TtC8DGCharts19RadarChartDataEntry")]
    interface RadarChartDataEntry
    {
        // -(instancetype _Nonnull)initWithValue:(double)value __attribute__((objc_designated_initializer));
        [Export("initWithValue:")]
        [DesignatedInitializer]
        NativeHandle Constructor(double value);

        // -(instancetype _Nonnull)initWithValue:(double)value data:(id _Nullable)data;
        [Export("initWithValue:data:")]
        NativeHandle Constructor(double value, [NullAllowed] NSObject data);

        // @property (nonatomic) double value;
        [Export("value")]
        double Value { get; set; }
    }

    interface IRadarChartDataSetProtocol { }

    // @protocol RadarChartDataSetProtocol <LineRadarChartDataSetProtocol>
    [Protocol(Name = "_TtP8DGCharts25RadarChartDataSetProtocol_"), Model]
    [BaseType(typeof(NSObject))]
    interface RadarChartDataSetProtocol : LineRadarChartDataSetProtocol
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

    // @interface RadarChartDataSet : LineRadarChartDataSet <RadarChartDataSetProtocol>
    [BaseType(typeof(LineRadarChartDataSet), Name = "_TtC8DGCharts17RadarChartDataSet")]
    interface RadarChartDataSet : RadarChartDataSetProtocol
    {
        // -(instancetype _Nonnull)initWithEntries:(NSArray<ChartDataEntry *> * _Nonnull)entries label:(NSString * _Nonnull)label __attribute__((objc_designated_initializer));
        [Export("initWithEntries:label:")]
        [DesignatedInitializer]
        NativeHandle Constructor(ChartDataEntry[] entries, string label);

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
    [BaseType(typeof(LineRadarChartRenderer), Name = "_TtC8DGCharts18RadarChartRenderer")]
    interface RadarChartRenderer
    {
        // @property (nonatomic, weak) RadarChartView * _Nullable chart;
        [NullAllowed, Export("chart", ArgumentSemantic.Weak)]
        RadarChartView Chart { get; set; }

        // -(instancetype _Nonnull)initWithChart:(RadarChartView * _Nonnull)chart animator:(ChartAnimator * _Nonnull)animator viewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler __attribute__((objc_designated_initializer));
        [Export("initWithChart:animator:viewPortHandler:")]
        [DesignatedInitializer]
        NativeHandle Constructor(RadarChartView chart, ChartAnimator animator, ChartViewPortHandler viewPortHandler);

        // -(void)drawDataWithContext:(CGContextRef _Nonnull)context;
        [Export("drawDataWithContext:")]
        void DrawDataWithContext(CGContext context);

        // -(void)drawValuesWithContext:(CGContextRef _Nonnull)context;
        [Export("drawValuesWithContext:")]
        void DrawValuesWithContext(CGContext context);

        // -(void)drawExtrasWithContext:(CGContextRef _Nonnull)context;
        [Export("drawExtrasWithContext:")]
        void DrawExtrasWithContext(CGContext context);

        // -(void)drawWebWithContext:(CGContextRef _Nonnull)context;
        [Export("drawWebWithContext:")]
        void DrawWebWithContext(CGContext context);

        // -(void)drawHighlightedWithContext:(CGContextRef _Nonnull)context indices:(NSArray<ChartHighlight *> * _Nonnull)indices;
        [Export("drawHighlightedWithContext:indices:")]
        void DrawHighlightedWithContext(CGContext context, ChartHighlight[] indices);
    }

    // @interface RadarChartView : PieRadarChartViewBase
    [BaseType(typeof(PieRadarChartViewBase), Name = "_TtC8DGCharts14RadarChartView")]
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
        NativeHandle Constructor(CGRect frame);

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

        // -(NSInteger)indexForAngle:(CGFloat)angle __attribute__((warn_unused_result("")));
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
        // -(ChartHighlight * _Nullable)closestHighlightWithIndex:(NSInteger)index x:(CGFloat)x y:(CGFloat)y __attribute__((warn_unused_result("")));
        [Export("closestHighlightWithIndex:x:y:")]
        [return: NullAllowed]
        ChartHighlight ClosestHighlightWithIndex(nint index, nfloat x, nfloat y);

        // -(instancetype _Nonnull)initWithChart:(id<ChartDataProvider> _Nonnull)chart __attribute__((objc_designated_initializer));
        [Export("initWithChart:")]
        [DesignatedInitializer]
        NativeHandle Constructor(IChartDataProvider chart);
    }

    // @interface ChartRadialGradientFill : NSObject <ChartFill>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ChartRadialGradientFill : ChartFill
    {
        // @property (readonly, nonatomic) CGGradientRef _Nonnull gradient;
        [Export("gradient")]
        CGGradient Gradient { get; }

        // @property (readonly, nonatomic) CGPoint startOffsetPercent;
        [Export("startOffsetPercent")]
        CGPoint StartOffsetPercent { get; }

        // @property (readonly, nonatomic) CGPoint endOffsetPercent;
        [Export("endOffsetPercent")]
        CGPoint EndOffsetPercent { get; }

        // @property (readonly, nonatomic) CGFloat startRadiusPercent;
        [Export("startRadiusPercent")]
        nfloat StartRadiusPercent { get; }

        // @property (readonly, nonatomic) CGFloat endRadiusPercent;
        [Export("endRadiusPercent")]
        nfloat EndRadiusPercent { get; }

        // -(instancetype _Nonnull)initWithGradient:(CGGradientRef _Nonnull)gradient startOffsetPercent:(CGPoint)startOffsetPercent endOffsetPercent:(CGPoint)endOffsetPercent startRadiusPercent:(CGFloat)startRadiusPercent endRadiusPercent:(CGFloat)endRadiusPercent __attribute__((objc_designated_initializer));
        [Export("initWithGradient:startOffsetPercent:endOffsetPercent:startRadiusPercent:endRadiusPercent:")]
        [DesignatedInitializer]
        NativeHandle Constructor(CGGradient gradient, CGPoint startOffsetPercent, CGPoint endOffsetPercent, nfloat startRadiusPercent, nfloat endRadiusPercent);

        // -(instancetype _Nonnull)initWithGradient:(CGGradientRef _Nonnull)gradient;
        [Export("initWithGradient:")]
        NativeHandle Constructor(CGGradient gradient);

        // -(void)fillPathWithContext:(CGContextRef _Nonnull)context rect:(CGRect)rect;
        [Export("fillPathWithContext:rect:")]
        void FillPathWithContext(CGContext context, CGRect rect);
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
        NativeHandle Constructor(double from, double to);

        // -(BOOL)contains:(double)value __attribute__((warn_unused_result("")));
        [Export("contains:")]
        bool Contains(double value);

        // -(BOOL)isLarger:(double)value __attribute__((warn_unused_result("")));
        [Export("isLarger:")]
        bool IsLarger(double value);

        // -(BOOL)isSmaller:(double)value __attribute__((warn_unused_result("")));
        [Export("isSmaller:")]
        bool IsSmaller(double value);
    }

    // @interface ScatterChartData : BarLineScatterCandleBubbleChartData
    [BaseType(typeof(BarLineScatterCandleBubbleChartData), Name = "_TtC8DGCharts16ScatterChartData")]
    interface ScatterChartData
    {
        // -(instancetype _Nonnull)initWithDataSets:(NSArray<id<ChartDataSetProtocol>> * _Nonnull)dataSets __attribute__((objc_designated_initializer));
        [Export("initWithDataSets:")]
        [DesignatedInitializer]
        NativeHandle Constructor(IChartDataSetProtocol[] dataSets);

        // -(CGFloat)getGreatestShapeSize __attribute__((warn_unused_result("")));
        [Export("getGreatestShapeSize")]
        nfloat GetGreatestShapeSize();
    }

    interface IScatterChartDataSetProtocol { }

    // @protocol ScatterChartDataSetProtocol <LineScatterCandleRadarChartDataSetProtocol>
    [Protocol(Name = "_TtP8DGCharts27ScatterChartDataSetProtocol_"), Model]
    [BaseType(typeof(NSObject))]
    interface ScatterChartDataSetProtocol : LineScatterCandleRadarChartDataSetProtocol
    {
        // @required @property (readonly, nonatomic) CGFloat scatterShapeSize;
        [Abstract]
        [Export("scatterShapeSize")]
        nfloat ScatterShapeSize { get; set; }

        // @required @property (readonly, nonatomic) CGFloat scatterShapeHoleRadius;
        [Abstract]
        [Export("scatterShapeHoleRadius")]
        nfloat ScatterShapeHoleRadius { get; set; }

        // @required @property (readonly, nonatomic, strong) UIColor * _Nullable scatterShapeHoleColor;
        [Abstract]
        [NullAllowed, Export("scatterShapeHoleColor", ArgumentSemantic.Strong)]
        UIColor ScatterShapeHoleColor { get; set; }

        // @required @property (readonly, nonatomic, strong) id<ShapeRenderer> _Nullable shapeRenderer;
        [Abstract]
        [NullAllowed, Export("shapeRenderer", ArgumentSemantic.Strong)]
        IShapeRenderer ShapeRenderer { get; set; }
    }

    // @interface ScatterChartDataSet : LineScatterCandleRadarChartDataSet <ScatterChartDataSetProtocol>
    [BaseType(typeof(LineScatterCandleRadarChartDataSet), Name = "_TtC8DGCharts19ScatterChartDataSet")]
    interface ScatterChartDataSet : ScatterChartDataSetProtocol
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

        // @property (nonatomic, strong) id<ShapeRenderer> _Nullable shapeRenderer;
        [NullAllowed, Export("shapeRenderer", ArgumentSemantic.Strong)]
        IShapeRenderer ShapeRenderer { get; set; }

        // +(id<ShapeRenderer> _Nonnull)rendererForShape:(enum ScatterShape)shape __attribute__((warn_unused_result("")));
        [Static]
        [Export("rendererForShape:")]
        IShapeRenderer RendererForShape(ScatterShape shape);

        // -(instancetype _Nonnull)initWithEntries:(NSArray<ChartDataEntry *> * _Nonnull)entries label:(NSString * _Nonnull)label __attribute__((objc_designated_initializer));
        [Export("initWithEntries:label:")]
        [DesignatedInitializer]
        NativeHandle Constructor(ChartDataEntry[] entries, string label);
    }

    // @interface ScatterChartRenderer : LineScatterCandleRadarChartRenderer
    [BaseType(typeof(LineScatterCandleRadarChartRenderer), Name = "_TtC8DGCharts20ScatterChartRenderer")]
    interface ScatterChartRenderer
    {
        // @property (nonatomic, weak) id<ScatterChartDataProvider> _Nullable dataProvider;
        [NullAllowed, Export("dataProvider", ArgumentSemantic.Weak)]
        IScatterChartDataProvider DataProvider { get; set; }

        // -(instancetype _Nonnull)initWithDataProvider:(id<ScatterChartDataProvider> _Nonnull)dataProvider animator:(ChartAnimator * _Nonnull)animator viewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler __attribute__((objc_designated_initializer));
        [Export("initWithDataProvider:animator:viewPortHandler:")]
        [DesignatedInitializer]
        NativeHandle Constructor(IScatterChartDataProvider dataProvider, ChartAnimator animator, ChartViewPortHandler viewPortHandler);

        // -(void)drawDataWithContext:(CGContextRef _Nonnull)context;
        [Export("drawDataWithContext:")]
        void DrawDataWithContext(CGContext context);

        // -(void)drawDataSetWithContext:(CGContextRef _Nonnull)context dataSet:(id<ScatterChartDataSetProtocol> _Nonnull)dataSet;
        [Export("drawDataSetWithContext:dataSet:")]
        void DrawDataSetWithContext(CGContext context, IScatterChartDataSetProtocol dataSet);

        // -(void)drawValuesWithContext:(CGContextRef _Nonnull)context;
        [Export("drawValuesWithContext:")]
        void DrawValuesWithContext(CGContext context);

        // -(void)drawExtrasWithContext:(CGContextRef _Nonnull)context;
        [Export("drawExtrasWithContext:")]
        void DrawExtrasWithContext(CGContext context);

        // -(void)drawHighlightedWithContext:(CGContextRef _Nonnull)context indices:(NSArray<ChartHighlight *> * _Nonnull)indices;
        [Export("drawHighlightedWithContext:indices:")]
        void DrawHighlightedWithContext(CGContext context, ChartHighlight[] indices);
    }

    // @interface ScatterChartView : BarLineChartViewBase <ScatterChartDataProvider>
    [BaseType(typeof(BarLineChartViewBase), Name = "_TtC8DGCharts16ScatterChartView")]
    interface ScatterChartView : ScatterChartDataProvider
    {
        // @property (readonly, nonatomic, strong) ScatterChartData * _Nullable scatterData;
        [NullAllowed, Export("scatterData", ArgumentSemantic.Strong)]
        ScatterChartData ScatterData { get; }

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        NativeHandle Constructor(CGRect frame);
    }

    // @interface SquareShapeRenderer : NSObject <ShapeRenderer>
    [BaseType(typeof(NSObject), Name = "_TtC8DGCharts19SquareShapeRenderer")]
    interface SquareShapeRenderer : ShapeRenderer
    {
        // -(void)renderShapeWithContext:(CGContextRef _Nonnull)context dataSet:(id<ScatterChartDataSetProtocol> _Nonnull)dataSet viewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler point:(CGPoint)point color:(UIColor * _Nonnull)color;
        [Export("renderShapeWithContext:dataSet:viewPortHandler:point:color:")]
        void RenderShapeWithContext(CGContext context, IScatterChartDataSetProtocol dataSet, ChartViewPortHandler viewPortHandler, CGPoint point, UIColor color);
    }

    // @interface ChartTransformer : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ChartTransformer
    {
        // -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler __attribute__((objc_designated_initializer));
        [Export("initWithViewPortHandler:")]
        [DesignatedInitializer]
        NativeHandle Constructor(ChartViewPortHandler viewPortHandler);

        // -(void)prepareMatrixValuePxWithChartXMin:(double)chartXMin deltaX:(CGFloat)deltaX deltaY:(CGFloat)deltaY chartYMin:(double)chartYMin;
        [Export("prepareMatrixValuePxWithChartXMin:deltaX:deltaY:chartYMin:")]
        void PrepareMatrixValuePxWithChartXMin(double chartXMin, nfloat deltaX, nfloat deltaY, double chartYMin);

        // -(void)prepareMatrixOffsetWithInverted:(BOOL)inverted;
        [Export("prepareMatrixOffsetWithInverted:")]
        void PrepareMatrixOffsetWithInverted(bool inverted);

        // -(CGPoint)pixelForValuesWithX:(double)x y:(double)y __attribute__((warn_unused_result("")));
        [Export("pixelForValuesWithX:y:")]
        CGPoint PixelForValuesWithX(double x, double y);

        // -(CGPoint)valueForTouchPoint:(CGPoint)point __attribute__((warn_unused_result("")));
        [Export("valueForTouchPoint:")]
        CGPoint ValueForTouchPoint(CGPoint point);

        // -(CGPoint)valueForTouchPointWithX:(CGFloat)x y:(CGFloat)y __attribute__((warn_unused_result("")));
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
        NativeHandle Constructor(ChartViewPortHandler viewPortHandler);
    }

    // @interface TriangleShapeRenderer : NSObject <ShapeRenderer>
    [BaseType(typeof(NSObject), Name = "_TtC8DGCharts21TriangleShapeRenderer")]
    interface TriangleShapeRenderer : ShapeRenderer
    {
        // -(void)renderShapeWithContext:(CGContextRef _Nonnull)context dataSet:(id<ScatterChartDataSetProtocol> _Nonnull)dataSet viewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler point:(CGPoint)point color:(UIColor * _Nonnull)color;
        [Export("renderShapeWithContext:dataSet:viewPortHandler:point:color:")]
        void RenderShapeWithContext(CGContext context, IScatterChartDataSetProtocol dataSet, ChartViewPortHandler viewPortHandler, CGPoint point, UIColor color);
    }

    // @interface ChartViewPortHandler : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ChartViewPortHandler
    {
        // @property (readonly, nonatomic) CGAffineTransform touchMatrix;
        [Export("touchMatrix")]
        CGAffineTransform TouchMatrix { get; }

        // @property (readonly, nonatomic) CGRect contentRect;
        [Export("contentRect")]
        CGRect ContentRect { get; }

        // @property (readonly, nonatomic) CGFloat chartWidth;
        [Export("chartWidth")]
        nfloat ChartWidth { get; }

        // @property (readonly, nonatomic) CGFloat chartHeight;
        [Export("chartHeight")]
        nfloat ChartHeight { get; }

        // @property (readonly, nonatomic) CGFloat minScaleY;
        [Export("minScaleY")]
        nfloat MinScaleY { get; }

        // @property (readonly, nonatomic) CGFloat maxScaleY;
        [Export("maxScaleY")]
        nfloat MaxScaleY { get; }

        // @property (readonly, nonatomic) CGFloat minScaleX;
        [Export("minScaleX")]
        nfloat MinScaleX { get; }

        // @property (readonly, nonatomic) CGFloat maxScaleX;
        [Export("maxScaleX")]
        nfloat MaxScaleX { get; }

        // @property (readonly, nonatomic) CGFloat scaleX;
        [Export("scaleX")]
        nfloat ScaleX { get; }

        // @property (readonly, nonatomic) CGFloat scaleY;
        [Export("scaleY")]
        nfloat ScaleY { get; }

        // @property (readonly, nonatomic) CGFloat transX;
        [Export("transX")]
        nfloat TransX { get; }

        // @property (readonly, nonatomic) CGFloat transY;
        [Export("transY")]
        nfloat TransY { get; }

        // -(instancetype _Nonnull)initWithWidth:(CGFloat)width height:(CGFloat)height __attribute__((objc_designated_initializer));
        [Export("initWithWidth:height:")]
        [DesignatedInitializer]
        NativeHandle Constructor(nfloat width, nfloat height);

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

        // @property (readonly, nonatomic) CGPoint contentCenter;
        [Export("contentCenter")]
        CGPoint ContentCenter { get; }

        // -(CGAffineTransform)zoomWithScaleX:(CGFloat)scaleX scaleY:(CGFloat)scaleY __attribute__((warn_unused_result("")));
        [Export("zoomWithScaleX:scaleY:")]
        CGAffineTransform ZoomWithScaleX(nfloat scaleX, nfloat scaleY);

        // -(CGAffineTransform)zoomWithScaleX:(CGFloat)scaleX scaleY:(CGFloat)scaleY x:(CGFloat)x y:(CGFloat)y __attribute__((warn_unused_result("")));
        [Export("zoomWithScaleX:scaleY:x:y:")]
        CGAffineTransform ZoomWithScaleX(nfloat scaleX, nfloat scaleY, nfloat x, nfloat y);

        // -(CGAffineTransform)zoomInX:(CGFloat)x y:(CGFloat)y __attribute__((warn_unused_result("")));
        [Export("zoomInX:y:")]
        CGAffineTransform ZoomInX(nfloat x, nfloat y);

        // -(CGAffineTransform)zoomOutWithX:(CGFloat)x y:(CGFloat)y __attribute__((warn_unused_result("")));
        [Export("zoomOutWithX:y:")]
        CGAffineTransform ZoomOutWithX(nfloat x, nfloat y);

        // -(CGAffineTransform)resetZoom __attribute__((warn_unused_result("")));
        [Export("resetZoom")]
        CGAffineTransform ResetZoom();

        // -(CGAffineTransform)setZoomWithScaleX:(CGFloat)scaleX scaleY:(CGFloat)scaleY __attribute__((warn_unused_result("")));
        [Export("setZoomWithScaleX:scaleY:")]
        CGAffineTransform SetZoomWithScaleX(nfloat scaleX, nfloat scaleY);

        // -(CGAffineTransform)setZoomWithScaleX:(CGFloat)scaleX scaleY:(CGFloat)scaleY x:(CGFloat)x y:(CGFloat)y __attribute__((warn_unused_result("")));
        [Export("setZoomWithScaleX:scaleY:x:y:")]
        CGAffineTransform SetZoomWithScaleX(nfloat scaleX, nfloat scaleY, nfloat x, nfloat y);

        // -(CGAffineTransform)fitScreen __attribute__((warn_unused_result("")));
        [Export("fitScreen")]
        CGAffineTransform FitScreen();

        // -(CGAffineTransform)translateWithPt:(CGPoint)pt __attribute__((warn_unused_result("")));
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

        // -(BOOL)isInBoundsX:(CGFloat)x __attribute__((warn_unused_result("")));
        [Export("isInBoundsX:")]
        bool IsInBoundsX(nfloat x);

        // -(BOOL)isInBoundsY:(CGFloat)y __attribute__((warn_unused_result("")));
        [Export("isInBoundsY:")]
        bool IsInBoundsY(nfloat y);

        // -(BOOL)isInBoundsWithPoint:(CGPoint)point __attribute__((warn_unused_result("")));
        [Export("isInBoundsWithPoint:")]
        bool IsInBoundsWithPoint(CGPoint point);

        // -(BOOL)isInBoundsWithX:(CGFloat)x y:(CGFloat)y __attribute__((warn_unused_result("")));
        [Export("isInBoundsWithX:y:")]
        bool IsInBoundsWithX(nfloat x, nfloat y);

        // -(BOOL)isInBoundsLeft:(CGFloat)x __attribute__((warn_unused_result("")));
        [Export("isInBoundsLeft:")]
        bool IsInBoundsLeft(nfloat x);

        // -(BOOL)isInBoundsRight:(CGFloat)x __attribute__((warn_unused_result("")));
        [Export("isInBoundsRight:")]
        bool IsInBoundsRight(nfloat x);

        // -(BOOL)isInBoundsTop:(CGFloat)y __attribute__((warn_unused_result("")));
        [Export("isInBoundsTop:")]
        bool IsInBoundsTop(nfloat y);

        // -(BOOL)isInBoundsBottom:(CGFloat)y __attribute__((warn_unused_result("")));
        [Export("isInBoundsBottom:")]
        bool IsInBoundsBottom(nfloat y);

        // -(BOOL)isIntersectingLineFrom:(CGPoint)startPoint to:(CGPoint)endPoint __attribute__((warn_unused_result("")));
        [Export("isIntersectingLineFrom:to:")]
        bool IsIntersectingLineFrom(CGPoint startPoint, CGPoint endPoint);

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

    // @interface ChartXAxisRenderer : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ChartXAxisRenderer
    {
        // @property (readonly, nonatomic, strong) ChartViewPortHandler * _Nonnull viewPortHandler;
        [Export("viewPortHandler", ArgumentSemantic.Strong)]
        ChartViewPortHandler ViewPortHandler { get; }

        // @property (readonly, nonatomic, strong) ChartXAxis * _Nonnull axis;
        [Export("axis", ArgumentSemantic.Strong)]
        ChartXAxis Axis { get; }

        // @property (readonly, nonatomic, strong) ChartTransformer * _Nullable transformer;
        [NullAllowed, Export("transformer", ArgumentSemantic.Strong)]
        ChartTransformer Transformer { get; }

        // -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler axis:(ChartXAxis * _Nonnull)axis transformer:(ChartTransformer * _Nullable)transformer __attribute__((objc_designated_initializer));
        [Export("initWithViewPortHandler:axis:transformer:")]
        [DesignatedInitializer]
        NativeHandle Constructor(ChartViewPortHandler viewPortHandler, ChartXAxis axis, [NullAllowed] ChartTransformer transformer);

        // -(void)computeSize;
        [Export("computeSize")]
        void ComputeSize();

        // -(void)drawLabelsWithContext:(CGContextRef _Nonnull)context pos:(CGFloat)pos anchor:(CGPoint)anchor;
        [Export("drawLabelsWithContext:pos:anchor:")]
        void DrawLabelsWithContext(CGContext context, nfloat pos, CGPoint anchor);

        // -(void)drawLabelWithContext:(CGContextRef _Nonnull)context formattedLabel:(NSString * _Nonnull)formattedLabel x:(CGFloat)x y:(CGFloat)y attributes:(NSDictionary<NSAttributedStringKey,id> * _Nonnull)attributes constrainedTo:(CGSize)size anchor:(CGPoint)anchor angleRadians:(CGFloat)angleRadians;
        [Export("drawLabelWithContext:formattedLabel:x:y:attributes:constrainedTo:anchor:angleRadians:")]
        void DrawLabelWithContext(CGContext context, string formattedLabel, nfloat x, nfloat y, NSDictionary<NSString, NSObject> attributes, CGSize size, CGPoint anchor, nfloat angleRadians);

        // @property (readonly, nonatomic) CGRect gridClippingRect;
        [Export("gridClippingRect")]
        CGRect GridClippingRect { get; }

        // -(void)drawGridLineWithContext:(CGContextRef _Nonnull)context x:(CGFloat)x y:(CGFloat)y;
        [Export("drawGridLineWithContext:x:y:")]
        void DrawGridLineWithContext(CGContext context, nfloat x, nfloat y);

        // -(void)renderLimitLineLineWithContext:(CGContextRef _Nonnull)context limitLine:(ChartLimitLine * _Nonnull)limitLine position:(CGPoint)position;
        [Export("renderLimitLineLineWithContext:limitLine:position:")]
        void RenderLimitLineLineWithContext(CGContext context, ChartLimitLine limitLine, CGPoint position);

        // -(void)renderLimitLineLabelWithContext:(CGContextRef _Nonnull)context limitLine:(ChartLimitLine * _Nonnull)limitLine position:(CGPoint)position yOffset:(CGFloat)yOffset;
        [Export("renderLimitLineLabelWithContext:limitLine:position:yOffset:")]
        void RenderLimitLineLabelWithContext(CGContext context, ChartLimitLine limitLine, CGPoint position, nfloat yOffset);
    }

    // @interface XAxisRendererHorizontalBarChart : ChartXAxisRenderer
    [BaseType(typeof(ChartXAxisRenderer), Name = "_TtC8DGCharts31XAxisRendererHorizontalBarChart")]
    interface XAxisRendererHorizontalBarChart
    {
        // -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler axis:(ChartXAxis * _Nonnull)axis transformer:(ChartTransformer * _Nullable)transformer chart:(BarChartView * _Nonnull)chart __attribute__((objc_designated_initializer));
        [Export("initWithViewPortHandler:axis:transformer:chart:")]
        [DesignatedInitializer]
        NativeHandle Constructor(ChartViewPortHandler viewPortHandler, ChartXAxis axis, [NullAllowed] ChartTransformer transformer, BarChartView chart);

        // -(void)computeSize;
        [Export("computeSize")]
        void ComputeSize();

        // -(void)drawLabelsWithContext:(CGContextRef _Nonnull)context pos:(CGFloat)pos anchor:(CGPoint)anchor;
        [Export("drawLabelsWithContext:pos:anchor:")]
        void DrawLabelsWithContext(CGContext context, nfloat pos, CGPoint anchor);

        // -(void)drawLabelWithContext:(CGContextRef _Nonnull)context formattedLabel:(NSString * _Nonnull)formattedLabel x:(CGFloat)x y:(CGFloat)y attributes:(NSDictionary<NSAttributedStringKey,id> * _Nonnull)attributes anchor:(CGPoint)anchor angleRadians:(CGFloat)angleRadians;
        [Export("drawLabelWithContext:formattedLabel:x:y:attributes:anchor:angleRadians:")]
        void DrawLabelWithContext(CGContext context, string formattedLabel, nfloat x, nfloat y, NSDictionary<NSString, NSObject> attributes, CGPoint anchor, nfloat angleRadians);

        // @property (readonly, nonatomic) CGRect gridClippingRect;
        [Export("gridClippingRect")]
        CGRect GridClippingRect { get; }

        // -(void)drawGridLineWithContext:(CGContextRef _Nonnull)context x:(CGFloat)x y:(CGFloat)y;
        [Export("drawGridLineWithContext:x:y:")]
        void DrawGridLineWithContext(CGContext context, nfloat x, nfloat y);
    }

    // @interface XAxisRendererRadarChart : ChartXAxisRenderer
    [BaseType(typeof(ChartXAxisRenderer), Name = "_TtC8DGCharts23XAxisRendererRadarChart")]
    interface XAxisRendererRadarChart
    {
        // @property (nonatomic, weak) RadarChartView * _Nullable chart;
        [NullAllowed, Export("chart", ArgumentSemantic.Weak)]
        RadarChartView Chart { get; set; }

        // -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler axis:(ChartXAxis * _Nonnull)axis chart:(RadarChartView * _Nonnull)chart __attribute__((objc_designated_initializer));
        [Export("initWithViewPortHandler:axis:chart:")]
        [DesignatedInitializer]
        NativeHandle Constructor(ChartViewPortHandler viewPortHandler, ChartXAxis axis, RadarChartView chart);

        // -(void)drawLabelWithContext:(CGContextRef _Nonnull)context formattedLabel:(NSString * _Nonnull)formattedLabel x:(CGFloat)x y:(CGFloat)y attributes:(NSDictionary<NSAttributedStringKey,id> * _Nonnull)attributes anchor:(CGPoint)anchor angleRadians:(CGFloat)angleRadians;
        [Export("drawLabelWithContext:formattedLabel:x:y:attributes:anchor:angleRadians:")]
        void DrawLabelWithContext(CGContext context, string formattedLabel, nfloat x, nfloat y, NSDictionary<NSString, NSObject> attributes, CGPoint anchor, nfloat angleRadians);
    }

    // @interface XShapeRenderer : NSObject <ShapeRenderer>
    [BaseType(typeof(NSObject), Name = "_TtC8DGCharts14XShapeRenderer")]
    interface XShapeRenderer : ShapeRenderer
    {
        // -(void)renderShapeWithContext:(CGContextRef _Nonnull)context dataSet:(id<ScatterChartDataSetProtocol> _Nonnull)dataSet viewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler point:(CGPoint)point color:(UIColor * _Nonnull)color;
        [Export("renderShapeWithContext:dataSet:viewPortHandler:point:color:")]
        void RenderShapeWithContext(CGContext context, IScatterChartDataSetProtocol dataSet, ChartViewPortHandler viewPortHandler, CGPoint point, UIColor color);
    }

    // @interface ChartYAxis : ChartAxisBase
    [BaseType(typeof(ChartAxisBase))]
    interface ChartYAxis
    {
        // @property (nonatomic) BOOL drawBottomYLabelEntryEnabled;
        [Export("drawBottomYLabelEntryEnabled")]
        bool DrawBottomYLabelEntryEnabled { get; set; }

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

        // @property (nonatomic) NSTextAlignment labelAlignment;
        [Export("labelAlignment", ArgumentSemantic.Assign)]
        UITextAlignment LabelAlignment { get; set; }

        // @property (nonatomic) CGFloat labelXOffset;
        [Export("labelXOffset")]
        nfloat LabelXOffset { get; set; }

        // @property (nonatomic) CGFloat minWidth;
        [Export("minWidth")]
        nfloat MinWidth { get; set; }

        // @property (nonatomic) CGFloat maxWidth;
        [Export("maxWidth")]
        nfloat MaxWidth { get; set; }

        // -(instancetype _Nonnull)initWithPosition:(enum AxisDependency)position __attribute__((objc_designated_initializer));
        [Export("initWithPosition:")]
        [DesignatedInitializer]
        NativeHandle Constructor(AxisDependency position);

        // @property (readonly, nonatomic) enum AxisDependency axisDependency;
        [Export("axisDependency")]
        AxisDependency AxisDependency { get; }

        // -(CGSize)requiredSize __attribute__((warn_unused_result("")));
        [Export("requiredSize")]
        CGSize RequiredSize { get; }

        // -(CGFloat)getRequiredHeightSpace __attribute__((warn_unused_result("")));
        [Export("getRequiredHeightSpace")]
        nfloat GetRequiredHeightSpace();

        // @property (readonly, nonatomic) BOOL needsOffset;
        [Export("needsOffset")]
        bool NeedsOffset { get; }

        // @property (readonly, nonatomic) BOOL isInverted;
        [Export("isInverted")]
        bool IsInverted { get; }

        // -(void)calculateWithMin:(double)dataMin max:(double)dataMax;
        [Export("calculateWithMin:max:")]
        void CalculateWithMin(double dataMin, double dataMax);

        // @property (readonly, nonatomic) BOOL isDrawBottomYLabelEntryEnabled;
        [Export("isDrawBottomYLabelEntryEnabled")]
        bool IsDrawBottomYLabelEntryEnabled { get; }

        // @property (readonly, nonatomic) BOOL isDrawTopYLabelEntryEnabled;
        [Export("isDrawTopYLabelEntryEnabled")]
        bool IsDrawTopYLabelEntryEnabled { get; }
    }

    // @interface ChartYAxisRenderer : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ChartYAxisRenderer
    {
        // @property (readonly, nonatomic, strong) ChartViewPortHandler * _Nonnull viewPortHandler;
        [Export("viewPortHandler", ArgumentSemantic.Strong)]
        ChartViewPortHandler ViewPortHandler { get; }

        // @property (readonly, nonatomic, strong) ChartYAxis * _Nonnull axis;
        [Export("axis", ArgumentSemantic.Strong)]
        ChartYAxis Axis { get; }

        // @property (readonly, nonatomic, strong) ChartTransformer * _Nullable transformer;
        [NullAllowed, Export("transformer", ArgumentSemantic.Strong)]
        ChartTransformer Transformer { get; }

        // -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler axis:(ChartYAxis * _Nonnull)axis transformer:(ChartTransformer * _Nullable)transformer __attribute__((objc_designated_initializer));
        [Export("initWithViewPortHandler:axis:transformer:")]
        [DesignatedInitializer]
        NativeHandle Constructor(ChartViewPortHandler viewPortHandler, ChartYAxis axis, [NullAllowed] ChartTransformer transformer);

        // @property (readonly, nonatomic) CGRect gridClippingRect;
        [Export("gridClippingRect")]
        CGRect GridClippingRect { get; }

        // -(void)drawGridLineWithContext:(CGContextRef _Nonnull)context position:(CGPoint)position;
        [Export("drawGridLineWithContext:position:")]
        void DrawGridLineWithContext(CGContext context, CGPoint position);

        // -(NSArray<NSValue *> * _Nonnull)transformedPositions __attribute__((warn_unused_result("")));
        [Export("transformedPositions")]
        NSValue[] TransformedPositions { get; }

        // -(void)drawZeroLineWithContext:(CGContextRef _Nonnull)context;
        [Export("drawZeroLineWithContext:")]
        void DrawZeroLineWithContext(CGContext context);

        // -(void)computeAxisWithMin:(double)min max:(double)max inverted:(BOOL)inverted;
        [Export("computeAxisWithMin:max:inverted:")]
        void ComputeAxisWithMin(double min, double max, bool inverted);

        // -(void)computeAxisValuesWithMin:(double)min max:(double)max;
        [Export("computeAxisValuesWithMin:max:")]
        void ComputeAxisValuesWithMin(double min, double max);
    }

    // @interface YAxisRendererHorizontalBarChart : ChartYAxisRenderer
    [BaseType(typeof(ChartYAxisRenderer), Name = "_TtC8DGCharts31YAxisRendererHorizontalBarChart")]
    interface YAxisRendererHorizontalBarChart
    {
        // -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler axis:(ChartYAxis * _Nonnull)axis transformer:(ChartTransformer * _Nullable)transformer __attribute__((objc_designated_initializer));
        [Export("initWithViewPortHandler:axis:transformer:")]
        [DesignatedInitializer]
        NativeHandle Constructor(ChartViewPortHandler viewPortHandler, ChartYAxis axis, [NullAllowed] ChartTransformer transformer);

        // -(void)computeAxisWithMin:(double)min max:(double)max inverted:(BOOL)inverted;
        [Export("computeAxisWithMin:max:inverted:")]
        void ComputeAxisWithMin(double min, double max, bool inverted);

        // -(void)drawYLabelsWithContext:(CGContextRef _Nonnull)context fixedPosition:(CGFloat)fixedPosition positions:(NSArray<NSValue *> * _Nonnull)positions offset:(CGFloat)offset;
        [Export("drawYLabelsWithContext:fixedPosition:positions:offset:")]
        void DrawYLabelsWithContext(CGContext context, nfloat fixedPosition, NSValue[] positions, nfloat offset);

        // @property (readonly, nonatomic) CGRect gridClippingRect;
        [Export("gridClippingRect")]
        CGRect GridClippingRect { get; }

        // -(void)drawGridLineWithContext:(CGContextRef _Nonnull)context position:(CGPoint)position;
        [Export("drawGridLineWithContext:position:")]
        void DrawGridLineWithContext(CGContext context, CGPoint position);

        // -(NSArray<NSValue *> * _Nonnull)transformedPositions __attribute__((warn_unused_result("")));
        [Export("transformedPositions")]
        NSValue[] TransformedPositions { get; }

        // -(void)drawZeroLineWithContext:(CGContextRef _Nonnull)context;
        [Export("drawZeroLineWithContext:")]
        void DrawZeroLineWithContext(CGContext context);
    }

    // @interface YAxisRendererRadarChart : ChartYAxisRenderer
    [BaseType(typeof(ChartYAxisRenderer), Name = "_TtC8DGCharts23YAxisRendererRadarChart")]
    interface YAxisRendererRadarChart
    {
        // -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler axis:(ChartYAxis * _Nonnull)axis chart:(RadarChartView * _Nonnull)chart __attribute__((objc_designated_initializer));
        [Export("initWithViewPortHandler:axis:chart:")]
        [DesignatedInitializer]
        NativeHandle Constructor(ChartViewPortHandler viewPortHandler, ChartYAxis axis, RadarChartView chart);

        // -(void)computeAxisValuesWithMin:(double)yMin max:(double)yMax;
        [Export("computeAxisValuesWithMin:max:")]
        void ComputeAxisValuesWithMin(double yMin, double yMax);
    }

    // @interface ZoomChartViewJob : ChartViewPortJob
    [BaseType(typeof(ChartViewPortJob))]
    interface ZoomChartViewJob
    {
        // -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler scaleX:(CGFloat)scaleX scaleY:(CGFloat)scaleY xValue:(double)xValue yValue:(double)yValue transformer:(ChartTransformer * _Nonnull)transformer axis:(enum AxisDependency)axis view:(ChartViewBase * _Nonnull)view __attribute__((objc_designated_initializer));
        [Export("initWithViewPortHandler:scaleX:scaleY:xValue:yValue:transformer:axis:view:")]
        [DesignatedInitializer]
        NativeHandle Constructor(ChartViewPortHandler viewPortHandler, nfloat scaleX, nfloat scaleY, double xValue, double yValue, ChartTransformer transformer, AxisDependency axis, ChartViewBase view);

        // -(void)doJob;
        [Export("doJob")]
        void DoJob();
    }
}
