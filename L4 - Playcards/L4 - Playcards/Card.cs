namespace L4___Playcards
{
    public class Card(Suit suit, Number number)
    {
        public Suit CardSuit { get; } = suit;
        public Number CardNumber { get; } = number;

        public override string ToString()
        {
            return $"{CardSuit} {CardNumber}";
        }
    }

    public delegate bool FilterCardDelegate(Card card);

    public enum Suit { Hearts, Diamonds, Clubs, Spades }
    public enum Number { Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King }
}
