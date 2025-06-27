using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarşılaştırmaOperatörüKüçükEşittir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kucuk Eşit mi karşılaştırması
            // bool donenDeger = degisken1 <= degisken2 

            int s1 = 100;
            int s2 = 90;

            bool kucukEsitSonuc = s1 <= s2; // false alıcaz.

            int s3 = 90;
            int s4 = 100;

            bool kucukEsitSonuc2 = s3 <= s4; // true alıcaz.

        }
    }
}
