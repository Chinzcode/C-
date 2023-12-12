using MyFlexibleList;

//Demo3 Innebygde lister av alle typer med List<>
var names = new List<string>();
var numbers = new List<int>();
while (true)
{
    Console.WriteLine("Skriv et navn: ");
    string? name = Console.ReadLine();
    names.Add(name);
    Console.WriteLine("Skriv et tall:");
    string? numberStr = Console.ReadLine();
    int number = Convert.ToInt32(numberStr);
    numbers.Add(number);
    Console.WriteLine(string.Join(",", names));
    Console.WriteLine(string.Join(",", numbers));
}


//Demo2 Lister av alle typer
var myNames = new FlexibleList<string>();
var myNumbers = new FlexibleList<int>();
while (true)
{
    Console.WriteLine("Skriv et navn: ");
    string? name = Console.ReadLine();
    myNames.Add(name);
    Console.WriteLine("Skriv et tall:");
    string? numberStr = Console.ReadLine();
    int number = Convert.ToInt32(numberStr);
    myNumbers.Add(number);
    Console.WriteLine(myNames.GetValues());
    Console.WriteLine(myNumbers.GetValues());
}

//Demo1 Array - Liste av int
var numbersx = new FlexibleIntList();
while (true)
{
    Console.WriteLine("Skriv et tall: ");
    string? numberStr = Console.ReadLine();
    int number = Convert.ToInt32(numberStr);
    numbersx.AddNumber(number);
    Console.WriteLine(numbersx.GetValues());
}