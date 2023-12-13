using TravelAgency;

var agency = new Agency("Tryms Reisebyrå");

var travelDate = new DateTime(2024, 5, 17);
var returnDate = new DateTime(2024, 5, 25);

agency.RegisterTravel("Vinsmaking i Toscana", travelDate, returnDate, 20, 9900);