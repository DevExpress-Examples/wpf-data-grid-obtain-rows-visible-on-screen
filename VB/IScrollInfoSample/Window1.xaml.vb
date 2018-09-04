Imports DevExpress.Mvvm.UI

Namespace Sample
    Partial Public Class Window1
        Inherits Window

        Public Sub New()
            InitializeComponent()
            Dim list = New List(Of Item)()
            For i As Integer = 0 To 99
                list.Add(New Item() With {.Number = i Mod 3, .Text = "row" & i})
            Next i
            Grid.ItemsSource = list
        End Sub

        Public Sub GetVisibleRowsOnScreen()
            Dim scrollViewer = LayoutTreeHelper.GetVisualChildren(view).OfType(Of ScrollViewer)().FirstOrDefault()
            Dim bottomIndex As Integer = Convert.ToInt32(scrollViewer.ViewportHeight + scrollViewer.VerticalOffset)

            ListBox.Items.Clear()
            For i As Integer = Grid.View.TopRowIndex To bottomIndex
                Dim handle = Grid.GetRowHandleByVisibleIndex(i)
                If Not Grid.IsValidRowHandle(handle) Then
                    Continue For
                End If
                Dim item = TryCast(Grid.GetRow(handle), Item)
                If item Is Nothing Then
                    ListBox.Items.Add("<null>")
                Else
                    ListBox.Items.Add(If(Grid.IsGroupRowHandle(handle), "Group: " & item.Text, item.Text))
                End If
            Next i
        End Sub
        Private Sub OnButtonClick(ByVal sender As Object, ByVal e As RoutedEventArgs)
            GetVisibleRowsOnScreen()
        End Sub
    End Class

    Public Class Item
        Public Property Number() As Integer
        Public Property Text() As String
    End Class
End Namespace