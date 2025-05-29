partial class Program
{
    static void Arrays()
    {
        int[] number = new int[5];
        number[0] = 1;
        number[1] = 3;

        // Directa
        int[] numbersArray = [5, 10, 15, 20, 25];

        //Indices
        Console.WriteLine($"Primer elemento {numbersArray[0]}");
        Console.WriteLine($"Segundo elemento {numbersArray[1]}");

        //Tamaño del arreglo
        Console.WriteLine($"El numer ode elemtnos es: {numbersArray.Length}");

        // Desde el final del arreglo ^
        Console.WriteLine($"Ultimo elemento {numbersArray[^1]}");
        Console.WriteLine($"Penultimo elemento {numbersArray[^2]}");

        // Rangos para obtener subarreglos ..
        int[] firstTree = numbersArray[..3];
        int[] fromIndexTwo = numbersArray[2..];


        foreach (var num in firstTree)
        {
            Console.WriteLine(num);
        }
    }
}