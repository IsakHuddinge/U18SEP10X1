using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt for when user input is required
            string prompt = ">";
            string user_input = "";
            //wait until non-empty string is passed
            while (true)
            {
                Console.WriteLine("Write a sentence to translate to leet!");
                Console.Write(prompt);
                user_input = Console.ReadLine();

                if (user_input == "")
                {
                    Console.WriteLine("Don't leave it blank!");
                }
                else
                {
                    break;
                }
            }

            Dictionary<char, string> translate_leet = new Dictionary<char, string>
            {
                { 'a', "4" },
                { 'b', "8" },
                { 'c', "<" },
                { 'd', "|>" },
                { 'e', "3" },
                { 'f', "|=" },
                { 'g', "6" },
                { 'h', "]-[" },
                { 'i', "|" },
                { 'j', "_|" },
                { 'k', "|<" },
                { 'l', "1" },
                { 'm', "/\\\\" },
                { 'n', "|\\|" },
                { 'o', "0" },
                { 'p', "|2" },
                { 'q', "(.)" },
                { 'r', "|z" },
                { 's', "5" },
                { 't', "7" },
                { 'u', "|_|" },
                { 'v', "|/" },
                { 'w', "//" },
                { 'x', "><" },
                { 'y', "'/" },
                { 'z', "(\\)" }
            };

            string leet = "";
            foreach (char character in user_input)
            {
                //checks if character is within range of a-Z and can be translated
                if ((character >= 'a' && character <= 'z') || (character >= 'A' && character <= 'Z'))
                {
                    leet += translate_leet[char.ToLower(character)];
                }
                else
                {
                    leet += character.ToString();
                }

            }
            Console.WriteLine("Your sentence translated to leet:");
            Console.WriteLine(leet);
            Console.WriteLine("Press any key to continue. . .");
            Console.ReadKey();
        }
    }
}
