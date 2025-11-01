namespace _12_MathLibrary;

// Math.Max ve Math.Min - İki değer arasından maksimum ve minimum bulma
public static class Example1
{
    public static void Run()
    {
        Console.WriteLine("=== Example 1: Math.Max ve Math.Min ===");
        
        int a = 10;
        int b = 20;
        int c = 15;
        
        // Math.Max - İki değerden büyük olanı döner
        Console.WriteLine($"Math.Max({a}, {b}): {Math.Max(a, b)}");
        
        // Math.Min - İki değerden küçük olanı döner
        Console.WriteLine($"Math.Min({a}, {b}): {Math.Min(a, b)}");
        
        // Üç değer karşılaştırması (iç içe kullanım)
        int enBuyuk = Math.Max(a, Math.Max(b, c));
        int enKucuk = Math.Min(a, Math.Min(b, c));
        Console.WriteLine($"Üç değerden en büyük: {enBuyuk}");
        Console.WriteLine($"Üç değerden en küçük: {enKucuk}");
        
        // Double ve float için de kullanılabilir
        double d1 = 10.5;
        double d2 = 20.7;
        Console.WriteLine($"Math.Max(double): {Math.Max(d1, d2)}");
    }
}

