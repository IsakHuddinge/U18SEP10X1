using System;

namespace F
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt for when user input is required
            string prompt = ">";
            int user_guess = 0;
            while (true)
            {
                //wait until valid int is passed
                while (true)
                {
                    Console.WriteLine("Guess a number between 1-21!");
                    Console.Write(prompt);
                    string user_input = Console.ReadLine();

                    if (Int32.TryParse(user_input, out user_guess))
                    {
                        if (user_guess >= 1 && user_guess <= 21)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please type a number between 1-21!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please type a number!");
                    }
                }
                //generate random number between 1-21
                //funny that we generate it after the user guesses it
                Random rand = new Random();
                int random_number = rand.Next(21) + 1;

                if (user_guess == random_number)
                {
                    Console.WriteLine("You guessed correctly!");
                    break;
                }
                else
                {
                    Console.WriteLine("You guessed incorrectly! The Correct number was {0}", random_number);

                }
            }
            Console.WriteLine("Press any key to continue. . .");
            Console.ReadKey();
        }
    }
}
