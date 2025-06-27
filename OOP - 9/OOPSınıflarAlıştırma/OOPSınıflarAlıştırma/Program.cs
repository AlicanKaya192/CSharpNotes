using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSınıflarAlıştırma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arac A1 = new Arac("Opel", "Corsa", 2010, 56000)
            {
                AlisFiyat = 28000,
                SatisFiyat = 32000,
                MaxIndirimTutar = 1500
            };
            // A1.Fiyat = Kapsulleme Konusu....
            A1.FiyatAta(31000);
            A1.BilgeriGoruntule();
        }
    }
}
