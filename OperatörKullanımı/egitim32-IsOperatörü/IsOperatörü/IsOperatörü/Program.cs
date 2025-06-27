using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IsOperatörü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Is Operatörü
            // bool donenDeger = degisken is degiskenTipi

            int s1 = 50;
            int s2 = 100;

            // object değeri kutularken değerin oluştuğu değişkeni de kutular
            // ve değeri içerisinden çıkarırken kutuladığı değişken ile çıkarmamız gerekiyor

            object o1 = s1; // object kendi içerisinde bulunduğu komutdan dolayı string olarak gösterir.
            //Console.WriteLine(o1);

            s1 = (int)o1;
            //s1 = (byte)o1; s1 kutulanırken int olarak kutulandığı ve dışarı o şekilde çıkması gerektiği için burada byte hata verir
                                // bu yüzden yorum satırına alıyoruz 

            bool isKontrol = o1 is int; // true gelicektir
           // bool isKontrol2 = o1 is byte; // false gelicektir

        }
    }
}
