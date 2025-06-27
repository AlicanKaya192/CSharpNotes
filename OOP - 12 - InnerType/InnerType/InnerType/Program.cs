using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();

            M1.musteriID = 1;
            M1.tcKimlikNumarasi = "12345678910";
            M1.isim = "Alican";
            M1.soyisim = "Kaya";
            M1.olusturmaTarih = DateTime.Now;

            // M1.musteriAdresleri = new MusteriAdres[5];
            // Asla yapma ...

            M1.musteriAdresleri[0] = new MusteriAdres()
            {
                Il = "Istanbul",
                Ilce = "Umraniye",
                Adres = "Adres ...",
                adresTip = "Is Yeri"
            };

            M1.musteriAdresleri[0].MusteriAdresTestMetot();

            M1.musteriSiparisBilgileri[0] = new MusteriSiparisBilgisi()
            {
                siparisNumarasi = "SIP0001"
            };

            M1.musteriSiparisBilgileri[0].urunler[0] = new Urun()
            {
                urunID = 1,
                Tanim = "cikolata",
                fiyat = 5.5m
            };

            Console.ReadLine();
        }
    }
}
