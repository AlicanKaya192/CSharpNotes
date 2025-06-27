using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EşittiVeEşitDeğildirOperatörü
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            // = operatörü tek başına kullanılır iken atama operatörü olarak çalışır.
            // değişken = AtanacakDeger

            decimal decimalSayı1 = 10.90M;

            // Eşit mi karşılaştırma operatörü == / eşit olmadığını da != ile sorgularız

            int s1 = 100;
            int s2 = 100;

            bool esitKontrol1 = s1 == s2;
            bool esitKontrol2 = s1 != s2;

        }
    }
}
