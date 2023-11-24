using System.Xml.Serialization;

namespace FootballBetting
{
    internal class Match
    {
        private int homeGoals;
        private int awayGoals;
        private readonly string bet;
        public bool isOngoing { get; private set; }

        public Match(string bet)
        {
            this.bet = bet;
            this.isOngoing = true;
        }

        public void AddGoal(bool isHomeTeam)
        {
            if (isHomeTeam) this.homeGoals++;
            else this.awayGoals++;
        }

        public bool IsBetCorrect()
        {
            var result = this.homeGoals == this.awayGoals ? "U" : this.homeGoals > this.awayGoals ? "H" : "B";
            return this.bet.Contains(result);
        }

        public void Stop()
        {
            this.isOngoing = false;
        }

        public string GetScore()
        {
            return this.homeGoals + "-" + this.awayGoals;
        }
    }
}