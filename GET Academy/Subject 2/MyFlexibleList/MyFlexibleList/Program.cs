var numbers = new int[4];
var count = 0;

while (true)
{
    Console.WriteLine("Skriv et tall: ");
    string numberStr = Console.ReadLine() ?? string.Empty;
    int number = Convert.ToInt32(numberStr);
    numbers[count] = number;
    count++;
    Console.WriteLine(string.Join(", ", numbers));
}