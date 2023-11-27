/*
Square klassen tilstanden til en enkelt rute, 
Board klassen håndterer tilstanden til hele brettet, og 
GameConsole klassen håndterer visningen av brettet.
*/

namespace ThreeInARow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowOptionText();

            var board = new Board();
            var gameConsole = new GameConsole(board);

            while (true)
            {
                gameConsole.Show();
                Console.Write("Skriv inn hvor du vil sette kryss (f.eks. \"a2\"): ");
                var position = Console.ReadLine();
                board.Mark(position, true);
            }
        }

        static void ShowOptionText()
        {
            Console.WriteLine("Skriv inn hvor du vil sette kryss (f.eks. \"a2\"): ");
        }
    }
}
