namespace _04_Identifiers;

// Geçersiz tanımlayıcı örnekleri (yorum satırları)
public static class Example3
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 3: İsimlendirme Kuralları ===");
        
        Console.WriteLine("Geçerli: ogrenciSayisi, _deger, ogrenciAdi123");
        Console.WriteLine("Geçersiz: 123sayi, sayi-deger, class, int (rezerve kelimeler)");
        
        int ogrenciSayisi = 100;
        int _deger = 50;
        
        Console.WriteLine($"Örnek değişkenler: {ogrenciSayisi}, {_deger}");
    }
}

