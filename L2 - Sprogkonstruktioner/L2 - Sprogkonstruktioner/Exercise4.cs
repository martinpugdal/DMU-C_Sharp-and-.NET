namespace L2___Sprogkonstruktioner
{
    internal class Exercise4
    {

        public static void Main()
        {
            CalculateAge(new DateTime(2001, 3, 5), out int age);
            Console.WriteLine("Alder er: " + age);
        }

        static void CalculateAge(DateTime BirthDateInput, out int age)
        {
            age = DateTime.Now.Year - BirthDateInput.Year;

            // Hvis datoen er under fødselsdagen, så er vedkommede ikke fyldt år endnu
            if (DateTime.Now.DayOfYear < BirthDateInput.DayOfYear)
                age = age - 1;
        }
    }
}