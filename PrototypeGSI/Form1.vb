Public Class Form1

    Shared filters As New Dictionary(Of String, Filter)

    Private Sub treeView_DrawNode(sender As Object, e As DrawTreeNodeEventArgs) Handles TreeView1.DrawNode
        e.DrawDefault = True
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        TreeView1.SelectedNode = Nothing
    End Sub

    Private Sub TreeView1_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
        If (e.Node.Parent IsNot Nothing) Then
            If (e.Node.Parent.GetType() Is GetType(TreeNode)) Then
                Dim filter As Filter
                filter = Nothing
                If (filters.TryGetValue(e.Node.Text, filter)) Then
                    If (filter.Color = Color.Green) Then
                        filter.Color = Color.Red

                        e.Node.ForeColor = Color.Red

                    ElseIf (filter.Color = Color.Red) Then
                        RemoveFilter(e.Node.Text)
                    End If
                Else
                    filter = New Filter(e.Node, Color.Green)
                    FilterPanel.Controls.Add(filter)
                    filters.Add(e.Node.Text, filter)
                    e.Node.ForeColor = Color.Green
                    End If
                End If
            End If
    End Sub

    ' We want a double click to count as to clicks
    Private Sub TreeView1_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseDoubleClick
        TreeView1_NodeMouseClick(sender, e)
    End Sub

    Public Shared Sub RemoveFilter(name As String)
        Dim filter As Filter
        filter = Nothing
        If filters.TryGetValue(name, filter) Then
            filter.Node.ForeColor = Color.Black
            filter.Destroy()
            filters.Remove(name)
        End If

    End Sub

    Private Sub ShowPizzas()
        Debug.Print("Pizzas?")
        For Each Pizza As Pizza In Database.pizzas.Values
            PizzaLayoutPanel.Controls.Add(New PizzaPanel(Pizza))
            Debug.Print(Pizza.Name)
        Next

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Database.Init()
        Debug.Print("Pizzas?")
        ShowPizzas()
    End Sub
End Class
