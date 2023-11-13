Imports System.Drawing
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

Namespace CustomTableOfContents

    Public Partial Class ProductsReport
        Inherits XtraReport

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub tcCategoryName_BeforePrint(ByVal sender As Object, ByVal e As CancelEventArgs)
            Dim label As XRControl = TryCast(sender, XRControl)
            label.Tag = String.Format("Target_{0}", GetCurrentColumnValue("CategoryID"))
        End Sub
    End Class
End Namespace
