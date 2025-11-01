namespace _02_Constants;

// const ile sabit tanımlama
public static class Example1
{
    public static void Run()
    {
        Console.WriteLine("=== Example 1: const ile Sabitler ===");
        
        const double PI = 3.14159;
        const string UYGULAMA_ADI = "C# Temel Kursu";
        
        Console.WriteLine($"Pi sabiti: {PI}");
        Console.WriteLine($"Uygulama adı: {UYGULAMA_ADI}");
        
        // PI = 3.14; // HATA: const değer değiştirilemez
    }
}

