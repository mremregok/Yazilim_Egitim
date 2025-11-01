namespace _23_Methods_Basics;

// void metotlar ve parametreli metotlar
public static class Example3
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 3: void Metotlar ve Parametreler ===");
        
        // Tek parametreli metot çağırma
        MesajYaz("C# Dersi");
        
        // Çoklu parametreli metot çağırma
        BilgiYaz("Ahmet", 25);
        
        // void metot - Değer döndürmez, sadece işlem yapar
        IslemYap();
    }
    
    // void metot - Değer döndürmez (return yok veya return; şeklinde)
    // string mesaj - Parametre, metot çağrılırken değer verilir
    private static void MesajYaz(string mesaj)
    {
        Console.WriteLine($"Mesaj: {mesaj}");
    }
    
    // Çoklu parametreli metot
    private static void BilgiYaz(string isim, int yas)
    {
        Console.WriteLine($"İsim: {isim}, Yaş: {yas}");
    }
    
    // void metot - Erken çıkış için return kullanılabilir
    private static void IslemYap()
    {
        Console.WriteLine("İşlem başlıyor...");
        
        // Koşula göre erken çıkış
        if (true)
        {
            return; // Metottan çıkar, aşağıdaki kod çalışmaz
        }
        
        Console.WriteLine("Bu satır çalışmaz");
    }
}

