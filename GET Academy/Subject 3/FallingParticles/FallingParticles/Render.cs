namespace FallingParticles
{
    internal class Render
    {
        public void DrawScoreAndLevel(int score, int level)
        {
            Console.SetCursorPosition(60, 0);
            Console.Write($"Score: {score}");
            Console.SetCursorPosition(71, 0);
            Console.Write($"Level: {level}");
        }

        public void DrawPaddle(Paddle paddle)
        {
            Console.SetCursorPosition(paddle.Position, Console.WindowHeight - 1);
            Console.Write(paddle.PaddleStr);
        }

        public void DrawParticles(List<Particle> particles)
        {
            foreach (var particle in particles)
            {
                particle.Render();
            }
        }

        public void DrawGameOverMessage()
        {
            var text = "Game Over! Press ENTER to restart";
            Console.SetCursorPosition(40 - text.Length / 2, 5);
            Console.WriteLine(text);
        }
    }
}