Public Class Database
    Shared pizzas As New Dictionary(Of String, Pizza)

    Public Shared Sub Init()
        pizzas.Add("Reine", New Pizza("Reine", "Jambon, Fromage, Champignons", Image.FromFile("Reine.jpg"), 10))
    End Sub


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

End Class
