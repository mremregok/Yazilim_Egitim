namespace _04_Identifiers;

// camelCase ve PascalCase kullanımı
public static class Example2
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 2: İsimlendirme Kuralları ===");
        
        // camelCase: Yerel değişkenler
        int ogrenciYasi = 20;
        string ogrenciAdi = "Ayşe";
        
        // PascalCase: Sınıf ve metot adları
        Console.WriteLine($"Öğrenci: {ogrenciAdi}, Yaş: {ogrenciYasi}");
    }
}

