namespace SecretNumberGuesser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            getSecretNumber();
        }
        private static void getSecretNumber()
        {
            const int min = 1;
            const int max = 10;

            var random = new Random();
            var number = random.Next(min, max + 1);
            var correctGuess = false;

            while (!correctGuess)
            {
                var guessStr = guessNumber();
                var guess = Convert.ToInt32(guessStr);

                if (guess == number)
                {
                    Console.WriteLine($"Gz, you win. Number was {number}");
                    Environment.Exit(0);
                }
                else if (guess < number)
                {
                    Console.WriteLine("Guess higher");
                }
                else if (guess > number)
                {
                    Console.WriteLine("Guess lower");
                }
            }
        }
        private static string guessNumber(string text = "Guess number between 1 and 10")
        {
            Console.WriteLine(text);

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int guess))
                {
                    if (guess >= 1 && guess <= 10)
                    {
                        return guess.ToString();
                    }
                }
                Console.WriteLine("Invalid input. Please enter a number between 1 and 10.");
            }
        }
    }
}