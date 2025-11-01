namespace _36_Files;

// Dosya okuma - File.ReadAllText, File.ReadAllLines
public static class Example2
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 2: Dosya Okuma Metotları ===");
        
        string dosyaYolu = "test.txt";
        File.WriteAllText(dosyaYolu, "Satır 1\nSatır 2\nSatır 3");
        
        // File.ReadAllText - Tüm dosyayı tek string olarak okur
        string icerik = File.ReadAllText(dosyaYolu);
        Console.WriteLine($"ReadAllText içeriği:\n{icerik}");
        
        // File.ReadAllLines - Dosyayı satır satır okur, string dizisi döner
        string[] satirlar = File.ReadAllLines(dosyaYolu);
        Console.WriteLine($"\nReadAllLines ile {satirlar.Length} satır:");
        for (int i = 0; i < satirlar.Length; i++)
        {
            Console.WriteLine($"  [{i}] {satirlar[i]}");
        }
        
        // File.ReadAllLines ile foreach kullanımı
        Console.WriteLine("\nForeach ile okuma:");
        foreach (string satir in File.ReadAllLines(dosyaYolu))
        {
            Console.WriteLine($"  - {satir}");
        }
        
        // Temizlik
        File.Delete(dosyaYolu);
    }
}

