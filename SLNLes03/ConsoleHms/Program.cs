using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geef het aantal seconden");
            int aantalSeconden = Int32.Parse(Console.ReadLine());
            int uur = aantalSeconden / 3600,
                minute = (aantalSeconden%3600)/60,
                second = aantalSeconden%60;
            

            Console.WriteLine($"Omgezet in HMS {uur}:{minute}:{second}");
            Console.ReadKey();


        }
    }
}
