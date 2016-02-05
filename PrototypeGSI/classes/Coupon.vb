Public Class Coupon

    Private Description As String
    Private CatchPhrase As String

    Public Sub New(Desc As String, Phrase As String)
        Description = Desc
        CatchPhrase = Phrase
 
    End Sub

    Public Sub SetDescription(Text As String)
        Description = Text
    End Sub

    Public Sub SetCatchPhrase(Text As String)
        CatchPhrase = Text
    End Sub

    Public Function GetDescription()
        Return Description
    End Function

    Public Function GetCatchPhrase()
        Return CatchPhrase
    End Function


End Class
