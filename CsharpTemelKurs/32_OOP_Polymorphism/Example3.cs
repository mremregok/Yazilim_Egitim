namespace _32_OOP_Polymorphism;

// virtual ve override
public static class Example3
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 3: virtual/override ===");
        
        Arac4 arac = new Motor();
        arac.HareketEt();
    }
}

class Arac4
{
    public virtual void HareketEt()
    {
        Console.WriteLine("Araç hareket ediyor...");
    }
}

class Motor : Arac4
{
    public override void HareketEt()
    {
        Console.WriteLine("Motor hızla gidiyor!");
    }
}

