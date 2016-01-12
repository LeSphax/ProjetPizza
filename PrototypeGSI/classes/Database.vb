Public Class Database
    Public Shared pizzas As New Dictionary(Of Pizza, PizzaPanel)

    Public Shared Sub Init()
        Dim MyPizza As New Pizza("Reine", My.Resources.Reine, 8,
                                      New String() {Pizza.Ham, Pizza.Mozzarella, Pizza.Mushrooms, Pizza.Tomato},
                                      New String() {})
        AddPizza(MyPizza)
        MyPizza = New Pizza("Quatre fromages", My.Resources.Quatre_fromages, 9.5,
                                      New String() {Pizza.Cream, Pizza.Reblochon, Pizza.Mozzarella, Pizza.Roquefort, Pizza.GoatCheese},
                                      New String() {Pizza.Best, Pizza.Vegan, Pizza.Hallal})
        AddPizza(MyPizza)
        MyPizza = New Pizza("Kebab", My.Resources.Kebab, 9,
                                      New String() {Pizza.Kebab, Pizza.Onion, Pizza.Mozzarella, Pizza.WhiteSauce, Pizza.Tomato},
                                      New String() {Pizza.Hallal})
        AddPizza(MyPizza)
        MyPizza = New Pizza("Calzone", My.Resources.Calzone, 10,
                                      New String() {Pizza.Ham, Pizza.Mozzarella, Pizza.Mushrooms, Pizza.Tomato},
                                      New String() {Pizza.Best})
        AddPizza(MyPizza)
        MyPizza = New Pizza("Italienne", My.Resources.Italienne, 10,
                                      New String() {Pizza.Beef, Pizza.Tomato, Pizza.Garlic, Pizza.Mozzarella},
                                      New String() {Pizza.Best, Pizza.Hallal})
        AddPizza(MyPizza)
    End Sub

    Private Shared Sub AddPizza(MyPizza As Pizza)
        pizzas.Add(MyPizza, New PizzaPanel(MyPizza))
    End Sub

End Class
