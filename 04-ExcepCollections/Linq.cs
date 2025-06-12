using System.Runtime.Intrinsics.Arm;

partial class Program
{
    static void Linq()
    {
        List<int> numbers = [1, 2, 3, 4, 5, 6, 7];
        List<int> evenNumbers = [];

        // numeros pares 
        foreach (var number in numbers)
        {
            if (number % 2 == 0)
            {
                evenNumbers.Add(number);
            }
        }

        // LinQ Sintaxis de consulta
        var evenNumbersQuery = from num in numbers
                               where num % 2 == 0
                               select num;

        // LinQ Sintaxis de metodo
        var evenNumbersMethod = numbers.Where(n => n % 2 == 0);


        foreach (var number in evenNumbersMethod) // evenNumbers, evenNumbersQuery, evenNumbersMethod
        {
            WriteLine(number);
        }

        List<MarvelCharacter> characters = new List<MarvelCharacter>
        {
            new MarvelCharacter { Name = "Peter Parker", Alias = "Spider-Man", Team = "Avengers" },
            new MarvelCharacter { Name = "Tony Stark", Alias = "Iron Man", Team = "Avengers" },
            new MarvelCharacter { Name = "Steve Rogers", Alias = "Captain America", Team = "Avengers" },
            new MarvelCharacter { Name = "Natasha Romanoff", Alias = "Black Widow", Team = "Avengers" },
            new MarvelCharacter { Name = "T'Challa", Alias = "Black Panther", Team = "Wakanda" },
            new MarvelCharacter { Name = "Stephen Strange", Alias = "Doctor Strange", Team = "Defenders" }
        };

        // consultas simples
        // where
        WriteLine("Personajes que pertenecen a los Avengers");
        var avengersQuery = from avenger in characters
                            where avenger.Team == "Avengers"
                            select avenger;

        var avengersMethod = characters.Where(c => c.Team == "Avengers");

        foreach (var avenger in avengersMethod)
        {
            WriteLine(avenger.Name);
        }
        //  uppercase
        var upperCaseNamesQuery = from avenger in characters
                                  select avenger.Name?.ToUpper();

        foreach (var avenger in upperCaseNamesQuery)
        {
            WriteLine(avenger);
        }

        var upperCaseNamesMethod = characters.Select(c => c.Name?.ToUpper());

        foreach (var avenger in upperCaseNamesMethod)
        {
            WriteLine(avenger);
        }

        WriteLine("=============Sorted=============");
        var sortedQuery = (from c in characters
                           orderby c.Name
                           select c.Name).Take(3);

        var sortedMethod = characters.OrderByDescending(c => c.Name).Take(3);


        foreach (var character in sortedQuery)
        {
            WriteLine(character);
        }

        foreach (var character in sortedMethod)
        {
            WriteLine(character.Name);
        }
        WriteLine();

        var teamsQuery = from c in characters
                         group c by c.Team into team
                         select team;
        
        foreach (var team in teamsQuery)
        {
            WriteLine(team.Key);
        }
    }
}


class MarvelCharacter
{
    public string? Name { get; set; }
    public string? Alias { get; set; }
    public string? Team { get; set; }
}
