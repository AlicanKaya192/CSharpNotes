using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SınıfTanımlamaVeInceleme
{
    internal class Musteri
    {
        /*
         * TC Kimlik numarasi
         * Isim
         * Soyisim
         * Cinsiyet
         */

        // Yapıcı metot ctor 

        public Musteri()
        {
            // TCkimliknumara = "23213214212";
        }

        public Musteri(string _tckimlikno)
        {
            TCkimliknumara = _tckimlikno;
        }

        public Musteri(string _tckimlikno, string _isim)
        {
            TCkimliknumara = _tckimlikno;
            isim = _isim;
        }

        public Musteri(string _tckimlikno, string _isim, string _soyisim)
        {
            TCkimliknumara = _tckimlikno;
            isim = _isim;
            soyisim = _soyisim;
        }

        public string TCkimliknumara;
        public string isim;
        public string soyisim;
        public int cinsiyet; // 717770001 : Bay - 717770002 : Bayan

        public bool MusteriKontrol()
        {
            // database gidilir musterinin tckimlik numarasina gore daha once kayit edilip edilmedigi bilgisi sorgulanir...

            bool kontrol = MusteriKontrolDatabase(TCkimliknumara);
            return kontrol;
        }

        private bool MusteriKontrolDatabase(string tckimliknumarasi)
        {
            return true;
        }
    }
}
