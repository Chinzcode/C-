namespace ConsoleApp1
{
    internal class MyConsole
    {
        public static string Ask(string question)
        {
            Console.Write(question + " ");
            return Console.ReadLine();
        }

        public static int AskForInt(string question)
        {
            var answerStr = Ask(question);
            return Convert.ToInt32(answerStr);
        }

        public static bool AskForBool(string question)
        {
            var answerStr = Ask( question + " (Yes/No):");
            return answerStr.ToLower().StartsWith("y");
        }
    }
}
