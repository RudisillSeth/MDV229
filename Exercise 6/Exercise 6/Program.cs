using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values = new string[] { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };
            string[] suits = new string[] { "Spades", "Diamonds", "Hearts", "Clubs" };
            List<Player> players = new List<Player> { };
            List<string> currentDeck = new List<string> { };

            //This creates the deck of cards
            for (int i = 0; i < 4; i++)
            {
                for (int x = 0; x < 13; x++)
                {
                    string card = $"{values[x]} of {suits[i]}";
                    currentDeck.Add(card);
                }
            }

            Console.WriteLine("Before we play, we need to name who is playing.");

            int z = 1;
            //this asks for the names of the players and adds them to the players list
            while(z < 5)
            {
                Console.Write($"Who is player {z}? ");
                string input = Console.ReadLine();
                int inputCheck = 0;

                //this makes sure nothing or numbers are not entered
                while (string.IsNullOrWhiteSpace(input) || int.TryParse(input, out inputCheck))
                {
                    Console.Write("That's not a name, try again. ");
                    input = Console.ReadLine();
                }

                List<string> hand = new List<string> { };
                Player player = new Player(input, hand);
                players.Add(player);
                z++;
            }
            Console.WriteLine("Great, now I will shuffle and deal cards to everyone.");
            currentDeck = Utility.Shuffle(currentDeck);

            //this takes the deck after it is shuffled and deals them to the players until no cards are left
            for (int i = 0; i < 52; i++)
            {
                players[0].Hand.Add(currentDeck[i]);
                i++;
                players[1].Hand.Add(currentDeck[i]);
                i++;
                players[2].Hand.Add(currentDeck[i]);
                i++;
                players[3].Hand.Add(currentDeck[i]);
            }

            Console.WriteLine("All done, let's see who won." +
                "\n--------------------------------------");
            int deckScore = 0;

            //this displays the players, their cards, and the total score 
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"{players[i].Name}");
                Utility.ShowHand(players[i].Hand);
                Console.WriteLine($"Total Score: {players[i].TotalScore()}");
                Console.WriteLine("--------------------------------------");
                deckScore += players[i].TotalScore();
            }
            Console.WriteLine(deckScore / 2);
            Console.ReadKey();
        }
    }
}
