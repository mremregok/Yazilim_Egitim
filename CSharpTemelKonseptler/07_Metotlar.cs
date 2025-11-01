using System;

namespace CSharpTemelKonseptler
{
    /// <summary>
    /// 7. METOTLAR (FUNCTIONS / METHODS)
    /// Metot tanımlama, parametreler, overloading, recursive metotlar içerir.
    /// </summary>
    public class Metotlar
    {
        /// <summary>
        /// Metot tanımlama ve çağırma
        /// </summary>
        public static void MetotTemelleri()
        {
            Console.WriteLine("=== METOT TEMELLERİ ===");

            // Metot çağırma
            MerhabaYazdir();
            string mesaj = IsimAl();
            Console.WriteLine($"Alınan isim: {mesaj}");

            int toplam = Topla(10, 20);
            Console.WriteLine($"Toplam: {toplam}");
        }

        // Parametresiz, değer döndürmeyen metot
        private static void MerhabaYazdir()
        {
            Console.WriteLine("Merhaba C#!");
        }

        // Parametresiz, değer döndüren metot
        private static string IsimAl()
        {
            return "Ahmet";
        }

        // Parametreli, değer döndüren metot
        private static int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        /// <summary>
        /// Parametre geçişi (value, ref, out)
        /// </summary>
        public static void ParametreGecisi()
        {
            Console.WriteLine("\n=== PARAMETRE GEÇİŞİ ===");

            // VALUE (Değer ile geçiş) - Varsayılan
            int sayi = 10;
            Console.WriteLine($"Orijinal değer: {sayi}");
            DegerDegistir(sayi);
            Console.WriteLine($"Value geçişi sonrası: {sayi}"); // Hala 10 (değişmedi)

            // REF (Referans ile geçiş)
            int sayi2 = 10;
            Console.WriteLine($"\nREF - Orijinal değer: {sayi2}");
            DegerDegistirRef(ref sayi2);
            Console.WriteLine($"REF geçişi sonrası: {sayi2}"); // 100 (değişti)

            // OUT (Çıkış parametresi)
            int sayi3;
            DegerAlOut(out sayi3);
            Console.WriteLine($"\nOUT ile alınan değer: {sayi3}"); // 50

            // TryParse örneği (out kullanımı)
            string giris = "123";
            if (int.TryParse(giris, out int sonuc))
            {
                Console.WriteLine($"Parse başarılı: {sonuc}");
            }
        }

        // Value geçişi - kopya oluşturulur
        private static void DegerDegistir(int deger)
        {
            deger = 100; // Sadece kopyayı değiştirir
        }

        // Ref geçişi - orijinal değişken referans edilir
        private static void DegerDegistirRef(ref int deger)
        {
            deger = 100; // Orijinal değişkeni değiştirir
        }

        // Out geçişi - çıkış parametresi, metot içinde mutlaka değer atanmalı
        private static void DegerAlOut(out int deger)
        {
            deger = 50; // Mutlaka atama yapılmalı
        }

        /// <summary>
        /// Geri dönüş tipleri
        /// </summary>
        public static void GeriDonusTipleri()
        {
            Console.WriteLine("\n=== GERİ DÖNÜŞ TİPLERİ ===");

            // void - Değer döndürmez
            void Metot1() { }

            // int
            int sayi = SayiDondur();
            Console.WriteLine($"Dönen sayı: {sayi}");

            // string
            string metin = MetinDondur();
            Console.WriteLine($"Dönen metin: {metin}");

            // bool
            bool sonuc = DogruMu();
            Console.WriteLine($"Dönen bool: {sonuc}");

            // Dizi
            int[] dizi = DiziDondur();
            Console.WriteLine($"Dönen dizi: [{string.Join(", ", dizi)}]");

            // Tuple (çoklu değer)
            var tuple = TupleDondur();
            Console.WriteLine($"Tuple: ({tuple.Item1}, {tuple.Item2})");
        }

        private static int SayiDondur() => 42;
        private static string MetinDondur() => "Merhaba";
        private static bool DogruMu() => true;
        private static int[] DiziDondur() => new int[] { 1, 2, 3 };
        private static (int, string) TupleDondur() => (10, "Test");

        /// <summary>
        /// Aşırı yükleme (method overloading)
        /// </summary>
        public static void MetotAsiriYukleme()
        {
            Console.WriteLine("\n=== METOT AŞIRI YÜKLEME (OVERLOADING) ===");

            // Aynı isim, farklı parametreler
            Console.WriteLine($"Topla(5, 3) = {ToplaOverload(5, 3)}");
            Console.WriteLine($"Topla(5.5, 3.2) = {ToplaOverload(5.5, 3.2)}");
            Console.WriteLine($"Topla(1, 2, 3) = {ToplaOverload(1, 2, 3)}");
            Console.WriteLine($"Topla(\"5\", \"3\") = {ToplaOverload("5", "3")}");
        }

        // Overload 1: İki int
        private static int ToplaOverload(int a, int b)
        {
            return a + b;
        }

        // Overload 2: İki double
        private static double ToplaOverload(double a, double b)
        {
            return a + b;
        }

        // Overload 3: Üç int
        private static int ToplaOverload(int a, int b, int c)
        {
            return a + b + c;
        }

        // Overload 4: İki string (sayıya dönüştürüp topla)
        private static int ToplaOverload(string a, string b)
        {
            return int.Parse(a) + int.Parse(b);
        }

        /// <summary>
        /// Recursive (özyinelemeli) metotlar
        /// </summary>
        public static void RecursiveMetotlar()
        {
            Console.WriteLine("\n=== RECURSIVE (ÖZYİNELEMELİ) METOTLAR ===");

            // Faktöriyel hesaplama
            int sayi = 5;
            long faktoriyel = Faktoriyel(sayi);
            Console.WriteLine($"{sayi}! = {faktoriyel}");

            // Fibonacci serisi
            Console.WriteLine("\nFibonacci serisi (ilk 10 terim):");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{Fibonacci(i)} ");
            }
            Console.WriteLine();

            // Üs alma (recursive)
            int taban = 2;
            int us = 8;
            long sonuc = UsAlma(taban, us);
            Console.WriteLine($"\n{taban}^{us} = {sonuc}");
        }

        // Faktöriyel: n! = n * (n-1)!
        private static long Faktoriyel(int n)
        {
            // Base case (temel durum)
            if (n <= 1)
                return 1;
            
            // Recursive case (özyineleme)
            return n * Faktoriyel(n - 1);
        }

        // Fibonacci: F(n) = F(n-1) + F(n-2)
        private static int Fibonacci(int n)
        {
            // Base cases
            if (n == 0) return 0;
            if (n == 1) return 1;

            // Recursive case
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        // Üs alma: x^y = x * x^(y-1)
        private static long UsAlma(int taban, int us)
        {
            // Base case
            if (us == 0)
                return 1;
            if (us == 1)
                return taban;

            // Recursive case
            return taban * UsAlma(taban, us - 1);
        }

        /// <summary>
        /// return ifadesi ve metot akışı
        /// </summary>
        public static void ReturnIfadesi()
        {
            Console.WriteLine("\n=== RETURN İFADESİ ===");

            int sonuc1 = ErkenCikis(5);
            Console.WriteLine($"Erken çıkış sonucu: {sonuc1}");

            bool sonuc2 = DogruMuKontrol(10);
            Console.WriteLine($"Kontrol sonucu: {sonuc2}");

            // Return ile döngüden çıkma
            int ilkTekSayi = IlkTekSayiyiBul(new int[] { 2, 4, 6, 7, 8, 10 });
            Console.WriteLine($"İlk tek sayı: {ilkTekSayi}");
        }

        // Erken return örneği
        private static int ErkenCikis(int deger)
        {
            if (deger < 0)
            {
                return -1; // Erken çıkış
            }

            if (deger > 100)
            {
                return 100; // Erken çıkış
            }

            return deger * 2;
        }

        // Return ile koşul kontrolü
        private static bool DogruMuKontrol(int sayi)
        {
            if (sayi % 2 == 0)
                return true;
            
            return false;
        }

        // Return ile döngüden çıkma
        private static int IlkTekSayiyiBul(int[] sayilar)
        {
            foreach (int sayi in sayilar)
            {
                if (sayi % 2 == 1)
                {
                    return sayi; // İlk tek sayıyı bulunca metottan çık
                }
            }
            return -1; // Tek sayı yoksa
        }

        /// <summary>
        /// Metotlardan exception fırlatma
        /// </summary>
        public static void ExceptionFirlatma()
        {
            Console.WriteLine("\n=== EXCEPTION FIRLATMA ===");

            try
            {
                int sonuc = GuvenliBolme(10, 0);
                Console.WriteLine($"Sonuç: {sonuc}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
            }

            try
            {
                int yas = YasKontrolEt(-5);
                Console.WriteLine($"Yaş: {yas}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
            }
        }

        // Exception fırlatma örneği
        private static int GuvenliBolme(int bolunen, int bolen)
        {
            if (bolen == 0)
            {
                throw new ArgumentException("Bölen sıfır olamaz!");
            }
            return bolunen / bolen;
        }

        // ArgumentException fırlatma
        private static int YasKontrolEt(int yas)
        {
            if (yas < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(yas), "Yaş negatif olamaz!");
            }
            if (yas > 150)
            {
                throw new ArgumentOutOfRangeException(nameof(yas), "Yaş çok yüksek!");
            }
            return yas;
        }

        /// <summary>
        /// Optional parametreler ve default değerler
        /// </summary>
        public static void OptionalParametreler()
        {
            Console.WriteLine("\n=== OPTIONAL PARAMETRELER ===");

            // Optional parametre ile çağırma
            Console.WriteLine($"Selamla(): {Selamla()}");
            Console.WriteLine($"Selamla(\"Ahmet\"): {Selamla("Ahmet")}");

            // Named parametreler
            Console.WriteLine($"Hesapla(10, 20): {Hesapla(10, 20)}");
            Console.WriteLine($"Hesapla(10, 20, carpim: 5): {Hesapla(10, 20, carpim: 5)}");
            Console.WriteLine($"Hesapla(10, 20, carpim: 5, bolum: 2): {Hesapla(10, 20, carpim: 5, bolum: 2)}");
        }

        // Optional parametre (default değer)
        private static string Selamla(string isim = "Misafir")
        {
            return $"Merhaba {isim}!";
        }

        // Named parametreler
        private static double Hesapla(double a, double b, double carpim = 1, double bolum = 1)
        {
            return (a + b) * carpim / bolum;
        }

        /// <summary>
        /// Metot örnekleri birleşik
        /// </summary>
        public static void BilesikMetotOrnekleri()
        {
            Console.WriteLine("\n=== BİLEŞİK METOT ÖRNEKLERİ ===");

            // Birden fazla return değeri (Tuple)
            var (toplam, carpim) = ToplaVeCarp(5, 3);
            Console.WriteLine($"Toplam: {toplam}, Çarpım: {carpim}");

            // Metot zincirleme (fluent interface benzeri)
            int sonuc = IslemYap(10).Carp(2).Ekle(5).DegeriAl();
            Console.WriteLine($"Zincirleme sonuç: {sonuc}");
        }

        // Çoklu değer döndürme
        private static (int, int) ToplaVeCarp(int a, int b)
        {
            return (a + b, a * b);
        }

        // Basit fluent interface örneği
        private class IslemYapici
        {
            private int deger;

            public IslemYapici(int baslangic)
            {
                deger = baslangic;
            }

            public IslemYapici Carp(int carpan)
            {
                deger *= carpan;
                return this;
            }

            public IslemYapici Ekle(int ekleme)
            {
                deger += ekleme;
                return this;
            }

            public int DegeriAl()
            {
                return deger;
            }
        }

        private static IslemYapici IslemYap(int baslangic)
        {
            return new IslemYapici(baslangic);
        }
    }
}

