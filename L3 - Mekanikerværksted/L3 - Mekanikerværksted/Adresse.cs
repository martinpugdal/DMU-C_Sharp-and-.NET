namespace L3___Mekanikerværksted
{
    public class Adresse(string vejnavn, string nummer, string postnummer, string by)
    {
        public string Vejnavn { get => vejnavn; set => vejnavn = value; }
        public string Nummer { get => nummer; set => nummer = value; }
        public string Postnummer { get => postnummer; set => postnummer = value; }
        public string By { get => by; set => by = value; }

        public override string ToString()
        {
            return String.Format("{0} {1}, {2} {3}", Vejnavn, Nummer, Postnummer, By);
        }

        public override int GetHashCode()
        {
            return Vejnavn.GetHashCode() ^ Nummer.GetHashCode() ^ Postnummer.GetHashCode() ^ By.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Adresse a = (Adresse)obj;
            return this.GetHashCode() == a.GetHashCode();
        }
    }
}
