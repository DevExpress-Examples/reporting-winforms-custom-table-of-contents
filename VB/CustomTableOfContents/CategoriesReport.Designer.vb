Namespace CustomTableOfContents

    Partial Class CategoriesReport

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomTableOfContents.CategoriesReport))
            Me.pbPicture = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.lbCategoryName = New DevExpress.XtraReports.UI.XRLabel()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.lbHeader = New DevExpress.XtraReports.UI.XRLabel()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.lbPage = New DevExpress.XtraReports.UI.XRLabel()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' pbPicture
            ' 
            Me.pbPicture.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ImageSource", "[Picture]")})
            Me.pbPicture.LocationFloat = New DevExpress.Utils.PointFloat(0F, 10F)
            Me.pbPicture.Name = "pbPicture"
            Me.pbPicture.SizeF = New System.Drawing.SizeF(100F, 50F)
            Me.pbPicture.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
            ' 
            ' lbCategoryName
            ' 
            Me.lbCategoryName.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CategoryName]")})
            Me.lbCategoryName.Font = New DevExpress.Drawing.DXFont("Times New Roman", 16F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.lbCategoryName.LocationFloat = New DevExpress.Utils.PointFloat(110.625F, 10.00001F)
            Me.lbCategoryName.Name = "lbCategoryName"
            Me.lbCategoryName.NavigateUrl = "lbHeader"
            Me.lbCategoryName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.lbCategoryName.SizeF = New System.Drawing.SizeF(461.6667F, 49.99999F)
            Me.lbCategoryName.StylePriority.UseFont = False
            Me.lbCategoryName.StylePriority.UseTextAlignment = False
            Me.lbCategoryName.Target = "_self"
            Me.lbCategoryName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            AddHandler Me.lbCategoryName.BeforePrint, New DevExpress.XtraReports.UI.BeforePrintEventHandler(AddressOf Me.lbCategoryName_BeforePrint)
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' lbHeader
            ' 
            Me.lbHeader.Font = New DevExpress.Drawing.DXFont("Times New Roman", 36F)
            Me.lbHeader.LocationFloat = New DevExpress.Utils.PointFloat(0F, 10.00001F)
            Me.lbHeader.Name = "lbHeader"
            Me.lbHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.lbHeader.SizeF = New System.Drawing.SizeF(650.0001F, 54.99999F)
            Me.lbHeader.StylePriority.UseFont = False
            Me.lbHeader.StylePriority.UseTextAlignment = False
            Me.lbHeader.Text = "Contents"
            Me.lbHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lbPage, Me.pbPicture, Me.lbCategoryName})
            Me.Detail.HeightF = 70F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' lbPage
            ' 
            Me.lbPage.Font = New DevExpress.Drawing.DXFont("Times New Roman", 20.25F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", (CByte((0))))})
            Me.lbPage.LocationFloat = New DevExpress.Utils.PointFloat(583.75F, 10.00001F)
            Me.lbPage.Name = "lbPage"
            Me.lbPage.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.lbPage.SizeF = New System.Drawing.SizeF(56.25F, 50F)
            Me.lbPage.StylePriority.UseFont = False
            Me.lbPage.StylePriority.UseTextAlignment = False
            Me.lbPage.Text = "lbPage"
            Me.lbPage.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            AddHandler Me.lbPage.BeforePrint, New DevExpress.XtraReports.UI.BeforePrintEventHandler(AddressOf Me.lbPage_BeforePrint)
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lbHeader})
            Me.ReportHeader.HeightF = 75F
            Me.ReportHeader.Name = "ReportHeader"
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "NorthwindConnection"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            columnExpression1.ColumnName = "CategoryID"
            table1.Name = "Categories"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "CategoryName"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "Description"
            columnExpression3.Table = table1
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "Picture"
            columnExpression4.Table = table1
            column4.Expression = columnExpression4
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Columns.Add(column3)
            selectQuery1.Columns.Add(column4)
            selectQuery1.Name = "Categories"
            selectQuery1.Tables.Add(table1)
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {selectQuery1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' CategoriesReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.sqlDataSource1})
            Me.DataMember = "Categories"
            Me.DataSource = Me.sqlDataSource1
            Me.Version = "23.1"
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private pbPicture As DevExpress.XtraReports.UI.XRPictureBox

        Private lbCategoryName As DevExpress.XtraReports.UI.XRLabel

        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand

        Private lbHeader As DevExpress.XtraReports.UI.XRLabel

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand

        Private lbPage As DevExpress.XtraReports.UI.XRLabel

        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    End Class
End Namespace
