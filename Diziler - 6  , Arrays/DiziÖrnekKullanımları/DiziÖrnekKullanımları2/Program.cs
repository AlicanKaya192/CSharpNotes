using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziÖrnekKullanımları2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 20 elemanlı bir int dizi oluşturalım. Değerlerimizi random sınıfını next fonskiyonu ile 1 - 10 arasında
            // değerler ile dolduralım. Daha sonra dizi içerisinde ki elemanlarımızı ekrana yazdıralım ve ilgili dizi içerisinde
            // kaç tane 4 değeri olduğunu bulalım

            int[] d1 = new int[20];
            Random rnd = new Random();

            for ( int i = 0; i < d1.Length; i++ )
            {
                d1[i] = rnd.Next(1, 10);
            }

            int dortSayisiAdeti = 0;

            foreach ( int sayilar in d1)
            {
                Console.WriteLine(sayilar);
                if (sayilar == 4)
                {
                    dortSayisiAdeti++;
                }
            }

            Console.WriteLine("Oluşan dizi içerisinde: {0} adet 4 vardır.", dortSayisiAdeti);

        }
    }
}
