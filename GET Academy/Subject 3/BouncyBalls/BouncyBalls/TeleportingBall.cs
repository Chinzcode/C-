namespace BouncyBalls
{
    internal class TeleportingBall : Ball
    {
        public TeleportingBall(int col, int row, int speedCol, int speedRow) 
            : base(col, row, speedCol, speedRow)
        {
        }

        protected override void SetColor()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }

        protected override void UpdateSpeedAndPosition()
        {
            if (_col < 0 || _col > Console.WindowWidth - 1) _col = (_col + Console.WindowWidth) % Console.WindowWidth;
            if (_row < 0 || _row > Console.WindowHeight - 1) _row = (_row + Console.WindowHeight) % Console.WindowHeight;
        }
    }
}
