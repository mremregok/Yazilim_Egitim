namespace _25_Methods_ReturnValues;

// String ve diğer referans tipler döndürme
public static class Example2
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 2: String ve Referans Tip Dönüşümleri ===");
        
        // String döndüren metot
        string mesaj = Selamla("Ahmet");
        Console.WriteLine($"Selamla: {mesaj}");
        
        // String formatlama ile dönüş
        string bilgi = BilgiOlustur("Ali", 25);
        Console.WriteLine($"BilgiOlustur: {bilgi}");
        
        // Boş string kontrolü ile dönüş
        string sonuc = BosKontrol("");
        Console.WriteLine($"BosKontrol(\"\") = '{sonuc}'");
        
        // Dizi döndüren metot
        int[] sayilar = SayiDizisiOlustur(1, 5);
        Console.WriteLine($"SayiDizisiOlustur: [{string.Join(", ", sayilar)}]");
    }
    
    // String döndüren metot
    private static string Selamla(string isim)
    {
        // return ile string döndürülür
        return $"Merhaba {isim}!";
    }
    
    // String birleştirme ile dönüş
    private static string BilgiOlustur(string ad, int yas)
    {
        return $"İsim: {ad}, Yaş: {yas}";
    }
    
    // Koşullu string dönüş
    private static string BosKontrol(string metin)
    {
        // string.IsNullOrEmpty - Boş veya null kontrolü
        if (string.IsNullOrEmpty(metin))
        {
            return "Boş"; // Erken return
        }
        
        return $"Değer: {metin}";
    }
    
    // Dizi döndüren metot
    private static int[] SayiDizisiOlustur(int baslangic, int bitis)
    {
        List<int> liste = new List<int>();
        for (int i = baslangic; i <= bitis; i++)
        {
            liste.Add(i);
        }
        return liste.ToArray(); // List'i diziye çevir ve döndür
    }
}

