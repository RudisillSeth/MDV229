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
                    string newCard = Utility.OneLength(card);
                    currentDeck.Add(newCard);
                }
            }

            Console.Clear();
            Console.WriteLine("Welcome to this simple little game of luck. Add in 4 players and, using a standard deck, the computer will shuffle and \ndeal out cards to every player." +
                " Each card has a value. The number cards have a value equal to their number. \nFace cards are worth 12 points, and aces are 15. Whoever has the most points wins.");
            Console.WriteLine("\nBefore we play, we need to name who is playing.");

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

                input = $"player {z}: {input}";

                List<string> hand = new List<string> { };
                Player player = new Player(input, hand);
                players.Add(player);
                z++;
            }
            Console.Clear();
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

            Console.WriteLine("All done, let's see who won. Press any key to continue.");
            Console.ReadKey();
            Console.Clear();

            int deckScore = 0;

            //this displays the players, their cards, and the total score 
            Console.WriteLine($"  {players[0].Name}      {players[1].Name}     {players[2].Name}     {players[3].Name}" +
                $"\n+-------------------+-------------------+-------------------+-------------------+");
            Utility.ShowHand(players[0].Hand, players[1].Hand, players[2].Hand, players[3].Hand);
            Console.WriteLine("+-------------------+-------------------+-------------------+-------------------+");
            Console.Write($"| Total Score: {players[0].TotalScore()}  | Total Score: {players[1].TotalScore()}  | Total Score: {players[2].TotalScore()}  | Total Score: {players[3].TotalScore()}  |" +
                $"\n+-------------------+-------------------+-------------------+-------------------+\n");
            for (int i = 0; i < 4; i++)
            {
                deckScore += players[i].TotalScore();
            }
            Console.WriteLine($" Total deck score : {deckScore / 2}");
            Console.ReadKey();
        }
    }
}
