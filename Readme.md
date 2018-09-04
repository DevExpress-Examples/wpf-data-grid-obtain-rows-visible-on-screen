# GridControl - How to obtain rows visible in GridControl's viewport


<p>In this example, we used the approach from the <a href="https://documentation.devexpress.com/WPF/6122/Controls-and-Libraries/Data-Grid/Focus-and-Navigation/Traversing-Rows">Traversing Rows</a> topic. As we need only visible  rows, we create a cycle from the <a href="https://documentation.devexpress.com/#wpf/DevExpressXpfGridDataViewBase_TopRowIndextopic">TopRowIndex</a> value to the bottom row index (this value is obtained from the grid's <a href="https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.scrollviewer">ScrollViewer</a>).

<br/>


