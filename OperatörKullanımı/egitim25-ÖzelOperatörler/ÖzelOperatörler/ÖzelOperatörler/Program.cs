using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖzelOperatörler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mod alma operatörü %

            int s1 = 10;
            int s2 = 2;
            int sonucMod = s1 % s2;

            // ++ operatörü

            int s3 = 10;
            int OperatörSonuc1 = s3++;  // ++ değere 1 atıyor ancak burda ki kullanımda önce değeri atar daha sonra 1 ekler
            int OperatörSonuc2 = ++s3;  // burda ise önce toplama işlemini yapar daha sonra değeri atar

            // -- operatörü

            int s4 = 10;
            int OperatörSonuc3 = s4--; // ++ ile aynı işlevi görür tek farkı 1 çıkarır
            int OperatörSonuc4 = --s4;



        }
    }
}
