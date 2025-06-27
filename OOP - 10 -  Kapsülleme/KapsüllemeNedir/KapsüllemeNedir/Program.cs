using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsüllemeNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            //  M1.id = 1;
            // M1.isim = "Alican";
            // M1.soyisim = "Kaya";

            /*
             * Field deger atamasi yapilamasin ama deger okunabilsin.
             * Field deger atamasi yapilsin ama deger okunamasin.
             * Field deger atamasi yapilsin ama degerin ilk 4 hanesi okunsun.
             * Field deger atamasi ve okuma islemleri yapilsin ama bu iki islemde bizim belirledigimiz bir surecten gecsin
             * veri daha sonra gosterilsin.
             * 
             * Kisacasi class icerisinde bir alanin deger alma ve deger okuma kisimlarina mudahale ettigimiz yerlere
             * kapsulleme denir.
             */

            // Class
            // Field
            // Property
            // Get & Set

            // M1.emailAdress = "csharpkonulari@gmail.com"; ( Field )
            //M1.EmailAdress = "csharpkonulari@gmail.com";
            //Console.WriteLine(M1.EmailAdress);

            // 1. Field deger atamasi yapilamasin ama deger okunabilsin.

            Console.WriteLine("Musteri ID Degeri = " + M1.ID.ToString());
            // M1.ID = 10; sett blogu private oldugu icin deger atanamaz ancak okunabilir

            // isim ve soyisim
            // isim ve soyisim [soyisim] = set
            // email adresi...
            // email get alican.kaya@gmail.com
            // set : private

            M1.isim = "Alican";
            M1.soyisim = "Kaya";
            Console.WriteLine(M1.EmailAdres);
        }
    }
}
