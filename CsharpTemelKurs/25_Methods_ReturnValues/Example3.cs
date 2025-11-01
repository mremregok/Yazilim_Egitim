namespace _25_Methods_ReturnValues;

// bool ve diğer dönüş tipleri - Tuple, çoklu değer döndürme
public static class Example3
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 3: bool, Tuple ve Çoklu Değer Dönüşümleri ===");
        
        // bool döndüren metot - true/false döner
        bool sonuc = DogruMu(10);
        Console.WriteLine($"DogruMu(10): {sonuc}");
        
        bool sonuc2 = CiftSayiMi(8);
        Console.WriteLine($"CiftSayiMi(8): {sonuc2}");
        
        // Tuple - Birden fazla değer döndürme (C# 7.0+)
        var (toplam, carpim) = ToplaVeCarp(5, 3);
        Console.WriteLine($"ToplaVeCarp(5, 3): Toplam={toplam}, Çarpım={carpim}");
        
        // Tuple açık kullanım
        (int min, int max) = MinMaxBul(10, 5, 8);
        Console.WriteLine($"MinMaxBul(10, 5, 8): Min={min}, Max={max}");
        
        // Tuple return örneği
        var (ad, yas) = BilgiAl();
        Console.WriteLine($"BilgiAl(): Ad={ad}, Yaş={yas}");
    }
    
    // bool döndüren metot - Koşul sonucunu döner
    private static bool DogruMu(int sayi)
    {
        // Boolean ifade direkt return edilebilir
        return sayi > 5;
    }
    
    // bool - Cift sayı kontrolü
    private static bool CiftSayiMi(int sayi)
    {
        return sayi % 2 == 0; // Modül operatörü ile çift kontrolü
    }
    
    // Tuple - İki değer döndürme (int, int)
    private static (int, int) ToplaVeCarp(int a, int b)
    {
        int toplam = a + b;
        int carpim = a * b;
        return (toplam, carpim); // Tuple döndür
    }
    
    // İsimli Tuple - Dönen değerlere isim verilmiş
    private static (int min, int max) MinMaxBul(int a, int b, int c)
    {
        int min = Math.Min(a, Math.Min(b, c));
        int max = Math.Max(a, Math.Max(b, c));
        return (min, max);
    }
    
    // String ve int içeren Tuple
    private static (string ad, int yas) BilgiAl()
    {
        return ("Ahmet", 25);
    }
}

