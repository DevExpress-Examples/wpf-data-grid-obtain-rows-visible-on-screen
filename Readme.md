<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128647777/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3138)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# GridControl - How to obtain rows visible in GridControl's viewport


<p>In this example, we used the approach from the <a href="https://documentation.devexpress.com/WPF/6122/Controls-and-Libraries/Data-Grid/Focus-and-Navigation/Traversing-Rows">Traversing Rows</a> topic. As we need only visible  rows, we create a cycle from the <a href="https://documentation.devexpress.com/#wpf/DevExpressXpfGridDataViewBase_TopRowIndextopic">TopRowIndex</a> value to the bottom row index (this value is obtained from the grid's <a href="https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.scrollviewer">ScrollViewer</a>).

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-obtain-rows-visible-on-screen&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-obtain-rows-visible-on-screen&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
