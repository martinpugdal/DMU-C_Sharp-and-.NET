
namespace DelegateExercises {

    public class Person {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public delegate string FormatPersonName(string firstname, string lastname);

        public void printPersonName(FormatPersonName format)
        {
            System.Console.WriteLine(format(FirstName, LastName));
        }

        public void PrintFullNameLastNameFirst() {
            Console.WriteLine($"{LastName}, {FirstName}");
        }

        public void PrintFullNameAllCaps() {
            Console.WriteLine($"{LastName.ToUpper()}, {FirstName.ToUpper()}");
        }

        public void PrintFullNameLowerCase() {
            Console.WriteLine($"{LastName.ToLower()}, {FirstName.ToLower()}");
        }

        public void PrintShortName() {
            Console.WriteLine($"{FirstName.Substring(0, 1)}. {LastName}");
        }

        public static List<Person> CreateListOfPeople() {
            return new List<Person>()
            {
                new Person() { FirstName = "Stephen", LastName = "King" },
                new Person() { FirstName = "George", LastName = "Martin" },
                new Person() { FirstName = "Ernest", LastName = "Hemingway" },
                new Person() { FirstName = "William", LastName = "Shakespeare" }
            };
        }
    }
}
