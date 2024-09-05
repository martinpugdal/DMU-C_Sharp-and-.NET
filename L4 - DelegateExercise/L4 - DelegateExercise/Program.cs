using DelegateExercises;
using static DelegateExercises.Person;

var people = Person.CreateListOfPeople();
people.ForEach(p => p.PrintFullNameLastNameFirst());

void PrintPeople(FormatPersonName formatter)
{
    people.ForEach(p => p.printPersonName(formatter));
}

while (true)
{
    Console.WriteLine("----------------------------------------------------");
    Console.WriteLine("Hvordan vil du have udskrevet navnene?");
    Console.WriteLine("1: Efternavn efterfulgt af fornavn");
    Console.WriteLine("2: Efternavn efterfulgt af fornavn, store bogstaver");
    Console.WriteLine("3: Efternavn efterfulgt af fornavn, små bogstaver");
    Console.WriteLine("4: Kun forbogstav af fornavn efterfulgt af efternavn");
    Console.WriteLine();
    Console.WriteLine("q: For at afslutte!");
    Console.Write("> ");
    var input = Console.ReadLine();
    switch (input.ToUpper())
    {
        case "1":
            PrintPeople(FormatFullNameLastNameFirst);
            break;
        case "2":
            PrintPeople(FormatFullNameAllCaps);
            break;
        case "3":
            PrintPeople(FormatFullNameLowerCase);
            break;
        case "4":
            PrintPeople(FormatShortName);
            break;
        case "Q": return;
        default:
            Console.WriteLine("Ukendt valg, prøv igen");
            break;
    }
}

static string FormatFullNameLastNameFirst(string FirstName, string LastName)
{
    return $"{LastName}, {FirstName}";
}
static string FormatFullNameAllCaps(string FirstName, string LastName)
{
    return $"{LastName.ToUpper()}, {FirstName.ToUpper()}";
}
static string FormatFullNameLowerCase(string FirstName, string LastName)
{
    return $"{LastName.ToLower()}, {FirstName.ToLower()}";
}
static string FormatShortName(string FirstName, string LastName)
{
    return $"{FirstName.Substring(0, 1)}. {LastName}";
}

