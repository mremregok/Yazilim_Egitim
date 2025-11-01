using System;
using System.Text.RegularExpressions;

namespace CSharpTemelKonseptler
{
    /// <summary>
    /// 3. OPERATÖRLER VE İFADELER
    /// Aritmetik, atama, karşılaştırma, mantıksal, bitwise operatörler ve Regex içerir.
    /// </summary>
    public class OperatorlerVeIfadeler
    {
        /// <summary>
        /// Aritmetik operatörler
        /// </summary>
        public static void AritmetikOperatorler()
        {
            int a = 10;
            int b = 3;

            Console.WriteLine("=== ARİTMETİK OPERATÖRLER ===");
            Console.WriteLine($"a = {a}, b = {b}");
            Console.WriteLine($"Toplama (+): {a} + {b} = {a + b}");
            Console.WriteLine($"Çıkarma (-): {a} - {b} = {a - b}");
            Console.WriteLine($"Çarpma (*): {a} * {b} = {a * b}");
            Console.WriteLine($"Bölme (/): {a} / {b} = {a / b}"); // 3 (tam sayı bölme)
            Console.WriteLine($"Modül (%): {a} % {b} = {a % b}"); // Kalan: 1

            double x = 10.0;
            double y = 3.0;
            Console.WriteLine($"Ondalıklı bölme: {x} / {y} = {x / y}"); // 3.333...

            // Bölme sıfıra yaklaşma
            Console.WriteLine($"10.0 / 0.0 = {10.0 / 0.0}"); // Infinity (∞)
            Console.WriteLine($"0.0 / 0.0 = {0.0 / 0.0}"); // NaN (Not a Number)
        }

        /// <summary>
        /// Atama operatörleri
        /// </summary>
        public static void AtamaOperatorleri()
        {
            int sayi = 10;
            Console.WriteLine($"Başlangıç değeri: {sayi}");

            sayi += 5;  // sayi = sayi + 5
            Console.WriteLine($"sayi += 5: {sayi}"); // 15

            sayi -= 3;  // sayi = sayi - 3
            Console.WriteLine($"sayi -= 3: {sayi}"); // 12

            sayi *= 2;  // sayi = sayi * 2
            Console.WriteLine($"sayi *= 2: {sayi}"); // 24

            sayi /= 4;  // sayi = sayi / 4
            Console.WriteLine($"sayi /= 4: {sayi}"); // 6

            sayi %= 4;  // sayi = sayi % 4
            Console.WriteLine($"sayi %= 4: {sayi}"); // 2

            // String birleştirme
            string metin = "Merhaba";
            metin += " C#";
            Console.WriteLine($"Metin: {metin}"); // "Merhaba C#"
        }

        /// <summary>
        /// Karşılaştırma operatörleri
        /// </summary>
        public static void KarsilastirmaOperatorleri()
        {
            int a = 10;
            int b = 20;
            int c = 10;

            Console.WriteLine("=== KARŞILAŞTIRMA OPERATÖRLERİ ===");
            Console.WriteLine($"a = {a}, b = {b}, c = {c}");

            Console.WriteLine($"Eşitlik (==): {a} == {c} = {a == c}"); // true
            Console.WriteLine($"Eşitsizlik (!=): {a} != {b} = {a != b}"); // true

            Console.WriteLine($"Küçük (<): {a} < {b} = {a < b}"); // true
            Console.WriteLine($"Büyük (>): {a} > {b} = {a > b}"); // false

            Console.WriteLine($"Küçük-eşit (<=): {a} <= {c} = {a <= c}"); // true
            Console.WriteLine($"Büyük-eşit (>=): {b} >= {a} = {b >= a}"); // true

            // String karşılaştırma
            string str1 = "Ahmet";
            string str2 = "Ahmet";
            string str3 = "Mehmet";

            Console.WriteLine($"String eşitlik: \"{str1}\" == \"{str2}\" = {str1 == str2}"); // true
            Console.WriteLine($"String eşitlik: \"{str1}\" == \"{str3}\" = {str1 == str3}"); // false

            // Referans karşılaştırma
            object obj1 = "Test";
            object obj2 = "Test";
            Console.WriteLine($"Object referans (==): {obj1 == obj2}"); // true (string özel durum)
            Console.WriteLine($"Object referans (ReferenceEquals): {ReferenceEquals(obj1, obj2)}"); // true
        }

        /// <summary>
        /// Mantıksal operatörler
        /// </summary>
        public static void MantiksalOperatorler()
        {
            bool dogru = true;
            bool yanlis = false;

            Console.WriteLine("=== MANTIKSAL OPERATÖRLER ===");

            // VE (AND) - &&
            Console.WriteLine($"VE (&&): {dogru} && {dogru} = {dogru && dogru}"); // true
            Console.WriteLine($"VE (&&): {dogru} && {yanlis} = {dogru && yanlis}"); // false

            // VEYA (OR) - ||
            Console.WriteLine($"VEYA (||): {dogru} || {yanlis} = {dogru || yanlis}"); // true
            Console.WriteLine($"VEYA (||): {yanlis} || {yanlis} = {yanlis || yanlis}"); // false

            // DEĞİL (NOT) - !
            Console.WriteLine($"DEĞİL (!): !{dogru} = {!dogru}"); // false
            Console.WriteLine($"DEĞİL (!): !{yanlis} = {!yanlis}"); // true

            // XOR (Exclusive OR) - ^
            Console.WriteLine($"XOR (^): {dogru} ^ {dogru} = {dogru ^ dogru}"); // false
            Console.WriteLine($"XOR (^): {dogru} ^ {yanlis} = {dogru ^ yanlis}"); // true

            // Kısa devre değerlendirme (Short-circuit)
            bool sonuc1 = false && Test(); // Test() çağrılmaz
            bool sonuc2 = true || Test();   // Test() çağrılmaz
        }

        private static bool Test()
        {
            Console.WriteLine("Test metodu çağrıldı!");
            return true;
        }

        /// <summary>
        /// Bitwise (bit düzeyinde) operatörler
        /// </summary>
        public static void BitwiseOperatorler()
        {
            int a = 5;   // 0101 (binary)
            int b = 3;   // 0011 (binary)

            Console.WriteLine("=== BITWISE OPERATÖRLER ===");
            Console.WriteLine($"a = {a} (binary: {Convert.ToString(a, 2)})");
            Console.WriteLine($"b = {b} (binary: {Convert.ToString(b, 2)})");

            // AND (&)
            int andSonuc = a & b; // 0101 & 0011 = 0001 (1)
            Console.WriteLine($"AND (&): {a} & {b} = {andSonuc} (binary: {Convert.ToString(andSonuc, 2)})");

            // OR (|)
            int orSonuc = a | b; // 0101 | 0011 = 0111 (7)
            Console.WriteLine($"OR (|): {a} | {b} = {orSonuc} (binary: {Convert.ToString(orSonuc, 2)})");

            // XOR (^)
            int xorSonuc = a ^ b; // 0101 ^ 0011 = 0110 (6)
            Console.WriteLine($"XOR (^): {a} ^ {b} = {xorSonuc} (binary: {Convert.ToString(xorSonuc, 2)})");

            // NOT (~)
            int notSonuc = ~a;
            Console.WriteLine($"NOT (~): ~{a} = {notSonuc}");

            // Sola kaydırma (<<)
            int solaKaydir = a << 1; // 0101 << 1 = 1010 (10) - 2 ile çarpma
            Console.WriteLine($"Sola kaydırma (<<): {a} << 1 = {solaKaydir}");

            // Sağa kaydırma (>>)
            int sagaKaydir = a >> 1; // 0101 >> 1 = 0010 (2) - 2'ye bölme
            Console.WriteLine($"Sağa kaydırma (>>): {a} >> 1 = {sagaKaydir}");
        }

        /// <summary>
        /// Artırma ve azaltma operatörleri
        /// </summary>
        public static void ArtirmaAzaltmaOperatorleri()
        {
            int sayi = 10;

            Console.WriteLine("=== ARTIRMA VE AZALTMA OPERATÖRLERİ ===");

            // Ön ek (prefix) artırma
            int sayi1 = ++sayi; // Önce artırır, sonra değeri alır
            Console.WriteLine($"++sayi (ön ek): sayi = {sayi}, sayi1 = {sayi1}"); // sayi=11, sayi1=11

            sayi = 10;
            // Son ek (postfix) artırma
            int sayi2 = sayi++; // Önce değeri alır, sonra artırır
            Console.WriteLine($"sayi++ (son ek): sayi = {sayi}, sayi2 = {sayi2}"); // sayi=11, sayi2=10

            sayi = 10;
            // Ön ek azaltma
            int sayi3 = --sayi;
            Console.WriteLine($"--sayi (ön ek): sayi = {sayi}, sayi3 = {sayi3}"); // sayi=9, sayi3=9

            sayi = 10;
            // Son ek azaltma
            int sayi4 = sayi--;
            Console.WriteLine($"sayi-- (son ek): sayi = {sayi}, sayi4 = {sayi4}"); // sayi=9, sayi4=10
        }

        /// <summary>
        /// Operatör önceliği örneği
        /// </summary>
        public static void OperatorOnceligi()
        {
            Console.WriteLine("=== OPERATÖR ÖNCELİĞİ ===");
            Console.WriteLine("En yüksek öncelikten en düşüğe:");
            Console.WriteLine("1. () - Parantez");
            Console.WriteLine("2. ++, -- (ön ek)");
            Console.WriteLine("3. *, /, %");
            Console.WriteLine("4. +, -");
            Console.WriteLine("5. <, >, <=, >=");
            Console.WriteLine("6. ==, !=");
            Console.WriteLine("7. &&");
            Console.WriteLine("8. ||");
            Console.WriteLine("9. =, +=, -=, vb.");

            int sonuc1 = 2 + 3 * 4;        // 14 (önce çarpma)
            int sonuc2 = (2 + 3) * 4;      // 20 (önce parantez)
            bool sonuc3 = 5 > 3 && 2 < 1;  // false (önce karşılaştırma)
            int sonuc4 = 10 / 2 + 3;       // 8 (önce bölme)

            Console.WriteLine($"2 + 3 * 4 = {sonuc1}");
            Console.WriteLine($"(2 + 3) * 4 = {sonuc2}");
            Console.WriteLine($"5 > 3 && 2 < 1 = {sonuc3}");
            Console.WriteLine($"10 / 2 + 3 = {sonuc4}");
        }

        /// <summary>
        /// Regex (Regular Expression) ile pattern eşleştirme
        /// </summary>
        public static void RegexOrnekleri()
        {
            Console.WriteLine("=== REGEX (REGULAR EXPRESSION) ===");

            // E-posta formatı kontrolü
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            string[] emailOrnekleri = {
                "ornek@email.com",
                "test.test123@domain.co.uk",
                "gecersiz.email",
                "@domain.com",
                "user@"
            };

            Console.WriteLine("E-posta doğrulama:");
            foreach (string email in emailOrnekleri)
            {
                bool gecerli = Regex.IsMatch(email, emailPattern);
                Console.WriteLine($"  {email,-30} => {(gecerli ? "GEÇERLİ" : "GEÇERSİZ")}");
            }

            // Telefon numarası kontrolü (Türkiye formatı)
            string telefonPattern = @"^(\+90|0)?[5][0-9]{9}$";
            string[] telefonOrnekleri = {
                "05321234567",
                "+905321234567",
                "5321234567",
                "01234567890",
                "555555555"
            };

            Console.WriteLine("\nTelefon numarası doğrulama:");
            foreach (string telefon in telefonOrnekleri)
            {
                bool gecerli = Regex.IsMatch(telefon, telefonPattern);
                Console.WriteLine($"  {telefon,-15} => {(gecerli ? "GEÇERLİ" : "GEÇERSİZ")}");
            }

            // Metin içinde arama
            string metin = "İletişim: 0532 123 45 67 veya info@example.com";
            MatchCollection sayilar = Regex.Matches(metin, @"\d+");
            Console.WriteLine($"\nMetindeki sayılar: {string.Join(", ", sayilar.Cast<Match>().Select(m => m.Value))}");

            // Replace (değiştirme)
            string gizliTelefon = Regex.Replace("0532 123 45 67", @"\d", "*");
            Console.WriteLine($"Gizli telefon: {gizliTelefon}");

            // Split (ayırma)
            string cumle = "Ali, Veli, Mehmet, Ayşe";
            string[] isimler = Regex.Split(cumle, @",\s*");
            Console.WriteLine($"İsimler: {string.Join(" | ", isimler)}");
        }

        /// <summary>
        /// Temel regex pattern'leri
        /// </summary>
        public static void TemelRegexPatternleri()
        {
            Console.WriteLine("\n=== TEMEL REGEX PATTERN'LERİ ===");
            Console.WriteLine(".       => Herhangi bir karakter");
            Console.WriteLine("\\d      => Rakam (0-9)");
            Console.WriteLine("\\w      => Kelime karakteri (a-z, A-Z, 0-9, _)");
            Console.WriteLine("\\s      => Boşluk karakteri");
            Console.WriteLine("^       => Satır başı");
            Console.WriteLine("$       => Satır sonu");
            Console.WriteLine("*       => 0 veya daha fazla");
            Console.WriteLine("+       => 1 veya daha fazla");
            Console.WriteLine("?       => 0 veya 1");
            Console.WriteLine("{n}     => Tam n adet");
            Console.WriteLine("{n,m}   => n ile m arasında");
            Console.WriteLine("[abc]   => a, b veya c");
            Console.WriteLine("[a-z]   => a'dan z'ye");
            Console.WriteLine("(abc)   => Grup");
        }
    }
}

