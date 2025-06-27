using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BölümSonuAlıştırma3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ekrana yazı yazdır

            Console.WriteLine("Alican Kaya");
            Console.Write("Alican Kaya");

            // String ata

            string isimm = "Alican";


            // Char ata

            char tekli = 'A';

            // Byte ve Int ata

            byte alıştırma = 255;
            int alıştırma2 = 256;

            // Double Decimal ve Float ata

            double double1 = 10.9;
            decimal decimal1 = 11.9M;
            float float1 = 13.9f;

            // Mantıksal Değişken ( bool ) ata

            bool onay = true;
            bool onay2 = false;

            // Zamansal Değişken ( DateTime )

            DateTime bugün = DateTime.Now;

            // Byte Int çevir / Bilinçli

            byte çevir = 255;
            int çevirbyte = çevir;

            // Int Byte Çevir / Bilinçsiz

            int çevir2 = 255;
            byte çevirint = (byte)çevir2;

            // Object Tipi ata

            object o5 = null;

            // Boxing İşlemi yap

            object o6 = "Alican";

            // Convert Ve Pars İşlemi yap

            string convertvepars = "255";

            byte bytepars = byte.Parse(convertvepars);
            int intconvert = Convert.ToInt32(bytepars);

            // Var Anahtarı oluştur

            var inta = 10;
            var stringa = "Alican";
            var decimala = 10.9M; // decimal olarak atanır çünkü 10.9 değerinin sonunda decimal ( M ) işareti vardır.

            // kısa yol ile karşıdan bilgi alma 

            Console.WriteLine("Merhaba");
            Console.Write("İsminiz Nedir : ");
            int isimAlma = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İsminiz : " + isimAlma);
            Console.ReadLine();

        }
    }
}
