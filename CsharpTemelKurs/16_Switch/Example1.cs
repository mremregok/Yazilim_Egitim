namespace _16_Switch;

// Switch-case
public static class Example1
{
    public static void Run()
    {
        Console.WriteLine("=== Example 1: Switch-case ===");
        
        int gun = 3;
        
        switch (gun)
        {
            case 1:
                Console.WriteLine("Pazartesi");
                break;
            case 2:
                Console.WriteLine("Salı");
                break;
            case 3:
                Console.WriteLine("Çarşamba");
                break;
            default:
                Console.WriteLine("Diğer");
                break;
        }
    }
}

