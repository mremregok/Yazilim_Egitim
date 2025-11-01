namespace _20_BreakAndContinue;

// continue kullanımı
public static class Example2
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 2: continue ===");
        
        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                continue;
            }
            Console.WriteLine($"Tek sayı: {i}");
        }
    }
}

