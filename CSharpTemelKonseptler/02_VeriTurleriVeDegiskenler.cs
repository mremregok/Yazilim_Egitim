using System;

namespace CSharpTemelKonseptler
{
    /// <summary>
    /// 2. VERİ TÜRLERİ VE DEĞİŞKENLER
    /// Value Type, Reference Type, temel türler, nullable, enum gibi kavramları içerir.
    /// </summary>
    public class VeriTurleriVeDegiskenler
    {
        // VALUE TYPE (Değer Tipi)
        // Stack'te saklanır, kopya ile geçirilir
        // int, double, char, bool, struct, enum

        // REFERENCE TYPE (Referans Tipi)
        // Heap'te saklanır, referans ile geçirilir
        // string, class, array, object

        /// <summary>
        /// Temel veri türleri ve kullanımları
        /// </summary>
        public static void TemelVeriTurleri()
        {
            // TAM SAYI TÜRLERİ
            byte sayiByte = 255;           // 0-255, 1 byte
            sbyte sayiSByte = -128;        // -128 to 127, 1 byte
            short sayiShort = -32768;     // -32,768 to 32,767, 2 byte
            ushort sayiUShort = 65535;    // 0 to 65,535, 2 byte
            int sayiInt = 2147483647;     // -2,147,483,648 to 2,147,483,647, 4 byte
            uint sayiUInt = 4294967295;    // 0 to 4,294,967,295, 4 byte
            long sayiLong = 9223372036854775807L; // 8 byte (L suffix)
            ulong sayiULong = 18446744073709551615UL; // 8 byte

            // ONDALIKLI SAYILAR
            float sayiFloat = 3.14f;       // 4 byte (f suffix)
            double sayiDouble = 3.14159;   // 8 byte (varsayılan)
            decimal sayiDecimal = 123.456m; // 16 byte (m suffix), para işlemleri için

            // KARAKTER VE METİN
            char karakter = 'A';           // Tek karakter, 2 byte (Unicode)
            string metin = "Merhaba C#";   // Metin dizisi, Reference Type

            // MANTIKSAL
            bool dogruMu = true;           // true veya false
            bool yanlisMi = false;

            Console.WriteLine($"Byte: {sayiByte}");
            Console.WriteLine($"Int: {sayiInt}");
            Console.WriteLine($"Float: {sayiFloat}");
            Console.WriteLine($"Double: {sayiDouble}");
            Console.WriteLine($"Decimal: {sayiDecimal}");
            Console.WriteLine($"Char: {karakter}");
            Console.WriteLine($"String: {metin}");
            Console.WriteLine($"Bool: {dogruMu}");
        }

        /// <summary>
        /// var, object ve dynamic kullanımı
        /// </summary>
        public static void VarObjectDynamic()
        {
            // var: Türü derleyici tarafından çıkarılır (Implicit Typing)
            // Derleme zamanında türü belirlenir, sonradan değiştirilemez
            var sayi = 10;              // int olarak çıkarılır
            var metin = "Merhaba";      // string olarak çıkarılır
            var pi = 3.14;              // double olarak çıkarılır
            // var hata; // HATA: var kullanırken başlangıç değeri verilmeli

            // object: Tüm türlerin temel sınıfı (boxing/unboxing)
            object obje1 = 42;          // int değer object'e box edilir
            object obje2 = "Test";
            object obje3 = true;

            // Unboxing: object'ten orijinal türe geri dönüşüm
            int sayi2 = (int)obje1;     // Cast gerekli
            string metin2 = (string)obje2;

            // dynamic: Çalışma zamanında tür kontrolü yapılır
            dynamic dinamik = 10;
            Console.WriteLine(dinamik);
            dinamik = "Artık string";   // Tür değişebilir
            Console.WriteLine(dinamik);
            dinamik = new { Ad = "Ali", Yas = 25 }; // Anonim tip

            Console.WriteLine($"var sayi: {sayi}, türü: {sayi.GetType()}");
            Console.WriteLine($"object değer: {obje1}");
            Console.WriteLine($"dynamic değer: {dinamik}");
        }

        /// <summary>
        /// Tür dönüşümleri (Convert, Parse, ToString)
        /// </summary>
        public static void TurDonusumleri()
        {
            // IMPLICIT (Örtük) DÖNÜŞÜM - Küçük türden büyüğe
            int tamSayi = 100;
            long uzunSayi = tamSayi;        // Otomatik dönüşüm
            float ondalik1 = tamSayi;       // Otomatik dönüşüm

            // EXPLICIT (Açık) DÖNÜŞÜM - Büyük türden küçüğe
            double ondalik2 = 9.99;
            int yeniTamSayi = (int)ondalik2; // 9 (ondalık kısım kesilir)

            // Convert sınıfı ile dönüşüm
            string sayiMetin = "123";
            int sayi1 = Convert.ToInt32(sayiMetin);
            double sayi2 = Convert.ToDouble("45.67");
            bool sonuc = Convert.ToBoolean("true");

            // Parse metodu ile dönüşüm
            int sayi3 = int.Parse("456");
            double sayi4 = double.Parse("78.9");
            // int.Parse("abc"); // FormatException fırlatır

            // TryParse - Güvenli dönüşüm (hata fırlatmaz)
            string giris = "123abc";
            int sonucSayi;
            bool basarili = int.TryParse(giris, out sonucSayi);
            if (basarili)
            {
                Console.WriteLine($"Dönüşüm başarılı: {sonucSayi}");
            }
            else
            {
                Console.WriteLine("Dönüşüm başarısız!");
            }

            // ToString() - Her tür string'e dönüştürülebilir
            int sayi5 = 999;
            string sayiString = sayi5.ToString(); // "999"
            string formatli = sayi5.ToString("C"); // Para formatı: "₺999.00"
            string formatli2 = sayi5.ToString("N"); // Sayı formatı: "999.00"

            Console.WriteLine($"Convert: {sayi1}, Parse: {sayi3}, ToString: {sayiString}");
        }

        /// <summary>
        /// const ve readonly farkı
        /// </summary>
        public class SabitlerOrnegi
        {
            // const: Derleme zamanında değeri bilinmelidir, değiştirilemez
            public const double PI = 3.14159;
            public const string DERS_ADI = "C# Temel Konseptler";
            // public const DateTime Tarih = DateTime.Now; // HATA: Runtime değeri olamaz

            // readonly: Çalışma zamanında veya constructor'da atanabilir
            public readonly string OlusturmaTarihi;
            public readonly int ToplamOgrenciSayisi;

            public SabitlerOrnegi()
            {
                OlusturmaTarihi = DateTime.Now.ToString();
                ToplamOgrenciSayisi = 50;
                // PI = 3.14; // HATA: const değer değiştirilemez
            }

            // readonly field'ı constructor dışında değiştirmek mümkün değil
        }

        /// <summary>
        /// Enum (enumeration) tanımlama ve kullanımı
        /// </summary>
        public enum HaftaninGunleri
        {
            Pazartesi,    // 0
            Sali,         // 1
            Carsamba,     // 2
            Persembe,     // 3
            Cuma,         // 4
            Cumartesi,    // 5
            Pazar         // 6
        }

        public enum Renkler : byte
        {
            Kirmizi = 1,
            Yesil = 2,
            Mavi = 4,
            Sari = 8
        }

        public static void EnumOrnekleri()
        {
            HaftaninGunleri bugun = HaftaninGunleri.Pazartesi;
            Console.WriteLine($"Bugün: {bugun}"); // Pazartesi
            Console.WriteLine($"Değer: {(int)bugun}"); // 0

            // Enum'dan string'e
            string gunAdi = bugun.ToString(); // "Pazartesi"

            // String'den enum'a
            HaftaninGunleri yarın = Enum.Parse<HaftaninGunleri>("Sali");

            // Enum üzerinde döngü
            foreach (var gun in Enum.GetValues(typeof(HaftaninGunleri)))
            {
                Console.WriteLine($"{gun} = {(int)gun}");
            }

            // Flags enum (bitwise işlemler için)
            Renkler kirmiziMavi = Renkler.Kirmizi | Renkler.Mavi;
            Console.WriteLine($"Renk: {kirmiziMavi}");
        }

        /// <summary>
        /// Null değerler ve Nullable<T> yapısı
        /// </summary>
        public static void NullableOrnekleri()
        {
            // Value type'lar normalde null olamaz
            // int sayi = null; // HATA!

            // Nullable<T> veya ? kullanarak null yapılabilir
            int? sayiNullable = null;
            Nullable<int> sayiNullable2 = null; // Aynı şey

            bool? cevap = null; // Üç durum: true, false, null

            // Null kontrolü
            if (sayiNullable.HasValue)
            {
                Console.WriteLine($"Değer: {sayiNullable.Value}");
            }
            else
            {
                Console.WriteLine("Değer null");
            }

            // Null-coalescing operator (??)
            int gercekSayi = sayiNullable ?? 0; // null ise 0 kullan
            Console.WriteLine($"Gercek sayı: {gercekSayi}");

            // Null-conditional operator (?.)
            string? metin = null;
            int uzunluk = metin?.Length ?? 0; // null ise 0 döner
            Console.WriteLine($"Uzunluk: {uzunluk}");
        }

        /// <summary>
        /// Bellek yönetimi - Stack vs Heap
        /// </summary>
        public static void BellekYonetimi()
        {
            Console.WriteLine("=== STACK (Yığın) ===");
            Console.WriteLine("- Value type'lar burada saklanır");
            Console.WriteLine("- int, double, char, bool, struct, enum");
            Console.WriteLine("- Hızlı erişim");
            Console.WriteLine("- Otomatik temizlik (scope sonunda)");

            int stackSayi = 42; // Stack'te

            Console.WriteLine("\n=== HEAP (Öbek) ===");
            Console.WriteLine("- Reference type'lar burada saklanır");
            Console.WriteLine("- string, class, array");
            Console.WriteLine("- Stack'te sadece referans (adres) tutulur");
            Console.WriteLine("- Garbage Collector tarafından temizlenir");

            string heapMetin = "Merhaba"; // Heap'te, stack'te referans var

            // Örnek
            int a = 10;        // Stack'te: 10
            int b = a;         // Stack'te: 10 (kopya)
            a = 20;            // Stack'te: a=20, b=10 (bağımsız)

            string str1 = "Test"; // Heap'te "Test", stack'te referans
            string str2 = str1;   // Stack'te aynı referans (aynı nesneye işaret)
            str1 = "Yeni";        // Yeni string oluşur, str2 hala "Test"e işaret eder
        }
    }
}

