using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    class Player
    {
        private string _name = null;
        private List<string> _hand = new List<string> { };
        private int _totalScore = 0;


        public Player(string name, List<string> hand)
        {
            _name = name;
            _hand = hand;
        }

        public List<string> Hand
        {
            get { return _hand; }
        }

        public string Name
        {
            get { return _name; }
        }

        //this finds the total score of the players hand
        public int TotalScore()
        {
            for (int i = 0; i < _hand.Count(); i++)
            {
                _totalScore += Utility.Points(_hand[i]);
            }
            return _totalScore;
        }
    }
}
