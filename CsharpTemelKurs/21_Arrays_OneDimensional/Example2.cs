namespace _21_Arrays_OneDimensional;

// Dizi elemanlarına erişim ve değiştirme
public static class Example2
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 2: Dizi Elemanlarına Erişim ===");
        
        int[] sayilar = { 10, 20, 30, 40, 50 };
        
        // İlk elemana erişim (indis 0'dan başlar)
        Console.WriteLine($"İlk eleman [0]: {sayilar[0]}");
        
        // Son elemana erişim (Length - 1)
        Console.WriteLine($"Son eleman [{sayilar.Length - 1}]: {sayilar[sayilar.Length - 1]}");
        
        // Belirli bir elemana erişim
        Console.WriteLine($"Üçüncü eleman [2]: {sayilar[2]}");
        
        // Eleman değiştirme
        sayilar[1] = 25;
        Console.WriteLine($"Değiştirilmiş [1]: {sayilar[1]}");
        
        // Döngü ile tüm elemanlara erişim
        Console.WriteLine("\nTüm elemanlar:");
        for (int i = 0; i < sayilar.Length; i++)
        {
            Console.WriteLine($"  [{i}] = {sayilar[i]}");
        }
    }
}

