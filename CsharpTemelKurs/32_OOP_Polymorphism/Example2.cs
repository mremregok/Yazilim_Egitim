namespace _32_OOP_Polymorphism;

// Çok biçimlilik örneği
public static class Example2
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 2: Polymorphism ===");
        
        Sekil2[] sekiller = { new Ucgen(), new Kare() };
        
        foreach (var sekil in sekiller)
        {
            sekil.Ciz();
        }
    }
}

class Sekil2
{
    public virtual void Ciz()
    {
        Console.WriteLine("Şekil çiziliyor...");
    }
}

class Ucgen : Sekil2
{
    public override void Ciz()
    {
        Console.WriteLine("Üçgen çiziliyor...");
    }
}

class Kare : Sekil2
{
    public override void Ciz()
    {
        Console.WriteLine("Kare çiziliyor...");
    }
}

