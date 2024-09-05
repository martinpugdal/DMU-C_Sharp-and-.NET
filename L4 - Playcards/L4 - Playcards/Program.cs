using L4___Playcards;

static bool FilterByKlør(Card card)
{
    return card.CardSuit == Suit.Clubs;
}
static bool FilterByBilede(Card card)
{
    return card.CardNumber >= Number.Jack;
}
static bool FilterByNumber(Card card)
{
    return card.CardNumber <= Number.Ten;
}
// Prøv at lave dem som lambda expressions.
static bool FilterByHjerte(Card card) => card.CardSuit == Suit.Hearts;

CardGame game = new();
game.AddCard(Suit.Clubs, Number.Ace);
game.AddCard(Suit.Clubs, Number.Jack);
game.AddCard(Suit.Hearts, Number.Queen);
game.AddCard(Suit.Spades, Number.Ten);

var klørKort = game.FilterCardGame(FilterByKlør);
var billedKort = game.FilterCardGame(FilterByBilede);
var nummerKort = game.FilterCardGame(FilterByNumber);
var hjerteKort = game.FilterCardGame(FilterByHjerte);

Console.WriteLine("Klør kort:");
klørKort.ForEach(card => Console.WriteLine(card));

Console.WriteLine("\nBilled kort:");
billedKort.ForEach(card => Console.WriteLine(card));

Console.WriteLine("\nNummer kort:");
nummerKort.ForEach(card => Console.WriteLine(card));

Console.WriteLine("\nHjerte kort:");
hjerteKort.ForEach(card => Console.WriteLine(card));