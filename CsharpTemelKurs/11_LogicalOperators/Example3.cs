namespace _11_LogicalOperators;

// ! (DEĞİL) operatörü
public static class Example3
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 3: ! (DEĞİL) ===");
        
        bool dogru = true;
        bool yanlis = false;
        
        Console.WriteLine($"!true: {!dogru}");
        Console.WriteLine($"!false: {!yanlis}");
    }
}

