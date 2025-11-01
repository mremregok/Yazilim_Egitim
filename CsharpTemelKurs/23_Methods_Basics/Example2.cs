namespace _23_Methods_Basics;

// Parametresiz metot - Hiç parametre almayan metotlar
public static class Example2
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 2: Parametresiz Metot ===");
        
        // Parametresiz metot çağırma - Parantez içinde hiçbir şey yok
        IsimYaz();
        TarihGoster();
        RandomSayi();
    }
    
    // Parametresiz metot - Parantez içi boş
    private static void IsimYaz()
    {
        Console.WriteLine("Ahmet");
    }
    
    // Parametresiz metot - Tarih gösterir
    private static void TarihGoster()
    {
        Console.WriteLine($"Bugünün tarihi: {DateTime.Now:dd.MM.yyyy}");
    }
    
    // Parametresiz metot - Rastgele sayı üretir
    private static void RandomSayi()
    {
        Random rnd = new Random();
        int sayi = rnd.Next(1, 100);
        Console.WriteLine($"Rastgele sayı: {sayi}");
    }
}

