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
        Init_Dialog()
    End Sub

    Private Sub Init_Dialog()
        myState = State.GRID
        CreatePizzaDisplay_Dialog()
        myFilters = New Filters(Me)
        reduc = 0
        Coupon1.AddCoupon(New Coupon("Pour trois pizzas achetées 5€ offert", "Plus qu'une pizza pour avoir la réduction"))
    End Sub

    'Taking_Off the automatic blue highlighting
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

    ' We want a double click to count as two clicks
    Private Sub TreeView1_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseDoubleClick
        TreeView1_NodeMouseClick(sender, e)
    End Sub

    Public Sub AddFilter_Presentation(newFilter As Filter)
        FilterPanel.Controls.Add(newFilter)
    End Sub

    Public Sub RefreshPizzas_Presentation(newPizzasToShow As List(Of Pizza))
        pizzasToShow = newPizzasToShow
        RefreshView_Dialog()
    End Sub

    Private Sub RefreshView_Dialog()
        EmptyPizzaContainer_Presentation()

        For Each Pizza As Pizza In pizzasToShow
            Select Case myState
                Case State.LIST
                    AddPizzaToList_Presentation(Pizza)

                Case State.GRID
                    AddPizzaToGrid_Presentation(Pizza)
            End Select

        Next
    End Sub

    Private Sub AddPizzaToGrid_Presentation(Pizza As Pizza)
        PizzaLayoutPanel.Controls.Add(New PizzaGridView(Pizza))
    End Sub

    Private Sub AddPizzaToList_Presentation(Pizza As Pizza)
        Dim pizzal As PizzaListView = New PizzaListView(Pizza)
        pizzal.Dock = DockStyle.Fill
        PizzaLayoutPanel.Controls.Add(pizzal)
    End Sub

    Private Sub EmptyPizzaContainer_Presentation()
        PizzaLayoutPanel.Controls.Clear()
    End Sub

    Public Sub AddToCartNewPizza_Dialog(pizza As Pizza)
        AddToCartNewPizza_Presentation(pizza)
        UpdateTotal_Dialog()

    End Sub

    Private Sub AddToCartNewPizza_Presentation(pizza As Pizza)
        CartLayoutPanel.Controls.Add(New CartElem(pizza))
    End Sub

    Public Sub UpdateCart_Dialog(pizza As Pizza)
        'Update the panel
        For Each elem In CartLayoutPanel.Controls
            Dim e As CartElem = DirectCast(elem, CartElem)
            If e.ContainsPizza_Dialog(pizza) Then
                e.UpdatePizzaView_Presentation(pizza)
            End If
        Next
        UpdateTotal_Dialog()

    End Sub

    Private Sub viderBtn_Click(sender As Object, e As EventArgs) Handles viderBtn.Click
        EmptyButtonClicked_Dialog()
    End Sub

    Private Sub EmptyButtonClicked_Dialog()
        For Each control In CartLayoutPanel.Controls
            Dim elem As CartElem = DirectCast(control, CartElem)
            elem.GetPizza().Delete()
        Next

        EmptyCart_Presentation()
        SetReduc_Dialog(0)
        UpdateTotal_Dialog()
        Coupon1.UpdateCouponEmptyCart_Dialog()
    End Sub

    Private Sub EmptyCart_Presentation()
        CartLayoutPanel.Controls.Clear()
    End Sub

    Private Sub validerBtn_Click(sender As Object, e As EventArgs) Handles validerBtn.Click
        ConfirmationButtonClicked_Dialog()
    End Sub

    Private Shared Sub ConfirmationButtonClicked_Dialog()
        DisplayNotImplementedMessage_Presentation()
    End Sub

    Private Shared Sub DisplayNotImplementedMessage_Presentation()
        MessageBox.Show("Cette partie n'a pas été implémentée", "Désolé", MessageBoxButtons.OK)
    End Sub

    Public Sub UpdateTotal_Dialog()
        Dim total As Double = 0
        For Each control In CartLayoutPanel.Controls
            Dim elem As CartElem = DirectCast(control, CartElem)
            total += elem.GetPizza().Price * elem.GetPizza().Number
        Next
        UpdateLabelTotal_Presentation(total - reduc)

    End Sub

    Public Sub IncrementReducBy_Dialog(Nb As Double)
        reduc += Nb
        UpdateLabelReduc_Presentation(reduc)
    End Sub

    Public Sub SetReduc_Dialog(Nb As Double)
        reduc = Nb
        UpdateLabelReduc_Presentation(reduc)
    End Sub

    Private Sub GridButton_CLick(sender As Object, e As EventArgs) Handles GridButton.Click
        GridButtonClicked_Dialog()
    End Sub

    Private Sub GridButtonClicked_Dialog()
        myState = State.GRID
        CreatePizzaDisplay_Dialog()
        RefreshView_Dialog()
    End Sub

    Private Sub ListButton_Click(sender As Object, e As EventArgs) Handles ListButton.Click
        ListButtonClicked_Dialog()
    End Sub

    Private Sub ListButtonClicked_Dialog()
        myState = State.LIST
        CreatePizzaDisplay_Dialog()
        RefreshView_Dialog()
    End Sub

    Private Sub CreatePizzaDisplay_Dialog()
        DeleteCurrentPizzaLayoutPanel_Presentation()

        Select Case myState
            Case State.GRID
                CreateGrid_Presentation()
            Case State.LIST
                CreateList_Presentation()
        End Select

        SetPizzaLayoutPanelProperties_Presentation()

    End Sub

    Private Sub SetPizzaLayoutPanelProperties_Presentation()
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

    Private Sub DeleteCurrentPizzaLayoutPanel_Presentation()
        Panel6.Controls.Remove(PizzaLayoutPanel)
    End Sub

    Private Sub CreateGrid_Presentation()
        PizzaLayoutPanel = New FlowLayoutPanel
    End Sub

    Private Sub CreateList_Presentation()
        Dim temp As TableLayoutPanel = New TableLayoutPanel
        temp.ColumnCount = 1
        PizzaLayoutPanel = temp
    End Sub

    Private Sub UpdateLabelReduc_Presentation(Reduc As Double)
        LabelReduc.Text = Reduc
    End Sub

    Private Sub UpdateLabelTotal_Presentation(Total As Double)
        LabelTotal.Text = Total
    End Sub
End Class
