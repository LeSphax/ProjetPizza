Public Class Database
    Public Shared pizzas As New Dictionary(Of String, Pizza)

    Public Shared Sub Init()
        pizzas.Add("Reine", New Pizza("Reine", "Jambon, Mozzarella, Champignons", My.Resources.Reine, 10))
        pizzas.Add("Quatre fromages", New Pizza("Quatre fromages", "Jambon, Fromage, Champignons", My.Resources.Quatre_fromages, 10))
        pizzas.Add("Kebab", New Pizza("Kebab", "Jambon, Fromage, Champignons", My.Resources.Kebab, 10))
        pizzas.Add("Calzone", New Pizza("Calzone", "Jambon, Fromage, Champignons", My.Resources.Calzone, 10))
        pizzas.Add("Italienne", New Pizza("Italienne", "Jambon, Fromage, Champignons", My.Resources.Italienne, 10))
    End Sub

End Class
