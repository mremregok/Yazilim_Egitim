namespace _19_ForeachLoop;

// foreach vs for
public static class Example3
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 3: foreach vs for ===");
        
        int[] sayilar = { 10, 20, 30 };
        
        Console.WriteLine("for ile:");
        for (int i = 0; i < sayilar.Length; i++)
        {
            Console.WriteLine($"İndis {i}: {sayilar[i]}");
        }
        
        Console.WriteLine("foreach ile:");
        foreach (int sayi in sayilar)
        {
            Console.WriteLine($"Değer: {sayi}");
        }
    }
}

