using L4___Delegate__powerplant___exercise_4_;


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