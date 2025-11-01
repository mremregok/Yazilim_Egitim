namespace _26_Methods_Overloading;

// Farklı parametre türleri ile overloading
public static class Example2
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 2: Farklı Türler ===");
        
        Console.WriteLine(Topla(5, 3));
        Console.WriteLine(Topla(5.5, 3.2));
    }
    
    private static int Topla(int a, int b)
    {
        return a + b;
    }
    
    private static double Topla(double a, double b)
    {
        return a + b;
    }
}

