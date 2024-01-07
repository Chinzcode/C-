namespace FallingParticles
{
    internal class Paddle
    {
        private InputManager _inputManager;
        public int Position { get; set; }
        public string PaddleStr { get; private set; }
        private readonly int _moveDistance;

        public Paddle(int initialPos, string paddleStr, int moveDistanse)
        {
            _inputManager = new InputManager();
            Position = initialPos;
            PaddleStr = paddleStr;
            _moveDistance = moveDistanse;
        }

        public void MovePaddle()
        {
            var key = _inputManager.GetKeyInput();

            if (key.Key == ConsoleKey.LeftArrow && IsMoveLeft())
            {
                Move(-1);
            }
            else if (key.Key == ConsoleKey.RightArrow && IsMoveRight())
            {
                Move(1);
            }
        }
        public void Move(int direction)
        {
            Position += direction * 3 * PaddleStr.Length / 4;
        }

        public void HandleUserInput(ConsoleKeyInfo key)
        {
            bool moveLeft = key.Key == ConsoleKey.LeftArrow && IsMoveLeft();
            bool moveRight = key.Key == ConsoleKey.RightArrow && IsMoveRight();

            if (moveLeft || moveRight)
            {
                int dirrection = moveLeft ? -1 : 1;
                Position += dirrection * 3 * PaddleStr.Length / 4;
            }
        }

        public bool IsMoveLeft()
        {
            return Position >= _moveDistance;
        }

        public bool IsMoveRight()
        {
            return Position < Console.WindowWidth - PaddleStr.Length;
        }
    }
}
