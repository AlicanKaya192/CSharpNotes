using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDöngüsü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            for (int i=0; i <= 10; i++)
            {
                Console.WriteLine("For Döngüsü");
            }
            #endregion

            #region Ekran üzerinde 1 - 10 arasındaki değerleri yazdıralım

            for (int i = 2; i < 10; i++)
            {
                Console.WriteLine(i + ". tekrar");
            }

            #endregion

            #region 1 - 100 arasındaki çift sayıları ekran üzerinde yazdıralım

            for (int i = 2; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " - çift sayıdır !");
                }
            }

            #endregion

            #region Küçük ödev 1 - 100 arasındaki çift sayıların toplamı nedir

            int toplam = 0;

            for (int i = 2; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    toplam += i;
                }
            }
            Console.WriteLine("1 ile 100 arasındaki çift sayıların toplamı: {0}", toplam);
            #endregion
        }
    }
}
