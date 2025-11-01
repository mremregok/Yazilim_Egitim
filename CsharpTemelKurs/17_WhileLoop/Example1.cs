namespace _17_WhileLoop;

// while döngüsü
public static class Example1
{
    public static void Run()
    {
        Console.WriteLine("=== Example 1: while Döngüsü ===");
        
        int sayac = 0;
        while (sayac < 5)
        {
            Console.WriteLine($"Sayac: {sayac}");
            sayac++;
        }
    }
}

