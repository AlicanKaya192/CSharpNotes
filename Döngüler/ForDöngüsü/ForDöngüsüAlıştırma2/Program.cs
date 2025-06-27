using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDöngüsüAlıştırma2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcı ekran üzerinden bir sayı girişi yapacak . (5) girilen sayının faktöriyel hesabını ekrana yazdıralım

            Console.Write("Faktoriyel almak istediğiniz değeri giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int toplam = 1;

            for ( int i = sayi; i > 1; i--)
            {
                toplam *= i;
            }

            Console.WriteLine("{0} değerin faktoriyel sonucu = {1}", sayi, toplam);

        }
    }
}
