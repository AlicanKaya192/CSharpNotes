using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchKullanımı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * switch(ifade)
             * {
             * case kontrol1 :
             *   çalışacak olan işlemler
             *break;
             *}
             *
             *default: 
             * çalışacak olan işlemler 
             *break;
             *
             * 
             */

            // Ocak Şubat Mart Nisan ....  Yada Hatalı Girebilir Alican gibi

            Console.Write("Hangi Ay: ");
            string kullaniciGelen = Console.ReadLine();

            switch(kullaniciGelen)
            {
                case "Ocak":
                    Console.WriteLine("01");
                    break;
                case "Şubat":
                    Console.WriteLine("02");
                    break;
                case "Mart":
                    Console.WriteLine("03");
                    break;
                default:
                    Console.WriteLine("Belirtilen Değerlerin Dışarısında Değer Girdiniz");
                    break;
            }
        }
    }
}
