partial class Program
{
    static void Generics()
    {
        string[] names = { "Juan", "Luis", "Diana" };
        int[] numbers = { 1, 2, 3 };

        // sin genricos
        Console.WriteLine($"Tamaño del arreglo numerico {GetIntArrayLength(numbers)}");
        Console.WriteLine($"Tamaño del arreglo de nombres {GetStringArrayLength(names)}");

        // con genericos
        Console.WriteLine($"Tamaño del arreglo numerico {GetArrayLength(numbers)}");
        Console.WriteLine($"Tamaño del arreglo de nombres {GetArrayLength(names)}");

        Box<int> numberBox = new Box<int> { Content = 50 };
        Box<string> stringBox = new Box<string> { Content = "Ahora soy un texto klk" };

        numberBox.Show();
        stringBox.Show();
    }

    // sin usar Genericos 😕
    static int GetIntArrayLength(int[] array)
    {
        return array.Length;
    }

    static int GetStringArrayLength(string[] array)
    {
        return array.Length;
    }

    // con Genericos 😉
    static int GetArrayLength<T>(T[] array)
    {
        return array.Length;
    }
}


class Box<T>
{
    public T? Content { get; set; }
    public void Show()
    {
        Console.WriteLine($"Contenido: {Content}");
    }
}