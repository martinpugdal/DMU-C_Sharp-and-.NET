using System;
using System.Collections.Generic;
using static L4___Playcards.Card;

namespace L4___Playcards
{
    public class CardGame
    {
        private List<Card> cards = new();

        public void AddCard(Suit suit, Number number)
        {
            cards.Add(new Card(suit, number));
        }

        public List<Card> GetCards() { return cards; }  

        public List<Card> FilterCardGame(FilterCardDelegate filter)
        {
            cards = cards.FindAll(card => filter(card));
            return cards;
        }
    }
}
