namespace _34_OOP_Interfaces;

// Interface property
public static class Example3
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 3: Interface Property ===");
        
        IUye uye = new Uye();
        uye.Ad = "Ahmet";
        Console.WriteLine($"Üye adı: {uye.Ad}");
    }
}

interface IUye
{
    string Ad { get; set; }
}

class Uye : IUye
{
    public string Ad { get; set; } = "";
}

