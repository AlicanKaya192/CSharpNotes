using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegiskenNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // degiskenTipi degiskenAdi = deger;
            // 1.YOL
            // string isimSoyisim = "oooo";
            string isimSoyisim = "Alican Kaya";
            int lenghtofstring = isimSoyisim.Length;
            Console.WriteLine(isimSoyisim);
            Console.WriteLine(lenghtofstring);
            Console.ReadLine();
        }
        static void SecondWay(string[] args) 
        {
            // 2.YOL
            string isimSoyisim;
            isimSoyisim = "Alican Kaya";
            Console.WriteLine(isimSoyisim);
            Console.ReadLine();
        }
    }
}
