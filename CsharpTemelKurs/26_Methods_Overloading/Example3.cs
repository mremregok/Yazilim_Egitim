namespace _26_Methods_Overloading;

// Kombine overloading
public static class Example3
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 3: Kombine Overloading ===");
        
        Yazdir(10);
        Yazdir("Merhaba");
        Yazdir(10, "Ahmet");
    }
    
    private static void Yazdir(int sayi)
    {
        Console.WriteLine($"Sayı: {sayi}");
    }
    
    private static void Yazdir(string metin)
    {
        Console.WriteLine($"Metin: {metin}");
    }
    
    private static void Yazdir(int sayi, string metin)
    {
        Console.WriteLine($"Sayı: {sayi}, Metin: {metin}");
    }
}

