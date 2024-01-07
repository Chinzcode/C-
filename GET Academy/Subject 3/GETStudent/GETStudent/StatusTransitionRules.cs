using System.Linq;

namespace GETStudent
{
    internal class StatusTransitionRules
    {
        private List<List<string>> _validTransitions;
        private List<string> _specialTransitions;

        public StatusTransitionRules()
        {
            _validTransitions = new List<List<string>>
            {
                new List<string> { "Har søkt", "Levert dokumentasjon", "Ikke levert dokumentasjon" },
                new List<string> { "Levert dokumentasjon", "Fått tilbud", "Fått avslag" },
                new List<string> { "Fått tilbud", "Signert kontrakt", "Takket nei" },
                new List<string> { "Signert kontrakt", "Startet", "Angret/ikke møtt" },
                new List<string> { "Startet", "Fullført og bestått", "Fullført, ikke bestått", "Brutt" },
                new List<string> { "Fullført, ikke bestått", "Fullført og bestått", "Ikke bestått - ikke flere forsøk igjen" },
            };
            _specialTransitions = new List<string>
            {
                "Ikke levert dokumentasjon", "Fått avslag", "Takket nei", "Angret/ikke møtt",
            };
        }

        public string IsTransitionAllowed(string currentStatus, string newStatus)
        {
            foreach (var transition in _validTransitions)
            {
                if (transition[0] == currentStatus && transition.Contains(newStatus))
                {
                    if (_specialTransitions.Contains(newStatus))
                    {
                        newStatus = "Ikke Startet";
                    }
                    return newStatus;
                }
            }
            return currentStatus;
        }
    }
}