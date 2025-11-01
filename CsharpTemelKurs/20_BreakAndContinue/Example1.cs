namespace _20_BreakAndContinue;

// break kullanımı
public static class Example1
{
    public static void Run()
    {
        Console.WriteLine("=== Example 1: break ===");
        
        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
            {
                break;
            }
            Console.WriteLine($"i = {i}");
        }
    }
}

