using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel P1 = new Personel();
            P1.isim = "Alican";
            P1.Soyisim = "Kaya";
            P1.Emailadres = "alican.kaya";
            P1.Cinsiyet = 717770001; // Bay 717770001 - Bayan 717770002

            Personel P2 = new Personel();
            P1.isim = "Alican";
            P1.Soyisim = "Kaya";
            P1.Emailadres = "alican.kaya";
            P1.Cinsiyet = 717770001; // Bay 717770001 - Bayan 717770002

            // Helper H1 = new Helper(); static olarak isaretlenmis classlar orneklenemez.

            Helper.emailGonder("ik@firmam.com","Yeni Personel Bilgilendirme",P1.isim + P1.Soyisim);
            Helper.emailGonder("ik@firmam.com", "Yeni Personel Bilgilendirme", P1.isim + P1.Soyisim);

            // 2.kez cagirilirken static yapici metot 1 kere calisacagi icin 2. seferinde helper static metodumuz Console Yazisini yazmayacak
        }
    }
}
