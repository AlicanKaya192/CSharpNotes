using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotAlıştırma3
{
    internal class ortalama
    {
        public void notlar(string ad, string soyad, decimal not1, decimal not2, decimal not3 = 45) // Bu sekilde oldugunda default deger vermis oluruz. Eger herhangi bir deger almaz ise 45 sayar, alir ise o degeri sayar
        {
            decimal ortalama = (not1 + not2 + not3) / 3;

            if (ortalama > 45)
            {
                Console.WriteLine("Tebrikler gectiniz - ortalamaniz {0} ", ortalama);
            }
            else
            {
                Console.WriteLine("Malesef kaldiniz - ortalamaniz {0}", ortalama);
            }
        }
    }
}
