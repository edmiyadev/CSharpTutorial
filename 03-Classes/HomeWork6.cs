partial class Program
{
    static void ShowEmpoyeesInformation()
    {
        List<Employee> employees = new();

        employees.Add(new TeamLeader("Carlos", 5000));
        employees.Add(new Developer("Ana", 4000));
        employees.Add(new TeamLeader("Laura", 6000));
        employees.Add(new Developer("Carlos", 3500));

        foreach (var employee in employees)
        {
            employee.ShowInfo();
        }
    }
}


class Employee
{
    protected string? Name;
    protected double Salary;
    protected string? Position;

    public Employee(string name, double salary, string position)
    {
        Name = name;
        Salary = salary;
        Position = position;
    }

    public virtual double CalculateBonus()
    {
        return Salary = Salary * 5 / 100;
    }

    public void ShowInfo()
    {
        WriteLine($"Nombre: {Name}, Cargo: {Position}, Salario: {Salary:C}, Bono calculado {CalculateBonus():C}");
    }
}


class TeamLeader : Employee
{
    public TeamLeader(string name, double salary, string position = "Team Leader") : base(name, salary, position)
    {
    }

    public override double CalculateBonus()
    {
        return Salary * 0.10;
    }
}

class Developer : Employee
{
    public Developer(string name, double salary, string position = "Developer") : base(name, salary, position)
    {
    }

    public override double CalculateBonus()
    {
        return Salary * 0.7;
    }
}

