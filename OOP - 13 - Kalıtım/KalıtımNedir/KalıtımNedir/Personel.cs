using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalıtımNedir
{
    public class Personel : temelTip
    {
        public DateTime IsBaslangicTarih { get; set; }
        public DateTime IsBitisTarihi { get; set; }
        public int IzinGunSayisi { get; set; }
    }
}
