using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatematikseLIslemler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matematik M = new Matematik();
            YenidenIslemYap:
            M.menuHazirla();
            int kullaniciSecim = int.Parse(Console.ReadLine());

            Console.Write("Sayı 1 değerini giriniz : ");
            decimal kullaniciSayi1 = decimal.Parse(Console.ReadLine());

            Console.Write("Sayı 2 değerini giriniz : ");
            decimal kullaniciSayi2 = decimal.Parse(Console.ReadLine());

            decimal sonuc = 0;

            switch (kullaniciSecim)
            {
                case 1: // Toplama işlemi
                    sonuc = M.toplamaIslemi(kullaniciSayi1, kullaniciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "+");
                    break;
                        case 2: // Çıkarma İşlemi
                    sonuc = M.cikartmaIslemi(kullaniciSayi1, kullaniciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "-");
                    break;
                        case 3: // Bölme İşlemi
                    sonuc = M.bölmeIslemi(kullaniciSayi1, kullaniciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "/");
                    break;
                        case 4: // Çarpma İşlemi
                    sonuc = M.carpmaIslemi(kullaniciSayi1, kullaniciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "*");
                    break;
                    default:
                    Console.WriteLine("Belirtmiş olduğunuz değer liste içerisinde bulunamadı.");
                    Console.WriteLine("Lütfen Yeniden Deneyiniz");
                    System.Threading.Thread.Sleep(1500);
                    goto YenidenIslemYap;
            }

            Console.Write("Yeni İşlem Yapmak İstiyor Musunuz ? [ E / H ] : ");
            string EH = Console.ReadLine();
            string EH2 = EH.ToUpper();
            if(EH2 == "E")
            {
                goto YenidenIslemYap;
            }
        }
    }
}
