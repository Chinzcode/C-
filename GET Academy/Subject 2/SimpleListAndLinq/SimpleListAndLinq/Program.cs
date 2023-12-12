using SimpleListAndLinq;

var people = new List<Person>
{
    new Person(
        1, 
        "Per", 
        "Hansen",
        new DateTime(1990, 1, 2),
        1234
        ),
    new Person(
        2,
        "Pål",
        "Nilsen",
        new DateTime(1991, 3, 4),
        2345
    ),
    new Person(
        3,
        "Espen",
        "Olsen",
        new DateTime(1992, 5, 6),
        3456
    )
};

// FirstOrDefault - første som...

var firstPersonInList = people.FirstOrDefault();
var personWhoIsBornBefore1991 = people.FirstOrDefault(p => p.BirthDay.Year < 1991); // per
var personWhoIsBornBefore1981 = people.FirstOrDefault(p => p.BirthDay.Year < 1981); // null

// SingleOrDefault - den ene som...

var personWithId2 = people.SingleOrDefault(p => p.Id == 2); // pål
var personWithId20 = people.SingleOrDefault(p => p.Id == 20); // null

// Where (tilsvarer filter i Javascript)

var peopleWithFirstNameWithLetterE = 
    people.Where(p => p.FirstName.ToLower().Contains("e"))
        .ToList();

// Select (tilsvarer map i Javascript)

var firstNames = people.Select(p => p.FirstName).ToList();

// Select og Where

var firstNamesOfPeopleBornBefore1992 = people
    .Where(p => p.BirthDay.Year < 1992)
    .Select(p => p.FirstName)
    .ToList();
//.ToArray();

// Sum, Min, Max, Average

var sumOfPeopleAges =  people.Select(p => p.Age).Sum(); //.Min(); .Max(); .Average();
