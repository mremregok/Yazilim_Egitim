namespace _17_WhileLoop;

// Sonsuz döngü ve çıkış
public static class Example3
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 3: Sonsuz Döngü ===");
        
        int sayac = 0;
        while (true)
        {
            sayac++;
            if (sayac >= 3)
            {
                break;
            }
            Console.WriteLine($"Iterasyon: {sayac}");
        }
    }
}

