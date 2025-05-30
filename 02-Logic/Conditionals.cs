partial class Program
{
    static void Conditionals()
    {
        int age = 19;


        if (age > 18)
        {
            WriteLine("Eres mayor de edad");
        }
        else
        {
            WriteLine("Eres menor de edad");
        }

        //if ternario
        string message = age > 18 ? "Eres mayor de edad" : "Eres menor de edad";
        WriteLine(message);

        // Multiples condiciones: Se recomienda que se use cuando el maximo de evaluaciones sean 3 casos
        int temperature = 18;

        if (temperature > 35)
        {
            WriteLine("Hace mucho calor");
        }
        else if (temperature >= 20)
        {
            WriteLine("Es agradable");
        }
        else
        {
            WriteLine("Hace frio");
        }

        // if ternario multiple
        string messageTemerature = temperature > 35 ? "Hace muchos calor" : temperature >= 20 ? "Es agradable" : "Hace Frio";
        WriteLine(messageTemerature);

        //Switch 
        int day = 3;

        switch (day)
        {
            case 1:
                WriteLine("Lunes");
                break;

            case 2:
                WriteLine("Martes");
                break;

            case 3:
                WriteLine("Miercoes");
                break;

            case 4:
                WriteLine("Jueves");
                break;

            case 5:
                WriteLine("Viernes");
                break;

            case 6:
                WriteLine("Sabado");
                break;

            case 7:
                WriteLine("Domingo");
                break;

            default:
                WriteLine("Dia no valido");
                break;
        }

        //Switch con exprresiones
        string dayMessage = day switch
        {
            1 => "Lunes",
            2 => "Martes",
            3 => "Miercoles",
            4 => "Jueves",
            5 => "Viernes",
            6 => "Sabado",
            7 => "Domingo",
            _ => "Dia no valido"
        };

        WriteLine(dayMessage);
    }
}