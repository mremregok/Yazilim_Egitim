namespace _05_DataTypes;

// Tamsayı türleri
public static class Example1
{
    public static void Run()
    {
        Console.WriteLine("=== Example 1: Tamsayı Türleri ===");
        
        byte b = 255;
        short s = -32768;
        int i = 2147483647;
        long l = 9223372036854775807L;
        
        Console.WriteLine($"byte: {b}");
        Console.WriteLine($"short: {s}");
        Console.WriteLine($"int: {i}");
        Console.WriteLine($"long: {l}");
    }
}

