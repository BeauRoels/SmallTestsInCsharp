using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBMI
{
    class Program
    {
        static void Main(string[] args)
            
        {
            string invoer;
            double bmi, lengte, gewicht;
            Console.WriteLine("BMI CALCULATOR \n ===============");

            Console.WriteLine("lengte in CM: ");
            invoer = Console.ReadLine();
            lengte = Double.Parse(invoer);

            Console.WriteLine("gewicht in kg: ");
            invoer = Console.ReadLine();
            gewicht = Double.Parse(invoer);

            bmi = (gewicht / (lengte * lengte))*10000;
            double bmirounded = Math.Round(bmi,1); 

            Console.WriteLine($"je bmi bedraagt: {bmirounded}");

            Console.ReadKey();

        }
    }
}
