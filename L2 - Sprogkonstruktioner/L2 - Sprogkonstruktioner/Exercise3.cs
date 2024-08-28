namespace L2___Sprogkonstruktioner
{
    internal class Exercise3
    {
        public static void Main()
        {
            Console.WriteLine("Det højeste fibonacci tal du ønsker at finde: ");
            string input = Console.ReadLine() ?? "0";
            int n = 0;
            try
            {
                n = int.Parse(input);
            }
            catch (Exception)
            {
                Console.WriteLine("Input was not a number, defaulting to 0");
            }
            Console.WriteLine("Fibonacci of " + n + " is " + String.Join(", ", Fibonacci(n)));
        }

        static List<int> Fibonacci(int n)
        {
            var fib = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                fib.Add(Calc_fibonnaci(i));
            }
            return fib;
        }

        static int Calc_fibonnaci(int n)
        {
            return (n == 0 || n == 1 || n == 2) ? n - 1 : Calc_fibonnaci(n - 1) + Calc_fibonnaci(n - 2);
        }
    }
}