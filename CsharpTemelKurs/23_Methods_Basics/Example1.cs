namespace _23_Methods_Basics;

// Metot tanımlama ve çağırma - Temel yapı
public static class Example1
{
    public static void Run()
    {
        Console.WriteLine("=== Example 1: Metot Tanımlama ve Çağırma ===");
        
        // Metot çağırma - Sadece metot adını yazarak
        MerhabaYaz();
        
        // Başka bir metot çağırma
        ToplamaYap(10, 20);
    }
    
    // Metot tanımlama:
    // erişim_modifier static dönüş_tipi MetotAdı() { ... }
    // private - Sadece bu sınıf içinden erişilebilir
    // static - Sınıf seviyesinde, nesne oluşturmadan çağrılabilir
    // void - Değer döndürmez
    private static void MerhabaYaz()
    {
        Console.WriteLine("Merhaba C#!");
    }
    
    // Parametreli metot örneği
    private static void ToplamaYap(int sayi1, int sayi2)
    {
        int sonuc = sayi1 + sayi2;
        Console.WriteLine($"{sayi1} + {sayi2} = {sonuc}");
    }
}

