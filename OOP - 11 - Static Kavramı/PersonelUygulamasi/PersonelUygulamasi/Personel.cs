using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelUygulamasi
{
    public class Personel
    {
        public static string domainAdres = "gmail.com";

        public string isim {  get; set; }
        public string Soyisim { get; set; }

        private string _emailadres;

        public string Emailadres
        {
            get
            {
                return this._emailadres;
            }
            set
            {
                this._emailadres = value.ToLower() + "@" + Personel.domainAdres;
            }
        }

        public int Cinsiyet {  get; set; }

        public Personel()
        {
            Console.WriteLine("Her orneklemede calisan metot");
        }

        static Personel()
        {
            domainAdres = "firmam.com";

            // once static yapici metot calisir daha sonra normal yapici metot calisir.

            // 2 defa ornekleyip calistirmamiza ragmen static oldugu icin 1 defa calisacak ancak normal yapici metodumuz 1 defa calisacak
        }
    }
}
