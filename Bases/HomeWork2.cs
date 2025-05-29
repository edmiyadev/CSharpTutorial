using System.Globalization;

partial class Program
{
    static void DaysOfLife()
    {
        DateTime birthDate = new DateTime(1998, 5, 14);
        TimeSpan difference = DateTime.Now - birthDate;
        Console.WriteLine($"Has vivido {difference.Days}");
    }


    // 🏆 Ejercicio:
    // Pedir al usuario su fecha de nacimiento y calcular cuántos días faltan para su próximo cumpleaños.
    // Consideraciones:
    // - La fecha de nacimiento ingresada debe ser interpretada correctamente, 
    //   asegurando que las comparaciones de fechas no sean afectadas por las horas.
    // - Investigar acerca de `CultureInfo.InvariantCulture` para que no afecte la configuración regional del sistema.
    // - Se debe manejar el caso en que el cumpleaños ya haya pasado en el año actual, 
    //   sumando un año para calcular la fecha del próximo (opcional).
    static void DaysUnitNextBirthday()
    {
        DateTime currentDate = DateTime.Now.Date;
        DateTime birthdayDate;
        DateTime nextBirthdayDate;
        TimeSpan missingDays;

        Console.WriteLine("Introduce tu fecha de naciimiento (dd/mm/aaaa):");
        birthdayDate = DateTime.ParseExact(Console.ReadLine()!, "dd/MM/yyyy", CultureInfo.InvariantCulture); // ParseExact es un metodo que permite tomas la fecha con formato exacto
                                                                                                             // CultureInfo.InvariantCulture ignora la configuracion regional y toma el formato que se le otorga
        nextBirthdayDate = new DateTime(currentDate.Year, birthdayDate.Month, birthdayDate.Day);


        if (nextBirthdayDate < currentDate)
        {
            missingDays = nextBirthdayDate - currentDate.AddYears(1);
        }
        else
        {
            missingDays = nextBirthdayDate - currentDate;
        }

        Console.WriteLine($"Faltan {missingDays.Days} dias para tu proximo cumpleaños");
    }
}