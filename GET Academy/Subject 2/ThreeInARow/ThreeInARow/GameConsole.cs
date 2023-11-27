using ThreeInARow;

namespace ThreeInARow
{
    internal class GameConsole
    {
        private Board board;

        public GameConsole(Board board)
        {
            this.board = board;
        }

        public void Show()
        {
            Console.Clear();
            Console.WriteLine("  a b c");
            Console.WriteLine(" ┌─────┐");

            for (int i = 0; i < 3; i++)
            {
                Console.Write(i + 1 + "│");
                for (int j = 0; j < 3; j++)
                {
                    if (board.GetSquare(i, j).IsEmpty())
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(board.GetSquare(i, j).IsPlayer1() ? "x" : "o");
                    }

                    if (j < 2)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("│");
            }

            Console.WriteLine(" └─────┘");
        }
    }
}
//"  a b c\r\n \u250c\u2500\u2500\u2500\u2500\u2500\u2510\r\n1\u2502o    \u2502\r\n2\u2502    o\u2502\r\n3\u2502\u00d7 \u00d7  \u2502\r\n \u2514\u2500\u2500\u2500\u2500\u2500\u2518"
//  a b c
// ┌─────┐
//1│o    │
//2│    o│
//3│× ×  │
// └─────┘

//var symbol = Board.GetSquare;

//Console.WriteLine("1 |" + symbol[0] + " " + symbol[1] + " " + symbol[2] + "|");
//Console.WriteLine("2 |" + symbol[3] + " " + symbol[4] + " " + symbol[5] + "|");
//Console.WriteLine("3 |" + symbol[6] + " " + symbol[7] + " " + symbol[8] + "|");
//Console.WriteLine("  └─────┘");