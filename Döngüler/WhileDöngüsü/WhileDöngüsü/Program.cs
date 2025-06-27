using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Timers;


namespace WhileDöngüsü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  while (true) // Şartımız true olduğu süre boyunca döngümüz çalışmaya devam eder.
            //  {
            /*
             * 1 - While ( False ) olana kadar devam eder
             * 2 - Break; görene kadar devam eder
             */
            //  }

            // Örnek kullanım 1 : Ekrana 1 - 10 a kadar sayıların değerlerini yazdıralım

            // for döngüsü ile bu işlemin cevabı

            /* for(int i = 1; i<= 10; i++)
              {
               //Console.WriteLine(i);
              }*/

            int sayac = 1;

            while (sayac <= 10)
            {
                Console.WriteLine(sayac);
                sayac++;
            }
        }

    }
}
