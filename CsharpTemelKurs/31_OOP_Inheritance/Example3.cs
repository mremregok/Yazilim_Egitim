namespace _31_OOP_Inheritance;

// base kullanımı
public static class Example3
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 3: base Kullanımı ===");
        
        Otomobil otomobil = new Otomobil();
        otomobil.Calistir();
    }
}

class Arac3
{
    protected string Marka { get; set; } = "";
    
    public virtual void Calistir()
    {
        Console.WriteLine("Araç çalışıyor...");
    }
}

class Otomobil : Arac3
{
    public override void Calistir()
    {
        base.Calistir();
        Console.WriteLine("Otomobil çalıştı!");
    }
}

