namespace _06_TypeCasting;

// Convert, Parse ve TryParse - String'den sayıya dönüşüm
public static class Example3
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 3: Convert, Parse ve TryParse ===");
        
        string sayiMetin = "123";
        
        // Convert.ToInt32 - String'i int'e dönüştürür (hata fırlatabilir)
        int sayi1 = Convert.ToInt32(sayiMetin);
        Console.WriteLine($"Convert.ToInt32(\"{sayiMetin}\"): {sayi1}");
        
        // int.Parse - String'i int'e parse eder (hata fırlatabilir)
        int sayi2 = int.Parse(sayiMetin);
        Console.WriteLine($"int.Parse(\"{sayiMetin}\"): {sayi2}");
        
        // TryParse - Güvenli dönüşüm (hata fırlatmaz, true/false döner)
        // out parametresi ile sonucu döndürür
        if (int.TryParse("456", out int sayi3))
        {
            Console.WriteLine($"TryParse başarılı: {sayi3}");
        }
        else
        {
            Console.WriteLine("TryParse başarısız");
        }
        
        // TryParse ile hatalı durum
        string hataliGiris = "abc";
        if (int.TryParse(hataliGiris, out int sayi4))
        {
            Console.WriteLine($"Sayı: {sayi4}");
        }
        else
        {
            Console.WriteLine($"'{hataliGiris}' geçerli bir sayı değil");
        }
        
        // Double dönüşümleri
        string ondalikMetin = "123.45";
        double ondalik1 = Convert.ToDouble(ondalikMetin);
        double ondalik2 = double.Parse(ondalikMetin);
        Console.WriteLine($"Convert.ToDouble: {ondalik1}");
        Console.WriteLine($"double.Parse: {ondalik2}");
        
        // ToString - Her tür string'e dönüştürülebilir
        int sayi5 = 999;
        string sayiString = sayi5.ToString();
        Console.WriteLine($"ToString(): {sayiString}");
        Console.WriteLine($"ToString(\"C\") - Para formatı: {sayi5.ToString("C")}");
        Console.WriteLine($"ToString(\"N\") - Sayı formatı: {sayi5.ToString("N")}");
    }
}

