namespace _06_TypeCasting;

// Örtük (Implicit) dönüşüm
public static class Example1
{
    public static void Run()
    {
        Console.WriteLine("=== Example 1: Örtük Dönüşüm ===");
        
        int sayi = 100;
        long uzunSayi = sayi;      // Otomatik dönüşüm
        float ondalik = sayi;      // Otomatik dönüşüm
        
        Console.WriteLine($"int: {sayi}");
        Console.WriteLine($"long: {uzunSayi}");
        Console.WriteLine($"float: {ondalik}");
    }
}

