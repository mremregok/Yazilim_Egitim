namespace _10_ComparisonOperators;

// == ve != operatörleri
public static class Example1
{
    public static void Run()
    {
        Console.WriteLine("=== Example 1: == ve != ===");
        
        int a = 10;
        int b = 20;
        
        Console.WriteLine($"{a} == {b}: {a == b}");
        Console.WriteLine($"{a} != {b}: {a != b}");
    }
}

