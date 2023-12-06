namespace CoinCounts
{
    internal class Counter
    {
        private int Value;
        private int Count;

        public Counter(int value, int count)
        {
            this.Value = value;
            this.Count = count;
        }

        public int CalculateValue()
        {
            return this.Value * this.Count;
        }
    }
}
