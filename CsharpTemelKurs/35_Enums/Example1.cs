namespace _35_Enums;

// Enum tanımlama
public static class Example1
{
    public static void Run()
    {
        Console.WriteLine("=== Example 1: Enum Tanımlama ===");
        
        HaftaninGunleri bugun = HaftaninGunleri.Pazartesi;
        Console.WriteLine($"Bugün: {bugun}");
    }
}

enum HaftaninGunleri
{
    Pazartesi,
    Sali,
    Carsamba,
    Persembe,
    Cuma,
    Cumartesi,
    Pazar
}

