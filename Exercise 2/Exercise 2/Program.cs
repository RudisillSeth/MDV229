using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "Folgers";
            string guess = null;
            int guessCheck = 0;
            int numOfGuesses = 0;
            bool run = true;
            bool go = true;

            string[] hints = new string[] { "This is a popular drink brand.", "This drink gives you energy.", "This is a popular coffee brand.", "This brand can be found in just about every home.", "This brand is 'in your cup'.", "This brand has a red container.",
                "This brand has a sunrise over mountains for a logo.", "This is an Amercian coffee.", "This brand rymes with boulder.", "This brand starts with 'F'." };

            // This lets the player know they have 10 guesses and the answer has to begin with a capital letter.
            Console.Write("Let's play a game. A quick note, your answer needs to start with a capital letter." +
                "\nCan you guess the brand within 10 guesses?");

            // This sets up the loop for the game
            while (go)
            {
                run = true;
                // This shows the hint for the player.
                Console.Write($"\nYour hint is: {hints[numOfGuesses]} ");
                guess = Console.ReadLine();

                // This sets up the loop for checking the guess from the player.
                while (run)
                {
                    // This checks if the guess is a number, white space, or null.
                    if (int.TryParse(guess, out guessCheck) || string.IsNullOrWhiteSpace(guess))
                    {
                        Console.Write("\nInvalid input, please make a guess. ");
                        guess = Console.ReadLine();
                    }
                    // This uses the CheckUpper method to make sure the guess starts with a capital.
                    else if (!CheckUpper(guess))
                    {
                        Console.Write("\nYour answer did not begin with a capital, please make a guess. ");
                        guess = Console.ReadLine();
                    }
                    // If all checks pass, this will turn off the loop.
                    else
                    {
                        run = false;
                    }
                }

                // This checks if the guess matches the answer.
                if (guess == answer)
                {
                    go = false;
                    Console.WriteLine("Congrats! you guessed correctly!");
                }
                // This checks the number of guesses left, if all 10 are used, the game ends and displays the answer.
                else if (numOfGuesses == hints.Count())
                {
                    go = false;
                    Console.WriteLine($"Sorry out of guesses, the answer was {answer}");
                }
                // If the player still has guesses left but gave a wrong guess, this has them try again.
                else
                {
                    Console.Write($"Oooh wrong answer, try again.");
                }

                numOfGuesses++;
            }
        }
        
        // This takes the guess, breaks it apart, and checks if the first letter is capital or not.
        static bool CheckUpper(string value)
        {
            char[] charArray = value.ToCharArray();

            if (char.IsUpper(charArray[0]) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
