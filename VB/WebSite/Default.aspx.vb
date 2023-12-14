Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web.ASPxPivotGrid

	Partial Public Class _Default
		Inherits System.Web.UI.Page

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			TextBox1.Text = Date.Now.ToString("F")
		End Sub

		Protected Sub ASPxPivotGrid1_FieldAreaChanged(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxPivotGrid.PivotFieldEventArgs)
			Dim pivot As ASPxPivotGrid = DirectCast(sender, ASPxPivotGrid)
			pivot.OptionsChartDataSource.ProvideColumnGrandTotals = If(pivot.Fields.GetVisibleFieldCount(DevExpress.XtraPivotGrid.PivotArea.ColumnArea) = 0, True, False)
			pivot.OptionsChartDataSource.ProvideRowGrandTotals = If(pivot.Fields.GetVisibleFieldCount(DevExpress.XtraPivotGrid.PivotArea.RowArea) = 0, True, False)
		End Sub
	End Class
