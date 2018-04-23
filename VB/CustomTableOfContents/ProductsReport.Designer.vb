Namespace CustomTableOfContents
	Partial Public Class ProductsReport
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.tcUnitsOnOrder = New DevExpress.XtraReports.UI.XRTableCell()
			Me.tcUnitPriceHeader = New DevExpress.XtraReports.UI.XRTableCell()
			Me.tcUnitsInStockHeader = New DevExpress.XtraReports.UI.XRTableCell()
			Me.tcProductName = New DevExpress.XtraReports.UI.XRTableCell()
			Me.tcDiscontHeader = New DevExpress.XtraReports.UI.XRTableCell()
			Me.cbDiscont = New DevExpress.XtraReports.UI.XRCheckBox()
			Me.tcUnitsInStock = New DevExpress.XtraReports.UI.XRTableCell()
			Me.tcUnitsOnOrderHeader = New DevExpress.XtraReports.UI.XRTableCell()
			Me.tbProductHeader = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.tcCategoryName = New DevExpress.XtraReports.UI.XRTableCell()
			Me.trProductHeader = New DevExpress.XtraReports.UI.XRTableRow()
			Me.tcProductNameHeader = New DevExpress.XtraReports.UI.XRTableCell()
			Me.trProductData = New DevExpress.XtraReports.UI.XRTableRow()
			Me.tcUnitPrice = New DevExpress.XtraReports.UI.XRTableCell()
			Me.tcDiscont = New DevExpress.XtraReports.UI.XRTableCell()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.tbProductData = New DevExpress.XtraReports.UI.XRTable()
			Me.GroupHeaderTitle = New DevExpress.XtraReports.UI.GroupHeaderBand()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.nwindDataSet1 = New CustomTableOfContents.nwindDataSet()
			Me.productsTableAdapter = New CustomTableOfContents.nwindDataSetTableAdapters.ProductsTableAdapter()
			DirectCast(Me.tbProductHeader, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.tbProductData, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' tcUnitsOnOrder
			' 
			Me.tcUnitsOnOrder.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.UnitsOnOrder")})
			Me.tcUnitsOnOrder.Name = "tcUnitsOnOrder"
			Me.tcUnitsOnOrder.StylePriority.UseTextAlignment = False
			Me.tcUnitsOnOrder.Text = "tcUnitsOnOrder"
			Me.tcUnitsOnOrder.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.tcUnitsOnOrder.Weight = 0.44903843327809811R
			' 
			' tcUnitPriceHeader
			' 
			Me.tcUnitPriceHeader.Name = "tcUnitPriceHeader"
			Me.tcUnitPriceHeader.Text = "Unit Price"
			Me.tcUnitPriceHeader.Weight = 0.4663460215732067R
			' 
			' tcUnitsInStockHeader
			' 
			Me.tcUnitsInStockHeader.Name = "tcUnitsInStockHeader"
			Me.tcUnitsInStockHeader.Text = "Units In Stock"
			Me.tcUnitsInStockHeader.Weight = 0.46634598636061309R
			' 
			' tcProductName
			' 
			Me.tcProductName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.ProductName")})
			Me.tcProductName.Name = "tcProductName"
			Me.tcProductName.StylePriority.UseTextAlignment = False
			Me.tcProductName.Text = "tcProductName"
			Me.tcProductName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			Me.tcProductName.Weight = 1.3798077514467915R
			' 
			' tcDiscontHeader
			' 
			Me.tcDiscontHeader.Name = "tcDiscontHeader"
			Me.tcDiscontHeader.Text = "Discont."
			Me.tcDiscontHeader.Weight = 0.23846170170351017R
			' 
			' cbDiscont
			' 
			Me.cbDiscont.Borders = (CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.cbDiscont.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("CheckState", Nothing, "Products.Discontinued")})
			Me.cbDiscont.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.cbDiscont.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.cbDiscont.Name = "cbDiscont"
			Me.cbDiscont.SizeF = New System.Drawing.SizeF(51.66656F, 25F)
			Me.cbDiscont.StylePriority.UseBorders = False
			' 
			' tcUnitsInStock
			' 
			Me.tcUnitsInStock.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.UnitsInStock")})
			Me.tcUnitsInStock.Name = "tcUnitsInStock"
			Me.tcUnitsInStock.StylePriority.UseTextAlignment = False
			Me.tcUnitsInStock.Text = "tcUnitsInStock"
			Me.tcUnitsInStock.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.tcUnitsInStock.Weight = 0.46634616242358046R
			' 
			' tcUnitsOnOrderHeader
			' 
			Me.tcUnitsOnOrderHeader.Name = "tcUnitsOnOrderHeader"
			Me.tcUnitsOnOrderHeader.Text = "Units On Order"
			Me.tcUnitsOnOrderHeader.Weight = 0.44903843327809806R
			' 
			' tbProductHeader
			' 
			Me.tbProductHeader.LocationFloat = New DevExpress.Utils.PointFloat(0F, 10F)
			Me.tbProductHeader.Name = "tbProductHeader"
			Me.tbProductHeader.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1, Me.trProductHeader})
			Me.tbProductHeader.SizeF = New System.Drawing.SizeF(649.9999F, 55F)
			' 
			' xrTableRow1
			' 
			Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.tcCategoryName})
			Me.xrTableRow1.Name = "xrTableRow1"
			Me.xrTableRow1.Weight = 1.2R
			' 
			' tcCategoryName
			' 
            Me.tcCategoryName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.CategoryName"), New DevExpress.XtraReports.UI.XRBinding("Bookmark", Nothing, "Categories.CategoryName")})
            Me.tcCategoryName.Font = New System.Drawing.Font("Times New Roman", 16.0F, System.Drawing.FontStyle.Bold)
            Me.tcCategoryName.Name = "tcCategoryName"
			Me.tcCategoryName.StylePriority.UseFont = False
			Me.tcCategoryName.StylePriority.UseTextAlignment = False
			Me.tcCategoryName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			Me.tcCategoryName.Weight = 3R
'			Me.tcCategoryName.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.tcCategoryName_BeforePrint)
			' 
			' trProductHeader
			' 
			Me.trProductHeader.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.tcProductNameHeader, Me.tcUnitPriceHeader, Me.tcUnitsInStockHeader, Me.tcUnitsOnOrderHeader, Me.tcDiscontHeader})
			Me.trProductHeader.Name = "trProductHeader"
			Me.trProductHeader.Weight = 1R
			' 
			' tcProductNameHeader
			' 
			Me.tcProductNameHeader.Name = "tcProductNameHeader"
			Me.tcProductNameHeader.Text = "Product Name"
			Me.tcProductNameHeader.Weight = 1.379807857084572R
			' 
			' trProductData
			' 
			Me.trProductData.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.tcProductName, Me.tcUnitPrice, Me.tcUnitsInStock, Me.tcUnitsOnOrder, Me.tcDiscont})
			Me.trProductData.Name = "trProductData"
			Me.trProductData.Weight = 1R
			' 
			' tcUnitPrice
			' 
			Me.tcUnitPrice.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.UnitPrice", "{0:c}")})
			Me.tcUnitPrice.Name = "tcUnitPrice"
			Me.tcUnitPrice.StylePriority.UseTextAlignment = False
			Me.tcUnitPrice.Text = "tcUnitPrice"
			Me.tcUnitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.tcUnitPrice.Weight = 0.4663461624235804R
			' 
			' tcDiscont
			' 
			Me.tcDiscont.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.cbDiscont})
			Me.tcDiscont.Name = "tcDiscont"
			Me.tcDiscont.Text = "tcDiscont"
			Me.tcDiscont.Weight = 0.2384614904279494R
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' Detail
			' 
			Me.Detail.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.tbProductData})
			Me.Detail.HeightF = 25F
			Me.Detail.KeepTogether = True
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.StylePriority.UseBorders = False
			Me.Detail.StylePriority.UseTextAlignment = False
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' tbProductData
			' 
			Me.tbProductData.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.tbProductData.Name = "tbProductData"
			Me.tbProductData.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.trProductData})
			Me.tbProductData.SizeF = New System.Drawing.SizeF(649.9999F, 25F)
			' 
			' GroupHeaderTitle
			' 
			Me.GroupHeaderTitle.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.GroupHeaderTitle.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.tbProductHeader})
			Me.GroupHeaderTitle.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold)
			Me.GroupHeaderTitle.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("CategoryID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
			Me.GroupHeaderTitle.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WholePage
			Me.GroupHeaderTitle.HeightF = 65F
			Me.GroupHeaderTitle.Name = "GroupHeaderTitle"
			Me.GroupHeaderTitle.RepeatEveryPage = True
			Me.GroupHeaderTitle.StylePriority.UseBorders = False
			Me.GroupHeaderTitle.StylePriority.UseFont = False
			Me.GroupHeaderTitle.StylePriority.UseTextAlignment = False
			Me.GroupHeaderTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
			' 
			' TopMargin
			' 
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' nwindDataSet1
			' 
			Me.nwindDataSet1.DataSetName = "nwindDataSet"
			Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' productsTableAdapter
			' 
			Me.productsTableAdapter.ClearBeforeFill = True
			' 
			' ProductsReport
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeaderTitle})
			Me.DataAdapter = Me.productsTableAdapter
			Me.DataMember = "Products"
			Me.DataSource = Me.nwindDataSet1
			Me.Version = "13.2"
			DirectCast(Me.tbProductHeader, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.tbProductData, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private tcUnitsOnOrder As DevExpress.XtraReports.UI.XRTableCell
		Private tcUnitPriceHeader As DevExpress.XtraReports.UI.XRTableCell
		Private tcUnitsInStockHeader As DevExpress.XtraReports.UI.XRTableCell
		Private tcProductName As DevExpress.XtraReports.UI.XRTableCell
		Private tcDiscontHeader As DevExpress.XtraReports.UI.XRTableCell
		Private cbDiscont As DevExpress.XtraReports.UI.XRCheckBox
		Private tcUnitsInStock As DevExpress.XtraReports.UI.XRTableCell
		Private tcUnitsOnOrderHeader As DevExpress.XtraReports.UI.XRTableCell
		Private tbProductHeader As DevExpress.XtraReports.UI.XRTable
		Private trProductHeader As DevExpress.XtraReports.UI.XRTableRow
		Private tcProductNameHeader As DevExpress.XtraReports.UI.XRTableCell
		Private trProductData As DevExpress.XtraReports.UI.XRTableRow
		Private tcUnitPrice As DevExpress.XtraReports.UI.XRTableCell
		Private tcDiscont As DevExpress.XtraReports.UI.XRTableCell
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private tbProductData As DevExpress.XtraReports.UI.XRTable
		Private GroupHeaderTitle As DevExpress.XtraReports.UI.GroupHeaderBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
		Private WithEvents tcCategoryName As DevExpress.XtraReports.UI.XRTableCell
		Private nwindDataSet1 As nwindDataSet
		Private productsTableAdapter As nwindDataSetTableAdapters.ProductsTableAdapter

	End Class
End Namespace
