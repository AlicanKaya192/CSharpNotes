using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotMatematikİşlemleriTekrar
{
    internal class matematik
    {
        public decimal toplamaIslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 + sayi2;
            return sonuc;
        }

        public decimal cikarmaIslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 - sayi2;
            return sonuc;
        }

        public decimal carpmaIslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 * sayi2;
            return sonuc;
        }

        public decimal bölmeIslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 / sayi2;
            return sonuc;
        }

        public void menuHazirla()
        {
            Console.WriteLine("MATEMATİK İŞLEMLER MENÜ");
            Console.WriteLine("1 - TOPLAMA");
            Console.WriteLine("2 - ÇIKARMA");
            Console.WriteLine("3 - ÇARPMA");
            Console.WriteLine("4 - BÖLME");
            Console.Write("Lütfen İşlem Seçiniz : ");
        }

        public void ekranaYazma(decimal sayi1, decimal sayi2, decimal sonuc, string sembol)
        {
            Console.WriteLine("{0} {1} {2} = {3}", sayi1, sembol, sayi2, sonuc);
        }
    }
}
