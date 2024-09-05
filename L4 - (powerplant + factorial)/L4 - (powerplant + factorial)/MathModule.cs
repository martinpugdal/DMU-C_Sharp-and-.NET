
namespace L4____powerplant___factorial_
{
    public static class MathModule
    {

        public static int Factorial0(int n)
        {
            return n == 0 ? 1 : n * Factorial0(n - 1);
        }

        public static int Factorial(this int n)
        {
            return Factorial0(n);
        }

        public static int Power0(int n, int p)
        {
            return p == 0 ? 1 : n * Power0(n, p - 1);
        }

        public static int Power(this int n, int p)
        {
            return Power0(n, p);
        }
    }
}
