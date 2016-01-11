Public Class Pizza
    Public Property Name As String
    Public Property Description As String
    Public Property Image As Image
    Public Property Price As Double
    Public Property Number As Integer
    Dim _state As State
    Enum State
        INCART
        OUTCART
    End Enum

    Public Property Ingredients As List(Of String)

    Sub New(NewName As String, NewDescription As String, NewImage As Image, NewPrice As Double)
        Name = NewName
        Description = NewDescription
        Image = NewImage
        Price = NewPrice
        Number = 0
        _state = State.OUTCART
    End Sub

    Public Function InOrOut()
        Select Case _state
            Case State.INCART
                Number += 1
                Return True
             
            Case State.OUTCART
                Number = 1
                _state = State.INCART
                Return False
        End Select
        Return False
    End Function

    Public Sub Delete()
        _state = State.OUTCART
    End Sub
End Class
