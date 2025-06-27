using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenelAlistirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.musteriID = 1;
            M1.isim = "Alican";
            M1.soyisim = "Kaya";
            M1.emailAdres = "alican.kaya@gmail.com";
            M1.KullaniciAdi = "alican.kaya";
            M1.sifre = "1";

            Musteri.MusteriEkle(M1);

            Musteri M2 = new Musteri()
            {
                musteriID = 2,
                isim = "Toprak",
                soyisim = "Gulec",
                emailAdres = "toprak.gulec@gmail.com",
                KullaniciAdi = "toprak.gulec",
                sifre = "2"
            };

            Musteri.MusteriEkle(M2);

            Musteri M3 = new Musteri()
            {
                musteriID = 3,
                isim = "Toprak",
                soyisim = "Gulec",
                emailAdres = "toprak.gulec@gmail.com",
                KullaniciAdi = "toprak.gulec",
                sifre = "3"
            };

            Musteri.MusteriEkle(M3);
        }
    }
}
