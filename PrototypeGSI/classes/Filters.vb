Public Class Filters

    Dim myForm As Form1
    Shared instance As Filters

    Shared Dictionary As New Dictionary(Of TreeNode, Filter)

    Sub New(form As Form1)
        myForm = form
        Database.Init()
        RefreshPizzas()
    End Sub

    Public Sub RemoveFilter(node As TreeNode)
        Dim filter As Filter
        filter = Nothing
        If Dictionary.TryGetValue(node, filter) Then
            filter.Destroy()
            Dictionary.Remove(node)
        End If
        RefreshPizzas()
    End Sub

    Private Sub AddFilter(node As TreeNode)
        Dim filter As New Filter(Me, node)
        Dictionary.Add(node, filter)
        myForm.AddFilter(filter)
    End Sub

    Public Sub TreeClicked(node As TreeNode)
        Dim filter As Filter
        filter = Nothing
        If Dictionary.TryGetValue(node, filter) Then
            filter.TreeClicked()
        Else
            AddFilter(node)
        End If
        RefreshPizzas()
    End Sub

    Public Sub FilterClicked(filter As Filter)
        filter.FilterClicked()
        RefreshPizzas()
    End Sub

    Private Sub RefreshPizzas()
        Form1.ShowPizzas(FilterPizzas)
    End Sub

    Private Function FilterPizzas() As List(Of PizzaGridView)
        Dim list As New List(Of PizzaGridView)
        Dim pizzaPanel As PizzaGridView = Nothing

        For Each Pizza As Pizza In Database.pizzas.Keys
            If (FilterPizza(Pizza) = True) Then
                If (Database.pizzas.TryGetValue(Pizza, pizzaPanel)) Then
                    list.Add(pizzaPanel)
                Else
                    Debug.Fail("There is no panel associated to this pizza")
                End If

            End If
        Next
        Return list
    End Function

    Private Function FilterPizza(Pizza As Pizza) As Boolean
        For Each filter In Dictionary.Values
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