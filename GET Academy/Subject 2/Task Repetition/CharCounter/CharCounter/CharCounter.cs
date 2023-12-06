namespace CharCounterTask
{
    internal class CharCounter
    {
        private int[] Counts;
        private int Range;

        public CharCounter()
        {
            this.Range = 250;
            this.Counts = new int[Range];
        }

        public void AddText(string text)
        {
            foreach (var character in text ?? string.Empty)
            {
                this.Counts[(int)character]++;
            }
        }
        public void ShowCounts()
        {
            for (var i = 0; i < this.Range; i++)
            {
                if (this.Counts[i] > 0)
                {
                    var character = (char)i;
                    Console.WriteLine(character + " - " + this.Counts[i]);
                }
            }
        }
    }
}