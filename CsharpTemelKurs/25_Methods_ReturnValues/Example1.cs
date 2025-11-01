namespace _25_Methods_ReturnValues;

// Değer döndüren metotlar - return ifadesi kullanımı
public static class Example1
{
    public static void Run()
    {
        Console.WriteLine("=== Example 1: Return Değeri - Temel Kullanım ===");
        
        // int döndüren metot
        int sonuc = Topla(5, 3);
        Console.WriteLine($"Topla(5, 3) = {sonuc}");
        
        // return ifadesi - Metottan değer döndürür ve metodu sonlandırır
        int carpim = Carp(4, 6);
        Console.WriteLine($"Carp(4, 6) = {carpim}");
        
        // Erken return - Koşula göre metottan erken çıkış
        int kontrol = PozitifSayiKontrol(-5);
        Console.WriteLine($"PozitifSayiKontrol(-5) = {kontrol}");
        
        int kontrol2 = PozitifSayiKontrol(10);
        Console.WriteLine($"PozitifSayiKontrol(10) = {kontrol2}");
    }
    
    // return - Metottan değer döndürür ve metodu sonlandırır
    // Dönüş tipi int olduğu için int değer döndürmelidir
    private static int Topla(int a, int b)
    {
        return a + b; // return ile değer döndürülür, metot sonlanır
    }
    
    // Çarpma metodu
    private static int Carp(int a, int b)
    {
        return a * b;
    }
    
    // Erken return örneği - Koşula göre erken çıkış
    private static int PozitifSayiKontrol(int sayi)
    {
        // Koşul sağlanırsa erken çıkış
        if (sayi <= 0)
        {
            return -1; // Metottan erken çık, -1 döndür
        }
        
        // Yukarıdaki return çalışmazsa buraya gelir
        return sayi * 2;
    }
}

