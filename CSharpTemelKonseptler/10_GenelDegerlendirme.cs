using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpTemelKonseptler
{
    /// <summary>
    /// 10. GENEL DEĞERLENDİRME
    /// Kod okuma, hata bulma, best practice örnekleri içerir.
    /// </summary>
    public class GenelDegerlendirme
    {
        /// <summary>
        /// Kod okuma ve hata bulma alıştırmaları
        /// </summary>
        public static void KodOkumaAlistirmalari()
        {
            Console.WriteLine("=== KOD OKUMA ALIŞTIRMALARI ===");

            // Örnek 1: Hatalı kod örneği
            Console.WriteLine("\n1. HATALI KOD ÖRNEĞİ:");
            Console.WriteLine("Aşağıdaki kodda hatalar var, bulabilir misiniz?");
            Console.WriteLine(@"
int[] sayilar = { 1, 2, 3, 4, 5 };
for (int i = 0; i <= sayilar.Length; i++)
{
    Console.WriteLine(sayilar[i]);
}
");
            Console.WriteLine("HATALAR:");
            Console.WriteLine("  - i <= sayilar.Length -> IndexOutOfRangeException");
            Console.WriteLine("  - Doğrusu: i < sayilar.Length");
            Console.WriteLine("\nDOĞRU KOD:");
            Console.WriteLine(@"
int[] sayilar = { 1, 2, 3, 4, 5 };
for (int i = 0; i < sayilar.Length; i++)
{
    Console.WriteLine(sayilar[i]);
}
");

            // Örnek 2: Mantık hatası
            Console.WriteLine("\n2. MANTIK HATASI ÖRNEĞİ:");
            Console.WriteLine(@"
int sayi = 10;
if (sayi = 5)  // HATA: = yerine == olmalı
{
    Console.WriteLine(""Eşit"");
}
");
            Console.WriteLine("HATA: Atama operatörü (=) yerine karşılaştırma operatörü (==) kullanılmalı");

            // Örnek 3: Null reference hatası
            Console.WriteLine("\n3. NULL REFERENCE HATASI:");
            Console.WriteLine(@"
string metin = null;
int uzunluk = metin.Length;  // NullReferenceException
");
            Console.WriteLine("ÇÖZÜM: Null kontrolü yapılmalı");
            Console.WriteLine(@"
string metin = null;
int uzunluk = metin?.Length ?? 0;  // Güvenli erişim
");
        }

        /// <summary>
        /// Best practice: Değişken isimlendirme
        /// </summary>
        public static void DegiskenIsimlendirme()
        {
            Console.WriteLine("\n=== DEĞİŞKEN İSİMLENDİRME BEST PRACTİCES ===");

            // ❌ KÖTÜ ÖRNEKLER
            Console.WriteLine("\n❌ KÖTÜ İSİMLENDİRME:");
            Console.WriteLine("  - int x = 10;");
            Console.WriteLine("  - string str = \"test\";");
            Console.WriteLine("  - int temp = 5;");
            Console.WriteLine("  - int data1, data2, data3;");

            // ✅ İYİ ÖRNEKLER
            Console.WriteLine("\n✅ İYİ İSİMLENDİRME:");
            Console.WriteLine("  - int yas = 25;");
            Console.WriteLine("  - string ogrenciAdi = \"Ahmet\";");
            Console.WriteLine("  - int toplamNot = 85;");
            Console.WriteLine("  - int vizeNotu, finalNotu, projeNotu;");

            // İsimlendirme kuralları
            Console.WriteLine("\n=== İSİMLENDİRME KURALLARI ===");
            Console.WriteLine("1. camelCase: Yerel değişkenler ve parametreler");
            Console.WriteLine("   Örnek: string ogrenciAdi, int toplamNot");
            Console.WriteLine("\n2. PascalCase: Sınıf, metot, özellik adları");
            Console.WriteLine("   Örnek: class Ogrenci, void NotHesapla()");
            Console.WriteLine("\n3. UPPER_CASE: Sabitler (const)");
            Console.WriteLine("   Örnek: const double PI = 3.14;");
            Console.WriteLine("\n4. İsimler anlamlı ve açıklayıcı olmalı");
            Console.WriteLine("5. Türkçe karakter kullanılabilir (önerilir)");
            Console.WriteLine("6. Kısaltmalardan kaçınılmalı");

            // Örnek karşılaştırma
            Console.WriteLine("\n=== ÖRNEK KARŞILAŞTIRMA ===");
            Console.WriteLine("KÖTÜ:");
            Console.WriteLine("  int n = 10;");
            Console.WriteLine("  string s = \"test\";");
            Console.WriteLine("  int[] arr = new int[5];");
            Console.WriteLine("\nİYİ:");
            Console.WriteLine("  int ogrenciSayisi = 10;");
            Console.WriteLine("  string isim = \"Ahmet\";");
            Console.WriteLine("  int[] notlar = new int[5];");
        }

        /// <summary>
        /// Best practice: Sade kod yazma
        /// </summary>
        public static void SadeKodOrnekleri()
        {
            Console.WriteLine("\n=== SADE KOD YAZMA BEST PRACTİCES ===");

            // Örnek 1: Gereksiz karmaşıklık
            Console.WriteLine("\n1. GEREKSİZ KARMAŞIKLIK:");
            Console.WriteLine("KÖTÜ:");
            Console.WriteLine(@"
if (sayi > 10 == true)
{
    return true;
}
else
{
    return false;
}
");
            Console.WriteLine("İYİ:");
            Console.WriteLine(@"
return sayi > 10;
");

            // Örnek 2: Tekrarlayan kod
            Console.WriteLine("\n2. TEKRARLAYAN KOD:");
            Console.WriteLine("KÖTÜ:");
            Console.WriteLine(@"
if (yas >= 18)
{
    Console.WriteLine(""Yetişkin"");
}
if (yas >= 65)
{
    Console.WriteLine(""Yaşlı"");
}
");
            Console.WriteLine("İYİ:");
            Console.WriteLine(@"
if (yas >= 65)
{
    Console.WriteLine(""Yaşlı"");
}
else if (yas >= 18)
{
    Console.WriteLine(""Yetişkin"");
}
");

            // Örnek 3: Magic numbers
            Console.WriteLine("\n3. MAGIC NUMBERS (Sihirli Sayılar):");
            Console.WriteLine("KÖTÜ:");
            Console.WriteLine(@"
if (yas >= 18 && yas <= 65)
{
    // Kod
}
");
            Console.WriteLine("İYİ:");
            Console.WriteLine(@"
const int YETISKIN_YAS_SINIRI = 18;
const int EMEKLILIK_YASI = 65;

if (yas >= YETISKIN_YAS_SINIRI && yas <= EMEKLILIK_YASI)
{
    // Kod
}
");

            // Örnek 4: Uzun metotlar
            Console.WriteLine("\n4. UZUN METOTLAR:");
            Console.WriteLine("KÖTÜ: Her şeyi tek metotta yapmak");
            Console.WriteLine("İYİ: Küçük, tek sorumluluğu olan metotlar");
        }

        /// <summary>
        /// namespace düzenleme egzersizi
        /// </summary>
        public static void NamespaceDuzenleme()
        {
            Console.WriteLine("\n=== NAMESPACE DÜZENLEME ===");

            Console.WriteLine("İYİ NAMESPACE YAPISI:");
            Console.WriteLine(@"
namespace CSharpTemelKonseptler
{
    namespace Matematik
    {
        public class Hesaplayici { }
    }
    
    namespace Veritabani
    {
        public class Baglanti { }
    }
    
    namespace Arayuz
    {
        public class KullaniciArayuzu { }
    }
}
");

            Console.WriteLine("\nKULLANIM:");
            Console.WriteLine(@"
using CSharpTemelKonseptler.Matematik;
using CSharpTemelKonseptler.Veritabani;

// Artık doğrudan kullanılabilir
Hesaplayici hesap = new Hesaplayici();
");

            Console.WriteLine("\nNAMESPACE KURALLARI:");
            Console.WriteLine("1. Mantıksal gruplandırma yapılmalı");
            Console.WriteLine("2. Şirket/Proje ismi ile başlamalı");
            Console.WriteLine("3. İç içe namespace'ler kullanılabilir");
            Console.WriteLine("4. Her sınıf için ayrı namespace gerekmez");
        }

        /// <summary>
        /// Kod stillerini karşılaştırma
        /// </summary>
        public static void KodStiliKarsilastirma()
        {
            Console.WriteLine("\n=== KOD STİLLERİ KARŞILAŞTIRMA ===");

            Console.WriteLine("\n1. CAMELCASE vs PASCALCASE:");
            Console.WriteLine("camelCase:");
            Console.WriteLine("  - Değişkenler: string ogrenciAdi");
            Console.WriteLine("  - Parametreler: void Metot(int sayi)");
            Console.WriteLine("  - Private alanlar: private int _sayac");
            Console.WriteLine("\nPascalCase:");
            Console.WriteLine("  - Sınıflar: public class Ogrenci");
            Console.WriteLine("  - Metotlar: public void NotHesapla()");
            Console.WriteLine("  - Özellikler: public string Isim { get; set; }");

            Console.WriteLine("\n2. SUSLU PARANTEZ KULLANIMI:");
            Console.WriteLine("Tek satırlık if için:");
            Console.WriteLine("  if (kosul) TekIslem(); // Parantez olmadan");
            Console.WriteLine("  if (kosul) { TekIslem(); } // Parantez ile (önerilir)");

            Console.WriteLine("\n3. BOŞLUK KULLANIMI:");
            Console.WriteLine("Operatörlerde:");
            Console.WriteLine("  int toplam = sayi1 + sayi2; // Boşluk var");
            Console.WriteLine("  int toplam=sayi1+sayi2; // Boşluk yok (kötü)");

            Console.WriteLine("\n4. GİRİNTİ (INDENTATION):");
            Console.WriteLine("  - Tab veya 4 boşluk kullanılabilir");
            Console.WriteLine("  - Proje genelinde tutarlı olmalı");

            Console.WriteLine("\n5. YORUMLAR:");
            Console.WriteLine("  // Tek satır yorum");
            Console.WriteLine("  /* Çok satırlı yorum */");
            Console.WriteLine("  /// XML dokümantasyon yorumu");
        }

        /// <summary>
        /// Öğrenci proje önerileri
        /// </summary>
        public static void ProjeOnerileri()
        {
            Console.WriteLine("\n=== ÖĞRENCİ PROJE ÖNERİLERİ ===");

            Console.WriteLine("\n1. BAŞLANGIÇ SEVİYESİ:");
            Console.WriteLine("   ✓ Hesap makinesi");
            Console.WriteLine("   ✓ Not hesaplayıcı");
            Console.WriteLine("   ✓ Sayı tahmin oyunu");
            Console.WriteLine("   ✓ Basit ATM simülasyonu");
            Console.WriteLine("   ✓ To-do list uygulaması");

            Console.WriteLine("\n2. ORTA SEVİYE:");
            Console.WriteLine("   ✓ Öğrenci kayıt sistemi");
            Console.WriteLine("   ✓ Kütüphane yönetim sistemi");
            Console.WriteLine("   ✓ Quiz uygulaması");
            Console.WriteLine("   ✓ Basit banka hesap yönetimi");
            Console.WriteLine("   ✓ Kelime oyunu (Hangman)");

            Console.WriteLine("\n3. İLERİ SEVİYE:");
            Console.WriteLine("   ✓ Dosya yönetim sistemi");
            Console.WriteLine("   ✓ CSV/JSON veri işleme");
            Console.WriteLine("   ✓ Veritabani bağlantılı uygulamalar");
            Console.WriteLine("   ✓ REST API tüketici uygulaması");
            Console.WriteLine("   ✓ Multi-threaded uygulamalar");

            Console.WriteLine("\n=== PROJE GELİŞTİRME ADIMLARI ===");
            Console.WriteLine("1. İhtiyaçları belirle");
            Console.WriteLine("2. Senaryoları yaz");
            Console.WriteLine("3. Kod yapısını planla");
            Console.WriteLine("4. Küçük parçalara böl");
            Console.WriteLine("5. Her parçayı test et");
            Console.WriteLine("6. Kodları birleştir");
            Console.WriteLine("7. Hataları düzelt");
            Console.WriteLine("8. İyileştirmeler yap");
        }

        /// <summary>
        /// Kod kalitesi kontrol listesi
        /// </summary>
        public static void KodKalitesiKontrolListesi()
        {
            Console.WriteLine("\n=== KOD KALİTESİ KONTROL LİSTESİ ===");

            Console.WriteLine("\n✓ İSİMLENDİRME:");
            Console.WriteLine("  [ ] Değişken isimleri anlamlı mı?");
            Console.WriteLine("  [ ] Metot isimleri ne yaptığını açıklıyor mu?");
            Console.WriteLine("  [ ] Sınıf isimleri tek bir sorumluluğu mu gösteriyor?");
            Console.WriteLine("  [ ] İsimlendirme tutarlı mı (camelCase/PascalCase)?");

            Console.WriteLine("\n✓ YAPISAL:");
            Console.WriteLine("  [ ] Metotlar çok uzun değil mi? (max 20-30 satır)");
            Console.WriteLine("  [ ] Kod tekrarı var mı?");
            Console.WriteLine("  [ ] Magic numbers yerine sabitler kullanılmış mı?");
            Console.WriteLine("  [ ] Gereksiz yorumlar temizlenmiş mi?");

            Console.WriteLine("\n✓ HATA YÖNETİMİ:");
            Console.WriteLine("  [ ] Null kontrolleri yapılmış mı?");
            Console.WriteLine("  [ ] Try-catch blokları uygun yerlerde mi?");
            Console.WriteLine("  [ ] Kullanıcı girdileri doğrulanmış mı?");
            Console.WriteLine("  [ ] Hata mesajları anlaşılır mı?");

            Console.WriteLine("\n✓ OKUNABİLİRLİK:");
            Console.WriteLine("  [ ] Kod akışı mantıklı mı?");
            Console.WriteLine("  [ ] Gereksiz karmaşıklık var mı?");
            Console.WriteLine("  [ ] Kod yorumları yeterli mi?");
            Console.WriteLine("  [ ] Formatlama tutarlı mı?");
        }

        /// <summary>
        /// Yaygın hatalar ve çözümleri
        /// </summary>
        public static void YayginHatalar()
        {
            Console.WriteLine("\n=== YAYGIN HATALAR VE ÇÖZÜMLERİ ===");

            Console.WriteLine("\n1. NULL REFERENCE EXCEPTION:");
            Console.WriteLine("HATALI:");
            Console.WriteLine("  string metin = null;");
            Console.WriteLine("  int uzunluk = metin.Length;");
            Console.WriteLine("ÇÖZÜM:");
            Console.WriteLine("  string? metin = null;");
            Console.WriteLine("  int uzunluk = metin?.Length ?? 0;");

            Console.WriteLine("\n2. INDEX OUT OF RANGE:");
            Console.WriteLine("HATALI:");
            Console.WriteLine("  int[] dizi = {1, 2, 3};");
            Console.WriteLine("  int eleman = dizi[5];");
            Console.WriteLine("ÇÖZÜM:");
            Console.WriteLine("  if (indis >= 0 && indis < dizi.Length)");
            Console.WriteLine("  {");
            Console.WriteLine("      int eleman = dizi[indis];");
            Console.WriteLine("  }");

            Console.WriteLine("\n3. DIVIDE BY ZERO:");
            Console.WriteLine("HATALI:");
            Console.WriteLine("  int sonuc = sayi1 / sayi2;");
            Console.WriteLine("ÇÖZÜM:");
            Console.WriteLine("  if (sayi2 != 0)");
            Console.WriteLine("  {");
            Console.WriteLine("      int sonuc = sayi1 / sayi2;");
            Console.WriteLine("  }");

            Console.WriteLine("\n4. TÜR DÖNÜŞÜMÜ HATALARI:");
            Console.WriteLine("HATALI:");
            Console.WriteLine("  int sayi = int.Parse(\"abc\"); // FormatException");
            Console.WriteLine("ÇÖZÜM:");
            Console.WriteLine("  if (int.TryParse(\"abc\", out int sayi))");
            Console.WriteLine("  {");
            Console.WriteLine("      // Başarılı");
            Console.WriteLine("  }");

            Console.WriteLine("\n5. SONSUZ DÖNGÜ:");
            Console.WriteLine("HATALI:");
            Console.WriteLine("  while (true) { } // Çıkış koşulu yok");
            Console.WriteLine("ÇÖZÜM:");
            Console.WriteLine("  bool devam = true;");
            Console.WriteLine("  while (devam)");
            Console.WriteLine("  {");
            Console.WriteLine("      if (cikisKosulu) devam = false;");
            Console.WriteLine("  }");
        }

        /// <summary>
        /// Özet ve sonraki adımlar
        /// </summary>
        public static void OzetVeSonrakiAdimlar()
        {
            Console.WriteLine("\n=== ÖZET VE SONRAKİ ADIMLAR ===");

            Console.WriteLine("\n✓ ÖĞRENİLEN KONULAR:");
            Console.WriteLine("  1. Program yapısı ve namespace");
            Console.WriteLine("  2. Veri türleri ve değişkenler");
            Console.WriteLine("  3. Operatörler ve ifadeler");
            Console.WriteLine("  4. Karar yapıları (if, switch)");
            Console.WriteLine("  5. Döngüler (for, while, foreach)");
            Console.WriteLine("  6. Diziler ve koleksiyonlar");
            Console.WriteLine("  7. Metotlar ve parametreler");
            Console.WriteLine("  8. Girdi/çıktı işlemleri");
            Console.WriteLine("  9. Temel uygulama senaryoları");

            Console.WriteLine("\n📚 SONRAKİ ADIMLAR:");
            Console.WriteLine("  1. Nesne Yönelimli Programlama (OOP)");
            Console.WriteLine("     - Sınıf ve nesne kavramı");
            Console.WriteLine("     - Encapsulation (Kapsülleme)");
            Console.WriteLine("     - Inheritance (Kalıtım)");
            Console.WriteLine("     - Polymorphism (Çok biçimlilik)");
            Console.WriteLine("  2. İleri C# Konuları");
            Console.WriteLine("     - Generic sınıflar");
            Console.WriteLine("     - LINQ");
            Console.WriteLine("     - Async/Await");
            Console.WriteLine("     - Delegates ve Events");
            Console.WriteLine("  3. .NET Framework Bilgileri");
            Console.WriteLine("     - Collections (List, Dictionary)");
            Console.WriteLine("     - Exception Handling");
            Console.WriteLine("     - File I/O");
            Console.WriteLine("     - Serialization");

            Console.WriteLine("\n💡 TAVSİYELER:");
            Console.WriteLine("  - Düzenli pratik yapın");
            Console.WriteLine("  - Kod örneklerini çalıştırın");
            Console.WriteLine("  - Hataları kendiniz çözmeye çalışın");
            Console.WriteLine("  - Başkalarının kodlarını okuyun");
            Console.WriteLine("  - Projeler geliştirin");
            Console.WriteLine("  - Dokümantasyon okuyun");

            Console.WriteLine("\n🎓 BAŞARILAR!");
        }
    }
}

