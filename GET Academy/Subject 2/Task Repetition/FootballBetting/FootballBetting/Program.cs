Console.Write("Gyldig tips: \n" +
              " - H, U, B\n" +
              " - halvgardering: HU, HB, UB\n" +
              " - helgardering: HUB\n" +
              "Hva har du tippet for denne kampen? ");
var bet = Console.ReadLine();
var homeGoals = 0;
var awayGoals = 0;
var matchIsRunning = true;
while (matchIsRunning)
{
    Console.Write("Kommandoer: \n" +
                  " - H = scoring hjemmelag\n" +
                  " - B = scoring bortelag\n" +
                  " - X = kampen er ferdig\n" +
                  "Angi kommando: ");
    var command = Console.ReadLine();
    matchIsRunning = command != "X";
    if (command == "H") homeGoals++;
    else if (command == "B") awayGoals++;
    Console.WriteLine($"Stillingen er {homeGoals}-{awayGoals}.");
}

var result = homeGoals == awayGoals ? "U" : homeGoals > awayGoals ? "H" : "B";
var isBetCorrect = bet.Contains(result);
var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
Console.WriteLine($"Du tippet {isBetCorrectText}");