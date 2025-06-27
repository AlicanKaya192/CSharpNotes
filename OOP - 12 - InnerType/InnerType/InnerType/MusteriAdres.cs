using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType
{
    internal class MusteriAdres
    {
        public string adresTip {  get; set; }
        public string Il {  get; set; }
        public string Ilce { get; set; }
        public string Adres {  get; set; }

        public MusteriAdres()
        {
            Console.WriteLine("Musteri Adres yapici metodu calisti");
        }

        public void MusteriAdresTestMetot()
        {
            Console.WriteLine("MusteriAdresTestMetot");
        }
    }
}
