namespace _08_ArithmeticOperators;

// Modül operatörü
public static class Example3
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 3: Modül Operatörü ===");
        
        int sayi = 17;
        int bolen = 5;
        
        Console.WriteLine($"{sayi} % {bolen} = {sayi % bolen}");
        Console.WriteLine($"{sayi} / {bolen} = {sayi / bolen} kalan {sayi % bolen}");
    }
}

