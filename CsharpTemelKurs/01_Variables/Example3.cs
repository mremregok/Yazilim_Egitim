namespace _01_Variables;

// Değişken değer değiştirme
public static class Example3
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 3: Değişkenin Değerini Değiştirme ===");
        
        int sayi = 5;
        Console.WriteLine($"Başlangıç değeri: {sayi}");
        
        sayi = 10;
        Console.WriteLine($"Değiştirilmiş değer: {sayi}");
        
        sayi = sayi + 5;
        Console.WriteLine($"Toplam sonrası: {sayi}");
        
        sayi *= 2;
        Console.WriteLine($"Çarpım sonrası: {sayi}");
    }
}

