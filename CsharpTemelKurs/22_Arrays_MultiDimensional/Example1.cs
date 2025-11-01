namespace _22_Arrays_MultiDimensional;

// İki boyutlu dizi
public static class Example1
{
    public static void Run()
    {
        Console.WriteLine("=== Example 1: İki Boyutlu Dizi ===");
        
        int[,] matris = {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };
        
        for (int i = 0; i < matris.GetLength(0); i++)
        {
            for (int j = 0; j < matris.GetLength(1); j++)
            {
                Console.Write($"{matris[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}

