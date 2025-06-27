using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String Tipi

            string isimSoyisim = "Alican Kaya";

            Console.WriteLine(isimSoyisim);

            isimSoyisim = "Umut";

            Console.WriteLine(isimSoyisim);

            string buyukKarakter = isimSoyisim.ToUpper();
            string kucukKarakter = isimSoyisim.ToLower();
            string belirliBirBolum = isimSoyisim.Substring(1, 3);

            Console.WriteLine(buyukKarakter);
            Console.WriteLine(kucukKarakter);
            Console.WriteLine(belirliBirBolum);


        }
    }
}
