Public Class Form1

    Dim myFilters As Filters

    Private Sub treeView_DrawNode(sender As Object, e As DrawTreeNodeEventArgs) Handles TreeView1.DrawNode
        e.DrawDefault = True
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        TreeView1.SelectedNode = Nothing
    End Sub

    Private Sub TreeView1_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
        If (e.Node.Parent IsNot Nothing) Then
            If (e.Node.Parent.GetType() Is GetType(TreeNode)) Then
                myFilters.Clicked(e.Node)
            End If
        End If
    End Sub

    ' We want a double click to count as to clicks
    Private Sub TreeView1_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseDoubleClick
        TreeView1_NodeMouseClick(sender, e)
    End Sub

    Public Sub AddFilter(newFilter As Filter)
        FilterPanel.Controls.Add(newFilter)
    End Sub

    Public Sub ShowPizzas(pizzas As List(Of PizzaPanel))
        PizzaLayoutPanel.Controls.Clear()

        For Each Pizza As PizzaPanel In pizzas
            PizzaLayoutPanel.Controls.Add(Pizza)
        Next

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        myFilters = New Filters(Me)
    End Sub
End Class
