Public Class Filter

    Dim _color As Color
    Public Property Color As Color
        Set(ByVal value As Color)
            Label1.ForeColor = value
            _color = value
        End Set
        Get
            Return _color
        End Get
    End Property

    Public Property Node As TreeNode
    Sub New(NewNode As TreeNode, NewColor As Color)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()
        Node = NewNode
        Color = NewColor
        SetText(Node.Text)


    End Sub



    Public Sub SetText(NewText As String)
        Text = NewText
        Label1.Text = Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.RemoveFilter(Text)
    End Sub

    Public Sub Destroy()

        Parent = Nothing
        Finalize()
    End Sub
End Class
