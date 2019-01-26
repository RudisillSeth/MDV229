using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    class Utility
    {
        // this takes the deck and shuffles it around
        public static List<string> Shuffle(List<string> deck)
        {
            List<string> currentDeck = deck;
            List<string> shuffledDeck = new List<string> { };

            while (currentDeck.Count > 0)
            {
                Random rNum = new Random();
                int num = rNum.Next(0, currentDeck.Count);

                shuffledDeck.Add(currentDeck[num]);
                currentDeck.RemoveAt(num);
            }
            return shuffledDeck;
        }

        //this looks at each card, then gives a point value to it
        public static int Points(string card)
        {
            if (card.Contains("Two"))
            {
                return 2;
            }
            else if (card.Contains("Three"))
            {
                return 3;
            }
            else if (card.Contains("Four"))
            {
                return 4;
            }
            else if (card.Contains("Five"))
            {
                return 5;
            }
            else if (card.Contains("Six"))
            {
                return 6;
            }
            else if (card.Contains("Seven"))
            {
                return 7;
            }
            else if (card.Contains("Eight"))
            {
                return 8;
            }
            else if (card.Contains("Nine"))
            {
                return 9;
            }
            else if (card.Contains("Ten"))
            {
                return 10;
            }
            else if (card.Contains("Jack"))
            {
                return 12;
            }
            else if (card.Contains("Queen"))
            {
                return 12;
            }
            else if (card.Contains("King"))
            {
                return 12;
            }
            else { return 15; }
        }

        //this shows the cards in the players hand
        public static void ShowHand(List<string> hand, List<string> hand2, List<string> hand3, List<string> hand4)
        {
            List<string> cards = hand;
            List<string> cards2 = hand2;
            List<string> cards3 = hand3;
            List<string> cards4 = hand4;

            for (int i = 0; i < cards.Count(); i++)
            {
                Console.WriteLine($"| {cards[i]} | {cards2[i]} | {cards3[i]} | {cards4[i]} |");
            }
        }

        // This takes the string for each card and makes the same length for display
        public static string OneLength(string card)
        {
            List<char> length = card.ToList<char>();

            for (int i = length.Count(); i < 17; i++)
            {
                length.Add(' ');
            }
            
            string finalCard = $"{length[0]}{length[1]}{length[2]}{length[3]}{length[4]}{length[5]}{length[6]}{length[7]}{length[8]}" +
                $"{length[9]}{length[10]}{length[11]}{length[12]}{length[13]}{length[14]}{length[15]}{length[16]}";
            return finalCard;
        }
    }
}
