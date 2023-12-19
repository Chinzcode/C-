namespace BouncyBalls
{
    internal class Ball
    {
        private float _col;
        private float _row;
        private float _speedCol;
        private float _speedRow;
        private readonly BallType _ballType;

        public Ball(int col, int row, int speedCol, int speedRow, BallType ballType)
        {
            _ballType = ballType;
            _col = col;
            _row = row;
            _speedCol = speedCol;
            _speedRow = speedRow;
        }

        public void Show()
        {
            if (_ballType == BallType.BouncingInWalls)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (_ballType == BallType.Teleporting)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (_ballType == BallType.BouncingWithGravity)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            Console.CursorLeft = Convert.ToInt32(_col);
            Console.CursorTop = Convert.ToInt32(_row);
            Console.Write("O");
        }

        public void Move()
        {
            _col += _speedCol;
            _row += _speedRow;

            if (_ballType is BallType.BouncingInWalls or BallType.BouncingWithGravity)
            {
                if (_col <= 0 || _col >= Console.WindowWidth -1 ) _speedCol = -_speedCol;
                if (_row <= 0 || _row >= Console.WindowHeight - 1) _speedRow = -_speedRow;
            }
            else if (_ballType == BallType.Teleporting)
            {
                if (_col < 0 || _col > Console.WindowWidth - 1) _col = (_col + Console.WindowWidth) % Console.WindowWidth;
                if (_row < 0 || _row > Console.WindowHeight - 1) _row = (_row + Console.WindowHeight) % Console.WindowHeight;
            }
            if (_ballType == BallType.BouncingWithGravity)
            {
                _speedRow += 0.3f;
                if (_row > Console.WindowHeight - 1) _row = Console.WindowHeight - 1;
            }
        }
    }
}
