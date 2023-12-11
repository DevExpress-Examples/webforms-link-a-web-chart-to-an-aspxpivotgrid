<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128575117/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1242)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Webforms - How to Link a Web Chart to a Pivot Grid
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e1242/)**
<!-- run online end -->

<p>This tutorial demonstrates how you can link <a href="http://documentation.devexpress.com/#XtraCharts/clsDevExpressXtraChartsWebWebChartControltopic"><u>WebChartControl</u></a> to <a href="http://documentation.devexpress.com/#AspNet/clsDevExpressWebASPxPivotGridASPxPivotGridtopic"><u>ASPxPivotGrid</u></a> at design time.</p>

![Pivot-Chart](./images/pivot-chart.png)

<p>Note that in order to synchronize both controls when the ASPxPivotGrid layout is changed, it is necessary to set their <strong>EnableCallbacks</strong> property to <i>False</i>. It is possible to place both controls inside the <strong>UpdatePanel</strong> to avoid the entire page update during a postback.

<br/>

## Files to Review

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))

## Documentation

* [UpdatePanel Class](http://msdn.microsoft.com/en-us/library/system.web.ui.updatepanel.aspx)
* [Pivot Charting on the Web (Integration with the ASPxPivotGrid)](http://documentation.devexpress.com/XtraCharts/CustomDocument8750.aspx)
