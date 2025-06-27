using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsOperatörü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // as Operatörü

            string isimSoyisim = "Cengiz Atilla";
            object objectString = isimSoyisim;
            string sonucStr = objectString as string;

            // as operatörünün is den farkı eğer öyleyse aktar olmasıdır.
            // is direk değişken odaklı giderken as eğer değişken birbirine uyuyorsa gider
            // yoğunluk olarak is kullanılır.



        }
    }
}
