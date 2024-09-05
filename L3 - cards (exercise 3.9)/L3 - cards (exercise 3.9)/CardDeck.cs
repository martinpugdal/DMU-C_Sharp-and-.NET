namespace L3___cards__exercise_3._9_
{
    public class CardDeck
    {

        private readonly Card[] cards = new Card[52];

        public CardDeck()
        {
            SetupCards();
        }

        void SetupCards()
        {
            int i = 0;
            foreach (var suit in Enum.GetValues<Suit>())
            {
                foreach (var number in Enum.GetValues<Number>())
                {
                    cards[i++] = new(suit, number);
                }
            }
        }
    }
}
