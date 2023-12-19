namespace BouncyBalls
{
    internal abstract class Ball
    {
        protected float _col;
        protected float _row;
        protected float _speedCol;
        protected float _speedRow;

        protected Ball(int col, int row, int speedCol, int speedRow)
        {
            _col = col;
            _row = row;
            _speedCol = speedCol;
            _speedRow = speedRow;
        }

        public void Show()
        {
            SetColor();
            Console.CursorLeft = Convert.ToInt32(_col);
            Console.CursorTop = Convert.ToInt32(_row);
            Console.Write("O");
        }

        protected virtual void SetColor()
        {
        }

        public void Move()
        {
            _col += _speedCol;
            _row += _speedRow;
            UpdateSpeedAndPosition();
        }

        protected abstract void UpdateSpeedAndPosition();
    }
}
