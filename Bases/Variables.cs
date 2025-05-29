using System.Security.Cryptography;

partial class Program
{
    static void Variables()
    {
        int age = 25;
        string name = "Edward";
        bool isStudent = true;
        var inferred = 123;  // el valor es inferido a partir del dato con el que se inicialize
        Console.WriteLine($"Nombre:{name} tiene una edad {age} es estudiante {isStudent}, Random {inferred}");
    }
}