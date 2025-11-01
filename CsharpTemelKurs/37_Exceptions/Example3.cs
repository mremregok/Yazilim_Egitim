namespace _37_Exceptions;

// Exception fırlatma (throw) ve özel exception oluşturma
public static class Example3
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 3: Exception Fırlatma (throw) ===");
        
        // throw - Hata fırlatma, program akışını keser
        try
        {
            GuvenliBolme(10, 0);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Yakalanan hata: {ex.Message}");
        }
        
        // Başarılı durum
        try
        {
            int sonuc = GuvenliBolme(10, 2);
            Console.WriteLine($"Bölme sonucu: {sonuc}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Hata: {ex.Message}");
        }
        
        // Özel hata kontrolü
        try
        {
            YasKontrol(200); // Geçersiz yaş
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Yaş kontrolü hatası: {ex.Message}");
        }
    }
    
    // throw ile exception fırlatma
    // throw new ExceptionType("Mesaj") - Yeni exception oluşturup fırlatır
    private static int GuvenliBolme(int a, int b)
    {
        if (b == 0)
        {
            // throw - Bu noktada metot sonlanır, hata yukarıya fırlatılır
            throw new ArgumentException("Sıfıra bölme hatası! Bölen sıfır olamaz.");
        }
        return a / b;
    }
    
    // Özel koşul kontrolü ile exception
    private static void YasKontrol(int yas)
    {
        if (yas < 0 || yas > 150)
        {
            // ArgumentOutOfRangeException - Aralık dışı değer hatası
            throw new ArgumentOutOfRangeException(nameof(yas), "Yaş 0-150 arasında olmalıdır!");
        }
        Console.WriteLine($"Geçerli yaş: {yas}");
    }
}

