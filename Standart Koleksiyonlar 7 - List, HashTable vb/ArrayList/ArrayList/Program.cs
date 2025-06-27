using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.CompilerServices;

namespace ArrayListGenelKullanım
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Capacity = 0;
            int Count = 0;

            string[] isimler = new string[10];

            ArrayList A1 = new ArrayList();

            #region Tek Değer Ekleme
            A1.Add("Alican Kaya"); // Add bir tane değer eklememizi sağlar. Bu değer herhangi bir değer olabilir çünkü object olarak atar yani tüm değer tiplerini kabul eder.
            Capacity = A1.Capacity;
            Count = A1.Count;
            A1.Add(100);
            #endregion

            #region

            ArrayList A2 = new ArrayList();
            A2.Add("Yakup");
            A2.Add("Merve");
            A2.Add("Tutku");
            A1.AddRange(A2); // Birden fazla değer ekler.
            #endregion

            #region
            Capacity = A1.Capacity; // Capacity büyümesi gerektiğinde 4 er 4 er artarak büyür.
            Count = A1.Capacity; // Koleksiyonun içerisindeki mevcut değer sayısını gösterir. 
            #endregion

            #region Koleksiyon içindeki değere ulaşmak
            object O1 = A1[3];
            string S1 = A1[3].ToString();
            int I1 = (int)A1[1];

            A1[3] = "Alican Kaya"; // 3.değeri değiştirdik.
            #endregion

            #region ArrayList Sıralama

            // Seçtiğimiz değeri siler.

            A1.Remove(100);

            // Dizinin mevcut elemanlarını ters olarak sıralama

            A1.Reverse();

            // A-Z Sıralama

            A1.Sort(); // İçeride int değeri olduğundan dolayı sıralama yapamayıp hata vericektir. Bu yüzden yukarıdaki int değerimizi bundan önce siliyoruz.

            #endregion

            #region Koleksiyonlar yardımcı komutlar

            if (A1.Contains("Yakup"))
            {
                int IndexDegeri = A1.IndexOf("Yakup"); // İlgili değeri ArrayListimizin içinde ki değerini bulup bizi verir.
                A1.RemoveAt(IndexDegeri);
            }

            bool Kontrol1 = A1.Contains("Tutku"); // Contains ilgili değerin ArrayListimizde olup olmadığını kontrol eder.
            bool Kontrol2 = A1.Contains(900);

            object[] D1 = A1.ToArray(); // ArrayListimizin içerisindeki tüm dataları objeden dizi olarak verir.

            A1.Clear(); // Array'ın içindeki herşeyi siler. Ancak kapasitesi kalır.
            A1.TrimToSize(); // İlgili koleksiyonun kapasitesini ilk aldığı değere yeniden ayarlamak için kullanılır.

            #endregion

            #region ArrayList koleksiyonu içerisindeki değeri silme

            A1.RemoveAt(3);
            A1.RemoveRange(1, 2);
            A1.Remove("Alican Kaya");

            #endregion

            #region 10 elemanlı ( string ) ArrayList içindeki değerleri Z-A olacak şekilde sıralayın

            ArrayList Deneme = new ArrayList();

            Deneme.Add("Ahmet");
            Deneme.Add("Elif");
            Deneme.Add("Mehmet");
            Deneme.Add("Yusuf");
            Deneme.Add("Fırtına");
            Deneme.Add("Bıldırcın");
            Deneme.Add("Yavuz");
            Deneme.Add("Kuş");
            Deneme.Add("Hasan");
            Deneme.Add("Yumruk");

            Deneme.Sort();
            Deneme.Reverse();

            #endregion
        }
    }
}
