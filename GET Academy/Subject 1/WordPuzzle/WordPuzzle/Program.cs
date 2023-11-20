namespace WordPuzzle
{
    internal class Program
    {
        public static string _filename = "Dictionary.txt";
        public static string[] _fileArray = File.ReadAllLines(_filename);

        static void Main(string[] args)
        {
            string[] strArray = ReturnArray.ReturnArrayOfString(7, 10);
            var randomWord = ReturnRandomWord(strArray).ToLower();

            var lastThreeChars = ReturnLastCharsInString(randomWord, 3);
            var lastFourChars = ReturnLastCharsInString(randomWord, 4);
            var lastFiveChars = ReturnLastCharsInString(randomWord, 5);

            var threeCharList = new List<string>();
            var fourCharList = new List<string>();
            var fiveCharList = new List<string>();

            foreach (var element in strArray)
            {
                if (string.Equals(element.Substring(0, 3), lastThreeChars)) threeCharList.Add(element);
                else if (string.Equals(element.Substring(0, 4), lastFourChars)) fourCharList.Add(element);
                else if (string.Equals(element.Substring(0, 5), lastFiveChars)) fiveCharList.Add(element);
            }
            PrintWordList(threeCharList, fourCharList, fiveCharList);
        }

        private static void PrintWordList(List<string> threeCharList, List<string> fourCharList, List<string> fiveCharList)
        {
            if (threeCharList.Count > 0) foreach (var element in threeCharList) Console.WriteLine(element);
            else if (fourCharList.Count > 0) foreach (var element in fourCharList) Console.WriteLine(element);
            else if (fiveCharList.Count > 0) foreach (var element in fiveCharList) Console.WriteLine(element);
        }

        private static string ReturnLastCharsInString(string randomWord, int length)
        {
            return randomWord.Substring(randomWord.Length - length);
        }

        private static string ReturnRandomWord(string[] strArray)
        {
            var random = new Random();
            var randomNum = random.Next(0, strArray.Length);
            return strArray[randomNum];
        }
    }
}