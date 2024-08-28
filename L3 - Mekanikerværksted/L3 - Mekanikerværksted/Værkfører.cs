
namespace L3___Mekanikerværksted
{
    public class Værkfører(CprNr cprNr, string navn, Adresse adresse, int udnævnelse, double timeløn, double tillægPrUge) : Mekaniker(cprNr, navn, adresse, udnævnelse, timeløn)
    {
        public double TillægPrUge { get; set; } = tillægPrUge;

        override public double BeregnUgeLøn()
        {
            return Timeløn * TimerPrUge + TillægPrUge;
        }

    }
}
