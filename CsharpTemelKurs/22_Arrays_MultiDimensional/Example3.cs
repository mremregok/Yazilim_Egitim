namespace _22_Arrays_MultiDimensional;

// Jagged Array (Dişli dizi)
public static class Example3
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 3: Jagged Array ===");
        
        int[][] jagged = new int[3][];
        jagged[0] = new int[] { 1, 2 };
        jagged[1] = new int[] { 3, 4, 5 };
        jagged[2] = new int[] { 6 };
        
        for (int i = 0; i < jagged.Length; i++)
        {
            Console.Write($"Satır {i}: ");
            foreach (int deger in jagged[i])
            {
                Console.Write($"{deger} ");
            }
            Console.WriteLine();
        }
    }
}

