partial class Program
{
    static void StringTypes()
    {
        string name = "Edward Minaya";
        string message = "Hola " + name; // concatenar
        string interpolatedMessage = $"Hola {name}"; // interpolar

        Console.WriteLine(message);
        Console.WriteLine(interpolatedMessage);

        Console.WriteLine($"Tu nombre tiene {name.Length} letras"); // Length longitud de la cadena
        Console.WriteLine($"Tu nombre en mayuscula {name.ToUpper()}"); // ToUpper() Convierte a mayuculas
        Console.WriteLine($"Tu nombre en  minusculas {name.ToLower()}"); // ToUpper() Convierte a Minusculas

        bool isString = true;
        Console.WriteLine(isString.ToString()); // Convierte el valor a string
    }
}