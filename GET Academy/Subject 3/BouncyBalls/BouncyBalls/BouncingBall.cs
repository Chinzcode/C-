namespace BouncyBalls
{
    internal class BouncingBall : Ball
    {
        public BouncingBall(int col, int row, int speedCol, int speedRow)
            : base(col, row, speedCol, speedRow)
        {
        }

        protected override void SetColor()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        protected override void UpdateSpeedAndPosition()
        {
            if (_col <= 0 || _col >= Console.WindowWidth - 1) _speedCol = -_speedCol;
            if (_row <= 0 || _row >= Console.WindowHeight - 1) _speedRow = -_speedRow;
        }
    }
}
