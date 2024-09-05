using L5___FindAll__5._3_;

var people1 = new List<Person>();
var people2 = new List<Person>();

void readCSVFiles()
{
    try
    {
        people1 = Person.ReadCSVFile(@"C:\Users\Marti\OneDrive - EFIF\Dokumenter\GitHub\DMU-C_Sharp-and-.NET\L5 - FindAll (5.3-5.12)\L5 - FindAll (5.3-5.12)\data1.csv");
        people2 = Person.ReadCSVFile(@"C:\Users\Marti\OneDrive - EFIF\Dokumenter\GitHub\DMU-C_Sharp-and-.NET\L5 - FindAll (5.3-5.12)\L5 - FindAll (5.3-5.12)\data2.csv");
    }
    catch (Exception ex)
    {
        Console.WriteLine("EXCEPTION: " + ex.Message);
    }
}
readCSVFiles();

// 5.3 (FindAll)
var scoreBelow2 = people1.FindAll(x => x.Score < 2);

var scoreEven = people1.FindAll(x => x.Score % 2 == 0);

var scoreEvenWeightOver60 = scoreEven.FindAll(x => x.Weight > 60);

var weightModulus3 = people1.FindAll(x => x.Weight % 3 == 0);


// 5.4 (FindIndex)
var firstPeopleWithScore3 = people1.FindIndex(x => x.Score == 3);
//Console.WriteLine(firstPeopleWithScore3);

var ageBelow10AndScoreEquals3 = people1.FindIndex(x => x.Score == 3 && x.Age < 10);
//Console.WriteLine(ageBelow10AndScoreEquals3);

var allAgeBelow10AndScoreEquals3 = people1.FindAll(x => x.Score == 3 && x.Age < 10);
//allAgeBelow10AndScoreEquals3.ForEach(Console.WriteLine);

var firstBelowAge8 = people1.FindIndex(x => x.Age < 8 && x.Score == 3);
//Console.WriteLine(firstBelowAge8);


// 5.6 (predicates og extension methods)
var people1_ = new List<Person>(people1);
people1_.SetAccepted(p => p.Score >= 6 && p.Age <= 40);
//people1_.ForEach(Console.WriteLine);


// 5.7 (LINQ)
people1_ = new List<Person>(people1);
var peopleScoreOrder = people1_.OrderByDescending(x => x.Score);
var peopleAgeOrder = people1_.OrderBy(x => x.Age);


// 5.8 (LINQ)
int[] numbers = { 34, 8, 56, 31, 79, 150, 88, 7, 200, 47, 88, 20 };

var twoDigits = numbers.Where(x => x.ToString().Length == 2);

var twoDigitsAscOrder = twoDigits.OrderBy(x => x);
var twoDigitsDescOrder = twoDigits.OrderByDescending(x => x);

var digitsAsString = twoDigitsAscOrder.Select(x => x.ToString()).ToList();
var digitsAsStringEvenCheck = twoDigitsDescOrder.Select(x => x + " " + (x % 2 == 0 ? "even" : "uneven")).ToList();

//digitsAsStringEvenCheck.ForEach(Console.WriteLine);


// 5.9
people1_ = new List<Person>(people1);
people1_.SetAccepted(people1 => true);
people1_.Reset();
//people1_.ForEach(Console.WriteLine);


// 5.10
var randomNumbers = new List<int>();
var rand = new Random();
for (int i = 0; i < 100; i++)
    randomNumbers.Add(rand.Next(-15, 15));

var unevenNumbersCount = randomNumbers.Where(x => x % 2 != 0).Count();
//Console.WriteLine("\nantallet af ulige tal I listen:");
//Console.WriteLine(unevenNumbersCount);

var distinctNumbersCount = randomNumbers.Distinct().Count();
//Console.WriteLine("\nantallet af unikke tal I listen:");
//Console.WriteLine(distinctNumbersCount);

var first3UnevenNumbers = randomNumbers.Where(x => x % 2 != 0).Take(3);
//Console.WriteLine("\ntre første ulige tal:");
//first3UnevenNumbers.ToList().ForEach(Console.WriteLine);

var distinctUneventNumbers = randomNumbers.Distinct().Where(x => x % 2 != 0);
//Console.WriteLine("\nalle unikke ulige tal:");
//distinctUneventNumbers.ToList().ForEach(Console.WriteLine);


// 5.11 (ekstra opgave med GroupBy)
var peopleGroupByFirstLetter = people1.GroupBy(people1 => people1.Name.Substring(0, 1));
foreach (var group in peopleGroupByFirstLetter)
{
    //Console.WriteLine("Grupperet efter " + group.Key);

    foreach (var person in group)
    {
        //Console.WriteLine(person);
    }
    //Console.WriteLine();
}

// 5.12 (ekstra opgave med join med 2 sæt)
var allPeople = people1.Join(people2,
    p1 => p1.Name, p2 => p2.Name,
    (p1, p2) => p1
);

foreach (var item in allPeople)
{
    //Console.WriteLine(item);
}