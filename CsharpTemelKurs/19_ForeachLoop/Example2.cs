namespace _19_ForeachLoop;

// foreach ile koleksiyonlar - List, Dictionary, vb.
public static class Example2
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 2: foreach ile Koleksiyonlar ===");
        
        // List<T> ile foreach
        List<string> isimler = new() { "Ali", "Veli", "Mehmet", "Ayşe" };
        Console.WriteLine("List<string> ile:");
        foreach (string isim in isimler)
        {
            Console.WriteLine($"  İsim: {isim}");
        }
        
        // List<int> ile foreach
        List<int> sayilar = new() { 10, 20, 30, 40 };
        Console.WriteLine("\nList<int> ile:");
        foreach (int sayi in sayilar)
        {
            Console.WriteLine($"  Sayı: {sayi}");
        }
        
        // Dictionary<TKey, TValue> ile foreach - KeyValuePair kullanımı
        Dictionary<string, int> notlar = new()
        {
            { "Ali", 85 },
            { "Veli", 90 },
            { "Mehmet", 75 }
        };
        Console.WriteLine("\nDictionary<string, int> ile:");
        foreach (var kayit in notlar)
        {
            Console.WriteLine($"  {kayit.Key}: {kayit.Value}");
        }
    }
}

