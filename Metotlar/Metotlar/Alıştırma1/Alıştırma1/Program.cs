using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alıştırma1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kişiden öğrenci isim ve soyisim al
            // daha sonra 3 notunu al
            // ortalaması 45 altı ise kaldın mesajı alıcak, üstünde ise geçtin mesajı alıcak

            Console.Write("Öğrenci İsim : ");
            string ogrenciAd = Console.ReadLine();

            Console.Write("Öğrenci Soyisim : ");
            string ogrenciSoyad = Console.ReadLine();

            Console.Write("1. Sınav notunuz : ");
            decimal not1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("2.Sınav notunuz : ");
            decimal not2 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("3. Sınav notunuz : ");
            decimal not3 = Convert.ToDecimal(Console.ReadLine());

            Ogrenci O = new Ogrenci();
            O.puanHesapla(ogrenciAd, ogrenciSoyad, not1, not2, not3);
            
        }
    }
}
