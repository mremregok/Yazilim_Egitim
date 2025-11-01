namespace _15_IfElse;

// if-else if
public static class Example3
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 3: if-else if ===");
        
        int not = 75;
        
        if (not >= 90)
        {
            Console.WriteLine("AA");
        }
        else if (not >= 80)
        {
            Console.WriteLine("BA");
        }
        else if (not >= 70)
        {
            Console.WriteLine("BB");
        }
        else
        {
            Console.WriteLine("Diğer");
        }
    }
}

