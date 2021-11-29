using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSom
{
    class Program
    {
        static void Main(string[] args)
        {
            String invoer = "";
            do
            {
                Console.WriteLine("Voer een getal in (q om te stoppen ");
                invoer = Console.ReadLine();
            } while (invoer != "q");
        }
    }
}
