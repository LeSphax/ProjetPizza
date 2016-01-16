Public Class Form1

    Dim myFilters As Filters

    Enum State
        LIST
        GRID
    End Enum

    Dim myState As State
    Dim pizzasToShow As List(Of Pizza)
    Friend WithEvents PizzaLayoutPanel As Panel

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        CreatePizzaLayoutPanel()
        myFilters = New Filters(Me)
        myState = State.GRID
    End Sub

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

    Public Sub RefreshPizzas(newPizzasToShow As List(Of Pizza))
        pizzasToShow = newPizzasToShow
        RefreshView()
    End Sub

    Private Sub RefreshView()
        PizzaLayoutPanel.Controls.Clear()

        For Each Pizza As Pizza In pizzasToShow
            Select Case myState
                Case State.LIST
                    Dim pizzal As PizzaListView = New PizzaListView(Pizza)
                    pizzal.Dock = DockStyle.Fill

                    PizzaLayoutPanel.Controls.Add(pizzal)

                Case State.GRID
                    PizzaLayoutPanel.Controls.Add(New PizzaGridView(Pizza))
            End Select

        Next
    End Sub

    Public Sub AddToCartNewPizza(pizza As Pizza)
        CartLayoutPanel.Controls.Add(New CartElem(pizza))
        sumLabel.Text += pizza.Price
    End Sub

    Public Sub AddToCart(pizza As Pizza)
        sumLabel.Text += pizza.Price
        Dim index As Integer = 0
        Dim newCartElem As CartElem
        For Each elem In CartLayoutPanel.Controls
            Dim e As CartElem = DirectCast(elem, CartElem)
            If e.ContainsPizza(pizza) Then
                index = CartLayoutPanel.Controls.GetChildIndex(e)
                CartLayoutPanel.Controls.Remove(e)
                newCartElem = New CartElem(pizza)
                CartLayoutPanel.Controls.Add(newCartElem)
                CartLayoutPanel.Controls.SetChildIndex(newCartElem, index)

            End If

        Next


    End Sub

    Private Sub viderBtn_Click(sender As Object, e As EventArgs) Handles viderBtn.Click
        For Each control In CartLayoutPanel.Controls
            Dim elem As CartElem = DirectCast(control, CartElem)
            elem.GetPizza().Delete()
        Next
        CartLayoutPanel.Controls.Clear()
        sumLabel.Text = 0.0

    End Sub

    Private Sub validerBtn_Click(sender As Object, e As EventArgs) Handles validerBtn.Click
        CartLayoutPanel.Controls.Clear()
        sumLabel.Text = 0.0

    End Sub

    Private Sub GridButton_CLick(sender As Object, e As EventArgs) Handles GridButton.Click
        myState = State.GRID
        CreatePizzaLayoutPanel()
        RefreshView()
    End Sub

    Private Sub ListButton_Click(sender As Object, e As EventArgs) Handles ListButton.Click
        myState = State.LIST
        CreatePizzaLayoutPanel()
        RefreshView()
    End Sub

    Private Sub CreatePizzaLayoutPanel()
        Panel6.Controls.Remove(PizzaLayoutPanel)

        Select Case myState
            Case State.GRID
                PizzaLayoutPanel = New FlowLayoutPanel
            Case State.LIST
                Dim temp As TableLayoutPanel = New TableLayoutPanel
                temp.ColumnCount = 1
                PizzaLayoutPanel = temp
        End Select
        Panel6.Controls.Add(PizzaLayoutPanel)
        Panel6.Controls.SetChildIndex(PizzaLayoutPanel, 0)
        PizzaLayoutPanel.AutoScroll = True
        PizzaLayoutPanel.AutoSize = False
        PizzaLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        PizzaLayoutPanel.Location = New System.Drawing.Point(0, 100)
        PizzaLayoutPanel.Name = "PizzaLayoutPanel"
        Me.PizzaLayoutPanel.Size = New System.Drawing.Size(837, 606)
        Refresh()
    End Sub

End Class
