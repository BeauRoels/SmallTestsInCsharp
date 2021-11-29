using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBankautomaat
{
    class Program
    {
        static public double bedrag;
        static public double saldo = 0;
        static public int pincode = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("bankautomaat");
            Console.WriteLine("==================================");
            Console.WriteLine("a: afhaling \n b: storting \n c: stoppen");

            string invoer = Console.ReadLine();

           
            switch(invoer)
            {
                case "a":
                    Console.WriteLine("afhaling");
                    Afhaling();
                    break;
                case "b":
                    Console.WriteLine("storting");
                    Storting();
                    break;
                case "c":
                    Console.WriteLine("stoppen");
                    Stoppen();
                    break;
            }

            Console.ReadKey();

        }
        static public void Afhaling()
        {
            Console.WriteLine("welk bedrag wil je afhalen");
            bedrag = Double.Parse(Console.ReadLine());
            double saldoCheck = saldo - bedrag;
            if (saldoCheck >0)
            {
                saldo -= bedrag;
            }
            else
            {
                Console.WriteLine(" je mag niet onder nul gaan!");
            }
        }
        static public void Storting()
        {
            Console.WriteLine("welk bedrag wil je storten");
            bedrag = Double.Parse(Console.ReadLine());
            saldo += bedrag;
        }
        static public void PincodeIngeven()
        {
            Console.WriteLine("geef je pincode");
            int ingegevenPincode = Int32.Parse(Console.ReadLine());

            if (ingegevenPincode == pincode)
            {
                Console.WriteLine("je bent ingelogd");
            }
            
        }
        static public void Stoppen()
        {
            
                Environment.Exit(0);

            
        }
    }
}
