using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.InteropServices;

namespace ArrayListAlıştırma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kullaniciSecim = string.Empty;
            ArrayList degerListesi = new ArrayList();
            do
            {
                Console.Clear();
                Console.WriteLine("Menü");
                Console.WriteLine("1 - Değer Ekle");
                Console.WriteLine("2 - Değer Listele");
                Console.WriteLine("3 - Değer Ara");
                Console.WriteLine("4 - Değer düzenle");
                Console.WriteLine("5 - Değer sil");
                Console.WriteLine("6 - Uygulama Çıkış");
                Console.Write("Seçiniz: ");
                kullaniciSecim = Console.ReadLine();


                switch (kullaniciSecim)
                {
                    case "1":
                        Console.Write("Değer Giriniz: ");
                        string girilenDeger = Console.ReadLine();
                        degerListesi.Add(girilenDeger);
                        Console.WriteLine("Değeriniz Başarılı Bir Şekilde Eklendi");
                        System.Threading.Thread.Sleep(1000); // Sistemi mili saniyelik bekletir.
                        break;
                    case "2":
                        for (int i = 0; i < degerListesi.Count; i++)
                        {
                            Console.WriteLine("{0}. Değer = {1}", i, degerListesi[1]);
                        }
                        Console.WriteLine("Devam etmek için bir tuşa basınız");
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.Write("Aramak istediğiz değer: ");
                        string arananDeger = Console.ReadLine();
                        bool kontrol = degerListesi.Contains(arananDeger);
                        if (kontrol)
                        {
                            int bulunanIndex = degerListesi.IndexOf(arananDeger);
                            string bulunanDeger = degerListesi[bulunanIndex].ToString();
                            Console.WriteLine("Değeriniz Bulundu: index sırası : {0} - Değer : {1]", bulunanIndex, bulunanDeger);
                        }
                        else
                        {
                            Console.WriteLine("Aradığınız değer bulunamadı. Değeri eklemek ister misiniz ?");
                            string evetHayır = Console.ReadLine();
                        }
                        Console.WriteLine("Devam etmek için bir tuşa basınız");
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.WriteLine("Güncellemek istediğiniz değeri giriniz: ");
                        string kullaniciDüzenlenecekDeger = Console.ReadLine();

                        Console.WriteLine("{0} Değerini hangi değer ile güncellemek istiyorsunuz: ", kullaniciDüzenlenecekDeger);
                        string kullaniciYeniDeger = Console.ReadLine();

                        if (degerListesi.Contains(kullaniciDüzenlenecekDeger))
                        {
                            int kullaniciHedefIndex = degerListesi.IndexOf(kullaniciDüzenlenecekDeger);
                            degerListesi[kullaniciHedefIndex] = kullaniciYeniDeger;
                            Console.WriteLine("Değeriniz Güncellendi.");
                        }
                        else
                        {
                            Console.WriteLine("Aradığınız değer liste içerisinde yok");
                        }

                        System.Threading.Thread.Sleep(1000);
                        break;
                    case "5":
                        Console.Write("Tüm değerleri mi silmek istiyorsunuz: ");
                        string kullaniciSilCevap = Console.ReadLine();
                        
                        if(kullaniciSilCevap.ToUpper() == "E")
                        {
                            degerListesi.Clear();
                            Console.WriteLine("Tüm değerler silindi");
                        }
                        else
                        {
                            Console.WriteLine("Liste içerisinde silmek istediğiniz değeri giriniz: ");
                            string kullaniciSilDeger = Console.ReadLine();
                            if (degerListesi.Contains(kullaniciSilDeger))
                            {
                                degerListesi.Remove(kullaniciSilDeger);
                                Console.WriteLine("Değeriniz Silindi");
                            }
                            else
                            {
                                Console.WriteLine("Silmek istediğiniz değer liste içerisinde mevcut değil.");
                            }
                        }
                        break;
                    default:
                        break;
                }
            } while (kullaniciSecim != "6");


        }
    }
}
