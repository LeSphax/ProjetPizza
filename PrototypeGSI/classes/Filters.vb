Public Class Filters

    Dim myForm As Form1

    Shared activeFilters As New Dictionary(Of TreeNode, Filter)

    Sub New(form As Form1)
        myForm = form
        CreateDatabase_Core()
        RefreshPizzas_Dialog()
    End Sub

    Private Shared Sub CreateDatabase_Core()
        Database.Init()
    End Sub

    Public Sub RemoveFilter_Dialog(node As TreeNode)
        Dim filter As Filter
        filter = Nothing
        If (activeFilters.TryGetValue(node, filter)) Then
            filter.Destroy_Presentation()
            activeFilters.Remove(node)
        End If
        RefreshPizzas_Dialog()
    End Sub

    Private Sub AddFilter_Dialog(node As TreeNode)
        Dim filter As New Filter(Me, node)
        activeFilters.Add(node, filter)
        myForm.AddFilter_Presentation(filter)
    End Sub

    Public Sub TreeClicked_Dialog(node As TreeNode)
        Dim filter As Filter
        filter = Nothing
        If activeFilters.TryGetValue(node, filter) Then
            filter.TreeClicked_Dialog()
        Else
            AddFilter_Dialog(node)
        End If
        RefreshPizzas_Dialog()
    End Sub

    Public Sub FilterClicked_Dialog(filter As Filter)
        filter.FilterClicked_Dialog()
        RefreshPizzas_Dialog()
    End Sub

    Private Sub RefreshPizzas_Dialog()
        Form1.RefreshPizzas_Presentation(FilterPizzas_Core)
    End Sub

    Private Function FilterPizzas_Core() As List(Of Pizza)
        Dim list As New List(Of Pizza)
        Dim pizzaPanel As Pizza = Nothing

        For Each Pizza As Pizza In Database.pizzas
            If (FilterPizza_Core(Pizza) = True) Then
                list.Add(Pizza)
            End If
        Next
        Return list
    End Function

    Private Function FilterPizza_Core(Pizza As Pizza) As Boolean
        For Each filter In activeFilters.Values
            If (filter.MyState = Filter.State.Positive) Then
                If (-1 = Array.IndexOf(Pizza.Ingredients, filter.Node.Text)) Then
                    If (-1 = Array.IndexOf(Pizza.Tags, filter.Node.Text)) Then
                        Return False
                    End If
                End If
            Else
                If (-1 <> Array.IndexOf(Pizza.Ingredients, filter.Node.Text) Or
                    -1 <> Array.IndexOf(Pizza.Tags, filter.Node.Text)) Then
                    Return False
                End If
            End If
        Next
        Return True
    End Function

End Class