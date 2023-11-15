namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            var name = Console.ReadLine();
            Console.Write($"Hi {name}, what year are you born? ");
            var birthyearStr = Console.ReadLine();
            var birthyear = Convert.ToInt32(birthyearStr);
            var age = 2023 - birthyear;
            Console.Write("Have you had a birthday this year? (Yes/No): ");
            var answer = Console.ReadLine();
            if (answer == "No") age--; 
            Console.WriteLine($"You are {age} years old");
        }
    }
}