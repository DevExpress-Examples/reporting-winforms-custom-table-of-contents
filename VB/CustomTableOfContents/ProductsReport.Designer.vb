Namespace CustomTableOfContents

    Partial Class ProductsReport

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim selectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column4 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression4 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column5 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression5 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column6 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression6 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column7 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression7 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column8 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression8 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column9 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression9 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column10 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression10 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column11 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression11 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column12 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression12 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table2 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim join1 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim relationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomTableOfContents.ProductsReport))
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
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            CType((Me.tbProductHeader), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tbProductData), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' tcUnitsOnOrder
            ' 
            Me.tcUnitsOnOrder.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitsOnOrder]")})
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
            Me.tcProductName.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductName]")})
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
            Me.tcDiscontHeader.Weight = 0.23846170170351016R
            ' 
            ' cbDiscont
            ' 
            Me.cbDiscont.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.cbDiscont.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "CheckBoxState", "[Discontinued]")})
            Me.cbDiscont.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.cbDiscont.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.cbDiscont.Name = "cbDiscont"
            Me.cbDiscont.SizeF = New System.Drawing.SizeF(50.62496F, 23.95833F)
            Me.cbDiscont.StylePriority.UseBorders = False
            ' 
            ' tcUnitsInStock
            ' 
            Me.tcUnitsInStock.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitsInStock]")})
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
            Me.tbProductHeader.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow1, Me.trProductHeader})
            Me.tbProductHeader.SizeF = New System.Drawing.SizeF(649.9999F, 55F)
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tcCategoryName})
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Weight = 1.2R
            ' 
            ' tcCategoryName
            ' 
            Me.tcCategoryName.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CategoryName]"), New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Bookmark", "[CategoryName]")})
            Me.tcCategoryName.Font = New DevExpress.Drawing.DXFont("Times New Roman", 16F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.tcCategoryName.Name = "tcCategoryName"
            Me.tcCategoryName.StylePriority.UseFont = False
            Me.tcCategoryName.StylePriority.UseTextAlignment = False
            Me.tcCategoryName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.tcCategoryName.Weight = 3R
            AddHandler Me.tcCategoryName.BeforePrint, New DevExpress.XtraReports.UI.BeforePrintEventHandler(AddressOf Me.tcCategoryName_BeforePrint)
            ' 
            ' trProductHeader
            ' 
            Me.trProductHeader.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tcProductNameHeader, Me.tcUnitPriceHeader, Me.tcUnitsInStockHeader, Me.tcUnitsOnOrderHeader, Me.tcDiscontHeader})
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
            Me.trProductData.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tcProductName, Me.tcUnitPrice, Me.tcUnitsInStock, Me.tcUnitsOnOrder, Me.tcDiscont})
            Me.trProductData.Name = "trProductData"
            Me.trProductData.Weight = 1R
            ' 
            ' tcUnitPrice
            ' 
            Me.tcUnitPrice.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitPrice]")})
            Me.tcUnitPrice.Name = "tcUnitPrice"
            Me.tcUnitPrice.StylePriority.UseTextAlignment = False
            Me.tcUnitPrice.Text = "tcUnitPrice"
            Me.tcUnitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.tcUnitPrice.TextFormatString = "{0:c}"
            Me.tcUnitPrice.Weight = 0.4663461624235804R
            ' 
            ' tcDiscont
            ' 
            Me.tcDiscont.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.cbDiscont})
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
            Me.Detail.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.tbProductData})
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
            Me.tbProductData.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.trProductData})
            Me.tbProductData.SizeF = New System.Drawing.SizeF(649.9999F, 25F)
            ' 
            ' GroupHeaderTitle
            ' 
            Me.GroupHeaderTitle.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.GroupHeaderTitle.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.tbProductHeader})
            Me.GroupHeaderTitle.Font = New DevExpress.Drawing.DXFont("Times New Roman", 9.75F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.GroupHeaderTitle.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("CategoryID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
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
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "NorthwindConnection"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            columnExpression1.ColumnName = "ProductID"
            table1.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""283"" />"
            table1.Name = "Products"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "ProductName"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "SupplierID"
            columnExpression3.Table = table1
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "CategoryID"
            columnExpression4.Table = table1
            column4.Expression = columnExpression4
            columnExpression5.ColumnName = "QuantityPerUnit"
            columnExpression5.Table = table1
            column5.Expression = columnExpression5
            columnExpression6.ColumnName = "UnitPrice"
            columnExpression6.Table = table1
            column6.Expression = columnExpression6
            columnExpression7.ColumnName = "UnitsInStock"
            columnExpression7.Table = table1
            column7.Expression = columnExpression7
            columnExpression8.ColumnName = "UnitsOnOrder"
            columnExpression8.Table = table1
            column8.Expression = columnExpression8
            columnExpression9.ColumnName = "ReorderLevel"
            columnExpression9.Table = table1
            column9.Expression = columnExpression9
            columnExpression10.ColumnName = "Discontinued"
            columnExpression10.Table = table1
            column10.Expression = columnExpression10
            columnExpression11.ColumnName = "EAN13"
            columnExpression11.Table = table1
            column11.Expression = columnExpression11
            columnExpression12.ColumnName = "CategoryName"
            table2.MetaSerializable = "<Meta X=""185"" Y=""30"" Width=""125"" Height=""143"" />"
            table2.Name = "Categories"
            columnExpression12.Table = table2
            column12.Expression = columnExpression12
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Columns.Add(column3)
            selectQuery1.Columns.Add(column4)
            selectQuery1.Columns.Add(column5)
            selectQuery1.Columns.Add(column6)
            selectQuery1.Columns.Add(column7)
            selectQuery1.Columns.Add(column8)
            selectQuery1.Columns.Add(column9)
            selectQuery1.Columns.Add(column10)
            selectQuery1.Columns.Add(column11)
            selectQuery1.Columns.Add(column12)
            selectQuery1.Name = "Products"
            relationColumnInfo1.NestedKeyColumn = "CategoryID"
            relationColumnInfo1.ParentKeyColumn = "CategoryID"
            join1.KeyColumns.Add(relationColumnInfo1)
            join1.Nested = table2
            join1.Parent = table1
            selectQuery1.Relations.Add(join1)
            selectQuery1.Tables.Add(table1)
            selectQuery1.Tables.Add(table2)
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {selectQuery1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' ProductsReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeaderTitle})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.sqlDataSource1})
            Me.DataMember = "Products"
            Me.DataSource = Me.sqlDataSource1
            Me.Version = "23.1"
            CType((Me.tbProductHeader), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tbProductData), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
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

        Private tcCategoryName As DevExpress.XtraReports.UI.XRTableCell

        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    End Class
End Namespace
