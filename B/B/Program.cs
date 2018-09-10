using System;
using System.Text.RegularExpressions;
namespace B
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

            // add all words to an array
            string[] word_array = new string[regex_matches.Count];
            int index = 0;
            foreach (Match word in regex_matches)
            {
                word_array[index++] = word.ToString();
            }

            //sort by word lenght. shortest first
            Array.Sort(word_array, (x, y) => x.Length.CompareTo(y.Length) );

            Console.WriteLine("\nShortest First:");
            for (int i = word_array.GetLowerBound(0); i <= word_array.GetUpperBound(0); i++)
            {
                Console.WriteLine(word_array[i]);
            }

            Console.WriteLine("\nLongest First:");
            for (int i = word_array.GetUpperBound(0); i >= word_array.GetLowerBound(0); i--)
            {
                Console.WriteLine(word_array[i]);
            }


            Console.WriteLine("Press any key to continue. . .");
            Console.ReadKey();
        }
    }
}
