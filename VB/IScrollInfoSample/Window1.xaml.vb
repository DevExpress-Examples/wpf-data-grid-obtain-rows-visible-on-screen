Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Mvvm.UI

Namespace Sample
    Partial Public Class Window1
        Inherits Window

        Public Sub New()
            InitializeComponent()
            Dim list = New List(Of Item)()
            For i As Integer = 0 To 99
                list.Add(New Item() With { _
                    .Number = i Mod 3, _
                    .Text = "row" & i _
                })
            Next i
            grid.ItemsSource = list
        End Sub

        Public Sub GetVisibleRowsOnScreen()
            listBox.Items.Clear()

            Dim scrollViewer = LayoutTreeHelper.GetVisualChildren(view).OfType(Of ScrollViewer)().FirstOrDefault()
            If scrollViewer Is Nothing Then
                Return
            End If

            Dim bottomIndex As Integer = Convert.ToInt32(scrollViewer.ViewportHeight + scrollViewer.VerticalOffset)

            For i As Integer = grid.View.TopRowIndex To bottomIndex
                Dim handle = grid.GetRowHandleByVisibleIndex(i)
                If Not grid.IsValidRowHandle(handle) Then
                    Continue For
                End If
                Dim item = TryCast(grid.GetRow(handle), Item)
                If item Is Nothing Then
                    listBox.Items.Add("<null>")
                Else
                    listBox.Items.Add(If(grid.IsGroupRowHandle(handle), "Group: " & item.Text, item.Text))
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