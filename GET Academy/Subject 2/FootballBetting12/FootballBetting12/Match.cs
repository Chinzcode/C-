namespace FootballBetting12
{
    internal class Match
    {
        private int HomeGoals;
        private int AwayGoals;
        private bool MatchIsRunning;

        public Match()
        {
            this.MatchIsRunning = true;
        }

        public bool IsMatchRunning()
        {
            return this.MatchIsRunning;
        }

        public void CheckCommands(string command)
        {
            if (command == "H") this.HomeGoals++;
            else if (command == "B") this.AwayGoals++;
            else if (command == "X") this.MatchIsRunning = false;
        }

        public string GetCurrentScore()
        {
            return this.HomeGoals + "-" + this.AwayGoals;
        }

        public bool IsBetCorrect(string bet)
        {
            string result = this.HomeGoals == this.AwayGoals ? "U"
                : this.HomeGoals > this.AwayGoals ? "H" : "B";
            return bet.Contains(result);
        }
    }
}