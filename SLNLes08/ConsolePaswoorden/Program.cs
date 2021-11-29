using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePaswoorden
{
    class Program
    {
        public static string input = "";
        public static int i = 0;
        public static List<string> listOkPasswords = new List<string>();
        public static List<string> listNotOkPasswords = new List<string>();
        public static string[] toBeCheckPasswords = {"klepketoe","test","Azerty123","rogier@work","paswoord", "MisterNasty12","pwnz0red" };
        static void Main(string[] args)
        {
           // Console.WriteLine("geef je wachtwoord om te checken");
           //input = Console.ReadLine();

            foreach (var item in toBeCheckPasswords)
            {
                
                input = toBeCheckPasswords[i];

                if (IsOk(input) == true)
                {
                    listOkPasswords.Add(input);
                }
                else
                {
                    listNotOkPasswords.Add(input);
                }

                Console.WriteLine($"{i+1}: {item}");
                i++;
            }
            Console.Write("ok: ");
            foreach (var item in listOkPasswords)
            {
                Console.Write($" {item}");
            }
            Console.WriteLine();
            Console.Write("niet ok: ");
            foreach (var item in listNotOkPasswords)
            {
                Console.Write($" {item}");
            }
            Console.ReadKey();

        

        }
        static public bool CheckMinLength(string input)
        {
            return input.Length >= 9;
        }
        static public bool CheckContainsAt(string input)
        {
            return !input.Contains("@");
        }
        static public bool CheckEqualsPassword(string input)
        {
            return !input.Equals("password");
        }
        static public bool IsOk(string input)
        {
            return CheckMinLength(input) == true && CheckContainsAt(input) == true && CheckEqualsPassword(input) == true;
        }
    }
}
