using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalıtımNedir
{
    public class temelTip
    {
        public int id {  get; set; }
        public string referansKod { get; set; }
        public string tcKimlikNumarasi {  get; set; }
        public string isim {  get; set; }
        public string soyisim { get; set; }
        public int cinsiyet {  get; set; }
        public int myProperty { get; set; }
        public DateTime kayitTarih {  get; set; }
        public int kayitKullanici { get; set; }
        public DateTime guncellemeTarih { get; set; }
        public int guncellemeKullanici { get; set; }
        public bool silindi {  get; set; }
    }
}
