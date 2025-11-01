namespace _35_Enums;

// Enum switch
public static class Example3
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 3: Enum Switch ===");
        
        Durum durum = Durum.Aktif;
        
        switch (durum)
        {
            case Durum.Aktif:
                Console.WriteLine("Sistem aktif");
                break;
            case Durum.Pasif:
                Console.WriteLine("Sistem pasif");
                break;
            case Durum.Beklemede:
                Console.WriteLine("Sistem beklemede");
                break;
        }
    }
}

enum Durum
{
    Aktif,
    Pasif,
    Beklemede
}

