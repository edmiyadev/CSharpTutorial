partial class Program
{
    static void DataStructures()
    {
        User user = new User { Name = "Edward Minaya", Age = 27 };
        user.Greet();

        Point point = new Point { x = 30, y = 33 };
        Console.WriteLine($"Punto ({point.x}, {point.y})");

        CellPhone iphone = new CellPhone("iphone", 2024);
        Console.WriteLine($"Marca ({iphone.Model}, año {iphone.Year})");

        // error por que es inmutable ❌
        // iphone.Model = "Samsung";
    }
}


// se usa para objetos complejos
class User
{
    public string? Name { get; set; }
    public int Age { get; set; }

    public void Greet()
    {
        Console.WriteLine($"Hola, soy el usuario {Name} y tengo la edad de {Age} años");
    }
}

// Se usa para estructuras mas pequeñas
struct Point
{
    public int x { get; set; }
    public int y { get; set; }
}

// Para datos inmutables
record CellPhone(string Model, int Year);