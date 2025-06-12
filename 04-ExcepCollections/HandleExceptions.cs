partial class Program
{

    static void HanldeExceptions()
    {
        try
        {
            int number = 10;
            int result = number / 0;
        }
        catch (DivideByZeroException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine("Error: Division por cero");
        }
    }
}
