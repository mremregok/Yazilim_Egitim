namespace _33_OOP_Abstraction;

// Abstract metod ve somut metod
public static class Example2
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 2: Abstract ve Somut ===");
        
        Sekil3 sekil = new Daire3();
        sekil.Bilgi();
        sekil.Ciz();
    }
}

abstract class Sekil3
{
    public abstract void Ciz();
    
    public void Bilgi()
    {
        Console.WriteLine("Şekil bilgisi...");
    }
}

class Daire3 : Sekil3
{
    public override void Ciz()
    {
        Console.WriteLine("Daire çiziliyor...");
    }
}

