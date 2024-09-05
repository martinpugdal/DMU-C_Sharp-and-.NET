namespace L4___Person__4._6_
{
    public class Person(int age, double weight, string name)
    {
        public int Age { get; set; } = age;
        public double Weight { get; set; } = weight;
        public string Name { get; set; } = name;

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight} kg";
        }
    }

    public class ByAgeSorter : IComparer<Person>
    {
        public int Compare(Person? x, Person? y)
        {
            return x?.Age.CompareTo(y?.Age) ?? 0;
        }
    }
    public class ByWeightSorter : IComparer<Person>
    {
        public int Compare(Person? x, Person? y)
        {
            return x?.Weight.CompareTo(y?.Weight) ?? 0;
        }
    }
    public class ByNameSorter : IComparer<Person>
    {
        public int Compare(Person? x, Person? y)
        {
            return x?.Name.CompareTo(y?.Name) ?? 0;
        }
    }
}
