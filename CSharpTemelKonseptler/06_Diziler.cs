using System;
using System.Linq;

namespace CSharpTemelKonseptler
{
    /// <summary>
    /// 6. DİZİLER (ARRAYS)
    /// Tek boyutlu, çok boyutlu diziler ve dizi işlemlerini içerir.
    /// </summary>
    public class Diziler
    {
        /// <summary>
        /// Tek boyutlu dizi tanımlama ve başlatma
        /// </summary>
        public static void TekBoyutluDiziler()
        {
            Console.WriteLine("=== TEK BOYUTLU DİZİLER ===");

            // Yöntem 1: Tanımlama ve başlatma ayrı
            int[] sayilar1;
            sayilar1 = new int[5]; // 5 elemanlı dizi, tümü 0

            // Yöntem 2: Tanımlama ve başlatma birlikte (boş)
            int[] sayilar2 = new int[5];

            // Yöntem 3: Değerlerle başlatma
            int[] sayilar3 = new int[] { 10, 20, 30, 40, 50 };

            // Yöntem 4: Kısa syntax (önerilen)
            int[] sayilar4 = { 10, 20, 30, 40, 50 };

            // Yöntem 5: var ile
            var sayilar5 = new int[] { 10, 20, 30 };

            Console.WriteLine("Dizi tanımlama yöntemleri gösterildi.");

            // Dizi içeriğini yazdırma
            Console.WriteLine("\nDizi içeriği:");
            for (int i = 0; i < sayilar4.Length; i++)
            {
                Console.Write($"{sayilar4[i]} ");
            }
            Console.WriteLine();

            // Farklı türlerde diziler
            string[] isimler = { "Ali", "Veli", "Mehmet" };
            double[] ondaliklar = { 3.14, 2.71, 1.41 };
            bool[] durumlar = { true, false, true };
            char[] karakterler = { 'A', 'B', 'C' };
        }

        /// <summary>
        /// Dizi elemanlarına erişim
        /// </summary>
        public static void DiziElemanErisimi()
        {
            Console.WriteLine("\n=== DİZİ ELEMAN ERİŞİMİ ===");

            int[] sayilar = { 10, 20, 30, 40, 50 };

            // Elemanlara erişim (indis 0'dan başlar)
            Console.WriteLine($"İlk eleman (indis 0): {sayilar[0]}"); // 10
            Console.WriteLine($"İkinci eleman (indis 1): {sayilar[1]}"); // 20
            Console.WriteLine($"Son eleman (indis Length-1): {sayilar[sayilar.Length - 1]}"); // 50

            // Eleman değiştirme
            sayilar[0] = 100;
            Console.WriteLine($"Değiştirilmiş ilk eleman: {sayilar[0]}"); // 100

            // Son elemanı değiştirme
            sayilar[sayilar.Length - 1] = 999;
            Console.WriteLine($"Değiştirilmiş son eleman: {sayilar[sayilar.Length - 1]}"); // 999

            // Hata: Geçersiz indis
            // sayilar[10] = 5; // IndexOutOfRangeException hatası

            // Güvenli erişim kontrolü
            int indis = 3;
            if (indis >= 0 && indis < sayilar.Length)
            {
                Console.WriteLine($"Güvenli erişim: {sayilar[indis]}");
            }
            else
            {
                Console.WriteLine("Geçersiz indis!");
            }
        }

        /// <summary>
        /// Length özelliği ve dizi bilgileri
        /// </summary>
        public static void LengthOzelligi()
        {
            Console.WriteLine("\n=== LENGTH ÖZELLİĞİ ===");

            int[] sayilar = { 10, 20, 30, 40, 50 };

            Console.WriteLine($"Dizi uzunluğu: {sayilar.Length}"); // 5

            // Length kullanarak dizi üzerinde işlemler
            Console.WriteLine("\nDizi elemanlarının toplamı:");
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            Console.WriteLine($"Toplam: {toplam}");

            // Dizi boş mu kontrolü
            if (sayilar.Length == 0)
            {
                Console.WriteLine("Dizi boş");
            }
            else
            {
                Console.WriteLine($"Dizide {sayilar.Length} eleman var");
            }

            // İlk ve son eleman
            if (sayilar.Length > 0)
            {
                Console.WriteLine($"İlk eleman: {sayilar[0]}");
                Console.WriteLine($"Son eleman: {sayilar[sayilar.Length - 1]}");
            }
        }

        /// <summary>
        /// Döngüyle dizileri gezmek (for, foreach)
        /// </summary>
        public static void DiziGezintisi()
        {
            Console.WriteLine("\n=== DİZİ GEZİNTİSİ ===");

            int[] sayilar = { 10, 20, 30, 40, 50 };

            // FOR döngüsü ile
            Console.WriteLine("FOR döngüsü ile:");
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine($"İndis {i}: {sayilar[i]}");
            }

            // FOREACH döngüsü ile (daha okunabilir)
            Console.WriteLine("\nFOREACH döngüsü ile:");
            foreach (int sayi in sayilar)
            {
                Console.WriteLine($"Değer: {sayi}");
            }

            // FOREACH ile indis bilgisi (LINQ kullanarak)
            Console.WriteLine("\nFOREACH ile indis (LINQ):");
            foreach (var (deger, indis) in sayilar.Select((deger, indis) => (deger, indis)))
            {
                Console.WriteLine($"İndis {indis}: {deger}");
            }

            // Geriye doğru gezinme
            Console.WriteLine("\nGeriye doğru gezinme:");
            for (int i = sayilar.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"İndis {i}: {sayilar[i]}");
            }
        }

        /// <summary>
        /// Çok boyutlu diziler
        /// </summary>
        public static void CokBoyutluDiziler()
        {
            Console.WriteLine("\n=== ÇOK BOYUTLU DİZİLER ===");

            // İki boyutlu dizi (matris) - [,]
            int[,] matris = new int[3, 4]; // 3 satır, 4 sütun

            // Değer atama
            matris[0, 0] = 1;
            matris[0, 1] = 2;
            matris[1, 0] = 3;
            matris[2, 3] = 12;

            // İki boyutlu dizi başlatma
            int[,] matris2 = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            Console.WriteLine("İki boyutlu dizi (3x3):");
            for (int i = 0; i < matris2.GetLength(0); i++) // Satırlar
            {
                for (int j = 0; j < matris2.GetLength(1); j++) // Sütunlar
                {
                    Console.Write($"{matris2[i, j]} ");
                }
                Console.WriteLine();
            }

            // Üç boyutlu dizi - [,,]
            int[,,] ucBoyutlu = new int[2, 3, 4]; // 2x3x4 = 24 eleman

            Console.WriteLine($"\nÜç boyutlu dizi boyutları: {ucBoyutlu.GetLength(0)} x {ucBoyutlu.GetLength(1)} x {ucBoyutlu.GetLength(2)}");

            // Jagged Array (Dişli dizi) - [][]
            // Her satırın farklı uzunlukta olabileceği dizi
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2, 3 };
            jaggedArray[1] = new int[] { 4, 5 };
            jaggedArray[2] = new int[] { 6, 7, 8, 9 };

            Console.WriteLine("\nJagged Array (Dişli dizi):");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write($"{jaggedArray[i][j]} ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Array.Sort(), Array.Reverse() gibi metodlar
        /// </summary>
        public static void DiziMetodlari()
        {
            Console.WriteLine("\n=== DİZİ METODLARI ===");

            int[] sayilar = { 45, 12, 89, 3, 67, 23 };

            Console.WriteLine("Orijinal dizi:");
            foreach (int sayi in sayilar)
            {
                Console.Write($"{sayi} ");
            }
            Console.WriteLine();

            // Array.Sort() - Sıralama (küçükten büyüğe)
            Array.Sort(sayilar);
            Console.WriteLine("\nSıralanmış dizi (küçükten büyüğe):");
            foreach (int sayi in sayilar)
            {
                Console.Write($"{sayi} ");
            }
            Console.WriteLine();

            // Array.Reverse() - Ters çevirme
            Array.Reverse(sayilar);
            Console.WriteLine("\nTers çevrilmiş dizi:");
            foreach (int sayi in sayilar)
            {
                Console.Write($"{sayi} ");
            }
            Console.WriteLine();

            // Array.Clear() - Diziyi temizleme
            int[] sayilar2 = { 1, 2, 3, 4, 5 };
            Array.Clear(sayilar2, 1, 2); // İndis 1'den başlayarak 2 elemanı temizle
            Console.WriteLine("\nArray.Clear() sonrası:");
            foreach (int sayi in sayilar2)
            {
                Console.Write($"{sayi} ");
            }
            Console.WriteLine();

            // Array.Copy() - Dizi kopyalama
            int[] kaynak = { 1, 2, 3, 4, 5 };
            int[] hedef = new int[5];
            Array.Copy(kaynak, hedef, kaynak.Length);
            Console.WriteLine("\nKopyalanmış dizi:");
            foreach (int sayi in hedef)
            {
                Console.Write($"{sayi} ");
            }
            Console.WriteLine();

            // Array.IndexOf() - Eleman arama
            int[] sayilar3 = { 10, 20, 30, 20, 40 };
            int indis = Array.IndexOf(sayilar3, 20);
            Console.WriteLine($"\n20 değerinin ilk indis: {indis}"); // 1

            int sonIndis = Array.LastIndexOf(sayilar3, 20);
            Console.WriteLine($"20 değerinin son indis: {sonIndis}"); // 3

            // Array.Find() - Koşula uyan ilk eleman
            int[] sayilar4 = { 10, 25, 30, 45, 50 };
            int bulunan = Array.Find(sayilar4, x => x > 30);
            Console.WriteLine($"30'dan büyük ilk sayı: {bulunan}"); // 45
        }

        /// <summary>
        /// Dizilerle pratik uygulama: ortalama hesaplama
        /// </summary>
        public static void DiziOrtalamaHesaplama()
        {
            Console.WriteLine("\n=== ORTALAMA HESAPLAMA UYGULAMASI ===");

            // Öğrenci notları
            double[] notlar = { 85.5, 92.0, 78.5, 88.0, 95.5, 82.0, 90.0 };

            Console.WriteLine("Öğrenci notları:");
            for (int i = 0; i < notlar.Length; i++)
            {
                Console.WriteLine($"Not {i + 1}: {notlar[i]}");
            }

            // Toplam hesaplama
            double toplam = 0;
            foreach (double not in notlar)
            {
                toplam += not;
            }

            // Ortalama hesaplama
            double ortalama = toplam / notlar.Length;

            Console.WriteLine($"\nToplam: {toplam:F2}");
            Console.WriteLine($"Ortalama: {ortalama:F2}");

            // En yüksek ve en düşük not
            double enYuksek = notlar[0];
            double enDusuk = notlar[0];

            for (int i = 1; i < notlar.Length; i++)
            {
                if (notlar[i] > enYuksek)
                {
                    enYuksek = notlar[i];
                }
                if (notlar[i] < enDusuk)
                {
                    enDusuk = notlar[i];
                }
            }

            Console.WriteLine($"En yüksek not: {enYuksek}");
            Console.WriteLine($"En düşük not: {enDusuk}");

            // Ortalamadan yüksek notlar
            Console.WriteLine("\nOrtalamadan yüksek notlar:");
            int sayac = 0;
            foreach (double not in notlar)
            {
                if (not > ortalama)
                {
                    Console.WriteLine($"  Not {++sayac}: {not}");
                }
            }

            // Sıralı notlar (yüksekten düşüğe)
            double[] siraliNotlar = new double[notlar.Length];
            Array.Copy(notlar, siraliNotlar, notlar.Length);
            Array.Sort(siraliNotlar);
            Array.Reverse(siraliNotlar);

            Console.WriteLine("\nSıralı notlar (yüksekten düşüğe):");
            foreach (double not in siraliNotlar)
            {
                Console.Write($"{not} ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Dizi örnekleri ve pratik uygulamalar
        /// </summary>
        public static void DiziPratikOrnekleri()
        {
            Console.WriteLine("\n=== DİZİ PRATİK ÖRNEKLERİ ===");

            // Örnek 1: Sayı dizisinde toplam ve ortalama
            int[] sayilar = { 15, 25, 35, 45, 55 };
            int toplam = sayilar.Sum(); // LINQ kullanımı
            double ortalama = sayilar.Average();
            Console.WriteLine($"Toplam: {toplam}, Ortalama: {ortalama}");

            // Örnek 2: Dizide belirli değeri bulma
            string[] isimler = { "Ali", "Veli", "Mehmet", "Ali", "Ayşe" };
            int aliSayisi = Array.FindAll(isimler, isim => isim == "Ali").Length;
            Console.WriteLine($"'Ali' sayısı: {aliSayisi}");

            // Örnek 3: Diziyi büyütme (yeni dizi oluşturma)
            int[] kucukDizi = { 1, 2, 3 };
            int[] buyukDizi = new int[6];
            Array.Copy(kucukDizi, buyukDizi, kucukDizi.Length);
            Console.WriteLine($"Büyütülmüş dizi uzunluğu: {buyukDizi.Length}");

            // Örnek 4: Dizi birleştirme
            int[] dizi1 = { 1, 2, 3 };
            int[] dizi2 = { 4, 5, 6 };
            int[] birlesik = new int[dizi1.Length + dizi2.Length];
            Array.Copy(dizi1, birlesik, dizi1.Length);
            Array.Copy(dizi2, 0, birlesik, dizi1.Length, dizi2.Length);
            Console.WriteLine("Birleştirilmiş dizi:");
            foreach (int sayi in birlesik)
            {
                Console.Write($"{sayi} ");
            }
            Console.WriteLine();
        }
    }
}

