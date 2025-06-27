using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İçİçeForDöngüsüAlıştırma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  1*1 = 1
             *  1*2 = 2
             *  
             *  Çarpım Tablosu
             */ 

            for ( int i = 1; i <= 9; i++ )
            {
               for( int j = 1; j <= 9; j++ )
                {
                    int carpma = i * j;
                    Console.WriteLine("{0} * {1} = {2}", i, j, carpma);
                }
                Console.WriteLine("------------------------");
            }
        }
    }
}
