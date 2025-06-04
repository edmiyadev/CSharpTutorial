partial class Program
{
    static void ProductSalesDemo()
    {
        Inventory inventory = new Inventory();
        Product laptop = new Product("Latop", 1200.99, 5);
        Product mouse = new Product("Mouse", 100, 10);

        inventory.AddProduct(laptop);
        inventory.AddProduct(mouse);
        inventory.ShowInventory();
        laptop.Sell(1);
        inventory.ShowInventory();
    }

    static void BusFleat()
    {
        Bus toyota = new Bus("Toyota", "Corolla", 2019, 54_0000.00, 10_000);
        Bus honda = new Bus("Honda", "Civic", 2018, 74_0000.00, 8_000);
        Bus ford = new Bus("Ford", "Fiesta", 2017, 34_0000.00, 7_000);
        Fleet fleet = new();
        fleet.AddBuss(toyota);
        fleet.AddBuss(honda);
        fleet.AddBuss(ford);
        fleet.ShowBuses();
        toyota.Drive(5000);
        honda.Drive(5000);
        ford.Drive(5000);
        WriteLine("Despues de manetar 5000 km");
        fleet.ShowBuses();
    }
}

class Product
{
    public string? Name { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }

    public Product(string name, double price, int stock)
    {
        Name = name;
        Price = price;
        Stock = stock;
    }

    public void ShowInfo()
    {
        WriteLine($"Producto: {Name}, Precio: {Price}, Stock: {Stock}");
    }

    public bool Sell(int quantity)
    {
        if (quantity <= Stock)
        {
            Stock -= quantity;
            WriteLine($"Venta realizada: {quantity} unidades de {Name}");
            return true;
        }
        WriteLine($"Stock insuficiente para {Name}");
        return false;
    }
}

class Inventory
{
    private List<Product> products = new List<Product>();

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void ShowInventory()
    {
        WriteLine("Invnetario de productos");
        foreach (var product in products)
        {
            product.ShowInfo();
        }
    }
}

class Bus
{
    public string? Brand;
    public string? Model;
    public int Year;
    public double Price;
    public int TotalKilometers;

    public Bus(string brand, string model, int year, double price, int totalKilometers)
    {
        Brand = brand;
        Model = model;
        Year = year;
        Price = price;
        TotalKilometers = totalKilometers;
    }

    public void Drive(int kilometers)
    {
        TotalKilometers += kilometers;
    }

    public void ShowPrice()
    {
        WriteLine($"Precio{Price}");
    }

    public void ShowBus()
    {
        WriteLine($"Marca: {Brand}, Modelo: {Model}, Año: {Year}, Kilometraje {TotalKilometers}");
    }
}

class Fleet
{
    public List<Bus> buses = new();

    public void AddBuss(Bus bus)
    {
        buses.Add(bus);
    }

    public void ShowBuses()
    {
        foreach (var bus in buses)
        {
            bus.ShowBus();
        }
    }
}