using L1___intro_til_C_;
using MyLibrary;

Console.WriteLine("Hello, World!");

Person person = new("martin");
Console.WriteLine(person);
person.Name = "benny";
Console.WriteLine(person);

List<Person> personer = [person]; // new() / new List<Person>();

foreach (var person1 in personer)
{
    Console.WriteLine(person1.Name);
}

var running = true;
while (running)
{
    Console.WriteLine("Hvad skal slags dyr skal der oprettes?");
    var dogType = Console.ReadLine();
    if (dogType != "")
    {
        var animal = new Animal(dogType);
        Console.WriteLine("{0} er tilføjet, og det er {1}", animal, animal.IsDog() ? "en hund" : "ikke en hund");
    }
    else
    {
        running = false;
    }
}

var list = new MyList();
list.AddNumber(1);
list.AddNumber(10);
list.AddNumber(100);
list.PrintNumbers();

MyList list2 = new();
var random = new Random();
for (var i = 0; i < 10; i++)
{
    list2.AddNumber(random.Next(0, 100)+1);
}
list2.PrintNumbers();