using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatörAlıştırma2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcı adı : admin
            // Şifre : 123

            // Kullanıcı adınızı giriniz :
            // Şifrenizi giriniz :

            Console.Write("KUllanıcı adı giriniz : ");
            string kullanıcıAdı = Console.ReadLine();

            Console.Write("Şifre giriniz : ");
            string sifre = Console.ReadLine();

            bool kontrolKullanıcıAdı = kullanıcıAdı == "admin123";
            bool kontrolKullanıcıAdı2 = sifre != "admin123";

            bool kontrolSifre = sifre == "123";
            bool kontrolSifre2 = sifre != "123";

            Console.Clear();

        }
    }
}
