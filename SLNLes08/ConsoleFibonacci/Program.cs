using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hoeveel fibonacci getallen wilt u?");
            int amount = int.Parse(Console.ReadLine());

            foreach (var item in FirstTenFibonacci(amount))
            {
                Console.WriteLine($"{item} ");
            }
            Console.ReadKey();

        }
        static public int[] FirstTenFibonacci(int amount)
        {
            int[] firstTenFiboArray = new int[amount];
            for (int i = 0; i < amount; i++)
            {
                firstTenFiboArray[i] += CalculateFibonacci(i, i - 1);
            }
            return firstTenFiboArray;
        }
        static public int CalculateFibonacci(int previousNumber, int number)
        {
           return previousNumber + number;
        }
    }
}
