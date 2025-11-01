namespace _18_ForLoop;

// for döngü varyasyonları
public static class Example3
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 3: for Varyasyonları ===");
        
        // Geriye doğru
        for (int i = 5; i >= 1; i--)
        {
            Console.WriteLine($"Geriye: {i}");
        }
        
        // İkişer artırma
        for (int i = 0; i < 10; i += 2)
        {
            Console.WriteLine($"İkişer: {i}");
        }
    }
}

