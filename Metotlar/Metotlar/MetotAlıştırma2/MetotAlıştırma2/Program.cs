using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotAlıştırma2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Öğrencinin Adı : ");
            string ad = Console.ReadLine();

            Console.Write("Öğrencinin Soyad : ");
            string soyad = Console.ReadLine();

            Console.Write("1. Not : ");
            int not1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. Not : ");
            int not2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("3. Not : ");
            int not3 = Convert.ToInt32(Console.ReadLine());

            Bilgiler bilgiler = new Bilgiler();

            bilgiler.Bilgiler2(ad, soyad, not1, not2, not3);
        }
    }
}
