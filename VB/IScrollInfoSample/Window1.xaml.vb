Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Mvvm.UI

Namespace Sample

    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Dim list = New List(Of Item)()
            For i As Integer = 0 To 100 - 1
                list.Add(New Item() With {.Number = i Mod 3, .Text = "row" & i})
            Next

            Me.grid.ItemsSource = list
        End Sub

        Public Sub GetVisibleRowsOnScreen()
            Me.listBox.Items.Clear()
            Dim scrollViewer = LayoutTreeHelper.GetVisualChildren(Me.view).OfType(Of ScrollViewer)().FirstOrDefault()
            If scrollViewer Is Nothing Then Return
            Dim bottomIndex As Integer = Convert.ToInt32(scrollViewer.ViewportHeight + scrollViewer.VerticalOffset)
            For i As Integer = Me.grid.View.TopRowIndex To bottomIndex - 1
                Dim handle = Me.grid.GetRowHandleByVisibleIndex(i)
                If Not Me.grid.IsValidRowHandle(handle) Then Continue For
                Dim item = TryCast(Me.grid.GetRow(handle), Item)
                If item Is Nothing Then
                    Me.listBox.Items.Add("<null>")
                Else
                    Me.listBox.Items.Add(If(Me.grid.IsGroupRowHandle(handle), "Group: " & item.Text, item.Text))
                End If
            Next
        End Sub

        Private Sub OnButtonClick(ByVal sender As Object, ByVal e As RoutedEventArgs)
            GetVisibleRowsOnScreen()
        End Sub
    End Class

    Public Class Item

        Public Property Number As Integer

        Public Property Text As String
    End Class
End Namespace
