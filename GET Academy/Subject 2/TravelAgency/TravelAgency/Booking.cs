namespace TravelAgency
{
    internal class Booking
    {
        public string Name { get; }
        public int PeopleCount { get; }

        public Booking(string name, int peopleCount)
        {
            Name = name;
            PeopleCount = peopleCount;
        }

        public string GetAsText()
        {
            return Name + " - " + PeopleCount + " personer";
        }
    }
}