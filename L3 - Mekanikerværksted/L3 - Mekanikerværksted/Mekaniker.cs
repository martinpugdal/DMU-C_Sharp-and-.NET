namespace L3___Mekanikerværksted
{
    public class Mekaniker(CprNr cprNr, string navn, Adresse adresse, int svendeprøveÅr, double timeløn) : Medarbejder(cprNr, navn, adresse)
    {
        public int SvendeprøveÅr { get; set; } = svendeprøveÅr;
        public double Timeløn { get; set; } = timeløn;

        public override double BeregnUgeLøn()
        {
            return Timeløn * TimerPrUge;
        }
    }
}
