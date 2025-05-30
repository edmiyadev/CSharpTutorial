partial class Program
{
    static void AnonymousFunctions()
    {
        WriteLine(Square(5));
        WriteLine(LambdaSquare(5));

        // LinQ
        List<int> numbers = [1, 2, 3, 4, 5];
        var evenNumbers = numbers.Where(n => n % 2 == 0);
        foreach (var evenNumber in evenNumbers)
        {
            WriteLine(evenNumber);
        }


    }

    // Funcion anonima
    static Func<int, int> Square = delegate (int number)
    {
        return number * number;
    };

    // Exprresion anonima lambda
    static Func<int, int> LambdaSquare = x => x * x;
}