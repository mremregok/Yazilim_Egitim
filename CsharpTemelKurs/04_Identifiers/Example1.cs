namespace _04_Identifiers;

// Geçerli tanımlayıcı kuralları
public static class Example1
{
    public static void Run()
    {
        Console.WriteLine("=== Example 1: Geçerli Tanımlayıcılar ===");
        
        int ogrenciSayisi = 50;
        string ogrenciAdi = "Ali";
        double _deger = 100.5;
        
        Console.WriteLine($"Öğrenci sayısı: {ogrenciSayisi}");
        Console.WriteLine($"Öğrenci adı: {ogrenciAdi}");
        Console.WriteLine($"Değer: {_deger}");
    }
}

