namespace _07_UserInput;

// Sayısal girdi alma - int, double, decimal
public static class Example2
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 2: Sayısal Giriş ===");
        
        // int girişi - TryParse ile güvenli dönüşüm
        Console.Write("Bir tam sayı girin: ");
        string? girdi = Console.ReadLine();
        
        // int.TryParse - Güvenli dönüşüm, başarılı olursa true ve out parametresine değer atar
        if (int.TryParse(girdi, out int sayi))
        {
            Console.WriteLine($"Girdiğiniz tam sayı: {sayi}");
        }
        else
        {
            Console.WriteLine("Geçersiz tam sayı! Lütfen sadece rakam girin.");
        }
        
        // double girişi
        Console.Write("\nBir ondalıklı sayı girin (örn: 3.14): ");
        string? ondalikGirdi = Console.ReadLine();
        
        // double.TryParse - Ondalıklı sayı dönüşümü
        // NumberStyles ve CultureInfo ile kültüre duyarlı dönüşüm
        if (double.TryParse(ondalikGirdi, System.Globalization.NumberStyles.Float, 
            System.Globalization.CultureInfo.InvariantCulture, out double ondalik))
        {
            Console.WriteLine($"Girdiğiniz ondalıklı sayı: {ondalik}");
        }
        else
        {
            Console.WriteLine("Geçersiz ondalıklı sayı!");
        }
        
        // int.Parse - Hata fırlatabilir (TryParse daha güvenli)
        // int.Parse kullanırken try-catch kullanılmalı
        Console.Write("\nParse ile (hata fırlatabilir): ");
        string? parseGirdi = Console.ReadLine();
        try
        {
            int parseSonuc = int.Parse(parseGirdi ?? "0");
            Console.WriteLine($"Parse sonucu: {parseSonuc}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Parse hatası: Geçersiz format!");
        }
    }
}

