namespace WordPuzzle
{
    internal class ReturnArray
    {
        public static string[] getArrayOfString(int min, int max)
        {
            var list = new List<string>();
            string lastWord = null;

            for (var i = 0; i < Program.strArray.Length / 10; i++)
            {
                string[] parts = Program.strArray[i].Split('\t');

                if (parts.Length > 0)
                {
                    var word = parts[1];

                    if (word != lastWord)
                    {
                        if (word.Length >= min 
                            && word.Length <= max
                            && !word.Contains("-"))
                        {
                            list.Add(word);
                        }
                        lastWord = word;
                    }
                }
            }
            return list.ToArray();
        }
    }
}