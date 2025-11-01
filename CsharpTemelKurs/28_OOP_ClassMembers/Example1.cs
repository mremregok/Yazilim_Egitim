namespace _28_OOP_ClassMembers;

// Özellikler (Properties)
public static class Example1
{
    public static void Run()
    {
        Console.WriteLine("=== Example 1: Özellikler ===");
        
        Urun urun = new Urun();
        urun.Ad = "Laptop";
        urun.Fiyat = 5000;
        
        Console.WriteLine($"Ürün: {urun.Ad}, Fiyat: {urun.Fiyat} TL");
    }
}

class Urun
{
    public string Ad { get; set; } = "";
    public double Fiyat { get; set; }
}

