namespace _11_LogicalOperators;

// || (VEYA) operatörü
public static class Example2
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 2: || (VEYA) ===");
        
        bool kosul1 = true;
        bool kosul2 = false;
        
        Console.WriteLine($"true || false: {kosul1 || kosul2}");
        Console.WriteLine($"false || false: {false || false}");
    }
}

