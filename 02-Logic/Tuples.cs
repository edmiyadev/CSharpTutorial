partial class Program
{
    static void Tuples()
    {
        (int, string, bool) myTuple = (42, "Hola", true);
        WriteLine($"Numero: {myTuple.Item1}, Texto: {myTuple.Item2}, Boolean: {myTuple.Item3}");

        (int Number, string Text, bool Bool) myOtherTuple = (18, "Adios", false);
        WriteLine($"Numero: {myOtherTuple.Number}, Texto: {myOtherTuple.Text}, Boolean: {myOtherTuple.Bool}");


        var operations = Operations(20, 10);
        WriteLine($"Suma: {operations.Sum}, Resta: {operations.Subtraction}");


        (int sum, int subtraction) = Operations(20, 10); // desestructuracion de una tupla
        WriteLine($"Suma: {sum}, Resta: {subtraction}");
    }


    static (int Sum, int Subtraction) Operations(int a, int b) // Metodo que devuelve una Tupla
    {
        return (a + b, a - b);
    }
}