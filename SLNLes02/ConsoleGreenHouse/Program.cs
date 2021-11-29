using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGreenHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** WELKOM BIJ GREENHOUSE RESTAURANT ****");
            Console.WriteLine("==========================================");

            Console.WriteLine("Kies een grootste(kleine of grote): ");
            string size = Console.ReadLine();

            Console.WriteLine("Kies een basis(quinoa, rijst of salade): ");
            string side = Console.ReadLine();

            Console.WriteLine("Kies een soort (vegan, zalm of kip): ");
            string type = Console.ReadLine();


            Console.WriteLine("je bestelling: " + size + " " + side + " " + type + " ");


        }
    }
}
