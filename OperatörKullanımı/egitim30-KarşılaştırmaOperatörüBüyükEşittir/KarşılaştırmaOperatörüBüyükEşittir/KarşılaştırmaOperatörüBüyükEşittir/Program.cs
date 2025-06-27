using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KarşılaştırmaOperatörüBüyükEşittir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Buyuk Eşit mi Karşılaştırması
            // bool donenDeger = degisken1 >= degisken2

            int s1 = 90;
            int s2 = 100;

            bool buyukEsitSonuc = s1 >= s2; // false cevabını alırız

            int s3 = 100;
            int s4 = 100;

            bool buyukEsitSonuc2 = s3 >= s4; // true cevabını alırız

        }
    }
}
