using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRaden
{
    class Program
    {
        static void Main(string[] args)
        {
            int rG;
            Random rnd = new Random();
            rG = rnd.Next(1, 10);
          
            Console.WriteLine("raad een getal tussen 1 en 10");
            
            int gok;
            int poging;




            for (poging = 1; poging <= 3; poging++)
            {
                gok = int.Parse(Console.ReadLine());
                if (gok ==  rG)
                {
                    Console.WriteLine("goed geraden getal was " + rG);
                    break;
                }
             
            }
            if(poging == 4)
            {
                Console.WriteLine("volgende keer beter");

            }

            Console.ReadKey();
        }
    }
}
