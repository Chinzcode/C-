namespace WordPuzzle
{
    internal class Program
    {
        static string filename = "Dictionary.txt";
        public static string[] fileArray = File.ReadAllLines(filename);

        static void Main(string[] args)
        {
            string[] strArray = ReturnArray.GetArrayOfString(7, 10);
            var randomWord = GetRandomWord(strArray);

            var lastThreeChars = getLastCharsInString(randomWord, 3);
            var lastFourChars = getLastCharsInString(randomWord, 4);
            var lastFiveChars = getLastCharsInString(randomWord, 4);

            Console.WriteLine("randomWord = " + randomWord);
            Console.WriteLine("lastThreeChars = " + lastThreeChars);

            foreach (var element in strArray)
            {
                if (string.Equals(element.Substring(0, 3), lastThreeChars))
                {
                    Console.WriteLine("element = " + element);
                } else if (string.Equals(element.Substring(0, 4), lastFourChars))
                {
                    Console.WriteLine("element = " + element);
                } else if (string.Equals(element.Substring(0, 5), lastFiveChars))
                {
                    Console.WriteLine("element = " + element);
                }
            }
        }

        static string getLastCharsInString(string randomWord, int length)
        {
            return randomWord.Substring(randomWord.Length - length);
        }

        static string GetRandomWord(string[] strArray)
        {
            var random = new Random();
            var randomNum = random.Next(1, strArray.Length);
            return strArray[randomNum];
        }
    }
}