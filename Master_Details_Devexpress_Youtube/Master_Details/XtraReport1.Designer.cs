namespace Master_Details
{
    partial class XtraReport1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery23 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column89 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression89 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table23 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column90 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression90 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column91 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression91 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column92 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression92 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column93 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression93 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery24 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column94 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression94 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table24 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column95 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression95 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column96 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression96 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.MasterDetailInfo masterDetailInfo12 = new DevExpress.DataAccess.Sql.MasterDetailInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo12 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraReport1));
            DevExpress.XtraReports.UI.XRGroupSortingSummary xrGroupSortingSummary5 = new DevExpress.XtraReports.UI.XRGroupSortingSummary();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.detailBand2 = new DevExpress.XtraReports.UI.DetailBand();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
            this.topMarginBand1.HeightF = 40.625F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.HeightF = 91.62499F;
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // detailBand1
            // 
            this.detailBand1.Expanded = false;
            this.detailBand1.HeightF = 0F;
            this.detailBand1.Name = "detailBand1";
            this.detailBand1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5F, 5F, 5F, 5F, 100F);
            this.detailBand1.StylePriority.UsePadding = false;
            this.detailBand1.StylePriority.UseTextAlignment = false;
            this.detailBand1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "localhost_InvoiceDBMaster_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression89.ColumnName = "DetailId";
            table23.Name = "InvoiceDetails";
            columnExpression89.Table = table23;
            column89.Expression = columnExpression89;
            columnExpression90.ColumnName = "InvoiceId";
            columnExpression90.Table = table23;
            column90.Expression = columnExpression90;
            columnExpression91.ColumnName = "ProductName";
            columnExpression91.Table = table23;
            column91.Expression = columnExpression91;
            columnExpression92.ColumnName = "Qty";
            columnExpression92.Table = table23;
            column92.Expression = columnExpression92;
            columnExpression93.ColumnName = "Price";
            columnExpression93.Table = table23;
            column93.Expression = columnExpression93;
            selectQuery23.Columns.Add(column89);
            selectQuery23.Columns.Add(column90);
            selectQuery23.Columns.Add(column91);
            selectQuery23.Columns.Add(column92);
            selectQuery23.Columns.Add(column93);
            selectQuery23.MetaSerializable = "<Meta X=\"20\" Y=\"20\" Width=\"130\" Height=\"153\" />";
            selectQuery23.Name = "InvoiceDetails";
            selectQuery23.Tables.Add(table23);
            columnExpression94.ColumnName = "InvoiceId";
            table24.Name = "Invoice";
            columnExpression94.Table = table24;
            column94.Expression = columnExpression94;
            columnExpression95.ColumnName = "CustomerName";
            columnExpression95.Table = table24;
            column95.Expression = columnExpression95;
            columnExpression96.ColumnName = "InvoiceDate";
            columnExpression96.Table = table24;
            column96.Expression = columnExpression96;
            selectQuery24.Columns.Add(column94);
            selectQuery24.Columns.Add(column95);
            selectQuery24.Columns.Add(column96);
            selectQuery24.MetaSerializable = "<Meta X=\"170\" Y=\"20\" Width=\"126\" Height=\"103\" />";
            selectQuery24.Name = "Invoice";
            selectQuery24.Tables.Add(table24);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery23,
            selectQuery24});
            masterDetailInfo12.DetailQueryName = "Invoice";
            relationColumnInfo12.NestedKeyColumn = "InvoiceId";
            relationColumnInfo12.ParentKeyColumn = "InvoiceId";
            masterDetailInfo12.KeyColumns.Add(relationColumnInfo12);
            masterDetailInfo12.MasterQueryName = "InvoiceDetails";
            this.sqlDataSource1.Relations.AddRange(new DevExpress.DataAccess.Sql.MasterDetailInfo[] {
            masterDetailInfo12});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // DetailReport
            // 
            this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.detailBand2,
            this.GroupHeader1});
            this.DetailReport.DataMember = "InvoiceDetails.InvoiceDetailsInvoice";
            this.DetailReport.DataSource = this.sqlDataSource1;
            this.DetailReport.Level = 0;
            this.DetailReport.Name = "DetailReport";
            // 
            // detailBand2
            // 
            this.detailBand2.BorderColor = System.Drawing.Color.LightGray;
            this.detailBand2.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.detailBand2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel8,
            this.xrLabel6,
            this.xrLabel7});
            this.detailBand2.HeightF = 34.375F;
            this.detailBand2.Name = "detailBand2";
            this.detailBand2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5F, 5F, 5F, 5F, 100F);
            this.detailBand2.StylePriority.UseBorderColor = false;
            this.detailBand2.StylePriority.UseBorders = false;
            this.detailBand2.StylePriority.UsePadding = false;
            this.detailBand2.StylePriority.UseTextAlignment = false;
            this.detailBand2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GroupHeader1.BorderColor = System.Drawing.Color.LightGray;
            this.GroupHeader1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel3});
            this.GroupHeader1.Font = new DevExpress.Drawing.DXFont("Times New Roman", 11F);
            this.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader1.HeightF = 33.00001F;
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5F, 5F, 5F, 5F, 100F);
            this.GroupHeader1.RepeatEveryPage = true;
            xrGroupSortingSummary5.Enabled = true;
            xrGroupSortingSummary5.Function = DevExpress.XtraReports.UI.SortingSummaryFunction.DCount;
            xrGroupSortingSummary5.IgnoreNullValues = true;
            this.GroupHeader1.SortingSummary = xrGroupSortingSummary5;
            this.GroupHeader1.StylePriority.UseBackColor = false;
            this.GroupHeader1.StylePriority.UseBorderColor = false;
            this.GroupHeader1.StylePriority.UseBorders = false;
            this.GroupHeader1.StylePriority.UseFont = false;
            this.GroupHeader1.StylePriority.UsePadding = false;
            this.GroupHeader1.StylePriority.UseTextAlignment = false;
            this.GroupHeader1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel6
            // 
            this.xrLabel6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[InvoiceDetails].[ProductName]")});
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(22.91667F, 0F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(184.375F, 23F);
            this.xrLabel6.Text = "xrLabel3";
            // 
            // xrLabel7
            // 
            this.xrLabel7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[InvoiceDetails].[Qty]")});
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(239.5833F, 0F);
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(168.75F, 23F);
            this.xrLabel7.Text = "xrLabel4";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel3
            // 
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(22.91667F, 0F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(184.375F, 23F);
            this.xrLabel3.Text = "ProductName";
            // 
            // xrLabel4
            // 
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(239.5833F, 0F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(168.75F, 23F);
            this.xrLabel4.Text = "ProductQnt";
            // 
            // xrLabel5
            // 
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(464.4583F, 0F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(182.2916F, 23F);
            this.xrLabel5.Text = "Price";
            // 
            // xrLabel8
            // 
            this.xrLabel8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[InvoiceDetails].[Price]")});
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(464.4583F, 0F);
            this.xrLabel8.Multiline = true;
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(182.2916F, 23F);
            this.xrLabel8.Text = "xrLabel8";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel8.TextFormatString = "{0:$0.00}";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new DevExpress.Drawing.DXFont("Times New Roman", 18F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(239.5833F, 0F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(196.875F, 23F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "Master Detalis";
            // 
            // XtraReport1
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.bottomMarginBand1,
            this.detailBand1,
            this.DetailReport});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "InvoiceDetails";
            this.DataSource = this.sqlDataSource1;
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.Margins = new DevExpress.Drawing.DXMargins(47F, 100F, 40.625F, 91.62499F);
            this.Version = "25.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.DetailBand detailBand1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport;
        private DevExpress.XtraReports.UI.DetailBand detailBand2;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
    }
}
