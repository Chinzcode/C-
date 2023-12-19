using BouncyBalls;

var balls = new Ball[]
{
    new BouncingBall(15, 3, 1, 1),
    new TeleportingBall(15, 5, -1, 1),
    new BouncingGravityBall(15, 7, 1, 1)
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