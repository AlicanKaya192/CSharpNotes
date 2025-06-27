using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType
{
    internal class Musteri
    {
        #region Tekli olarak kullanilan field

        public int musteriID { get; set; }
        public string tcKimlikNumarasi { get; set; }
        public string isim {  get; set; }
        public string soyisim { get; set; }
        public DateTime olusturmaTarih {  get; set; }
        public int kullaniciID { get; set; }

        #endregion

        #region Inner Type gerektiren field lar

        public MusteriAdres[] musteriAdresleri;
        public MusteriletisimBilgisi[] musteriIletisimBilgileri;
        public MusteriSiparisBilgisi[] musteriSiparisBilgileri;

        #endregion

        public Musteri()
        {
            musteriAdresleri = new MusteriAdres[5];
            musteriIletisimBilgileri = new MusteriletisimBilgisi[5];
            musteriSiparisBilgileri = new MusteriSiparisBilgisi[10];
        }
    }
}
