using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ogrenciIsımListesi = new string[5];

            // Nasıl değer ekleyebiliriz.
            // 1 2 3 4 ..... 10
            // 0 1 2 3 4 5 6 7 8 9 10
            /*
             * 5 elemanlı bir dizi oluşturduğum zaman
             * 
             * [0] 1. eleman için
             * [1} 2. eleman için
             */

            ogrenciIsımListesi[0] = "Alican kaya";
            ogrenciIsımListesi[1] = "Ahmet Yavuz";
            ogrenciIsımListesi[2] = "Mustafa Sel";
            ogrenciIsımListesi[3] = "Toprak";
            ogrenciIsımListesi[4] = "Arda";

            // Console.WriteLine(ogrenciIsımListesi[1]);

            // oluşturduğumuz olduğumuz dizimizin içerisindeki elemanları ekrana yazdıralım.

            foreach(string item in ogrenciIsımListesi)
            {
                Console.WriteLine(item);
            }

            for(int i = 0; i < ogrenciIsımListesi.Length; i++)
            {
                string gelenIsım = ogrenciIsımListesi[i];
                Console.WriteLine(gelenIsım);
            }

        }
    }
}
