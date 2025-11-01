namespace _36_Files;

// Dosya yazma - File.WriteAllText, File.WriteAllLines
public static class Example1
{
    public static void Run()
    {
        Console.WriteLine("=== Example 1: Dosya Yazma Metotları ===");
        
        string dosyaYolu1 = "ornek1.txt";
        
        // File.WriteAllText - Tüm içeriği tek seferde yazar (mevcut içeriği siler)
        File.WriteAllText(dosyaYolu1, "Merhaba C#!");
        Console.WriteLine($"WriteAllText ile yazıldı: {dosyaYolu1}");
        
        // File.ReadAllText ile okuyup kontrol edelim
        string icerik = File.ReadAllText(dosyaYolu1);
        Console.WriteLine($"Okunan içerik: {icerik}");
        
        // File.WriteAllLines - String dizisini satır satır yazar
        string dosyaYolu2 = "ornek2.txt";
        string[] satirlar = { "Satır 1", "Satır 2", "Satır 3" };
        File.WriteAllLines(dosyaYolu2, satirlar);
        Console.WriteLine($"WriteAllLines ile {satirlar.Length} satır yazıldı: {dosyaYolu2}");
        
        // Temizlik
        File.Delete(dosyaYolu1);
        File.Delete(dosyaYolu2);
    }
}

