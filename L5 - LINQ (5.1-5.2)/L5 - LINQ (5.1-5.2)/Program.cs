
internal static class Program
{

    private static void ShowOutput(int num)
    {
        Console.WriteLine(num);
    }

    private static void Main()
    {
        var data = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };

        Action<int> action = new(ShowOutput);

        // 5.1
        var evenNumbers = data.FindAll(x => x % 0 == 0);
        //Array.ForEach(evenNumbers.ToArray(), action);

        var lastNum = data.FindAll(x => x > 15).Max();
        //action(lastNum);

        var lastIndex = data.FindAll(x => x > 15).Last();
        //action(lastIndex);

        // 5.2
        var evenNumbers2 = data.Where(x => x % 2 == 0);
        //Array.ForEach(evenNumbers2.ToArray(), action);

        var numberLengthTwo = data.Where(x => x.ToString().Length == 2);
        //Array.ForEach(numberLengthTwo.ToArray(), action);
    }
}