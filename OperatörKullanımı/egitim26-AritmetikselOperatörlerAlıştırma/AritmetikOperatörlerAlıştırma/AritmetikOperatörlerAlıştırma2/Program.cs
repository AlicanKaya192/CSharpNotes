using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmetikOperatörlerAlıştırma2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Sayı 1 değerini giriniz :
             * sayı 2 değerini giriniz :
             * 
             * + :
             * - :
             * / :
             * * :
             * % :
             * 
            */

            Console.Write("1. Sayı Değeri giriniz : ");
            decimal sayi1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("2. Sayı Değeri giriniz : ");
            decimal sayi2 = Convert.ToDecimal(Console.ReadLine());

            Console.Clear();

            decimal toplam = sayi1 + sayi2;
            decimal çıkarma = sayi1 - sayi2;
            decimal bölme = sayi1 / sayi2;
            decimal çarpma = sayi1 * sayi2;
            decimal mod = sayi1 % sayi2;

            Console.WriteLine("Toplam : " + toplam);
            Console.WriteLine("Çıkarma : " + çıkarma);
            Console.WriteLine("Bölme : " + bölme);
            Console.WriteLine("Çarpma : " + çarpma);
            Console.WriteLine("Mod : " + mod);

            Console.ReadLine();
        }
    }
}
