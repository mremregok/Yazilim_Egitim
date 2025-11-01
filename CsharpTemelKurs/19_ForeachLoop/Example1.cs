namespace _19_ForeachLoop;

// foreach ile dizi
public static class Example1
{
    public static void Run()
    {
        Console.WriteLine("=== Example 1: foreach ile Dizi ===");
        
        int[] sayilar = { 10, 20, 30, 40, 50 };
        
        foreach (int sayi in sayilar)
        {
            Console.WriteLine($"Sayı: {sayi}");
        }
    }
}

