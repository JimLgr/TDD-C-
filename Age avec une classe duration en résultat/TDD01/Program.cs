using TDD01;
using Time;
try
{
    DateTime birthDate = new DateTime(1998, 10, 16);
    DateTime endDate = new DateTime(2000, 01, 01);
    Duration age = ClsAge.GetAge(birthDate , endDate);
    Console.WriteLine($"Né le {birthDate}");
    Console.WriteLine($"La personne a {age.NombreYears} ans, {age.NombreMonths} mois et {age.NombreDays} jours.");
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
