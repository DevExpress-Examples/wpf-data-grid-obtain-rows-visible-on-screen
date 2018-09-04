using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using DevExpress.Mvvm.UI;

namespace Sample {
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
            var list = new List<Item>();
            for (int i = 0; i < 100; i++)
                list.Add(new Item() { Number = i % 3, Text = "row" + i });
            grid.ItemsSource = list;
        }

        public void GetVisibleRowsOnScreen() {
            listBox.Items.Clear();

            var scrollViewer = LayoutTreeHelper.GetVisualChildren(view).OfType<ScrollViewer>().FirstOrDefault();
            if (scrollViewer == null)
                return;

            int bottomIndex = Convert.ToInt32(scrollViewer.ViewportHeight + scrollViewer.VerticalOffset);

            for (int i = grid.View.TopRowIndex; i <= bottomIndex; i++) {
                var handle = grid.GetRowHandleByVisibleIndex(i);
                if (!grid.IsValidRowHandle(handle))
                    continue;
                var item = grid.GetRow(handle) as Item;
                if (item == null)
                    listBox.Items.Add("<null>");
                else
                    listBox.Items.Add(grid.IsGroupRowHandle(handle) ? "Group: " + item.Text : item.Text);
            }
        }
        void OnButtonClick(object sender, RoutedEventArgs e) {
            GetVisibleRowsOnScreen();
        }
    }
    public class Item {
        public int Number { get; set; }
        public string Text { get; set; }
    }
}