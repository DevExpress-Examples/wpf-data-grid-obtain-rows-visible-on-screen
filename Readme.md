# GridControl - How to get currently visible rows on the screen


<p>You should get a DataPresenter. This dependency object supports the IScrollInfo interface. This interface provides the VerticalOffset and ViewportHeight properties. In fact, the VerticalOffset property is a VisibleIndex for the first row, but the ViewprotHeight is a number of visible rows. Use the GridControl.GetRowHandleByVisibleIndex method to get the first visible and last visible row handles. If the last row handle is not valid, it means that you try to parse empty space, and the last row handle on the screen is the last row within row handles.<br /><br /></p>
<p><strong>Edited:</strong><br />Starting with v12.1, TableView has the <a href="https://documentation.devexpress.com/#wpf/DevExpressXpfGridDataViewBase_TopRowIndextopic">TopRowIndex</a> property, which allows retrieving the index of the first row shown in GridControl. </p>

<br/>


