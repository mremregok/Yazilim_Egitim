namespace _28_OOP_ClassMembers;

// Metotlar
public static class Example2
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 2: Metotlar ===");
        
        HesapMakinesi hesap = new HesapMakinesi();
        int sonuc = hesap.Topla(10, 5);
        Console.WriteLine($"Toplam: {sonuc}");
    }
}

class HesapMakinesi
{
    public int Topla(int a, int b)
    {
        return a + b;
    }
}

