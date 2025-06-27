using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Kimlik
    {
        string ad;
        string soyad;
        string memleket;
        int yas;
        string cinsiyet;
        public string AD
        {
            get { return ad; }
            set { ad = value; }
        }

        public string SOYAD
        {
            get { return soyad; }
            set { soyad = value; }
        }

        public string MEMLEKET
        {
            get { return memleket; }
            set { memleket = value; }
        }

        public int YAS
        {
            get { return yas; }
            set { yas = value; }
        }

        public string CINSIYET
        {
            get { return cinsiyet; }
            set { cinsiyet = value; }
        }

        public Kimlik()
        {
            Console.Write("Lütfen adınızı giriniz: ");
            ad = Console.ReadLine();
            Console.Write("Lütfen soyadınızı giriniz: ");
            soyad = Console.ReadLine();
            Console.Write("Lütfen memleketinizi giriniz: ");
            memleket = Console.ReadLine();
            Console.Write("Lütfen yaşınızı giriniz: ");
            yas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen cinsiyetinizi giriniz: ");
            cinsiyet = Console.ReadLine();
            Console.WriteLine($"Ad: {ad}, Soyad: {soyad}, Memleket: {memleket}, Yaş: {yas}, Cinsiyet: {cinsiyet}");
        }
    }
}
