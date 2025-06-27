using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenelAlistirma
{
    internal class Musteri
    {
        #region Sanal Database

        static ArrayList musteriDatabase;

        #endregion

        #region Static Yapici Metot

        static Musteri()
        {
            musteriDatabase = new ArrayList();
        }

        #endregion

        #region Field

        public int musteriID {  get; set; }
        public string isim {  get; set; }
        public string soyisim {  get; set; }
        public string emailAdres {  get; set; }
        public string sifre {  get; set; }

        #endregion

        #region Kapsulleme

        private string _kullaniciAdi;

        public string KullaniciAdi
        {
            get { return this._kullaniciAdi; }
            set
            {
                bool kullaniciAdiKontrol = musteriKullaniciAdiKontrol(value);
                if (kullaniciAdiKontrol)
                {
                    Console.WriteLine("Eklemek Istediginiz Kullanici Adi Sistem Icerisinde Kayitli");
                    this._kullaniciAdi = string.Empty;
                }
                else
                {
                    this._kullaniciAdi = value;
                }
            }
        }

        #endregion

        #region Static Metotlar

        static bool musteriKullaniciAdiKontrol(string _kullaniciadi)
        {
            bool Kontrol = false;

            for (int i = 0; i < musteriDatabase.Count; i++)
            {
                Musteri Temp = (Musteri)musteriDatabase[i];
                
                if(Temp.KullaniciAdi == _kullaniciadi)
                {
                    Kontrol = true;
                    break;
                }
            }

            return Kontrol;
        }

        public static void MusteriEkle(Musteri M)
        {
            #region Parametre Kontrol

            if(M != null && !string.IsNullOrEmpty(M.KullaniciAdi) && !string.IsNullOrEmpty(M.emailAdres))
            {
                bool emailAdresKontrol = musteriEmailAdresKontrol(M.emailAdres);
                if(emailAdresKontrol)
                {
                    Console.WriteLine("Eklemek Istediginiz Kullanici Sistemde Kayitli");
                }
                else
                {
                    musteriDatabase.Add(M);
                    Console.WriteLine("Yeni Kayit Islemi Basarili");
                }
            }

            #endregion
        }

        static bool musteriEmailAdresKontrol(string _emailAdres)
        {
            bool Kontrol = false;

            for (int i = 0;i < musteriDatabase.Count; i++)
            {
                Musteri Temp = (Musteri)musteriDatabase[i];
                if(Temp.emailAdres == _emailAdres)
                {
                    Kontrol = true;
                    break;
                }
            }
            return Kontrol;
        }

        #endregion
    }
}
