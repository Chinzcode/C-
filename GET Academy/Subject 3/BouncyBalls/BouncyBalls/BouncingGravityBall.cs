namespace BouncyBalls
{
    internal class BouncingGravityBall : BouncingBall
    {
        public BouncingGravityBall(int col, int row, int speedCol, int speedRow) 
            : base(col, row, speedCol, speedRow)
        {
        }

        protected override void SetColor()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }

        protected override void UpdateSpeedAndPosition()
        {
            base.UpdateSpeedAndPosition();
            _speedRow += 0.3f;
            if (_row > Console.WindowHeight - 1) _row = Console.WindowHeight - 1;
        }
    }
}
