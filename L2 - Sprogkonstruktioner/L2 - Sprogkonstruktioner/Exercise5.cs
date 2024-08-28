namespace L2___Sprogkonstruktioner
{
    internal class Exercise5
    {

        public static void Main()
        {
            MyNormalMethod(1);
        }

        static private void MyMethodWithError(int num = 0)
        {
            throw new Exception("MyMethodWithError is an error");
        }

        static public void MyNormalMethod(int num = 0)
        {
            try
            {
                MyMethodWithError(num);
            } catch (Exception e)
            {
                if (e.Message == "MyMethodWithError is an error")
                    Console.WriteLine("An error occured: " + e.Message);
                else
                    throw;
            }
            finally
            {
                Console.WriteLine("This is the finally block, num: {0}", num);
            }
        }
    }
}