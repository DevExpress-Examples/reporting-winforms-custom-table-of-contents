Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Native

Namespace CustomTableOfContents

    Public Partial Class Form1
        Inherits System.Windows.Forms.Form

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            Dim categoriesReport As CustomTableOfContents.CategoriesReport = New CustomTableOfContents.CategoriesReport()
            categoriesReport.CreateDocument()
            Dim productsReport As CustomTableOfContents.ProductsReport = New CustomTableOfContents.ProductsReport()
            productsReport.CreateDocument()
            'Merge reports
            categoriesReport.Pages.AddRange(productsReport.Pages)
            Call CustomTableOfContents.Form1.CreateLinks(categoriesReport)
            categoriesReport.ShowPreviewDialog()
        End Sub

        Private Shared Sub CreateLinks(ByVal report As DevExpress.XtraReports.UI.XtraReport)
            Dim linkBricks As System.Collections.Generic.List(Of DevExpress.XtraPrinting.VisualBrick) = New System.Collections.Generic.List(Of DevExpress.XtraPrinting.VisualBrick)()
            Dim pageBricks As System.Collections.Generic.List(Of DevExpress.XtraPrinting.VisualBrick) = New System.Collections.Generic.List(Of DevExpress.XtraPrinting.VisualBrick)()
            Dim targetBricks As System.Collections.Generic.List(Of CustomTableOfContents.TargetBrick) = New System.Collections.Generic.List(Of CustomTableOfContents.TargetBrick)()
            For Each page As DevExpress.XtraPrinting.Page In report.Pages
                For Each brick As DevExpress.XtraPrinting.VisualBrick In DevExpress.XtraPrinting.BrickSelector.GetBricks(page)
                    If brick.Tag IsNot Nothing Then
                        Dim tagString As String = brick.Tag.ToString()
                        If tagString.StartsWith("Link_") Then
                            linkBricks.Add(brick)
                        End If

                        If tagString.StartsWith("Target_") Then
                            targetBricks.Add(New CustomTableOfContents.TargetBrick() With {.Brick = brick, .Page = page})
                        End If

                        If tagString.StartsWith("PageBrick_") Then
                            pageBricks.Add(brick)
                        End If
                    End If
                Next
            Next

            For Each link As DevExpress.XtraPrinting.VisualBrick In linkBricks
                Dim key As String = link.Tag.ToString().Substring(5)
                Dim target As CustomTableOfContents.TargetBrick = targetBricks.Find(Function(targetBrick) Equals(CStr(targetBrick.Brick.Tag), System.[String].Concat("Target_", key)))
                If target IsNot Nothing Then
                    target.Brick.AnchorName = key
                    link.Url = key
                    link.NavigationPair = DevExpress.XtraPrinting.BrickPagePair.Create(target.Brick, target.Page)
                    Dim pageBrick As DevExpress.XtraPrinting.VisualBrick = pageBricks.Find(Function(brick) Equals(CStr(brick.Tag), System.[String].Concat("PageBrick_", key)))
                    If pageBrick IsNot Nothing Then pageBrick.Text =(target.Page.Index + 1).ToString()
                End If
            Next
        End Sub
    End Class
End Namespace
