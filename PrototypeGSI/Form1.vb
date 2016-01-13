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
                myFilters.TreeClicked(e.Node)
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

    Public Sub ShowPizzas(pizzas As List(Of PizzaGridView))
        PizzaLayoutPanel.Controls.Clear()

        For Each Pizza As PizzaGridView In pizzas
            PizzaLayoutPanel.Controls.Add(Pizza)
        Next
    End Sub

    Public Sub AddToCartNewPizza(pizza As Pizza)
        Dim elem As CartElem = New CartElem(pizza)
        CartLayoutPanel.Controls.Add(elem)
        sumLabel.Text += pizza.Price
    End Sub

    Public Sub AddToCart(pizza As Pizza)
        sumLabel.Text += pizza.Price
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        myFilters = New Filters(Me)
    End Sub


    Private Sub viderBtn_Click(sender As Object, e As EventArgs) Handles viderBtn.Click
        CartLayoutPanel.Controls.Clear()
        sumLabel.Text = 0.0

    End Sub

    Private Sub validerBtn_Click(sender As Object, e As EventArgs) Handles validerBtn.Click
        CartLayoutPanel.Controls.Clear()
        sumLabel.Text = 0.0
    End Sub
End Class
