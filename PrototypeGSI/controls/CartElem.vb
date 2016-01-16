Public Class CartElem
    Dim _pizza As Pizza


    Public Sub New(Pizza As Pizza)
        ' Cet appel est requis par le concepteur.
        InitializeComponent()
        pizzaNameLabel.Text = Pizza.Name
        pizzaPriceLabel.Text = Pizza.Price * Pizza.Number
        NumericUpDown1.Text = Pizza.Number
        _pizza = Pizza
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

    Private Sub pizzaQte_ValueChanged(sender As Object, e As EventArgs)
        '    _pizza.Number = 
    End Sub
End Class
