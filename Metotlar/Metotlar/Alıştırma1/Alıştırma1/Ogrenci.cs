using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alıştırma1
{
    internal class Ogrenci  
    {
        public decimal puanHesapla(string ad, string soyad, decimal not1, decimal not2, decimal not3)
        {
            decimal sınavToplam = not1 + not2 + not3;
            decimal sonuc = sınavToplam / 3;

            return 0;
        } 
    }
}
