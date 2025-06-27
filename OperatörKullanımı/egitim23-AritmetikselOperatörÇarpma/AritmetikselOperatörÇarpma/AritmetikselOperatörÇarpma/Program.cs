using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmetikselOperatörÇarpma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // * işareti
            // byte int double float decimal
            // sayısal işlemler yapabildiğimiz değişken tiplerinde kullanılır

            double d1 = 10.4;
            double d2 = 10;
            double sonuc = d1 * d2;

            int sonucInt = (int)(d1 * d2); // Burada double değeri intden büyük olabilme ihtimali olduğu için hata verir
                                           // değer (int) ekleyerek sonucun int olucağını belirtiyoruz
                                           // Burada çarptıkdan sonra int e dönüştürüyor.
                                           // Sonuç ondalıklı ise onu tam sayıya yuvarlar.
                                           // Yani burda değer kaybı olur ve bizde bunu kabul etmiş oluruz.

            double sonucDouble = d1 * d2;
            sonucInt = (int)sonucDouble;   // 2.yol

        }
    }
}
