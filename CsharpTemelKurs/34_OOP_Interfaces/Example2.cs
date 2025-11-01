namespace _34_OOP_Interfaces;

// Çoklu interface
public static class Example2
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 2: Çoklu Interface ===");
        
        Telefon telefon = new Telefon();
        telefon.Ara();
        telefon.MesajGonder();
    }
}

interface ITelefon
{
    void Ara();
}

interface IMesajlasma
{
    void MesajGonder();
}

class Telefon : ITelefon, IMesajlasma
{
    public void Ara()
    {
        Console.WriteLine("Aranıyor...");
    }
    
    public void MesajGonder()
    {
        Console.WriteLine("Mesaj gönderiliyor...");
    }
}

