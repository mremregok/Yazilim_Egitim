namespace _29_OOP_Constructors;

// Constructor overloading
public static class Example3
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 3: Constructor Overloading ===");
        
        Person person1 = new Person("Ahmet");
        Person person2 = new Person("Ali", 25);
        
        Console.WriteLine($"Person 1: {person1.Isim}");
        Console.WriteLine($"Person 2: {person2.Isim}, Yaş: {person2.Yas}");
    }
}

class Person
{
    public string Isim { get; set; }
    public int Yas { get; set; }
    
    public Person(string isim)
    {
        Isim = isim;
        Yas = 0;
    }
    
    public Person(string isim, int yas)
    {
        Isim = isim;
        Yas = yas;
    }
}

