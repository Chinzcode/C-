namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = MyConsole.Ask("What is your name?");
            var birthyear = MyConsole.AskForInt($"Hi {name}, what year are you born?");
            var hadBirthday = MyConsole.AskForBool("Have you had a birthday this year?");
            var age = 2023 - birthyear;
            if (!hadBirthday) age--;
            Console.WriteLine($"You are {age} years old");
        }
    }
}