namespace BouncyBalls
{
    internal class TeleportingBall : Ball
    {
        public TeleportingBall(int col, int row, int speedCol, int speedRow) 
            : base(col, row, speedCol, speedRow)
        {
        }

        public override void Show(bool changeColor)
        {
            if (changeColor)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            base.Show();
        }

        public override void Move()
        {
            base.Move();
            if (_col < 0 || _col > Console.WindowWidth - 1) _col = (_col + Console.WindowWidth) % Console.WindowWidth;
            if (_row < 0 || _row > Console.WindowHeight - 1) _row = (_row + Console.WindowHeight) % Console.WindowHeight;
        }
    }
}
