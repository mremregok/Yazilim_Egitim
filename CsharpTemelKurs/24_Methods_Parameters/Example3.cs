namespace _24_Methods_Parameters;

// out parametreler - Çıkış parametresi, metot içinde mutlaka değer atanmalı
public static class Example3
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 3: out Parametreler (Çıkış Parametresi) ===");
        
        // out - Metot içinde değer atanır ve dışarı çıkar
        // Çağrıda değişken tanımlanmadan da kullanılabilir
        if (DegerAl(out int sonuc))
        {
            Console.WriteLine($"Alınan değer: {sonuc}");
        }
        
        // out ile birden fazla değer döndürme
        if (Hesapla(10, 5, out int toplam, out int carpim))
        {
            Console.WriteLine($"Toplam: {toplam}, Çarpım: {carpim}");
        }
        
        // TryParse örneği - En yaygın out kullanımı
        string sayiMetin = "123";
        if (int.TryParse(sayiMetin, out int sayi))
        {
            Console.WriteLine($"TryParse başarılı: {sayi}");
        }
        
        // out ile değişken tanımlama (metot çağrısında)
        BolmeYap(20, 4, out int bolum, out int kalan);
        Console.WriteLine($"Bölme: {bolum}, Kalan: {kalan}");
    }
    
    // out parametre - Çıkış için kullanılır, metot içinde MUTLAKA değer atanmalı
    // Çağrıda değişken başlatılmadan kullanılabilir
    private static bool DegerAl(out int deger)
    {
        deger = 50; // Mutlaka değer atanmalı
        return true;
    }
    
    // Birden fazla out parametre
    private static bool Hesapla(int a, int b, out int toplam, out int carpim)
    {
        toplam = a + b; // Mutlaka atama yapılmalı
        carpim = a * b; // Mutlaka atama yapılmalı
        return true;
    }
    
    // out ile bölme ve kalan hesaplama
    private static void BolmeYap(int bolunen, int bolen, out int bolum, out int kalan)
    {
        bolum = bolunen / bolen;
        kalan = bolunen % bolen;
    }
}

