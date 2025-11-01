namespace _02_Constants;

// readonly ile sabitler
public static class Example2
{
    private static readonly int MAX_DEGER = 100;
    private static readonly string BASLANGIC_MESAJI;
    
    static Example2()
    {
        BASLANGIC_MESAJI = "Uygulama başlatılıyor...";
    }
    
    public static void Run()
    {
        Console.WriteLine("\n=== Example 2: readonly Sabitler ===");
        
        Console.WriteLine($"Maksimum değer: {MAX_DEGER}");
        Console.WriteLine($"Başlangıç mesajı: {BASLANGIC_MESAJI}");
    }
}

