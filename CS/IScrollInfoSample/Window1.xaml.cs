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
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls.Primitives;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Core.Native;

namespace Sample {
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window {
        List<TestData> list;
        public Window1() {
            InitializeComponent();
            list = new List<TestData>();
            list.Add(new TestData() { Number = 1, Text = "row1" });
            list.Add(new TestData() { Number = 2, Text = "row2" });
            list.Add(new TestData() { Number = 3, Text = "row3" });
            list.Add(new TestData() { Number = 1, Text = "row4" });
            list.Add(new TestData() { Number = 2, Text = "row5" });
            list.Add(new TestData() { Number = 3, Text = "row6" });
            list.Add(new TestData() { Number = 1, Text = "row7" });
            list.Add(new TestData() { Number = 2, Text = "row8" });
            list.Add(new TestData() { Number = 3, Text = "row9" });
            list.Add(new TestData() { Number = 1, Text = "row10" });
            list.Add(new TestData() { Number = 2, Text = "row11" });
            list.Add(new TestData() { Number = 3, Text = "row12" });
            grid.ItemsSource = list;
        }

        IScrollInfo GetScrollInfo() {
            foreach (DependencyObject item in new VisualTreeEnumerable(view)) {
                if (item is DataPresenter)
                    return (DataPresenter)item;
            }
            throw new InvalidOperationException();
        }

        public void GetVisibleRowsOnScreen() {
            int RowHandle1 = grid.GetRowHandleByListIndex((this.grid.View as TableView).TopRowIndex);
            int RowHandle2 = grid.GetRowHandleByVisibleIndex(Convert.ToInt32(GetScrollInfo().ViewportHeight + GetScrollInfo().VerticalOffset));
            
            TestData td;
            listBox.Items.Clear();
            if(grid.IsValidRowHandle(RowHandle2)) {
                for(int i = RowHandle1; i <= RowHandle2; i++) {
                    td = grid.GetRow(i) as TestData;
                    listBox.Items.Add(td.Text);
                }
            } else {
                for(int i = RowHandle1; i < grid.VisibleRowCount; i++) {
                    td = grid.GetRow(i) as TestData;
                    listBox.Items.Add(td.Text);
                }
            }
        }

        private void view_ScrollChanged(object sender, ScrollChangedEventArgs e) {
            //GetVisibleRowsOnScreen
        }

        private void button1_Click(object sender, RoutedEventArgs e) {
            
            this.GetVisibleRowsOnScreen();
        }
    }
    public class TestData {
        public int Number { get; set; }
        public string Text { get; set; }
    }
}