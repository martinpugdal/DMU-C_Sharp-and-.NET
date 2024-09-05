using L4___Delegates;
using static L4___Delegates.ExtensionModule;

var text = "Hello, World!";
bool result = text.Lang(5);
Console.WriteLine(result);

// Kald CalculateAndDisplay med hhv. Add og Multiply og passende (tilfældige) værdier for a og b.

CalculateAndDisplay(5, 10, Add);
CalculateAndDisplay(5, 10, Multiply);