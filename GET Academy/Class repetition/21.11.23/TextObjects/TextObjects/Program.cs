using TextObjects;

var model = new Model
{
    CurrenctUser = "Trym",
    Texts = new TextEffects[] {
        new TextEffects() {
            Text = "AAAAA",
            Color = ConsoleColor.Red,
            Col = 1,
            Rows = 1,
            IsInverted = false,
            Case = Case.Default,
        },
        new TextEffects() {
            Text = "BBB",
            Color = ConsoleColor.Blue,
            Col = 2,
            Rows = 2,
            IsInverted = false,
            Case = Case.Upper,
        },
        new TextEffects() {
            Text = "C",
            Color = ConsoleColor.Green,
            Col = 3,
            Rows = 3,
            IsInverted = true,
            Case = Case.Lower,
        },
    },
};