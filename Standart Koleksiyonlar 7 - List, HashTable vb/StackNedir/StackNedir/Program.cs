using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack S1 = new Stack();

            // İçerisine aldığı dataları komut ile kendi listesi içerisinde sırası ile çıkarmamıza yarıyor.

            // Örnek : 1000 rowluk bir data bloğu geldi ve bunu tek tek inceleyip üzerinde işlemler yapıp
            // eğer başaralı ise bu listeden çıkarmak istiyoruz.

            // Stack de son gelen, ilk sıraya alınarak işlem yapılır.
            // Last in first out, yani 1 2 3 4 5 datamız var. 5 den başlayarak işlem yapar.


            S1.Push("Bir"); // Datayı obje tipinde ekler.
            S1.Push("İki");
            S1.Push("Üç");
            S1.Push("Dört");

            object o1 = S1.Pop(); // İlgili datayı bize gönderir ve datayı siler.
            object o2 = S1.Peek(); // Datayı bize gönderir ancak koleksiyondan çıkarmaz. Ön izlenim yapar.
        }
    }
}
