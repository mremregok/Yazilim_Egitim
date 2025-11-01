namespace _30_OOP_AccessModifiers;

// private erişim
public static class Example2
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 2: private ===");
        
        PrivateExample priv = new PrivateExample();
        priv.PublicMetot();
    }
}

class PrivateExample
{
    private string _privateField = "Private";
    
    public void PublicMetot()
    {
        Console.WriteLine($"Private field'a erişim: {_privateField}");
    }
}

