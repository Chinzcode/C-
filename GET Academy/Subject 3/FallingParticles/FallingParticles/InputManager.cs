namespace FallingParticles
{
    internal class InputManager
    {
        public ConsoleKeyInfo GetKeyInput()
        {
            if (Console.KeyAvailable)
            {
                return Console.ReadKey(true);
            }
            return default(ConsoleKeyInfo);
        }
    }
}