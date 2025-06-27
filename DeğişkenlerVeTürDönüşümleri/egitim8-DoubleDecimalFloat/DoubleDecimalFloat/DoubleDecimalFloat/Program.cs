using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleDecimalFloat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Double

            double doubleVal1 = 10.2;
            double doubleVal2 = 10;

            double doubleMinVal = double.MinValue;
            double doubleMaxVal = double.MaxValue;

            Console.WriteLine(doubleVal1);
            Console.WriteLine(doubleVal2);

            Console.WriteLine(doubleMinVal);
            Console.WriteLine(doubleMaxVal);

            // Decimal

            decimal decimalVal1 = 10.2M;
            decimal decimalVal2 = 10M;

            decimal decimalMinVal = decimal.MinValue;
            decimal decimalMaxVal = decimal.MaxValue;

            Console.WriteLine(decimalVal1);
            Console.WriteLine(decimalVal2);

            Console.WriteLine(decimalMinVal);
            Console.WriteLine(decimalMaxVal);

            // Float

            float floatVal1 = 10.2f;
            float floatVal2 = 10f;

            float floatMinVal = float.MinValue;
            float floatMaxVal = float.MaxValue;
            
            Console.WriteLine(floatVal1);
            Console.WriteLine(floatVal2);

            Console.WriteLine(floatMinVal);
            Console.WriteLine(floatMaxVal);

            Console.ReadLine();




        }
    }
}
