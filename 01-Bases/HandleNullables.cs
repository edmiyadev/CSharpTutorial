partial class Program
{
    static void HandleNullables()
    {
        // No nulificable
        string firstName = "Carlos";

        // Nulificable
        string? lastName = null;
        Console.WriteLine($"Nombre {firstName}");

        // manejar nulos 
        if (lastName != null)
        {
            Console.WriteLine($"Apellido {lastName}");
        }
        else
        {
            Console.WriteLine($"Apellido no especificado");
        }


        // Operadoe de coalescencia nula ??
        Console.WriteLine($"Apellido {lastName ?? "no especificado"}");


        // Operador de acceso nulo seguro ?.
        string? text = null;
        Console.WriteLine(text?.Length);
    }
}