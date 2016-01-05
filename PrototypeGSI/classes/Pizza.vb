Public Class Pizza
    Public Property Name As String
    Public Property Description As String
    Public Property Image As Image
    Public Property Price As Double
    Public Property Ingredients As List(Of String)

    Sub New(NewName As String, NewDescription As String, NewImage As Image, NewPrice As Double)
        Name = NewName
        Description = NewDescription
        Image = NewImage
        Price = NewPrice
    End Sub
End Class
