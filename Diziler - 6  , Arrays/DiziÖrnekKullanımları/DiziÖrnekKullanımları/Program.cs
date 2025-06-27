using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziÖrnekKullanımları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Uygulama 1 : int veri tipinde bir dizi oluşturalım, kullanıcımız dizinin kaç elemanlı olacağı bilgisini bize versin,
            // ve dizi içindeki alanlara değer atamasını yapsın. Daha sonra dizi içerisinde ki elemanların toplamlarını ve ortalamasını
            // ekrana yazdıran bir uygulama yazdıralım

            Console.Write("Lütfen oluşturmak istediğiniz veri kümesinin uzunluğunu giriniz: ");
            int[] uygulama1Dizi = new int[Convert.ToInt32(Console.ReadLine())];

            for(int uygulamaSayac = 0; uygulamaSayac < uygulama1Dizi.Length; uygulamaSayac++)
            {
                Console.WriteLine("{0} . index e denk gelen değeri giriniz: ", uygulamaSayac);

                uygulama1Dizi[uygulamaSayac] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Dizinin içerisindeki tüm alanları doldurdunuz");

            Console.WriteLine("Dizi içerisindeki değerler ve toplam, ortalam değeri aşağıdaki gibidir.");

            int uygulama1Toplam = 0, uygulama1Ortalama = 0;
            foreach(int item  in uygulama1Dizi) 
            { 
                Console.WriteLine(item); 
                uygulama1Toplam = uygulama1Toplam + item;
            }

            Console.WriteLine("-------------------------------");
            Console.WriteLine(uygulama1Toplam);

            Console.WriteLine("Dizi içerisindeki eleman sayısı: {0}", uygulama1Dizi.Length);
            uygulama1Ortalama = uygulama1Toplam / uygulama1Dizi.Length;
            Console.WriteLine("Ortalama: {0}", uygulama1Ortalama);
        }
    }
}
