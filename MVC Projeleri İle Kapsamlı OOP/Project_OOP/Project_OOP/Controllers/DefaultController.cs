using Microsoft.AspNetCore.Mvc;
using Project_OOP.Örnekler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_OOP.Controllers
{
    public class DefaultController : Controller
    {
        //void Islemler()
        //{
        //    var class1 = new Class1();
        //    class1.Topla();
        //}

        void messages()
        {
            ViewBag.m1 = "Merhaba, bu bir deneme mesajıdır.";
            ViewBag.m2 = "Bu mesaj, ViewBag kullanılarak gönderilmiştir.";
            ViewBag.m3 = "Bla Bla Bla";
        }

        int topla()
        {
            int sayi1 = 20;
            int sayi2 = 30;
            int sonuc = sayi1 + sayi2;
            return sonuc;
        }

        int environment()
        {
            int kisa = 10;
            int uzun = 20;
            int sonuc = 2* (kisa + uzun);
            return sonuc;
        }

        string sentence() 
        {
            string c = "Deneme mesaji";
            return c;
        }

        void messagesList(string p)
        {
            ViewBag.v = p;
        }

        void user(string userName)
        {
            ViewBag.u = userName;
        }

        int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        int factorial(int p)
        {
            int f = 1;

            for(int i = 1; i <= p; i++)
            {
                f *= i;
            }

            return f;
        }

        public IActionResult Index()
        {
            messages();
            messagesList("Mesaj Listesi");
            user("Alican");
            ViewBag.t = Topla(20, 35);
            return View();
        }

        public IActionResult Products()
        {
            messages();
            ViewBag.t = topla();
            ViewBag.c = environment();
            user("Alican");
            ViewBag.factor = factorial(6);
            return View();
        }

        public IActionResult Customers()
        {
            ViewBag.s = sentence();
            user("Alican");
            return View();
        }

        public IActionResult Deneme()
        {
            Cities city = new Cities();
            Flag flag = new Flag();

            city.Id = 1;
            city.Name = "İstanbul";
            city.Population = 15000000;
            city.Country = "Türkiye";
            city.Color1 = "Red";
            city.Color2 = "White";

            ViewBag.Id = city.Id;
            ViewBag.Name = city.Name;
            ViewBag.Population = city.Population;
            ViewBag.Country = city.Country;
            ViewBag.Color1 = city.Color1;
            ViewBag.Color2 = city.Color2;

            city.Id = 2;
            city.Name = "Kiev";
            city.Population = 3000000;
            city.Country = "Ukrayna";
            city.Color1 = "Blue";
            city.Color2 = "Yellow";

            ViewBag.Id2 = city.Id;
            ViewBag.Name2 = city.Name;
            ViewBag.Population2 = city.Population;
            ViewBag.Country2 = city.Country;
            ViewBag.Color3 = city.Color1;
            ViewBag.Color4 = city.Color2;

            return View();
        }
    }
}
