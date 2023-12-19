namespace BouncyBalls
{
    internal class BouncingGravityBall : BouncingBall
    {
        public BouncingGravityBall(int col, int row, int speedCol, int speedRow) 
            : base(col, row, speedCol, speedRow)
        {
        }

        public override void Show(bool changeColor = true)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            base.Show(false);
        }

        public override void Move()
        {
            base.Move();
            _speedRow += 0.3f;
            if (_row > Console.WindowHeight - 1) _row = Console.WindowHeight - 1;
        }
    }
}
