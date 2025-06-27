using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelUygulamasi
{
    internal static class Helper
    {
        public static void emailGonder(string aliciEmailadres, string konu, string icerik)
        {
            // Email gonderme islemleri devam edecek ...

            Console.WriteLine("Mail Gonderildi");
        }

        //public void Test()
        //{
              // Static olan class lar icerisinde standart metotlar kullanilamaz. ( statik olmayan metotlar kullanilamaz ) 
        //}

        //public string Tanim {  get; set; }

        // Static olan class lar icerisinde static olmayan bir field tanimlari yapilamaz

        //public Helper()
        //{
             // Her nesne ornegi alindiginda uygulama standart yapici metodu calistirir.
        //}

        static Helper()
        {
            // Uygulama icerisinde istenildigi kadar cagrilsinlar sadece ilk cagrilmada calisirlar
            Console.WriteLine("Helper => Static class => Static CTOR");
        }
    }
}
