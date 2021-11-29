using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKarakter
{
    class Program
    {
        static void Main(string[] args)
        {
            char character;
            string invoer;
            Console.WriteLine("Geef een kleine letter: ");

            invoer = Console.ReadLine();
            character = Convert.ToChar(invoer);
            int characterInt = Convert.ToInt32(character);
            int characterHoofdletter = character - 32;
            int charactervorige = character - 1;
            int charactervolgende = character + 1;


            Console.WriteLine($"Het nummer is: {characterInt}");
            Console.WriteLine($"De hoofdletter is: {Convert.ToChar(characterHoofdletter)}");
            Console.WriteLine($"De vorige letter is: {Convert.ToChar(charactervorige)} ");
            Console.WriteLine($"De volgende letter is: {Convert.ToChar(charactervolgende)}");
            Console.ReadKey();



        }
    }
}
