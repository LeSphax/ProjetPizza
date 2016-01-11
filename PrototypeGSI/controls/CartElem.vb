Public Class CartElem
    Dim _pizza As Pizza


    Public Sub New(Pizza As Pizza)
        ' Cet appel est requis par le concepteur.
        InitializeComponent()
        pizzaNameLabel.Text = Pizza.Name
        pizzaPriceLabel.Text = Pizza.Price
        pizzaQteLabel.Text = Pizza.Number
        _pizza = Pizza
    End Sub

  
    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        _pizza.Delete()
        Parent = Nothing
        Finalize()
    End Sub
End Class
