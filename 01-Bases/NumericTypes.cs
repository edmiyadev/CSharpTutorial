partial class Program
{
    static void NumericTypes()
    {
        int intergerNumber = 42; // int.MaxValue; 2147483647   int.MinValue; -2147483648
        double doubleNumber = 3.1416d;
        float floatingNumber = 274f;
        long longNumber = 300_200_100L; // el separador _ no afecta en nada
        decimal decimalNumbre = 99.99m; // excelente para calculos financieros 

        Console.WriteLine($"Entero {intergerNumber} \nDoble: {doubleNumber} \nFloat: {floatingNumber} \nLogn: {longNumber} \nDecimal: {decimalNumbre}");
    }
}