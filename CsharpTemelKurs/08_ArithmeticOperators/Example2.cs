namespace _08_ArithmeticOperators;

// Çarpma ve bölme
public static class Example2
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 2: Çarpma ve Bölme ===");
        
        int a = 10;
        int b = 3;
        
        Console.WriteLine($"{a} * {b} = {a * b}");
        Console.WriteLine($"{a} / {b} = {a / b}");
        Console.WriteLine($"{a}.0 / {b} = {(double)a / b}");
    }
}

