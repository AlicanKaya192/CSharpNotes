using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoşulİfadeleriAlıştırma5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * 
             * Kullanıcı Kodu:
             * 
             * Kullanıcı Kodu = AA - BB - CC
             *      Admin yetkisine sahipsiniz
             * Kullanıcı Kodu = DD
             *      Güçlü kullanıcı yetkisine sahipsiniz
             * Kullanıcı kodu = FF - EE - GG
             *      Standart kullanıcı yetkisine sahipsiniz
             *
             * Farklı bir giriş olursa : Hatalı Kullanıcı kodu
             * 
             */

            Console.Write("Kullanıcı Kodunuz: ");
            string kullanıcıKodu = Console.ReadLine();


            switch(kullanıcıKodu)
            {
                case "AA":
                    case "BB":
                        case "CC":
                    Console.WriteLine("Admin Yetkisine Sahipsiniz");
                    break;

                case "DD":
                    Console.WriteLine("GÜçlü Kullanıcı Yetkisine Sahipsiniz");
                    break;
                case "FF":
                    case "EE":
                        case "GG":
                    Console.WriteLine("Standart Kullanıcı Yetkisine Sahipsiniz");
                    break;

                default:
                    Console.WriteLine("Hatalı Kullanıcı Kodu");
                    break;




            }





        }
    }
}
