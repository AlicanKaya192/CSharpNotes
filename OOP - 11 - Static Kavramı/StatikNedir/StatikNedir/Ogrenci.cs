using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatikNedir
{
    internal class Ogrenci
    {
        public string Isim {  get; set; }
        public string Soyisim {  get; set; }
        public string EmailAdres {  get; set; }

        public void Test1()
        {
            Console.WriteLine("Nesne ornegi alindikdan sonra calisan metotdur.");
            Test2();
            // Statik olmayan bir metot statik olan bir metodu cagirabilir.
        }

        public static void Test2()
        {
            Console.WriteLine("Nesne ornegi alinmadan kullanilabilir");
            // Test1();
            // Statik olan bir metot statik olmayan bir metodu cagiramaz.
        }
    }
}
