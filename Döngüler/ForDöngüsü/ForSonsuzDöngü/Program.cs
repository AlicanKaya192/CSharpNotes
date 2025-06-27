using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForSonsuzDöngü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sonsuz Döngü Oluşturmak

            int sayac = 0;

            for(; ; )
            {
                sayac++;
                // break anahtar kelimesi;

                // if(sayac == 2)
                // break;

                // continue anahtar kelimesi

                if (sayac == 2)
                    continue;


                Console.WriteLine(sayac);

                Console.WriteLine("Merhaba ben bir sonsuz döngüyüm");
            }


        }
    }
}
