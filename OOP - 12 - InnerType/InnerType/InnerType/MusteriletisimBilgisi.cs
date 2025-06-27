using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType
{
    internal class MusteriletisimBilgisi
    {
        public int iletisimTip {  get; set; } // 7177870001 - Model : 7177870001 - Sabit Hat
        public string alankodu { get; set; }
        public string numara { get; set; }
        public bool aktifPasif {  get; set; }

        public void MusteriIletisimBilgisiTestMetot()
        {
            Console.WriteLine("MusteriIletisimBilgisiTestMetot");
        }
    }
}
