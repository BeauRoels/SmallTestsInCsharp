using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGGD
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal1, getal2, ggd=0;
            Console.WriteLine("geef getal 1:");
            getal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("geef getal 2:");
            getal2 = int.Parse(Console.ReadLine());

            while (getal1 != getal2)
            {
                if(getal1 > getal2)
                {
                    getal1 -= getal2;
                }
                else
                {
                    getal2 -= getal1;
                }
            }
            Console.WriteLine("de ggd is " + getal1);
        }
    }
}
