using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFaculteit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("geef een getal");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"de faculteit is: {Faculteit(n)}");
            Console.ReadKey();
        }
        static private int Faculteit(int n)
        {
            int fac = 0;
            for (int i = n-1; i > n; i--)
            {
                fac = n * i;
            }
           
            return fac;
        }
    }
}
