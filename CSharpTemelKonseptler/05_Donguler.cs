using System;
using System.Collections.Generic;

namespace CSharpTemelKonseptler
{
    /// <summary>
    /// 5. DÖNGÜLER (LOOPS)
    /// for, while, do-while, foreach döngüleri ve kontrol komutları içerir.
    /// </summary>
    public class Donguler
    {
        /// <summary>
        /// for döngüsü temelleri
        /// </summary>
        public static void ForDongusu()
        {
            Console.WriteLine("=== FOR DÖNGÜSÜ ===");

            // Temel for döngüsü
            // for (başlangıç; koşul; artırma/azaltma)
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Döngü iterasyonu: {i}");
            }

            // Farklı kullanımlar
            Console.WriteLine("\n1'den 10'a kadar sayılar:");
            for (int sayi = 1; sayi <= 10; sayi++)
            {
                Console.Write($"{sayi} ");
            }
            Console.WriteLine();

            // Geriye doğru sayma
            Console.WriteLine("\n10'dan 1'e kadar sayılar:");
            for (int sayi = 10; sayi >= 1; sayi--)
            {
                Console.Write($"{sayi} ");
            }
            Console.WriteLine();

            // İkişer artırma
            Console.WriteLine("\n0'dan 20'ye kadar çift sayılar:");
            for (int sayi = 0; sayi <= 20; sayi += 2)
            {
                Console.Write($"{sayi} ");
            }
            Console.WriteLine();

            // Birden fazla değişken
            for (int i = 0, j = 10; i < 5 && j > 5; i++, j--)
            {
                Console.WriteLine($"i = {i}, j = {j}");
            }
        }

        /// <summary>
        /// while ve do-while farkı
        /// </summary>
        public static void WhileVeDoWhile()
        {
            Console.WriteLine("\n=== WHILE DÖNGÜSÜ ===");

            // while: Önce koşulu kontrol eder, sonra çalışır
            int sayac = 0;
            while (sayac < 5)
            {
                Console.WriteLine($"While döngüsü: {sayac}");
                sayac++;
            }

            // while ile kullanıcı girişi örneği
            Console.WriteLine("\nWhile ile kullanıcı girişi (çıkmak için 'q' girin):");
            // Not: Gerçek uygulamada Console.ReadLine() kullanılır
            string girdi = "";
            int iterasyon = 0;
            while (girdi != "q" && iterasyon < 3) // Örnek için 3 iterasyon
            {
                Console.WriteLine($"İterasyon {iterasyon + 1} - Girdi: {girdi}");
                iterasyon++;
                if (iterasyon == 2) girdi = "q"; // Örnek bitiş
            }

            Console.WriteLine("\n=== DO-WHILE DÖNGÜSÜ ===");

            // do-while: Önce çalışır, sonra koşulu kontrol eder
            // En az bir kez çalışır
            int sayac2 = 0;
            do
            {
                Console.WriteLine($"Do-while döngüsü: {sayac2}");
                sayac2++;
            } while (sayac2 < 5);

            // Örnek: Menü sistemi
            Console.WriteLine("\nDo-while ile menü örneği:");
            int secim = 0;
            int menuIterasyon = 0;
            do
            {
                Console.WriteLine($"Menü iterasyonu {menuIterasyon + 1}");
                menuIterasyon++;
                if (menuIterasyon == 3) secim = 4; // Çıkış
            } while (secim != 4 && menuIterasyon < 5);

            // while vs do-while farkı
            int deger1 = 10;
            Console.WriteLine("\nWhile ile (koşul başta):");
            while (deger1 > 20) // Hiç çalışmaz
            {
                Console.WriteLine("Bu mesaj görünmez");
            }

            int deger2 = 10;
            Console.WriteLine("Do-while ile (koşul sonda):");
            do
            {
                Console.WriteLine("Bu mesaj bir kez görünür (en az 1 kez çalışır)");
            } while (deger2 > 20);
        }

        /// <summary>
        /// foreach döngüsü (koleksiyonlarda gezinme)
        /// </summary>
        public static void ForeachDongusu()
        {
            Console.WriteLine("\n=== FOREACH DÖNGÜSÜ ===");

            // Dizi üzerinde foreach
            int[] sayilar = { 10, 20, 30, 40, 50 };
            Console.WriteLine("Dizi elemanları:");
            foreach (int sayi in sayilar)
            {
                Console.Write($"{sayi} ");
            }
            Console.WriteLine();

            // String üzerinde foreach
            string metin = "CSharp";
            Console.WriteLine("\nString karakterleri:");
            foreach (char karakter in metin)
            {
                Console.Write($"{karakter} ");
            }
            Console.WriteLine();

            // List üzerinde foreach
            List<string> isimler = new List<string> { "Ali", "Veli", "Mehmet" };
            Console.WriteLine("\nList elemanları:");
            foreach (string isim in isimler)
            {
                Console.WriteLine($"- {isim}");
            }

            // Dictionary üzerinde foreach
            Dictionary<string, int> notlar = new Dictionary<string, int>
            {
                { "Ali", 85 },
                { "Veli", 90 },
                { "Mehmet", 75 }
            };
            Console.WriteLine("\nDictionary elemanları:");
            foreach (var kayit in notlar)
            {
                Console.WriteLine($"{kayit.Key}: {kayit.Value}");
            }
        }

        /// <summary>
        /// Döngü kontrol komutları (break, continue)
        /// </summary>
        public static void DonguKontrolKomutlari()
        {
            Console.WriteLine("\n=== BREAK KOMUTU ===");
            // break: Döngüyü tamamen sonlandırır
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine("i = 5 bulundu, döngü sonlandırılıyor");
                    break; // Döngüden çık
                }
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            Console.WriteLine("\n=== CONTINUE KOMUTU ===");
            // continue: Mevcut iterasyonu atla, sonraki iterasyona geç
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue; // Çift sayıları atla
                }
                Console.Write($"{i} "); // Sadece tek sayılar yazdırılır
            }
            Console.WriteLine();

            // Örnek: Belirli değerleri atlama
            Console.WriteLine("\n1-20 arası 3 ve 5'in katları hariç:");
            for (int i = 1; i <= 20; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    continue;
                }
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// İç içe döngüler
        /// </summary>
        public static void IcIceDonguler()
        {
            Console.WriteLine("\n=== İÇ İÇE DÖNGÜLER ===");

            // Çarpım tablosu örneği
            Console.WriteLine("Çarpım tablosu (1-5):");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write($"{i}×{j}={i * j,2}  ");
                }
                Console.WriteLine();
            }

            // Yıldız deseni örneği
            Console.WriteLine("\nYıldız üçgeni:");
            int satirSayisi = 5;
            for (int i = 1; i <= satirSayisi; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // İç döngüde break kullanımı
            Console.WriteLine("\nİç döngüde break (sadece iç döngüyü sonlandırır):");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j == 3)
                    {
                        break; // Sadece iç döngüden çık
                    }
                    Console.Write($"({i},{j}) ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Sonsuz döngüler ve çıkış koşulları
        /// </summary>
        public static void SonsuzDonguler()
        {
            Console.WriteLine("\n=== SONSUZ DÖNGÜLER ===");

            // while(true) ile sonsuz döngü
            Console.WriteLine("while(true) örneği (3 iterasyon sonra çıkış):");
            int sayac = 0;
            while (true)
            {
                sayac++;
                Console.WriteLine($"Iterasyon {sayac}");
                if (sayac >= 3)
                {
                    break; // Çıkış koşulu
                }
            }

            // for(;;) ile sonsuz döngü
            Console.WriteLine("\nfor(;;) örneği (3 iterasyon sonra çıkış):");
            sayac = 0;
            for (;;)
            {
                sayac++;
                Console.WriteLine($"Iterasyon {sayac}");
                if (sayac >= 3)
                {
                    break;
                }
            }

            // Örnek: Kullanıcı 'q' girene kadar devam
            Console.WriteLine("\nKullanıcı çıkış örneği (simüle):");
            bool devamEt = true;
            int ornekSayac = 0;
            while (devamEt)
            {
                ornekSayac++;
                Console.WriteLine($"Komut bekleniyor... (iterasyon {ornekSayac})");
                
                // Simüle edilmiş kullanıcı girişi
                string girdi = ornekSayac == 3 ? "q" : "devam";
                
                if (girdi.ToLower() == "q")
                {
                    devamEt = false;
                    Console.WriteLine("Çıkış yapıldı!");
                }
                else
                {
                    Console.WriteLine("Devam ediliyor...");
                }
            }
        }

        /// <summary>
        /// Döngü içinde kullanıcı girdisi alma (örnek)
        /// </summary>
        public static void DonguIcindeKullaniciGirdisi()
        {
            Console.WriteLine("\n=== DÖNGÜ İÇİNDE KULLANICI GİRDİSİ (ÖRNEK) ===");
            Console.WriteLine("Not: Gerçek uygulamada Console.ReadLine() kullanılır");

            // Örnek: Kullanıcıdan sayılar al, topla, 'q' ile çık
            double toplam = 0;
            int sayiAdedi = 0;
            string[] ornekGirdiler = { "10", "20", "30", "q" }; // Simüle edilmiş

            foreach (string girdi in ornekGirdiler)
            {
                if (girdi.ToLower() == "q")
                {
                    Console.WriteLine("Çıkış yapıldı!");
                    break;
                }

                if (double.TryParse(girdi, out double sayi))
                {
                    toplam += sayi;
                    sayiAdedi++;
                    Console.WriteLine($"Sayı eklendi: {sayi}, Toplam: {toplam}");
                }
                else
                {
                    Console.WriteLine($"Geçersiz giriş: {girdi}");
                }
            }

            if (sayiAdedi > 0)
            {
                Console.WriteLine($"\nToplam: {toplam}");
                Console.WriteLine($"Ortalama: {toplam / sayiAdedi:F2}");
            }
        }

        /// <summary>
        /// Farklı döngü türlerinin karşılaştırması
        /// </summary>
        public static void DonguKarsilastirma()
        {
            Console.WriteLine("\n=== DÖNGÜ TÜRLERİ KARŞILAŞTIRMASI ===");
            Console.WriteLine("FOR:");
            Console.WriteLine("  - Kaç kez çalışacağı belli");
            Console.WriteLine("  - Sayaç değişkeni otomatik yönetilir");
            Console.WriteLine("  - Diziler ve koleksiyonlar için uygun");

            Console.WriteLine("\nWHILE:");
            Console.WriteLine("  - Kaç kez çalışacağı belli değil");
            Console.WriteLine("  - Koşul başta kontrol edilir");
            Console.WriteLine("  - Hiç çalışmayabilir");

            Console.WriteLine("\nDO-WHILE:");
            Console.WriteLine("  - Kaç kez çalışacağı belli değil");
            Console.WriteLine("  - Koşul sonda kontrol edilir");
            Console.WriteLine("  - En az bir kez çalışır");

            Console.WriteLine("\nFOREACH:");
            Console.WriteLine("  - Koleksiyon/dizi üzerinde gezinme");
            Console.WriteLine("  - Sadece okuma amaçlı");
            Console.WriteLine("  - Daha okunabilir kod");
        }
    }
}

