using TravelAgency;

var agency = new Agency("Tryms Reisebyrå");

var travelDate = new DateTime(2024, 5, 17);
var returnDate = new DateTime(2024, 5, 25);

var registerTravel = agency.RegisterTravel("Vinsmaking i Toscana", travelDate, returnDate, 20, 9900);

var bookTravel = agency.GetTravel("Vinsmaking i Toscana");
bookTravel.Book("Hansen", 5);

var text = agency.GetAllBookingsAsText();
Console.WriteLine(text);