using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Kisiler
    {
        public void kisilistesi(string ad)
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + " " + ad);
            }
        }
    }
}
