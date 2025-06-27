using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue Q1 = new Queue();

            // Değerler eklediğimiz sıra ile gelir.

            Q1.Enqueue("Bir"); // Burda listeye ekleme kodumuz değişiyor." Enqueue " ile ekliyoruz.
            Q1.Enqueue("İki");
            Q1.Enqueue("Üç");
            Q1.Enqueue("Dört");

            object O1 = Q1.Peek(); // Bir sonraki değerimizin ne olduğunu gösterir ancak değeri silmez.
            object O2 = Q1.Dequeue(); // Değeri gönderdikden sonra ilgili değeri koleksiyon içerisinden siler.
        }
    }
}
