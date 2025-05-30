partial class Program
{

    static double CalculateArea(double width, double height)
    {
        return width * height;
    }

    static string EvaluateNumber(int number)
    {
        if (number > 0) return "Positivo";
        else if (number < 0) return "negativo";
        else return "Cero";
    }

    static void Functions()
    {
        double area = CalculateArea(4.5, 2.3);
        WriteLine(area);

        string evaluatedNumber = EvaluateNumber(122);
        WriteLine(evaluatedNumber);
    }
}