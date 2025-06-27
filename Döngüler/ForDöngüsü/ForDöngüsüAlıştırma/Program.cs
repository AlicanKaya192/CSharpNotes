using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDöngüsüAlıştırma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1’den girilen sayıya kadar 7′ ye tam bölünen sayıları sayan
            // toplamlarını hesaplayan ve bu sayıları ekrana yazdıran programı yapınız.

            int sayi, sayac = 0, toplam = 0;

            Console.Write("Bir sayı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            for ( int i = 1;  i <= sayi; i++ ) 
            {
              if ( i % 7 == 0 )
                {
                    sayac++; toplam += i;
                    Console.WriteLine("{0}", i);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Toplam adeti: " + sayac);
            Console.WriteLine("Toplamları: " + toplam);
            Console.ReadKey();

        }
    }
}
