using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmetikselOperatörÇıkarma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Çıkartma operatör ( - )
            // byte , int , double , decimal , float 

            int s1 = 100;
            int s2 = 50;

            int sonuc = s1 - s2;

            byte b1 = 50;
            byte b2 = 100;
            var sonucByte = b1 - b2;  // + da olduğu gibi int olarak verir

        }
    }
}
