namespace _37_Exceptions;

// try-catch - Hata yakalama temelleri
public static class Example1
{
    public static void Run()
    {
        Console.WriteLine("=== Example 1: try-catch Temelleri ===");
        
        // FormatException - Format hatası (örn: sayıya çevrilemez string)
        try
        {
            int sayi = int.Parse("abc");
            Console.WriteLine($"Sayı: {sayi}");
        }
        catch (FormatException ex)
        {
            // FormatException yakalandı - Hata mesajını göster
            Console.WriteLine($"FormatException: {ex.Message}");
        }
        
        // DivideByZeroException - Sıfıra bölme hatası
        try
        {
            int bolen = 0;
            int sonuc = 10 / bolen; // Değişken ile sıfıra bölme
            Console.WriteLine($"Sonuç: {sonuc}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"DivideByZeroException: {ex.Message}");
        }
        
        // IndexOutOfRangeException - Dizi sınırları dışı erişim
        try
        {
            int[] dizi = { 1, 2, 3 };
            int deger = dizi[10];
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"IndexOutOfRangeException: {ex.Message}");
        }
        
        // NullReferenceException - Null referans hatası
        try
        {
            object? obj = null;
            string str = obj!.ToString(); // Null referans hatası oluşur
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine($"NullReferenceException: {ex.Message}");
        }
        
        // Genel Exception - Tüm hataları yakalar (en sonda olmalı)
        try
        {
            int[]? dizi = null;
            int deger = dizi![0]; // Null referans hatası
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Genel Exception: {ex.GetType().Name} - {ex.Message}");
        }
    }
}

