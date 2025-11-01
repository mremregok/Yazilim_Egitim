namespace _22_Arrays_MultiDimensional;

// Üç boyutlu dizi
public static class Example2
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 2: Üç Boyutlu Dizi ===");
        
        int[,,] ucBoyutlu = new int[2, 2, 2];
        ucBoyutlu[0, 0, 0] = 1;
        ucBoyutlu[1, 1, 1] = 8;
        
        Console.WriteLine($"Boyutlar: {ucBoyutlu.GetLength(0)}x{ucBoyutlu.GetLength(1)}x{ucBoyutlu.GetLength(2)}");
        Console.WriteLine($"Eleman[0,0,0]: {ucBoyutlu[0, 0, 0]}");
        Console.WriteLine($"Eleman[1,1,1]: {ucBoyutlu[1, 1, 1]}");
    }
}

