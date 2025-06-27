using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeAlistirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();

            Console.Write("TC KIMLIK NUMARANIZ NEDIR : ");
            string tc = Console.ReadLine();

            M1.TCKimlikNumarasi = tc;

            Console.WriteLine(M1.TCKimlikNumarasi);
        }
    }
}
