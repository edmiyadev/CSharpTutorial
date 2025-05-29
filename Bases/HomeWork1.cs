partial class Program
{
    static void SalesReport()
    {
        string product = "Laptop";
        int quantitySold = 3;
        double unitPrice = 750.99;

        double totalAmount = quantitySold * unitPrice;

        Console.WriteLine($"Producto: {product}");
        Console.WriteLine($"Cantidad Vendida: {quantitySold}");
        Console.WriteLine($"Total Generado: {totalAmount:C}"); // la C sirve para formatear a moneda dependiendo de la configuración
    }


    // 🏆 Ejercicio:
    // Crear un programa que calcule el salario mensual de un trabajador
    // - Pedir al usuario su nombre, horas trabajadas y tarifa por hora
    // - Calcular el sueldo y mostrarlo en pantalla
    static void SalaryCalculator()
    {
        string? name;  // ? indica que la variable podria ser nula
        float hoursWorked;
        double hourlyRate;


        Console.WriteLine("==================================================");
        Console.WriteLine("             CALCULADORA DE SALARIO");
        Console.WriteLine("==================================================");

        Console.Write("Ingrese su nombre: ");
        name = Console.ReadLine();

        Console.Write("Ingrese su numero de horas trabajadas: ");
        hoursWorked = float.Parse(Console.ReadLine()!); // ! null forgiving operator (Confio en que este alor no va a ser nulo)

        Console.Write("Ingrese el salario por hora: ");
        hourlyRate = double.Parse(Console.ReadLine()!);

        Console.WriteLine($"El salario para {name} es de {(hoursWorked * hourlyRate):C}");
    }
}