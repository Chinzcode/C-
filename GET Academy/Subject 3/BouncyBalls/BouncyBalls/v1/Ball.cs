//namespace BouncyBalls
//{
//    internal class Ball
//    {
//        protected float _col;
//        protected float _row;
//        protected float _speedCol;
//        protected float _speedRow;

//        public Ball(int col, int row, int speedCol, int speedRow)
//        {
//            _col = col;
//            _row = row;
//            _speedCol = speedCol;
//            _speedRow = speedRow;
//        }

//        public virtual void Show(bool changeColor = true)
//        {
//            Console.CursorLeft = Convert.ToInt32(_col);
//            Console.CursorTop = Convert.ToInt32(_row);
//            Console.Write("O");
//        }

//        public virtual void Move()
//        {
//            _col += _speedCol;
//            _row += _speedRow;
//        }
//    }
//}