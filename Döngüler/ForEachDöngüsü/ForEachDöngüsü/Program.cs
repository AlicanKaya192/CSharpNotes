using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachDöngüsü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Isımler = new[] { "Alican Kaya", "Tuğçe Kaya", "Aysel Kaya", "Serap Kaya"};

            foreach (string item in Isımler) 
            {
                Console.WriteLine(item);
            }


        }
    }
}
