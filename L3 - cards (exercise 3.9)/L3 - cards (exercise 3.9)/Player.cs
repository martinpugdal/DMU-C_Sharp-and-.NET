using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3___cards__exercise_3._9_
{
    public class Player(string name, double money)
    {
        private Card[] cards = new Card[2];

        public double Money { get; set; }

        public Card[] Cards { get; set; }
    }
}
