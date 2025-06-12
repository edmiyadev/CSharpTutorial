partial class Program
{
    static void Collections()
    {
        List<string> names = ["Luis", "Pedro", "Pablo"];
        names.Add("Ana");
        ShowNames(names);

        WriteLine("Despues de remover a Luis");
        names.Remove("Luis");

        ShowNames(names);

        WriteLine("============================================");

        // Diccionarios
        Dictionary<int, string> students = new()
        {
            {1, "Ana"},
            {2, "Carlos"},
            {3, "Pablo"},
        };
        students.Add(4, "Roberto");
        ShowStudents(students);
        students.Remove(1);
        WriteLine("\nDespues de remover a Ana");
        ShowStudents(students);

        WriteLine("============================================");
        HashSet<string> users = ["Luis", "Pedro", "Pablo"];
        users.Add("Melissa");
        users.Add("Maria");
        users.Add("Luis");

        foreach (var user in users)
        {
            WriteLine(user);
        }

    }

    private static void ShowStudents(Dictionary<int, string> students)
    {
        foreach (var student in students)
        {
            WriteLine(student);
        }
    }

    private static void ShowNames(List<string> names)
    {
        foreach (var name in names)
        {
            WriteLine(name);
        }
    }
}