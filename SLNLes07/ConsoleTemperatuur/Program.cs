using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTemperatuur
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geef je graad in");
            double graad = double.Parse(Console.ReadLine());
            Console.WriteLine("selecteer je keuze \n a: celsius - Farenheit \n b: Fahrenheit - Celsius \n c: Celsius naar Kelvin \n d: Kelvin naar Celsius \n x:  Afsluiten");
            string invoer = Console.ReadLine();

            switch (invoer)
            {
                case "a":
                    Console.WriteLine($" dat is: {CNaarF(graad)} Fahrenheit");
                    break;
                case "b":
                    Console.WriteLine($" dat is: {FNaarC(graad)} Celsius");
                    break;
                case "c":
                    Console.WriteLine($" dat is: {CNaarK(graad)} Kelvin");
                    break;
                case "d":
                    Console.WriteLine($" dat is: {KNaarC(graad)} Celsius");
                    break;
                case "x":
                    Exit();
                    break;
            }
        }

        static public double FNaarC(double graad) 
        {
            return graad / 1.8 - 32;
        }
        static public double CNaarF(double graad)
        {
            return graad * 1.8 + 32;
        }
        static public double CNaarK(double graad)
        {
            return graad + 273.15;
        }
        static public double KNaarC(double graad)
        {
            return graad - 273.15;
        }
        static public void Exit()
        {
            Environment.Exit(0);
        }


    }

}
