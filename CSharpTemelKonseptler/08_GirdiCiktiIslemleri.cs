using System;
using System.Globalization;

namespace CSharpTemelKonseptler
{
    /// <summary>
    /// 8. GİRDİ / ÇIKTI İŞLEMLERİ (INPUT / OUTPUT)
    /// Console işlemleri, string formatlama, hata yönetimi içerir.
    /// </summary>
    public class GirdiCiktiIslemleri
    {
        /// <summary>
        /// Console.ReadLine() ve Console.Write() farkı
        /// </summary>
        public static void ConsoleFarki()
        {
            Console.WriteLine("=== CONSOLE FARKLARI ===");

            // Console.WriteLine() - Yazdırır ve satır sonu ekler
            Console.WriteLine("Bu bir WriteLine örneği");
            Console.WriteLine("Her satır yeni bir satıra yazılır");

            // Console.Write() - Yazdırır ama satır sonu eklemez
            Console.Write("Bu bir ");
            Console.Write("Write örneği ");
            Console.Write("- hepsi aynı satırda");
            Console.WriteLine(); // Satır sonu için

            // Console.Read() - Tek karakter okur, ASCII kodu döner
            // Console.ReadKey() - Tek tuş okur, ConsoleKeyInfo döner

            // Console.ReadLine() - Kullanıcıdan satır okur
            Console.WriteLine("\nÖrnek kullanım:");
            // Console.WriteLine(Environment.NewLine + "Örnek kullanım:");
            Console.Write("Lütfen bir metin girin: ");
            // string girdi = Console.ReadLine();
            string ornekGirdi = "Merhaba C#"; // Simüle edilmiş
            Console.WriteLine($"Girdiğiniz metin: {ornekGirdi}");
        }

        /// <summary>
        /// Kullanıcı girdisi alma ve dönüştürme
        /// </summary>
        public static void KullaniciGirdisiAlma()
        {
            Console.WriteLine("\n=== KULLANICI GİRDİSİ ALMA ===");

            // String girdi
            Console.Write("İsminizi girin: ");
            string isim = "Ahmet"; // Simüle: Console.ReadLine();
            Console.WriteLine($"Merhaba {isim}!");

            // Sayısal girdi - Parse ile
            Console.Write("\nYaşınızı girin: ");
            string yasGirdisi = "25"; // Simüle: Console.ReadLine();
            try
            {
                int yas = int.Parse(yasGirdisi);
                Console.WriteLine($"Yaşınız: {yas}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Geçersiz sayı formatı!");
            }

            // Güvenli sayısal girdi - TryParse ile
            Console.Write("\nBir sayı girin: ");
            string sayiGirdisi = "abc"; // Simüle: Console.ReadLine();
            if (int.TryParse(sayiGirdisi, out int sayi))
            {
                Console.WriteLine($"Girdiğiniz sayı: {sayi}");
            }
            else
            {
                Console.WriteLine("Geçersiz sayı! Varsayılan değer kullanılacak.");
                sayi = 0;
            }

            // Birden fazla girdi
            Console.WriteLine("\nBirden fazla girdi örneği:");
            Console.Write("Adınız: ");
            string ad = "Ali"; // Simüle
            Console.Write("Soyadınız: ");
            string soyad = "Veli"; // Simüle
            Console.WriteLine($"Tam adınız: {ad} {soyad}");

            // Double girdi
            Console.Write("\nOndalıklı bir sayı girin: ");
            string ondalikGirdi = "3.14"; // Simüle
            if (double.TryParse(ondalikGirdi, NumberStyles.Float, CultureInfo.InvariantCulture, out double ondalik))
            {
                Console.WriteLine($"Girdiğiniz ondalık sayı: {ondalik}");
            }
        }

        /// <summary>
        /// String formatlama ($"", string.Format, ToString)
        /// </summary>
        public static void StringFormatlama()
        {
            Console.WriteLine("\n=== STRING FORMATLAMA ===");

            string isim = "Ahmet";
            int yas = 25;
            double maas = 5000.50;

            // 1. String Interpolation ($"") - Önerilen yöntem (C# 6.0+)
            string mesaj1 = $"İsim: {isim}, Yaş: {yas}, Maaş: {maas}";
            Console.WriteLine($"String Interpolation: {mesaj1}");

            // Format belirleyiciler
            string mesaj2 = $"Maaş: {maas:C}"; // Para formatı
            Console.WriteLine($"Para formatı: {mesaj2}");

            string mesaj3 = $"Ondalık: {maas:F2}"; // 2 ondalık basamak
            Console.WriteLine($"Ondalık format: {mesaj3}");

            string mesaj4 = $"Sayı: {maas:N2}"; // Sayı formatı
            Console.WriteLine($"Sayı formatı: {mesaj4}");

            // 2. string.Format() - Geleneksel yöntem
            string mesaj5 = string.Format("İsim: {0}, Yaş: {1}, Maaş: {2:C}", isim, yas, maas);
            Console.WriteLine($"string.Format: {mesaj5}");

            // 3. ToString() formatlama
            string mesaj6 = maas.ToString("C"); // Para formatı
            Console.WriteLine($"ToString para: {mesaj6}");

            string mesaj7 = yas.ToString("D4"); // 4 haneli sayı (0025)
            Console.WriteLine($"ToString sayı: {mesaj7}");

            // 4. Composite Formatting
            Console.WriteLine("Composite: İsim: {0}, Yaş: {1}", isim, yas);

            // Tarih formatlama
            DateTime tarih = DateTime.Now;
            Console.WriteLine($"Tarih (kısa): {tarih:d}");
            Console.WriteLine($"Tarih (uzun): {tarih:D}");
            Console.WriteLine($"Tarih (tam): {tarih:F}");
            Console.WriteLine($"Tarih (özel): {tarih:dd.MM.yyyy HH:mm}");

            // Format örnekleri
            int sayi = 12345;
            Console.WriteLine($"\nFormat örnekleri (sayı: {sayi}):");
            Console.WriteLine($"C (Para): {sayi:C}");
            Console.WriteLine($"N (Sayı): {sayi:N}");
            Console.WriteLine($"D (Ondalıksız): {sayi:D8}");
            Console.WriteLine($"X (Hex): {sayi:X}");
            Console.WriteLine($"E (Bilimsel): {sayi:E}");
        }

        /// <summary>
        /// Basit hata yönetimi (try-catch)
        /// </summary>
        public static void HataYonetimi()
        {
            Console.WriteLine("\n=== HATA YÖNETİMİ (TRY-CATCH) ===");

            // Try-Catch temel kullanım
            try
            {
                int sayi1 = 10;
                int sayi2 = 0;
                int sonuc = sayi1 / sayi2; // DivideByZeroException
                Console.WriteLine($"Sonuç: {sonuc}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Hata: Sıfıra bölme hatası - {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Genel hata: {ex.Message}");
            }

            // Try-Catch-Finally
            Console.WriteLine("\nTry-Catch-Finally örneği:");
            try
            {
                int[] dizi = { 1, 2, 3 };
                Console.WriteLine($"Dizi elemanı: {dizi[10]}"); // IndexOutOfRangeException
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Hata: Geçersiz dizi indisi - {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finally bloğu her zaman çalışır");
            }

            // TryParse ile güvenli dönüşüm
            Console.WriteLine("\nTryParse örneği:");
            string[] girdiler = { "123", "abc", "45.67", "-10" };
            foreach (string girdi in girdiler)
            {
                if (int.TryParse(girdi, out int sayi))
                {
                    Console.WriteLine($"'{girdi}' geçerli bir tam sayı: {sayi}");
                }
                else
                {
                    Console.WriteLine($"'{girdi}' geçerli bir tam sayı değil");
                }
            }
        }

        /// <summary>
        /// Kullanıcı hatalarına karşı savunmalı kodlama
        /// </summary>
        public static void SavunmaliKodlama()
        {
            Console.WriteLine("\n=== SAVUNMALI KODLAMA ===");

            // Örnek 1: Sayı girişi kontrolü
            int sayi = SayiGirisiAl("Bir sayı girin (1-100 arası): ", 1, 100);
            Console.WriteLine($"Girdiğiniz sayı: {sayi}");

            // Örnek 2: Evet/Hayır sorusu
            bool cevap = EvetHayirSorusu("Devam etmek istiyor musunuz? (e/h): ");
            Console.WriteLine($"Cevap: {(cevap ? "Evet" : "Hayır")}");

            // Örnek 3: Menü seçimi
            int secim = MenuSecimi("1- Toplama\n2- Çıkarma\n3- Çarpma\nSeçiminiz: ", 1, 3);
            Console.WriteLine($"Seçiminiz: {secim}");
        }

        // Güvenli sayı girişi metodu
        private static int SayiGirisiAl(string mesaj, int min, int max)
        {
            // Gerçek uygulamada:
            // while (true)
            // {
            //     Console.Write(mesaj);
            //     string girdi = Console.ReadLine();
            //     if (int.TryParse(girdi, out int sayi) && sayi >= min && sayi <= max)
            //     {
            //         return sayi;
            //     }
            //     Console.WriteLine($"Lütfen {min} ile {max} arasında bir sayı girin!");
            // }

            // Örnek için simüle edilmiş
            Console.Write(mesaj);
            string ornekGirdi = "50"; // Simüle
            if (int.TryParse(ornekGirdi, out int sayi) && sayi >= min && sayi <= max)
            {
                return sayi;
            }
            return min; // Varsayılan
        }

        // Evet/Hayır sorusu metodu
        private static bool EvetHayirSorusu(string mesaj)
        {
            // Gerçek uygulamada:
            // while (true)
            // {
            //     Console.Write(mesaj);
            //     string girdi = Console.ReadLine()?.ToLower();
            //     if (girdi == "e" || girdi == "evet")
            //         return true;
            //     if (girdi == "h" || girdi == "hayır")
            //         return false;
            //     Console.WriteLine("Lütfen 'e' veya 'h' girin!");
            // }

            // Örnek için simüle edilmiş
            Console.Write(mesaj);
            string ornekGirdi = "e"; // Simüle
            return ornekGirdi?.ToLower() == "e" || ornekGirdi?.ToLower() == "evet";
        }

        // Menü seçimi metodu
        private static int MenuSecimi(string mesaj, int minSecim, int maxSecim)
        {
            // Gerçek uygulamada:
            // while (true)
            // {
            //     Console.Write(mesaj);
            //     string girdi = Console.ReadLine();
            //     if (int.TryParse(girdi, out int secim) && secim >= minSecim && secim <= maxSecim)
            //     {
            //         return secim;
            //     }
            //     Console.WriteLine($"Lütfen {minSecim} ile {maxSecim} arasında bir seçim yapın!");
            // }

            // Örnek için simüle edilmiş
            Console.Write(mesaj);
            string ornekGirdi = "2"; // Simüle
            if (int.TryParse(ornekGirdi, out int secim) && secim >= minSecim && secim <= maxSecim)
            {
                return secim;
            }
            return minSecim; // Varsayılan
        }

        /// <summary>
        /// Console renkleri ve formatlama
        /// </summary>
        public static void ConsoleRenkleri()
        {
            Console.WriteLine("\n=== CONSOLE RENKLERİ ===");

            // Önceki rengi sakla
            ConsoleColor oncekiRenk = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Kırmızı metin");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Yeşil metin");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Mavi metin");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Sarı metin");

            // Arka plan rengi
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Beyaz metin, mavi arka plan");

            // Renkleri sıfırla
            Console.ResetColor();
            Console.WriteLine("Varsayılan renkler");

            // Önceki rengi geri yükle
            Console.ForegroundColor = oncekiRenk;
        }

        /// <summary>
        /// Dosya okuma/yazma örnekleri (temel)
        /// </summary>
        public static void DosyaIslemleri()
        {
            Console.WriteLine("\n=== DOSYA İŞLEMLERİ (TEMEL) ===");
            Console.WriteLine("Not: Dosya işlemleri System.IO namespace'i gerektirir");
            Console.WriteLine("Örnek kullanımlar:");

            // Dosya yazma örneği (yorum satırı)
            // using System.IO;
            // string dosyaYolu = "ornek.txt";
            // File.WriteAllText(dosyaYolu, "Merhaba Dünya!");
            // Console.WriteLine("Dosya yazıldı");

            // Dosya okuma örneği (yorum satırı)
            // string icerik = File.ReadAllText(dosyaYolu);
            // Console.WriteLine($"Dosya içeriği: {icerik}");

            Console.WriteLine("Dosya işlemleri için System.IO.File sınıfı kullanılır");
        }
    }
}

