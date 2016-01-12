Public Class Pizza
    Public Property Name As String
    Public Property Description As String
    Public Property Image As Image
    Public Property Price As Double
    Public Property Ingredients As String()
    Public Property Tags As String()

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
    End Sub
End Class
