namespace L3___Mekanikerværksted
{
    abstract public class Medarbejder(CprNr cprNr, string navn, Adresse adresse) : IHarAdresse
    {
        private static int MEDARBEJDER_ID = 0;

        private readonly int medarbejderId = ++MEDARBEJDER_ID;

        public int MedarbejderId => medarbejderId;
        public CprNr CprNr { get; } = cprNr;
        public string Navn { get => navn; set => navn = value; }
        public Adresse Adresse { get => adresse; set => adresse = value; }

        private const int _timerPrUge = 37; //konstant, dvs. kan ikke ændres, og er ens for alle objekter af klassen
        abstract public double BeregnUgeLøn(); //abstrakt metode, dvs. skal overskrives i subklasser
        public int TimerPrUge => _timerPrUge; //og den tilhørende access metode, bemærk readOnly, dvs get!

        public override string ToString()
        {
            return String.Format("{0} - {1,-8} - {2} - {3}", MedarbejderId, Navn, CprNr, Adresse);
        }
    }
}
