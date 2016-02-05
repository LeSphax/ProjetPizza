Public Class CartElem
    Dim _pizza As Pizza
    Dim initialValue As Decimal = 0

    Public Sub New(Pizza As Pizza)
        ' Cet appel est requis par le concepteur.
        InitializeComponent()
        _pizza = Pizza
        UpdatePizzaView(_pizza)
    End Sub

    Public Sub UpdatePizzaView(Pizza As Pizza)
        pizzaNameLabel.Text = Pizza.Name
        LabelPizzaPrice.Text = Pizza.Price * Pizza.Number
        PizzaQte.Text = Pizza.Number
    End Sub

    Public Function GetPizza() As Pizza
        Return _pizza
    End Function

    Public Function ContainsPizza(Pizza As Pizza) As Boolean
        Return _pizza.Equals(Pizza)
    End Function


    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Form1.Coupon1.UpdateCouponDeletePizzas(_pizza)
        _pizza.Delete()
        Parent = Nothing
        Form1.UpdateTotal()
        Finalize()
    End Sub


    Private Sub pizzaQte_ValueChanged(sender As Object, e As EventArgs) Handles PizzaQte.ValueChanged
        If PizzaQte.Value < initialValue Then
            'down was pressed
            Form1.Coupon1.UpdateCouponDeleteOnePizza()
        ElseIf PizzaQte.Value > initialValue Then
            'Up was pressed
            Form1.Coupon1.UpdateCouponAdd(_pizza)
        End If
        initialValue = PizzaQte.Value
        _pizza.Number = PizzaQte.Value
        UpdatePizzaView(_pizza)
        Form1.UpdateTotal()

    End Sub

End Class
