namespace _01_Variables;

// var kullanımı ile tip çıkarımı
public static class Example2
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 2: var ile Tip Çıkarımı ===");
        
        var yas = 25;              // int olarak çıkarılır
        var metin = "Merhaba";     // string olarak çıkarılır
        var pi = 3.14;             // double olarak çıkarılır
        
        Console.WriteLine($"Yaş (int): {yas}");
        Console.WriteLine($"Metin (string): {metin}");
        Console.WriteLine($"Pi (double): {pi}");
    }
}

