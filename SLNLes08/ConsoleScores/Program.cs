using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScores
{
    class Program
    {
        public static double sum = 0.0;
        static public Random rnd = new Random();
        public static int[] testScores = new int[10];
        static void Main(string[] args)
        {
            Console.Write("Scores test: ");
            testScores = GenerateTestScores(testScores);
            foreach (var item in testScores)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine($" gemiddelde: {CalculateAvg(testScores)}");
            Console.WriteLine($" Min: {CalculateLowest(testScores)}");
            Console.WriteLine($" Max: {CalculateHighest(testScores)}");
            Console.ReadKey();
        }
        static public double CalculateAvg(int[] score)
        {
            
            for (int i = 0; i < score.Length; i++)
            {
                sum += score[i];
            }
            
            return sum/score.Length;
        }
        static public int[] GenerateTestScores(int[] testScores)
        {
            for (int i = 0; i < testScores.Length; i++)
            {
                testScores[i] = rnd.Next(1, 20);
            }
            return testScores;
        }
       
        static  public int CalculateLowest(int[] score)
        {
            int min = score[0];
            for (int i = 0; i < score.Length; i++)
            {
                int number = score[i];
                if (number < min)
                {
                    min = number;
                }
            }
            return min;
        }
        static public int CalculateHighest(int[] score)
        {
            int max = score[0];
            for (int i = 0; i < score.Length; i++)
            {
                int number = score[i];
                if (number > max)
                {
                    max = number;
                }
            }
            return max;
        }
    }
}
