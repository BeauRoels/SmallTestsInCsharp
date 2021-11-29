using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("wat is je naam");
            string name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("welkom " + name);
            Console.ReadKey();
        }
    }
}
