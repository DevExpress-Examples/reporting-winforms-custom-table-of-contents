Imports System.Drawing
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

Namespace CustomTableOfContents

    Public Partial Class CategoriesReport
        Inherits XtraReport

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub lbCategoryName_BeforePrint(ByVal sender As Object, ByVal e As CancelEventArgs)
            Dim label As XRControl = TryCast(sender, XRControl)
            label.Tag = String.Format("Link_{0}", GetCurrentColumnValue("CategoryID"))
        End Sub

        Private Sub lbPage_BeforePrint(ByVal sender As Object, ByVal e As CancelEventArgs)
            Dim label As XRControl = TryCast(sender, XRControl)
            label.Tag = String.Format("PageBrick_{0}", GetCurrentColumnValue("CategoryID"))
        End Sub
    End Class
End Namespace
