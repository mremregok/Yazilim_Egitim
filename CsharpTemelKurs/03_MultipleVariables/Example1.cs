namespace _03_MultipleVariables;

// Birden fazla değişken aynı türde tanımlama
public static class Example1
{
    public static void Run()
    {
        Console.WriteLine("=== Example 1: Aynı Türde Birden Fazla Değişken ===");
        
        int sayi1, sayi2, sayi3;
        sayi1 = 10;
        sayi2 = 20;
        sayi3 = 30;
        
        Console.WriteLine($"Sayı 1: {sayi1}");
        Console.WriteLine($"Sayı 2: {sayi2}");
        Console.WriteLine($"Sayı 3: {sayi3}");
    }
}

