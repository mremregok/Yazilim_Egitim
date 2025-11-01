namespace _02_Constants;

// const vs readonly farkı
public static class Example3
{
    public static void Run()
    {
        Console.WriteLine("\n=== Example 3: const vs readonly ===");
        
        const int SABIT_DEGER = 42;
        // const DateTime TARIH = DateTime.Now; // HATA: Runtime değeri olamaz
        
        Console.WriteLine($"const değer: {SABIT_DEGER}");
        Console.WriteLine("const: Derleme zamanında değeri bilinmeli");
        Console.WriteLine("readonly: Çalışma zamanında atanabilir");
    }
}

