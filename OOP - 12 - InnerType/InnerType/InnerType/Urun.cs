using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType
{
    internal class Urun
    {
        public int urunID {  get; set; }
        public string Tanim { get; set; }
        public decimal fiyat { get; set; }

        public Urun()
        {
            Console.WriteLine("Urun yapici metod calisti");
        }

        public void UrunTestMetod()
        {
            Console.WriteLine("UrunTestMetod");
        }
    }
}
