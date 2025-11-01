namespace _29_OOP_Constructors;

// Varsayılan constructor
public static class Example1
{
    public static void Run()
    {
        Console.WriteLine("=== Example 1: Varsayılan Constructor ===");
        
        Kutu kutu = new Kutu();
        Console.WriteLine($"Kutu oluşturuldu: {kutu.Genislik}x{kutu.Yukseklik}");
    }
}

class Kutu
{
    public int Genislik { get; set; }
    public int Yukseklik { get; set; }
}

