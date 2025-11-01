namespace _24_Methods_Parameters;

// ref parametreler - Referans ile geçiş, orijinal değer değişir
public static class Example2
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 2: ref Parametreler (Referans ile Geçiş) ===");
        
        int sayi = 10;
        Console.WriteLine($"Metot çağrısından önce: {sayi}");
        
        // ref - Orijinal değişkene referans geçirilir
        // Çağrıda ref anahtar kelimesi zorunludur
        DegerDegistirRef(ref sayi);
        
        Console.WriteLine($"Metot çağrısından sonra: {sayi} (değişti!)");
        
        // ref ile iki değeri değiştirme örneği
        int a = 5;
        int b = 10;
        Console.WriteLine($"\nSwap öncesi: a={a}, b={b}");
        DegisTokus(ref a, ref b);
        Console.WriteLine($"Swap sonrası: a={a}, b={b}");
    }
    
    // ref parametre - Orijinal değişkene referans geçirilir
    // Metot içinde değer değiştirilirse orijinal değişken de değişir
    // Çağrıda "ref" anahtar kelimesi zorunludur
    private static void DegerDegistirRef(ref int deger)
    {
        deger = 100; // Orijinal değişken değişir!
    }
    
    // ref ile iki değeri değiştirme (swap)
    private static void DegisTokus(ref int x, ref int y)
    {
        int gecici = x;
        x = y;
        y = gecici;
    }
}

