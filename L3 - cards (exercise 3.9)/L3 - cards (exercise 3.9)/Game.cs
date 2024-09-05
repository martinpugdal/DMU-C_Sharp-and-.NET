namespace L3___cards__exercise_3._9_
{
    public class Game
    {
        private Dictionary<Player, double> currentPot = new();
        private List<Player> players = new();
        private readonly CardDeck cardDeck = new();

        public double CurrentPot { get; set; }
        public CardDeck CardDeck { get { return cardDeck; } }

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public void RemovePlayer(Player player)
        {
            players.Remove(player);
        }

        public void InsertIntoPot(Player player, double amount)
        {
            if (!players.Contains(player))
                throw new Exception("Du ikke med i spillet");
            if (player.Money > amount)
                throw new Exception("Du har ikke penge nok");
            if (amount <= 0)
                throw new Exception("Du kan ikke indsætte >= 0");

            if (!currentPot.TryAdd(player, amount))
            {
                currentPot[player] += amount;
                player.Money -= amount;
            }
        }

        public void GivePotMoneyTo(Player player)
        {
            double potTotal = currentPot.Values.Sum();
            player.Money += potTotal;
        }
    }
}
