partial class Program
{
    static void Conversions()
    {
        // Conversión implicita
        int number = 42;
        double decimalNumber = number;
        WriteLine(decimalNumber);

        // Conversión explícita
        double explicitDecimalNumber = 42.6;
        int integerNumber = (int)explicitDecimalNumber;
        WriteLine(integerNumber);

        // Convert o Parse
        string text = "123";
        int parsedNumber = int.Parse(text);
        WriteLine(parsedNumber);

        // Convert
        double anotherDecumalNumber = 50.7;

        int convertedNumber = Convert.ToInt32(anotherDecumalNumber);
        WriteLine(convertedNumber); // Redondea 

        int catedNumber = (int)anotherDecumalNumber;
        WriteLine(catedNumber); //Trunca


        
    }
}