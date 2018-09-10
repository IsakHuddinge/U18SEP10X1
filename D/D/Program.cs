using System;
using System.Collections.Generic;

public class Unique_character
{
    public char Character { get; set; }
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

            var character_list = new List<Unique_character> { };
            
            foreach (char character in user_input)
            {
                if(character_list.Exists(x => x.Character == character))
                {
                    var index = character_list.FindIndex(x=> x.Character == character);
                    character_list[index].Count += 1;
                }
                else
                {
                    character_list.Add(new Unique_character { Character = character, Count = 1 });
                }
            }

            Console.WriteLine("Unique characters: ");
            foreach (Unique_character character in character_list)
            {
                Console.WriteLine("{0} ({1})", character.Character, character.Count);
            }

            Console.WriteLine("Press any key to continue. . .");
            Console.ReadKey();
        }
    }
}
