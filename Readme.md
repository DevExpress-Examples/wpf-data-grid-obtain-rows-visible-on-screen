<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128647777/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3138)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WPF Data Grid - Obtain Rows Visible on Screen

This example demonstrates how to obtain grid rows visible on the screeen and display them in the `ListBox`.

![image](https://user-images.githubusercontent.com/65009440/225308974-ba0467ae-e98c-4028-924d-a0644f7d12e2.png)

The [TopRowIndex](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataViewBase.TopRowIndex) property returns the top visible row's index. To calculate the index of the bottom visible row, get the GridControl's [ScrollViewer](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.scrollviewer) and sum its [ViewportHeight](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.scrollviewer.viewportheight) and [VerticalOffset](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.scrollviewer.verticaloffset) property values.

## Files to Review

* [Window1.xaml](./CS/IScrollInfoSample/Window1.xaml) (VB: [Window1.xaml](./VB/IScrollInfoSample/Window1.xaml))
* [Window1.xaml.cs](./CS/IScrollInfoSample/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/IScrollInfoSample/Window1.xaml.vb))

## Documentation

* [Iterate Through Rows and Cells in Code](https://docs.devexpress.com/WPF/6122/controls-and-libraries/data-grid/grid-view-data-layout/iterate-through-rows)
* [Obtain Row Handles](https://docs.devexpress.com/WPF/6322/controls-and-libraries/data-grid/grid-view-data-layout/rows-and-cards/obtain-row-handles)
* [Identify Rows and Cards](https://docs.devexpress.com/WPF/6097/controls-and-libraries/data-grid/grid-view-data-layout/rows-and-cards/identify-rows-and-cards)

## More Examples

* [WPF Data Grid - Focus a Cell with the Specified Value](https://github.com/DevExpress-Examples/how-to-focus-a-cell-with-the-specified-value-e1544)
* [WPF Data Grid - Add and Remove Rows in Code](https://github.com/DevExpress-Examples/how-to-add-and-remove-rows-in-code)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-obtain-rows-visible-on-screen&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-obtain-rows-visible-on-screen&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
