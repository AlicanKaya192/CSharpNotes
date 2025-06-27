using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SınıfTanımlamaVeInceleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.TCkimliknumara = "10120234562";
            M1.isim = "Alican";
            M1.soyisim = "Kaya";
            M1.cinsiyet = 71777001;
           
            Musteri M2 = M1; // M2 üzerinde yaptığım değişiklikler M1 de etkiler buda referans tipli davranıştır. Çünkü aynı yere bakıyorlar.
            M2.TCkimliknumara = "50543489704";
            M2.isim = "Murat";

            bool musteriKontrol = M1.MusteriKontrol();

            //M2 = null;
            //M1 = null; 
            
            /* Hit bölgede duran veri kümem garbage collection a gider.
                        * Daha sonra tüm verileri ramden siler ve sistemi rahatlatır.
                        Biz buna using blokları ile müdahale edebiliyoruz. Bunu da farklı bir örnek konuda görüceksiniz. */

            /* Garbage collection için örnek
             * Bellekten düşme
              .NET FRAMEWORK garbage collection mantığı ile bunu kendisi yapıyor. */

            /* Hit bölgede onu tutan herhangi bir şey kalmaz ise değer ramden düşer.
             * Peki nereye düşer ? Garbage collection kısmına düşer.
             * Arka tarafta hafızada kalan atıl datayı alıp dispose(elden çıkarmak) eden bir yapıya gider.
               Daha sonra datamız komple silinir. */

            string isim = M2.isim;
            // Burada hata alacağız. Çünkü M2 değeri new anahtar kelimesi ile açılmamıştır.
        }
    }

    /*class Musteri
    *{
        * Classlarımız namespace altında bulunur. namespace en üst seviyedir
        * Bu şekilde de class oluşturabiliriz ancak kodun okunulabilirliği açısından tavsiye edilmez.
     }*/
}
