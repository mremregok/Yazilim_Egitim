using System;

namespace CSharpTemelKonseptler
{
    /// <summary>
    /// 4. KARAR YAPILARI
    /// if-else, switch-case, ternary operator gibi karar yapılarını içerir.
    /// </summary>
    public class KararYapilari
    {
        /// <summary>
        /// if ve else if kullanımı
        /// </summary>
        public static void IfElseOrnekleri()
        {
            Console.WriteLine("=== IF-ELSE YAPISI ===");

            int not = 75;

            // Basit if
            if (not >= 50)
            {
                Console.WriteLine("Sınavdan geçtiniz!");
            }

            // if-else
            if (not >= 50)
            {
                Console.WriteLine("Geçti");
            }
            else
            {
                Console.WriteLine("Kaldı");
            }

            // if-else if-else (çoklu koşul)
            if (not >= 90)
            {
                Console.WriteLine("Harf notu: AA");
            }
            else if (not >= 80)
            {
                Console.WriteLine("Harf notu: BA");
            }
            else if (not >= 70)
            {
                Console.WriteLine("Harf notu: BB");
            }
            else if (not >= 60)
            {
                Console.WriteLine("Harf notu: CB");
            }
            else if (not >= 50)
            {
                Console.WriteLine("Harf notu: CC");
            }
            else
            {
                Console.WriteLine("Harf notu: FF (Kaldı)");
            }

            // Tek satır if (parantez olmadan tek komut)
            if (not >= 50)
                Console.WriteLine("Geçti");
            else
                Console.WriteLine("Kaldı");
        }

        /// <summary>
        /// İç içe (nested) koşullar
        /// </summary>
        public static void IcIceKosullar()
        {
            Console.WriteLine("\n=== İÇ İÇE KOŞULLAR ===");

            int yas = 25;
            bool ehliyetVarMi = true;
            bool sigortaVarMi = false;

            if (yas >= 18)
            {
                Console.WriteLine("Yaş yeterli");

                if (ehliyetVarMi)
                {
                    Console.WriteLine("Ehliyet var");

                    if (sigortaVarMi)
                    {
                        Console.WriteLine("Araç kullanabilirsiniz!");
                    }
                    else
                    {
                        Console.WriteLine("Sigorta gerekli!");
                    }
                }
                else
                {
                    Console.WriteLine("Ehliyet gerekli!");
                }
            }
            else
            {
                Console.WriteLine("Yaş yeterli değil!");
            }

            // Mantıksal operatörlerle basitleştirme
            if (yas >= 18 && ehliyetVarMi && sigortaVarMi)
            {
                Console.WriteLine("Araç kullanabilirsiniz! (Basitleştirilmiş)");
            }
        }

        /// <summary>
        /// switch yapısı ve case blokları
        /// </summary>
        public static void SwitchOrnekleri()
        {
            Console.WriteLine("\n=== SWITCH YAPISI ===");

            int gun = 3;

            switch (gun)
            {
                case 1:
                    Console.WriteLine("Pazartesi");
                    break;
                case 2:
                    Console.WriteLine("Salı");
                    break;
                case 3:
                    Console.WriteLine("Çarşamba");
                    break;
                case 4:
                    Console.WriteLine("Perşembe");
                    break;
                case 5:
                    Console.WriteLine("Cuma");
                    break;
                case 6:
                case 7: // Birden fazla case'i birleştirme
                    Console.WriteLine("Hafta sonu");
                    break;
                default:
                    Console.WriteLine("Geçersiz gün");
                    break;
            }

            // C# 7.0+ - Switch expression (pattern matching)
            string mesaj = gun switch
            {
                1 => "Pazartesi - Hafta başlangıcı",
                2 or 3 or 4 => "Hafta ortası",
                5 => "Cuma - Hafta sonu yaklaşıyor",
                6 or 7 => "Hafta sonu",
                _ => "Geçersiz"
            };
            Console.WriteLine($"Mesaj: {mesaj}");
        }

        /// <summary>
        /// default ve break kullanımı
        /// </summary>
        public static void DefaultVeBreak()
        {
            Console.WriteLine("\n=== DEFAULT VE BREAK ===");

            string kategori = "Elektronik";

            switch (kategori)
            {
                case "Giyim":
                    Console.WriteLine("Giyim kategorisi seçildi");
                    // break unutulursa derleyici hatası verir (fall-through yok)
                    break;

                case "Elektronik":
                    Console.WriteLine("Elektronik kategorisi seçildi");
                    break;

                case "Kitap":
                    Console.WriteLine("Kitap kategorisi seçildi");
                    break;

                default: // Hiçbir case eşleşmezse çalışır
                    Console.WriteLine("Bilinmeyen kategori");
                    break; // default için de break gerekli
            }

            // break kullanmadan önceki C# versiyonlarında fall-through mümkündü
            // Modern C#'ta her case bloğu mutlaka break, return veya goto ile bitmeli
        }

        /// <summary>
        /// switch ile enum örneği
        /// </summary>
        public enum Mevsim
        {
            Ilkbahar,
            Yaz,
            Sonbahar,
            Kis
        }

        public static void SwitchEnumOrnegi()
        {
            Console.WriteLine("\n=== SWITCH İLE ENUM ===");

            Mevsim mevsim = Mevsim.Yaz;

            switch (mevsim)
            {
                case Mevsim.Ilkbahar:
                    Console.WriteLine("İlkbahar - Doğa uyanıyor");
                    Console.WriteLine("Aylar: Mart, Nisan, Mayıs");
                    break;

                case Mevsim.Yaz:
                    Console.WriteLine("Yaz - Sıcak günler");
                    Console.WriteLine("Aylar: Haziran, Temmuz, Ağustos");
                    break;

                case Mevsim.Sonbahar:
                    Console.WriteLine("Sonbahar - Yapraklar dökülüyor");
                    Console.WriteLine("Aylar: Eylül, Ekim, Kasım");
                    break;

                case Mevsim.Kis:
                    Console.WriteLine("Kış - Soğuk havalar");
                    Console.WriteLine("Aylar: Aralık, Ocak, Şubat");
                    break;

                default:
                    Console.WriteLine("Geçersiz mevsim");
                    break;
            }

            // C# 8.0+ - Switch expression ile enum
            string mevsimMesaji = mevsim switch
            {
                Mevsim.Ilkbahar => "Çiçekler açıyor",
                Mevsim.Yaz => "Deniz sezonu başladı",
                Mevsim.Sonbahar => "Havalar soğuyor",
                Mevsim.Kis => "Kar yağışı bekleniyor",
                _ => "Bilinmeyen mevsim"
            };
            Console.WriteLine($"Mevsim mesajı: {mevsimMesaji}");
        }

        /// <summary>
        /// Koşul operatörü (ternary operator ?:)
        /// </summary>
        public static void TernaryOperator()
        {
            Console.WriteLine("\n=== TERNARY OPERATOR (? :) ===");

            int not = 75;

            // Basit kullanım: koşul ? değer1 : değer2
            string sonuc = not >= 50 ? "Geçti" : "Kaldı";
            Console.WriteLine($"Not: {not}, Sonuç: {sonuc}");

            // İç içe ternary (okunabilirlik açısından dikkatli kullanılmalı)
            string harfNotu = not >= 90 ? "AA" :
                              not >= 80 ? "BA" :
                              not >= 70 ? "BB" :
                              not >= 60 ? "CB" :
                              not >= 50 ? "CC" : "FF";
            Console.WriteLine($"Harf notu: {harfNotu}");

            // Matematiksel işlemler
            int sayi1 = 10;
            int sayi2 = 20;
            int maksimum = sayi1 > sayi2 ? sayi1 : sayi2;
            Console.WriteLine($"Maksimum değer: {maksimum}");

            // Null kontrolü ile birlikte
            string? isim = null;
            string mesaj = isim != null ? $"Merhaba {isim}" : "İsim girilmedi";
            Console.WriteLine($"Mesaj: {mesaj}");

            // Atama işlemleri
            int yas = 25;
            string durum = yas >= 18 ? "Yetişkin" : "Çocuk";
            Console.WriteLine($"Yaş: {yas}, Durum: {durum}");
        }

        /// <summary>
        /// Pratik örnek: Not hesaplayıcı
        /// </summary>
        public static void NotHesaplayici(double vize, double final)
        {
            Console.WriteLine("\n=== NOT HESAPLAYICI ===");
            Console.WriteLine($"Vize: {vize}, Final: {final}");

            // Vize %40, Final %60
            double ortalam = (vize * 0.4) + (final * 0.6);

            if (ortalam >= 90)
            {
                Console.WriteLine($"Ortalama: {ortalam:F2}, Harf Notu: AA (Mükemmel)");
            }
            else if (ortalam >= 80)
            {
                Console.WriteLine($"Ortalama: {ortalam:F2}, Harf Notu: BA (Çok İyi)");
            }
            else if (ortalam >= 70)
            {
                Console.WriteLine($"Ortalama: {ortalam:F2}, Harf Notu: BB (İyi)");
            }
            else if (ortalam >= 60)
            {
                Console.WriteLine($"Ortalama: {ortalam:F2}, Harf Notu: CB (Orta)");
            }
            else if (ortalam >= 50)
            {
                Console.WriteLine($"Ortalama: {ortalam:F2}, Harf Notu: CC (Geçer)");
            }
            else
            {
                Console.WriteLine($"Ortalama: {ortalam:F2}, Harf Notu: FF (Kaldı)");
            }
        }

        /// <summary>
        /// Karar yapıları birleşik örneği
        /// </summary>
        public static void BilesikOrnek()
        {
            Console.WriteLine("\n=== BİLEŞİK ÖRNEK ===");

            int yas = 20;
            bool ogrenciMi = true;
            bool indirimVarMi = false;

            // Karmaşık koşul
            if (yas < 18)
            {
                Console.WriteLine("Yaş sınırı nedeniyle giriş yapılamaz");
            }
            else if (yas >= 18 && ogrenciMi)
            {
                indirimVarMi = true;
                Console.WriteLine("Öğrenci indirimi uygulandı!");
            }
            else if (yas >= 65)
            {
                indirimVarMi = true;
                Console.WriteLine("Yaşlı indirimi uygulandı!");
            }
            else
            {
                Console.WriteLine("Normal giriş ücreti uygulanacak");
            }

            // Ternary ile kısa yazım
            double ucret = indirimVarMi ? 50.0 : 100.0;
            Console.WriteLine($"Ücret: {ucret} TL");
        }
    }
}

