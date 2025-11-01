namespace _06_TypeCasting;

// Açık (Explicit) dönüşüm
public static class Example2
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 2: Açık Dönüşüm ===");
        
        double ondalik = 9.99;
        int tamSayi = (int)ondalik;  // Cast gerekli
        
        Console.WriteLine($"double: {ondalik}");
        Console.WriteLine($"int (cast): {tamSayi}");
    }
}

