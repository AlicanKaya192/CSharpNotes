using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteVeInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 2 3 4 5 6 7


            byte deger1 = 10;
            int deger2 = 100;

            byte byteMinVal = byte.MinValue;
            byte byteMaxVal = byte.MaxValue;

            int intMinVal = int.MinValue;
            int intMaxVal = int.MaxValue;

            Console.WriteLine(byteMinVal);
            Console.WriteLine(byteMaxVal);

            Console.WriteLine(intMinVal);
            Console.WriteLine(intMaxVal);

            Console.WriteLine(deger1);
            Console.WriteLine(deger2);
            Console.ReadLine();

        }
    }
}
