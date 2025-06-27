using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoşulİfadeleriAlıştırma4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Not Ortalaması Sistemine Hoşgeldiniz !
             * 
             * İsim ve soyisim : Alican Kaya
             * Not 1 : 50
             * Not 2 : 40
             * Not 3 : 60
             * 
             * Ortalama 45 değerinden küçük ise : Kaldınız
             * Ortalama 45 değerine eşit veya 70 değerinden küçük ise : Orta İle geçtiniz
             * Ortalama 70 değerine eşit veya 90 değerinden küçük ise : İyi ile geçtiniz
             * Ortalama 90 ile 100 arasında ise ( 100 dahil ) : Başarılı Tebrikler
             * Ortalama değeri 100 den büyük ise : Notlarınızı kontrol ediniz.
             * 
             */

            Console.WriteLine("Not Ortlaması Sistemine Hoşgeldiniz");

            Console.Write("İsminiz ve Soyisim: ");
            string isimSoyisim = Console.ReadLine();

            Console.Write("1. Notunuz: ");
            double not1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("2. Notunuz: ");
            double not2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("3. Notunuz: ");
            double not3 = Convert.ToDouble(Console.ReadLine());

            double sonuc = (not1 + not2 + not3) / 3;

            if (sonuc < 45)
            {
                Console.WriteLine("Kaldınız");
            }
            else if (sonuc >= 45 || sonuc < 70 )
            {
                Console.WriteLine("Orta İle Geçtiniz");
            }
            else if (sonuc >= 70 || sonuc < 90)
            {
                Console.WriteLine("İyi ile geçtiniz");
            }
            else if (sonuc >= 90 && sonuc <= 100)
            {
                Console.WriteLine("Başarılı Tebrikler");
            }
            else
            {
                Console.WriteLine("Notlarınızı Kontrol ediniz. Değerler 100'den büyük");
            }

            // NOT : Eğer if, else if veya else de tek satır kod kullanıyorsanız süslü parantez {] koymak zorunda değilsiniz.
            // Ama okunabilirlik için koymanız çok daha iyi olur
            // Eğer kullanmıyorsanız yazdığınız tek satır koddan sonra gelen kod if, else if veya else' in kodu olmaz.
        }
    }
}
