namespace _12_MathLibrary;

// Math.Round, Math.Ceiling, Math.Floor - Yuvarlama metotları
public static class Example2
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 2: Yuvarlama Metotları ===");
        
        double sayi1 = 3.7;
        double sayi2 = 3.4;
        double sayi3 = 3.5;
        
        // Math.Round - En yakın tam sayıya yuvarlar (0.5'te yukarı)
        Console.WriteLine($"Math.Round({sayi1}): {Math.Round(sayi1)}");
        Console.WriteLine($"Math.Round({sayi2}): {Math.Round(sayi2)}");
        Console.WriteLine($"Math.Round({sayi3}): {Math.Round(sayi3)}");
        
        // Math.Round - Belirtilen ondalık basamak sayısına yuvarlar
        double sayi4 = 3.14159;
        Console.WriteLine($"Math.Round({sayi4}, 2): {Math.Round(sayi4, 2)}");
        
        // Math.Ceiling - Her zaman yukarı yuvarlar (tavan)
        Console.WriteLine($"Math.Ceiling({sayi1}): {Math.Ceiling(sayi1)}");
        Console.WriteLine($"Math.Ceiling({sayi2}): {Math.Ceiling(sayi2)}");
        
        // Math.Floor - Her zaman aşağı yuvarlar (taban)
        Console.WriteLine($"Math.Floor({sayi1}): {Math.Floor(sayi1)}");
        Console.WriteLine($"Math.Floor({sayi2}): {Math.Floor(sayi2)}");
    }
}

