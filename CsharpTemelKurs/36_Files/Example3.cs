namespace _36_Files;

// Dosya işlemleri - File.Exists, File.AppendAllText, File.Copy, File.Move, File.Delete
public static class Example3
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 3: Dosya İşlem Metotları ===");
        
        string dosyaYolu = "kontrol.txt";
        
        // File.Exists - Dosyanın var olup olmadığını kontrol eder (true/false)
        if (File.Exists(dosyaYolu))
        {
            Console.WriteLine($"'{dosyaYolu}' dosyası mevcut");
        }
        else
        {
            Console.WriteLine($"'{dosyaYolu}' dosyası mevcut değil");
            
            // File.WriteAllText - Yeni dosya oluşturur veya mevcut içeriği siler
            File.WriteAllText(dosyaYolu, "İlk satır");
            Console.WriteLine("Dosya oluşturuldu (WriteAllText)");
        }
        
        // File.AppendAllText - Dosyanın sonuna ekler (mevcut içeriği korur)
        File.AppendAllText(dosyaYolu, "\nEklenen satır");
        Console.WriteLine("\nAppendAllText ile eklendi");
        
        // Dosya içeriğini göster
        Console.WriteLine("\nDosya içeriği:");
        Console.WriteLine(File.ReadAllText(dosyaYolu));
        
        // File.Copy - Dosyayı kopyalar
        string kopyaYolu = "kopya.txt";
        File.Copy(dosyaYolu, kopyaYolu, overwrite: true);
        Console.WriteLine($"\nDosya kopyalandı: {kopyaYolu}");
        
        // File.Move - Dosyayı taşır veya yeniden adlandırır
        string yeniIsim = "yeniden_adlandirildi.txt";
        File.Move(kopyaYolu, yeniIsim, overwrite: true);
        Console.WriteLine($"Dosya taşındı: {yeniIsim}");
        
        // File.Delete - Dosyayı siler
        File.Delete(dosyaYolu);
        File.Delete(yeniIsim);
        Console.WriteLine("\nDosyalar silindi");
    }
}

