namespace WordPuzzle
{
    internal class ReturnArray
    {
        public static string[] GetArrayOfString(int min, int max)
        {
            var list = new List<string>();
            string lastWord = null;

            for (var i = 0; i < Program.fileArray.Length; i++)
            {
                string[] parts = Program.fileArray[i].Split('\t');

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