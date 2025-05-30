partial class Program
{
    // 🏆 Ejercicio:
    // - Mostrar el inventario actualizado después de cada compra. 
    // - Crear un menu con las opciones de 1. Comprar producto y 2. Salir.

    static void InventoryMaanager()
    {
        string[] products = ["Laptop", "Mouse", "Teclado", "Monitor", "impresora"];
        int[] stock = [10, 25, 15, 8, 5];
        double[] prices = [750.50, 20.50, 45.00, 200.99, 150.00];


        Console.WriteLine("1. Comprar producto");
        Console.WriteLine("2. Salir");

        Console.WriteLine("Ingrese una opcion:");
        string option = Console.ReadLine()!;

        switch (option)
        {
            case "1":
                Console.WriteLine("Inventario de Productos");
                Console.WriteLine("-----------------------");

                for (int i = 0; i < products.Length; i++)
                {
                    Console.WriteLine($"Producto: {products[i]}, Stock: {stock[i]}, Precio: {prices[i]:C}");
                }

                Console.WriteLine("\nIngrese el prodcuto que desea comprar: ");
                string? searchedProduct = Console.ReadLine();

                Console.WriteLine("Ingrese la cantiad que desea comprar: ");
                int quantity = int.Parse(Console.ReadLine()!);

                for (int i = 0; i < products.Length; i++)
                {
                    if (products[i].Equals(searchedProduct, StringComparison.OrdinalIgnoreCase))
                    {
                        if (quantity <= stock[i])
                        {
                            double total = quantity * prices[i];
                            stock[i] -= quantity;
                            Console.WriteLine($"Compra exitosa. total a pagar {total:C}");
                            Console.WriteLine($"Stock restante para el producto {products[i]} es: {stock[i]}");
                        }
                        else
                        {
                            Console.WriteLine("No hay suficiente stock");
                        }
                    }
                    Console.WriteLine();
                }
                break;

            case "2":
                Console.WriteLine("Gracias por su visita");
                break;

            default:
                Console.WriteLine("Opcion invalida");
                break;
        }
    }
}