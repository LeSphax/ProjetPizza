Public Class Form1

    Dim myFilters As Filters

    Enum State
        LIST
        GRID
    End Enum

    Dim myState As State
    Dim pizzasToShow As List(Of Pizza)
    Friend WithEvents PizzaLayoutPanel As Panel
    Dim reduc As Double


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        CreatePizzaLayoutPanel()
        myFilters = New Filters(Me)
        myState = State.GRID
        reduc = 0
        Coupon1.AddCoupon(New Coupon("Pour trois pizzas achetées 5€ offert", "Plus qu'une pizza pour avoir la réduction"))
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
                myFilters.TreeClicked_Dialog(e.Node)
            End If
        End If
    End Sub

    ' We want a double click to count as to clicks
    Private Sub TreeView1_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseDoubleClick
        TreeView1_NodeMouseClick(sender, e)
    End Sub

    Public Sub AddFilter_Presentation(newFilter As Filter)
        FilterPanel.Controls.Add(newFilter)
    End Sub

    Public Sub RefreshPizzas_Presentation(newPizzasToShow As List(Of Pizza))
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
        UpdateTotal()

    End Sub

    Public Sub UpdateCart(pizza As Pizza)
        'Update the panel
        For Each elem In CartLayoutPanel.Controls
            Dim e As CartElem = DirectCast(elem, CartElem)
            If e.ContainsPizza(pizza) Then
                e.UpdatePizzaView(pizza)
            End If
        Next

        UpdateTotal()

    End Sub

    Private Sub viderBtn_Click(sender As Object, e As EventArgs) Handles viderBtn.Click
        For Each control In CartLayoutPanel.Controls
            Dim elem As CartElem = DirectCast(control, CartElem)
            elem.GetPizza().Delete()
        Next
        CartLayoutPanel.Controls.Clear()
        ResetReduc(0)
        UpdateTotal()
        Coupon1.UpdateCouponEmptyCart()
    End Sub

    Private Sub validerBtn_Click(sender As Object, e As EventArgs) Handles validerBtn.Click
        'Not implemented yet
    End Sub

    Public Sub UpdateTotal()
        Dim total As Double = 0
        For Each control In CartLayoutPanel.Controls
            Dim elem As CartElem = DirectCast(control, CartElem)
            total += elem.GetPizza().Price * elem.GetPizza().Number
        Next
        UpdateLabelTotal(total - reduc)

    End Sub

    Public Sub ResetTotal()
        LabelTotal.Text = 0.0
    End Sub

    Public Sub SetReduc(Nb As Double)
        reduc += Nb
        UpdateLabelReduc(reduc)
    End Sub
    Public Sub ResetReduc(Nb As Double)
        reduc = Nb
        UpdateLabelReduc(reduc)
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

    Private Sub UpdateLabelReduc(Reduc As Double)
        LabelReduc.Text = Reduc
    End Sub

    Private Sub UpdateLabelTotal(Total As Double)
        LabelTotal.Text = Total
    End Sub
End Class
