using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DiziÖrnekAlıştırma2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Uygulama 1 : int veri tipinde bir dizi oluşturalım, kullanıcımız dizinin kaç elemanlı olacağı bilgisini bize versin,
            // ve dizi içindeki alanlara değer atamasını yapsın. Daha sonra dizi içerisinde ki elemanların toplamlarını ve ortalamasını
            // ekrana yazdıran bir uygulama yazdıralım

            Console.Write("Kaç elemanlı dizi oluşturucaksınız: ");
            int[] gelenDizi = new int[Convert.ToInt32(Console.ReadLine())];

            for (int atama = 0; atama < gelenDizi.Length; atama++)
            {
                Console.Write("{0} . Dizi için atama yapınız: ", atama);
                gelenDizi[atama] = Convert.ToInt32(Console.ReadLine());
            }

            int toplam = 0, ortalama = 0;

            foreach(int toplama in gelenDizi)
            {
                toplam = toplam + toplama;
            }

            Console.WriteLine("--------------------");
            Console.WriteLine("Toplamları: {0}", toplam);

            ortalama = toplam / gelenDizi.Length;

            Console.WriteLine("Ortalamaları: {0}", ortalama);

        }
    }
}
