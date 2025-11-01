using System;

namespace CSharpTemelKonseptler
{
    /// <summary>
    /// 1. GİRİŞ VE PROGRAM YAPISI
    /// Bu dosya C# ve .NET ekosistemi, CLR, program yapısı gibi temel kavramları içerir.
    /// </summary>
    public class GirisVeProgramYapisi
    {
        // C# ve .NET Ekosistemi:
        // - .NET: Microsoft tarafından geliştirilen açık kaynaklı bir platform
        // - C#: .NET platformu için geliştirilmiş modern, nesne yönelimli programlama dili
        // - CLR (Common Language Runtime): Kodun çalıştırıldığı sanal makine ortamı
        //   - C# kodu önce IL (Intermediate Language) koduna derlenir
        //   - CLR bu IL kodunu çalışma zamanında makine koduna dönüştürür (JIT - Just In Time compilation)

        // NAMESPACE KAVRAMI
        // namespace: Kod organizasyonu için kullanılan mantıksal gruplandırma
        // using: Başka namespace'lerdeki sınıfları kullanmak için
        // Örnek: using System; -> System namespace'indeki Console sınıfını kullanabiliriz

        /// <summary>
        /// Konsol uygulamasında program giriş noktası
        /// Main metodu programın başladığı yerdir
        /// </summary>
        public static void OrnekProgramYapisi()
        {
            // Console.WriteLine(): Konsola veri yazdırır ve satır sonu ekler
            Console.WriteLine("Merhaba C# Dünyası!");
            Console.WriteLine("Bu bir konsol uygulaması örneğidir.");

            // Console.Write(): Konsola veri yazdırır ama satır sonu eklemez
            Console.Write("Birinci mesaj ");
            Console.Write("ikinci mesaj");
            Console.WriteLine(); // Satır sonu için

            // Console.ReadLine(): Kullanıcıdan girdi alır
            Console.WriteLine("Lütfen bir mesaj girin:");
            string? kullaniciGirdisi = Console.ReadLine();
            Console.WriteLine($"Girdiğiniz mesaj: {kullaniciGirdisi ?? "Boş"}");

            // String interpolation (C# 6.0+)
            string isim = "Ahmet";
            int yas = 25;
            Console.WriteLine($"Ad: {isim}, Yaş: {yas}");
        }

        /// <summary>
        /// Namespace kullanımı ve organizasyon örneği
        /// </summary>
        public static void NamespaceOrnegi()
        {
            // Tam namespace belirterek kullanım (using olmadan)
            System.Console.WriteLine("Tam namespace kullanımı");

            // Using ile namespace import edildiğinde doğrudan kullanım
            Console.WriteLine("Using ile import edilmiş kullanım");

            // Farklı namespace'lerdeki sınıfları kullanmak için:
            // using CSharpTemelKonseptler.Matematik; gibi eklemeler yapılabilir
        }

        /// <summary>
        /// Derleme süreci açıklaması
        /// </summary>
        public static void DerlemeSureci()
        {
            Console.WriteLine("=== DERLEME SÜRECİ ===");
            Console.WriteLine("1. Kaynak Kod (.cs dosyası)");
            Console.WriteLine("2. Derleyici (CSC - C# Compiler)");
            Console.WriteLine("3. IL Kodu (Intermediate Language) - .dll veya .exe");
            Console.WriteLine("4. CLR (Common Language Runtime)");
            Console.WriteLine("5. JIT Compilation (Just-In-Time)");
            Console.WriteLine("6. Makine Kodu");
            Console.WriteLine("7. Program Çalışır");

            // Komut satırından derleme:
            // dotnet build -> Projeyi derler
            // dotnet run -> Projeyi derler ve çalıştırır
        }

        /// <summary>
        /// Program yapısı örneği
        /// </summary>
        public static void ProgramYapisiOrnegi()
        {
            // C# dosya yapısı:
            // 1. using direktifleri (isteğe bağlı)
            // 2. namespace tanımı (isteğe bağlı ama önerilir)
            // 3. class tanımı
            // 4. Metotlar ve özellikler

            Console.WriteLine("=== PROGRAM YAPISI ===");
            Console.WriteLine("namespace CSharpTemelKonseptler");
            Console.WriteLine("{");
            Console.WriteLine("    public class GirisVeProgramYapisi");
            Console.WriteLine("    {");
            Console.WriteLine("        public static void Main()");
            Console.WriteLine("        {");
            Console.WriteLine("            // Kod buraya gelir");
            Console.WriteLine("        }");
            Console.WriteLine("    }");
            Console.WriteLine("}");
        }
    }

    // İÇ İÇE NAMESPACE ÖRNEĞİ
    namespace Matematik
    {
        /// <summary>
        /// Matematik işlemleri için ayrı bir namespace örneği
        /// </summary>
        public class Hesaplayici
        {
            public static int Topla(int a, int b)
            {
                return a + b;
            }

            public static int Carp(int a, int b)
            {
                return a * b;
            }
        }
    }
}

