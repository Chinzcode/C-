namespace WordPuzzle
{
    internal class ReturnArray
    {
        public static string[] ReturnArrayOfString(int min, int max)
        {
            var list = new List<string>();
            string lastWord = null;

            for (var i = 0; i < Program._filename.Length; i++)
            {
                string[] parts = Program._fileArray[i].Split('\t');

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