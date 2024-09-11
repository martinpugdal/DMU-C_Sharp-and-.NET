namespace StartUp_CORE.Models
{
    public class Person
    {
        private DateTime birthday;

        public Person(string firstname, string lastname, DateTime birthday, List<string> phoneNumbers, string adresse, string zip, string city)
        {
            FirstName = firstname;
            LastName = lastname;
            this.birthday = birthday;
            PhoneNumbers = phoneNumbers;
            Adresse = adresse;
            Zip = zip;
            City = city;
        }


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday
        {
            set
            {
                if (GetAge(value) < 0 || GetAge(value) > 120)
                {
                    throw new Exception("Age not accepted");
                }
                else
                {
                    birthday = value;
                }
            }
            get { return birthday; }
        }
        public List<string> PhoneNumbers { get; set; }
        public string Adresse { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }

        public int Age
        {
            get
            {
                return GetAge(birthday);
            }
        }

        public void AddPhone(string phone)
        {
            PhoneNumbers.Add(phone);
        }

        private static int GetAge(DateTime dateTime)
        {
            DateTime now = DateTime.Now;
            int age;
            age = now.Year - dateTime.Year;
            // calculate to see if the person hasn’t had dateTime yet
            // subtract one year if that is not the case
            if (now.Month < dateTime.Month || (now.Month == dateTime.Month && now.Day < dateTime.Day))
            {
                age--;
            }
            return age;
        }


        public override string ToString()
        {
            return String.Format("{0} {1} is {2} years old, ({3}), {4}, {5} {6}", FirstName, LastName, Age, string.Join(", ", PhoneNumbers), Adresse, Zip, City);
        }
    }
}
