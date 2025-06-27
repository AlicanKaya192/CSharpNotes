using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotMatematikİşlemleriTekrar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            matematik islemler = new matematik();
            YenidenHazırla:
            islemler.menuHazirla();
            int kullaniciSecim = Convert.ToInt32(Console.ReadLine());

            Console.Write("1. sayıyı giriniz : ");
            decimal sayi1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("2. sayıyı giriniz : ");
            decimal sayi2 = Convert.ToDecimal(Console.ReadLine());

            decimal sonuc = 0;

            switch (kullaniciSecim)
            {
                case 1: 
                    sonuc = islemler.toplamaIslemi(sayi1, sayi2);
                    islemler.ekranaYazma(sayi1, sayi2, sonuc, "+");
                    break;
                    case 2:
                    sonuc = islemler.cikarmaIslemi(sayi1, sayi2);
                    islemler.ekranaYazma(sayi1, sayi2, sonuc, "-");
                    break;
                        case 3:
                    sonuc = islemler.carpmaIslemi(sayi1, sayi2);
                    islemler.ekranaYazma(sayi1, sayi2, sonuc, "*");
                    break;
                        case 4:
                    sonuc = islemler.bölmeIslemi(sayi1, sayi2);
                    islemler.ekranaYazma(sayi1, sayi2, sonuc, "/");
                    break;
                    default:
                    Console.WriteLine("Menü Dışı Seçim Yaptınız.");
                    Console.WriteLine("Lütfen Yeniden Deneyiniz ");
                    System.Threading.Thread.Sleep(1500);
                    goto YenidenHazırla;
                    break;
            }

            Console.Write("Yeniden İşlem Yapmak İster Misiniz ? - Y / N :  ");
            string tekrarAl = Console.ReadLine();
            string tekrarAl2 = tekrarAl.ToUpper();
            if(tekrarAl2 == "Y")
            {
                goto YenidenHazırla;
            }
        }
    }
}
