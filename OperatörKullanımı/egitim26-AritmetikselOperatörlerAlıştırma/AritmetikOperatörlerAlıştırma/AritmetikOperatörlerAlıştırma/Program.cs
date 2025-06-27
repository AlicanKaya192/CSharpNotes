using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmetikOperatörlerAlıştırma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Merhaba,
             * İsminiz :
             * Soyisminiz :
             * Doğum Yılınız :
             * 
             * Ekranı Temizle
             * 
             * Merhaba İsim Soyİsim Yaş ...
             * 
             */


            Console.WriteLine("Merhaba");

            Console.Write("İsminiz : ");
            string isim = Console.ReadLine();

            Console.Write("Soyİsminiz : ");
            string soyİsim = Console.ReadLine();

            Console.Write("Doğum Yılınız : ");
            string dogumTarihi = Console.ReadLine();

            Console.Clear();

            int yil = Convert.ToInt32(dogumTarihi);
            //int mevcutYil = 2024;
            int mevcutYil = DateTime.Now.Year; 
            int yas = mevcutYil - yil;

            Console.WriteLine("Merhaba " + isim + " " + soyİsim + " " + yas + " yaşındasınız");
            Console.ReadLine();

        }
    }
}
