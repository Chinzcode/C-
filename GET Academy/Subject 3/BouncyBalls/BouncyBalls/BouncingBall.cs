namespace BouncyBalls
{
    internal class BouncingBall : Ball
    {
        public BouncingBall(int col, int row, int speedCol, int speedRow)
            : base(col, row, speedCol, speedRow)
        {
        }

        public override void Show(bool changeColor = true)
        {
            if (changeColor)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            base.Show();
        }

        public override void Move()
        {
            base.Move();
            if (_col <= 0 || _col >= Console.WindowWidth - 1) _speedCol = -_speedCol;
            if (_row <= 0 || _row >= Console.WindowHeight - 1) _speedRow = -_speedRow;
        }
    }
}
