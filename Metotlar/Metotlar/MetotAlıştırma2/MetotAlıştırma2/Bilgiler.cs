using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotAlıştırma2
{
    public class Bilgiler
    {
        public void Bilgiler2(string ad, string soyad, decimal not1, decimal not2, decimal not3)
        {
            decimal sonuc = (not1 + not2 + not3) / 3;
            Console.WriteLine(sonuc);
        }
    }
}
