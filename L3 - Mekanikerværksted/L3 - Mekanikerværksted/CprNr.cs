namespace L3___Mekanikerværksted
{
    public class CprNr
    {
        private readonly string BirthDate;
        private readonly string SequenceNumber;

        public CprNr(string birthDate, string sequenceNumber)
        {
            this.BirthDate = birthDate;
            this.SequenceNumber = sequenceNumber;
        }

        public string GetBirthDate()
        {
            return this.BirthDate;
        }

        public string GetSequenceNumber()
        {
            return this.SequenceNumber;
        }

        public override string ToString()
        {
            return this.BirthDate + "-" + this.SequenceNumber;
        }

        public override bool Equals(object obj)
        {
            if (obj is CprNr other)
            {
                return this.GetHashCode() == other.GetHashCode();
            }
            return false;
        }

        public override int GetHashCode() {
            return this.BirthDate.GetHashCode() ^ this.SequenceNumber.GetHashCode();
        }
    }
}
