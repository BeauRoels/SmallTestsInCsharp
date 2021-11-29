using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTafels
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal, lengte;

            Console.WriteLine("geef een getal");
            getal = int.Parse(Console.ReadLine());

            Console.WriteLine("geef een lengte");
            lengte = int.Parse(Console.ReadLine());

            Console.WriteLine(DrukTafel(getal, lengte));

            Console.ReadKey();


        }

        static private string DrukTafel(int getal, int lengte)
        {
            string uitvoer = " ";
            for (int i = 1; i <= lengte; i++)
            {
                uitvoer +=($"{getal} X {i} = {getal*i} \n");
            }
            return uitvoer;
        }
    }
}
