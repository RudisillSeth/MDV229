using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> options = new List<string> { "Rock", "Paper", "Scissor", "Lizard", "Spock" };
            int count = 0;
            int playerWins = 0;
            int computerWins = 0;
            int ties = 0;

            //this lets you know the rules and how many rounds there will be
            Console.Write("Let's play Rock, Paper, Scissor, Lizard, Spock.\n" +
                "\nHow to play" +
                "\n----------------------------------------------------------------------------------------" +
                "\nAll you have to do is choose one of the options, either type the number or the word." +
                "\nThe computer will choose one at random." +
                "\nAfter 10 rounds, the game will end and display the score, think you can win?" +
                "\nMight help if you know what beats what right? Here you go" +
                "\n----------------------------------------------------------------------------------------" +
                "\nRock crushes scissor and lizard." +
                "\nPaper covers rock and disproves spock." +
                "\nscissor cuts paper and kills lizard." +
                "\nSpock smashes scissor and vaporizes rock." +
                "\nLizard eats paper and poisons spock." +
                "\n----------------------------------------------------------------------------------------" +
                "\nthese will always be there in case you forget, good luck." +
                "\nPress any key to start." +
                "\n----------------------------------------------------------------------------------------" +
                "\n");
            Console.ReadKey();
            while (count != 10)
            {
                Console.Clear();
                //this shows what beats what and will be displayed all the time
                Console.Write("\nRock crushes scissor and lizard." +
                    "\nPaper covers rock and disproves spock." +
                    "\nscissor cuts paper and kills lizard." +
                    "\nSpock smashes scissor and vaporizes rock." +
                    "\nLizard eats paper and poisons spock." +
                    "\n------------------------------------------------");

                count++;

                //this give you all of your options
                Console.Write("\nWhich do you choose." +
                $"\n1. {options[0]}" +
                $"\n2. {options[1]}" +
                $"\n3. {options[2]}" +
                $"\n4. {options[3]}" +
                $"\n5. {options[4]}" +
                "\nSelection: ");
                string input = Console.ReadLine().ToLower();
                int inputCheck = 0;

                //this makes sure that one of the options was typed in or their respective numbers
                while (string.IsNullOrWhiteSpace(input) || (int.TryParse(input, out inputCheck) && (inputCheck < 1 || inputCheck > 5)))
                {
                    Console.Write("invalid selection, please try agian. ");
                    input = Console.ReadLine().ToLower();
                }

                //this makes a random number that the computer uses to make its choice
                int rNum = new Random().Next(1,6);
                Console.WriteLine($"\nComputer chose {options[rNum - 1]}");
                Console.WriteLine(rNum);

                //this takes the user's input and compares it the computer's to see who won
                switch (input)
                {
                    case "1":
                    case "rock":
                        {
                            if (rNum == 3 || rNum == 4)
                            {
                                Console.WriteLine("Congrats! You win!");
                                playerWins++;
                                Console.WriteLine("Press any key to continue.");
                                Console.ReadKey();

                            }
                            else if (rNum == 1)
                            {
                                Console.WriteLine("Wow, it's a tie.");
                                ties++;
                                Console.WriteLine("Press any key to continue.");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Sorry, you lost.");
                                computerWins++;
                                Console.WriteLine("Press any key to continue.");
                                Console.ReadKey();
                            }
                            Console.Clear();
                            break;
                        }
                    case "2":
                    case "paper":
                        {
                            if (rNum == 1 || rNum == 5)
                            {
                                Console.WriteLine("Congrats! You win!");
                                playerWins++;
                                Console.WriteLine("Press any key to continue.");
                                Console.ReadKey();

                            }
                            else if (rNum == 2)
                            {
                                Console.WriteLine("Wow, it's a tie.");
                                ties++;
                                Console.WriteLine("Press any key to continue.");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Sorry, you lost.");
                                computerWins++;
                                Console.WriteLine("Press any key to continue.");
                                Console.ReadKey();
                            }
                            Console.Clear();
                            break;
                        }
                    case "3":
                    case "scissor":
                        {
                            if (rNum == 2 || rNum == 4)
                            {
                                Console.WriteLine("Congrats! You win!");
                                playerWins++;
                                Console.WriteLine("Press any key to continue.");
                                Console.ReadKey();

                            }
                            else if (rNum == 3)
                            {
                                Console.WriteLine("Wow, it's a tie.");
                                ties++;
                                Console.WriteLine("Press any key to continue.");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Sorry, you lost.");
                                computerWins++;
                                Console.WriteLine("Press any key to continue.");
                                Console.ReadKey();
                            }
                            Console.Clear();
                            break;
                        }
                    case "4":
                    case "lizard":
                        {
                            if (rNum == 2 || rNum == 5)
                            {
                                Console.WriteLine("Congrats! You win!");
                                playerWins++;
                                Console.WriteLine("Press any key to continue.");
                                Console.ReadKey();

                            }
                            else if (rNum == 4)
                            {
                                Console.WriteLine("Wow, it's a tie.");
                                ties++;
                                Console.WriteLine("Press any key to continue.");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Sorry, you lost.");
                                computerWins++;
                                Console.WriteLine("Press any key to continue.");
                                Console.ReadKey();
                            }
                            Console.Clear();
                            break;
                        }
                    case "5":
                    case "spock":
                        {
                            if (rNum == 1 || rNum == 3)
                            {
                                Console.WriteLine("Congrats! You win!");
                                playerWins++;
                                Console.WriteLine("Press any key to continue.");
                                Console.ReadKey();

                            }
                            else if (rNum == 5)
                            {
                                Console.WriteLine("Wow, it's a tie.");
                                ties++;
                                Console.WriteLine("Press any key to continue.");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Sorry, you lost.");
                                computerWins++;
                                Console.WriteLine("Press any key to continue.");
                                Console.ReadKey();
                            }
                            Console.Clear();
                            break;
                        }
                }
            }
            Console.Clear();

            //this lets the player know the game is over and what the scores are
            Console.Write($"Game over, let's see who won." +
                $"\nPlayer wins: {playerWins}" +
                $"\nTies: {ties}" +
                $"\nComputer wins: {computerWins}" +
                $"\nPress any key to end.");
            Console.ReadKey();
        }
    }
}
