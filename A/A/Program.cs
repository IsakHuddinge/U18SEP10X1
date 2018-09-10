using System;
using System.Text.RegularExpressions;

namespace A
{
    class Program
    {
        static void Main(string[] args)
        {
            string prompt = ">";    //prompt for when user input is required
            string user_input;
            //wait until non-empty string is passed
            while (true)
            {
                Console.WriteLine("Write a sentence!");
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

            Regex regex_match_words = new Regex(@"\w+");
            // find all words in user_input
            MatchCollection regex_matches = regex_match_words.Matches(user_input);

            Console.WriteLine("There are {0} words in \"{1}\"!", regex_matches.Count , user_input);
            Console.WriteLine("Words:");
            foreach (Match word in regex_matches)
            {
                Console.WriteLine("{0} ({1})", word, word.Length);
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
