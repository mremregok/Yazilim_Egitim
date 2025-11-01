namespace _30_OOP_AccessModifiers;

// public erişim
public static class Example1
{
    public static void Run()
    {
        Console.WriteLine("=== Example 1: public ===");
        
        PublicClass pub = new PublicClass();
        pub.PublicOzellik = "Erişilebilir";
        Console.WriteLine(pub.PublicOzellik);
    }
}

public class PublicClass
{
    public string PublicOzellik { get; set; } = "";
}

