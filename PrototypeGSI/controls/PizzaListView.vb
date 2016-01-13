﻿Public Class PizzaListView

    Dim _pizza As Pizza
    Public Sub New(Pizza As Pizza)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()
        Label1.Text = Pizza.Name
        Label2.Text = Pizza.IngredientsToString()
        _pizza = Pizza

    End Sub

    Private Sub addToCart_Click(sender As Object, e As EventArgs) Handles addToCart.Click
        Select Case _pizza.InOrOut()
            Case True

                Form1.CartPanelForm.Refresh()
                Form1.AddToCart(_pizza)
                '  Form1.AddToCart(Me)

            Case False
                Form1.AddToCartNewPizza(_pizza)

        End Select


    End Sub
End Class
