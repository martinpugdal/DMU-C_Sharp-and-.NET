namespace L4___Delegates
{
    public static class ExtensionModule
    {

        public static bool Lang(this string s, int n)
        {
            return s.Length > n;
        }

        public delegate int Operation(int a, int b);

        public static void CalculateAndDisplay(int a, int b, Operation operation)
        {
            Console.WriteLine("a: {0}, b: {1}", a, b);
            int result = operation(a, b);
            Console.WriteLine("Result: {0}", result);
        }

        public static int Add(int a, int b)
        {
            Operation operation = (a, b) => a + b;
            return operation(a, b);
        }

        public static int Multiply(int a, int b)
        {
            Operation operation = (a, b) => a * b;
            return operation(a, b);
        }
    }
}
