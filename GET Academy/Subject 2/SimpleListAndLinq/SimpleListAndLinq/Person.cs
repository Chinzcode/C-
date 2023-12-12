namespace SimpleListAndLinq
{
    internal class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public int PostalCode { get; set; }

        public int Age => (int)(DateTime.Now - BirthDay).TotalDays / 365;

        public Person(int id, string firstName, string lastName, DateTime birthDay, int postalCode)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthDay;
            PostalCode = postalCode;
        }

        public Person()
        {

        }
    }
}
