namespace _26_Methods_Overloading;

// Farklı parametre sayısı ile overloading
public static class Example1
{
    public static void Run()
    {
        Console.WriteLine("=== Example 1: Parametre Sayısı ===");
        
        Console.WriteLine(Topla(5, 3));
        Console.WriteLine(Topla(1, 2, 3));
    }
    
    private static int Topla(int a, int b)
    {
        return a + b;
    }
    
    private static int Topla(int a, int b, int c)
    {
        return a + b + c;
    }
}

