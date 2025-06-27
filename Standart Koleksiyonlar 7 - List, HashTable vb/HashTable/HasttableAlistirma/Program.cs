using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.InteropServices;

namespace HasttableAlistirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Hastable içerisine ENG - TR olarak data eklemeniz
             * 
             * Yeni kayıt eklemek istiyor musunuz E/H
             * E : Yeni kayıt ekleme işlemi devam etsin,
             * H : Tüm listeyi yazdırın
             * 
             * Var olan bir key değeri ekliyor ise kullanıcıya bu değer daha önceden girilmiş... şeklinde sistemimizde bulunmaktadır.
             */



            Hashtable sozlukVeriTabani = new Hashtable();

            do
            {
                Console.Clear();
                Console.WriteLine("Eklemek istediğiniz sözlük değerini yazınız : ");
                Console.WriteLine("EN : ");
                string eng = Console.ReadLine();

                bool kontrol = sozlukVeriTabani.ContainsKey(eng);
                if (kontrol) {
                    Console.WriteLine("Eklemek istediğiniz değer {0} sözlük içerisinde bulunmaktadır. {1] değerin türkçe karşılığıdır.", eng, sozlukVeriTabani[eng].ToString());
                }
                else
                {
                    Console.WriteLine("{0} türkçe karşılığını yazınız : ", eng);
                    string tr = Console.ReadLine();
                    sozlukVeriTabani.Add(eng, tr);
                    Console.WriteLine("Değer ekleme işlemi başarılı");
                }

                Console.WriteLine("Yeni değer eklemek istiyor musunuz ? ( E/H ) : ");
            } while (Console.ReadLine().ToUpper() != "H");

            // 1 . Yöntem
            foreach(var item in sozlukVeriTabani.Keys)
            {
                Console.WriteLine("ENG : {0} = TR : {1}",item, sozlukVeriTabani[item]);
            }

            // 2 . YOL

            foreach (DictionaryEntry item in sozlukVeriTabani)
            {
                // Console.WriteLine(item.GetType().Name);
                Console.WriteLine("ENG : {0} = TR : {1}", item.Key, item.Value);
            }
        }
    }
}
