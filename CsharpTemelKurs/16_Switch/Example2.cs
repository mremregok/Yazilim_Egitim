namespace _16_Switch;

// Default case
public static class Example2
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 2: Default Case ===");
        
        int sayi = 10;
        
        switch (sayi)
        {
            case 1:
            case 2:
            case 3:
                Console.WriteLine("Küçük sayı");
                break;
            default:
                Console.WriteLine("Bilinmeyen sayı");
                break;
        }
    }
}

