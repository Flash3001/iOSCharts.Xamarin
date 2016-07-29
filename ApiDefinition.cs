using System;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
//using ObjectiveC;
using UIKit;

namespace iOSCharts
{
	// @interface ChartData : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC6Charts9ChartData")]
	interface ChartData
	{
		// @property (nonatomic) double _yMax;
		[Export("_yMax")]
		double _yMax { get; set; }

		// @property (nonatomic) double _yMin;
		[Export("_yMin")]
		double _yMin { get; set; }

		// @property (nonatomic) double _leftAxisMax;
		[Export("_leftAxisMax")]
		double _leftAxisMax { get; set; }

		// @property (nonatomic) double _leftAxisMin;
		[Export("_leftAxisMin")]
		double _leftAxisMin { get; set; }

		// @property (nonatomic) double _rightAxisMax;
		[Export("_rightAxisMax")]
		double _rightAxisMax { get; set; }

		// @property (nonatomic) double _rightAxisMin;
		[Export("_rightAxisMin")]
		double _rightAxisMin { get; set; }

		// @property (nonatomic) NSInteger _lastStart;
		[Export("_lastStart")]
		nint _lastStart { get; set; }

		// @property (nonatomic) NSInteger _lastEnd;
		[Export("_lastEnd")]
		nint _lastEnd { get; set; }

		// @property (copy, nonatomic) NSArray<id<IInterfaceChartDataSet>> * _Null_unspecified _dataSets;
		[Export("_dataSets", ArgumentSemantic.Copy)]
		IInterfaceChartDataSet[] _dataSets { get; set; }

		// -(instancetype _Nonnull)initWithXVals:(NSArray<NSObject *> * _Nullable)xVals dataSets:(NSArray<id<IInterfaceChartDataSet>> * _Nullable)dataSets __attribute__((objc_designated_initializer));
		[Export("initWithXVals:dataSets:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] NSObject[] xVals, [NullAllowed] IInterfaceChartDataSet[] dataSets);

		// -(instancetype _Nonnull)initWithXVals:(NSArray<NSObject *> * _Nullable)xVals;
		[Export("initWithXVals:")]
		IntPtr Constructor([NullAllowed] NSObject[] xVals);

		// -(instancetype _Nonnull)initWithXVals:(NSArray<NSObject *> * _Nullable)xVals dataSet:(id<IInterfaceChartDataSet> _Nullable)dataSet;
		[Export("initWithXVals:dataSet:")]
		IntPtr Constructor([NullAllowed] NSObject[] xVals, [NullAllowed] IInterfaceChartDataSet dataSet);

		// -(void)initialize:(NSArray<id<IInterfaceChartDataSet>> * _Nonnull)dataSets;
		[Export("initialize:")]
		void Initialize(IInterfaceChartDataSet[] dataSets);

		// -(void)calcXValAverageLength;
		[Export("calcXValAverageLength")]
		void CalcXValAverageLength();

		// -(void)checkIsLegal:(NSArray<id<IInterfaceChartDataSet>> * _Null_unspecified)dataSets;
		[Export("checkIsLegal:")]
		void CheckIsLegal(IInterfaceChartDataSet[] dataSets);

		// -(void)notifyDataChanged;
		[Export("notifyDataChanged")]
		void NotifyDataChanged();

		// -(void)calcMinMaxWithStart:(NSInteger)start end:(NSInteger)end;
		[Export("calcMinMaxWithStart:end:")]
		void CalcMinMaxWithStart(nint start, nint end);

		// -(void)calcYValueCount;
		[Export("calcYValueCount")]
		void CalcYValueCount();

		// @property (readonly, nonatomic) NSInteger dataSetCount;
		[Export("dataSetCount")]
		nint DataSetCount { get; }

		// @property (readonly, nonatomic) double yMin;
		[Export("yMin")]
		double YMin { get; }

		//// -(double)getYMin;
		//[Export("getYMin")]
		////[Verify(MethodToProperty)]
		//double YMin { get; }

		// -(double)getYMin:(enum AxisDependency)axis;
		[Export("getYMin:")]
		double GetYMin(AxisDependency axis);

		// @property (readonly, nonatomic) double yMax;
		[Export("yMax")]
		double YMax { get; }

		//// -(double)getYMax;
		//[Export("getYMax")]
		////[Verify(MethodToProperty)]
		//double YMax { get; }

		// -(double)getYMax:(enum AxisDependency)axis;
		[Export("getYMax:")]
		double GetYMax(AxisDependency axis);

		// @property (readonly, nonatomic) double xValAverageLength;
		[Export("xValAverageLength")]
		double XValAverageLength { get; }

		// @property (readonly, nonatomic) NSInteger yValCount;
		[Export("yValCount")]
		nint YValCount { get; }

		// -(void)addXValue:(NSString * _Nullable)xVal;
		[Export("addXValue:")]
		void AddXValue([NullAllowed] string xVal);

		// -(void)removeXValue:(NSInteger)index;
		[Export("removeXValue:")]
		void RemoveXValue(nint index);

		// @property (copy, nonatomic) NSArray<id<IInterfaceChartDataSet>> * _Nonnull dataSets;
		[Export("dataSets", ArgumentSemantic.Copy)]
		IInterfaceChartDataSet[] DataSets { get; set; }

		// -(NSInteger)getDataSetIndexByLabel:(NSString * _Nonnull)label ignorecase:(BOOL)ignorecase;
		[Export("getDataSetIndexByLabel:ignorecase:")]
		nint GetDataSetIndexByLabel(string label, bool ignorecase);

		// @property (readonly, nonatomic) NSInteger xValCount;
		[Export("xValCount")]
		nint XValCount { get; }

		// -(NSArray<NSString *> * _Nonnull)dataSetLabels;
		[Export("dataSetLabels")]
		//[Verify(MethodToProperty)]
		string[] DataSetLabels { get; }

		// -(ChartDataEntry * _Nullable)getEntryForHighlight:(ChartHighlight * _Nonnull)highlight;
		[Export("getEntryForHighlight:")]
		[return: NullAllowed]
		ChartDataEntry GetEntryForHighlight(ChartHighlight highlight);

		// -(id<IInterfaceChartDataSet> _Nullable)getDataSetByLabel:(NSString * _Nonnull)label ignorecase:(BOOL)ignorecase;
		[Export("getDataSetByLabel:ignorecase:")]
		[return: NullAllowed]
		IInterfaceChartDataSet GetDataSetByLabel(string label, bool ignorecase);

		// -(id<IInterfaceChartDataSet> _Null_unspecified)getDataSetByIndex:(NSInteger)index;
		[Export("getDataSetByIndex:")]
		IInterfaceChartDataSet GetDataSetByIndex(nint index);

		// -(void)addDataSet:(id<IInterfaceChartDataSet> _Null_unspecified)d;
		[Export("addDataSet:")]
		void AddDataSet(IInterfaceChartDataSet d);

		// -(void)handleEmptyAxis:(id<IInterfaceChartDataSet> _Nullable)firstLeft firstRight:(id<IInterfaceChartDataSet> _Nullable)firstRight;
		[Export("handleEmptyAxis:firstRight:")]
		void HandleEmptyAxis([NullAllowed] IInterfaceChartDataSet firstLeft, [NullAllowed] IInterfaceChartDataSet firstRight);

		// -(BOOL)removeDataSet:(id<IInterfaceChartDataSet> _Null_unspecified)dataSet;
		[Export("removeDataSet:")]
		bool RemoveDataSet(IInterfaceChartDataSet dataSet);

		// -(BOOL)removeDataSetByIndex:(NSInteger)index;
		[Export("removeDataSetByIndex:")]
		bool RemoveDataSetByIndex(nint index);

		// -(void)addEntry:(ChartDataEntry * _Nonnull)e dataSetIndex:(NSInteger)dataSetIndex;
		[Export("addEntry:dataSetIndex:")]
		void AddEntry(ChartDataEntry e, nint dataSetIndex);

		// -(BOOL)removeEntry:(ChartDataEntry * _Null_unspecified)entry dataSetIndex:(NSInteger)dataSetIndex;
		[Export("removeEntry:dataSetIndex:")]
		bool RemoveEntry(ChartDataEntry entry, nint dataSetIndex);

		// -(BOOL)removeEntryByXIndex:(NSInteger)xIndex dataSetIndex:(NSInteger)dataSetIndex;
		[Export("removeEntryByXIndex:dataSetIndex:")]
		bool RemoveEntryByXIndex(nint xIndex, nint dataSetIndex);

		// -(id<IInterfaceChartDataSet> _Nullable)getDataSetForEntry:(ChartDataEntry * _Null_unspecified)e;
		[Export("getDataSetForEntry:")]
		[return: NullAllowed]
		IInterfaceChartDataSet GetDataSetForEntry(ChartDataEntry e);

		// -(NSInteger)indexOfDataSet:(id<IInterfaceChartDataSet> _Nonnull)dataSet;
		[Export("indexOfDataSet:")]
		nint IndexOfDataSet(IInterfaceChartDataSet dataSet);

		// -(id<IInterfaceChartDataSet> _Nullable)getFirstLeft;
		[NullAllowed, Export("getFirstLeft")]
		//[Verify(MethodToProperty)]
		IInterfaceChartDataSet FirstLeft { get; }

		// -(id<IInterfaceChartDataSet> _Nullable)getFirstRight;
		[NullAllowed, Export("getFirstRight")]
		//[Verify(MethodToProperty)]
		IInterfaceChartDataSet FirstRight { get; }

		// -(NSArray<UIColor *> * _Nullable)getColors;
		[NullAllowed, Export("getColors")]
		//[Verify(MethodToProperty)]
		UIColor[] Colors { get; }

		// -(NSArray<NSString *> * _Nonnull)generateXVals:(NSInteger)from to:(NSInteger)to;
		[Export("generateXVals:to:")]
		string[] GenerateXVals(nint from, nint to);

		// -(void)setValueFormatter:(NSNumberFormatter * _Null_unspecified)formatter;
		[Export("setValueFormatter:")]
		void SetValueFormatter(NSNumberFormatter formatter);

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

		// -(BOOL)containsWithEntry:(ChartDataEntry * _Nonnull)entry;
		[Export("containsWithEntry:")]
		bool ContainsWithEntry(ChartDataEntry entry);

		// -(BOOL)containsWithDataSet:(id<IInterfaceChartDataSet> _Nonnull)dataSet;
		[Export("containsWithDataSet:")]
		bool ContainsWithDataSet(IInterfaceChartDataSet dataSet);

		// @property (copy, nonatomic) NSArray<NSObject *> * _Nonnull xValsObjc;
		[Export("xValsObjc", ArgumentSemantic.Copy)]
		NSObject[] XValsObjc { get; set; }
	}

	// @interface BarLineScatterCandleBubbleChartData : ChartData
	[BaseType(typeof(ChartData), Name = "_TtC6Charts35BarLineScatterCandleBubbleChartData")]
	interface BarLineScatterCandleBubbleChartData
	{
		// -(instancetype _Nonnull)initWithXVals:(NSArray<NSObject *> * _Nullable)xVals dataSets:(NSArray<id<IInterfaceChartDataSet>> * _Nullable)dataSets __attribute__((objc_designated_initializer));
		[Export("initWithXVals:dataSets:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] NSObject[] xVals, [NullAllowed] IInterfaceChartDataSet[] dataSets);
	}

	// @interface BarChartData : BarLineScatterCandleBubbleChartData
	[BaseType(typeof(BarLineScatterCandleBubbleChartData), Name = "_TtC6Charts12BarChartData")]
	interface BarChartData
	{
		// -(instancetype _Nonnull)initWithXVals:(NSArray<NSObject *> * _Nullable)xVals dataSets:(NSArray<id<IInterfaceChartDataSet>> * _Nullable)dataSets __attribute__((objc_designated_initializer));
		[Export("initWithXVals:dataSets:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] NSObject[] xVals, [NullAllowed] IInterfaceChartDataSet[] dataSets);

		// @property (nonatomic) CGFloat groupSpace;
		[Export("groupSpace")]
		nfloat GroupSpace { get; set; }

		// @property (readonly, nonatomic) BOOL isGrouped;
		[Export("isGrouped")]
		bool IsGrouped { get; }
	}

	// @interface ChartDataEntry : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC6Charts14ChartDataEntry")]
	interface ChartDataEntry
	{
		// @property (nonatomic) double value;
		[Export("value")]
		double Value { get; set; }

		// @property (nonatomic) NSInteger xIndex;
		[Export("xIndex")]
		nint XIndex { get; set; }

		// @property (nonatomic, strong) id _Nullable data;
		[NullAllowed, Export("data", ArgumentSemantic.Strong)]
		NSObject Data { get; set; }

		// -(instancetype _Nonnull)initWithValue:(double)value xIndex:(NSInteger)xIndex __attribute__((objc_designated_initializer));
		[Export("initWithValue:xIndex:")]
		[DesignatedInitializer]
		IntPtr Constructor(double value, nint xIndex);

		// -(instancetype _Nonnull)initWithValue:(double)value xIndex:(NSInteger)xIndex data:(id _Nullable)data __attribute__((objc_designated_initializer));
		[Export("initWithValue:xIndex:data:")]
		[DesignatedInitializer]
		IntPtr Constructor(double value, nint xIndex, [NullAllowed] NSObject data);

		// -(BOOL)isEqual:(id _Nullable)object;
		[Export("isEqual:")]
		bool IsEqual([NullAllowed] NSObject @object);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export("description")]
		string Description { get; }

		//// -(id _Nonnull)copyWithZone:(struct _NSZone * _Null_unspecified)zone;
		//[Export("copyWithZone:")]
		//unsafe NSObject CopyWithZone(_NSZone* zone);
	}

	// @interface BarChartDataEntry : ChartDataEntry
	[BaseType(typeof(ChartDataEntry), Name = "_TtC6Charts17BarChartDataEntry")]
	interface BarChartDataEntry
	{
		// -(instancetype _Nonnull)initWithValues:(NSArray<NSNumber *> * _Nonnull)values xIndex:(NSInteger)xIndex __attribute__((objc_designated_initializer));
		[Export("initWithValues:xIndex:")]
		[DesignatedInitializer]
		IntPtr Constructor(NSNumber[] values, nint xIndex);

		// -(instancetype _Nonnull)initWithValue:(double)value xIndex:(NSInteger)xIndex __attribute__((objc_designated_initializer));
		[Export("initWithValue:xIndex:")]
		[DesignatedInitializer]
		IntPtr Constructor(double value, nint xIndex);

		// -(instancetype _Nonnull)initWithValues:(NSArray<NSNumber *> * _Nonnull)values xIndex:(NSInteger)xIndex label:(NSString * _Nonnull)label __attribute__((objc_designated_initializer));
		[Export("initWithValues:xIndex:label:")]
		[DesignatedInitializer]
		IntPtr Constructor(NSNumber[] values, nint xIndex, string label);

		// -(instancetype _Nonnull)initWithValue:(double)value xIndex:(NSInteger)xIndex data:(id _Nullable)data __attribute__((objc_designated_initializer));
		[Export("initWithValue:xIndex:data:")]
		[DesignatedInitializer]
		IntPtr Constructor(double value, nint xIndex, [NullAllowed] NSObject data);

		// -(double)getBelowSum:(NSInteger)stackIndex;
		[Export("getBelowSum:")]
		double GetBelowSum(nint stackIndex);

		// @property (readonly, nonatomic) double negativeSum;
		[Export("negativeSum")]
		double NegativeSum { get; }

		// @property (readonly, nonatomic) double positiveSum;
		[Export("positiveSum")]
		double PositiveSum { get; }

		// -(void)calcPosNegSum;
		[Export("calcPosNegSum")]
		void CalcPosNegSum();

		// @property (readonly, nonatomic) BOOL isStacked;
		[Export("isStacked")]
		bool IsStacked { get; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nullable values;
		[NullAllowed, Export("values", ArgumentSemantic.Copy)]
		NSNumber[] Values { get; set; }

		//// -(id _Nonnull)copyWithZone:(struct _NSZone * _Null_unspecified)zone;
		//[Export("copyWithZone:")]
		//unsafe NSObject CopyWithZone(_NSZone* zone);
	}

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

		// @required @property (readonly, nonatomic) NSInteger xValCount;
		[Abstract]
		[Export("xValCount")]
		nint XValCount { get; }

		// @required @property (readonly, nonatomic) CGPoint centerOffsets;
		[Abstract]
		[Export("centerOffsets")]
		CGPoint CenterOffsets { get; }

		// @required @property (readonly, nonatomic, strong) ChartData * _Nullable data;
		[Abstract]
		[NullAllowed, Export("data", ArgumentSemantic.Strong)]
		ChartData Data { get; set; }
	}

	interface IBarLineScatterCandleBubbleChartDataProvider { }

	// @protocol BarLineScatterCandleBubbleChartDataProvider <ChartDataProvider>
	[Protocol(Name = "_TtP6Charts43BarLineScatterCandleBubbleChartDataProvider_"), Model]
	interface BarLineScatterCandleBubbleChartDataProvider : ChartDataProvider
	{
		// @required -(ChartTransformer * _Nonnull)getTransformer:(enum AxisDependency)which;
		[Abstract]
		[Export("getTransformer:")]
		ChartTransformer GetTransformer(AxisDependency which);

		// @required @property (readonly, nonatomic) NSInteger maxVisibleValueCount;
		[Abstract]
		[Export("maxVisibleValueCount")]
		nint MaxVisibleValueCount { get; }

		// @required -(BOOL)isInverted:(enum AxisDependency)axis;
		[Abstract]
		[Export("isInverted:")]
		bool IsInverted(AxisDependency axis);

		// @required @property (readonly, nonatomic) NSInteger lowestVisibleXIndex;
		[Abstract]
		[Export("lowestVisibleXIndex")]
		nint LowestVisibleXIndex { get; }

		// @required @property (readonly, nonatomic) NSInteger highestVisibleXIndex;
		[Abstract]
		[Export("highestVisibleXIndex")]
		nint HighestVisibleXIndex { get; }
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

		// @required @property (readonly, nonatomic) BOOL isDrawHighlightArrowEnabled;
		[Abstract]
		[Export("isDrawHighlightArrowEnabled")]
		bool IsDrawHighlightArrowEnabled { get; }
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

		// @required -(void)calcMinMaxWithStart:(NSInteger)start end:(NSInteger)end;
		[Abstract]
		[Export("calcMinMaxWithStart:end:")]
		void CalcMinMaxWithStart(nint start, nint end);

		// @required @property (readonly, nonatomic) double yMin;
		[Abstract]
		[Export("yMin")]
		double YMin { get; }

		// @required @property (readonly, nonatomic) double yMax;
		[Abstract]
		[Export("yMax")]
		double YMax { get; }

		// @required @property (readonly, nonatomic) NSInteger entryCount;
		[Abstract]
		[Export("entryCount")]
		nint EntryCount { get; }

		// @required -(double)yValForXIndex:(NSInteger)x;
		[Abstract]
		[Export("yValForXIndex:")]
		double YValForXIndex(nint x);

		// @required -(NSArray<NSNumber *> * _Nonnull)yValsForXIndex:(NSInteger)x;
		[Abstract]
		[Export("yValsForXIndex:")]
		NSNumber[] YValsForXIndex(nint x);

		// @required -(ChartDataEntry * _Nullable)entryForIndex:(NSInteger)i;
		[Abstract]
		[Export("entryForIndex:")]
		[return: NullAllowed]
		ChartDataEntry EntryForIndex(nint i);

		// @required -(ChartDataEntry * _Nullable)entryForXIndex:(NSInteger)x rounding:(enum ChartDataSetRounding)rounding;
		[Abstract]
		[Export("entryForXIndex:rounding:")]
		[return: NullAllowed]
		ChartDataEntry EntryForXIndex(nint x, ChartDataSetRounding rounding);

		// @required -(ChartDataEntry * _Nullable)entryForXIndex:(NSInteger)x;
		[Abstract]
		[Export("entryForXIndex:")]
		[return: NullAllowed]
		ChartDataEntry EntryForXIndex(nint x);

		// @required -(NSArray<ChartDataEntry *> * _Nonnull)entriesForXIndex:(NSInteger)x;
		[Abstract]
		[Export("entriesForXIndex:")]
		ChartDataEntry[] EntriesForXIndex(nint x);

		// @required -(NSInteger)entryIndexWithXIndex:(NSInteger)x rounding:(enum ChartDataSetRounding)rounding;
		[Abstract]
		[Export("entryIndexWithXIndex:rounding:")]
		nint EntryIndexWithXIndex(nint x, ChartDataSetRounding rounding);

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

		// @required -(BOOL)removeEntryWithXIndex:(NSInteger)xIndex;
		[Abstract]
		[Export("removeEntryWithXIndex:")]
		bool RemoveEntryWithXIndex(nint xIndex);

		// @required -(BOOL)removeFirst;
		[Abstract]
		[Export("removeFirst")]
		//[Verify(MethodToProperty)]
		bool RemoveFirst { get; }

		// @required -(BOOL)removeLast;
		[Abstract]
		[Export("removeLast")]
		//[Verify(MethodToProperty)]
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
		AxisDependency AxisDependency { get; }

		// @required @property (readonly, copy, nonatomic) NSArray<UIColor *> * _Nonnull valueColors;
		[Abstract]
		[Export("valueColors", ArgumentSemantic.Copy)]
		UIColor[] ValueColors { get; }

		// @required @property (readonly, copy, nonatomic) NSArray<UIColor *> * _Nonnull colors;
		[Abstract]
		[Export("colors", ArgumentSemantic.Copy)]
		UIColor[] Colors { get; }

		// @required -(UIColor * _Nonnull)colorAt:(NSInteger)index;
		[Abstract]
		[Export("colorAt:")]
		UIColor ColorAt(nint index);

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

		// @required @property (nonatomic, strong) NSNumberFormatter * _Nullable valueFormatter;
		[Abstract]
		[NullAllowed, Export("valueFormatter", ArgumentSemantic.Strong)]
		NSNumberFormatter ValueFormatter { get; set; }

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

	interface IInterfaceBarChartDataSet { };

	// @protocol IInterfaceBarChartDataSet <IInterfaceBarLineScatterCandleBubbleChartDataSet>
	[Protocol(Name = "_TtP6Charts16IBarChartDataSet_"), Model]
	interface InterfaceBarChartDataSet : InterfaceBarLineScatterCandleBubbleChartDataSet
	{
		// @required @property (nonatomic) CGFloat barSpace;
		[Abstract]
		[Export("barSpace")]
		nfloat BarSpace { get; set; }

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

		// -(void)calcMinMaxWithStart:(NSInteger)start end:(NSInteger)end;
		[Export("calcMinMaxWithStart:end:")]
		void CalcMinMaxWithStart(nint start, nint end);

		// @property (readonly, nonatomic) double yMin;
		[Export("yMin")]
		double YMin { get; }

		// @property (readonly, nonatomic) double yMax;
		[Export("yMax")]
		double YMax { get; }

		// @property (readonly, nonatomic) NSInteger entryCount;
		[Export("entryCount")]
		nint EntryCount { get; }

		// -(double)yValForXIndex:(NSInteger)x;
		[Export("yValForXIndex:")]
		double YValForXIndex(nint x);

		// -(NSArray<NSNumber *> * _Nonnull)yValsForXIndex:(NSInteger)x;
		[Export("yValsForXIndex:")]
		NSNumber[] YValsForXIndex(nint x);

		// -(ChartDataEntry * _Nullable)entryForIndex:(NSInteger)i;
		[Export("entryForIndex:")]
		[return: NullAllowed]
		ChartDataEntry EntryForIndex(nint i);

		// -(ChartDataEntry * _Nullable)entryForXIndex:(NSInteger)x rounding:(enum ChartDataSetRounding)rounding;
		[Export("entryForXIndex:rounding:")]
		[return: NullAllowed]
		ChartDataEntry EntryForXIndex(nint x, ChartDataSetRounding rounding);

		// -(ChartDataEntry * _Nullable)entryForXIndex:(NSInteger)x;
		[Export("entryForXIndex:")]
		[return: NullAllowed]
		ChartDataEntry EntryForXIndex(nint x);

		// -(NSArray<ChartDataEntry *> * _Nonnull)entriesForXIndex:(NSInteger)x;
		[Export("entriesForXIndex:")]
		ChartDataEntry[] EntriesForXIndex(nint x);

		// -(NSInteger)entryIndexWithXIndex:(NSInteger)x rounding:(enum ChartDataSetRounding)rounding;
		[Export("entryIndexWithXIndex:rounding:")]
		nint EntryIndexWithXIndex(nint x, ChartDataSetRounding rounding);

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

		// -(BOOL)removeEntryWithXIndex:(NSInteger)xIndex;
		[Export("removeEntryWithXIndex:")]
		bool RemoveEntryWithXIndex(nint xIndex);

		// -(BOOL)removeFirst;
		[Export("removeFirst")]
		//[Verify(MethodToProperty)]
		bool RemoveFirst { get; }

		// -(BOOL)removeLast;
		[Export("removeLast")]
		//[Verify(MethodToProperty)]
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

		// -(UIColor * _Nonnull)colorAt:(NSInteger)index;
		[Export("colorAt:")]
		UIColor ColorAt(nint index);

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

		// @property (nonatomic, strong) NSNumberFormatter * _Nullable _valueFormatter;
		[NullAllowed, Export("_valueFormatter", ArgumentSemantic.Strong)]
		NSNumberFormatter _valueFormatter { get; set; }

		// @property (nonatomic, strong) NSNumberFormatter * _Nullable valueFormatter;
		[NullAllowed, Export("valueFormatter", ArgumentSemantic.Strong)]
		NSNumberFormatter ValueFormatter { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull valueTextColor;
		[Export("valueTextColor", ArgumentSemantic.Strong)]
		UIColor ValueTextColor { get; set; }

		// -(UIColor * _Nonnull)valueTextColorAt:(NSInteger)index;
		[Export("valueTextColorAt:")]
		UIColor ValueTextColorAt(nint index);

		// @property (nonatomic, strong) UIFont * _Nonnull valueFont;
		[Export("valueFont", ArgumentSemantic.Strong)]
		UIFont ValueFont { get; set; }

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

		//// -(id _Nonnull)copyWithZone:(struct _NSZone * _Null_unspecified)zone;
		//[Export("copyWithZone:")]
		//unsafe NSObject CopyWithZone(_NSZone* zone);
	}

	// @interface ChartDataSet : ChartBaseDataSet
	[BaseType(typeof(ChartBaseDataSet), Name = "_TtC6Charts12ChartDataSet")]
	interface ChartDataSet
	{
		// -(instancetype _Nonnull)initWithLabel:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
		[Export("initWithLabel:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] string label);

		// -(instancetype _Nonnull)initWithYVals:(NSArray<ChartDataEntry *> * _Nullable)yVals label:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
		[Export("initWithYVals:label:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] ChartDataEntry[] yVals, [NullAllowed] string label);

		// -(instancetype _Nonnull)initWithYVals:(NSArray<ChartDataEntry *> * _Nullable)yVals;
		[Export("initWithYVals:")]
		IntPtr Constructor([NullAllowed] ChartDataEntry[] yVals);

		// @property (copy, nonatomic) NSArray<ChartDataEntry *> * _Null_unspecified _yVals;
		[Export("_yVals", ArgumentSemantic.Copy)]
		ChartDataEntry[] _yVals { get; set; }

		// @property (nonatomic) double _yMax;
		[Export("_yMax")]
		double _yMax { get; set; }

		// @property (nonatomic) double _yMin;
		[Export("_yMin")]
		double _yMin { get; set; }

		// @property (nonatomic) NSInteger _lastStart;
		[Export("_lastStart")]
		nint _lastStart { get; set; }

		// @property (nonatomic) NSInteger _lastEnd;
		[Export("_lastEnd")]
		nint _lastEnd { get; set; }

		// @property (copy, nonatomic) NSArray<ChartDataEntry *> * _Nonnull yVals;
		[Export("yVals", ArgumentSemantic.Copy)]
		ChartDataEntry[] YVals { get; set; }

		// -(void)notifyDataSetChanged;
		[Export("notifyDataSetChanged")]
		void NotifyDataSetChanged();

		// -(void)calcMinMaxWithStart:(NSInteger)start end:(NSInteger)end;
		[Export("calcMinMaxWithStart:end:")]
		void CalcMinMaxWithStart(nint start, nint end);

		// @property (readonly, nonatomic) double yMin;
		[Export("yMin")]
		double YMin { get; }

		// @property (readonly, nonatomic) double yMax;
		[Export("yMax")]
		double YMax { get; }

		// @property (readonly, nonatomic) NSInteger entryCount;
		[Export("entryCount")]
		nint EntryCount { get; }

		// -(double)yValForXIndex:(NSInteger)x;
		[Export("yValForXIndex:")]
		double YValForXIndex(nint x);

		// -(NSArray<NSNumber *> * _Nonnull)yValsForXIndex:(NSInteger)x;
		[Export("yValsForXIndex:")]
		NSNumber[] YValsForXIndex(nint x);

		// -(ChartDataEntry * _Nullable)entryForIndex:(NSInteger)i;
		[Export("entryForIndex:")]
		[return: NullAllowed]
		ChartDataEntry EntryForIndex(nint i);

		// -(ChartDataEntry * _Nullable)entryForXIndex:(NSInteger)x rounding:(enum ChartDataSetRounding)rounding;
		[Export("entryForXIndex:rounding:")]
		[return: NullAllowed]
		ChartDataEntry EntryForXIndex(nint x, ChartDataSetRounding rounding);

		// -(ChartDataEntry * _Nullable)entryForXIndex:(NSInteger)x;
		[Export("entryForXIndex:")]
		[return: NullAllowed]
		ChartDataEntry EntryForXIndex(nint x);

		// -(NSArray<ChartDataEntry *> * _Nonnull)entriesForXIndex:(NSInteger)x;
		[Export("entriesForXIndex:")]
		ChartDataEntry[] EntriesForXIndex(nint x);

		// -(NSInteger)entryIndexWithXIndex:(NSInteger)x rounding:(enum ChartDataSetRounding)rounding;
		[Export("entryIndexWithXIndex:rounding:")]
		nint EntryIndexWithXIndex(nint x, ChartDataSetRounding rounding);

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
		//[Verify(MethodToProperty)]
		bool RemoveFirst { get; }

		// -(BOOL)removeLast;
		[Export("removeLast")]
		//[Verify(MethodToProperty)]
		bool RemoveLast { get; }

		// -(BOOL)contains:(ChartDataEntry * _Nonnull)e;
		[Export("contains:")]
		bool Contains(ChartDataEntry e);

		// -(void)clear;
		[Export("clear")]
		void Clear();

		// @property (readonly, nonatomic) NSInteger valueCount;
		[Export("valueCount")]
		nint ValueCount { get; }

		//// -(id _Nonnull)copyWithZone:(struct _NSZone * _Null_unspecified)zone;
		//[Export("copyWithZone:")]
		//unsafe NSObject CopyWithZone(_NSZone* zone);
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

		//// -(id _Nonnull)copyWithZone:(struct _NSZone * _Null_unspecified)zone;
		//[Export("copyWithZone:")]
		//unsafe NSObject CopyWithZone(_NSZone* zone);

		// -(instancetype _Nonnull)initWithLabel:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
		[Export("initWithLabel:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] string label);

		// -(instancetype _Nonnull)initWithYVals:(NSArray<ChartDataEntry *> * _Nullable)yVals label:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
		[Export("initWithYVals:label:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] ChartDataEntry[] yVals, [NullAllowed] string label);
	}

	// @interface BarChartDataSet : BarLineScatterCandleBubbleChartDataSet <IInterfaceBarChartDataSet>
	[BaseType(typeof(BarLineScatterCandleBubbleChartDataSet), Name = "_TtC6Charts15BarChartDataSet")]
	interface BarChartDataSet : InterfaceBarChartDataSet
	{
		// -(instancetype _Nonnull)initWithYVals:(NSArray<ChartDataEntry *> * _Nullable)yVals label:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
		[Export("initWithYVals:label:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] ChartDataEntry[] yVals, [NullAllowed] string label);

		// -(void)calcMinMaxWithStart:(NSInteger)start end:(NSInteger)end;
		[Export("calcMinMaxWithStart:end:")]
		void CalcMinMaxWithStart(nint start, nint end);

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

		// @property (nonatomic) CGFloat barSpace;
		[Export("barSpace")]
		nfloat BarSpace { get; set; }

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

		//// -(id _Nonnull)copyWithZone:(struct _NSZone * _Null_unspecified)zone;
		//[Export("copyWithZone:")]
		//unsafe NSObject CopyWithZone(_NSZone* zone);
	}

	// @interface ChartHighlighter : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC6Charts16ChartHighlighter")]
	interface ChartHighlighter
	{
		// @property (nonatomic, weak) BarLineChartViewBase * _Nullable chart;
		[NullAllowed, Export("chart", ArgumentSemantic.Weak)]
		BarLineChartViewBase Chart { get; set; }

		// -(instancetype _Nonnull)initWithChart:(BarLineChartViewBase * _Nonnull)chart __attribute__((objc_designated_initializer));
		[Export("initWithChart:")]
		[DesignatedInitializer]
		IntPtr Constructor(BarLineChartViewBase chart);

		// -(ChartHighlight * _Nullable)getHighlightWithX:(CGFloat)x y:(CGFloat)y;
		[Export("getHighlightWithX:y:")]
		[return: NullAllowed]
		ChartHighlight GetHighlightWithX(nfloat x, nfloat y);

		// -(NSInteger)getXIndex:(CGFloat)x;
		[Export("getXIndex:")]
		nint GetXIndex(nfloat x);
	}

	// @interface BarChartHighlighter : ChartHighlighter
	[BaseType(typeof(ChartHighlighter), Name = "_TtC6Charts19BarChartHighlighter")]
	interface BarChartHighlighter
	{
		// -(ChartHighlight * _Nullable)getHighlightWithX:(CGFloat)x y:(CGFloat)y;
		[Export("getHighlightWithX:y:")]
		[return: NullAllowed]
		ChartHighlight GetHighlightWithX(nfloat x, nfloat y);

		// -(NSInteger)getXIndex:(CGFloat)x;
		[Export("getXIndex:")]
		nint GetXIndex(nfloat x);

		// -(ChartHighlight * _Nullable)getStackedHighlightWithSelectionDetail:(ChartSelectionDetail * _Nonnull)selectionDetail set:(id<IInterfaceBarChartDataSet> _Nonnull)set xIndex:(NSInteger)xIndex yValue:(double)yValue;
		[Export("getStackedHighlightWithSelectionDetail:set:xIndex:yValue:")]
		[return: NullAllowed]
		ChartHighlight GetStackedHighlightWithSelectionDetail(ChartSelectionDetail selectionDetail, IInterfaceBarChartDataSet set, nint xIndex, double yValue);

		// -(NSInteger)getClosestStackIndexWithRanges:(NSArray<ChartRange *> * _Nullable)ranges value:(double)value;
		[Export("getClosestStackIndexWithRanges:value:")]
		nint GetClosestStackIndexWithRanges([NullAllowed] ChartRange[] ranges, double value);

		// -(double)getBase:(CGFloat)x;
		[Export("getBase:")]
		double GetBase(nfloat x);

		// -(NSArray<ChartRange *> * _Nullable)getRangesWithEntry:(BarChartDataEntry * _Nonnull)entry;
		[Export("getRangesWithEntry:")]
		[return: NullAllowed]
		ChartRange[] GetRangesWithEntry(BarChartDataEntry entry);

		// -(instancetype _Nonnull)initWithChart:(BarLineChartViewBase * _Nonnull)chart __attribute__((objc_designated_initializer));
		[Export("initWithChart:")]
		[DesignatedInitializer]
		IntPtr Constructor(BarLineChartViewBase chart);
	}

	// @interface ChartRendererBase : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC6Charts17ChartRendererBase")]
	interface ChartRendererBase
	{
		// @property (nonatomic, strong) ChartViewPortHandler * _Null_unspecified viewPortHandler;
		[Export("viewPortHandler", ArgumentSemantic.Strong)]
		ChartViewPortHandler ViewPortHandler { get; set; }

		// @property (nonatomic) NSInteger minX;
		[Export("minX")]
		nint MinX { get; set; }

		// @property (nonatomic) NSInteger maxX;
		[Export("maxX")]
		nint MaxX { get; set; }

		// -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler __attribute__((objc_designated_initializer));
		[Export("initWithViewPortHandler:")]
		[DesignatedInitializer]
		IntPtr Constructor(ChartViewPortHandler viewPortHandler);

		// -(void)calcXBoundsWithChart:(id<BarLineScatterCandleBubbleChartDataProvider> _Nonnull)chart xAxisModulus:(NSInteger)xAxisModulus;
		[Export("calcXBoundsWithChart:xAxisModulus:")]
		void CalcXBoundsWithChart(IBarLineScatterCandleBubbleChartDataProvider chart, nint xAxisModulus);
	}

	// @interface ChartDataRendererBase : ChartRendererBase
	[BaseType(typeof(ChartRendererBase), Name = "_TtC6Charts21ChartDataRendererBase")]
	interface ChartDataRendererBase
	{
		// @property (nonatomic, strong) ChartAnimator * _Nullable animator;
		[NullAllowed, Export("animator", ArgumentSemantic.Strong)]
		ChartAnimator Animator { get; set; }

		// -(instancetype _Nonnull)initWithAnimator:(ChartAnimator * _Nullable)animator viewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler __attribute__((objc_designated_initializer));
		[Export("initWithAnimator:viewPortHandler:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] ChartAnimator animator, ChartViewPortHandler viewPortHandler);

		//// -(void)drawDataWithContext:(CGContextRef _Nonnull)context;
		//[Export("drawDataWithContext:")]
		//unsafe void DrawDataWithContext(CGContextRef* context);

		//// -(void)drawValuesWithContext:(CGContextRef _Nonnull)context;
		//[Export("drawValuesWithContext:")]
		//unsafe void DrawValuesWithContext(CGContextRef* context);

		//// -(void)drawExtrasWithContext:(CGContextRef _Nonnull)context;
		//[Export("drawExtrasWithContext:")]
		//unsafe void DrawExtrasWithContext(CGContextRef* context);

		//// -(void)drawHighlightedWithContext:(CGContextRef _Nonnull)context indices:(NSArray<ChartHighlight *> * _Nonnull)indices;
		//[Export("drawHighlightedWithContext:indices:")]
		//unsafe void DrawHighlightedWithContext(CGContextRef* context, ChartHighlight[] indices);
	}

	// @interface BarChartRenderer : ChartDataRendererBase
	[BaseType(typeof(ChartDataRendererBase), Name = "_TtC6Charts16BarChartRenderer")]
	interface BarChartRenderer
	{
		// @property (nonatomic, weak) id<BarChartDataProvider> _Nullable dataProvider;
		[NullAllowed, Export("dataProvider", ArgumentSemantic.Weak)]
		IBarChartDataProvider DataProvider { get; set; }

		// -(instancetype _Nonnull)initWithDataProvider:(id<BarChartDataProvider> _Nullable)dataProvider animator:(ChartAnimator * _Nullable)animator viewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler __attribute__((objc_designated_initializer));
		[Export("initWithDataProvider:animator:viewPortHandler:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] IBarChartDataProvider dataProvider, [NullAllowed] ChartAnimator animator, ChartViewPortHandler viewPortHandler);

		//// -(void)drawDataWithContext:(CGContextRef _Nonnull)context;
		//[Export("drawDataWithContext:")]
		//unsafe void DrawDataWithContext(CGContextRef* context);

		//// -(void)drawDataSetWithContext:(CGContextRef _Nonnull)context dataSet:(id<IInterfaceBarChartDataSet> _Nonnull)dataSet index:(NSInteger)index;
		//[Export("drawDataSetWithContext:dataSet:index:")]
		//unsafe void DrawDataSetWithContext(CGContextRef* context, IInterfaceBarChartDataSet dataSet, nint index);

		//// -(void)drawValuesWithContext:(CGContextRef _Nonnull)context;
		//[Export("drawValuesWithContext:")]
		//unsafe void DrawValuesWithContext(CGContextRef* context);

		//// -(void)drawValueWithContext:(CGContextRef _Nonnull)context value:(NSString * _Nonnull)value xPos:(CGFloat)xPos yPos:(CGFloat)yPos font:(UIFont * _Nonnull)font align:(NSTextAlignment)align color:(UIColor * _Nonnull)color;
		//[Export("drawValueWithContext:value:xPos:yPos:font:align:color:")]
		//unsafe void DrawValueWithContext(CGContextRef* context, string value, nfloat xPos, nfloat yPos, UIFont font, NSTextAlignment align, UIColor color);

		//// -(void)drawExtrasWithContext:(CGContextRef _Nonnull)context;
		//[Export("drawExtrasWithContext:")]
		//unsafe void DrawExtrasWithContext(CGContextRef* context);

		//// -(void)drawHighlightedWithContext:(CGContextRef _Nonnull)context indices:(NSArray<ChartHighlight *> * _Nonnull)indices;
		//[Export("drawHighlightedWithContext:indices:")]
		//unsafe void DrawHighlightedWithContext(CGContextRef* context, ChartHighlight[] indices);

		// -(BOOL)passesCheck;
		[Export("passesCheck")]
		//[Verify(MethodToProperty)]
		bool PassesCheck { get; }
	}

	// @protocol ChartAnimatorDelegate
	[BaseType(typeof(NSObject), Name = "_TtP6Charts21ChartAnimatorDelegate_")]
	[Protocol(Name = "_TtP6Charts21ChartAnimatorDelegate_"), Model]
	interface ChartAnimatorDelegate
	{
		// @required -(void)chartAnimatorUpdated:(ChartAnimator * _Nonnull)chartAnimator;
		[Abstract]
		[Export("chartAnimatorUpdated:")]
		void ChartAnimatorUpdated(ChartAnimator chartAnimator);

		// @required -(void)chartAnimatorStopped:(ChartAnimator * _Nonnull)chartAnimator;
		[Abstract]
		[Export("chartAnimatorStopped:")]
		void ChartAnimatorStopped(ChartAnimator chartAnimator);
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

		// -(void)touchesCancelled:(NSSet<UITouch *> * _Nullable)touches withEvent:(UIEvent * _Nullable)event;
		[Export("touchesCancelled:withEvent:")]
		void TouchesCancelled([NullAllowed] NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

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

		// @property (readonly, nonatomic, strong) CALayer * _Nullable nsuiLayer;
		[NullAllowed, Export("nsuiLayer", ArgumentSemantic.Strong)]
		CALayer NsuiLayer { get; }

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
	interface ChartViewBase : ChartDataProvider, ChartAnimatorDelegate
	{
		// @property (readonly, nonatomic, strong) ChartXAxis * _Nonnull xAxis;
		[Export("xAxis", ArgumentSemantic.Strong)]
		ChartXAxis XAxis { get; }

		// @property (nonatomic, strong) NSNumberFormatter * _Nonnull _defaultValueFormatter;
		[Export("_defaultValueFormatter", ArgumentSemantic.Strong)]
		NSNumberFormatter _defaultValueFormatter { get; set; }

		// @property (nonatomic, strong) ChartData * _Nullable _data;
		[NullAllowed, Export("_data", ArgumentSemantic.Strong)]
		ChartData _data { get; set; }

		// @property (nonatomic) BOOL dragDecelerationEnabled;
		[Export("dragDecelerationEnabled")]
		bool DragDecelerationEnabled { get; set; }

		// @property (nonatomic, strong) UIFont * _Nullable descriptionFont;
		[NullAllowed, Export("descriptionFont", ArgumentSemantic.Strong)]
		UIFont DescriptionFont { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable descriptionTextColor;
		[NullAllowed, Export("descriptionTextColor", ArgumentSemantic.Strong)]
		UIColor DescriptionTextColor { get; set; }

		//// @property (nonatomic) NSTextAlignment descriptionTextAlign;
		//[Export("descriptionTextAlign", ArgumentSemantic.Assign)]
		//NSTextAlignment DescriptionTextAlign { get; set; }

		// @property (nonatomic, strong) UIFont * _Null_unspecified infoFont;
		[Export("infoFont", ArgumentSemantic.Strong)]
		UIFont InfoFont { get; set; }

		// @property (nonatomic, strong) UIColor * _Null_unspecified infoTextColor;
		[Export("infoTextColor", ArgumentSemantic.Strong)]
		UIColor InfoTextColor { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull descriptionText;
		[Export("descriptionText")]
		string DescriptionText { get; set; }

		// @property (nonatomic) BOOL _drawUnitInChart;
		[Export("_drawUnitInChart")]
		bool _drawUnitInChart { get; set; }

		// @property (nonatomic, strong) ChartXAxis * _Null_unspecified _xAxis;
		[Export("_xAxis", ArgumentSemantic.Strong)]
		ChartXAxis _xAxis { get; set; }

		// @property (nonatomic, strong) ChartLegend * _Null_unspecified _legend;
		[Export("_legend", ArgumentSemantic.Strong)]
		ChartLegend _legend { get; set; }

		[Wrap("WeakDelegate")]
		[NullAllowed]
		ChartViewDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<ChartViewDelegate> _Nullable delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull noDataText;
		[Export("noDataText")]
		string NoDataText { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable noDataTextDescription;
		[NullAllowed, Export("noDataTextDescription")]
		string NoDataTextDescription { get; set; }

		// @property (nonatomic, strong) ChartLegendRenderer * _Null_unspecified _legendRenderer;
		[Export("_legendRenderer", ArgumentSemantic.Strong)]
		ChartLegendRenderer _legendRenderer { get; set; }

		// @property (nonatomic, strong) ChartDataRendererBase * _Nullable renderer;
		[NullAllowed, Export("renderer", ArgumentSemantic.Strong)]
		ChartDataRendererBase Renderer { get; set; }

		// @property (nonatomic, strong) ChartHighlighter * _Nullable highlighter;
		[NullAllowed, Export("highlighter", ArgumentSemantic.Strong)]
		ChartHighlighter Highlighter { get; set; }

		// @property (nonatomic, strong) ChartViewPortHandler * _Null_unspecified _viewPortHandler;
		[Export("_viewPortHandler", ArgumentSemantic.Strong)]
		ChartViewPortHandler _viewPortHandler { get; set; }

		// @property (nonatomic, strong) ChartAnimator * _Null_unspecified _animator;
		[Export("_animator", ArgumentSemantic.Strong)]
		ChartAnimator _animator { get; set; }

		// @property (copy, nonatomic) NSArray<ChartHighlight *> * _Nonnull _indicesToHighlight;
		[Export("_indicesToHighlight", ArgumentSemantic.Copy)]
		ChartHighlight[] _indicesToHighlight { get; set; }

		// @property (nonatomic) BOOL drawMarkers;
		[Export("drawMarkers")]
		bool DrawMarkers { get; set; }

		// @property (nonatomic, strong) ChartMarker * _Nullable marker;
		[NullAllowed, Export("marker", ArgumentSemantic.Strong)]
		ChartMarker Marker { get; set; }

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

		// -(void)initialize;
		[Export("initialize")]
		void Initialize();

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
		//[Verify(MethodToProperty)]
		bool IsEmpty { get; }

		// -(void)notifyDataSetChanged;
		[Export("notifyDataSetChanged")]
		void NotifyDataSetChanged();

		// -(void)calculateOffsets;
		[Export("calculateOffsets")]
		void CalculateOffsets();

		// -(void)calcMinMax;
		[Export("calcMinMax")]
		void CalcMinMax();

		// -(void)calculateFormatterWithMin:(double)min max:(double)max;
		[Export("calculateFormatterWithMin:max:")]
		void CalculateFormatterWithMin(double min, double max);

		// -(void)drawRect:(CGRect)rect;
		[Export("drawRect:")]
		void DrawRect(CGRect rect);

		//// -(void)drawDescriptionWithContext:(CGContextRef _Nonnull)context;
		//[Export("drawDescriptionWithContext:")]
		//unsafe void DrawDescriptionWithContext(CGContextRef* context);

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
		//[Verify(MethodToProperty)]
		bool ValuesToHighlight { get; }

		// -(void)highlightValues:(NSArray<ChartHighlight *> * _Nullable)highs;
		[Export("highlightValues:")]
		void HighlightValues([NullAllowed] ChartHighlight[] highs);

		// -(void)highlightValue:(ChartHighlight * _Nullable)highlight;
		[Export("highlightValue:")]
		void HighlightValue([NullAllowed] ChartHighlight highlight);

		// -(void)highlightValueWithXIndex:(NSInteger)xIndex dataSetIndex:(NSInteger)dataSetIndex;
		[Export("highlightValueWithXIndex:dataSetIndex:")]
		void HighlightValueWithXIndex(nint xIndex, nint dataSetIndex);

		// -(void)highlightValueWithXIndex:(NSInteger)xIndex dataSetIndex:(NSInteger)dataSetIndex callDelegate:(BOOL)callDelegate;
		[Export("highlightValueWithXIndex:dataSetIndex:callDelegate:")]
		void HighlightValueWithXIndex(nint xIndex, nint dataSetIndex, bool callDelegate);

		// -(void)highlightValueWithHighlight:(ChartHighlight * _Nullable)highlight callDelegate:(BOOL)callDelegate;
		[Export("highlightValueWithHighlight:callDelegate:")]
		void HighlightValueWithHighlight([NullAllowed] ChartHighlight highlight, bool callDelegate);

		// @property (nonatomic, strong) ChartHighlight * _Nullable lastHighlighted;
		[NullAllowed, Export("lastHighlighted", ArgumentSemantic.Strong)]
		ChartHighlight LastHighlighted { get; set; }

		//// -(void)drawMarkersWithContext:(CGContextRef _Nonnull)context;
		//[Export("drawMarkersWithContext:")]
		//unsafe void DrawMarkersWithContext(CGContextRef* context);

		// -(CGPoint)getMarkerPositionWithEntry:(ChartDataEntry * _Nonnull)entry highlight:(ChartHighlight * _Nonnull)highlight;
		[Export("getMarkerPositionWithEntry:highlight:")]
		CGPoint GetMarkerPositionWithEntry(ChartDataEntry entry, ChartHighlight highlight);

		// @property (readonly, nonatomic, strong) ChartAnimator * _Null_unspecified chartAnimator;
		[Export("chartAnimator", ArgumentSemantic.Strong)]
		ChartAnimator ChartAnimator { get; }

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration yAxisDuration:(NSTimeInterval)yAxisDuration easingX:(CGFloat (^ _Nullable)(NSTimeInterval, NSTimeInterval))easingX easingY:(CGFloat (^ _Nullable)(NSTimeInterval, NSTimeInterval))easingY;
		[Export("animateWithXAxisDuration:yAxisDuration:easingX:easingY:")]
		void AnimateWithXAxisDuration(double xAxisDuration, double yAxisDuration, [NullAllowed] Func<double, double, nfloat> easingX, [NullAllowed] Func<double, double, nfloat> easingY);

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration yAxisDuration:(NSTimeInterval)yAxisDuration easingOptionX:(enum ChartEasingOption)easingOptionX easingOptionY:(enum ChartEasingOption)easingOptionY;
		[Export("animateWithXAxisDuration:yAxisDuration:easingOptionX:easingOptionY:")]
		void AnimateWithXAxisDuration(double xAxisDuration, double yAxisDuration, ChartEasingOption easingOptionX, ChartEasingOption easingOptionY);

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration yAxisDuration:(NSTimeInterval)yAxisDuration easing:(CGFloat (^ _Nullable)(NSTimeInterval, NSTimeInterval))easing;
		[Export("animateWithXAxisDuration:yAxisDuration:easing:")]
		void AnimateWithXAxisDuration(double xAxisDuration, double yAxisDuration, [NullAllowed] Func<double, double, nfloat> easing);

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration yAxisDuration:(NSTimeInterval)yAxisDuration easingOption:(enum ChartEasingOption)easingOption;
		[Export("animateWithXAxisDuration:yAxisDuration:easingOption:")]
		void AnimateWithXAxisDuration(double xAxisDuration, double yAxisDuration, ChartEasingOption easingOption);

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration yAxisDuration:(NSTimeInterval)yAxisDuration;
		[Export("animateWithXAxisDuration:yAxisDuration:")]
		void AnimateWithXAxisDuration(double xAxisDuration, double yAxisDuration);

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration easing:(CGFloat (^ _Nullable)(NSTimeInterval, NSTimeInterval))easing;
		[Export("animateWithXAxisDuration:easing:")]
		void AnimateWithXAxisDuration(double xAxisDuration, [NullAllowed] Func<double, double, nfloat> easing);

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration easingOption:(enum ChartEasingOption)easingOption;
		[Export("animateWithXAxisDuration:easingOption:")]
		void AnimateWithXAxisDuration(double xAxisDuration, ChartEasingOption easingOption);

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration;
		[Export("animateWithXAxisDuration:")]
		void AnimateWithXAxisDuration(double xAxisDuration);

		// -(void)animateWithYAxisDuration:(NSTimeInterval)yAxisDuration easing:(CGFloat (^ _Nullable)(NSTimeInterval, NSTimeInterval))easing;
		[Export("animateWithYAxisDuration:easing:")]
		void AnimateWithYAxisDuration(double yAxisDuration, [NullAllowed] Func<double, double, nfloat> easing);

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

		// @property (readonly, nonatomic) NSInteger xValCount;
		[Export("xValCount")]
		nint XValCount { get; }

		// @property (readonly, nonatomic) NSInteger valueCount;
		[Export("valueCount")]
		nint ValueCount { get; }

		// @property (readonly, nonatomic) CGPoint midPoint;
		[Export("midPoint")]
		CGPoint MidPoint { get; }

		// -(void)setDescriptionTextPositionWithX:(CGFloat)x y:(CGFloat)y;
		[Export("setDescriptionTextPositionWithX:y:")]
		void SetDescriptionTextPositionWithX(nfloat x, nfloat y);

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

		// -(NSString * _Null_unspecified)getXValue:(NSInteger)index;
		[Export("getXValue:")]
		string GetXValue(nint index);

		// -(NSArray<ChartDataEntry *> * _Nonnull)getEntriesAtIndex:(NSInteger)xIndex;
		[Export("getEntriesAtIndex:")]
		ChartDataEntry[] GetEntriesAtIndex(nint xIndex);

		// @property (readonly, nonatomic, strong) ChartViewPortHandler * _Null_unspecified viewPortHandler;
		[Export("viewPortHandler", ArgumentSemantic.Strong)]
		ChartViewPortHandler ViewPortHandler { get; }

		// -(UIImage * _Nullable)getChartImageWithTransparent:(BOOL)transparent;
		[Export("getChartImageWithTransparent:")]
		[return: NullAllowed]
		UIImage GetChartImageWithTransparent(bool transparent);

		// -(void)saveToCameraRoll;
		[Export("saveToCameraRoll")]
		void SaveToCameraRoll();

		//// -(void)observeValueForKeyPath:(NSString * _Nullable)keyPath ofObject:(id _Nullable)object change:(NSDictionary<NSString *,id> * _Nullable)change context:(void * _Null_unspecified)context;
		//[Export("observeValueForKeyPath:ofObject:change:context:")]
		//unsafe void ObserveValueForKeyPath([NullAllowed] string keyPath, [NullAllowed] NSObject @object, [NullAllowed] NSDictionary<NSString, NSObject> change, void* context);

		// -(void)clearAllViewportJobs;
		[Export("clearAllViewportJobs")]
		void ClearAllViewportJobs();

		// @property (readonly, nonatomic) BOOL isDragDecelerationEnabled;
		[Export("isDragDecelerationEnabled")]
		bool IsDragDecelerationEnabled { get; }

		// @property (nonatomic) CGFloat dragDecelerationFrictionCoef;
		[Export("dragDecelerationFrictionCoef")]
		nfloat DragDecelerationFrictionCoef { get; set; }

		// -(void)chartAnimatorUpdated:(ChartAnimator * _Nonnull)chartAnimator;
		[Export("chartAnimatorUpdated:")]
		void ChartAnimatorUpdated(ChartAnimator chartAnimator);

		// -(void)chartAnimatorStopped:(ChartAnimator * _Nonnull)chartAnimator;
		[Export("chartAnimatorStopped:")]
		void ChartAnimatorStopped(ChartAnimator chartAnimator);

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
		// @property (nonatomic) NSInteger _maxVisibleValueCount;
		[Export("_maxVisibleValueCount")]
		nint _maxVisibleValueCount { get; set; }

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

		// @property (nonatomic) CGFloat minOffset;
		[Export("minOffset")]
		nfloat MinOffset { get; set; }

		// @property (nonatomic) BOOL keepPositionOnRotation;
		[Export("keepPositionOnRotation")]
		bool KeepPositionOnRotation { get; set; }

		// @property (nonatomic, strong) ChartYAxis * _Null_unspecified _leftAxis;
		[Export("_leftAxis", ArgumentSemantic.Strong)]
		ChartYAxis _leftAxis { get; set; }

		// @property (nonatomic, strong) ChartYAxis * _Null_unspecified _rightAxis;
		[Export("_rightAxis", ArgumentSemantic.Strong)]
		ChartYAxis _rightAxis { get; set; }

		// @property (nonatomic, strong) ChartYAxisRenderer * _Null_unspecified _leftYAxisRenderer;
		[Export("_leftYAxisRenderer", ArgumentSemantic.Strong)]
		ChartYAxisRenderer _leftYAxisRenderer { get; set; }

		// @property (nonatomic, strong) ChartYAxisRenderer * _Null_unspecified _rightYAxisRenderer;
		[Export("_rightYAxisRenderer", ArgumentSemantic.Strong)]
		ChartYAxisRenderer _rightYAxisRenderer { get; set; }

		// @property (nonatomic, strong) ChartTransformer * _Null_unspecified _leftAxisTransformer;
		[Export("_leftAxisTransformer", ArgumentSemantic.Strong)]
		ChartTransformer _leftAxisTransformer { get; set; }

		// @property (nonatomic, strong) ChartTransformer * _Null_unspecified _rightAxisTransformer;
		[Export("_rightAxisTransformer", ArgumentSemantic.Strong)]
		ChartTransformer _rightAxisTransformer { get; set; }

		// @property (nonatomic, strong) ChartXAxisRenderer * _Null_unspecified _xAxisRenderer;
		[Export("_xAxisRenderer", ArgumentSemantic.Strong)]
		ChartXAxisRenderer _xAxisRenderer { get; set; }

		// @property (nonatomic, strong) UITapGestureRecognizer * _Null_unspecified _tapGestureRecognizer;
		[Export("_tapGestureRecognizer", ArgumentSemantic.Strong)]
		UITapGestureRecognizer _tapGestureRecognizer { get; set; }

		// @property (nonatomic, strong) UITapGestureRecognizer * _Null_unspecified _doubleTapGestureRecognizer;
		[Export("_doubleTapGestureRecognizer", ArgumentSemantic.Strong)]
		UITapGestureRecognizer _doubleTapGestureRecognizer { get; set; }

		// @property (nonatomic, strong) UIPinchGestureRecognizer * _Null_unspecified _pinchGestureRecognizer;
		[Export("_pinchGestureRecognizer", ArgumentSemantic.Strong)]
		UIPinchGestureRecognizer _pinchGestureRecognizer { get; set; }

		// @property (nonatomic, strong) UIPanGestureRecognizer * _Null_unspecified _panGestureRecognizer;
		[Export("_panGestureRecognizer", ArgumentSemantic.Strong)]
		UIPanGestureRecognizer _panGestureRecognizer { get; set; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor(CGRect frame);

		//// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		//[Export("initWithCoder:")]
		//[DesignatedInitializer]
		//IntPtr Constructor(NSCoder aDecoder);

		// -(void)initialize;
		[Export("initialize")]
		void Initialize();

		//// -(void)observeValueForKeyPath:(NSString * _Nullable)keyPath ofObject:(id _Nullable)object change:(NSDictionary<NSString *,id> * _Nullable)change context:(void * _Null_unspecified)context;
		//[Export("observeValueForKeyPath:ofObject:change:context:")]
		//unsafe void ObserveValueForKeyPath([NullAllowed] string keyPath, [NullAllowed] NSObject @object, [NullAllowed] NSDictionary<NSString, NSObject> change, void* context);

		// -(void)drawRect:(CGRect)rect;
		[Export("drawRect:")]
		void DrawRect(CGRect rect);

		// -(void)prepareValuePxMatrix;
		[Export("prepareValuePxMatrix")]
		void PrepareValuePxMatrix();

		// -(void)prepareOffsetMatrix;
		[Export("prepareOffsetMatrix")]
		void PrepareOffsetMatrix();

		// -(void)notifyDataSetChanged;
		[Export("notifyDataSetChanged")]
		void NotifyDataSetChanged();

		// -(void)calcMinMax;
		[Export("calcMinMax")]
		void CalcMinMax();

		// -(void)calculateOffsets;
		[Export("calculateOffsets")]
		void CalculateOffsets();

		// -(void)calcModulus;
		[Export("calcModulus")]
		void CalcModulus();

		// -(CGPoint)getMarkerPositionWithEntry:(ChartDataEntry * _Nonnull)e highlight:(ChartHighlight * _Nonnull)highlight;
		[Export("getMarkerPositionWithEntry:highlight:")]
		CGPoint GetMarkerPositionWithEntry(ChartDataEntry e, ChartHighlight highlight);

		//// -(void)drawGridBackgroundWithContext:(CGContextRef _Nonnull)context;
		//[Export("drawGridBackgroundWithContext:")]
		//unsafe void DrawGridBackgroundWithContext(CGContextRef* context);

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

		// -(void)zoom:(CGFloat)scaleX scaleY:(CGFloat)scaleY x:(CGFloat)x y:(CGFloat)y;
		[Export("zoom:scaleY:x:y:")]
		void Zoom(nfloat scaleX, nfloat scaleY, nfloat x, nfloat y);

		// -(void)zoom:(CGFloat)scaleX scaleY:(CGFloat)scaleY xIndex:(CGFloat)xIndex yValue:(double)yValue axis:(enum AxisDependency)axis;
		[Export("zoom:scaleY:xIndex:yValue:axis:")]
		void Zoom(nfloat scaleX, nfloat scaleY, nfloat xIndex, double yValue, AxisDependency axis);

		// -(void)zoomAndCenterViewAnimatedWithScaleX:(CGFloat)scaleX scaleY:(CGFloat)scaleY xIndex:(CGFloat)xIndex yValue:(double)yValue axis:(enum AxisDependency)axis duration:(NSTimeInterval)duration easing:(CGFloat (^ _Nullable)(NSTimeInterval, NSTimeInterval))easing;
		[Export("zoomAndCenterViewAnimatedWithScaleX:scaleY:xIndex:yValue:axis:duration:easing:")]
		void ZoomAndCenterViewAnimatedWithScaleX(nfloat scaleX, nfloat scaleY, nfloat xIndex, double yValue, AxisDependency axis, double duration, [NullAllowed] Func<double, double, nfloat> easing);

		// -(void)zoomAndCenterViewAnimatedWithScaleX:(CGFloat)scaleX scaleY:(CGFloat)scaleY xIndex:(CGFloat)xIndex yValue:(double)yValue axis:(enum AxisDependency)axis duration:(NSTimeInterval)duration easingOption:(enum ChartEasingOption)easingOption;
		[Export("zoomAndCenterViewAnimatedWithScaleX:scaleY:xIndex:yValue:axis:duration:easingOption:")]
		void ZoomAndCenterViewAnimatedWithScaleX(nfloat scaleX, nfloat scaleY, nfloat xIndex, double yValue, AxisDependency axis, double duration, ChartEasingOption easingOption);

		// -(void)zoomAndCenterViewAnimatedWithScaleX:(CGFloat)scaleX scaleY:(CGFloat)scaleY xIndex:(CGFloat)xIndex yValue:(double)yValue axis:(enum AxisDependency)axis duration:(NSTimeInterval)duration;
		[Export("zoomAndCenterViewAnimatedWithScaleX:scaleY:xIndex:yValue:axis:duration:")]
		void ZoomAndCenterViewAnimatedWithScaleX(nfloat scaleX, nfloat scaleY, nfloat xIndex, double yValue, AxisDependency axis, double duration);

		// -(void)fitScreen;
		[Export("fitScreen")]
		void FitScreen();

		// -(void)setScaleMinima:(CGFloat)scaleX scaleY:(CGFloat)scaleY;
		[Export("setScaleMinima:scaleY:")]
		void SetScaleMinima(nfloat scaleX, nfloat scaleY);

		// -(void)setVisibleXRangeMaximum:(CGFloat)maxXRange;
		[Export("setVisibleXRangeMaximum:")]
		void SetVisibleXRangeMaximum(nfloat maxXRange);

		// -(void)setVisibleXRangeMinimum:(CGFloat)minXRange;
		[Export("setVisibleXRangeMinimum:")]
		void SetVisibleXRangeMinimum(nfloat minXRange);

		// -(void)setVisibleXRangeWithMinXRange:(CGFloat)minXRange maxXRange:(CGFloat)maxXRange;
		[Export("setVisibleXRangeWithMinXRange:maxXRange:")]
		void SetVisibleXRangeWithMinXRange(nfloat minXRange, nfloat maxXRange);

		// -(void)setVisibleYRangeMaximum:(CGFloat)maxYRange axis:(enum AxisDependency)axis;
		[Export("setVisibleYRangeMaximum:axis:")]
		void SetVisibleYRangeMaximum(nfloat maxYRange, AxisDependency axis);

		// -(void)moveViewToX:(CGFloat)xIndex;
		[Export("moveViewToX:")]
		void MoveViewToX(nfloat xIndex);

		// -(void)moveViewToY:(double)yValue axis:(enum AxisDependency)axis;
		[Export("moveViewToY:axis:")]
		void MoveViewToY(double yValue, AxisDependency axis);

		// -(void)moveViewToXIndex:(CGFloat)xIndex yValue:(double)yValue axis:(enum AxisDependency)axis;
		[Export("moveViewToXIndex:yValue:axis:")]
		void MoveViewToXIndex(nfloat xIndex, double yValue, AxisDependency axis);

		// -(void)moveViewToAnimatedWithXIndex:(CGFloat)xIndex yValue:(double)yValue axis:(enum AxisDependency)axis duration:(NSTimeInterval)duration easing:(CGFloat (^ _Nullable)(NSTimeInterval, NSTimeInterval))easing;
		[Export("moveViewToAnimatedWithXIndex:yValue:axis:duration:easing:")]
		void MoveViewToAnimatedWithXIndex(nfloat xIndex, double yValue, AxisDependency axis, double duration, [NullAllowed] Func<double, double, nfloat> easing);

		// -(void)moveViewToAnimatedWithXIndex:(CGFloat)xIndex yValue:(double)yValue axis:(enum AxisDependency)axis duration:(NSTimeInterval)duration easingOption:(enum ChartEasingOption)easingOption;
		[Export("moveViewToAnimatedWithXIndex:yValue:axis:duration:easingOption:")]
		void MoveViewToAnimatedWithXIndex(nfloat xIndex, double yValue, AxisDependency axis, double duration, ChartEasingOption easingOption);

		// -(void)moveViewToAnimatedWithXIndex:(CGFloat)xIndex yValue:(double)yValue axis:(enum AxisDependency)axis duration:(NSTimeInterval)duration;
		[Export("moveViewToAnimatedWithXIndex:yValue:axis:duration:")]
		void MoveViewToAnimatedWithXIndex(nfloat xIndex, double yValue, AxisDependency axis, double duration);

		// -(void)centerViewToXIndex:(CGFloat)xIndex yValue:(double)yValue axis:(enum AxisDependency)axis;
		[Export("centerViewToXIndex:yValue:axis:")]
		void CenterViewToXIndex(nfloat xIndex, double yValue, AxisDependency axis);

		// -(void)centerViewToAnimatedWithXIndex:(CGFloat)xIndex yValue:(double)yValue axis:(enum AxisDependency)axis duration:(NSTimeInterval)duration easing:(CGFloat (^ _Nullable)(NSTimeInterval, NSTimeInterval))easing;
		[Export("centerViewToAnimatedWithXIndex:yValue:axis:duration:easing:")]
		void CenterViewToAnimatedWithXIndex(nfloat xIndex, double yValue, AxisDependency axis, double duration, [NullAllowed] Func<double, double, nfloat> easing);

		// -(void)centerViewToAnimatedWithXIndex:(CGFloat)xIndex yValue:(double)yValue axis:(enum AxisDependency)axis duration:(NSTimeInterval)duration easingOption:(enum ChartEasingOption)easingOption;
		[Export("centerViewToAnimatedWithXIndex:yValue:axis:duration:easingOption:")]
		void CenterViewToAnimatedWithXIndex(nfloat xIndex, double yValue, AxisDependency axis, double duration, ChartEasingOption easingOption);

		// -(void)centerViewToAnimatedWithXIndex:(CGFloat)xIndex yValue:(double)yValue axis:(enum AxisDependency)axis duration:(NSTimeInterval)duration;
		[Export("centerViewToAnimatedWithXIndex:yValue:axis:duration:")]
		void CenterViewToAnimatedWithXIndex(nfloat xIndex, double yValue, AxisDependency axis, double duration);

		// -(void)setViewPortOffsetsWithLeft:(CGFloat)left top:(CGFloat)top right:(CGFloat)right bottom:(CGFloat)bottom;
		[Export("setViewPortOffsetsWithLeft:top:right:bottom:")]
		void SetViewPortOffsetsWithLeft(nfloat left, nfloat top, nfloat right, nfloat bottom);

		// -(void)resetViewPortOffsets;
		[Export("resetViewPortOffsets")]
		void ResetViewPortOffsets();

		// -(CGFloat)getDeltaY:(enum AxisDependency)axis;
		[Export("getDeltaY:")]
		nfloat GetDeltaY(AxisDependency axis);

		// -(CGPoint)getPosition:(ChartDataEntry * _Nonnull)e axis:(enum AxisDependency)axis;
		[Export("getPosition:axis:")]
		CGPoint GetPosition(ChartDataEntry e, AxisDependency axis);

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

		// @property (nonatomic) BOOL highlightFullBarEnabled;
		[Export("highlightFullBarEnabled")]
		bool HighlightFullBarEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isHighlightFullBarEnabled;
		[Export("isHighlightFullBarEnabled")]
		bool IsHighlightFullBarEnabled { get; }

		// @property (readonly, nonatomic) BOOL isDrawGridBackgroundEnabled;
		[Export("isDrawGridBackgroundEnabled")]
		bool IsDrawGridBackgroundEnabled { get; }

		// @property (readonly, nonatomic) BOOL isDrawBordersEnabled;
		[Export("isDrawBordersEnabled")]
		bool IsDrawBordersEnabled { get; }

		// -(ChartHighlight * _Nullable)getHighlightByTouchPoint:(CGPoint)pt;
		[Export("getHighlightByTouchPoint:")]
		[return: NullAllowed]
		ChartHighlight GetHighlightByTouchPoint(CGPoint pt);

		// -(CGPoint)getValueByTouchPointWithPt:(CGPoint)pt axis:(enum AxisDependency)axis;
		[Export("getValueByTouchPointWithPt:axis:")]
		CGPoint GetValueByTouchPointWithPt(CGPoint pt, AxisDependency axis);

		// -(CGPoint)getPixelForValue:(double)x y:(double)y axis:(enum AxisDependency)axis;
		[Export("getPixelForValue:y:axis:")]
		CGPoint GetPixelForValue(double x, double y, AxisDependency axis);

		// -(CGFloat)getYValueByTouchPointWithPt:(CGPoint)pt axis:(enum AxisDependency)axis;
		[Export("getYValueByTouchPointWithPt:axis:")]
		nfloat GetYValueByTouchPointWithPt(CGPoint pt, AxisDependency axis);

		// -(ChartDataEntry * _Null_unspecified)getEntryByTouchPoint:(CGPoint)pt;
		[Export("getEntryByTouchPoint:")]
		ChartDataEntry GetEntryByTouchPoint(CGPoint pt);

		// -(id<IInterfaceBarLineScatterCandleBubbleChartDataSet> _Null_unspecified)getDataSetByTouchPoint:(CGPoint)pt;
		[Export("getDataSetByTouchPoint:")]
		IInterfaceBarLineScatterCandleBubbleChartDataSet GetDataSetByTouchPoint(CGPoint pt);

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

		// -(void)setYAxisMinWidth:(enum AxisDependency)which width:(CGFloat)width;
		[Export("setYAxisMinWidth:width:")]
		void SetYAxisMinWidth(AxisDependency which, nfloat width);

		// -(CGFloat)getYAxisMinWidth:(enum AxisDependency)which;
		[Export("getYAxisMinWidth:")]
		nfloat GetYAxisMinWidth(AxisDependency which);

		// -(void)setYAxisMaxWidth:(enum AxisDependency)which width:(CGFloat)width;
		[Export("setYAxisMaxWidth:width:")]
		void SetYAxisMaxWidth(AxisDependency which, nfloat width);

		// -(CGFloat)getYAxisMaxWidth:(enum AxisDependency)which;
		[Export("getYAxisMaxWidth:")]
		nfloat GetYAxisMaxWidth(AxisDependency which);

		// -(CGFloat)getYAxisWidth:(enum AxisDependency)which;
		[Export("getYAxisWidth:")]
		nfloat GetYAxisWidth(AxisDependency which);

		// -(ChartTransformer * _Nonnull)getTransformer:(enum AxisDependency)which;
		[Export("getTransformer:")]
		ChartTransformer GetTransformer(AxisDependency which);

		// @property (nonatomic) NSInteger maxVisibleValueCount;
		[Export("maxVisibleValueCount")]
		nint MaxVisibleValueCount { get; set; }

		// -(BOOL)isInverted:(enum AxisDependency)axis;
		[Export("isInverted:")]
		bool IsInverted(AxisDependency axis);

		// @property (readonly, nonatomic) NSInteger lowestVisibleXIndex;
		[Export("lowestVisibleXIndex")]
		nint LowestVisibleXIndex { get; }

		// @property (readonly, nonatomic) NSInteger highestVisibleXIndex;
		[Export("highestVisibleXIndex")]
		nint HighestVisibleXIndex { get; }
	}

	// @interface BarChartView : BarLineChartViewBase <BarChartDataProvider>
	[BaseType(typeof(BarLineChartViewBase), Name = "_TtC6Charts12BarChartView")]
	interface BarChartView : BarChartDataProvider
	{
		// -(void)initialize;
		[Export("initialize")]
		void Initialize();

		// -(void)calcMinMax;
		[Export("calcMinMax")]
		void CalcMinMax();

		// -(ChartHighlight * _Nullable)getHighlightByTouchPoint:(CGPoint)pt;
		[Export("getHighlightByTouchPoint:")]
		[return: NullAllowed]
		ChartHighlight GetHighlightByTouchPoint(CGPoint pt);

		// -(CGRect)getBarBounds:(BarChartDataEntry * _Nonnull)e;
		[Export("getBarBounds:")]
		CGRect GetBarBounds(BarChartDataEntry e);

		// @property (readonly, nonatomic) NSInteger lowestVisibleXIndex;
		[Export("lowestVisibleXIndex")]
		nint LowestVisibleXIndex { get; }

		// @property (readonly, nonatomic) NSInteger highestVisibleXIndex;
		[Export("highestVisibleXIndex")]
		nint HighestVisibleXIndex { get; }

		// @property (nonatomic) BOOL drawHighlightArrowEnabled;
		[Export("drawHighlightArrowEnabled")]
		bool DrawHighlightArrowEnabled { get; set; }

		// @property (nonatomic) BOOL drawValueAboveBarEnabled;
		[Export("drawValueAboveBarEnabled")]
		bool DrawValueAboveBarEnabled { get; set; }

		// @property (nonatomic) BOOL drawBarShadowEnabled;
		[Export("drawBarShadowEnabled")]
		bool DrawBarShadowEnabled { get; set; }

		// @property (readonly, nonatomic, strong) BarChartData * _Nullable barData;
		[NullAllowed, Export("barData", ArgumentSemantic.Strong)]
		BarChartData BarData { get; }

		// @property (readonly, nonatomic) BOOL isDrawHighlightArrowEnabled;
		[Export("isDrawHighlightArrowEnabled")]
		bool IsDrawHighlightArrowEnabled { get; }

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

	// @interface BubbleChartData : BarLineScatterCandleBubbleChartData
	[BaseType(typeof(BarLineScatterCandleBubbleChartData), Name = "_TtC6Charts15BubbleChartData")]
	interface BubbleChartData
	{
		// -(instancetype _Nonnull)initWithXVals:(NSArray<NSObject *> * _Nullable)xVals dataSets:(NSArray<id<IInterfaceChartDataSet>> * _Nullable)dataSets __attribute__((objc_designated_initializer));
		[Export("initWithXVals:dataSets:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] NSObject[] xVals, [NullAllowed] IInterfaceChartDataSet[] dataSets);

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

		// -(instancetype _Nonnull)initWithXIndex:(NSInteger)xIndex value:(double)value size:(CGFloat)size __attribute__((objc_designated_initializer));
		[Export("initWithXIndex:value:size:")]
		[DesignatedInitializer]
		IntPtr Constructor(nint xIndex, double value, nfloat size);

		// -(instancetype _Nonnull)initWithXIndex:(NSInteger)xIndex value:(double)value size:(CGFloat)size data:(id _Nullable)data __attribute__((objc_designated_initializer));
		[Export("initWithXIndex:value:size:data:")]
		[DesignatedInitializer]
		IntPtr Constructor(nint xIndex, double value, nfloat size, [NullAllowed] NSObject data);

		//// -(id _Nonnull)copyWithZone:(struct _NSZone * _Null_unspecified)zone;
		//[Export("copyWithZone:")]
		//unsafe NSObject CopyWithZone(_NSZone* zone);
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

	// @protocol InterfaceBubbleChartDataSet <IInterfaceBarLineScatterCandleBubbleChartDataSet>
	[Protocol(Name = "_TtP6Charts19IBubbleChartDataSet_"), Model]
	interface InterfaceBubbleChartDataSet : InterfaceBarLineScatterCandleBubbleChartDataSet
	{
		// @required @property (readonly, nonatomic) double xMin;
		[Abstract]
		[Export("xMin")]
		double XMin { get; }

		// @required @property (readonly, nonatomic) double xMax;
		[Abstract]
		[Export("xMax")]
		double XMax { get; }

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

	// @interface BubbleChartDataSet : BarLineScatterCandleBubbleChartDataSet <InterfaceBubbleChartDataSet>
	[BaseType(typeof(BarLineScatterCandleBubbleChartDataSet), Name = "_TtC6Charts18BubbleChartDataSet")]
	interface BubbleChartDataSet : InterfaceBubbleChartDataSet
	{
		// @property (nonatomic) double _xMax;
		[Export("_xMax")]
		double _xMax { get; set; }

		// @property (nonatomic) double _xMin;
		[Export("_xMin")]
		double _xMin { get; set; }

		// @property (nonatomic) CGFloat _maxSize;
		[Export("_maxSize")]
		nfloat _maxSize { get; set; }

		// @property (readonly, nonatomic) double xMin;
		[Export("xMin")]
		double XMin { get; }

		// @property (readonly, nonatomic) double xMax;
		[Export("xMax")]
		double XMax { get; }

		// @property (readonly, nonatomic) CGFloat maxSize;
		[Export("maxSize")]
		nfloat MaxSize { get; }

		// @property (nonatomic) BOOL normalizeSizeEnabled;
		[Export("normalizeSizeEnabled")]
		bool NormalizeSizeEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isNormalizeSizeEnabled;
		[Export("isNormalizeSizeEnabled")]
		bool IsNormalizeSizeEnabled { get; }

		// -(void)calcMinMaxWithStart:(NSInteger)start end:(NSInteger)end;
		[Export("calcMinMaxWithStart:end:")]
		void CalcMinMaxWithStart(nint start, nint end);

		// @property (nonatomic) CGFloat highlightCircleWidth;
		[Export("highlightCircleWidth")]
		nfloat HighlightCircleWidth { get; set; }

		//// -(id _Nonnull)copyWithZone:(struct _NSZone * _Null_unspecified)zone;
		//[Export("copyWithZone:")]
		//unsafe NSObject CopyWithZone(_NSZone* zone);

		// -(instancetype _Nonnull)initWithLabel:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
		[Export("initWithLabel:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] string label);

		// -(instancetype _Nonnull)initWithYVals:(NSArray<ChartDataEntry *> * _Nullable)yVals label:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
		[Export("initWithYVals:label:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] ChartDataEntry[] yVals, [NullAllowed] string label);
	}

	// @interface BubbleChartRenderer : ChartDataRendererBase
	[BaseType(typeof(ChartDataRendererBase), Name = "_TtC6Charts19BubbleChartRenderer")]
	interface BubbleChartRenderer
	{
		// @property (nonatomic, weak) id<BubbleChartDataProvider> _Nullable dataProvider;
		[NullAllowed, Export("dataProvider", ArgumentSemantic.Weak)]
		IBubbleChartDataProvider DataProvider { get; set; }

		// -(instancetype _Nonnull)initWithDataProvider:(id<BubbleChartDataProvider> _Nullable)dataProvider animator:(ChartAnimator * _Nullable)animator viewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler __attribute__((objc_designated_initializer));
		[Export("initWithDataProvider:animator:viewPortHandler:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] IBubbleChartDataProvider dataProvider, [NullAllowed] ChartAnimator animator, ChartViewPortHandler viewPortHandler);

		//// -(void)drawDataWithContext:(CGContextRef _Nonnull)context;
		//[Export("drawDataWithContext:")]
		//unsafe void DrawDataWithContext(CGContextRef* context);

		//// -(void)drawDataSetWithContext:(CGContextRef _Nonnull)context dataSet:(id<InterfaceBubbleChartDataSet> _Nonnull)dataSet;
		//[Export("drawDataSetWithContext:dataSet:")]
		//unsafe void DrawDataSetWithContext(CGContextRef* context, InterfaceBubbleChartDataSet dataSet);

		//// -(void)drawValuesWithContext:(CGContextRef _Nonnull)context;
		//[Export("drawValuesWithContext:")]
		//unsafe void DrawValuesWithContext(CGContextRef* context);

		//// -(void)drawExtrasWithContext:(CGContextRef _Nonnull)context;
		//[Export("drawExtrasWithContext:")]
		//unsafe void DrawExtrasWithContext(CGContextRef* context);

		//// -(void)drawHighlightedWithContext:(CGContextRef _Nonnull)context indices:(NSArray<ChartHighlight *> * _Nonnull)indices;
		//[Export("drawHighlightedWithContext:indices:")]
		//unsafe void DrawHighlightedWithContext(CGContextRef* context, ChartHighlight[] indices);
	}

	// @interface BubbleChartView : BarLineChartViewBase <BubbleChartDataProvider>
	[BaseType(typeof(BarLineChartViewBase), Name = "_TtC6Charts15BubbleChartView")]
	interface BubbleChartView : BubbleChartDataProvider
	{
		// -(void)initialize;
		[Export("initialize")]
		void Initialize();

		// -(void)calcMinMax;
		[Export("calcMinMax")]
		void CalcMinMax();

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
		// -(instancetype _Nonnull)initWithXVals:(NSArray<NSObject *> * _Nullable)xVals dataSets:(NSArray<id<IInterfaceChartDataSet>> * _Nullable)dataSets __attribute__((objc_designated_initializer));
		[Export("initWithXVals:dataSets:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] NSObject[] xVals, [NullAllowed] IInterfaceChartDataSet[] dataSets);
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

		// -(instancetype _Nonnull)initWithXIndex:(NSInteger)xIndex shadowH:(double)shadowH shadowL:(double)shadowL open:(double)open close:(double)close __attribute__((objc_designated_initializer));
		[Export("initWithXIndex:shadowH:shadowL:open:close:")]
		[DesignatedInitializer]
		IntPtr Constructor(nint xIndex, double shadowH, double shadowL, double open, double close);

		// -(instancetype _Nonnull)initWithXIndex:(NSInteger)xIndex shadowH:(double)shadowH shadowL:(double)shadowL open:(double)open close:(double)close data:(id _Nullable)data __attribute__((objc_designated_initializer));
		[Export("initWithXIndex:shadowH:shadowL:open:close:data:")]
		[DesignatedInitializer]
		IntPtr Constructor(nint xIndex, double shadowH, double shadowL, double open, double close, [NullAllowed] NSObject data);

		// @property (readonly, nonatomic) double shadowRange;
		[Export("shadowRange")]
		double ShadowRange { get; }

		// @property (readonly, nonatomic) double bodyRange;
		[Export("bodyRange")]
		double BodyRange { get; }

		// @property (nonatomic) double value;
		[Export("value")]
		double Value { get; set; }

		//// -(id _Nonnull)copyWithZone:(struct _NSZone * _Null_unspecified)zone;
		//[Export("copyWithZone:")]
		//unsafe NSObject CopyWithZone(_NSZone* zone);
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

	// @protocol InterfaceCandleChartDataSet <IInterfaceLineScatterCandleRadarChartDataSet>
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

		//// -(id _Nonnull)copyWithZone:(struct _NSZone * _Null_unspecified)zone;
		//[Export("copyWithZone:")]
		//unsafe NSObject CopyWithZone(_NSZone* zone);

		// -(instancetype _Nonnull)initWithLabel:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
		[Export("initWithLabel:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] string label);

		// -(instancetype _Nonnull)initWithYVals:(NSArray<ChartDataEntry *> * _Nullable)yVals label:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
		[Export("initWithYVals:label:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] ChartDataEntry[] yVals, [NullAllowed] string label);
	}

	// @interface CandleChartDataSet : LineScatterCandleRadarChartDataSet <InterfaceCandleChartDataSet>
	[BaseType(typeof(LineScatterCandleRadarChartDataSet), Name = "_TtC6Charts18CandleChartDataSet")]
	interface CandleChartDataSet : InterfaceCandleChartDataSet
	{
		// -(instancetype _Nonnull)initWithYVals:(NSArray<ChartDataEntry *> * _Nullable)yVals label:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
		[Export("initWithYVals:label:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] ChartDataEntry[] yVals, [NullAllowed] string label);

		// -(void)calcMinMaxWithStart:(NSInteger)start end:(NSInteger)end;
		[Export("calcMinMaxWithStart:end:")]
		void CalcMinMaxWithStart(nint start, nint end);

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

	// @interface LineScatterCandleRadarChartRenderer : ChartDataRendererBase
	[BaseType(typeof(ChartDataRendererBase), Name = "_TtC6Charts35LineScatterCandleRadarChartRenderer")]
	interface LineScatterCandleRadarChartRenderer
	{
		// -(instancetype _Nonnull)initWithAnimator:(ChartAnimator * _Nullable)animator viewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler __attribute__((objc_designated_initializer));
		[Export("initWithAnimator:viewPortHandler:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] ChartAnimator animator, ChartViewPortHandler viewPortHandler);

		//// -(void)drawHighlightLinesWithContext:(CGContextRef _Nonnull)context point:(CGPoint)point set:(id<IInterfaceLineScatterCandleRadarChartDataSet> _Nonnull)set;
		//[Export("drawHighlightLinesWithContext:point:set:")]
		//unsafe void DrawHighlightLinesWithContext(CGContextRef* context, CGPoint point, IInterfaceLineScatterCandleRadarChartDataSet set);
	}

	// @interface CandleStickChartRenderer : LineScatterCandleRadarChartRenderer
	[BaseType(typeof(LineScatterCandleRadarChartRenderer), Name = "_TtC6Charts24CandleStickChartRenderer")]
	interface CandleStickChartRenderer
	{
		// @property (nonatomic, weak) id<CandleChartDataProvider> _Nullable dataProvider;
		[NullAllowed, Export("dataProvider", ArgumentSemantic.Weak)]
		ICandleChartDataProvider DataProvider { get; set; }

		// -(instancetype _Nonnull)initWithDataProvider:(id<CandleChartDataProvider> _Nullable)dataProvider animator:(ChartAnimator * _Nullable)animator viewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler __attribute__((objc_designated_initializer));
		[Export("initWithDataProvider:animator:viewPortHandler:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] ICandleChartDataProvider dataProvider, [NullAllowed] ChartAnimator animator, ChartViewPortHandler viewPortHandler);

		//// -(void)drawDataWithContext:(CGContextRef _Nonnull)context;
		//[Export("drawDataWithContext:")]
		//unsafe void DrawDataWithContext(CGContextRef* context);

		//// -(void)drawDataSetWithContext:(CGContextRef _Nonnull)context dataSet:(id<InterfaceCandleChartDataSet> _Nonnull)dataSet;
		//[Export("drawDataSetWithContext:dataSet:")]
		//unsafe void DrawDataSetWithContext(CGContextRef* context, InterfaceCandleChartDataSet dataSet);

		//// -(void)drawValuesWithContext:(CGContextRef _Nonnull)context;
		//[Export("drawValuesWithContext:")]
		//unsafe void DrawValuesWithContext(CGContextRef* context);

		//// -(void)drawExtrasWithContext:(CGContextRef _Nonnull)context;
		//[Export("drawExtrasWithContext:")]
		//unsafe void DrawExtrasWithContext(CGContextRef* context);

		//// -(void)drawHighlightedWithContext:(CGContextRef _Nonnull)context indices:(NSArray<ChartHighlight *> * _Nonnull)indices;
		//[Export("drawHighlightedWithContext:indices:")]
		//unsafe void DrawHighlightedWithContext(CGContextRef* context, ChartHighlight[] indices);
	}

	// @interface CandleStickChartView : BarLineChartViewBase <CandleChartDataProvider>
	[BaseType(typeof(BarLineChartViewBase), Name = "_TtC6Charts20CandleStickChartView")]
	interface CandleStickChartView : CandleChartDataProvider
	{
		// -(void)initialize;
		[Export("initialize")]
		void Initialize();

		// -(void)calcMinMax;
		[Export("calcMinMax")]
		void CalcMinMax();

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

	// @interface ChartAnimator : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC6Charts13ChartAnimator")]
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

		// @property (nonatomic) CGFloat phaseX;
		[Export("phaseX")]
		nfloat PhaseX { get; set; }

		// @property (nonatomic) CGFloat phaseY;
		[Export("phaseY")]
		nfloat PhaseY { get; set; }

		// -(void)stop;
		[Export("stop")]
		void Stop();

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration yAxisDuration:(NSTimeInterval)yAxisDuration easingX:(CGFloat (^ _Nullable)(NSTimeInterval, NSTimeInterval))easingX easingY:(CGFloat (^ _Nullable)(NSTimeInterval, NSTimeInterval))easingY;
		[Export("animateWithXAxisDuration:yAxisDuration:easingX:easingY:")]
		void AnimateWithXAxisDuration(double xAxisDuration, double yAxisDuration, [NullAllowed] Func<double, double, nfloat> easingX, [NullAllowed] Func<double, double, nfloat> easingY);

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration yAxisDuration:(NSTimeInterval)yAxisDuration easingOptionX:(enum ChartEasingOption)easingOptionX easingOptionY:(enum ChartEasingOption)easingOptionY;
		[Export("animateWithXAxisDuration:yAxisDuration:easingOptionX:easingOptionY:")]
		void AnimateWithXAxisDuration(double xAxisDuration, double yAxisDuration, ChartEasingOption easingOptionX, ChartEasingOption easingOptionY);

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration yAxisDuration:(NSTimeInterval)yAxisDuration easing:(CGFloat (^ _Nullable)(NSTimeInterval, NSTimeInterval))easing;
		[Export("animateWithXAxisDuration:yAxisDuration:easing:")]
		void AnimateWithXAxisDuration(double xAxisDuration, double yAxisDuration, [NullAllowed] Func<double, double, nfloat> easing);

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration yAxisDuration:(NSTimeInterval)yAxisDuration easingOption:(enum ChartEasingOption)easingOption;
		[Export("animateWithXAxisDuration:yAxisDuration:easingOption:")]
		void AnimateWithXAxisDuration(double xAxisDuration, double yAxisDuration, ChartEasingOption easingOption);

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration yAxisDuration:(NSTimeInterval)yAxisDuration;
		[Export("animateWithXAxisDuration:yAxisDuration:")]
		void AnimateWithXAxisDuration(double xAxisDuration, double yAxisDuration);

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration easing:(CGFloat (^ _Nullable)(NSTimeInterval, NSTimeInterval))easing;
		[Export("animateWithXAxisDuration:easing:")]
		void AnimateWithXAxisDuration(double xAxisDuration, [NullAllowed] Func<double, double, nfloat> easing);

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration easingOption:(enum ChartEasingOption)easingOption;
		[Export("animateWithXAxisDuration:easingOption:")]
		void AnimateWithXAxisDuration(double xAxisDuration, ChartEasingOption easingOption);

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration;
		[Export("animateWithXAxisDuration:")]
		void AnimateWithXAxisDuration(double xAxisDuration);

		// -(void)animateWithYAxisDuration:(NSTimeInterval)yAxisDuration easing:(CGFloat (^ _Nullable)(NSTimeInterval, NSTimeInterval))easing;
		[Export("animateWithYAxisDuration:easing:")]
		void AnimateWithYAxisDuration(double yAxisDuration, [NullAllowed] Func<double, double, nfloat> easing);

		// -(void)animateWithYAxisDuration:(NSTimeInterval)yAxisDuration easingOption:(enum ChartEasingOption)easingOption;
		[Export("animateWithYAxisDuration:easingOption:")]
		void AnimateWithYAxisDuration(double yAxisDuration, ChartEasingOption easingOption);

		// -(void)animateWithYAxisDuration:(NSTimeInterval)yAxisDuration;
		[Export("animateWithYAxisDuration:")]
		void AnimateWithYAxisDuration(double yAxisDuration);
	}

	// @interface ChartComponentBase : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC6Charts18ChartComponentBase")]
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
	[BaseType(typeof(ChartComponentBase), Name = "_TtC6Charts13ChartAxisBase")]
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

		// @property (nonatomic) BOOL drawLimitLinesBehindDataEnabled;
		[Export("drawLimitLinesBehindDataEnabled")]
		bool DrawLimitLinesBehindDataEnabled { get; set; }

		// @property (nonatomic) BOOL gridAntialiasEnabled;
		[Export("gridAntialiasEnabled")]
		bool GridAntialiasEnabled { get; set; }

		// -(NSString * _Nonnull)getLongestLabel;
		[Export("getLongestLabel")]
		//[Verify(MethodToProperty)]
		string LongestLabel { get; }

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

		// @property (nonatomic) BOOL _customAxisMin;
		[Export("_customAxisMin")]
		bool _customAxisMin { get; set; }

		// @property (nonatomic) BOOL _customAxisMax;
		[Export("_customAxisMax")]
		bool _customAxisMax { get; set; }

		// @property (nonatomic) double _axisMinimum;
		[Export("_axisMinimum")]
		double _axisMinimum { get; set; }

		// @property (nonatomic) double _axisMaximum;
		[Export("_axisMaximum")]
		double _axisMaximum { get; set; }

		// @property (nonatomic) double axisRange;
		[Export("axisRange")]
		double AxisRange { get; set; }

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
	}

	// @interface ChartAxisRendererBase : ChartRendererBase
	[BaseType(typeof(ChartRendererBase), Name = "_TtC6Charts21ChartAxisRendererBase")]
	interface ChartAxisRendererBase
	{
		// @property (nonatomic, strong) ChartTransformer * _Null_unspecified transformer;
		[Export("transformer", ArgumentSemantic.Strong)]
		ChartTransformer Transformer { get; set; }

		// -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler transformer:(ChartTransformer * _Null_unspecified)transformer __attribute__((objc_designated_initializer));
		[Export("initWithViewPortHandler:transformer:")]
		[DesignatedInitializer]
		IntPtr Constructor(ChartViewPortHandler viewPortHandler, ChartTransformer transformer);

		//// -(void)renderAxisLabelsWithContext:(CGContextRef _Nonnull)context;
		//[Export("renderAxisLabelsWithContext:")]
		//unsafe void RenderAxisLabelsWithContext(CGContextRef* context);

		//// -(void)renderGridLinesWithContext:(CGContextRef _Nonnull)context;
		//[Export("renderGridLinesWithContext:")]
		//unsafe void RenderGridLinesWithContext(CGContextRef* context);

		//// -(void)renderAxisLineWithContext:(CGContextRef _Nonnull)context;
		//[Export("renderAxisLineWithContext:")]
		//unsafe void RenderAxisLineWithContext(CGContextRef* context);

		//// -(void)renderLimitLinesWithContext:(CGContextRef _Nonnull)context;
		//[Export("renderLimitLinesWithContext:")]
		//unsafe void RenderLimitLinesWithContext(CGContextRef* context);
	}

	// @interface ChartColorTemplates : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC6Charts19ChartColorTemplates")]
	interface ChartColorTemplates
	{
		// +(NSArray<UIColor *> * _Nonnull)liberty;
		[Static]
		[Export("liberty")]
		//[Verify(MethodToProperty)]
		UIColor[] Liberty { get; }

		// +(NSArray<UIColor *> * _Nonnull)joyful;
		[Static]
		[Export("joyful")]
		//[Verify(MethodToProperty)]
		UIColor[] Joyful { get; }

		// +(NSArray<UIColor *> * _Nonnull)pastel;
		[Static]
		[Export("pastel")]
		//[Verify(MethodToProperty)]
		UIColor[] Pastel { get; }

		// +(NSArray<UIColor *> * _Nonnull)colorful;
		[Static]
		[Export("colorful")]
		//[Verify(MethodToProperty)]
		UIColor[] Colorful { get; }

		// +(NSArray<UIColor *> * _Nonnull)vordiplom;
		[Static]
		[Export("vordiplom")]
		//[Verify(MethodToProperty)]
		UIColor[] Vordiplom { get; }

		// +(NSArray<UIColor *> * _Nonnull)material;
		[Static]
		[Export("material")]
		//[Verify(MethodToProperty)]
		UIColor[] Material { get; }

		// +(UIColor * _Nonnull)colorFromString:(NSString * _Nonnull)colorString;
		[Static]
		[Export("colorFromString:")]
		UIColor ColorFromString(string colorString);
	}

	// @interface ChartDataBaseFilter : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC6Charts19ChartDataBaseFilter")]
	interface ChartDataBaseFilter
	{
		// -(NSArray<ChartDataEntry *> * _Nonnull)filter:(NSArray<ChartDataEntry *> * _Nonnull)points;
		[Export("filter:")]
		ChartDataEntry[] Filter(ChartDataEntry[] points);
	}

	// @interface ChartDataApproximatorFilter : ChartDataBaseFilter
	[BaseType(typeof(ChartDataBaseFilter), Name = "_TtC6Charts27ChartDataApproximatorFilter")]
	interface ChartDataApproximatorFilter
	{
		// @property (nonatomic) enum ApproximatorType type;
		[Export("type", ArgumentSemantic.Assign)]
		ApproximatorType Type { get; set; }

		// @property (nonatomic) double tolerance;
		[Export("tolerance")]
		double Tolerance { get; set; }

		// @property (nonatomic) double scaleRatio;
		[Export("scaleRatio")]
		double ScaleRatio { get; set; }

		// @property (nonatomic) double deltaRatio;
		[Export("deltaRatio")]
		double DeltaRatio { get; set; }

		// -(instancetype _Nonnull)initWithType:(enum ApproximatorType)type tolerance:(double)tolerance __attribute__((objc_designated_initializer));
		[Export("initWithType:tolerance:")]
		[DesignatedInitializer]
		IntPtr Constructor(ApproximatorType type, double tolerance);

		// -(void)setup:(enum ApproximatorType)type tolerance:(double)tolerance;
		[Export("setup:tolerance:")]
		void Setup(ApproximatorType type, double tolerance);

		// -(void)setRatios:(double)deltaRatio scaleRatio:(double)scaleRatio;
		[Export("setRatios:scaleRatio:")]
		void SetRatios(double deltaRatio, double scaleRatio);

		// -(NSArray<ChartDataEntry *> * _Nonnull)filter:(NSArray<ChartDataEntry *> * _Nonnull)points;
		[Export("filter:")]
		ChartDataEntry[] Filter(ChartDataEntry[] points);

		// -(NSArray<ChartDataEntry *> * _Nonnull)filter:(NSArray<ChartDataEntry *> * _Nonnull)points tolerance:(double)tolerance;
		[Export("filter:tolerance:")]
		ChartDataEntry[] Filter(ChartDataEntry[] points, double tolerance);
	}

	interface IChartFillFormatter { }

	// @protocol ChartFillFormatter
	[Protocol(Name = "_TtP6Charts18ChartFillFormatter_"), Model]
	interface ChartFillFormatter
	{
		// @required -(CGFloat)getFillLinePositionWithDataSet:(id<IInterfaceLineChartDataSet> _Nonnull)dataSet dataProvider:(id<LineChartDataProvider> _Nonnull)dataProvider;
		[Abstract]
		[Export("getFillLinePositionWithDataSet:dataProvider:")]
		nfloat DataProvider(IInterfaceLineChartDataSet dataSet, ILineChartDataProvider dataProvider);
	}

	// @interface ChartDefaultFillFormatter : NSObject <ChartFillFormatter>
	[BaseType(typeof(NSObject), Name = "_TtC6Charts25ChartDefaultFillFormatter")]
	interface ChartDefaultFillFormatter : ChartFillFormatter
	{
		//// -(CGFloat)getFillLinePositionWithDataSet:(id<IInterfaceLineChartDataSet> _Nonnull)dataSet dataProvider:(id<LineChartDataProvider> _Nonnull)dataProvider;
		//[Export("getFillLinePositionWithDataSet:dataProvider:")]
		//nfloat GetFillLinePositionWithDataSet(IInterfaceLineChartDataSet dataSet, ILineChartDataProvider dataProvider);
	}

	interface IChartXAxisValueFormatter { }

	// @protocol ChartXAxisValueFormatter
	[Protocol(Name = "_TtP6Charts24ChartXAxisValueFormatter_"), Model]
	interface ChartXAxisValueFormatter
	{
		// @required -(NSString * _Nonnull)stringForXValue:(NSInteger)index original:(NSString * _Nonnull)original viewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler;
		[Abstract]
		[Export("stringForXValue:original:viewPortHandler:")]
		string Original(nint index, string original, ChartViewPortHandler viewPortHandler);
	}

	// @interface ChartDefaultXAxisValueFormatter : NSObject <ChartXAxisValueFormatter>
	[BaseType(typeof(NSObject), Name = "_TtC6Charts31ChartDefaultXAxisValueFormatter")]
	interface ChartDefaultXAxisValueFormatter : ChartXAxisValueFormatter
	{
		//// -(NSString * _Nonnull)stringForXValue:(NSInteger)index original:(NSString * _Nonnull)original viewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler;
		//[Export("stringForXValue:original:viewPortHandler:")]
		//string StringForXValue(nint index, string original, ChartViewPortHandler viewPortHandler);
	}

	// @interface ChartFill : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC6Charts9ChartFill")]
	interface ChartFill
	{
		// @property (readonly, nonatomic) enum ChartFillType type;
		[Export("type")]
		ChartFillType Type { get; }

		//// @property (readonly, nonatomic) CGColorRef _Nullable color;
		//[NullAllowed, Export("color")]
		//unsafe CGColorRef* Color { get; }

		//// @property (readonly, nonatomic) CGGradientRef _Nullable gradient;
		//[NullAllowed, Export("gradient")]
		//unsafe CGGradientRef* Gradient { get; }

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

		//// @property (readonly, nonatomic) CGImageRef _Nullable image;
		//[NullAllowed, Export("image")]
		//unsafe CGImageRef* Image { get; }

		//// @property (readonly, nonatomic) CGLayerRef _Nullable layer;
		//[NullAllowed, Export("layer")]
		//unsafe CGLayerRef* Layer { get; }

		//// -(instancetype _Nonnull)initWithCGColor:(CGColorRef _Nonnull)CGColor __attribute__((objc_designated_initializer));
		//[Export("initWithCGColor:")]
		//[DesignatedInitializer]
		//unsafe IntPtr Constructor(CGColorRef* CGColor);

		// -(instancetype _Nonnull)initWithColor:(UIColor * _Nonnull)color;
		[Export("initWithColor:")]
		IntPtr Constructor(UIColor color);

		//// -(instancetype _Nonnull)initWithLinearGradient:(CGGradientRef _Nonnull)linearGradient angle:(CGFloat)angle __attribute__((objc_designated_initializer));
		//[Export("initWithLinearGradient:angle:")]
		//[DesignatedInitializer]
		//unsafe IntPtr Constructor(CGGradientRef* linearGradient, nfloat angle);

		//// -(instancetype _Nonnull)initWithRadialGradient:(CGGradientRef _Nonnull)radialGradient startOffsetPercent:(CGPoint)startOffsetPercent startRadiusPercent:(CGFloat)startRadiusPercent endOffsetPercent:(CGPoint)endOffsetPercent endRadiusPercent:(CGFloat)endRadiusPercent __attribute__((objc_designated_initializer));
		//[Export("initWithRadialGradient:startOffsetPercent:startRadiusPercent:endOffsetPercent:endRadiusPercent:")]
		//[DesignatedInitializer]
		//unsafe IntPtr Constructor(CGGradientRef* radialGradient, CGPoint startOffsetPercent, nfloat startRadiusPercent, CGPoint endOffsetPercent, nfloat endRadiusPercent);

		//// -(instancetype _Nonnull)initWithRadialGradient:(CGGradientRef _Nonnull)radialGradient;
		//[Export("initWithRadialGradient:")]
		//unsafe IntPtr Constructor(CGGradientRef* radialGradient);

		//// -(instancetype _Nonnull)initWithCGImage:(CGImageRef _Nonnull)CGImage tiled:(BOOL)tiled __attribute__((objc_designated_initializer));
		//[Export("initWithCGImage:tiled:")]
		//[DesignatedInitializer]
		//unsafe IntPtr Constructor(CGImageRef* CGImage, bool tiled);

		// -(instancetype _Nonnull)initWithImage:(UIImage * _Nonnull)image tiled:(BOOL)tiled;
		[Export("initWithImage:tiled:")]
		IntPtr Constructor(UIImage image, bool tiled);

		//// -(instancetype _Nonnull)initWithCGImage:(CGImageRef _Nonnull)CGImage;
		//[Export("initWithCGImage:")]
		//unsafe IntPtr Constructor(CGImageRef* CGImage);

		// -(instancetype _Nonnull)initWithImage:(UIImage * _Nonnull)image;
		[Export("initWithImage:")]
		IntPtr Constructor(UIImage image);

		//// -(instancetype _Nonnull)initWithCGLayer:(CGLayerRef _Nonnull)CGLayer __attribute__((objc_designated_initializer));
		//[Export("initWithCGLayer:")]
		//[DesignatedInitializer]
		//unsafe IntPtr Constructor(CGLayerRef* CGLayer);

		//// +(ChartFill * _Nonnull)fillWithCGColor:(CGColorRef _Nonnull)CGColor;
		//[Static]
		//[Export("fillWithCGColor:")]
		//unsafe ChartFill FillWithCGColor(CGColorRef* CGColor);

		// +(ChartFill * _Nonnull)fillWithColor:(UIColor * _Nonnull)color;
		[Static]
		[Export("fillWithColor:")]
		ChartFill FillWithColor(UIColor color);

		//// +(ChartFill * _Nonnull)fillWithLinearGradient:(CGGradientRef _Nonnull)linearGradient angle:(CGFloat)angle;
		//[Static]
		//[Export("fillWithLinearGradient:angle:")]
		//unsafe ChartFill FillWithLinearGradient(CGGradientRef* linearGradient, nfloat angle);

		//// +(ChartFill * _Nonnull)fillWithRadialGradient:(CGGradientRef _Nonnull)radialGradient startOffsetPercent:(CGPoint)startOffsetPercent startRadiusPercent:(CGFloat)startRadiusPercent endOffsetPercent:(CGPoint)endOffsetPercent endRadiusPercent:(CGFloat)endRadiusPercent;
		//[Static]
		//[Export("fillWithRadialGradient:startOffsetPercent:startRadiusPercent:endOffsetPercent:endRadiusPercent:")]
		//unsafe ChartFill FillWithRadialGradient(CGGradientRef* radialGradient, CGPoint startOffsetPercent, nfloat startRadiusPercent, CGPoint endOffsetPercent, nfloat endRadiusPercent);

		//// +(ChartFill * _Nonnull)fillWithRadialGradient:(CGGradientRef _Nonnull)radialGradient;
		//[Static]
		//[Export("fillWithRadialGradient:")]
		//unsafe ChartFill FillWithRadialGradient(CGGradientRef* radialGradient);

		//// +(ChartFill * _Nonnull)fillWithCGImage:(CGImageRef _Nonnull)CGImage tiled:(BOOL)tiled;
		//[Static]
		//[Export("fillWithCGImage:tiled:")]
		//unsafe ChartFill FillWithCGImage(CGImageRef* CGImage, bool tiled);

		// +(ChartFill * _Nonnull)fillWithImage:(UIImage * _Nonnull)image tiled:(BOOL)tiled;
		[Static]
		[Export("fillWithImage:tiled:")]
		ChartFill FillWithImage(UIImage image, bool tiled);

		//// +(ChartFill * _Nonnull)fillWithCGImage:(CGImageRef _Nonnull)CGImage;
		//[Static]
		//[Export("fillWithCGImage:")]
		//unsafe ChartFill FillWithCGImage(CGImageRef* CGImage);

		// +(ChartFill * _Nonnull)fillWithImage:(UIImage * _Nonnull)image;
		[Static]
		[Export("fillWithImage:")]
		ChartFill FillWithImage(UIImage image);

		//// +(ChartFill * _Nonnull)fillWithCGLayer:(CGLayerRef _Nonnull)CGLayer;
		//[Static]
		//[Export("fillWithCGLayer:")]
		//unsafe ChartFill FillWithCGLayer(CGLayerRef* CGLayer);

		//// -(void)fillPathWithContext:(CGContextRef _Nonnull)context rect:(CGRect)rect;
		//[Export("fillPathWithContext:rect:")]
		//unsafe void FillPathWithContext(CGContextRef* context, CGRect rect);
	}

	// @interface ChartHighlight : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC6Charts14ChartHighlight")]
	interface ChartHighlight
	{
		// -(instancetype _Nonnull)initWithXIndex:(NSInteger)x value:(double)value dataIndex:(NSInteger)dataIndex dataSetIndex:(NSInteger)dataSetIndex stackIndex:(NSInteger)stackIndex range:(ChartRange * _Nullable)range __attribute__((objc_designated_initializer));
		[Export("initWithXIndex:value:dataIndex:dataSetIndex:stackIndex:range:")]
		[DesignatedInitializer]
		IntPtr Constructor(nint x, double value, nint dataIndex, nint dataSetIndex, nint stackIndex, [NullAllowed] ChartRange range);

		// -(instancetype _Nonnull)initWithXIndex:(NSInteger)x value:(double)value dataIndex:(NSInteger)dataIndex dataSetIndex:(NSInteger)dataSetIndex stackIndex:(NSInteger)stackIndex;
		[Export("initWithXIndex:value:dataIndex:dataSetIndex:stackIndex:")]
		IntPtr Constructor(nint x, double value, nint dataIndex, nint dataSetIndex, nint stackIndex);

		// -(instancetype _Nonnull)initWithXIndex:(NSInteger)x value:(double)value dataSetIndex:(NSInteger)dataSetIndex stackIndex:(NSInteger)stackIndex range:(ChartRange * _Nullable)range;
		[Export("initWithXIndex:value:dataSetIndex:stackIndex:range:")]
		IntPtr Constructor(nint x, double value, nint dataSetIndex, nint stackIndex, [NullAllowed] ChartRange range);

		// -(instancetype _Nonnull)initWithXIndex:(NSInteger)x value:(double)value dataSetIndex:(NSInteger)dataSetIndex stackIndex:(NSInteger)stackIndex;
		[Export("initWithXIndex:value:dataSetIndex:stackIndex:")]
		IntPtr Constructor(nint x, double value, nint dataSetIndex, nint stackIndex);

		// -(instancetype _Nonnull)initWithXIndex:(NSInteger)x dataSetIndex:(NSInteger)dataSetIndex stackIndex:(NSInteger)stackIndex;
		[Export("initWithXIndex:dataSetIndex:stackIndex:")]
		IntPtr Constructor(nint x, nint dataSetIndex, nint stackIndex);

		// -(instancetype _Nonnull)initWithXIndex:(NSInteger)x dataSetIndex:(NSInteger)dataSetIndex;
		[Export("initWithXIndex:dataSetIndex:")]
		IntPtr Constructor(nint x, nint dataSetIndex);

		// @property (readonly, nonatomic) NSInteger xIndex;
		[Export("xIndex")]
		nint XIndex { get; }

		// @property (readonly, nonatomic) double value;
		[Export("value")]
		double Value { get; }

		// @property (readonly, nonatomic) NSInteger dataIndex;
		[Export("dataIndex")]
		nint DataIndex { get; }

		// @property (readonly, nonatomic) NSInteger dataSetIndex;
		[Export("dataSetIndex")]
		nint DataSetIndex { get; }

		// @property (readonly, nonatomic) NSInteger stackIndex;
		[Export("stackIndex")]
		nint StackIndex { get; }

		// @property (readonly, nonatomic, strong) ChartRange * _Nullable range;
		[NullAllowed, Export("range", ArgumentSemantic.Strong)]
		ChartRange Range { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export("description")]
		string Description { get; }

		// -(BOOL)isEqual:(id _Nullable)object;
		[Export("isEqual:")]
		bool IsEqual([NullAllowed] NSObject @object);
	}

	// @interface ChartLegend : ChartComponentBase
	[BaseType(typeof(ChartComponentBase), Name = "_TtC6Charts11ChartLegend")]
	interface ChartLegend
	{
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

		// -(instancetype _Nonnull)initWithColors:(NSArray<NSObject *> * _Nonnull)colors labels:(NSArray<NSObject *> * _Nonnull)labels __attribute__((objc_designated_initializer));
		[Export("initWithColors:labels:")]
		[DesignatedInitializer]
		IntPtr Constructor(NSObject[] colors, NSObject[] labels);

		// -(CGSize)getMaximumEntrySize:(UIFont * _Nonnull)font;
		[Export("getMaximumEntrySize:")]
		CGSize GetMaximumEntrySize(UIFont font);

		// -(NSString * _Nullable)getLabel:(NSInteger)index;
		[Export("getLabel:")]
		[return: NullAllowed]
		string GetLabel(nint index);

		// -(CGSize)getFullSize:(UIFont * _Nonnull)labelFont;
		[Export("getFullSize:")]
		CGSize GetFullSize(UIFont labelFont);

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

		// -(void)resetCustom;
		[Export("resetCustom")]
		void ResetCustom();

		// @property (readonly, nonatomic) BOOL isLegendCustom;
		[Export("isLegendCustom")]
		bool IsLegendCustom { get; }

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

		// -(void)setExtraWithColors:(NSArray<NSObject *> * _Nonnull)colors labels:(NSArray<NSObject *> * _Nonnull)labels;
		[Export("setExtraWithColors:labels:")]
		void SetExtraWithColors(NSObject[] colors, NSObject[] labels);

		// -(void)setCustomWithColors:(NSArray<NSObject *> * _Nonnull)colors labels:(NSArray<NSObject *> * _Nonnull)labels;
		[Export("setCustomWithColors:labels:")]
		void SetCustomWithColors(NSObject[] colors, NSObject[] labels);
	}

	// @interface ChartLegendRenderer : ChartRendererBase
	[BaseType(typeof(ChartRendererBase), Name = "_TtC6Charts19ChartLegendRenderer")]
	interface ChartLegendRenderer
	{
		// @property (nonatomic, strong) ChartLegend * _Nullable legend;
		[NullAllowed, Export("legend", ArgumentSemantic.Strong)]
		ChartLegend Legend { get; set; }

		// -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler legend:(ChartLegend * _Nullable)legend __attribute__((objc_designated_initializer));
		[Export("initWithViewPortHandler:legend:")]
		[DesignatedInitializer]
		IntPtr Constructor(ChartViewPortHandler viewPortHandler, [NullAllowed] ChartLegend legend);

		// -(void)computeLegend:(ChartData * _Nonnull)data;
		[Export("computeLegend:")]
		void ComputeLegend(ChartData data);

		//// -(void)renderLegendWithContext:(CGContextRef _Nonnull)context;
		//[Export("renderLegendWithContext:")]
		//unsafe void RenderLegendWithContext(CGContextRef* context);

		//// -(void)drawFormWithContext:(CGContextRef _Nonnull)context x:(CGFloat)x y:(CGFloat)y colorIndex:(NSInteger)colorIndex legend:(ChartLegend * _Nonnull)legend;
		//[Export("drawFormWithContext:x:y:colorIndex:legend:")]
		//unsafe void DrawFormWithContext(CGContextRef* context, nfloat x, nfloat y, nint colorIndex, ChartLegend legend);

		//// -(void)drawLabelWithContext:(CGContextRef _Nonnull)context x:(CGFloat)x y:(CGFloat)y label:(NSString * _Nonnull)label font:(UIFont * _Nonnull)font textColor:(UIColor * _Nonnull)textColor;
		//[Export("drawLabelWithContext:x:y:label:font:textColor:")]
		//unsafe void DrawLabelWithContext(CGContextRef* context, nfloat x, nfloat y, string label, UIFont font, UIColor textColor);
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

		// @property (copy, nonatomic) NSString * _Nonnull label;
		[Export("label")]
		string Label { get; set; }

		// @property (nonatomic) BOOL drawLabelEnabled;
		[Export("drawLabelEnabled")]
		bool DrawLabelEnabled { get; set; }

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

	// @interface ChartMarker : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC6Charts11ChartMarker")]
	interface ChartMarker
	{
		// @property (nonatomic, strong) UIImage * _Nullable image;
		[NullAllowed, Export("image", ArgumentSemantic.Strong)]
		UIImage Image { get; set; }

		// @property (nonatomic) CGPoint offset;
		[Export("offset", ArgumentSemantic.Assign)]
		CGPoint Offset { get; set; }

		// @property (readonly, nonatomic) CGSize size;
		[Export("size")]
		CGSize Size { get; }

		// -(CGPoint)offsetForDrawingAtPos:(CGPoint)point;
		[Export("offsetForDrawingAtPos:")]
		CGPoint OffsetForDrawingAtPos(CGPoint point);

		//// -(void)drawWithContext:(CGContextRef _Nonnull)context point:(CGPoint)point;
		//[Export("drawWithContext:point:")]
		//unsafe void DrawWithContext(CGContextRef* context, CGPoint point);

		// -(void)refreshContentWithEntry:(ChartDataEntry * _Nonnull)entry highlight:(ChartHighlight * _Nonnull)highlight;
		[Export("refreshContentWithEntry:highlight:")]
		void RefreshContentWithEntry(ChartDataEntry entry, ChartHighlight highlight);
	}

	// @interface ChartRange : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC6Charts10ChartRange")]
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

	// @interface ChartSelectionDetail : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC6Charts20ChartSelectionDetail")]
	interface ChartSelectionDetail
	{
		// -(instancetype _Nonnull)initWithY:(CGFloat)y value:(double)value dataIndex:(NSInteger)dataIndex dataSetIndex:(NSInteger)dataSetIndex dataSet:(id<IInterfaceChartDataSet> _Nonnull)dataSet __attribute__((objc_designated_initializer));
		[Export("initWithY:value:dataIndex:dataSetIndex:dataSet:")]
		[DesignatedInitializer]
		IntPtr Constructor(nfloat y, double value, nint dataIndex, nint dataSetIndex, IInterfaceChartDataSet dataSet);

		// -(instancetype _Nonnull)initWithY:(CGFloat)y value:(double)value dataSetIndex:(NSInteger)dataSetIndex dataSet:(id<IInterfaceChartDataSet> _Nonnull)dataSet;
		[Export("initWithY:value:dataSetIndex:dataSet:")]
		IntPtr Constructor(nfloat y, double value, nint dataSetIndex, IInterfaceChartDataSet dataSet);

		// -(instancetype _Nonnull)initWithValue:(double)value dataSetIndex:(NSInteger)dataSetIndex dataSet:(id<IInterfaceChartDataSet> _Nonnull)dataSet;
		[Export("initWithValue:dataSetIndex:dataSet:")]
		IntPtr Constructor(double value, nint dataSetIndex, IInterfaceChartDataSet dataSet);

		// @property (readonly, nonatomic) CGFloat y;
		[Export("y")]
		nfloat Y { get; }

		// @property (readonly, nonatomic) double value;
		[Export("value")]
		double Value { get; }

		// @property (readonly, nonatomic) NSInteger dataIndex;
		[Export("dataIndex")]
		nint DataIndex { get; }

		// @property (readonly, nonatomic) NSInteger dataSetIndex;
		[Export("dataSetIndex")]
		nint DataSetIndex { get; }

		// @property (readonly, nonatomic, strong) id<IInterfaceChartDataSet> _Nullable dataSet;
		[NullAllowed, Export("dataSet", ArgumentSemantic.Strong)]
		IInterfaceChartDataSet DataSet { get; }

		// -(BOOL)isEqual:(id _Nullable)object;
		[Export("isEqual:")]
		bool IsEqual([NullAllowed] NSObject @object);
	}

	// @interface ChartTransformer : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC6Charts16ChartTransformer")]
	interface ChartTransformer
	{
		// @property (nonatomic) CGAffineTransform _matrixValueToPx;
		[Export("_matrixValueToPx", ArgumentSemantic.Assign)]
		CGAffineTransform _matrixValueToPx { get; set; }

		// @property (nonatomic) CGAffineTransform _matrixOffset;
		[Export("_matrixOffset", ArgumentSemantic.Assign)]
		CGAffineTransform _matrixOffset { get; set; }

		// @property (nonatomic, strong) ChartViewPortHandler * _Nonnull _viewPortHandler;
		[Export("_viewPortHandler", ArgumentSemantic.Strong)]
		ChartViewPortHandler _viewPortHandler { get; set; }

		// -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler __attribute__((objc_designated_initializer));
		[Export("initWithViewPortHandler:")]
		[DesignatedInitializer]
		IntPtr Constructor(ChartViewPortHandler viewPortHandler);

		// -(void)prepareMatrixValuePxWithChartXMin:(double)chartXMin deltaX:(CGFloat)deltaX deltaY:(CGFloat)deltaY chartYMin:(double)chartYMin;
		[Export("prepareMatrixValuePxWithChartXMin:deltaX:deltaY:chartYMin:")]
		void PrepareMatrixValuePxWithChartXMin(double chartXMin, nfloat deltaX, nfloat deltaY, double chartYMin);

		// -(void)prepareMatrixOffset:(BOOL)inverted;
		[Export("prepareMatrixOffset:")]
		void PrepareMatrixOffset(bool inverted);

		// -(CGPoint)getTransformedValueBarChartWithEntry:(ChartDataEntry * _Nonnull)entry xIndex:(NSInteger)xIndex dataSetIndex:(NSInteger)dataSetIndex phaseY:(CGFloat)phaseY dataSetCount:(NSInteger)dataSetCount groupSpace:(CGFloat)groupSpace;
		[Export("getTransformedValueBarChartWithEntry:xIndex:dataSetIndex:phaseY:dataSetCount:groupSpace:")]
		CGPoint GetTransformedValueBarChartWithEntry(ChartDataEntry entry, nint xIndex, nint dataSetIndex, nfloat phaseY, nint dataSetCount, nfloat groupSpace);

		// -(CGPoint)getTransformedValueHorizontalBarChartWithEntry:(ChartDataEntry * _Nonnull)entry xIndex:(NSInteger)xIndex dataSetIndex:(NSInteger)dataSetIndex phaseY:(CGFloat)phaseY dataSetCount:(NSInteger)dataSetCount groupSpace:(CGFloat)groupSpace;
		[Export("getTransformedValueHorizontalBarChartWithEntry:xIndex:dataSetIndex:phaseY:dataSetCount:groupSpace:")]
		CGPoint GetTransformedValueHorizontalBarChartWithEntry(ChartDataEntry entry, nint xIndex, nint dataSetIndex, nfloat phaseY, nint dataSetCount, nfloat groupSpace);

		// -(CGPoint)getValueByTouchPoint:(CGPoint)point;
		[Export("getValueByTouchPoint:")]
		CGPoint GetValueByTouchPoint(CGPoint point);

		// @property (readonly, nonatomic) CGAffineTransform valueToPixelMatrix;
		[Export("valueToPixelMatrix")]
		CGAffineTransform ValueToPixelMatrix { get; }

		// @property (readonly, nonatomic) CGAffineTransform pixelToValueMatrix;
		[Export("pixelToValueMatrix")]
		CGAffineTransform PixelToValueMatrix { get; }
	}

	// @interface ChartTransformerHorizontalBarChart : ChartTransformer
	[BaseType(typeof(ChartTransformer), Name = "_TtC6Charts34ChartTransformerHorizontalBarChart")]
	interface ChartTransformerHorizontalBarChart
	{
		// -(void)prepareMatrixOffset:(BOOL)inverted;
		[Export("prepareMatrixOffset:")]
		void PrepareMatrixOffset(bool inverted);

		// -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler __attribute__((objc_designated_initializer));
		[Export("initWithViewPortHandler:")]
		[DesignatedInitializer]
		IntPtr Constructor(ChartViewPortHandler viewPortHandler);
	}

	// @protocol ChartViewDelegate
	[BaseType(typeof(NSObject), Name = "_TtP6Charts17ChartViewDelegate_")]
	[Protocol(Name = "_TtP6Charts17ChartViewDelegate_"), Model]
	interface ChartViewDelegate
	{
		// @optional -(void)chartValueSelected:(ChartViewBase * _Nonnull)chartView entry:(ChartDataEntry * _Nonnull)entry dataSetIndex:(NSInteger)dataSetIndex highlight:(ChartHighlight * _Nonnull)highlight;
		[Export("chartValueSelected:entry:dataSetIndex:highlight:")]
		void ChartValueSelected(ChartViewBase chartView, ChartDataEntry entry, nint dataSetIndex, ChartHighlight highlight);

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

	// @interface ChartViewPortHandler : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC6Charts20ChartViewPortHandler")]
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
		//[Verify(MethodToProperty)]
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
	[BaseType(typeof(ChartAxisBase), Name = "_TtC6Charts10ChartXAxis")]
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

		// @property (nonatomic) NSInteger spaceBetweenLabels;
		[Export("spaceBetweenLabels")]
		nint SpaceBetweenLabels { get; set; }

		// @property (nonatomic) NSInteger axisLabelModulus;
		[Export("axisLabelModulus")]
		nint AxisLabelModulus { get; set; }

		// @property (nonatomic) NSInteger yAxisLabelModulus;
		[Export("yAxisLabelModulus")]
		nint YAxisLabelModulus { get; set; }

		// @property (nonatomic) BOOL avoidFirstLastClippingEnabled;
		[Export("avoidFirstLastClippingEnabled")]
		bool AvoidFirstLastClippingEnabled { get; set; }

		// @property (nonatomic, strong) id<ChartXAxisValueFormatter> _Nullable valueFormatter;
		[NullAllowed, Export("valueFormatter", ArgumentSemantic.Strong)]
		IChartXAxisValueFormatter ValueFormatter { get; set; }

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

		// -(NSString * _Nonnull)getLongestLabel;
		[Export("getLongestLabel")]
		//[Verify(MethodToProperty)]
		string LongestLabel { get; }

		// @property (readonly, nonatomic) BOOL isAvoidFirstLastClippingEnabled;
		[Export("isAvoidFirstLastClippingEnabled")]
		bool IsAvoidFirstLastClippingEnabled { get; }

		// -(void)setLabelsToSkip:(NSInteger)count;
		[Export("setLabelsToSkip:")]
		void SetLabelsToSkip(nint count);

		// -(void)resetLabelsToSkip;
		[Export("resetLabelsToSkip")]
		void ResetLabelsToSkip();

		// @property (readonly, nonatomic) BOOL isAxisModulusCustom;
		[Export("isAxisModulusCustom")]
		bool IsAxisModulusCustom { get; }

		// @property (copy, nonatomic) NSArray<NSObject *> * _Nonnull valuesObjc;
		[Export("valuesObjc", ArgumentSemantic.Copy)]
		NSObject[] ValuesObjc { get; set; }
	}

	// @interface ChartXAxisRenderer : ChartAxisRendererBase
	[BaseType(typeof(ChartAxisRendererBase), Name = "_TtC6Charts18ChartXAxisRenderer")]
	interface ChartXAxisRenderer
	{
		// @property (nonatomic, strong) ChartXAxis * _Nullable xAxis;
		[NullAllowed, Export("xAxis", ArgumentSemantic.Strong)]
		ChartXAxis XAxis { get; set; }

		// -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler xAxis:(ChartXAxis * _Nonnull)xAxis transformer:(ChartTransformer * _Null_unspecified)transformer __attribute__((objc_designated_initializer));
		[Export("initWithViewPortHandler:xAxis:transformer:")]
		[DesignatedInitializer]
		IntPtr Constructor(ChartViewPortHandler viewPortHandler, ChartXAxis xAxis, ChartTransformer transformer);

		//// -(void)renderAxisLabelsWithContext:(CGContextRef _Nonnull)context;
		//[Export("renderAxisLabelsWithContext:")]
		//unsafe void RenderAxisLabelsWithContext(CGContextRef* context);

		//// -(void)renderAxisLineWithContext:(CGContextRef _Nonnull)context;
		//[Export("renderAxisLineWithContext:")]
		//unsafe void RenderAxisLineWithContext(CGContextRef* context);

		//// -(void)drawLabelsWithContext:(CGContextRef _Nonnull)context pos:(CGFloat)pos anchor:(CGPoint)anchor;
		//[Export("drawLabelsWithContext:pos:anchor:")]
		//unsafe void DrawLabelsWithContext(CGContextRef* context, nfloat pos, CGPoint anchor);

		//// -(void)drawLabelWithContext:(CGContextRef _Nonnull)context label:(NSString * _Nonnull)label xIndex:(NSInteger)xIndex x:(CGFloat)x y:(CGFloat)y attributes:(NSDictionary<NSString *,NSObject *> * _Nonnull)attributes constrainedToSize:(CGSize)constrainedToSize anchor:(CGPoint)anchor angleRadians:(CGFloat)angleRadians;
		//[Export("drawLabelWithContext:label:xIndex:x:y:attributes:constrainedToSize:anchor:angleRadians:")]
		//unsafe void DrawLabelWithContext(CGContextRef* context, string label, nint xIndex, nfloat x, nfloat y, NSDictionary<NSString, NSObject> attributes, CGSize constrainedToSize, CGPoint anchor, nfloat angleRadians);

		//// -(void)renderGridLinesWithContext:(CGContextRef _Nonnull)context;
		//[Export("renderGridLinesWithContext:")]
		//unsafe void RenderGridLinesWithContext(CGContextRef* context);

		//// -(void)renderLimitLinesWithContext:(CGContextRef _Nonnull)context;
		//[Export("renderLimitLinesWithContext:")]
		//unsafe void RenderLimitLinesWithContext(CGContextRef* context);

		//// -(void)renderLimitLineLineWithContext:(CGContextRef _Nonnull)context limitLine:(ChartLimitLine * _Nonnull)limitLine position:(CGPoint)position;
		//[Export("renderLimitLineLineWithContext:limitLine:position:")]
		//unsafe void RenderLimitLineLineWithContext(CGContextRef* context, ChartLimitLine limitLine, CGPoint position);

		//// -(void)renderLimitLineLabelWithContext:(CGContextRef _Nonnull)context limitLine:(ChartLimitLine * _Nonnull)limitLine position:(CGPoint)position yOffset:(CGFloat)yOffset;
		//[Export("renderLimitLineLabelWithContext:limitLine:position:yOffset:")]
		//unsafe void RenderLimitLineLabelWithContext(CGContextRef* context, ChartLimitLine limitLine, CGPoint position, nfloat yOffset);
	}

	// @interface ChartXAxisRendererBarChart : ChartXAxisRenderer
	[BaseType(typeof(ChartXAxisRenderer), Name = "_TtC6Charts26ChartXAxisRendererBarChart")]
	interface ChartXAxisRendererBarChart
	{
		// @property (nonatomic, weak) BarChartView * _Nullable chart;
		[NullAllowed, Export("chart", ArgumentSemantic.Weak)]
		BarChartView Chart { get; set; }

		// -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler xAxis:(ChartXAxis * _Nonnull)xAxis transformer:(ChartTransformer * _Null_unspecified)transformer chart:(BarChartView * _Nonnull)chart __attribute__((objc_designated_initializer));
		[Export("initWithViewPortHandler:xAxis:transformer:chart:")]
		[DesignatedInitializer]
		IntPtr Constructor(ChartViewPortHandler viewPortHandler, ChartXAxis xAxis, ChartTransformer transformer, BarChartView chart);

		//// -(void)drawLabelsWithContext:(CGContextRef _Nonnull)context pos:(CGFloat)pos anchor:(CGPoint)anchor;
		//[Export("drawLabelsWithContext:pos:anchor:")]
		//unsafe void DrawLabelsWithContext(CGContextRef* context, nfloat pos, CGPoint anchor);

		//// -(void)renderGridLinesWithContext:(CGContextRef _Nonnull)context;
		//[Export("renderGridLinesWithContext:")]
		//unsafe void RenderGridLinesWithContext(CGContextRef* context);
	}

	// @interface ChartXAxisRendererHorizontalBarChart : ChartXAxisRendererBarChart
	[BaseType(typeof(ChartXAxisRendererBarChart), Name = "_TtC6Charts36ChartXAxisRendererHorizontalBarChart")]
	interface ChartXAxisRendererHorizontalBarChart
	{
		// -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler xAxis:(ChartXAxis * _Nonnull)xAxis transformer:(ChartTransformer * _Null_unspecified)transformer chart:(BarChartView * _Nonnull)chart __attribute__((objc_designated_initializer));
		[Export("initWithViewPortHandler:xAxis:transformer:chart:")]
		[DesignatedInitializer]
		IntPtr Constructor(ChartViewPortHandler viewPortHandler, ChartXAxis xAxis, ChartTransformer transformer, BarChartView chart);

		//// -(void)renderAxisLabelsWithContext:(CGContextRef _Nonnull)context;
		//[Export("renderAxisLabelsWithContext:")]
		//unsafe void RenderAxisLabelsWithContext(CGContextRef* context);

		//// -(void)drawLabelsWithContext:(CGContextRef _Nonnull)context pos:(CGFloat)pos anchor:(CGPoint)anchor;
		//[Export("drawLabelsWithContext:pos:anchor:")]
		//unsafe void DrawLabelsWithContext(CGContextRef* context, nfloat pos, CGPoint anchor);

		//// -(void)drawLabelWithContext:(CGContextRef _Nonnull)context label:(NSString * _Nonnull)label xIndex:(NSInteger)xIndex x:(CGFloat)x y:(CGFloat)y attributes:(NSDictionary<NSString *,NSObject *> * _Nonnull)attributes anchor:(CGPoint)anchor angleRadians:(CGFloat)angleRadians;
		//[Export("drawLabelWithContext:label:xIndex:x:y:attributes:anchor:angleRadians:")]
		//unsafe void DrawLabelWithContext(CGContextRef* context, string label, nint xIndex, nfloat x, nfloat y, NSDictionary<NSString, NSObject> attributes, CGPoint anchor, nfloat angleRadians);

		//// -(void)renderGridLinesWithContext:(CGContextRef _Nonnull)context;
		//[Export("renderGridLinesWithContext:")]
		//unsafe void RenderGridLinesWithContext(CGContextRef* context);

		//// -(void)renderAxisLineWithContext:(CGContextRef _Nonnull)context;
		//[Export("renderAxisLineWithContext:")]
		//unsafe void RenderAxisLineWithContext(CGContextRef* context);

		//// -(void)renderLimitLinesWithContext:(CGContextRef _Nonnull)context;
		//[Export("renderLimitLinesWithContext:")]
		//unsafe void RenderLimitLinesWithContext(CGContextRef* context);
	}

	// @interface ChartXAxisRendererRadarChart : ChartXAxisRenderer
	[BaseType(typeof(ChartXAxisRenderer), Name = "_TtC6Charts28ChartXAxisRendererRadarChart")]
	interface ChartXAxisRendererRadarChart
	{
		// @property (nonatomic, weak) RadarChartView * _Nullable chart;
		[NullAllowed, Export("chart", ArgumentSemantic.Weak)]
		RadarChartView Chart { get; set; }

		// -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler xAxis:(ChartXAxis * _Nonnull)xAxis chart:(RadarChartView * _Nonnull)chart __attribute__((objc_designated_initializer));
		[Export("initWithViewPortHandler:xAxis:chart:")]
		[DesignatedInitializer]
		IntPtr Constructor(ChartViewPortHandler viewPortHandler, ChartXAxis xAxis, RadarChartView chart);

		//// -(void)renderAxisLabelsWithContext:(CGContextRef _Nonnull)context;
		//[Export("renderAxisLabelsWithContext:")]
		//unsafe void RenderAxisLabelsWithContext(CGContextRef* context);

		//// -(void)drawLabelWithContext:(CGContextRef _Nonnull)context label:(NSString * _Nonnull)label xIndex:(NSInteger)xIndex x:(CGFloat)x y:(CGFloat)y attributes:(NSDictionary<NSString *,NSObject *> * _Nonnull)attributes anchor:(CGPoint)anchor angleRadians:(CGFloat)angleRadians;
		//[Export("drawLabelWithContext:label:xIndex:x:y:attributes:anchor:angleRadians:")]
		//unsafe void DrawLabelWithContext(CGContextRef* context, string label, nint xIndex, nfloat x, nfloat y, NSDictionary<NSString, NSObject> attributes, CGPoint anchor, nfloat angleRadians);

		//// -(void)renderLimitLinesWithContext:(CGContextRef _Nonnull)context;
		//[Export("renderLimitLinesWithContext:")]
		//unsafe void RenderLimitLinesWithContext(CGContextRef* context);
	}

	// @interface ChartYAxis : ChartAxisBase
	[BaseType(typeof(ChartAxisBase), Name = "_TtC6Charts10ChartYAxis")]
	interface ChartYAxis
	{
		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nonnull entries;
		[Export("entries", ArgumentSemantic.Copy)]
		NSNumber[] Entries { get; set; }

		// @property (readonly, nonatomic) NSInteger entryCount;
		[Export("entryCount")]
		nint EntryCount { get; }

		// @property (nonatomic) BOOL drawTopYLabelEntryEnabled;
		[Export("drawTopYLabelEntryEnabled")]
		bool DrawTopYLabelEntryEnabled { get; set; }

		// @property (nonatomic) BOOL showOnlyMinMaxEnabled;
		[Export("showOnlyMinMaxEnabled")]
		bool ShowOnlyMinMaxEnabled { get; set; }

		// @property (nonatomic) BOOL inverted;
		[Export("inverted")]
		bool Inverted { get; set; }

		// @property (nonatomic) BOOL startAtZeroEnabled;
		[Export("startAtZeroEnabled")]
		bool StartAtZeroEnabled { get; set; }

		// @property (nonatomic) BOOL forceLabelsEnabled;
		[Export("forceLabelsEnabled")]
		bool ForceLabelsEnabled { get; set; }

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

		// @property (nonatomic, strong) NSNumberFormatter * _Nullable valueFormatter;
		[NullAllowed, Export("valueFormatter", ArgumentSemantic.Strong)]
		NSNumberFormatter ValueFormatter { get; set; }

		// @property (nonatomic, strong) NSNumberFormatter * _Nonnull _defaultValueFormatter;
		[Export("_defaultValueFormatter", ArgumentSemantic.Strong)]
		NSNumberFormatter _defaultValueFormatter { get; set; }

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

		// @property (nonatomic) BOOL granularityEnabled;
		[Export("granularityEnabled")]
		bool GranularityEnabled { get; set; }

		// @property (nonatomic) double granularity;
		[Export("granularity")]
		double Granularity { get; set; }

		// -(instancetype _Nonnull)initWithPosition:(enum AxisDependency)position __attribute__((objc_designated_initializer));
		[Export("initWithPosition:")]
		[DesignatedInitializer]
		IntPtr Constructor(AxisDependency position);

		// @property (readonly, nonatomic) enum AxisDependency axisDependency;
		[Export("axisDependency")]
		AxisDependency AxisDependency { get; }

		// -(void)setLabelCount:(NSInteger)count force:(BOOL)force;
		[Export("setLabelCount:force:")]
		void SetLabelCount(nint count, bool force);

		// @property (nonatomic) NSInteger labelCount;
		[Export("labelCount")]
		nint LabelCount { get; set; }

		// -(CGSize)requiredSize;
		[Export("requiredSize")]
		////[Verify(MethodToProperty)]
		CGSize RequiredSize { get; }

		// -(CGFloat)getRequiredHeightSpace;
		[Export("getRequiredHeightSpace")]
		////[Verify(MethodToProperty)]
		nfloat RequiredHeightSpace { get; }

		// -(NSString * _Nonnull)getLongestLabel;
		[Export("getLongestLabel")]
		//[Verify(MethodToProperty)]
		string LongestLabel { get; }

		// -(NSString * _Nonnull)getFormattedLabel:(NSInteger)index;
		[Export("getFormattedLabel:")]
		string GetFormattedLabel(nint index);

		// @property (readonly, nonatomic) BOOL needsOffset;
		[Export("needsOffset")]
		bool NeedsOffset { get; }

		// @property (readonly, nonatomic) BOOL isInverted;
		[Export("isInverted")]
		bool IsInverted { get; }

		// @property (readonly, nonatomic) BOOL isStartAtZeroEnabled;
		[Export("isStartAtZeroEnabled")]
		bool IsStartAtZeroEnabled { get; }

		// @property (readonly, nonatomic) BOOL isForceLabelsEnabled;
		[Export("isForceLabelsEnabled")]
		bool IsForceLabelsEnabled { get; }

		// @property (readonly, nonatomic) BOOL isShowOnlyMinMaxEnabled;
		[Export("isShowOnlyMinMaxEnabled")]
		bool IsShowOnlyMinMaxEnabled { get; }

		// @property (readonly, nonatomic) BOOL isDrawTopYLabelEntryEnabled;
		[Export("isDrawTopYLabelEntryEnabled")]
		bool IsDrawTopYLabelEntryEnabled { get; }

		// -(void)calculateWithMin:(double)dataMin max:(double)dataMax;
		[Export("calculateWithMin:max:")]
		void CalculateWithMin(double dataMin, double dataMax);
	}

	// @interface ChartYAxisRenderer : ChartAxisRendererBase
	[BaseType(typeof(ChartAxisRendererBase), Name = "_TtC6Charts18ChartYAxisRenderer")]
	interface ChartYAxisRenderer
	{
		// @property (nonatomic, strong) ChartYAxis * _Nullable yAxis;
		[NullAllowed, Export("yAxis", ArgumentSemantic.Strong)]
		ChartYAxis YAxis { get; set; }

		// -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler yAxis:(ChartYAxis * _Nonnull)yAxis transformer:(ChartTransformer * _Null_unspecified)transformer __attribute__((objc_designated_initializer));
		[Export("initWithViewPortHandler:yAxis:transformer:")]
		[DesignatedInitializer]
		IntPtr Constructor(ChartViewPortHandler viewPortHandler, ChartYAxis yAxis, ChartTransformer transformer);

		// -(void)computeAxisWithYMin:(double)yMin yMax:(double)yMax;
		[Export("computeAxisWithYMin:yMax:")]
		void ComputeAxisWithYMin(double yMin, double yMax);

		// -(void)computeAxisValuesWithMin:(double)min max:(double)max;
		[Export("computeAxisValuesWithMin:max:")]
		void ComputeAxisValuesWithMin(double min, double max);

		//// -(void)renderAxisLabelsWithContext:(CGContextRef _Nonnull)context;
		//[Export("renderAxisLabelsWithContext:")]
		//unsafe void RenderAxisLabelsWithContext(CGContextRef* context);

		//// -(void)renderAxisLineWithContext:(CGContextRef _Nonnull)context;
		//[Export("renderAxisLineWithContext:")]
		//unsafe void RenderAxisLineWithContext(CGContextRef* context);

		//// -(void)drawYLabelsWithContext:(CGContextRef _Nonnull)context fixedPosition:(CGFloat)fixedPosition offset:(CGFloat)offset textAlign:(NSTextAlignment)textAlign;
		//[Export("drawYLabelsWithContext:fixedPosition:offset:textAlign:")]
		//unsafe void DrawYLabelsWithContext(CGContextRef* context, nfloat fixedPosition, nfloat offset, NSTextAlignment textAlign);

		//// -(void)renderGridLinesWithContext:(CGContextRef _Nonnull)context;
		//[Export("renderGridLinesWithContext:")]
		//unsafe void RenderGridLinesWithContext(CGContextRef* context);

		//// -(void)drawZeroLineWithContext:(CGContextRef _Nonnull)context x1:(CGFloat)x1 x2:(CGFloat)x2 y1:(CGFloat)y1 y2:(CGFloat)y2;
		//[Export("drawZeroLineWithContext:x1:x2:y1:y2:")]
		//unsafe void DrawZeroLineWithContext(CGContextRef* context, nfloat x1, nfloat x2, nfloat y1, nfloat y2);

		//// -(void)renderLimitLinesWithContext:(CGContextRef _Nonnull)context;
		//[Export("renderLimitLinesWithContext:")]
		//unsafe void RenderLimitLinesWithContext(CGContextRef* context);
	}

	// @interface ChartYAxisRendererHorizontalBarChart : ChartYAxisRenderer
	[BaseType(typeof(ChartYAxisRenderer), Name = "_TtC6Charts36ChartYAxisRendererHorizontalBarChart")]
	interface ChartYAxisRendererHorizontalBarChart
	{
		// -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler yAxis:(ChartYAxis * _Nonnull)yAxis transformer:(ChartTransformer * _Null_unspecified)transformer __attribute__((objc_designated_initializer));
		[Export("initWithViewPortHandler:yAxis:transformer:")]
		[DesignatedInitializer]
		IntPtr Constructor(ChartViewPortHandler viewPortHandler, ChartYAxis yAxis, ChartTransformer transformer);

		// -(void)computeAxisWithYMin:(double)yMin yMax:(double)yMax;
		[Export("computeAxisWithYMin:yMax:")]
		void ComputeAxisWithYMin(double yMin, double yMax);

		//// -(void)renderAxisLabelsWithContext:(CGContextRef _Nonnull)context;
		//[Export("renderAxisLabelsWithContext:")]
		//unsafe void RenderAxisLabelsWithContext(CGContextRef* context);

		//// -(void)renderAxisLineWithContext:(CGContextRef _Nonnull)context;
		//[Export("renderAxisLineWithContext:")]
		//unsafe void RenderAxisLineWithContext(CGContextRef* context);

		//// -(void)renderGridLinesWithContext:(CGContextRef _Nonnull)context;
		//[Export("renderGridLinesWithContext:")]
		//unsafe void RenderGridLinesWithContext(CGContextRef* context);

		//// -(void)renderLimitLinesWithContext:(CGContextRef _Nonnull)context;
		//[Export("renderLimitLinesWithContext:")]
		//unsafe void RenderLimitLinesWithContext(CGContextRef* context);
	}

	// @interface ChartYAxisRendererRadarChart : ChartYAxisRenderer
	[BaseType(typeof(ChartYAxisRenderer), Name = "_TtC6Charts28ChartYAxisRendererRadarChart")]
	interface ChartYAxisRendererRadarChart
	{
		// -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler yAxis:(ChartYAxis * _Nonnull)yAxis chart:(RadarChartView * _Nonnull)chart __attribute__((objc_designated_initializer));
		[Export("initWithViewPortHandler:yAxis:chart:")]
		[DesignatedInitializer]
		IntPtr Constructor(ChartViewPortHandler viewPortHandler, ChartYAxis yAxis, RadarChartView chart);

		// -(void)computeAxisWithYMin:(double)yMin yMax:(double)yMax;
		[Export("computeAxisWithYMin:yMax:")]
		void ComputeAxisWithYMin(double yMin, double yMax);

		// -(void)computeAxisValuesWithMin:(double)yMin max:(double)yMax;
		[Export("computeAxisValuesWithMin:max:")]
		void ComputeAxisValuesWithMin(double yMin, double yMax);

		//// -(void)renderAxisLabelsWithContext:(CGContextRef _Nonnull)context;
		//[Export("renderAxisLabelsWithContext:")]
		//unsafe void RenderAxisLabelsWithContext(CGContextRef* context);

		//// -(void)renderLimitLinesWithContext:(CGContextRef _Nonnull)context;
		//[Export("renderLimitLinesWithContext:")]
		//unsafe void RenderLimitLinesWithContext(CGContextRef* context);
	}

	// @interface CombinedChartData : BarLineScatterCandleBubbleChartData
	[BaseType(typeof(BarLineScatterCandleBubbleChartData), Name = "_TtC6Charts17CombinedChartData")]
	interface CombinedChartData
	{
		// -(instancetype _Nonnull)initWithXVals:(NSArray<NSObject *> * _Nullable)xVals dataSets:(NSArray<id<IInterfaceChartDataSet>> * _Nullable)dataSets __attribute__((objc_designated_initializer));
		[Export("initWithXVals:dataSets:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] NSObject[] xVals, [NullAllowed] IInterfaceChartDataSet[] dataSets);

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

		// @property (readonly, copy, nonatomic) NSArray<ChartData *> * _Nonnull allData;
		[Export("allData", ArgumentSemantic.Copy)]
		ChartData[] AllData { get; }

		// -(void)notifyDataChanged;
		[Export("notifyDataChanged")]
		void NotifyDataChanged();

		// -(ChartDataEntry * _Nullable)getEntryForHighlight:(ChartHighlight * _Nonnull)highlight;
		[Export("getEntryForHighlight:")]
		[return: NullAllowed]
		ChartDataEntry GetEntryForHighlight(ChartHighlight highlight);
	}

	// @interface CombinedChartRenderer : ChartDataRendererBase
	[BaseType(typeof(ChartDataRendererBase), Name = "_TtC6Charts21CombinedChartRenderer")]
	interface CombinedChartRenderer
	{
		// @property (nonatomic, weak) CombinedChartView * _Nullable chart;
		[NullAllowed, Export("chart", ArgumentSemantic.Weak)]
		CombinedChartView Chart { get; set; }

		// @property (nonatomic) BOOL drawHighlightArrowEnabled;
		[Export("drawHighlightArrowEnabled")]
		bool DrawHighlightArrowEnabled { get; set; }

		// @property (nonatomic) BOOL drawValueAboveBarEnabled;
		[Export("drawValueAboveBarEnabled")]
		bool DrawValueAboveBarEnabled { get; set; }

		// @property (nonatomic) BOOL drawBarShadowEnabled;
		[Export("drawBarShadowEnabled")]
		bool DrawBarShadowEnabled { get; set; }

		// @property (copy, nonatomic) NSArray<ChartDataRendererBase *> * _Nonnull _renderers;
		[Export("_renderers", ArgumentSemantic.Copy)]
		ChartDataRendererBase[] _renderers { get; set; }

		// -(instancetype _Nonnull)initWithChart:(CombinedChartView * _Nonnull)chart animator:(ChartAnimator * _Nonnull)animator viewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler __attribute__((objc_designated_initializer));
		[Export("initWithChart:animator:viewPortHandler:")]
		[DesignatedInitializer]
		IntPtr Constructor(CombinedChartView chart, ChartAnimator animator, ChartViewPortHandler viewPortHandler);

		// -(void)createRenderers;
		[Export("createRenderers")]
		void CreateRenderers();

		//// -(void)drawDataWithContext:(CGContextRef _Nonnull)context;
		//[Export("drawDataWithContext:")]
		//unsafe void DrawDataWithContext(CGContextRef* context);

		//// -(void)drawValuesWithContext:(CGContextRef _Nonnull)context;
		//[Export("drawValuesWithContext:")]
		//unsafe void DrawValuesWithContext(CGContextRef* context);

		//// -(void)drawExtrasWithContext:(CGContextRef _Nonnull)context;
		//[Export("drawExtrasWithContext:")]
		//unsafe void DrawExtrasWithContext(CGContextRef* context);

		//// -(void)drawHighlightedWithContext:(CGContextRef _Nonnull)context indices:(NSArray<ChartHighlight *> * _Nonnull)indices;
		//[Export("drawHighlightedWithContext:indices:")]
		//unsafe void DrawHighlightedWithContext(CGContextRef* context, ChartHighlight[] indices);

		// -(void)calcXBoundsWithChart:(id<BarLineScatterCandleBubbleChartDataProvider> _Nonnull)chart xAxisModulus:(NSInteger)xAxisModulus;
		[Export("calcXBoundsWithChart:xAxisModulus:")]
		void CalcXBoundsWithChart(IBarLineScatterCandleBubbleChartDataProvider chart, nint xAxisModulus);

		// -(ChartDataRendererBase * _Nullable)getSubRendererWithIndex:(NSInteger)index;
		[Export("getSubRendererWithIndex:")]
		[return: NullAllowed]
		ChartDataRendererBase GetSubRendererWithIndex(nint index);

		// @property (copy, nonatomic) NSArray<ChartDataRendererBase *> * _Nonnull subRenderers;
		[Export("subRenderers", ArgumentSemantic.Copy)]
		ChartDataRendererBase[] SubRenderers { get; set; }

		// @property (readonly, nonatomic) BOOL isDrawHighlightArrowEnabled;
		[Export("isDrawHighlightArrowEnabled")]
		bool IsDrawHighlightArrowEnabled { get; }

		// @property (readonly, nonatomic) BOOL isDrawValueAboveBarEnabled;
		[Export("isDrawValueAboveBarEnabled")]
		bool IsDrawValueAboveBarEnabled { get; }

		// @property (readonly, nonatomic) BOOL isDrawBarShadowEnabled;
		[Export("isDrawBarShadowEnabled")]
		bool IsDrawBarShadowEnabled { get; }
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

	// @interface CombinedChartView : BarLineChartViewBase <BarChartDataProvider, ScatterChartDataProvider, CandleChartDataProvider, BubbleChartDataProvider, LineChartDataProvider>
	[BaseType(typeof(BarLineChartViewBase), Name = "_TtC6Charts17CombinedChartView")]
	interface CombinedChartView : BarChartDataProvider, ScatterChartDataProvider, CandleChartDataProvider, BubbleChartDataProvider, LineChartDataProvider
	{
		// @property (nonatomic, strong) id<ChartFillFormatter> _Null_unspecified _fillFormatter;
		[Export("_fillFormatter", ArgumentSemantic.Strong)]
		IChartFillFormatter _fillFormatter { get; set; }

		// -(void)initialize;
		[Export("initialize")]
		void Initialize();

		// -(void)calcMinMax;
		[Export("calcMinMax")]
		void CalcMinMax();

		// @property (nonatomic, strong) ChartData * _Nullable data;
		[NullAllowed, Export("data", ArgumentSemantic.Strong)]
		ChartData Data { get; set; }

		// @property (nonatomic, strong) id<ChartFillFormatter> _Nonnull fillFormatter;
		[Export("fillFormatter", ArgumentSemantic.Strong)]
		IChartFillFormatter FillFormatter { get; set; }

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

		// @property (nonatomic) BOOL drawHighlightArrowEnabled;
		[Export("drawHighlightArrowEnabled")]
		bool DrawHighlightArrowEnabled { get; set; }

		// @property (nonatomic) BOOL drawValueAboveBarEnabled;
		[Export("drawValueAboveBarEnabled")]
		bool DrawValueAboveBarEnabled { get; set; }

		// @property (nonatomic) BOOL drawBarShadowEnabled;
		[Export("drawBarShadowEnabled")]
		bool DrawBarShadowEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isDrawHighlightArrowEnabled;
		[Export("isDrawHighlightArrowEnabled")]
		bool IsDrawHighlightArrowEnabled { get; }

		// @property (readonly, nonatomic) BOOL isDrawValueAboveBarEnabled;
		[Export("isDrawValueAboveBarEnabled")]
		bool IsDrawValueAboveBarEnabled { get; }

		// @property (readonly, nonatomic) BOOL isDrawBarShadowEnabled;
		[Export("isDrawBarShadowEnabled")]
		bool IsDrawBarShadowEnabled { get; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nonnull drawOrder;
		[Export("drawOrder", ArgumentSemantic.Copy)]
		NSNumber[] DrawOrder { get; set; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor(CGRect frame);

		//// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		//[Export("initWithCoder:")]
		//[DesignatedInitializer]
		//IntPtr Constructor(NSCoder aDecoder);
	}

	// @interface CombinedHighlighter : ChartHighlighter
	[BaseType(typeof(ChartHighlighter), Name = "_TtC6Charts19CombinedHighlighter")]
	interface CombinedHighlighter
	{
		// -(instancetype _Nonnull)initWithChart:(BarLineChartViewBase * _Nonnull)chart __attribute__((objc_designated_initializer));
		[Export("initWithChart:")]
		[DesignatedInitializer]
		IntPtr Constructor(BarLineChartViewBase chart);
	}

	// @interface HorizontalBarChartHighlighter : BarChartHighlighter
	[BaseType(typeof(BarChartHighlighter), Name = "_TtC6Charts29HorizontalBarChartHighlighter")]
	interface HorizontalBarChartHighlighter
	{
		// -(ChartHighlight * _Nullable)getHighlightWithX:(CGFloat)x y:(CGFloat)y;
		[Export("getHighlightWithX:y:")]
		[return: NullAllowed]
		ChartHighlight GetHighlightWithX(nfloat x, nfloat y);

		// -(NSInteger)getXIndex:(CGFloat)x;
		[Export("getXIndex:")]
		nint GetXIndex(nfloat x);

		// -(double)getBase:(CGFloat)y;
		[Export("getBase:")]
		double GetBase(nfloat y);

		// -(instancetype _Nonnull)initWithChart:(BarLineChartViewBase * _Nonnull)chart __attribute__((objc_designated_initializer));
		[Export("initWithChart:")]
		[DesignatedInitializer]
		IntPtr Constructor(BarLineChartViewBase chart);
	}

	// @interface HorizontalBarChartRenderer : BarChartRenderer
	[BaseType(typeof(BarChartRenderer), Name = "_TtC6Charts26HorizontalBarChartRenderer")]
	interface HorizontalBarChartRenderer
	{
		// -(instancetype _Nonnull)initWithDataProvider:(id<BarChartDataProvider> _Nullable)dataProvider animator:(ChartAnimator * _Nullable)animator viewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler __attribute__((objc_designated_initializer));
		[Export("initWithDataProvider:animator:viewPortHandler:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] IBarChartDataProvider dataProvider, [NullAllowed] ChartAnimator animator, ChartViewPortHandler viewPortHandler);

		//// -(void)drawDataSetWithContext:(CGContextRef _Nonnull)context dataSet:(id<IInterfaceBarChartDataSet> _Nonnull)dataSet index:(NSInteger)index;
		//[Export("drawDataSetWithContext:dataSet:index:")]
		//unsafe void DrawDataSetWithContext(CGContextRef* context, IInterfaceBarChartDataSet dataSet, nint index);

		//// -(void)drawValuesWithContext:(CGContextRef _Nonnull)context;
		//[Export("drawValuesWithContext:")]
		//unsafe void DrawValuesWithContext(CGContextRef* context);

		// -(BOOL)passesCheck;
		[Export("passesCheck")]
		////[Verify(MethodToProperty)]
		bool PassesCheck { get; }
	}

	// @interface HorizontalBarChartView : BarChartView
	[BaseType(typeof(BarChartView), Name = "_TtC6Charts22HorizontalBarChartView")]
	interface HorizontalBarChartView
	{
		// -(void)initialize;
		[Export("initialize")]
		void Initialize();

		// -(void)calculateOffsets;
		[Export("calculateOffsets")]
		void CalculateOffsets();

		// -(void)prepareValuePxMatrix;
		[Export("prepareValuePxMatrix")]
		void PrepareValuePxMatrix();

		// -(void)calcModulus;
		[Export("calcModulus")]
		void CalcModulus();

		// -(CGRect)getBarBounds:(BarChartDataEntry * _Nonnull)e;
		[Export("getBarBounds:")]
		CGRect GetBarBounds(BarChartDataEntry e);

		// -(CGPoint)getPosition:(ChartDataEntry * _Nonnull)e axis:(enum AxisDependency)axis;
		[Export("getPosition:axis:")]
		CGPoint GetPosition(ChartDataEntry e, AxisDependency axis);

		// -(ChartHighlight * _Nullable)getHighlightByTouchPoint:(CGPoint)pt;
		[Export("getHighlightByTouchPoint:")]
		[return: NullAllowed]
		ChartHighlight GetHighlightByTouchPoint(CGPoint pt);

		// @property (readonly, nonatomic) NSInteger lowestVisibleXIndex;
		[Export("lowestVisibleXIndex")]
		nint LowestVisibleXIndex { get; }

		// @property (readonly, nonatomic) NSInteger highestVisibleXIndex;
		[Export("highestVisibleXIndex")]
		nint HighestVisibleXIndex { get; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor(CGRect frame);

		//// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		//[Export("initWithCoder:")]
		//[DesignatedInitializer]
		//IntPtr Constructor(NSCoder aDecoder);
	}

	// @protocol InterfaceLineRadarChartDataSet <IInterfaceLineScatterCandleRadarChartDataSet>
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

	// @protocol IInterfaceLineChartDataSet <InterfaceLineRadarChartDataSet>
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

		// @required -(UIColor * _Nullable)getCircleColor:(NSInteger)index;
		[Abstract]
		[Export("getCircleColor:")]
		[return: NullAllowed]
		UIColor GetCircleColor(nint index);

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

		// @required @property (nonatomic, strong) id<ChartFillFormatter> _Nullable fillFormatter;
		[Abstract]
		[NullAllowed, Export("fillFormatter", ArgumentSemantic.Strong)]
		IChartFillFormatter FillFormatter { get; set; }
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
	}

	// @protocol InterfaceRadarChartDataSet <InterfaceLineRadarChartDataSet>
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

	// @protocol InterfaceScatterChartDataSet <IInterfaceLineScatterCandleRadarChartDataSet>
	[Protocol(Name = "_TtP6Charts20IScatterChartDataSet_"), Model]
	interface InterfaceScatterChartDataSet : InterfaceLineScatterCandleRadarChartDataSet
	{
		// @required @property (nonatomic) CGFloat scatterShapeSize;
		[Abstract]
		[Export("scatterShapeSize")]
		nfloat ScatterShapeSize { get; set; }

		// @required @property (nonatomic) enum ScatterShape scatterShape;
		[Abstract]
		[Export("scatterShape", ArgumentSemantic.Assign)]
		ScatterShape ScatterShape { get; set; }

		// @required @property (nonatomic) CGFloat scatterShapeHoleRadius;
		[Abstract]
		[Export("scatterShapeHoleRadius")]
		nfloat ScatterShapeHoleRadius { get; set; }

		// @required @property (nonatomic, strong) UIColor * _Nullable scatterShapeHoleColor;
		[Abstract]
		[NullAllowed, Export("scatterShapeHoleColor", ArgumentSemantic.Strong)]
		UIColor ScatterShapeHoleColor { get; set; }

		//// @required @property (nonatomic) CGPathRef _Nullable customScatterShape;
		//[Abstract]
		//[NullAllowed, Export("customScatterShape", ArgumentSemantic.Assign)]
		//unsafe CGPathRef* CustomScatterShape { get; set; }
	}

	// @interface LineChartData : ChartData
	[BaseType(typeof(ChartData), Name = "_TtC6Charts13LineChartData")]
	interface LineChartData
	{
		// -(instancetype _Nonnull)initWithXVals:(NSArray<NSObject *> * _Nullable)xVals dataSets:(NSArray<id<IInterfaceChartDataSet>> * _Nullable)dataSets __attribute__((objc_designated_initializer));
		[Export("initWithXVals:dataSets:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] NSObject[] xVals, [NullAllowed] IInterfaceChartDataSet[] dataSets);
	}

	// @interface LineRadarChartDataSet : LineScatterCandleRadarChartDataSet <InterfaceLineRadarChartDataSet>
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

		//// -(id _Nonnull)copyWithZone:(struct _NSZone * _Null_unspecified)zone;
		//[Export("copyWithZone:")]
		//unsafe NSObject CopyWithZone(_NSZone* zone);

		// -(instancetype _Nonnull)initWithLabel:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
		[Export("initWithLabel:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] string label);

		// -(instancetype _Nonnull)initWithYVals:(NSArray<ChartDataEntry *> * _Nullable)yVals label:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
		[Export("initWithYVals:label:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] ChartDataEntry[] yVals, [NullAllowed] string label);
	}

	// @interface LineChartDataSet : LineRadarChartDataSet <IInterfaceLineChartDataSet>
	[BaseType(typeof(LineRadarChartDataSet), Name = "_TtC6Charts16LineChartDataSet")]
	interface LineChartDataSet : InterfaceLineChartDataSet
	{
		// -(instancetype _Nonnull)initWithYVals:(NSArray<ChartDataEntry *> * _Nullable)yVals label:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
		[Export("initWithYVals:label:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] ChartDataEntry[] yVals, [NullAllowed] string label);

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

		// -(UIColor * _Nullable)getCircleColor:(NSInteger)index;
		[Export("getCircleColor:")]
		[return: NullAllowed]
		UIColor GetCircleColor(nint index);

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

		//// -(id _Nonnull)copyWithZone:(struct _NSZone * _Null_unspecified)zone;
		//[Export("copyWithZone:")]
		//unsafe NSObject CopyWithZone(_NSZone* zone);
	}

	// @interface LineRadarChartRenderer : LineScatterCandleRadarChartRenderer
	[BaseType(typeof(LineScatterCandleRadarChartRenderer), Name = "_TtC6Charts22LineRadarChartRenderer")]
	interface LineRadarChartRenderer
	{
		// -(instancetype _Nonnull)initWithAnimator:(ChartAnimator * _Nullable)animator viewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler __attribute__((objc_designated_initializer));
		[Export("initWithAnimator:viewPortHandler:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] ChartAnimator animator, ChartViewPortHandler viewPortHandler);

		//// -(void)drawFilledPathWithContext:(CGContextRef _Nonnull)context path:(CGPathRef _Nonnull)path fill:(ChartFill * _Nonnull)fill fillAlpha:(CGFloat)fillAlpha;
		//[Export("drawFilledPathWithContext:path:fill:fillAlpha:")]
		//unsafe void DrawFilledPathWithContext(CGContextRef* context, CGPathRef* path, ChartFill fill, nfloat fillAlpha);

		//// -(void)drawFilledPathWithContext:(CGContextRef _Nonnull)context path:(CGPathRef _Nonnull)path fillColor:(UIColor * _Nonnull)fillColor fillAlpha:(CGFloat)fillAlpha;
		//[Export("drawFilledPathWithContext:path:fillColor:fillAlpha:")]
		//unsafe void DrawFilledPathWithContext(CGContextRef* context, CGPathRef* path, UIColor fillColor, nfloat fillAlpha);
	}

	// @interface LineChartRenderer : LineRadarChartRenderer
	[BaseType(typeof(LineRadarChartRenderer), Name = "_TtC6Charts17LineChartRenderer")]
	interface LineChartRenderer
	{
		// @property (nonatomic, weak) id<LineChartDataProvider> _Nullable dataProvider;
		[NullAllowed, Export("dataProvider", ArgumentSemantic.Weak)]
		ILineChartDataProvider DataProvider { get; set; }

		// -(instancetype _Nonnull)initWithDataProvider:(id<LineChartDataProvider> _Nullable)dataProvider animator:(ChartAnimator * _Nullable)animator viewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler __attribute__((objc_designated_initializer));
		[Export("initWithDataProvider:animator:viewPortHandler:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] ILineChartDataProvider dataProvider, [NullAllowed] ChartAnimator animator, ChartViewPortHandler viewPortHandler);

		//// -(void)drawDataWithContext:(CGContextRef _Nonnull)context;
		//[Export("drawDataWithContext:")]
		//unsafe void DrawDataWithContext(CGContextRef* context);

		//// -(void)drawDataSetWithContext:(CGContextRef _Nonnull)context dataSet:(id<IInterfaceLineChartDataSet> _Nonnull)dataSet;
		//[Export("drawDataSetWithContext:dataSet:")]
		//unsafe void DrawDataSetWithContext(CGContextRef* context, IInterfaceLineChartDataSet dataSet);

		//// -(void)drawCubicBezierWithContext:(CGContextRef _Nonnull)context dataSet:(id<IInterfaceLineChartDataSet> _Nonnull)dataSet;
		//[Export("drawCubicBezierWithContext:dataSet:")]
		//unsafe void DrawCubicBezierWithContext(CGContextRef* context, IInterfaceLineChartDataSet dataSet);

		//// -(void)drawHorizontalBezierWithContext:(CGContextRef _Nonnull)context dataSet:(id<IInterfaceLineChartDataSet> _Nonnull)dataSet;
		//[Export("drawHorizontalBezierWithContext:dataSet:")]
		//unsafe void DrawHorizontalBezierWithContext(CGContextRef* context, IInterfaceLineChartDataSet dataSet);

		//// -(void)drawCubicFillWithContext:(CGContextRef _Nonnull)context dataSet:(id<IInterfaceLineChartDataSet> _Nonnull)dataSet spline:(CGMutablePathRef _Nonnull)spline matrix:(CGAffineTransform)matrix from:(NSInteger)from to:(NSInteger)to;
		//[Export("drawCubicFillWithContext:dataSet:spline:matrix:from:to:")]
		//unsafe void DrawCubicFillWithContext(CGContextRef* context, IInterfaceLineChartDataSet dataSet, CGMutablePathRef* spline, CGAffineTransform matrix, nint from, nint to);

		//// -(void)drawLinearWithContext:(CGContextRef _Nonnull)context dataSet:(id<IInterfaceLineChartDataSet> _Nonnull)dataSet;
		//[Export("drawLinearWithContext:dataSet:")]
		//unsafe void DrawLinearWithContext(CGContextRef* context, IInterfaceLineChartDataSet dataSet);

		//// -(void)drawLinearFillWithContext:(CGContextRef _Nonnull)context dataSet:(id<IInterfaceLineChartDataSet> _Nonnull)dataSet minx:(NSInteger)minx maxx:(NSInteger)maxx trans:(ChartTransformer * _Nonnull)trans;
		//[Export("drawLinearFillWithContext:dataSet:minx:maxx:trans:")]
		//unsafe void DrawLinearFillWithContext(CGContextRef* context, IInterfaceLineChartDataSet dataSet, nint minx, nint maxx, ChartTransformer trans);

		//// -(void)drawValuesWithContext:(CGContextRef _Nonnull)context;
		//[Export("drawValuesWithContext:")]
		//unsafe void DrawValuesWithContext(CGContextRef* context);

		//// -(void)drawExtrasWithContext:(CGContextRef _Nonnull)context;
		//[Export("drawExtrasWithContext:")]
		//unsafe void DrawExtrasWithContext(CGContextRef* context);

		//// -(void)drawHighlightedWithContext:(CGContextRef _Nonnull)context indices:(NSArray<ChartHighlight *> * _Nonnull)indices;
		//[Export("drawHighlightedWithContext:indices:")]
		//unsafe void DrawHighlightedWithContext(CGContextRef* context, ChartHighlight[] indices);
	}

	// @interface LineChartView : BarLineChartViewBase <LineChartDataProvider>
	[BaseType(typeof(BarLineChartViewBase), Name = "_TtC6Charts13LineChartView")]
	interface LineChartView : LineChartDataProvider
	{
		// -(void)initialize;
		[Export("initialize")]
		void Initialize();

		// -(void)calcMinMax;
		[Export("calcMinMax")]
		void CalcMinMax();

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

	// @interface PieChartData : ChartData
	[BaseType(typeof(ChartData), Name = "_TtC6Charts12PieChartData")]
	interface PieChartData
	{
		// -(instancetype _Nonnull)initWithXVals:(NSArray<NSObject *> * _Nullable)xVals dataSets:(NSArray<id<IInterfaceChartDataSet>> * _Nullable)dataSets __attribute__((objc_designated_initializer));
		[Export("initWithXVals:dataSets:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] NSObject[] xVals, [NullAllowed] IInterfaceChartDataSet[] dataSets);

		// @property (nonatomic, strong) id<IInterfacePieChartDataSet> _Nullable dataSet;
		[NullAllowed, Export("dataSet", ArgumentSemantic.Strong)]
		IInterfacePieChartDataSet DataSet { get; set; }

		// -(id<IInterfaceChartDataSet> _Nullable)getDataSetByIndex:(NSInteger)index;
		[Export("getDataSetByIndex:")]
		[return: NullAllowed]
		IInterfaceChartDataSet GetDataSetByIndex(nint index);

		// -(id<IInterfaceChartDataSet> _Nullable)getDataSetByLabel:(NSString * _Nonnull)label ignorecase:(BOOL)ignorecase;
		[Export("getDataSetByLabel:ignorecase:")]
		[return: NullAllowed]
		IInterfaceChartDataSet GetDataSetByLabel(string label, bool ignorecase);

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

	// @interface PieChartDataSet : ChartDataSet <IInterfacePieChartDataSet>
	[BaseType(typeof(ChartDataSet), Name = "_TtC6Charts15PieChartDataSet")]
	interface PieChartDataSet : InterfacePieChartDataSet
	{
		// -(instancetype _Nonnull)initWithYVals:(NSArray<ChartDataEntry *> * _Nullable)yVals label:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
		[Export("initWithYVals:label:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] ChartDataEntry[] yVals, [NullAllowed] string label);

		// @property (nonatomic) CGFloat sliceSpace;
		[Export("sliceSpace")]
		nfloat SliceSpace { get; set; }

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

		//// -(id _Nonnull)copyWithZone:(struct _NSZone * _Null_unspecified)zone;
		//[Export("copyWithZone:")]
		//unsafe NSObject CopyWithZone(_NSZone* zone);
	}

	// @interface PieChartRenderer : ChartDataRendererBase
	[BaseType(typeof(ChartDataRendererBase), Name = "_TtC6Charts16PieChartRenderer")]
	interface PieChartRenderer
	{
		// @property (nonatomic, weak) PieChartView * _Nullable chart;
		[NullAllowed, Export("chart", ArgumentSemantic.Weak)]
		PieChartView Chart { get; set; }

		// -(instancetype _Nonnull)initWithChart:(PieChartView * _Nonnull)chart animator:(ChartAnimator * _Nullable)animator viewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler __attribute__((objc_designated_initializer));
		[Export("initWithChart:animator:viewPortHandler:")]
		[DesignatedInitializer]
		IntPtr Constructor(PieChartView chart, [NullAllowed] ChartAnimator animator, ChartViewPortHandler viewPortHandler);

		//// -(void)drawDataWithContext:(CGContextRef _Nonnull)context;
		//[Export("drawDataWithContext:")]
		//unsafe void DrawDataWithContext(CGContextRef* context);

		// -(CGFloat)calculateMinimumRadiusForSpacedSliceWithCenter:(CGPoint)center radius:(CGFloat)radius angle:(CGFloat)angle arcStartPointX:(CGFloat)arcStartPointX arcStartPointY:(CGFloat)arcStartPointY startAngle:(CGFloat)startAngle sweepAngle:(CGFloat)sweepAngle;
		[Export("calculateMinimumRadiusForSpacedSliceWithCenter:radius:angle:arcStartPointX:arcStartPointY:startAngle:sweepAngle:")]
		nfloat CalculateMinimumRadiusForSpacedSliceWithCenter(CGPoint center, nfloat radius, nfloat angle, nfloat arcStartPointX, nfloat arcStartPointY, nfloat startAngle, nfloat sweepAngle);

		//// -(void)drawDataSetWithContext:(CGContextRef _Nonnull)context dataSet:(id<IInterfacePieChartDataSet> _Nonnull)dataSet;
		//[Export("drawDataSetWithContext:dataSet:")]
		//unsafe void DrawDataSetWithContext(CGContextRef* context, IInterfacePieChartDataSet dataSet);

		//// -(void)drawValuesWithContext:(CGContextRef _Nonnull)context;
		//[Export("drawValuesWithContext:")]
		//unsafe void DrawValuesWithContext(CGContextRef* context);

		//// -(void)drawExtrasWithContext:(CGContextRef _Nonnull)context;
		//[Export("drawExtrasWithContext:")]
		//unsafe void DrawExtrasWithContext(CGContextRef* context);

		//// -(void)drawHighlightedWithContext:(CGContextRef _Nonnull)context indices:(NSArray<ChartHighlight *> * _Nonnull)indices;
		//[Export("drawHighlightedWithContext:indices:")]
		//unsafe void DrawHighlightedWithContext(CGContextRef* context, ChartHighlight[] indices);
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

		// -(void)initialize;
		[Export("initialize")]
		void Initialize();

		// -(void)calcMinMax;
		[Export("calcMinMax")]
		void CalcMinMax();

		// -(void)notifyDataSetChanged;
		[Export("notifyDataSetChanged")]
		void NotifyDataSetChanged();

		// -(void)calculateOffsets;
		[Export("calculateOffsets")]
		void CalculateOffsets();

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

		// @property (readonly, nonatomic) CGFloat requiredLegendOffset;
		[Export("requiredLegendOffset")]
		nfloat RequiredLegendOffset { get; }

		// @property (readonly, nonatomic) CGFloat requiredBaseOffset;
		[Export("requiredBaseOffset")]
		nfloat RequiredBaseOffset { get; }

		// @property (readonly, nonatomic) double chartYMax;
		[Export("chartYMax")]
		double ChartYMax { get; }

		// @property (readonly, nonatomic) double chartYMin;
		[Export("chartYMin")]
		double ChartYMin { get; }

		// -(NSArray<ChartSelectionDetail *> * _Nonnull)getSelectionDetailsAtIndex:(NSInteger)xIndex;
		[Export("getSelectionDetailsAtIndex:")]
		ChartSelectionDetail[] GetSelectionDetailsAtIndex(nint xIndex);

		// @property (readonly, nonatomic) BOOL isRotationEnabled;
		[Export("isRotationEnabled")]
		bool IsRotationEnabled { get; }

		// @property (nonatomic) BOOL rotationWithTwoFingers;
		[Export("rotationWithTwoFingers")]
		bool RotationWithTwoFingers { get; set; }

		// @property (readonly, nonatomic) BOOL isRotationWithTwoFingers;
		[Export("isRotationWithTwoFingers")]
		bool IsRotationWithTwoFingers { get; }

		// -(void)spinWithDuration:(NSTimeInterval)duration fromAngle:(CGFloat)fromAngle toAngle:(CGFloat)toAngle easing:(CGFloat (^ _Nullable)(NSTimeInterval, NSTimeInterval))easing;
		[Export("spinWithDuration:fromAngle:toAngle:easing:")]
		void SpinWithDuration(double duration, nfloat fromAngle, nfloat toAngle, [NullAllowed] Func<double, double, nfloat> easing);

		// -(void)spinWithDuration:(NSTimeInterval)duration fromAngle:(CGFloat)fromAngle toAngle:(CGFloat)toAngle easingOption:(enum ChartEasingOption)easingOption;
		[Export("spinWithDuration:fromAngle:toAngle:easingOption:")]
		void SpinWithDuration(double duration, nfloat fromAngle, nfloat toAngle, ChartEasingOption easingOption);

		// -(void)spinWithDuration:(NSTimeInterval)duration fromAngle:(CGFloat)fromAngle toAngle:(CGFloat)toAngle;
		[Export("spinWithDuration:fromAngle:toAngle:")]
		void SpinWithDuration(double duration, nfloat fromAngle, nfloat toAngle);

		// -(void)stopSpinAnimation;
		[Export("stopSpinAnimation")]
		void StopSpinAnimation();

		// -(void)processRotationGestureBeganWithLocation:(CGPoint)location;
		[Export("processRotationGestureBeganWithLocation:")]
		void ProcessRotationGestureBeganWithLocation(CGPoint location);

		// -(void)processRotationGestureMovedWithLocation:(CGPoint)location;
		[Export("processRotationGestureMovedWithLocation:")]
		void ProcessRotationGestureMovedWithLocation(CGPoint location);

		// -(void)processRotationGestureEndedWithLocation:(CGPoint)location;
		[Export("processRotationGestureEndedWithLocation:")]
		void ProcessRotationGestureEndedWithLocation(CGPoint location);

		// -(void)processRotationGestureCancelled;
		[Export("processRotationGestureCancelled")]
		void ProcessRotationGestureCancelled();

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

		// -(void)initialize;
		[Export("initialize")]
		void Initialize();

		// -(void)drawRect:(CGRect)rect;
		[Export("drawRect:")]
		void DrawRect(CGRect rect);

		// -(void)calculateOffsets;
		[Export("calculateOffsets")]
		void CalculateOffsets();

		// -(void)calcMinMax;
		[Export("calcMinMax")]
		void CalcMinMax();

		// -(CGPoint)getMarkerPositionWithEntry:(ChartDataEntry * _Nonnull)e highlight:(ChartHighlight * _Nonnull)highlight;
		[Export("getMarkerPositionWithEntry:highlight:")]
		CGPoint GetMarkerPositionWithEntry(ChartDataEntry e, ChartHighlight highlight);

		// -(BOOL)needsHighlightWithXIndex:(NSInteger)xIndex dataSetIndex:(NSInteger)dataSetIndex;
		[Export("needsHighlightWithXIndex:dataSetIndex:")]
		bool NeedsHighlightWithXIndex(nint xIndex, nint dataSetIndex);

		// @property (readonly, nonatomic, strong) ChartXAxis * _Nonnull xAxis;
		[Export("xAxis", ArgumentSemantic.Strong)]
		ChartXAxis XAxis { get; }

		// -(NSInteger)indexForAngle:(CGFloat)angle;
		[Export("indexForAngle:")]
		nint IndexForAngle(nfloat angle);

		// -(NSInteger)dataSetIndexForIndex:(NSInteger)xIndex;
		[Export("dataSetIndexForIndex:")]
		nint DataSetIndexForIndex(nint xIndex);

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

		// @property (nonatomic) BOOL drawCenterTextEnabled;
		[Export("drawCenterTextEnabled")]
		bool DrawCenterTextEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isDrawCenterTextEnabled;
		[Export("isDrawCenterTextEnabled")]
		bool IsDrawCenterTextEnabled { get; }

		// @property (readonly, nonatomic) CGFloat requiredLegendOffset;
		[Export("requiredLegendOffset")]
		nfloat RequiredLegendOffset { get; }

		// @property (readonly, nonatomic) CGFloat requiredBaseOffset;
		[Export("requiredBaseOffset")]
		nfloat RequiredBaseOffset { get; }

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

		// -(instancetype _Nonnull)initWithXVals:(NSArray<NSObject *> * _Nullable)xVals dataSets:(NSArray<id<IInterfaceChartDataSet>> * _Nullable)dataSets __attribute__((objc_designated_initializer));
		[Export("initWithXVals:dataSets:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] NSObject[] xVals, [NullAllowed] IInterfaceChartDataSet[] dataSets);
	}

	// @interface RadarChartDataSet : LineRadarChartDataSet <InterfaceRadarChartDataSet>
	[BaseType(typeof(LineRadarChartDataSet), Name = "_TtC6Charts17RadarChartDataSet")]
	interface RadarChartDataSet : InterfaceRadarChartDataSet
	{
		// -(instancetype _Nonnull)initWithYVals:(NSArray<ChartDataEntry *> * _Nullable)yVals label:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
		[Export("initWithYVals:label:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] ChartDataEntry[] yVals, [NullAllowed] string label);

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

		// -(instancetype _Nonnull)initWithChart:(RadarChartView * _Nonnull)chart animator:(ChartAnimator * _Nullable)animator viewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler __attribute__((objc_designated_initializer));
		[Export("initWithChart:animator:viewPortHandler:")]
		[DesignatedInitializer]
		IntPtr Constructor(RadarChartView chart, [NullAllowed] ChartAnimator animator, ChartViewPortHandler viewPortHandler);

		//// -(void)drawDataWithContext:(CGContextRef _Nonnull)context;
		//[Export("drawDataWithContext:")]
		//unsafe void DrawDataWithContext(CGContextRef* context);

		//// -(void)drawDataSetWithContext:(CGContextRef _Nonnull)context dataSet:(id<InterfaceRadarChartDataSet> _Nonnull)dataSet mostEntries:(NSInteger)mostEntries;
		//[Export("drawDataSetWithContext:dataSet:mostEntries:")]
		//unsafe void DrawDataSetWithContext(CGContextRef* context, InterfaceRadarChartDataSet dataSet, nint mostEntries);

		//// -(void)drawValuesWithContext:(CGContextRef _Nonnull)context;
		//[Export("drawValuesWithContext:")]
		//unsafe void DrawValuesWithContext(CGContextRef* context);

		//// -(void)drawExtrasWithContext:(CGContextRef _Nonnull)context;
		//[Export("drawExtrasWithContext:")]
		//unsafe void DrawExtrasWithContext(CGContextRef* context);

		//// -(void)drawWebWithContext:(CGContextRef _Nonnull)context;
		//[Export("drawWebWithContext:")]
		//unsafe void DrawWebWithContext(CGContextRef* context);

		//// -(void)drawHighlightedWithContext:(CGContextRef _Nonnull)context indices:(NSArray<ChartHighlight *> * _Nonnull)indices;
		//[Export("drawHighlightedWithContext:indices:")]
		//unsafe void DrawHighlightedWithContext(CGContextRef* context, ChartHighlight[] indices);

		//// -(void)drawHighlightCircleWithContext:(CGContextRef _Nonnull)context atPoint:(CGPoint)point innerRadius:(CGFloat)innerRadius outerRadius:(CGFloat)outerRadius fillColor:(UIColor * _Nullable)fillColor strokeColor:(UIColor * _Nullable)strokeColor strokeWidth:(CGFloat)strokeWidth;
		//[Export("drawHighlightCircleWithContext:atPoint:innerRadius:outerRadius:fillColor:strokeColor:strokeWidth:")]
		//unsafe void DrawHighlightCircleWithContext(CGContextRef* context, CGPoint point, nfloat innerRadius, nfloat outerRadius, [NullAllowed] UIColor fillColor, [NullAllowed] UIColor strokeColor, nfloat strokeWidth);
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

		// @property (nonatomic, strong) ChartYAxisRendererRadarChart * _Null_unspecified _yAxisRenderer;
		[Export("_yAxisRenderer", ArgumentSemantic.Strong)]
		ChartYAxisRendererRadarChart _yAxisRenderer { get; set; }

		// @property (nonatomic, strong) ChartXAxisRendererRadarChart * _Null_unspecified _xAxisRenderer;
		[Export("_xAxisRenderer", ArgumentSemantic.Strong)]
		ChartXAxisRendererRadarChart _xAxisRenderer { get; set; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor(CGRect frame);

		//// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		//[Export("initWithCoder:")]
		//[DesignatedInitializer]
		//IntPtr Constructor(NSCoder aDecoder);

		// -(void)initialize;
		[Export("initialize")]
		void Initialize();

		// -(void)calcMinMax;
		[Export("calcMinMax")]
		void CalcMinMax();

		// -(CGPoint)getMarkerPositionWithEntry:(ChartDataEntry * _Nonnull)entry highlight:(ChartHighlight * _Nonnull)highlight;
		[Export("getMarkerPositionWithEntry:highlight:")]
		CGPoint GetMarkerPositionWithEntry(ChartDataEntry entry, ChartHighlight highlight);

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

		// @property (readonly, nonatomic) CGFloat requiredLegendOffset;
		[Export("requiredLegendOffset")]
		nfloat RequiredLegendOffset { get; }

		// @property (readonly, nonatomic) CGFloat requiredBaseOffset;
		[Export("requiredBaseOffset")]
		nfloat RequiredBaseOffset { get; }

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

	// @interface ScatterChartData : BarLineScatterCandleBubbleChartData
	[BaseType(typeof(BarLineScatterCandleBubbleChartData), Name = "_TtC6Charts16ScatterChartData")]
	interface ScatterChartData
	{
		// -(instancetype _Nonnull)initWithXVals:(NSArray<NSObject *> * _Nullable)xVals dataSets:(NSArray<id<IInterfaceChartDataSet>> * _Nullable)dataSets __attribute__((objc_designated_initializer));
		[Export("initWithXVals:dataSets:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] NSObject[] xVals, [NullAllowed] IInterfaceChartDataSet[] dataSets);

		// -(CGFloat)getGreatestShapeSize;
		[Export("getGreatestShapeSize")]
		//[Verify(MethodToProperty)]
		nfloat GreatestShapeSize { get; }
	}

	// @interface ScatterChartDataSet : LineScatterCandleRadarChartDataSet <InterfaceScatterChartDataSet>
	[BaseType(typeof(LineScatterCandleRadarChartDataSet), Name = "_TtC6Charts19ScatterChartDataSet")]
	interface ScatterChartDataSet : InterfaceScatterChartDataSet
	{
		// @property (nonatomic) CGFloat scatterShapeSize;
		[Export("scatterShapeSize")]
		nfloat ScatterShapeSize { get; set; }

		// @property (nonatomic) enum ScatterShape scatterShape;
		[Export("scatterShape", ArgumentSemantic.Assign)]
		ScatterShape ScatterShape { get; set; }

		// @property (nonatomic) CGFloat scatterShapeHoleRadius;
		[Export("scatterShapeHoleRadius")]
		nfloat ScatterShapeHoleRadius { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable scatterShapeHoleColor;
		[NullAllowed, Export("scatterShapeHoleColor", ArgumentSemantic.Strong)]
		UIColor ScatterShapeHoleColor { get; set; }

		//// @property (nonatomic) CGPathRef _Nullable customScatterShape;
		//[NullAllowed, Export("customScatterShape", ArgumentSemantic.Assign)]
		//unsafe CGPathRef* CustomScatterShape { get; set; }

		//// -(id _Nonnull)copyWithZone:(struct _NSZone * _Null_unspecified)zone;
		//[Export("copyWithZone:")]
		//unsafe NSObject CopyWithZone(_NSZone* zone);

		// -(instancetype _Nonnull)initWithLabel:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
		[Export("initWithLabel:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] string label);

		// -(instancetype _Nonnull)initWithYVals:(NSArray<ChartDataEntry *> * _Nullable)yVals label:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
		[Export("initWithYVals:label:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] ChartDataEntry[] yVals, [NullAllowed] string label);
	}

	// @interface ScatterChartRenderer : LineScatterCandleRadarChartRenderer
	[BaseType(typeof(LineScatterCandleRadarChartRenderer), Name = "_TtC6Charts20ScatterChartRenderer")]
	interface ScatterChartRenderer
	{
		// @property (nonatomic, weak) id<ScatterChartDataProvider> _Nullable dataProvider;
		[NullAllowed, Export("dataProvider", ArgumentSemantic.Weak)]
		IScatterChartDataProvider DataProvider { get; set; }

		// -(instancetype _Nonnull)initWithDataProvider:(id<ScatterChartDataProvider> _Nullable)dataProvider animator:(ChartAnimator * _Nullable)animator viewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler __attribute__((objc_designated_initializer));
		[Export("initWithDataProvider:animator:viewPortHandler:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] IScatterChartDataProvider dataProvider, [NullAllowed] ChartAnimator animator, ChartViewPortHandler viewPortHandler);

		//// -(void)drawDataWithContext:(CGContextRef _Nonnull)context;
		//[Export("drawDataWithContext:")]
		//unsafe void DrawDataWithContext(CGContextRef* context);

		//// -(void)drawDataSetWithContext:(CGContextRef _Nonnull)context dataSet:(id<InterfaceScatterChartDataSet> _Nonnull)dataSet;
		//[Export("drawDataSetWithContext:dataSet:")]
		//unsafe void DrawDataSetWithContext(CGContextRef* context, InterfaceScatterChartDataSet dataSet);

		//// -(void)drawValuesWithContext:(CGContextRef _Nonnull)context;
		//[Export("drawValuesWithContext:")]
		//unsafe void DrawValuesWithContext(CGContextRef* context);

		//// -(void)drawExtrasWithContext:(CGContextRef _Nonnull)context;
		//[Export("drawExtrasWithContext:")]
		//unsafe void DrawExtrasWithContext(CGContextRef* context);

		//// -(void)drawHighlightedWithContext:(CGContextRef _Nonnull)context indices:(NSArray<ChartHighlight *> * _Nonnull)indices;
		//[Export("drawHighlightedWithContext:indices:")]
		//unsafe void DrawHighlightedWithContext(CGContextRef* context, ChartHighlight[] indices);
	}

	// @interface ScatterChartView : BarLineChartViewBase <ScatterChartDataProvider>
	[BaseType(typeof(BarLineChartViewBase), Name = "_TtC6Charts16ScatterChartView")]
	interface ScatterChartView : ScatterChartDataProvider
	{
		// -(void)initialize;
		[Export("initialize")]
		void Initialize();

		// -(void)calcMinMax;
		[Export("calcMinMax")]
		void CalcMinMax();

		// @property (readonly, nonatomic, strong) ScatterChartData * _Nullable scatterData;
		[NullAllowed, Export("scatterData", ArgumentSemantic.Strong)]
		ScatterChartData ScatterData { get; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);

		//// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		//[Export ("initWithCoder:")]
		//[DesignatedInitializer]
		//IntPtr Constructor (NSCoder aDecoder);
	}

	//// @interface Charts_Swift_4376 (UIPanGestureRecognizer)
	//[Category]
	//[BaseType (typeof(UIPanGestureRecognizer))]
	//interface UIPanGestureRecognizer_Charts_Swift_4376
	//{
	//	// -(NSInteger)nsuiNumberOfTouches;
	//	[Export ("nsuiNumberOfTouches")]
	//	//[Verify (MethodToProperty)]
	//	nint NsuiNumberOfTouches { get; }

	//	// -(CGPoint)nsuiLocationOfTouch:(NSInteger)touch inView:(UIView * _Nullable)inView;
	//	[Export ("nsuiLocationOfTouch:inView:")]
	//	CGPoint NsuiLocationOfTouch (nint touch, [NullAllowed] UIView inView);
	//}

	//// @interface Charts_Swift_4382 (UIPinchGestureRecognizer)
	//[Category]
	//[BaseType (typeof(UIPinchGestureRecognizer))]
	//interface UIPinchGestureRecognizer_Charts_Swift_4382
	//{
	//	// @property (nonatomic) CGFloat nsuiScale;
	//	[Export ("nsuiScale")]
	//	nfloat NsuiScale { get; set; }

	//	// -(CGPoint)nsuiLocationOfTouch:(NSInteger)touch inView:(UIView * _Nullable)inView;
	//	[Export ("nsuiLocationOfTouch:inView:")]
	//	CGPoint NsuiLocationOfTouch (nint touch, [NullAllowed] UIView inView);
	//}

	//// @interface Charts_Swift_4388 (UIRotationGestureRecognizer)
	//[Category]
	//[BaseType (typeof(UIRotationGestureRecognizer))]
	//interface UIRotationGestureRecognizer_Charts_Swift_4388
	//{
	//	// @property (nonatomic) CGFloat nsuiRotation;
	//	[Export ("nsuiRotation")]
	//	nfloat NsuiRotation { get; set; }
	//}

	//// @interface Charts_Swift_4393 (UIScreen)
	//[Category]
	//[BaseType (typeof(UIScreen))]
	//interface UIScreen_Charts_Swift_4393
	//{
	//	// @property (readonly, nonatomic) CGFloat nsuiScale;
	//	[Export ("nsuiScale")]
	//	nfloat NsuiScale { get; }
	//}

	//// @interface Charts_Swift_4398 (UITapGestureRecognizer)
	//[Category]
	//[BaseType (typeof(UITapGestureRecognizer))]
	//interface UITapGestureRecognizer_Charts_Swift_4398
	//{
	//	// -(NSInteger)nsuiNumberOfTouches;
	//	[Export ("nsuiNumberOfTouches")]
	//	//[Verify (MethodToProperty)]
	//	nint NsuiNumberOfTouches { get; }

	//	// @property (nonatomic) NSInteger nsuiNumberOfTapsRequired;
	//	[Export ("nsuiNumberOfTapsRequired")]
	//	nint NsuiNumberOfTapsRequired { get; set; }
	//}

	//// @interface Charts_Swift_4404 (UIView)
	//[Category]
	//[BaseType (typeof(UIView))]
	//interface UIView_Charts_Swift_4404
	//{
	//	// @property (readonly, copy, nonatomic) NSArray<UIGestureRecognizer *> * _Nullable nsuiGestureRecognizers;
	//	[NullAllowed, Export ("nsuiGestureRecognizers", ArgumentSemantic.Copy)]
	//	UIGestureRecognizer[] NsuiGestureRecognizers { get; }
	//}
}
