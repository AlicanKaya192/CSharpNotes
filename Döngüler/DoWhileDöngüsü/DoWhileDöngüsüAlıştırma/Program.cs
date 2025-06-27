using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileDöngüsüAlıştırma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Alıştırma 1 : Kullancıyı do-while içerisine alın ve kullanıcı adı ve password sorun. Kullanıcı adı : Demo Şifre : Demo
            // Eğer kullanıcı bu değerleri bilirse döngüden çıkın ve başarılı yazın. Eğer yanlış giriş yapıyorsa 
            // tekrardan kişiye do-while ile ilgili değerleri sormaya devam edin.

            string kullanıcıAdı = string.Empty;
            string sifre = string.Empty;

            int sayac = 0;

            do
            {
                if (sayac > 0)
                    Console.WriteLine("Kullanıcı adı veya şifre hatalı");

                Console.Write("Kullanıcı Adı Giriniz: ");
                string gelenKullanıcıAdı = Console.ReadLine();

                Console.Write("Şifre Giriniz: ");
                string gelenSifre = Console.ReadLine();

                sayac++;

            } while (kullanıcıAdı.ToLower() != "demo" || sifre.ToLower() != "demo");

            Console.WriteLine("Başarılı Giriş");

        }
    }
}
