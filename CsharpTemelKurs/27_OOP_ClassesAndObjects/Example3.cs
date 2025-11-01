namespace _27_OOP_ClassesAndObjects;

// Birden fazla nesne
public static class Example3
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 3: Çoklu Nesneler ===");
        
        Kisi kisi1 = new Kisi { Ad = "Ahmet", Soyad = "Yılmaz" };
        Kisi kisi2 = new Kisi { Ad = "Ayşe", Soyad = "Demir" };
        
        Console.WriteLine($"Kişi 1: {kisi1.Ad} {kisi1.Soyad}");
        Console.WriteLine($"Kişi 2: {kisi2.Ad} {kisi2.Soyad}");
    }
}

class Kisi
{
    public string Ad { get; set; } = "";
    public string Soyad { get; set; } = "";
}

