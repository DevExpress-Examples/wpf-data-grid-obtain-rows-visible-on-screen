' Developer Express Code Central Example:
' How to get visible rows on the screen
' 
' You should get a DataPresenter. This dependency object supports the IScrollInfo
' interface. This interface provides the VerticalOffset and ViewportHeight
' properties. In fact, the VerticalOffset property is a VisibleIndex for the first
' row, but the ViewprotHeight is a number of visible rows. Use the
' GridControl.GetRowHandleByVisibleIndex method to get the first visible and last
' visible row handles. If the last row handle is not valid, it means that you try
' to parse empty space, and the last row handle on the screen is the last row
' within row handles.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E3138

Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.Windows.Controls.Primitives
Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.Core.Native

Namespace Sample
    ''' <summary>
    ''' Interaction logic for Window1.xaml
    ''' </summary>
    Partial Public Class Window1
        Inherits Window

        Private list As List(Of TestData)
        Public Sub New()
            InitializeComponent()
            list = New List(Of TestData)()
            list.Add(New TestData() With { _
                .Number = 1, _
                .Text = "row1" _
            })
            list.Add(New TestData() With { _
                .Number = 2, _
                .Text = "row2" _
            })
            list.Add(New TestData() With { _
                .Number = 3, _
                .Text = "row3" _
            })
            list.Add(New TestData() With { _
                .Number = 1, _
                .Text = "row4" _
            })
            list.Add(New TestData() With { _
                .Number = 2, _
                .Text = "row5" _
            })
            list.Add(New TestData() With { _
                .Number = 3, _
                .Text = "row6" _
            })
            list.Add(New TestData() With { _
                .Number = 1, _
                .Text = "row7" _
            })
            list.Add(New TestData() With { _
                .Number = 2, _
                .Text = "row8" _
            })
            list.Add(New TestData() With { _
                .Number = 3, _
                .Text = "row9" _
            })
            list.Add(New TestData() With { _
                .Number = 1, _
                .Text = "row10" _
            })
            list.Add(New TestData() With { _
                .Number = 2, _
                .Text = "row11" _
            })
            list.Add(New TestData() With { _
                .Number = 3, _
                .Text = "row12" _
            })
            grid.ItemsSource = list
        End Sub

        Private Function GetScrollInfo() As IScrollInfo
            For Each item As DependencyObject In New VisualTreeEnumerable(view)
                If TypeOf item Is DataPresenter Then
                    Return CType(item, DataPresenter)
                End If
            Next item
            Throw New InvalidOperationException()
        End Function

        Public Sub GetVisibleRowsOnScreen()
            Dim RowHandle1 As Integer = grid.GetRowHandleByListIndex((TryCast(Me.grid.View, TableView)).TopRowIndex)
            Dim RowHandle2 As Integer = grid.GetRowHandleByVisibleIndex(Convert.ToInt32(GetScrollInfo().ViewportHeight + GetScrollInfo().VerticalOffset))

            Dim td As TestData
            listBox.Items.Clear()
            If grid.IsValidRowHandle(RowHandle2) Then
                For i As Integer = RowHandle1 To RowHandle2
                    td = TryCast(grid.GetRow(i), TestData)
                    listBox.Items.Add(td.Text)
                Next i
            Else
                For i As Integer = RowHandle1 To grid.VisibleRowCount - 1
                    td = TryCast(grid.GetRow(i), TestData)
                    listBox.Items.Add(td.Text)
                Next i
            End If
        End Sub

        Private Sub view_ScrollChanged(ByVal sender As Object, ByVal e As ScrollChangedEventArgs)
            'GetVisibleRowsOnScreen
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)

            Me.GetVisibleRowsOnScreen()
        End Sub
    End Class
    Public Class TestData
        Public Property Number() As Integer
        Public Property Text() As String
    End Class
End Namespace