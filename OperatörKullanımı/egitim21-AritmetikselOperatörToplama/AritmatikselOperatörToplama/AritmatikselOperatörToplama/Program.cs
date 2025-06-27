using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmetikselOperatörToplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Toplama Operatörü
            // + * sağına ve soluna gelen değişken tiplerine göre + operatörünün davranışı değişir.
            // int + int ( toplama işlemi yapar )
            // sağına veya soluna string geldiğinde

            int s1 = 10;
            int s2 = 15;
            int toplamInt = s1 + s2; // 2 tarafada bakıyor ve 2 taraf da int olduğu için toplama işlemi yapıyor

            byte s3 = 10;
            byte s4 = 10;
            int toplamByte = s3 + s4;
            // 2 byte toplamı yapılır iken gelen toplam değer int olarak gelir çünkü byte toplam gelen değerin kendi aralığında mı değil mi bilemiyor

            // string + int * ( string vericektir )

            string metin1 = "Merhaba";
            int s5 = 10;
            string toplamStr1 = metin1 + s5;
            // Derleyici burada merhaba ile 10 toplayamayacağı için 10 burda string olarak alıyor.


            // int + string * ( string vericektir )

            string toplamStr2 = s5 + metin1 + s5;
            // string + int de ki verdiği olayın aynısını vericek 


            // string + string *  bu tarz durumlarda toplama işlemimiz string birleştirme yapar ( string vericektir )

            string metin2 = " Dünya ";
            string toplamStr3 = metin1 + metin2;

            // Bu olaylar sadece + operatörüne özeldir. Diğer operatörlerde yoktur.


        }
    }
}
