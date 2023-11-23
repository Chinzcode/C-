namespace RefactorByIntroducingClass
{
    internal class CharCounter
    {
        private int[] counts;
        private const int range = 250;

        public CharCounter()
        {
            counts = new int[range];
        }

        public void AddText(string text)
        {
            foreach (var character in text ?? string.Empty)
            {
                counts[(int)character]++;
            }
        }

        public void ShowCounts()
        {
            for (var i = 0; i < range; i++)
            {
                if (counts[i] > 0)
                {
                    var character = (char)i;
                    Console.WriteLine(character + " - " + counts[i]);
                }
            }
        }
    }
}
