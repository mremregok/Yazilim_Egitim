namespace _28_OOP_ClassMembers;

// Alanlar (Fields)
public static class Example3
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 3: Alanlar ===");
        
        Sayac sayac = new Sayac();
        sayac.Arttir();
        sayac.Arttir();
        Console.WriteLine($"Sayaç: {sayac.Deger}");
    }
}

class Sayac
{
    private int _deger = 0;
    
    public int Deger => _deger;
    
    public void Arttir()
    {
        _deger++;
    }
}

