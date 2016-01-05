Public Class PizzaPanel

    Public Sub New(Pizza As Pizza)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        PictureBox1.Image = Pizza.Image
        Label1.Text = Pizza.Name

    End Sub
End Class
