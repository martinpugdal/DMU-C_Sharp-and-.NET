namespace L3___Mekanikerværksted
{
    public class Synsmand(CprNr cprNr, string navn, Adresse adresse, int udnævnelse, int syn) : Mekaniker(cprNr, navn, adresse, udnævnelse, 0)
    {
        public double Syn { get; set; } = syn;

        override public double BeregnUgeLøn()
        {
            return syn * 290;
        }
    }
}
