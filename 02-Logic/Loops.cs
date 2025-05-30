partial class Program
{
    static void Loops()
    {
        // while 
        int counter = 1;
        while (counter <= 5)
        {
            WriteLine($"Iteracion {counter}");
            counter++;
        }


        // Do while 
        int number = 0;
        do
        {
            WriteLine($"Numero {number}");
            number++;
        } while (number < 3);


        // for
        for (int i = 0; i < 5; i++)
        {
            WriteLine($"Iteracion: {i}");
        }


        // foreach
        // Array
        string[] fruits = ["Manzana", "Pera", "Piña"];
        foreach (string fruit in fruits)
        {
            WriteLine(fruit);
        }
        WriteLine("====================================");

        // List
        List<string> names = ["Pedro", "Luis", "Nancy"];
        foreach (string name in names)
        {
            WriteLine(name);
        }
    }
}