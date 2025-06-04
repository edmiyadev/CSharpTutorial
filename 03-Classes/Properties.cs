partial class Program
{
    static void Properties()
    {
        Animal animal = new Animal("En el 9");
        animal.Species = "Chofer de Carro Publico";
        animal.Age = 35;
        animal.Category = "Fenatrano";

        WriteLine($"Donde vive: {animal.Habitat}, que animal es: {animal.Species}, que categoria tiene {animal.Category}");
    }
}


class Animal
{
    public string? Species { get; set; }
    public string? Category { get; set; }
    public int age;
    public int Age
    {
        get { return age; }
        set
        {
            age = value < 0 ?
            throw new ArgumentException("La edad no puede ser negativa")
            : value;
        }
    }

    public string Habitat { get; }

    public Animal(string habitat)
    {
        Habitat = habitat;
    }

}