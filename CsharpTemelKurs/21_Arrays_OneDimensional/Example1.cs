namespace _21_Arrays_OneDimensional;

// Tek boyutlu dizi tanımlama ve başlatma yöntemleri
public static class Example1
{
    public static void Run()
    {
        Console.WriteLine("=== Example 1: Dizi Tanımlama Yöntemleri ===");
        
        // Yöntem 1: Değerlerle birlikte tanımlama
        int[] sayilar1 = { 10, 20, 30, 40, 50 };
        Console.WriteLine("Yöntem 1 - Değerlerle:");
        foreach (int sayi in sayilar1)
        {
            Console.WriteLine($"  Sayı: {sayi}");
        }
        
        // Yöntem 2: new ile boş dizi oluşturma (tüm elemanlar varsayılan değer)
        int[] sayilar2 = new int[5];
        Console.WriteLine("\nYöntem 2 - Boş dizi (new int[5]):");
        Console.WriteLine($"  Uzunluk: {sayilar2.Length}");
        
        // Yöntem 3: new ile değerlerle
        int[] sayilar3 = new int[] { 1, 2, 3 };
        Console.WriteLine("\nYöntem 3 - new int[] ile:");
        foreach (int sayi in sayilar3)
        {
            Console.WriteLine($"  Sayı: {sayi}");
        }
    }
}

