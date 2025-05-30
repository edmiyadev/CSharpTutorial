using System.Globalization;

partial class Program
{
    static void ConvertionToDateTime()
    {
        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("es-DO");

        int friends = int.Parse("101");
        double cost = 250.50;
        DateTime birthday = DateTime.Parse("2 Marzo 2025");
        WriteLine($"Tengo {friends} amigos para invitar a mi fiesta");
        WriteLine($"La celebracion de mi cumpleaños sera {birthday}");
        WriteLine($"Formato largo : {birthday:D}");
        WriteLine($"El consto de la entrada sera: {cost:C}");
    }
}