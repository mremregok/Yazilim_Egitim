namespace _30_OOP_AccessModifiers;

// protected erişim
public static class Example3
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 3: protected ===");
        
        DerivedClass derived = new DerivedClass();
        derived.Eris();
    }
}

class BaseClass
{
    protected string ProtectedField = "Protected";
}

class DerivedClass : BaseClass
{
    public void Eris()
    {
        Console.WriteLine($"Protected field: {ProtectedField}");
    }
}

