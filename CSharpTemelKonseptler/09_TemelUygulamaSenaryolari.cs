using System;
using System.Text.RegularExpressions;

namespace CSharpTemelKonseptler
{
    /// <summary>
    /// 9. TEMEL UYGULAMA SENARYOLARI
    /// Mini hesap makinesi, not hesaplayıcı, regex doğrulama, görev planlayıcı, sayı tahmin oyunu içerir.
    /// </summary>
    public class TemelUygulamaSenaryolari
    {
        /// <summary>
        /// Mini Hesap Makinesi (operatörler + metotlar)
        /// </summary>
        public static void MiniHesapMakinesi()
        {
            Console.WriteLine("=== MİNİ HESAP MAKİNESİ ===");

            double sayi1 = 10;
            double sayi2 = 5;
            char islem = '+';

            // Gerçek uygulamada kullanıcıdan alınır:
            // Console.Write("Birinci sayı: ");
            // double sayi1 = double.Parse(Console.ReadLine());
            // Console.Write("İkinci sayı: ");
            // double sayi2 = double.Parse(Console.ReadLine());
            // Console.Write("İşlem (+, -, *, /): ");
            // char islem = Console.ReadKey().KeyChar;

            double sonuc = HesapYap(sayi1, sayi2, islem);
            Console.WriteLine($"\n{sayi1} {islem} {sayi2} = {sonuc}");

            // Farklı işlemler
            Console.WriteLine($"\n10 + 5 = {HesapYap(10, 5, '+')}");
            Console.WriteLine($"10 - 5 = {HesapYap(10, 5, '-')}");
            Console.WriteLine($"10 * 5 = {HesapYap(10, 5, '*')}");
            Console.WriteLine($"10 / 5 = {HesapYap(10, 5, '/')}");
        }

        private static double HesapYap(double a, double b, char islem)
        {
            return islem switch
            {
                '+' => a + b,
                '-' => a - b,
                '*' => a * b,
                '/' => b != 0 ? a / b : throw new DivideByZeroException("Sıfıra bölme hatası!"),
                _ => throw new ArgumentException("Geçersiz işlem!")
            };
        }

        /// <summary>
        /// Not Hesaplayıcı (if/switch yapısı)
        /// </summary>
        public static void NotHesaplayici()
        {
            Console.WriteLine("\n=== NOT HESAPLAYICI ===");

            // Vize ve final notları
            double[] vizeNotlari = { 70, 85, 60, 90, 75 };
            double[] finalNotlari = { 80, 90, 70, 95, 85 };

            for (int i = 0; i < vizeNotlari.Length; i++)
            {
                double vize = vizeNotlari[i];
                double final = finalNotlari[i];

                // Vize %40, Final %60
                double ortalama = (vize * 0.4) + (final * 0.6);
                string harfNotu = HarfNotuHesapla(ortalama);
                string durum = ortalama >= 50 ? "GEÇTİ" : "KALDI";

                Console.WriteLine($"Öğrenci {i + 1}: Vize={vize}, Final={final}, Ortalama={ortalama:F2}, Harf={harfNotu}, Durum={durum}");
            }
        }

        private static string HarfNotuHesapla(double ortalama)
        {
            return ortalama switch
            {
                >= 90 => "AA",
                >= 80 => "BA",
                >= 70 => "BB",
                >= 60 => "CB",
                >= 50 => "CC",
                _ => "FF"
            };
        }

        /// <summary>
        /// Dizi Ortalama Hesaplama
        /// </summary>
        public static void DiziOrtalamaHesaplama()
        {
            Console.WriteLine("\n=== DİZİ ORTALAMA HESAPLAMA ===");

            // Rastgele sayı dizisi
            int[] sayilar = { 15, 25, 35, 45, 55, 65, 75, 85, 95 };

            Console.WriteLine("Sayılar:");
            foreach (int sayi in sayilar)
            {
                Console.Write($"{sayi} ");
            }
            Console.WriteLine();

            // Toplam hesaplama
            int toplam = 0;
            foreach (int sayi in sayilar)
            {
                toplam += sayi;
            }

            // Ortalama hesaplama
            double ortalama = (double)toplam / sayilar.Length;

            Console.WriteLine($"\nToplam: {toplam}");
            Console.WriteLine($"Eleman sayısı: {sayilar.Length}");
            Console.WriteLine($"Ortalama: {ortalama:F2}");

            // Ortalamadan büyük sayılar
            Console.WriteLine("\nOrtalamadan büyük sayılar:");
            int sayac = 0;
            foreach (int sayi in sayilar)
            {
                if (sayi > ortalama)
                {
                    Console.WriteLine($"  {sayi} (ortalama +{sayi - ortalama:F2})");
                    sayac++;
                }
            }
            Console.WriteLine($"Toplam {sayac} sayı ortalamadan büyük");
        }

        /// <summary>
        /// Regex ile e-posta doğrulama
        /// </summary>
        public static void EmailDogrulama()
        {
            Console.WriteLine("\n=== REGEX İLE E-POSTA DOĞRULAMA ===");

            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            string[] emailOrnekleri = {
                "ornek@email.com",
                "test.user123@domain.co.uk",
                "isim_soyad@subdomain.example.com",
                "gecersiz.email",
                "@domain.com",
                "user@",
                "user@domain",
                "user name@domain.com", // Boşluk içeriyor
                "user+tag@example.com"
            };

            Console.WriteLine("E-posta doğrulama sonuçları:\n");
            foreach (string email in emailOrnekleri)
            {
                bool gecerli = Regex.IsMatch(email, emailPattern);
                string durum = gecerli ? "✓ GEÇERLİ" : "✗ GEÇERSİZ";
                Console.WriteLine($"{durum,-12} : {email}");
            }

            // Detaylı doğrulama metodu
            Console.WriteLine("\n=== DETAYLI E-POSTA DOĞRULAMA ===");
            string[] detayliEmailOrnekleri = {
                "ali.veli@example.com",
                "test123@mail.co.uk",
                "user_name@sub.domain.example.org"
            };

            foreach (string email in detayliEmailOrnekleri)
            {
                DogrulaEmail(email);
            }
        }

        private static void DogrulaEmail(string email)
        {
            string pattern = @"^([a-zA-Z0-9._%+-]+)@([a-zA-Z0-9.-]+)\.([a-zA-Z]{2,})$";
            Match match = Regex.Match(email, pattern);

            if (match.Success)
            {
                Console.WriteLine($"\nE-posta: {email}");
                Console.WriteLine($"  Kullanıcı adı: {match.Groups[1].Value}");
                Console.WriteLine($"  Domain: {match.Groups[2].Value}");
                Console.WriteLine($"  Uzantı: {match.Groups[3].Value}");
            }
            else
            {
                Console.WriteLine($"\nGeçersiz e-posta: {email}");
            }
        }

        /// <summary>
        /// Haftalık Görev Planlayıcı (enum + switch)
        /// </summary>
        public enum HaftaninGunleri
        {
            Pazartesi,
            Sali,
            Carsamba,
            Persembe,
            Cuma,
            Cumartesi,
            Pazar
        }

        public static void HaftalikGorevPlanlayici()
        {
            Console.WriteLine("\n=== HAFTALIK GÖREV PLANLAYICI ===");

            // Haftalık görevler
            Dictionary<HaftaninGunleri, string[]> gorevler = new Dictionary<HaftaninGunleri, string[]>
            {
                { HaftaninGunleri.Pazartesi, new string[] { "Toplantı", "Rapor hazırlama", "Kod yazma" } },
                { HaftaninGunleri.Sali, new string[] { "Test yazma", "Dokümantasyon" } },
                { HaftaninGunleri.Carsamba, new string[] { "Code review", "Refactoring" } },
                { HaftaninGunleri.Persembe, new string[] { "Müşteri görüşmesi", "Sunum hazırlama" } },
                { HaftaninGunleri.Cuma, new string[] { "Haftalık rapor", "Hafta sonu planı" } },
                { HaftaninGunleri.Cumartesi, new string[] { "Dinlenme", "Hobi" } },
                { HaftaninGunleri.Pazar, new string[] { "Dinlenme", "Aile zamanı" } }
            };

            // Her gün için görevleri listele
            foreach (var gun in Enum.GetValues(typeof(HaftaninGunleri)).Cast<HaftaninGunleri>())
            {
                Console.WriteLine($"\n{gun}:");
                if (gorevler.ContainsKey(gun))
                {
                    int sira = 1;
                    foreach (string gorev in gorevler[gun])
                    {
                        Console.WriteLine($"  {sira}. {gorev}");
                        sira++;
                    }
                }

                // Günlük özel mesaj
                string mesaj = GunMesaji(gun);
                Console.WriteLine($"  → {mesaj}");
            }

            // Belirli bir günün görevlerini göster
            Console.WriteLine("\n=== BELİRLİ BİR GÜNÜN GÖREVLERİ ===");
            HaftaninGunleri secilenGun = HaftaninGunleri.Cuma;
            GorevleriGoster(secilenGun, gorevler);
        }

        private static string GunMesaji(HaftaninGunleri gun)
        {
            return gun switch
            {
                HaftaninGunleri.Pazartesi => "Haftanın başlangıcı!",
                HaftaninGunleri.Cuma => "Hafta sonu yaklaşıyor!",
                HaftaninGunleri.Cumartesi or HaftaninGunleri.Pazar => "Hafta sonu - Dinlenme zamanı!",
                _ => "Çalışma günü - Devam!"
            };
        }

        private static void GorevleriGoster(HaftaninGunleri gun, Dictionary<HaftaninGunleri, string[]> gorevler)
        {
            Console.WriteLine($"\n{gun} gününün görevleri:");
            if (gorevler.ContainsKey(gun))
            {
                foreach (string gorev in gorevler[gun])
                {
                    Console.WriteLine($"  ✓ {gorev}");
                }
            }
        }

        /// <summary>
        /// Sayı Tahmin Oyunu (döngü + koşul kombinasyonu)
        /// </summary>
        public static void SayiTahminOyunu()
        {
            Console.WriteLine("\n=== SAYI TAHMİN OYUNU ===");

            // Rastgele sayı üret (1-100 arası)
            Random rastgele = new Random();
            int hedefSayi = rastgele.Next(1, 101);
            int tahminSayisi = 0;
            int maksimumTahmin = 7;

            Console.WriteLine("1 ile 100 arasında bir sayı tahmin edin!");
            Console.WriteLine($"Maksimum {maksimumTahmin} hakkınız var.\n");

            // Gerçek uygulamada kullanıcıdan alınır
            int[] ornekTahminler = { 50, 75, 63, 69, 66, 67, 68 }; // Simüle edilmiş tahminler

            foreach (int tahmin in ornekTahminler)
            {
                tahminSayisi++;
                Console.WriteLine($"Tahmin #{tahminSayisi}: {tahmin}");

                if (tahmin == hedefSayi)
                {
                    Console.WriteLine($"\n🎉 TEBRİKLER! {tahminSayisi}. denemede bildiniz!");
                    Console.WriteLine($"Hedef sayı: {hedefSayi}");
                    break;
                }
                else if (tahminSayisi >= maksimumTahmin)
                {
                    Console.WriteLine($"\n❌ Hakkınız bitti! Hedef sayı: {hedefSayi}");
                    break;
                }
                else if (tahmin < hedefSayi)
                {
                    int kalanHak = maksimumTahmin - tahminSayisi;
                    Console.WriteLine($"  ⬆️  Daha yüksek bir sayı girin (Kalan hak: {kalanHak})");
                }
                else
                {
                    int kalanHak = maksimumTahmin - tahminSayisi;
                    Console.WriteLine($"  ⬇️  Daha düşük bir sayı girin (Kalan hak: {kalanHak})");
                }

                // Gerçek uygulamada:
                // if (tahminSayisi >= maksimumTahmin)
                // {
                //     Console.WriteLine($"Hakkınız bitti! Hedef sayı: {hedefSayi}");
                //     break;
                // }
                // Console.Write("Yeni tahmin: ");
                // tahmin = int.Parse(Console.ReadLine());
            }

            // Oyun istatistikleri
            Console.WriteLine($"\n=== OYUN İSTATİSTİKLERİ ===");
            Console.WriteLine($"Hedef sayı: {hedefSayi}");
            Console.WriteLine($"Toplam tahmin: {tahminSayisi}");
            Console.WriteLine($"Kalan hak: {maksimumTahmin - tahminSayisi}");

            if (tahminSayisi <= 3)
            {
                Console.WriteLine("Mükemmel oyun! ⭐⭐⭐");
            }
            else if (tahminSayisi <= 5)
            {
                Console.WriteLine("İyi oyun! ⭐⭐");
            }
            else
            {
                Console.WriteLine("Daha çok pratik yapmalısınız! ⭐");
            }
        }

        /// <summary>
        /// Bileşik örnek: Öğrenci Not Sistemi
        /// </summary>
        public static void OgrenciNotSistemi()
        {
            Console.WriteLine("\n=== ÖĞRENCİ NOT SİSTEMİ ===");

            // Öğrenci bilgileri
            string[] ogrenciIsimleri = { "Ali", "Veli", "Ayşe", "Mehmet", "Fatma" };
            double[][] notlar = new double[][]
            {
                new double[] { 85, 90, 78 }, // Ali
                new double[] { 92, 88, 95 }, // Veli
                new double[] { 75, 80, 70 },  // Ayşe
                new double[] { 88, 85, 90 }, // Mehmet
                new double[] { 95, 92, 98 }  // Fatma
            };

            Console.WriteLine("Öğrenci Not Raporu:\n");
            Console.WriteLine($"{"Öğrenci",-10} {"Vize",-8} {"Final",-8} {"Proje",-8} {"Ortalama",-10} {"Harf",-6} {"Durum"}");
            Console.WriteLine(new string('-', 60));

            for (int i = 0; i < ogrenciIsimleri.Length; i++)
            {
                double vize = notlar[i][0];
                double final = notlar[i][1];
                double proje = notlar[i][2];

                // Ağırlıklı ortalama: Vize %30, Final %50, Proje %20
                double ortalama = (vize * 0.3) + (final * 0.5) + (proje * 0.2);
                string harfNotu = HarfNotuHesapla(ortalama);
                string durum = ortalama >= 50 ? "GEÇTİ" : "KALDI";

                Console.WriteLine($"{ogrenciIsimleri[i],-10} {vize,-8:F1} {final,-8:F1} {proje,-8:F1} {ortalama,-10:F2} {harfNotu,-6} {durum}");
            }

            // Sınıf ortalaması
            double toplamOrtalama = 0;
            foreach (var ogrenciNotlari in notlar)
            {
                double ogrenciOrt = (ogrenciNotlari[0] * 0.3) + (ogrenciNotlari[1] * 0.5) + (ogrenciNotlari[2] * 0.2);
                toplamOrtalama += ogrenciOrt;
            }
            double sinifOrtalamasi = toplamOrtalama / notlar.Length;

            Console.WriteLine(new string('-', 60));
            Console.WriteLine($"Sınıf Ortalaması: {sinifOrtalamasi:F2}");
        }
    }
}

