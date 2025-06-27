using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilinçliTürDönüşümü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bilinçli Tür Dönüşümü :

            byte sayi1 = 100; // True
            byte byteMin = byte.MinValue; // 0 
            byte byteMax = byte.MaxValue; // 255
            // sayi1 = 256;

            int sayi2 = 256;
            int intMin = int.MinValue;
            int intMax = int.MaxValue;

            int sayi3 = sayi1; // Bilinçli Tür Dönüşümü

        }
    }
}
