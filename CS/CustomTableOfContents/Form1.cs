using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Native;

namespace CustomTableOfContents {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            CategoriesReport categoriesReport = new CategoriesReport();
            categoriesReport.CreateDocument();


            ProductsReport productsReport = new ProductsReport();
            productsReport.CreateDocument();

            //Merge reports
            categoriesReport.Pages.AddRange(productsReport.Pages);

            CreateLinks(categoriesReport);

            categoriesReport.ShowPreviewDialog();
        }

        private static void CreateLinks(XtraReport report) {
            List<VisualBrick> linkBricks = new List<VisualBrick>();
            List<VisualBrick> pageBricks = new List<VisualBrick>();
            List<TargetBrick> targetBricks = new List<TargetBrick>();



            foreach (Page page in report.Pages) {
                foreach (VisualBrick brick in BrickSelector.GetBricks(page)) {
                    if (brick.Tag != null) {
                        string tagString = brick.Tag.ToString();

                        if (tagString.StartsWith("Link_")) {
                            linkBricks.Add(brick);
                        }

                        if (tagString.StartsWith("Target_")) {
                            targetBricks.Add(new TargetBrick() { Brick = brick, Page = page });
                        }

                        if (tagString.StartsWith("PageBrick_")) {
                            pageBricks.Add(brick);
                        }
                    }
                }
            }

            foreach (VisualBrick link in linkBricks) {
                string key = link.Tag.ToString().Substring(5);
                TargetBrick target = targetBricks.Find(targetBrick => (string)targetBrick.Brick.Tag == String.Concat("Target_", key));
                if (target != null) {
                    target.Brick.AnchorName = key;
                    link.Url = key;
                    link.NavigationPair = BrickPagePair.Create(target.Brick, target.Page);
                    VisualBrick pageBrick = pageBricks.Find(brick => (string)brick.Tag == String.Concat("PageBrick_", key));
                    if (pageBrick != null)
                        pageBrick.Text = (target.Page.Index + 1).ToString();
                }
            }
        }
    }
}
