using FootballBetting12;

WriteTips();
var bet = Console.ReadLine();
var match = new Match();

while (match.IsMatchRunning())
{
    WriteCommand();
    var command = Console.ReadLine();
    match.CheckCommands(command ?? string.Empty);
    Console.WriteLine($"Stillingen er {match.GetCurrentScore()}.");
}

var isBetCorrectText = match.IsBetCorrect(bet ?? string.Empty) ? "riktig" : "feil";
Console.WriteLine($"Du tippet {isBetCorrectText}");

void WriteTips()
{
    Console.Write("Gyldig tips: \n" +
                  " - H, U, B\n" +
                  " - halvgardering: HU, HB, UB\n" +
                  " - helgardering: HUB\n" +
                  "Hva har du tippet for denne kampen? ");
}

void WriteCommand()
{
    Console.Write("Kommandoer: \n" +
                  " - H = scoring hjemmelag\n" +
                  " - B = scoring bortelag\n" +
                  " - X = kampen er ferdig\n" +
                  "Angi kommando: ");
}