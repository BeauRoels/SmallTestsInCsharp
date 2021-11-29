using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLancering
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("hoeveel seconden tot lancering");
            int keuze = Int32.Parse(Console.ReadLine());
            for (int i = keuze; i >= 1; i--)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine("de nucleare lancering gaat van start op amerika");
            Console.ReadKey();
        }
      
    }
}
