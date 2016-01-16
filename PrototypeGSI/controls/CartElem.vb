Public Class CartElem
    Dim _pizza As Pizza


    Public Sub New(Pizza As Pizza)
        ' Cet appel est requis par le concepteur.
        InitializeComponent()
        _pizza = Pizza
        UpdatePizza(_pizza)
    End Sub

    Public Sub UpdatePizza(Pizza As Pizza)
        pizzaNameLabel.Text = Pizza.Name
        pizzaPriceLabel.Text = Pizza.Price * Pizza.Number
        pizzaQte.Text = Pizza.Number
    End Sub

    Public Function GetPizza() As Pizza
        Return _pizza
    End Function

    Public Function ContainsPizza(Pizza As Pizza) As Boolean
        Return _pizza.Equals(Pizza)
    End Function


    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        _pizza.Delete()
        Parent = Nothing
        Finalize()
    End Sub

    Private Sub pizzaQte_ValueChanged(sender As Object, e As EventArgs) Handles pizzaQte.ValueChanged
        If _pizza IsNot Nothing Then
            Form1.UpdateTotal(-_pizza.Price * _pizza.Number)
            _pizza.Number = pizzaQte.Value
            UpdatePizza(_pizza)
            Form1.UpdateTotal(_pizza.Price * _pizza.Number)

        End If
    End Sub

End Class
