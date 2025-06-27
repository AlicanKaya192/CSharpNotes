using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SortedListNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList SortedL = new SortedList();
            SortedL.Add(100, "Yüz");
            SortedL.Add(90, "Doksan");
            SortedL.Add(1, "Bir");
            SortedL.Add(9000, "Dokuzbin");

            //SortedL.Add("A", "B");
            // Bunu hata olarak dönücek. Object olarak almadığı için hata vericek.
            // Int olarak başladıysak Listinize string ekleyemeyiz.
            // Bu kural key için geçerlidir

            // Hashtable ile aynı komutlara sahiptir.
        }
    }
}
