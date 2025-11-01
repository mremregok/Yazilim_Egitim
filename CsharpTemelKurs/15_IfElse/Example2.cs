namespace _15_IfElse;

// if-else
public static class Example2
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 2: if-else ===");
        
        int sayi = 3;
        
        if (sayi > 5)
        {
            Console.WriteLine($"{sayi} 5'ten büyük");
        }
        else
        {
            Console.WriteLine($"{sayi} 5'ten küçük veya eşit");
        }
    }
}

