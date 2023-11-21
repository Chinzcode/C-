using TextObjects;

var model = new Model
{
    CurrenctUser = "Trym",
    Texts = new TextEffects[] {
        new TextEffects() {
            Text = "AAAAA",
            Color = ConsoleColor.Red,
            Col = 12,
            Row = 2,
            IsInverted = false,
            Case = Case.Default,
        },
        new TextEffects() {
            Text = "BBB",
            Color = ConsoleColor.Blue,
            Col = 3,
            Row = 14,
            IsInverted = true,
            Case = Case.Upper,
        },
        new TextEffects() {
            Text = "C",
            Color = ConsoleColor.Green,
            Col = 23,
            Row = 8,
            IsInverted = false,
            Case = Case.Lower,
        },
    },
};

Console.Clear();

foreach (var text in model.Texts)
{
    Console.CursorLeft = text.Col;
    Console.CursorTop = text.Row;
    if (text.IsInverted)
    {
        Console.BackgroundColor = text.Color;
        Console.ForegroundColor = ConsoleColor.Black;
    }
    else
    {
        Console.ForegroundColor = text.Color;
        Console.BackgroundColor = ConsoleColor.Black;
    }

    var myText = text.Text;
    if (text.Case == Case.Upper) myText.ToUpper();
    else if (text.Case == Case.Lower) myText.ToLower();
    Console.Write(myText);
}

Console.CursorTop = 20;