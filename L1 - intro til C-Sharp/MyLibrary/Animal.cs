namespace MyLibrary
{

    public class Animal(string name) : IAnimal
    {
        public string Name { get; set; }

        public bool IsDog()
        {
            return name.ToLower().Equals("dog") ||
                name.ToLower().Equals("hund");
        }

        public override string ToString()
        {
            return name;
        }
    }
}
