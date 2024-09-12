using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesap_Makinesi
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Basit Hesap Makinesi");


            Console.Write("Birinci sayıyı girin: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("İkinci sayıyı girin: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Yapmak istediğiniz işlemi seçin:");
            Console.WriteLine("1. Toplama");
            Console.WriteLine("2. Çıkarma");
            Console.WriteLine("3. Çarpma");
            Console.WriteLine("4. Bölme");

            Console.Write("Seçiminiz (1-4): ");
            int secim = Convert.ToInt32(Console.ReadLine());

            double sonuc = 0;

            switch (secim)
            {
                case 1:
                    sonuc = sayi1 + sayi2;
                    Console.WriteLine($"Sonuç: {sayi1} + {sayi2} = {sonuc}");
                    break;
                case 2:
                    sonuc = sayi1 - sayi2;
                    Console.WriteLine($"Sonuç: {sayi1} - {sayi2} = {sonuc}");
                    break;
                case 3:
                    sonuc = sayi1 * sayi2;
                    Console.WriteLine($"Sonuç: {sayi1} * {sayi2} = {sonuc}");
                    break;
                case 4:
                    if (sayi2 != 0)
                    {
                        sonuc = sayi1 / sayi2;
                        Console.WriteLine($"Sonuç: {sayi1} / {sayi2} = {sonuc}");
                    }
                    else
                    {
                        Console.WriteLine("Hata: Bir sayı sıfıra bölünemez.");
                    }
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim! Lütfen 1 ile 4 arasında bir değer girin.");
                    break;
            }

            Console.WriteLine("Hesaplama tamamlandı. Programdan çıkmak için bir tuşa basın.");
            Console.ReadKey();
        }
    }
}

