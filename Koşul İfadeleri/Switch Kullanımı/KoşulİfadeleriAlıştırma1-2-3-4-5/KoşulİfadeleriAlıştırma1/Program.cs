using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoşulİfadeleriAlıştırma1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kullanıcı Adınız: ");
            string kullaniciAdi = Console.ReadLine();

            Console.Write("Şifreniz: ");
            string sifre = Console.ReadLine();

            // Kullanıcı adı : admin
            // Şifre : 123


            if (kullaniciAdi == "admin" && sifre == "123")
            {
                Console.WriteLine("Bilgiler Doğru Hesaba Giriş Yapılıyor.");
            }
            else
            {
                Console.WriteLine("Bilgileriniz Yanlış Tekrar Deneyiniz");
            }


            Console.ReadLine();

        }
    }
}
