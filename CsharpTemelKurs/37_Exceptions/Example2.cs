namespace _37_Exceptions;

// try-catch-finally - Finally bloğu her zaman çalışır
public static class Example2
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 2: try-catch-finally ===");
        
        // Finally - Hata olsun ya da olmasın her zaman çalışır
        // Genellikle temizlik işlemleri için kullanılır (dosya kapatma, bağlantı kapatma, vb.)
        
        try
        {
            int[] dizi = { 1, 2, 3 };
            Console.WriteLine($"Dizi elemanı: {dizi[10]}");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"Hata yakalandı: {ex.Message}");
        }
        finally
        {
            // Hata olsa da olmasa da bu kod her zaman çalışır
            Console.WriteLine("Finally bloğu çalıştı - Temizlik yapılıyor");
        }
        
        // Hata olmayan durumda da finally çalışır
        Console.WriteLine("\nHata olmayan durum:");
        try
        {
            int sayi = 10;
            Console.WriteLine($"Sayı: {sayi}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Hata: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Finally bloğu yine de çalıştı");
        }
    }
}

