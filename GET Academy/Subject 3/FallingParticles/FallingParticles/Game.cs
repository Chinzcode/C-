using System;
using static System.Formats.Asn1.AsnWriter;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Reflection;

namespace FallingParticles
{
    internal class Game
    {
        private InputManager _inputManager;
        private Render _render;
        private List<Particle> _particles;
        private bool _isGameOver = false;
        private int _level;
        private int _score;
        private int _gameRoundsBetweenSpawn;
        private Random _random = new Random();
        private Paddle _paddle;

        public Game()
        {
            _inputManager = new InputManager();
            _render = new Render();

            int centerX = Console.WindowWidth / 2;
            int moveDistanse = 6;
            int initialPos = centerX - (centerX % moveDistanse);
            string paddleStr = "========";

            _particles = new List<Particle>();
            _paddle = new Paddle(initialPos, paddleStr, moveDistanse);
            InitializeGame();
        }

        public void InitializeGame()
        {
            _particles.Clear();
            _isGameOver = false;
            _score = 0;
            _level = 1;
            InitGameRoundsBetweenSpawn();
        }

        public void InitGameRoundsBetweenSpawn()
        {
            _gameRoundsBetweenSpawn = 50 / _level;
        }

        public void Run()
        {
            while (true)
            {
                var levelCount = 0;
                var roundCount = 45;

                while (!_isGameOver)
                {
                    DrawGame();
                    _paddle.MovePaddle();
                    MoveParticles();
                    var hasLostParticle = CheckLostParticle();

                    if (hasLostParticle)
                    {
                        _render.DrawGameOverMessage();
                        Console.ReadLine();
                        InitializeGame();
                        break;
                    }
                    if (roundCount >= _gameRoundsBetweenSpawn)
                    {
                        SpawnParticles();
                        InitGameRoundsBetweenSpawn();
                        roundCount = 0;
                    }
                    roundCount++;
                    levelCount++;

                    if (levelCount == 100)
                    {
                        levelCount = 0;
                        _level++;
                    }
                    Thread.Sleep(100);
                }
            }
        }

        public void DrawGame()
        {
            Console.Clear();
            _render.DrawScoreAndLevel(_score, _level);
            _render.DrawPaddle(_paddle);
            _render.DrawParticles(_particles);
        }

        public void SpawnParticles()
        {
            int randomParticle = _random.Next(0, Console.WindowWidth);
            var newParticle = new Particle(randomParticle, 0);
            _particles.Add(newParticle);
        }

        public void MoveParticles()
        {
            List<Particle> particlesToRemove = new List<Particle>();

            foreach (var particle in _particles)
            {
                particle.UpdatePosition(0, 0.5f);

                if (particle.IsOutOfBounds(Console.WindowHeight))
                {
                    _score++;
                    particlesToRemove.Add(particle);
                }

            }

            foreach (var particleToRemove in particlesToRemove)
            {
                _particles.Remove(particleToRemove);
            }
        }

        private bool CheckLostParticle()
        {
            foreach (var particle in _particles)
            {
                if ((particle.X < _paddle.Position ||
                     particle.X > _paddle.Position + _paddle.PaddleStr.Length)
                    && particle.Y == Console.WindowHeight - 1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}