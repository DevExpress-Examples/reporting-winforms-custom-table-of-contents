Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

Namespace CustomTableOfContents
	Partial Public Class CategoriesReport
		Inherits DevExpress.XtraReports.UI.XtraReport

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub lbCategoryName_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles lbCategoryName.BeforePrint
			Dim label As XRControl = TryCast(sender, XRControl)
			label.Tag = String.Format("Link_{0}", GetCurrentColumnValue("CategoryID"))
		End Sub

		Private Sub lbPage_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles lbPage.BeforePrint
			Dim label As XRControl = TryCast(sender, XRControl)
			label.Tag = String.Format("PageBrick_{0}", GetCurrentColumnValue("CategoryID"))
		End Sub

	End Class
End Namespace
