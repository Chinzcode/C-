namespace WordPuzzle
{
    internal class Program
    {
        static string filename = "Dictionary.txt";
        public static string[] strArray = File.ReadAllLines(filename);

        static void Main(string[] args)
        {
            var strArr = ReturnArray.getArrayOfString();
            foreach (var element in strArr)
            {
                Console.WriteLine(element);
            }
        }
    }
}

//string lastWord = null;

//for (var i = 0; i < strArray.Length; i++)
//{
//    string[] parts = strArray[i].Split('\t');

//    if (parts.Length > 0)
//    {
//        var word = parts[1];

//        if (word != lastWord)
//        {
//            Console.WriteLine(word);
//            lastWord = word;
//        }
//    }
//}