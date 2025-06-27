using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantıksalOperatörVe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mantıksal ve operatörü &&
            // bool donenDeger = degisken1 == "admin" && degisken2 == "123"; True
            /*
             * 
             * Degisken1 Degisken2 Sonuc
             * True       True     True
             * False      True     False
             * True       False    False
             * False      False    False
             * 
             */

            string kullaniciAdı = "admin";
            string sifre = "123";

            bool donenDeger = kullaniciAdı == "admin" && sifre == "123"; // True gelir
            // istediğiniz kadar değişken ekleyebilirsiniz ancak böyle bir durumda hepsinin true olarak gelmesi gerekir true olabilmesi için.

            // bool donenDeger = kullaniciAdı == "admin" && sifre == "123" && değisken == "deger";

        }
    }
}
