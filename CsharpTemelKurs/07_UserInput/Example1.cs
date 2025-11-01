namespace _07_UserInput;

// Console.ReadLine ile string girişi - Temel kullanım
public static class Example1
{
    public static void Run()
    {
        Console.WriteLine("=== Example 1: Console.ReadLine - String Girişi ===");
        
        // Console.ReadLine() - Kullanıcıdan satır girişi alır, string? döner (null olabilir)
        Console.Write("İsminizi girin: ");
        string? isim = Console.ReadLine();
        
        // Null kontrolü - ?? operatörü ile varsayılan değer
        Console.WriteLine($"Merhaba {isim ?? "Misafir"}!");
        
        // Console.ReadKey() - Tek tuş okur (Enter'a gerek yok)
        Console.Write("\nDevam etmek için bir tuşa basın...");
        Console.ReadKey();
        Console.WriteLine();
        
        // Console.Read() - Tek karakter okur, ASCII kodu döner
        Console.Write("Bir karakter girin: ");
        int karakterKodu = Console.Read();
        Console.WriteLine($"ASCII kodu: {karakterKodu}, Karakter: {(char)karakterKodu}");
    }
}

