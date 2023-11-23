namespace RefactorByIntroducingClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var counter = new CharCounter();
            string text = "Something!";

            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine();
                counter.AddText(text);
                counter.ShowCounts();
            }
        }
    }
}