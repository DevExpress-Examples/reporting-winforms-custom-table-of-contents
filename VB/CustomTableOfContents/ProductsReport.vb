Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

Namespace CustomTableOfContents
	Partial Public Class ProductsReport
		Inherits DevExpress.XtraReports.UI.XtraReport

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub tcCategoryName_BeforePrint(ByVal sender As Object, ByVal e As CancelEventArgs) Handles tcCategoryName.BeforePrint
			Dim label As XRControl = TryCast(sender, XRControl)
			label.Tag = String.Format("Target_{0}", GetCurrentColumnValue("CategoryID"))
		End Sub

	End Class
End Namespace
