partial class Program
{
    static void LoopGame()
    {
        int counter = 0;

        WriteLine("Presione una tecla para aumentar el contador");
        WriteLine("Presione ESC para salirs");

        while (true)
        {
            ConsoleKey key = ReadKey(true).Key;
            WriteLine(key);
            if (key == ConsoleKey.Escape)
            {
                WriteLine("Has pulsado la letra ESC");
                WriteLine($"Has pulsado {counter} las teclas antes de salirr");
                return;
            }
            counter++;
        }
    }
}