namespace _34_OOP_Interfaces;

// Interface tanımlama
public static class Example1
{
    public static void Run()
    {
        Console.WriteLine("=== Example 1: Interface ===");
        
        IDosyaYazdirici yazici = new DosyaYazdirici();
        yazici.Yazdir("test.txt", "Merhaba");
    }
}

interface IDosyaYazdirici
{
    void Yazdir(string dosya, string icerik);
}

class DosyaYazdirici : IDosyaYazdirici
{
    public void Yazdir(string dosya, string icerik)
    {
        Console.WriteLine($"{dosya} dosyasına yazılıyor: {icerik}");
    }
}

