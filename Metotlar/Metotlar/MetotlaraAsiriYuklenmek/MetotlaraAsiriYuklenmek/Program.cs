using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlaraAsiriYuklenmek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba Dunya");
            Console.WriteLine("true");

            decimal toplam = topla(12M, 45M);
            ekrandaGoster(toplam);

            ekrandaGoster(topla(12, 33)); // Ic ice metot kullanimi
        } 

        static void ekrandaGoster(object o)
        {
            Console.WriteLine(o.ToString());
        }

        static int topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }

        static decimal topla(decimal sayi1, decimal sayi2)
        {
            decimal toplam = sayi1 + sayi2;
            return toplam;
        }
          
        static string topla(string metin1 , string metin2)
        {
            return metin1 + " " + metin2;
        }
    }
}
