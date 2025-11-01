namespace _27_OOP_ClassesAndObjects;

// Basit sınıf tanımlama
public static class Example1
{
    public static void Run()
    {
        Console.WriteLine("=== Example 1: Sınıf Tanımlama ===");
        
        Ogrenci ogr = new Ogrenci();
        ogr.Isim = "Ali";
        ogr.Yas = 20;
        
        Console.WriteLine($"İsim: {ogr.Isim}, Yaş: {ogr.Yas}");
    }
}

class Ogrenci
{
    public string Isim { get; set; } = "";
    public int Yas { get; set; }
}

