namespace CustomTableOfContents {
    partial class ProductsReport {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column9 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression9 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column10 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression10 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column11 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression11 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column12 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression12 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Join join1 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsReport));
            this.tcUnitsOnOrder = new DevExpress.XtraReports.UI.XRTableCell();
            this.tcUnitPriceHeader = new DevExpress.XtraReports.UI.XRTableCell();
            this.tcUnitsInStockHeader = new DevExpress.XtraReports.UI.XRTableCell();
            this.tcProductName = new DevExpress.XtraReports.UI.XRTableCell();
            this.tcDiscontHeader = new DevExpress.XtraReports.UI.XRTableCell();
            this.cbDiscont = new DevExpress.XtraReports.UI.XRCheckBox();
            this.tcUnitsInStock = new DevExpress.XtraReports.UI.XRTableCell();
            this.tcUnitsOnOrderHeader = new DevExpress.XtraReports.UI.XRTableCell();
            this.tbProductHeader = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tcCategoryName = new DevExpress.XtraReports.UI.XRTableCell();
            this.trProductHeader = new DevExpress.XtraReports.UI.XRTableRow();
            this.tcProductNameHeader = new DevExpress.XtraReports.UI.XRTableCell();
            this.trProductData = new DevExpress.XtraReports.UI.XRTableRow();
            this.tcUnitPrice = new DevExpress.XtraReports.UI.XRTableCell();
            this.tcDiscont = new DevExpress.XtraReports.UI.XRTableCell();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.tbProductData = new DevExpress.XtraReports.UI.XRTable();
            this.GroupHeaderTitle = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbProductHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // tcUnitsOnOrder
            // 
            this.tcUnitsOnOrder.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitsOnOrder]")});
            this.tcUnitsOnOrder.Name = "tcUnitsOnOrder";
            this.tcUnitsOnOrder.StylePriority.UseTextAlignment = false;
            this.tcUnitsOnOrder.Text = "tcUnitsOnOrder";
            this.tcUnitsOnOrder.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tcUnitsOnOrder.Weight = 0.44903843327809811D;
            // 
            // tcUnitPriceHeader
            // 
            this.tcUnitPriceHeader.Name = "tcUnitPriceHeader";
            this.tcUnitPriceHeader.Text = "Unit Price";
            this.tcUnitPriceHeader.Weight = 0.4663460215732067D;
            // 
            // tcUnitsInStockHeader
            // 
            this.tcUnitsInStockHeader.Name = "tcUnitsInStockHeader";
            this.tcUnitsInStockHeader.Text = "Units In Stock";
            this.tcUnitsInStockHeader.Weight = 0.46634598636061309D;
            // 
            // tcProductName
            // 
            this.tcProductName.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductName]")});
            this.tcProductName.Name = "tcProductName";
            this.tcProductName.StylePriority.UseTextAlignment = false;
            this.tcProductName.Text = "tcProductName";
            this.tcProductName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.tcProductName.Weight = 1.3798077514467915D;
            // 
            // tcDiscontHeader
            // 
            this.tcDiscontHeader.Name = "tcDiscontHeader";
            this.tcDiscontHeader.Text = "Discont.";
            this.tcDiscontHeader.Weight = 0.23846170170351016D;
            // 
            // cbDiscont
            // 
            this.cbDiscont.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.cbDiscont.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "CheckBoxState", "[Discontinued]")});
            this.cbDiscont.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbDiscont.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.cbDiscont.Name = "cbDiscont";
            this.cbDiscont.SizeF = new System.Drawing.SizeF(50.62496F, 23.95833F);
            this.cbDiscont.StylePriority.UseBorders = false;
            // 
            // tcUnitsInStock
            // 
            this.tcUnitsInStock.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitsInStock]")});
            this.tcUnitsInStock.Name = "tcUnitsInStock";
            this.tcUnitsInStock.StylePriority.UseTextAlignment = false;
            this.tcUnitsInStock.Text = "tcUnitsInStock";
            this.tcUnitsInStock.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tcUnitsInStock.Weight = 0.46634616242358046D;
            // 
            // tcUnitsOnOrderHeader
            // 
            this.tcUnitsOnOrderHeader.Name = "tcUnitsOnOrderHeader";
            this.tcUnitsOnOrderHeader.Text = "Units On Order";
            this.tcUnitsOnOrderHeader.Weight = 0.44903843327809806D;
            // 
            // tbProductHeader
            // 
            this.tbProductHeader.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10F);
            this.tbProductHeader.Name = "tbProductHeader";
            this.tbProductHeader.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1,
            this.trProductHeader});
            this.tbProductHeader.SizeF = new System.Drawing.SizeF(649.9999F, 55F);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tcCategoryName});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1.2D;
            // 
            // tcCategoryName
            // 
            this.tcCategoryName.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CategoryName]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Bookmark", "[CategoryName]")});
            this.tcCategoryName.Font = new DevExpress.Drawing.DXFont("Times New Roman", 16F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tcCategoryName.Name = "tcCategoryName";
            this.tcCategoryName.StylePriority.UseFont = false;
            this.tcCategoryName.StylePriority.UseTextAlignment = false;
            this.tcCategoryName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.tcCategoryName.Weight = 3D;
            this.tcCategoryName.BeforePrint += new DevExpress.XtraReports.UI.BeforePrintEventHandler(this.tcCategoryName_BeforePrint);
            // 
            // trProductHeader
            // 
            this.trProductHeader.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tcProductNameHeader,
            this.tcUnitPriceHeader,
            this.tcUnitsInStockHeader,
            this.tcUnitsOnOrderHeader,
            this.tcDiscontHeader});
            this.trProductHeader.Name = "trProductHeader";
            this.trProductHeader.Weight = 1D;
            // 
            // tcProductNameHeader
            // 
            this.tcProductNameHeader.Name = "tcProductNameHeader";
            this.tcProductNameHeader.Text = "Product Name";
            this.tcProductNameHeader.Weight = 1.379807857084572D;
            // 
            // trProductData
            // 
            this.trProductData.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tcProductName,
            this.tcUnitPrice,
            this.tcUnitsInStock,
            this.tcUnitsOnOrder,
            this.tcDiscont});
            this.trProductData.Name = "trProductData";
            this.trProductData.Weight = 1D;
            // 
            // tcUnitPrice
            // 
            this.tcUnitPrice.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitPrice]")});
            this.tcUnitPrice.Name = "tcUnitPrice";
            this.tcUnitPrice.StylePriority.UseTextAlignment = false;
            this.tcUnitPrice.Text = "tcUnitPrice";
            this.tcUnitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tcUnitPrice.TextFormatString = "{0:c}";
            this.tcUnitPrice.Weight = 0.4663461624235804D;
            // 
            // tcDiscont
            // 
            this.tcDiscont.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.cbDiscont});
            this.tcDiscont.Name = "tcDiscont";
            this.tcDiscont.Text = "tcDiscont";
            this.tcDiscont.Weight = 0.2384614904279494D;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Detail
            // 
            this.Detail.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.tbProductData});
            this.Detail.HeightF = 25F;
            this.Detail.KeepTogether = true;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StylePriority.UseBorders = false;
            this.Detail.StylePriority.UseTextAlignment = false;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // tbProductData
            // 
            this.tbProductData.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.tbProductData.Name = "tbProductData";
            this.tbProductData.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.trProductData});
            this.tbProductData.SizeF = new System.Drawing.SizeF(649.9999F, 25F);
            // 
            // GroupHeaderTitle
            // 
            this.GroupHeaderTitle.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.GroupHeaderTitle.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.tbProductHeader});
            this.GroupHeaderTitle.Font = new DevExpress.Drawing.DXFont("Times New Roman", 9.75F, DevExpress.Drawing.DXFontStyle.Bold);
            this.GroupHeaderTitle.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("CategoryID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeaderTitle.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WholePage;
            this.GroupHeaderTitle.HeightF = 65F;
            this.GroupHeaderTitle.Name = "GroupHeaderTitle";
            this.GroupHeaderTitle.RepeatEveryPage = true;
            this.GroupHeaderTitle.StylePriority.UseBorders = false;
            this.GroupHeaderTitle.StylePriority.UseFont = false;
            this.GroupHeaderTitle.StylePriority.UseTextAlignment = false;
            this.GroupHeaderTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "NorthwindConnection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "ProductID";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"283\" />";
            table1.Name = "Products";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "ProductName";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "SupplierID";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "CategoryID";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "QuantityPerUnit";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "UnitPrice";
            columnExpression6.Table = table1;
            column6.Expression = columnExpression6;
            columnExpression7.ColumnName = "UnitsInStock";
            columnExpression7.Table = table1;
            column7.Expression = columnExpression7;
            columnExpression8.ColumnName = "UnitsOnOrder";
            columnExpression8.Table = table1;
            column8.Expression = columnExpression8;
            columnExpression9.ColumnName = "ReorderLevel";
            columnExpression9.Table = table1;
            column9.Expression = columnExpression9;
            columnExpression10.ColumnName = "Discontinued";
            columnExpression10.Table = table1;
            column10.Expression = columnExpression10;
            columnExpression11.ColumnName = "EAN13";
            columnExpression11.Table = table1;
            column11.Expression = columnExpression11;
            columnExpression12.ColumnName = "CategoryName";
            table2.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"143\" />";
            table2.Name = "Categories";
            columnExpression12.Table = table2;
            column12.Expression = columnExpression12;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.Columns.Add(column7);
            selectQuery1.Columns.Add(column8);
            selectQuery1.Columns.Add(column9);
            selectQuery1.Columns.Add(column10);
            selectQuery1.Columns.Add(column11);
            selectQuery1.Columns.Add(column12);
            selectQuery1.Name = "Products";
            relationColumnInfo1.NestedKeyColumn = "CategoryID";
            relationColumnInfo1.ParentKeyColumn = "CategoryID";
            join1.KeyColumns.Add(relationColumnInfo1);
            join1.Nested = table2;
            join1.Parent = table1;
            selectQuery1.Relations.Add(join1);
            selectQuery1.Tables.Add(table1);
            selectQuery1.Tables.Add(table2);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // ProductsReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeaderTitle});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "Products";
            this.DataSource = this.sqlDataSource1;
            this.Version = "23.1";
            ((System.ComponentModel.ISupportInitialize)(this.tbProductHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.XRTableCell tcUnitsOnOrder;
        private DevExpress.XtraReports.UI.XRTableCell tcUnitPriceHeader;
        private DevExpress.XtraReports.UI.XRTableCell tcUnitsInStockHeader;
        private DevExpress.XtraReports.UI.XRTableCell tcProductName;
        private DevExpress.XtraReports.UI.XRTableCell tcDiscontHeader;
        private DevExpress.XtraReports.UI.XRCheckBox cbDiscont;
        private DevExpress.XtraReports.UI.XRTableCell tcUnitsInStock;
        private DevExpress.XtraReports.UI.XRTableCell tcUnitsOnOrderHeader;
        private DevExpress.XtraReports.UI.XRTable tbProductHeader;
        private DevExpress.XtraReports.UI.XRTableRow trProductHeader;
        private DevExpress.XtraReports.UI.XRTableCell tcProductNameHeader;
        private DevExpress.XtraReports.UI.XRTableRow trProductData;
        private DevExpress.XtraReports.UI.XRTableCell tcUnitPrice;
        private DevExpress.XtraReports.UI.XRTableCell tcDiscont;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRTable tbProductData;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeaderTitle;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell tcCategoryName;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    }
}
