using Time;
try
{
    DateTime birthDate = new DateTime(1998, 10, 16);
    DateTime endDate = new DateTime(2000, 01, 01);
    int[] age = ClsAge.GetAge(birthDate , endDate);
    Console.WriteLine($"Né le {birthDate}");
    Console.WriteLine($"La personne a {age[0]} ans, {age[1]} mois et {age[2]} jours.");
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
catch(Exception ex)
{
    Console.WriteLine("Erreur inconnue appelez le helpDesk");
    Console.WriteLine(ex.GetType());
}
