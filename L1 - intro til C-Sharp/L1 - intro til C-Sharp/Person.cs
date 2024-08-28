namespace L1___intro_til_C_
{
    internal class Person
    {
        private string name;

        public Person(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
