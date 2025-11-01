namespace _13_Strings;

// String metotları - Contains, Split, Replace, Substring, IndexOf, vb.
public static class Example3
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 3: String Metotları ===");
        
        string metin = "  Merhaba C# Dünyası  ";
        
        // Length - String uzunluğu
        Console.WriteLine($"Length: {metin.Length}");
        
        // ToUpper / ToLower - Büyük/küçük harf dönüşümü
        Console.WriteLine($"ToUpper: {metin.ToUpper()}");
        Console.WriteLine($"ToLower: {metin.ToLower()}");
        
        // Trim - Baş ve sondaki boşlukları temizler
        Console.WriteLine($"Trim: '{metin.Trim()}'");
        
        // Contains - String içinde arama (true/false döner)
        bool iceriyor = metin.Contains("C#");
        Console.WriteLine($"Contains(\"C#\"): {iceriyor}");
        
        // IndexOf - Karakter veya string'in ilk bulunduğu pozisyonu döner (-1 bulunamazsa)
        int pozisyon = metin.IndexOf("C#");
        Console.WriteLine($"IndexOf(\"C#\"): {pozisyon}");
        
        // LastIndexOf - Son bulunduğu pozisyon
        int sonPozisyon = metin.LastIndexOf("a");
        Console.WriteLine($"LastIndexOf('a'): {sonPozisyon}");
        
        // Substring - Belirtilen pozisyondan itibaren string alır
        string altMetin = metin.Trim().Substring(8, 2);
        Console.WriteLine($"Substring(8, 2): '{altMetin}'");
        
        // Replace - String içindeki kısmı değiştirir
        string yeniMetin = metin.Replace("C#", "CSharp");
        Console.WriteLine($"Replace(\"C#\", \"CSharp\"): {yeniMetin.Trim()}");
        
        // Split - String'i belirtilen karaktere göre böler
        string[] kelimeler = metin.Trim().Split(' ');
        Console.WriteLine($"Split(' '): [{string.Join(", ", kelimeler)}]");
        
        // StartsWith / EndsWith - Başlangıç/bitiş kontrolü
        bool basliyor = metin.Trim().StartsWith("Merhaba");
        bool bitiyor = metin.Trim().EndsWith("Dünyası");
        Console.WriteLine($"StartsWith(\"Merhaba\"): {basliyor}");
        Console.WriteLine($"EndsWith(\"Dünyası\"): {bitiyor}");
        
        // IsNullOrEmpty / IsNullOrWhiteSpace - Boş kontrolü
        bool bosMu = string.IsNullOrEmpty("");
        bool boslukMu = string.IsNullOrWhiteSpace("   ");
        Console.WriteLine($"IsNullOrEmpty(\"\"): {bosMu}");
        Console.WriteLine($"IsNullOrWhiteSpace(\"   \"): {boslukMu}");
    }
}

