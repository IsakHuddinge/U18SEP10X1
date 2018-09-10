using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

public class Unique_word
{
    public String Word  { get; set; }
    public int Count { get; set; }
}

namespace D
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt for when user input is required
            string prompt = ">";
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

            var word_list = new List<Unique_word> { };

            //add all words to list. if word exist's it adds 1 to counter
            foreach (Match word in regex_matches)
            {
                string word_string = word.ToString();
                if (word_list.Exists(x => x.Word == word_string))
                {
                    var index = word_list.FindIndex(x => x.Word == word_string);
                    word_list[index].Count += 1;
                }
                else
                {
                    word_list.Add(new Unique_word { Word = word_string, Count = 1 });
                }
            }
            //create new list with sorted order;
            List<Unique_word> sorted_word_list= word_list.OrderByDescending(word => word.Count).ToList();

            Console.WriteLine("Unique words sorted by occurence : ");
            foreach (Unique_word word in sorted_word_list)
            {
                Console.WriteLine("{0} ({1})", word.Word, word.Count);
            }

            Console.WriteLine("Press any key to continue. . .");
            Console.ReadKey();
        }
    }
}