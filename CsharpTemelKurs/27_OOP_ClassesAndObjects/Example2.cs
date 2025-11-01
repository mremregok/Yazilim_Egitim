namespace _27_OOP_ClassesAndObjects;

// Nesne oluşturma
public static class Example2
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 2: Nesne Oluşturma ===");
        
        Araba araba = new Araba();
        araba.Marka = "Toyota";
        araba.Model = "Corolla";
        
        Console.WriteLine($"Marka: {araba.Marka}, Model: {araba.Model}");
    }
}

class Araba
{
    public string Marka { get; set; } = "";
    public string Model { get; set; } = "";
}

