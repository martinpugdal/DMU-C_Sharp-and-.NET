
namespace L1___intro_til_C_
{
    internal class MyList
    {
        private readonly List<int> list = new();

        public void AddNumber(int number)
        {
            list.Add(number);
        }

        public void PrintNumbers()
        {
            foreach (var number in list)
            {
                Console.WriteLine(number);
            }
        }
    }
}
