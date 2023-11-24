using FootballBetting;

ShowTips();
var bet = Console.ReadLine() ?? string.Empty;
var match = new Match(bet);
while (match.IsOngoing)
{
    ShowCommands();
    var command = Console.ReadLine();
    if (command == "X") match.Stop();
    else if (command == "H" || command == "B") match.AddGoal(command == "H");
    Console.WriteLine($"Stillingen er {match.GetScore()}.");
}

var isBetCorrectText = match.IsBetCorrect() ? "riktig" : "feil";
Console.WriteLine($"Du tippet {isBetCorrectText}");

void ShowTips()
{
    Console.Write("Gyldig tips: \n" +
                  " - H, U, B\n" +
                  " - halvgardering: HU, HB, UB\n" +
                  " - helgardering: HUB\n" +
                  "Hva har du tippet for denne kampen? ");
}

void ShowCommands()
{
    Console.Write("Kommandoer: \n" +
                  " - H = scoring hjemmelag\n" +
                  " - B = scoring bortelag\n" +
                  " - X = kampen er ferdig\n" +
                  "Angi kommando: ");
}