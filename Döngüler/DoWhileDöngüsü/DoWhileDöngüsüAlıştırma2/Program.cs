using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileDöngüsüAlıştırma2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan 1 ile x arasında bir sayı girmesini isteyin.
            // Daha sonra sistem kullanıcının girmiş olduğu 1 ile x değerleri arasında bir sayı tahmini yapsın
            // Daha sonra kullanıcı sistemin tahmin etmiş olduğu sayıyı bulmaya çalışsın.
            // Bulamaz ise yeniden sorsun. Kullanıcı ne zaman bulursa değeri Y kadar denediniz ve sonuca ulaştınız desin.

            int tahmin = 0;
            int alıstırma2uretilensayi = 0;
            int sayac = 0;

            Console.Write("Tahmin oyunu için en yüksek değeri giriniz: ");
            int alıstırma2kullanicimaxvalue = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            alıstırma2uretilensayi = rnd.Next(1, alıstırma2kullanicimaxvalue);

            do
            {
                sayac++;
                Console.WriteLine("--------------------------------");
                Console.Write("{0} hakkımız üretilen sayıyı tahmin ediniz: ", sayac);
                tahmin = Convert.ToInt32(Console.ReadLine());

            } while (tahmin != alıstırma2uretilensayi);
        }
    }
}
