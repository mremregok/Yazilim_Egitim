namespace _12_MathLibrary;

// Math.Pow, Math.Sqrt, Math.Abs ve diğer matematiksel metotlar
public static class Example3
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 3: Matematiksel Metotlar ===");
        
        // Math.Pow - Üs alma (x^y)
        Console.WriteLine($"Math.Pow(2, 3) = 2^3: {Math.Pow(2, 3)}");
        Console.WriteLine($"Math.Pow(5, 2) = 5^2: {Math.Pow(5, 2)}");
        
        // Math.Sqrt - Karekök alma
        Console.WriteLine($"Math.Sqrt(16): {Math.Sqrt(16)}");
        Console.WriteLine($"Math.Sqrt(25): {Math.Sqrt(25)}");
        
        // Math.Abs - Mutlak değer (negatif ise pozitife çevirir)
        Console.WriteLine($"Math.Abs(-10): {Math.Abs(-10)}");
        Console.WriteLine($"Math.Abs(10): {Math.Abs(10)}");
        
        // Math.Sin, Math.Cos, Math.Tan - Trigonometrik fonksiyonlar (radyan cinsinden)
        double aci = Math.PI / 2; // 90 derece
        Console.WriteLine($"Math.Sin(π/2): {Math.Sin(aci)}");
        Console.WriteLine($"Math.Cos(0): {Math.Cos(0)}");
        
        // Math.Log - Doğal logaritma (e tabanında)
        Console.WriteLine($"Math.Log(Math.E): {Math.Log(Math.E)}");
        
        // Math.PI ve Math.E - Sabitler
        Console.WriteLine($"Math.PI (π): {Math.PI}");
        Console.WriteLine($"Math.E (e): {Math.E}");
    }
}

