using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantıksalOperatörVeya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Veya Mantıksal Operatör || 
            /*
             * Şart1 Şart2 Sonuc
             * True  True  True
             * False True  True
             * True  False True
             * False False False 
             * 
             */

            string anahtar = "YASDASBCASMOASOPD";

            bool geriDonus = anahtar == "YASDASBCASMOASOPD" || anahtar == "DS123F" || anahtar == "USJDNSNCIOASDSA";

            // Bunlardan biri ile gelindiğinde eğer sistemde varsa true olarak bize döner.
        }
    }
}
