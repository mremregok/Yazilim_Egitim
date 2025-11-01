namespace _31_OOP_Inheritance;

// Temel kalıtım
public static class Example1
{
    public static void Run()
    {
        Console.WriteLine("=== Example 1: Temel Kalıtım ===");
        
        Kedi kedi = new Kedi();
        kedi.Ad = "Pamuk";
        kedi.SesCikar();
    }
}

class Hayvan
{
    public string Ad { get; set; } = "";
    
    public virtual void SesCikar()
    {
        Console.WriteLine("Ses çıkarıyor...");
    }
}

class Kedi : Hayvan
{
    public override void SesCikar()
    {
        Console.WriteLine($"{Ad} miyavlıyor!");
    }
}

