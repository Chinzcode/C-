using System.Reflection.Metadata;
using System.Text;

namespace TravelAgency
{
    internal class Travel
    {
        public string Name { get; }
        public DateTime FromDate { get; }
        public DateTime ToDate { get; }
        public int Capacity { get; }
        public int Price { get; }
        List<Booking> _bookings;

        public Travel(string name, DateTime fromDate, DateTime toDate, int capacity, int price)
        {
            Name = name;
            FromDate = fromDate;
            ToDate = toDate;
            Capacity = capacity;
            Price = price;
            _bookings = new List<Booking>();
        }

        public Booking Book(string name, int peopleCount)
        {
            var booking = new Booking(name, peopleCount);
            _bookings.Add(booking);
            return booking;
        }

        public string GetAllBookingsAsText()
        {
            var text = new StringBuilder();
            text.AppendLine($"{Name} - fra {FromDate:d} til {ToDate:d} - {Capacity} plasser");
            foreach (var booking in _bookings)
            {
                var travelText = booking.GetAsText();
                text.AppendLine(travelText);
            }
            return text.ToString();
        }
    }
}