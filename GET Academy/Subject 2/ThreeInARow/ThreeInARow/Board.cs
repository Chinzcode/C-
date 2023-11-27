namespace ThreeInARow
{
    internal class Board
    {
        private Square[,] squares;

        public Board()
        {
            squares = new Square[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    squares[i, j] = new Square();
                }
            }
        }

        public Square GetSquare(int row, int col)
        {
            return squares[row, col];
        }

        public void Mark(string position, bool player1)
        {
            if (position.Length == 2 && char.IsLetter(position[0]) && char.IsDigit(position[1]))
            {
                int col = position[0] - 'a';
                int row = position[1] - '1';
                if (row >= 0 && row < 3 && col >= 0 && col < 3)
                {
                    squares[row, col].Mark(player1);
                }
            }
        }
    }
}