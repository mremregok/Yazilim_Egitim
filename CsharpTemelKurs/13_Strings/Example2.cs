namespace _13_Strings;

// String interpolation ($"") ve formatlama
public static class Example2
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 2: String Interpolation ve Formatlama ===");
        
        // String interpolation ($"") - C# 6.0+
        string isim = "Ahmet";
        int yas = 25;
        double maas = 5000.50;
        
        string mesaj = $"İsim: {isim}, Yaş: {yas}, Maaş: {maas:C}";
        Console.WriteLine($"Interpolation: {mesaj}");
        
        // string.Format metodu ile formatlama
        string formatli = string.Format("İsim: {0}, Yaş: {1}, Maaş: {2:C}", isim, yas, maas);
        Console.WriteLine($"string.Format: {formatli}");
        
        // ToString ile formatlama
        string sayiFormatli = maas.ToString("C");
        Console.WriteLine($"ToString formatı (Para): {sayiFormatli}");
    }
}

