using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alıştırma1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba");

            Console.Write("İsminiz nedir ?  =  ");
            string isim = Console.ReadLine();

            Console.Write("Soyisminiz nedir ?  =  ");
            string soyisim = Console.ReadLine();

            Console.Write("Yaşadığınız şehri giriniz  =  ");
            string sehir = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("İsim :" +  isim);
            Console.WriteLine("Soyisim :" + soyisim);
            Console.WriteLine("Şehir : " + sehir);

            Console.ReadLine();
        }
    }
}
