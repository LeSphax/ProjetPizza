Public Class Pizza
    Public Property Name As String
    Public Property Description As String
    Public Property Image As Image
    Public Property Price As Double
    Public Property Ingredients As String()
    Public Property Tags As String()
    Public Property Number As Integer

    Dim _state As State
    Enum State
        INCART
        OUTCART
    End Enum

    Public Shared Best As String = "Les Meilleures"
    Public Shared Hallal As String = "Hallal"
    Public Shared Vegan As String = "Végétariennes"

    Public Shared WhiteSauce As String = "Sauce Blanche"
    Public Shared Tomato As String = "Tomate"
    Public Shared Cream As String = "Crème Fraiche"
    Public Shared Harissa As String = "Harissa"

    Public Shared Ham As String = "Jambon"
    Public Shared Kebab As String = "Kebab"
    Public Shared Beef As String = "Boeuf"

    Public Shared Mozzarella As String = "Mozzarella"
    Public Shared GoatCheese As String = "Chèvre"
    Public Shared Roquefort As String = "Roquefort"
    Public Shared Reblochon As String = "Reblochon"

    Public Shared Mushrooms As String = "Champignons"
    Public Shared Onion As String = "Oignons"
    Public Shared Garlic As String = "Ail"


    Sub New(NewName As String, NewImage As Image, NewPrice As Double, NewIngredients As IList(Of String), NewTags As String())
        Name = NewName
        Image = NewImage
        Price = NewPrice
        Ingredients = NewIngredients
        Tags = NewTags
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

    Public Function IngredientsToString() As String
        Dim result As String = ""
        For Each Ingredient As String In Ingredients
            result += Ingredient + ", "
        Next
        result = result.Substring(0, result.Length - 2)
        Return result
    End Function
End Class
