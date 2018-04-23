# How to create a custom Table Of Contents for merged reports with page indexes


This code example illustrates how to create a custom "Table Of Contents" in a separate report. <br>It is necessary to create links between bricks of merged reports manually, after the reports are merged. Get the required bricks from the report using <strong>NestedBrickIterator</strong> and use the <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPrintingVisualBrick_NavigationPairtopic">VisualBrick.NavigationPair</a> property to create a link. To provide page indexes for such links, collect "page" bricks to a separate collection and then modify the <strong>VisualBrick.Text</strong> property value based on <strong>Target.Page.Index</strong>.

<br/>


