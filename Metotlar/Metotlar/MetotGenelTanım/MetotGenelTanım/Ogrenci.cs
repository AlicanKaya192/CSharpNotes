using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotGenelTanım
{
    public class Ogrenci
    {
        public void ogrenciSelamla()
        {
            Console.WriteLine("Selam Ogrenci");
        }

        /*
         * 
         * [ErişimBelirleyicisi] <GeriDonusDegeri> MetotAdi (Parametreler)
         * {
         *      // Metot için gereken kodlar...
         * }
         * 
         * Erişim Belirleyicisi
         * 
         * Public // Her yerden ulaşılabilir olur
         * Private // Sadece yazıldığı class içerisinde erişilir
         * Protected // Birbirinden nesneler kalıtıldığında kullanılır
         * Internal
         * Internal Protected // Uygulama içerisinde ulaşabilirsin veya kalıtıldıysa
         * 
         */

        public void OgrenciMetot1(string ogrenciAdi, string ogrenciSoyadi)
        {
            Console.WriteLine("Öğrenci Bilgileri : {0} {1}", ogrenciAdi, ogrenciSoyadi);
        }
    }
}
