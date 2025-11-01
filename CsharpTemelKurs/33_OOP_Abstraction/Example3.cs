namespace _33_OOP_Abstraction;

// Abstract property
public static class Example3
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 3: Abstract Property ===");
        
        Arac5 arac = new Araba5();
        Console.WriteLine($"Marka: {arac.Marka}");
    }
}

abstract class Arac5
{
    public abstract string Marka { get; }
}

class Araba5 : Arac5
{
    public override string Marka => "Toyota";
}

