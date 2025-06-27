using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOutKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ref ve out anahtar sozcukleri eski .NET Framework versiyonlarinda 1 fark vardi.
            // Mevcut Framework versiyonu 7.0 veya üstü olanlar bu farktan etkilenmeyecekler

            // int sayi1 = 0;
            // degerAta(ref sayi1);

            topla(5, 9, 20, 45, 22, 12, 11, 56);
        }

        static void degerAta(ref int gelenDeger)
        {
            gelenDeger = 10;
        }

        // Params 

        static void topla(params int[] sayilar)
        {
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            Console.WriteLine("Toplam : {0}", toplam);
        }
    }
}
