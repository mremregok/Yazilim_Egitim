namespace _16_Switch;

// Switch expression
public static class Example3
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 3: Switch Expression ===");
        
        int gun = 3;
        
        string mesaj = gun switch
        {
            1 => "Pazartesi",
            2 => "Salı",
            3 => "Çarşamba",
            _ => "Diğer"
        };
        
        Console.WriteLine(mesaj);
    }
}

