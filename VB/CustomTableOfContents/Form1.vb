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
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim categoriesReport As New CategoriesReport()
			categoriesReport.CreateDocument()


			Dim productsReport As New ProductsReport()
			productsReport.CreateDocument()

			'Merge reports
			categoriesReport.Pages.AddRange(productsReport.Pages)

			CreateLinks(categoriesReport)

			categoriesReport.ShowPreviewDialog()
		End Sub

		Private Shared Sub CreateLinks(ByVal report As XtraReport)
			Dim linkBricks As New List(Of VisualBrick)()
			Dim pageBricks As New List(Of VisualBrick)()
			Dim targetBricks As New List(Of TargetBrick)()

			For Each page As Page In report.Pages
				Dim [iterator] As New NestedBrickIterator(page.InnerBricks)
				Do While [iterator].MoveNext()
					Dim brick As VisualBrick = TryCast([iterator].CurrentBrick, VisualBrick)
					If brick IsNot Nothing AndAlso brick.Value IsNot Nothing Then
						Dim valueString As String = brick.Value.ToString()

						If valueString.StartsWith("Link_") Then
							linkBricks.Add(brick)
						End If

						If valueString.StartsWith("Target_") Then
							targetBricks.Add(New TargetBrick() With {.Brick = brick, .Page = page})
						End If

						If valueString.StartsWith("PageBrick_") Then
							pageBricks.Add(brick)
						End If
					End If
				Loop
			Next page

			For Each link As VisualBrick In linkBricks
				Dim key As String = link.Value.ToString().Substring(5)
				Dim target As TargetBrick = targetBricks.Find(Function(targetBrick) CStr(targetBrick.Brick.Value) = String.Concat("Target_", key))
                If target IsNot Nothing Then
                    target.Brick.AnchorName = key
                    link.Url = key
                    link.NavigationPair = BrickPagePair.Create(target.Brick, target.Page)
                    Dim pageBrick As VisualBrick = pageBricks.Find(Function(brick) DirectCast(brick.Value, String) = String.Concat("PageBrick_", key))
                    If pageBrick IsNot Nothing Then
                        pageBrick.Text = (target.Page.Index + 1).ToString()
                    End If
                End If
			Next link
		End Sub
	End Class
End Namespace
