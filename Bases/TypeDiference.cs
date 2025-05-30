partial class Program
{
    static void TypeDiference()
    {
        // Pasando valores por valor 
        int x = 5;
        int y = x;
        y = 15;

        Console.WriteLine($"x {x}, y: {y}");


        // Pasando valores por referencia 
        Person person1 = new Person { Name = "Edward" };
        Person person2 = person1;
        person2.Name = "Anthony";

        Console.WriteLine($"Persona 1 {person1.Name}");
    }
}


class Person
{
    public string Name { get; set; }
}