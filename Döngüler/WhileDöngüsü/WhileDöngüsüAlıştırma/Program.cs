using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDöngüsüAlıştırma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan gelen sayısal değere göre ekrana 1 eksilterek 0 değerine ulaşıncaya kadar ekrana yazalım

            /*
             *  3
             *  2
             *  1
             *  0
             */

            #region

            Console.Write("Değer giriniz: ");
            int sayac = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------------");

            while (sayac != -1)
            {
                Console.WriteLine(sayac);
                sayac--;
            }
            Console.WriteLine("Örnek 1 işlemi tamamlandı");

            #endregion

            #region Kullanıcıdan gelen değerlerin toplamını ekrana yazdıralım. 0 dan küçük ise değer girişi yapılırsa toplama işlemini bitirelim ve toplam sonucu yazalım

            Console.WriteLine("Toplamak istediğiniz sayıları giriniz: ");
            Console.WriteLine("Not: -1 değeri işlemlerinizi durdurur.");

            int ornekKullanimToplam = 0;

            while (true)
            {
                int ornek2 = Convert.ToInt32(Console.ReadLine());
                if (ornek2 < 0)
                    break;
                else
                    ornekKullanimToplam = ornekKullanimToplam + ornek2;
            }

            Console.WriteLine("Toplam Değer : {0}", ornekKullanimToplam);

            #endregion

            #region Sistemin çalışma zamanında oluşturduğu 1 ile 10 arasında ki bir değeri kullanıcının tahmin etmesini isteyecek bir uygulama yazalım.

            int sistemUretSayi = 0;
            int tahminAdet = 1;
            Random rnd = new Random();
            sistemUretSayi = rnd.Next(1, 10);

            while (true)
            {
                Console.Write("{0} . - Tahmininiz nedir: ", tahminAdet);
                int tahmin = Convert.ToInt32(Console.ReadLine());

                if (tahmin == sistemUretSayi)
                {
                    tahminAdet++;
                    Console.WriteLine("{0} . Denemenizde Doğru Bildiniz", tahminAdet);
                    break;
                }
                else
                {
                    Console.WriteLine("Yanlış Bildiniz");
                    Console.WriteLine("Sistemin bulduğu değer: {0}", sistemUretSayi);
                    tahminAdet++;
                }
            }

            #endregion
        }
    }
}
