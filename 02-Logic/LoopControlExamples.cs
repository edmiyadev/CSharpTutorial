partial class Program
{
    static void LoopControlExamples()
    {
        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
            {
                break;
            }
            WriteLine(i);
        }
        WriteLine("========================");

        for (int i = 0; i < 10; i++)
        {
            if (i == 5 || i == 7)
            {
                continue;
            }
            WriteLine(i);
        }
        WriteLine("========================");

        for (int i = 0; i < 10; i++)
        {
            if (i == 3)
            {
                return;
            }
            WriteLine(i);
        }

        // Bucles infinito
        
        // while (true)
        // {
        //     WriteLine("Esto siempre se ejecutara");
        // }

        // for (; ; )
        // {
        //     WriteLine("Esto tambien siempre se ejecutara"); 
        // }
    }
}