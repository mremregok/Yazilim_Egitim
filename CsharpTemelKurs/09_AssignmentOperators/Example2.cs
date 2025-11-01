namespace _09_AssignmentOperators;

// += ve -= kullanımı
public static class Example2
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 2: += ve -= ===");
        
        int sayi = 10;
        Console.WriteLine($"Başlangıç: {sayi}");
        
        sayi += 5;
        Console.WriteLine($"sayi += 5: {sayi}");
        
        sayi -= 3;
        Console.WriteLine($"sayi -= 3: {sayi}");
    }
}

