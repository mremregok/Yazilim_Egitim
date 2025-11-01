namespace _20_BreakAndContinue;

// break ve continue kombinasyonu
public static class Example3
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 3: break ve continue ===");
        
        int sayac = 0;
        while (true)
        {
            sayac++;
            if (sayac > 10)
            {
                break;
            }
            if (sayac % 2 == 0)
            {
                continue;
            }
            Console.WriteLine($"Tek sayı: {sayac}");
        }
    }
}

