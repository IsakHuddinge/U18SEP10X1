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
            
            Dictionary<char, string> translate_leet = new Dictionary<char, string>();
            translate_leet.Add('a', "4");
            translate_leet.Add('b', "8");
            translate_leet.Add('c', "<");
            translate_leet.Add('d', "|>");
            translate_leet.Add('e', "3");
            translate_leet.Add('f', "|=");
            translate_leet.Add('g', "6");
            translate_leet.Add('h', "]-[");
            translate_leet.Add('i', "|");
            translate_leet.Add('j', "_|");
            translate_leet.Add('k', "|<");
            translate_leet.Add('l', "1");
            translate_leet.Add('m', "/\\\\");
            translate_leet.Add('n', "|\\|");
            translate_leet.Add('o', "0");
            translate_leet.Add('p', "|2");
            translate_leet.Add('q', "(.)");
            translate_leet.Add('r', "|z");
            translate_leet.Add('s', "5");
            translate_leet.Add('t', "7");
            translate_leet.Add('u', "|_|");
            translate_leet.Add('v', "|/");
            translate_leet.Add('w', "//");
            translate_leet.Add('x', "><");
            translate_leet.Add('y', "'/");
            translate_leet.Add('z', "(\\)");

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
