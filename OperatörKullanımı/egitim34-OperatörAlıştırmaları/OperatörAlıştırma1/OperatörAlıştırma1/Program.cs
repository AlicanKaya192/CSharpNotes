using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatörAlıştırma1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Kullanıcıdan gelen 3 farklı sınav notunun ortalaması 45 değerine eşit veya büyük mü
             * olarak kontrol edelim.
             */

            Console.WriteLine("Sınav Not Ortalaması");
            Console.Write("1.Not giriniz = ");
            decimal not1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("2.Not giriniz = ");
            decimal not2 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("3.Not giriniz = ");
            decimal not3 = Convert.ToDecimal(Console.ReadLine());

            decimal sınavToplam = not1 + not2 + not3;
            // Kısa yol olarak notları toplarken parantez içerisine alıp, parantez dışına bölü 3 yapabiliriz.

            decimal sınavOrtalama = sınavToplam / 3;

            bool kontrolSonuc = sınavOrtalama >= 45;

            Console.WriteLine("Ortalama değeriniz 45 değerinden büyük veya eşit mi : " + kontrolSonuc);
             
        }
    }
}
