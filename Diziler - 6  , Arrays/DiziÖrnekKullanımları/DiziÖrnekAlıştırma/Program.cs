using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DiziÖrnekAlıştırma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 30 elemanlı bir int dizi oluşturalım. Değerlerimizi random sınıfını next fonskiyonu ile 3 - 13 arasında
            // değerler ile dolduralım. Daha sonra dizi içerisinde ki elemanlarımızı ekrana yazdıralım ve ilgili dizi içerisinde
            // kaç tane 3 değeri olduğunu bulalım

            int[] dizi = new int[30];

            Random rnd = new Random();

            for(int atama = 0;  atama < dizi.Length; atama++)
            {
                dizi[atama] = rnd.Next(3, 13);
            }

            int sayac = 0;

            foreach(int sayilar in dizi)
            {
                Console.WriteLine(sayilar);
                if(sayilar == 3)
                {
                    sayac++;
                }
            }

            Console.WriteLine("Dizide {0} kadar 3 var.", sayac);

        }
    }
}
