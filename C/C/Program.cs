using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

public class Words
{
    public string Word {get; set; }
    public int Count {get; set;}
}



namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            string prompt = ">";    // prompt for when user input is required
            string user_input;
            // wait until non-empty string is passed
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

            var words_list = new List<Words>();

            foreach(Match match in regex_matches)
            {
                new Words() { }
            }




            for (int i = 0; i < index; i++)
            {
                Console.WriteLine("{0} ({1})", word_array[i], word_count_array[i]);
            }
            Console.WriteLine("Press any key to continue. . .");
            Console.ReadKey();
        }
    }
}
