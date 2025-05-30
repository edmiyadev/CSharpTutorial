partial class Program
{
    static void ListDictionary()
    {
        // Listas
        List<string> names = new List<string> { "Ana", "Carlos", "Juan" };
        names.Add("Lucia");

        Console.WriteLine($"Total de nombre: {names.Count}");

        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

        names.Remove("Ana");
        bool isPresent = names.Contains("Ana");

        Console.WriteLine($"Ana esta en la lista {isPresent}");


        //Diccionario
        Dictionary<int, string> students = new Dictionary<int, string>
        {
            {1, "Ana"},
            {2, "Felipe"},
            {3, "Ana"}
        };

        Console.WriteLine($"El estudiante con ID: 1 es {students[1]}");

        foreach (var student in students)
        {
            Console.WriteLine($"ID: {student.Key}, Nombre: {student.Value}");
        }


        // experimento
        Dictionary<string, string> person = new Dictionary<string, string>
        {
            {"Edward", "Minaya"},
            {"Kevin", "Gomez"},
        };
        
        Console.WriteLine(person["Edward"]);
    }
}