namespace _21_Arrays_OneDimensional;

// Dizi metotları - Array.Sort, Array.Reverse, Array.Copy, Array.IndexOf, vb.
public static class Example3
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 3: Dizi Metotları ===");
        
        int[] sayilar = { 30, 10, 50, 20, 40 };
        
        // Length - Dizi uzunluğu
        Console.WriteLine($"Dizi uzunluğu (Length): {sayilar.Length}");
        
        // Array.Sort - Diziyi küçükten büyüğe sıralar
        Console.WriteLine("\nOrijinal dizi:");
        foreach (int sayi in sayilar)
        {
            Console.Write($"{sayi} ");
        }
        
        Array.Sort(sayilar);
        Console.WriteLine("\nArray.Sort sonrası:");
        foreach (int sayi in sayilar)
        {
            Console.Write($"{sayi} ");
        }
        
        // Array.Reverse - Diziyi tersine çevirir
        Array.Reverse(sayilar);
        Console.WriteLine("\nArray.Reverse sonrası:");
        foreach (int sayi in sayilar)
        {
            Console.Write($"{sayi} ");
        }
        
        // Array.IndexOf - Elemanın bulunduğu ilk pozisyonu döner (-1 bulunamazsa)
        int pozisyon = Array.IndexOf(sayilar, 30);
        Console.WriteLine($"\nArray.IndexOf(30): {pozisyon}");
        
        // Array.Find - Koşula uyan ilk elemanı bulur
        int bulunan = Array.Find(sayilar, x => x > 25);
        Console.WriteLine($"Array.Find(x => x > 25): {bulunan}");
        
        // Array.Copy - Diziyi kopyalar
        int[] kopya = new int[sayilar.Length];
        Array.Copy(sayilar, kopya, sayilar.Length);
        Console.WriteLine($"\nKopyalanmış dizi uzunluğu: {kopya.Length}");
        
        // Array.Clear - Belirli aralıktaki elemanları temizler (0 yapar)
        int[] temizlenecek = { 1, 2, 3, 4, 5 };
        Array.Clear(temizlenecek, 1, 2); // İndis 1'den başlayarak 2 eleman
        Console.WriteLine("Array.Clear(1, 2) sonrası:");
        foreach (int sayi in temizlenecek)
        {
            Console.Write($"{sayi} ");
        }
    }
}

