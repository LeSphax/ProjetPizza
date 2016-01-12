Public Class Filter

    Dim colorDesactivated As Color = Color.Black
    Dim colorPositive As Color = Color.Green
    Dim colorNegative As Color = Color.Red

    Enum State
        Positive
        Negative
    End Enum

    Public Property MyState As State
    Dim MyFilters As Filters
    Public Property Node As TreeNode

    Sub New(filters As Filters, NewNode As TreeNode)
        InitializeComponent()
        MyFilters = filters
        Node = NewNode
        Label1.Text = Node.Text
        SetPositive()

    End Sub

    Sub SetPositive()
        MyState = State.Positive
        Label1.ForeColor = colorPositive
        Node.ForeColor = colorPositive
    End Sub

    Sub SetNegative()
        MyState = State.Negative
        Label1.ForeColor = colorNegative
        Node.ForeColor = colorNegative
    End Sub

    Sub SetDesactivated()
        Node.ForeColor = colorDesactivated
        myFilters.RemoveFilter(Node)
    End Sub


    Public Sub Clicked()
        Select Case MyState
            Case State.Positive
                SetNegative()
            Case State.Negative
                SetDesactivated()
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SetDesactivated()
    End Sub

    Public Sub Destroy()

        Parent = Nothing
        Finalize()
    End Sub
End Class
