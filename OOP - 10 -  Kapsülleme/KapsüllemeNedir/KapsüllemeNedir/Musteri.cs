using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsüllemeNedir
{
    internal class Musteri
    {
        public Musteri() 
        {
            this.id = IDUret();
        }

        // Class => Field
        private int id;
        public int ID 
        {
            get 
            {
                return this.id; 
            }

            private set // Kullanilmasini istemiyorsam eger private olarak isaretlenmesi lazim 
            {
                this.id = value;
            }
        }

        public string isim;
        private string _soyisim;
        public string soyisim
        {
            get
            {
                return this._soyisim;
            }

            set
            {
                this._soyisim = value;
                this.emailAdres = string.Format("{0}.{1}@gmail.com", isim, _soyisim);
            }
        }

        private string emailAdress;

        // Class => Property

        public string EmailAdress
        {
           // get; // DataBase veya farkli bir veri kaynagi .. class cagiran programciya datayi gosterdigimiz kisim...
           // set; // dis dunyadan alinan datanin iceride private olarak saklanan field icerisine deger atandigi kisim...

            set
            {
                this.emailAdress = value;
            }

            get
            {
                return this.emailAdress;
            }
        }

        private int IDUret()
        { 
            Random rnd = new Random();
            return rnd.Next(10000, 90000);
        }

        // isim soyisim ve email

        private string emailAdres;

        public string EmailAdres
        {
            // get; // database veya farkli veri kaynagi ... class cagiran programciya datayi gosterdigimiz kisim...
            // set; // dis dunyadan alinan datanin iceride private olarak saklanan field icerisine deger atandigi kisim...

            private set
            {
                this.emailAdres = value;
            }

            get
            {
                return this.emailAdres;
            }
        }
    }
}
