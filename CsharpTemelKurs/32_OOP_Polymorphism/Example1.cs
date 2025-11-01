namespace _32_OOP_Polymorphism;

// Metot override
public static class Example1
{
    public static void Run()
    {
        Console.WriteLine("=== Example 1: Override ===");
        
        Sekil sekil = new Daire();
        sekil.Ciz();
    }
}

class Sekil
{
    public virtual void Ciz()
    {
        Console.WriteLine("Şekil çiziliyor...");
    }
}

class Daire : Sekil
{
    public override void Ciz()
    {
        Console.WriteLine("Daire çiziliyor...");
    }
}

