using MyFlexibleList;

var numbers = new FlexibleList();
while (true)
{
    Console.WriteLine("Skriv et tall: ");
    string numberStr = Console.ReadLine() ?? string.Empty;
    int number = Convert.ToInt32(numberStr);
    numbers.AddNumber(number);
    Console.WriteLine(numbers.GetValues());
}