// Opret Person objekter
using L4___Person__4._6_;

List<Person> personList = [];
personList.Add(new(29, 70.5, "John Doe"));
personList.Add(new(34, 65.0, "Jane Smith"));
personList.Add(new(42, 80.0, "Michael Brown"));
personList.Add(new(25, 58.5, "Emily Davis"));
personList.Add(new(31, 72.0, "Chris Johnson"));

// Sorter Person objekterne efter alder
//personList.Sort(new ByAgeSorter());
personList.Sort((x,y) => x.Age.CompareTo(y.Age));
foreach (Person person in personList)
{
    Console.WriteLine(person);
}