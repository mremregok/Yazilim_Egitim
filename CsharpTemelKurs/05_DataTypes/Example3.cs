namespace _05_DataTypes;

// Diğer temel türler
public static class Example3
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 3: Diğer Türler ===");
        
        char karakter = 'A';
        string metin = "Merhaba C#";
        bool dogruMu = true;
        object obj = 42;
        
        Console.WriteLine($"char: {karakter}");
        Console.WriteLine($"string: {metin}");
        Console.WriteLine($"bool: {dogruMu}");
        Console.WriteLine($"object: {obj}");
    }
}

