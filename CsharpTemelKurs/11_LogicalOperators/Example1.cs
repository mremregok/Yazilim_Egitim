namespace _11_LogicalOperators;

// && (VE) operatörü
public static class Example1
{
    public static void Run()
    {
        Console.WriteLine("=== Example 1: && (VE) ===");
        
        bool kosul1 = true;
        bool kosul2 = false;
        
        Console.WriteLine($"true && true: {true && true}");
        Console.WriteLine($"true && false: {kosul1 && kosul2}");
    }
}

