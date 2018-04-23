// Developer Express Code Central Example:
// How to get visible rows on the screen
// 
// You should get a DataPresenter. This dependency object supports the IScrollInfo
// interface. This interface provides the VerticalOffset and ViewportHeight
// properties. In fact, the VerticalOffset property is a VisibleIndex for the first
// row, but the ViewprotHeight is a number of visible rows. Use the
// GridControl.GetRowHandleByVisibleIndex method to get the first visible and last
// visible row handles. If the last row handle is not valid, it means that you try
// to parse empty space, and the last row handle on the screen is the last row
// within row handles.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E3138

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace Sample {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
    }
}