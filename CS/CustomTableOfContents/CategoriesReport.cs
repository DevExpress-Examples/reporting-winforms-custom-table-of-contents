using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace CustomTableOfContents {
    public partial class CategoriesReport : DevExpress.XtraReports.UI.XtraReport {
        public CategoriesReport() {
            InitializeComponent();
        }

        private void lbCategoryName_BeforePrint(object sender, CancelEventArgs e) {
            XRControl label = sender as XRControl;
            label.Tag = String.Format("Link_{0}", GetCurrentColumnValue("CategoryID"));
        }

        private void lbPage_BeforePrint(object sender, CancelEventArgs e) {
            XRControl label = sender as XRControl;
            label.Tag = String.Format("PageBrick_{0}", GetCurrentColumnValue("CategoryID"));
        }

    }
}
