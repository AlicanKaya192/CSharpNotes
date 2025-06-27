using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BölümSonuAlıştırma2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Soru1 : String olarak verilen değeri bool tipine dönüştürün
            string metin1 = "True";

            bool sb1 = bool.Parse(metin1);
            bool sb2 = Convert.ToBoolean(metin1);

            // Soru 2 : int içerisinde olan 100 değerini byte ve float değişken tiplerine dönüştürün
            int s1 = 100;

            byte b1 = (byte)s1;
            float f1 = s1;

            // Byte değişken içerisinde olan tipi Decimal değişken tipine dönüştürün
            byte bd1 = 10;

            decimal d1 = bd1;
        }
    }
}
