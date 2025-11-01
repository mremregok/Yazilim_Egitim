namespace _18_ForLoop;

// İç içe for
public static class Example2
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 2: İç İçe for ===");
        
        for (int i = 1; i <= 3; i++)
        {
            for (int j = 1; j <= 3; j++)
            {
                Console.Write($"({i},{j}) ");
            }
            Console.WriteLine();
        }
    }
}

