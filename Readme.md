<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128599235/13.2.9%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T328491)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [CategoriesReport.cs](./CS/CustomTableOfContents/CategoriesReport.cs) (VB: [CategoriesReport.vb](./VB/CustomTableOfContents/CategoriesReport.vb))
* **[Form1.cs](./CS/CustomTableOfContents/Form1.cs) (VB: [Form1.vb](./VB/CustomTableOfContents/Form1.vb))**
* [ProductsReport.cs](./CS/CustomTableOfContents/ProductsReport.cs) (VB: [ProductsReport.vb](./VB/CustomTableOfContents/ProductsReport.vb))
* [TargetBrick.cs](./CS/CustomTableOfContents/TargetBrick.cs) (VB: [TargetBrick.vb](./VB/CustomTableOfContents/TargetBrick.vb))
<!-- default file list end -->
# How to create a custom Table Of Contents for merged reports with page indexes


This code example illustrates how to create a custom "Table Of Contents" in a separate report. <br>It is necessary to create links between bricks of merged reports manually, after the reports are merged. Get the required bricks from the report using <strong>NestedBrickIterator</strong> and use the <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPrintingVisualBrick_NavigationPairtopic">VisualBrick.NavigationPair</a> property to create a link. To provide page indexes for such links, collect "page" bricks to a separate collection and then modify the <strong>VisualBrick.Text</strong> property value based on <strong>Target.Page.Index</strong>.

<br/>


