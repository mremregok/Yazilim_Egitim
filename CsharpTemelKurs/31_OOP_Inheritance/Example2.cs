namespace _31_OOP_Inheritance;

// Çok seviyeli kalıtım
public static class Example2
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 2: Çok Seviyeli Kalıtım ===");
        
        Kopek kopek = new Kopek();
        kopek.Ad = "Karabas";
        kopek.SesCikar();
    }
}

class Kopek : Hayvan2
{
    public override void SesCikar()
    {
        Console.WriteLine($"{Ad} havlıyor!");
    }
}

class Hayvan2
{
    public string Ad { get; set; } = "";
    
    public virtual void SesCikar()
    {
        Console.WriteLine("Ses çıkarıyor...");
    }
}

