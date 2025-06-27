using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoşulluİfadelerAlıştırma3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * Menü
             * 1 - Toplama
             * 2 - Çıkartma
             * 3 - Çarpma
             * 4 - Bölme
             * Seçiniz : _
             * 
             * Kurallar : 4. seçenek içerisinde bölen 0 olamaz kontrolü yapılacak
             * 
             * 
             */

            Console.WriteLine("MENÜ");
            Console.WriteLine("1 - Toplama");
            Console.WriteLine("2 - Çıkartma");
            Console.WriteLine("3 - Çarpma");
            Console.WriteLine("4 - Bölme");
            Console.Write("Seçiniz : ");
            string secenek = Console.ReadLine();


            double sayi1 = 0;
            double sayi2 = 0;

            if (secenek == "1" || secenek == "2" || secenek == "3" || secenek == "4")
            {
                Console.Write("Sayı giriniz: ");
                sayi1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("2.Sayı giriniz: ");
                sayi2 = Convert.ToDouble(Console.ReadLine());
            }

            if (secenek == "1")
            {
                Console.WriteLine($"Girmiş olduğunuz değer toplamı: {sayi1 + sayi2}");
            }
            else if (secenek == "2") 
            {
                Console.WriteLine($"Girmiş olduğunuz değerlerin farkı: {sayi1 - sayi2}");
            }
            else if (secenek == "3")
            {
                Console.WriteLine($"Girmiş olduğunuz değerlerin çarpımı: {sayi1 * sayi2}");
            }
            else if (secenek == "4")
            {
                if(sayi2 == 0)
                {
                    Console.WriteLine("Bölen değer 0 olamaz....");
                }
                else 
                {
                    Console.WriteLine($"Girmiş olduğunuz değerlerin bölümü: {sayi1 / sayi2}");
                }
            }
            else
            {
                Console.WriteLine("Seçim dışı değer girişi yaptınız...");
            }

            Console.WriteLine("Uygulama Sonu");
        }
    }
}
