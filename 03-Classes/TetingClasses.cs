partial class Program
{
    static void TetingClasses()
    {
        Vehicle hyunday = new Vehicle();
        hyunday.Brand = "Hyunday";
        hyunday.Model = "Elantra";
        hyunday.Year = 2011;
        hyunday.ShowInfo();

        Vehicle toyota = new Vehicle { Brand = "Toyota", Model = "Corolla", Year = 2021 };
        toyota.ShowInfo();

        Vehicle renault = new Vehicle("Renault", "Duster", 2024);
        renault.ShowInfo();
    }
}


class Vehicle
{
    // Propiedades
    public string? Brand { get; set; }
    public string? Model { get; set; }
    public int Year { get; set; }


    // Constructor

    public Vehicle(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }

    public Vehicle() { }



    // Metodos
    public void ShowInfo()
    {
        WriteLine($"Este vehiculo es un {Brand} {Model} del año {Year}");
    }
}