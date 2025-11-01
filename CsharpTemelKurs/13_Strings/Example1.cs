namespace _13_Strings;

// String birleştirme (Concatenation) - + operatörü ile
public static class Example1
{
    public static void Run()
    {
        Console.WriteLine("=== Example 1: String Birleştirme (Concatenation) ===");
        
        // + operatörü ile string birleştirme
        string ad = "Ali";
        string soyad = "Veli";
        string tamAd = ad + " " + soyad;
        Console.WriteLine($"Birleştirme (+): {tamAd}");
        
        // String.Concat metodu ile birleştirme
        string birlesik = string.Concat(ad, " ", soyad);
        Console.WriteLine($"String.Concat: {birlesik}");
        
        // String.Join ile birleştirme
        string[] isimler = { "Ali", "Veli", "Mehmet" };
        string birlesik2 = string.Join(" - ", isimler);
        Console.WriteLine($"String.Join: {birlesik2}");
    }
}

