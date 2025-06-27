using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatikNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Static : Nesne ornegi alinmadan ulasabildigimiz metot, field, sinif...
            // Tip M1 = new Tip();

            // Stack bolge icerisinde pointer imiz olustu...

            Ogrenci O1;

            // Stack bolgede pointer olustugu zaman static olan bir yapici metot calisti ve yine class icerisinde
            // tanimli olan statik field, metot statik dedigimiz bolgede olusturuldu.

            Ogrenci.Test2();

            O1 = new Ogrenci();

            // Stack bolgede olusan pointer => kendisini heap bolgede tamamladi... static olmayan tanimlarini tamamladi...

            O1.Test1(); // nesne ornegi alindikdan sonra Test1 adindaki metotuma ulasabildim

            /* Statik Kavrami gercek hayatta nerelerde kullanilir...
             * 
             * 1 - Ornek Helper.cs => Kontroller (TC kimlik nosu dogrumu veya gelen data dogru mu) tarzi karisik kontrolleri ayri olarak yapabiliriz
             * 
             * 2 - Olusturmus oldugumuz nesnemizin icerisinde olmasi gereken bazi kontroller vardir. => Bagimliligi farkli classlara oldugu icin ( proje icerisinde ozel oldugu icin)
             * nesne icerisinde statik metot tanimlari yapilir.
             * 
             * 3 - Class icerisinde bir field ( static ) tanimi yapar ilgili field icerisinde N farkli yerde olusturmus oldugumuz static field imiza ulasir degerimiz okuruz.
             * 
             * 4 - [ Uygulama ] => [ ozel helper ] => [ DLL ]  
             * 
             */
        }
    }
}
