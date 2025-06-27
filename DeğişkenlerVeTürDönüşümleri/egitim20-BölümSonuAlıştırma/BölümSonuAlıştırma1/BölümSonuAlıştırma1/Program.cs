using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BölümSonuAlıştırma1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Merhaba
             * İsminiz : Alican
             * Soyisim : Kaya
             * Şehir : İstanbul
             * Yaş : 23
             * 
             * Ekran Temizle 
             * 
             * Ekran Çıktısı Yukarıdaki gibi
             * 
             */


            Console.WriteLine("Merhaba");
            Console.Write("İsminiz Nedir : ");
            string isim = Console.ReadLine();

            Console.Write("Soyisminiz Nedir : ");
            string soyisim = Console.ReadLine();

            Console.Write("Şehriniz Nedir : ");
            string şehir = Console.ReadLine();

            Console.Write("Yaşınız Kaç : ");
            int bilgiAlma = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("İsminiz : " + isim);
            Console.WriteLine("Soyisminiz : " + soyisim);
            Console.WriteLine("Şehriniz : " + şehir);
            Console.WriteLine("Yaşınız : " + bilgiAlma); // Burada yaşParse da yazsak olurdu, yaşConvert de 
                                                     // Peki string + int nasıl oluyor ? oda ayrı bir konu
                                                     // Notların ilerisinde olucak.

            Console.ReadLine();
        }
    }
}
