using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alıştırma2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba");

            Console.Write("İsminizi giriniz =  ");
            string isim = Console.ReadLine() + "  " + DateTime.Now;

            Console.Write("Soyisminizi giriniz =  ");
            string soyisim = Console.ReadLine();

            Console.Write("Yaşadığınız şehri giriniz =  ");
            string şehir = Console.ReadLine();

            Console.Write(" TC Kimlik Giriniz =  ");
            string tc = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("İsim = "  +  isim);
            Console.WriteLine("Soyisim = "  +  soyisim);
            Console.WriteLine("Şehir = "  +  şehir);
            Console.WriteLine("TC = "  +  tc);

        }
    }
}
