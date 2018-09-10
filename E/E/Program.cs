using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E
{
    class Program
    {
        static void Main(string[] args)
        {
            string prompt = ">";    //prompt for when user input is required
            string user_input;
            string sentence = "";
            while (true)
            {
                //wait until non-empty string is passed
                while (true)
                {
                    Console.WriteLine("Type a word! Type \"AVSLUTA\" to stop");
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

                if (user_input.ToLower() == "avsluta")
                {
                    break;
                }
                sentence += " " + user_input.Trim();
                
            }

            Console.WriteLine("Your sentence is now:{0}.",sentence);
            Console.WriteLine("Press any key to continue. . .");
            Console.ReadKey();

        }
    }
}
