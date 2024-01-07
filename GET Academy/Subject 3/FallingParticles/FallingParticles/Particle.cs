namespace FallingParticles
{
    internal class Particle
    {
        public float X { get; private set; }

        public float Y { get; private set; }

        public Particle(float initialX, float initialY)
        {
            X = initialX;
            Y = initialY;
        }

        public void UpdatePosition(float deltaX, float deltaY)
        {
            X += deltaX;
            Y += deltaY;
        }

        public bool IsOutOfBounds(int windowHeight)
        {
            return Y > windowHeight - 1;
        }

        public void Render()
        {
            var particleX = (int)Math.Floor(X);
            var particleY = (int)Math.Floor(Y);
            Console.SetCursorPosition(particleX, particleY);
            Console.Write("O");
        }
    }
}