using CharCounterTask;

var counter = new CharCounter();
string text = "something";
while (!string.IsNullOrWhiteSpace(text))
{
    text = Console.ReadLine() ?? string.Empty;
    counter.AddText(text);
    counter.ShowCounts();
}