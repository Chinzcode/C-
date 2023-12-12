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