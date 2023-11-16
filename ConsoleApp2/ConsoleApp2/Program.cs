namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            getArrayOfInt(5, 35, 5);
            reverseString();
            getLongestWord("a bb ccc dddd eeeee");
        }
        private static void getArrayOfInt(int startValue, int endValue, int diff)
        {
            var arrayLength = (endValue - startValue) / diff;
            var arrValues = startValue;

            for (var i = 0; i <= arrayLength; i++)
            {
                Console.WriteLine(arrValues);
                arrValues += diff;
            }
        }
        private static void reverseString()
        {
            var name = "Terje";
            var reversedString = "";

            for (var i = name.Length - 1; i >= 0; i--) reversedString += name[i];
            Console.WriteLine(reversedString);
        }

        private static void getLongestWord(string sentance)
        {
            var wordCount = 0;
            var longestWord = "";
            string[] subs = sentance.Split(' ');

            foreach (var sub in subs)
            {
                wordCount++;
                if (longestWord.Length < sub.Length) longestWord = sub;
            }
            Console.WriteLine("Antall ord = " + wordCount);
            Console.WriteLine("Lengste ord = " + longestWord);
        }
    }
}