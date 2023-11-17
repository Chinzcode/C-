namespace WordPuzzle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var filename = "Dictionary.txt";
            string[] textArray = File.ReadAllLines(filename);
            string lastWord = null;

            for (var i = 0; i < textArray.Length/10; i++)
            {
                string[] parts = textArray[i].Split('\t');

                if (parts.Length > 0)
                {
                    var word = parts[1];

                    if (word != lastWord)
                    {
                        Console.WriteLine(word);
                        lastWord = word;
                    }
                }
            }
        }
    }
}