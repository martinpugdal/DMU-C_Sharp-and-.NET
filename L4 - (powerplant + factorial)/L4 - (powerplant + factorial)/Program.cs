using L4____powerplant___factorial_;
using static L4____powerplant___factorial_.MathModule;


// Opretter en instans af PowerPlant
PowerPlant plant = new();

// Sætter WarningMethod som delegate
plant.SetWarning(warningToConsole);
plant.SetWarning(crazyWarningToConsole);

// Udløser advarslen
plant.TriggerWarning();

static void warningToConsole()
{
    Console.WriteLine("Advarsel!");
}
static void crazyWarningToConsole()
{
    Console.WriteLine("Crazy advarsel!");
}

// Udskriver 4! = 24
Console.WriteLine(4.Factorial());
// Udskriver 2^4 = 16
Console.WriteLine(2.Power(4));