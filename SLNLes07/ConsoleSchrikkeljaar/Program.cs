using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSchrikkeljaar
{
    class Program
    {
        static void Main(string[] args)
        {
            int jaar = 1;

            do {
                Console.WriteLine("geef een jaartal");
                jaar = int.Parse(Console.ReadLine());
                if (IsSchrikkeljaar(jaar) == true)
                {
                    Console.WriteLine($"{jaar} is een schrikkeljaar");
                }
                else
                {
                    Console.WriteLine($"{jaar} is geen schrikkeljaar");
                }
            } while (jaar >=0);
            


        }
        static public bool IsSchrikkeljaar(int jaar)
        {
            return (jaar % 4 == 0 && jaar % 100 != 0);
        }
    }
}
