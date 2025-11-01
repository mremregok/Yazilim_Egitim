namespace _09_AssignmentOperators;

// *= ve /= kullanımı
public static class Example3
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 3: *= ve /= ===");
        
        int sayi = 10;
        Console.WriteLine($"Başlangıç: {sayi}");
        
        sayi *= 2;
        Console.WriteLine($"sayi *= 2: {sayi}");
        
        sayi /= 4;
        Console.WriteLine($"sayi /= 4: {sayi}");
    }
}

