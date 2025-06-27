using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotAlıştırma3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Öğrenciden isim soyisim alıcaz ve notlarını daha sonra kişinin bilgilerini ekrana yazıcaz
            // ortalamasını gösterdikden sonra eğer öğrenci 45 üstü aldı ise geçti almadı ise geçemedi yazıcak

            Console.Write("Öğrencinin Adı : ");
            string ad = Console.ReadLine();

            Console.Write("Öğrencinin Soyadı : ");
            string soyad = Console.ReadLine();

            Console.Write("1. notunuz nedir : ");
            decimal not1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("2. notunuz nedir : ");
            decimal not2 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("3. notunuz nedir : ");
            decimal not3 = Convert.ToDecimal(Console.ReadLine());

            ortalama o = new ortalama();

            o.notlar(ad,soyad, not1, not2, not3);
        }
    }
}
