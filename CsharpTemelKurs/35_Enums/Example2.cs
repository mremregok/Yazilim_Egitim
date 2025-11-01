namespace _35_Enums;

// Enum değerleri
public static class Example2
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 2: Enum Değerleri ===");
        
        Renkler renk = Renkler.Kirmizi;
        Console.WriteLine($"Renk: {renk}");
        Console.WriteLine($"Değer: {(int)renk}");
    }
}

enum Renkler
{
    Kirmizi = 1,
    Yesil = 2,
    Mavi = 4
}

