using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable H1 = new Hashtable();

            #region Yeni Değer Ekleme

            H1.Add("Car", "Araba"); // Yeni değer eklemeye yarar.
            H1.Add("House", "Ev" );

            H1.Add("Cars", "Arabalar");
            // H1.Add("Cars", "Arabalar"); Key değeri benzersiz olmak zorundadır.

            #endregion

            #region Yardımcı Metotlar

            bool kontrol1 = H1.Contains("House");  // House değeri içeride var true dönücek
            bool kontrol2 = H1.Contains("Door");   // Door değeri içeride yok false dönücek

            bool kontrol3 = H1.ContainsKey("House"); // Contains ile aynı işlevi yapar keyleri arar.
            bool kontrol4 = H1.ContainsValue("Araba"); // İçeride ki key değerine bakar, eğer varsa ona göre true veya false döner.

            int koleksiyonIcindekiToplamDeger = H1.Count;

            H1.Remove("Cars"); // Verdiğimiz keyi siler.           

            H1["House"] = "Villa"; // Key değerimize karşı gelen value değerini güncelledik.

            H1.Clear(); // koleksiyon içerisindeki tüm datayı temizler.

            #endregion


        }
    }
}
