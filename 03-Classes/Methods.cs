partial class Program
{
    static void Methods()
    {
        Car car = new Car();
        car.Model = "Yaris";
        car.Year = 2022;
        WriteLine(car.ShowInfo());
        // car.ShowMessage("Cambiando de Modelo");
        // car.ChangeModel("Patrol");
        // WriteLine(car.ShowInfo());

        // Car.GenetalInfo();

        Car sportsCar = new Car("Ferrary", 2020);
        WriteLine(sportsCar.ShowInfo());

        //Sintaxis simplificada
        Car CollectionCar = new Car { Model = "Cadillac", Year = 1980 };
        WriteLine(CollectionCar.ShowInfo());


        // Lista de objetos
        WriteLine("Listado de automvile");

        List<Car> cars = new()
        {
            new Car(){Model="Duster", Year=2021},
            new Car(){Model="StepWay", Year=2019},
            new Car(){Model="Captur", Year=2020},
        };

        foreach (var item in cars)
        {
            WriteLine(item.ShowInfo());
        }

    }
}


class Car
{
    public string? Model { get; set; }
    public int? Year { get; set; }

    public Car()
    {
    }
    public Car(string model, int year)
    {
        Model = model;
        Year = year;
    }

    ~Car()
    {
        WriteLine("Destructor llamado. Recurso liberado");
    }
    public void ChangeModel(string newModel)
    {
        Model = newModel;
    }

    public string ShowInfo()
    {
        return $"Automovil: {Model}, Año {Year}";
    }

    public void ShowMessage(string message) => WriteLine(message);

    public static void GenetalInfo()
    {
        WriteLine("El automovil es uno de los transportes mas utilizados");
    }
}