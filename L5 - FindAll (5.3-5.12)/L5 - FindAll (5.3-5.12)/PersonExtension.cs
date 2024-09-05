namespace L5___FindAll__5._3_
{
    public static class PersonExtension
    {
        public static void SetAccepted(this List<Person> lst, Predicate<Person> pred)
        {
            lst.FindAll(pred).ForEach(p => p.Accepted = true);
        }

        public static void Reset(this List<Person> lst)
        {
            lst.ForEach(p => p.Accepted = false);
        }
    }
}
