namespace _33_OOP_Abstraction;

// Abstract class
public static class Example1
{
    public static void Run()
    {
        Console.WriteLine("=== Example 1: Abstract Class ===");
        
        Hayvan3 hayvan = new Kedi3();
        hayvan.SesCikar();
    }
}

abstract class Hayvan3
{
    public abstract void SesCikar();
}

class Kedi3 : Hayvan3
{
    public override void SesCikar()
    {
        Console.WriteLine("Miyav!");
    }
}

