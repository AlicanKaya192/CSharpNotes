using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilinçsizTürDönüşümü
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Bilinçsiz Tür Dönüşümü

            int sayi1 = 100;
            int intMin = int.MinValue;
            int intMax = int.MaxValue;

            byte sayi2 = (byte)sayi1;

            int sayi3 = 256;

            byte sayi4 = (byte)sayi3;
        }
    }
}
