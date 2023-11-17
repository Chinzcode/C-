namespace WordPuzzle
{
    internal class Program
    {
        static string filename = "Dictionary.txt";
        public static string[] fileArray = File.ReadAllLines(filename);

        static void Main(string[] args)
        {
            string[] strArray = ReturnArray.GetArrayOfString(7, 10);
            var randomWord = GetRandomWord(strArray).ToLower();

            var lastThreeChars = getLastCharsInString(randomWord, 3);
            var lastFourChars = getLastCharsInString(randomWord, 4);
            var lastFiveChars = getLastCharsInString(randomWord, 5);

            var threeCharList = new List<string>();
            var FourCharList = new List<string>();
            var FiveCharList = new List<string>();

            Console.WriteLine("randomWord = " + randomWord);

            foreach (var element in strArray)
            {
                if (string.Equals(element.Substring(0, 3), lastThreeChars))
                {
                    threeCharList.Add(element);
                }
                else if (string.Equals(element.Substring(0, 4), lastFourChars))
                {
                    FourCharList.Add(element);
                }
                else if (string.Equals(element.Substring(0, 5), lastFiveChars))
                {
                    FiveCharList.Add(element);
                }
            }

            if (threeCharList.Count > 0)
            {
                Console.WriteLine("First match = 3 Chars");
                foreach (var element in threeCharList)
                {
                    Console.WriteLine(element);
                }
            } 
            else if (FourCharList.Count > 0)
            {
                Console.WriteLine("First match = 4 Chars");
                foreach (var element in FourCharList)
                {
                    Console.WriteLine(element);
                }
            } 
            else if (FiveCharList.Count > 0)
            {
                Console.WriteLine("First match = 5 Chars");
                foreach (var element in FiveCharList)
                {
                    Console.WriteLine(element);
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
            var randomNum = random.Next(1, strArray.Length-1);
            return strArray[randomNum];
        }
    }
}