namespace _24_Methods_Parameters;

// Value parametreler - Değer kopyalanarak geçirilir
public static class Example1
{
    public static void Run()
    {
        Console.WriteLine("=== Example 1: Value Parametreler (Değer ile Geçiş) ===");
        
        int sayi = 10;
        Console.WriteLine($"Metot çağrısından önce: {sayi}");
        
        // Value parametre - Değer kopyalanır, orijinal değişmez
        DegerDegistir(sayi);
        
        Console.WriteLine($"Metot çağrısından sonra: {sayi} (değişmedi!)");
        
        // String de value type gibi davranır (immutable)
        string metin = "Merhaba";
        MetinDegistir(metin);
        Console.WriteLine($"String değişmedi: {metin}");
    }
    
    // Value parametre - int değer kopyalanır (stack'te yeni bir kopya oluşur)
    // Metot içinde değer değiştirilse bile orijinal değişmez
    private static void DegerDegistir(int deger)
    {
        deger = 100; // Sadece kopya değişir, orijinal değişmez
        Console.WriteLine($"  Metot içi (kopya): {deger}");
    }
    
    // String için de aynı durum - Yeni string oluşturulur
    private static void MetinDegistir(string metin)
    {
        metin = "Yeni Metin"; // Yeni string oluşturulur, orijinal değişmez
        Console.WriteLine($"  Metot içi metin: {metin}");
    }
}

