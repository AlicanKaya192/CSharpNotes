using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotGenelTanım
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Uzun bir şekilde yazım ( using yok iken yani kütüphane )
            // System.Console.WriteLine("Merhaba");
            // using kısmında kütüphane eklenmiş hali ile yazımı.
            // Console.WriteLine("Merhaba");
            // Selamla();

            Ogrenci O1 = new Ogrenci();
            O1.OgrenciMetot1("Alican","Kaya");
            // O1.ogrenciSelamla();
        }

        static void Selamla() // void Ben bu metodu çalıştırırım ancak herhangi bir değer dönmem demek
        {
            Console.WriteLine("Merhaba");
        }
    }
}
