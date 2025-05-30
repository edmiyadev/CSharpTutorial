partial class Program
{
    static void PrintMultiplicarionTable(int number, int tableLimit = 10) //int tableLimit = 10 parametro por defecto
    {
        WriteLine($"Tabla de multiplcia del numero {number}, desde el 1 hasta el {tableLimit}");

        for (int i = 1; i <= tableLimit; i++)
        {
            WriteLine($"{number} x {i} = {number * i}");
        }
    }

    // 🏆 Ejercicio:
    // Crear un método llamado `PrintFactorialTable` que reciba un número 
    // y muestre el factorial de todos los números desde 1 hasta el número ingresado.
    // Ejemplo: PrintFactorialTable(5);
    // 1! = 1
    // 2! = 2
    // 3! = 6
    // 4! = 24
    // 5! = 120
    static void PrintFactorialTable(int number)
    {
        WriteLine($"Factorial del numero {number} desde el 1 hasta el {number}");
        for (int i = 1; i <= number; i++)
        {
            WriteLine($"{i}! = {Factorial(i)}");
        }
    }

    static int Factorial(int number)
    {
        int result = 1;
        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }

        return result;
    }
}