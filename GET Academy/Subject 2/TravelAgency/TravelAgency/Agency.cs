using System.Text;

namespace TravelAgency
{
    internal class Agency
    {
        private string _name;
        readonly List<Travel> _travels;

        public Agency(string name)
        {
            _name = name;
            _travels = new List<Travel>();
        }

        public Travel RegisterTravel(string name, DateTime fromDate, DateTime toDate, int capacity, int price)
        {
            var travel = new Travel(name, fromDate, toDate, capacity, price);
            _travels.Add(travel);
            return travel;
        }

        public Travel GetTravel(string name)
        {
            return _travels.SingleOrDefault(t => t.Name == name);
        }

        public string GetAllBookingsAsText()
        {
            var text = new StringBuilder();
            foreach (var travel in _travels)
            {
                var travelText = travel.GetAllBookingsAsText();
                text.AppendLine(travelText);
            }
            return text.ToString();
        }
    }
}