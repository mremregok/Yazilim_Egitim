namespace _17_WhileLoop;

// do-while
public static class Example2
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 2: do-while ===");
        
        int sayac = 0;
        do
        {
            Console.WriteLine($"Sayac: {sayac}");
            sayac++;
        } while (sayac < 5);
    }
}

