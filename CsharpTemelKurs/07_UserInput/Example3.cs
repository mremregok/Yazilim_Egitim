namespace _07_UserInput;

// Birden fazla girdi alma ve döngü ile girdi alma
public static class Example3
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 3: Çoklu Giriş ve Döngü ile Giriş ===");
        
        // Birden fazla girdi alma
        Console.Write("Adınız: ");
        string? ad = Console.ReadLine();
        
        Console.Write("Soyadınız: ");
        string? soyad = Console.ReadLine();
        
        Console.Write("Yaşınız: ");
        string? yasGirdi = Console.ReadLine();
        
        // Tüm girdileri kontrol et ve göster
        if (int.TryParse(yasGirdi, out int yas))
        {
            Console.WriteLine($"\nBilgileriniz:");
            Console.WriteLine($"  Ad: {ad ?? "Belirtilmedi"}");
            Console.WriteLine($"  Soyad: {soyad ?? "Belirtilmedi"}");
            Console.WriteLine($"  Yaş: {yas}");
        }
        else
        {
            Console.WriteLine("Yaş bilgisi geçersiz!");
        }
        
        // Döngü ile girdi alma örneği (simüle edilmiş)
        Console.WriteLine("\nDöngü ile girdi alma örneği:");
        string[] ornekGirdiler = { "10", "20", "30", "q" }; // Gerçekte Console.ReadLine()
        
        List<int> sayilar = new List<int>();
        foreach (string girdi in ornekGirdiler)
        {
            if (girdi.ToLower() == "q")
            {
                Console.WriteLine("Çıkış yapıldı!");
                break;
            }
            
            if (int.TryParse(girdi, out int sayi))
            {
                sayilar.Add(sayi);
                Console.WriteLine($"Sayı eklendi: {sayi}");
            }
            else
            {
                Console.WriteLine($"Geçersiz giriş: {girdi}");
            }
        }
        
        if (sayilar.Count > 0)
        {
            Console.WriteLine($"\nToplam {sayilar.Count} sayı girildi: {string.Join(", ", sayilar)}");
        }
    }
}

