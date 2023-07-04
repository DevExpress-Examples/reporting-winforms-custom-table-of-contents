using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace CustomTableOfContents {
    public partial class ProductsReport : DevExpress.XtraReports.UI.XtraReport {
        public ProductsReport() {
            InitializeComponent();
        }

        private void tcCategoryName_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            XRControl label = sender as XRControl;
            label.Tag = String.Format("Target_{0}", GetCurrentColumnValue("CategoryID"));
        }

    }
}
