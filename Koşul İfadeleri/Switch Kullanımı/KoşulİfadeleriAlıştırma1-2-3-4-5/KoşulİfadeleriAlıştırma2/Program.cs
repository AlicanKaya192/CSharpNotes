using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoşulİfadeleriAlıştırma2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Sistem içerisine giriş yapabilicek kullanıcı kodları
             * 
             * ABC - 123 - 236 - CMK
             * Kullanıcı girişiniz başarılı
             * 
             * Sistem içerisine girişi yasaklanmış kullanıcı kodları
             * 
             * HHH - BBB - MMM
             * 
             * Kullanıcı girişiniz kilitlenmiştir
             * 
             * Bunların dışında ise,
             * 
             * Hatalı kullanıcı kodu
             * 
             */


            Console.Write("Kullanıcı kodunuz: ");
            string kullaniciKodu = Console.ReadLine();
            kullaniciKodu = kullaniciKodu.ToUpper(); 
            // Girilen değeri büyük harflere dönüştürerek, küçük girilen doğru değerleri, doğru şekilde algılamaya sağlar.

            if (kullaniciKodu == "ABC" || kullaniciKodu == "123" || kullaniciKodu == "236" || kullaniciKodu == "CMK")
            {
                Console.WriteLine("Kullanıcı girişiniz başarılı");
            }
            else if (kullaniciKodu == "HHH" || kullaniciKodu == "BBB" || kullaniciKodu == "MMM")
            {
                Console.WriteLine("Kullanıcı girişiniz kilitlenmiştir");
            }
            else
            {
                Console.WriteLine("Hatalı Kullanıcı Kodu");
            }


        }
    }
}
