namespace Players
{
    internal class Player
    {
        private string Name;
        private int Points;

        public Player(string name, int points)
        {
            this.Name = name;
            this.Points = points;
        }

        public void Play(Player player2)
        {
            var random = new Random();
            var winner = random.Next(2) == 0 ? this : player2;
            var loser = winner == this ? player2 : this;
            winner.Points++;
            loser.Points--;
        }

        public void ShowNameAndPoints()
        {
            Console.WriteLine($"Name: {this.Name}, points: {this.Points}");
        }
    }
}
