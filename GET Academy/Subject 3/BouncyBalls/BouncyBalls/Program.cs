using BouncyBalls;

var balls = new Ball[]
{
    new Ball(15, 3, 1, 1, BallType.BouncingInWalls),
    new Ball(15, 5, -1, 1, BallType.Teleporting),
    new Ball(15, 7, 1, 1, BallType.BouncingWithGravity),
};
Console.CursorVisible = false;
while (true)
{
    Console.Clear();
    foreach (var ball in balls)
    {
        ball.Show();
        ball.Move();
    }
    Thread.Sleep(50);
}