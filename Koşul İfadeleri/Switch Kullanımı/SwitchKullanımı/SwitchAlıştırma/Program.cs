using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchAlıştırma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Değer Giriniz: ");
            string aylar = Console.ReadLine();

            switch(aylar)
            {
                case "Ocak":
                    Console.WriteLine("Ocak ayı");
                    break;
                case "Şubat":
                case "Mart":
                    Console.Write("{0}, {1}, {2}");
                    break;
                    default:
                    break;
            }
        }
    }
}
