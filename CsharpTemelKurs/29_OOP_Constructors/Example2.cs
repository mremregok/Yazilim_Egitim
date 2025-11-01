namespace _29_OOP_Constructors;

// Parametreli constructor
public static class Example2
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 2: Parametreli Constructor ===");
        
        Dikdortgen dikdortgen = new Dikdortgen(10, 5);
        Console.WriteLine($"Dikdörtgen: {dikdortgen.Genislik}x{dikdortgen.Yukseklik}");
    }
}

class Dikdortgen
{
    public int Genislik { get; set; }
    public int Yukseklik { get; set; }
    
    public Dikdortgen(int genislik, int yukseklik)
    {
        Genislik = genislik;
        Yukseklik = yukseklik;
    }
}

