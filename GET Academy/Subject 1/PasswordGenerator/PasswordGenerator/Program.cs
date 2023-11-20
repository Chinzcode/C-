namespace PasswordGenerator
{
    internal class Program
    {
        static readonly Random Random = new Random();

        static void Main(string[] args)
        {
            if (!IsValid(args))
            {
                ShowHelpText();
                return;
            }

            void ShowHelpText()
            {
                Console.WriteLine("PasswordGenerator  \r\nOptions:\r\n- l = liten bokstav\r\n- L = stor bokstav\r\n- d = siffer\r\n- s = spesialtegn (!\"#\u00a4%&/(){}[]\r\nEksempel: PasswordGenerator 14 lLssdd\r\n    betyr\r\n        Min. 1 liten bokstav\r\n        Min. 1 1 stor bokstav\r\n        Min. 2 spesialtegn\r\n        Min. 2 sifre\r\n        Lengde på passordet skal være 14");
            }

            Console.WriteLine(ReturnGeneratedPassword(args));
        }
        static bool IsValid(string[] args)
        {
            var charOptions = "Llds";

            if (args.Length != 2) return false;

            foreach (var digit in args[0]) if (!char.IsDigit(digit)) return false;

            foreach (var letter in args[1]) if (!charOptions.Contains(letter)) return false;

            return true;
        }

        private static string ReturnGeneratedPassword(string[] args)
        {
            var length = Convert.ToInt32(args[0]);
            var pattern = args[1].PadRight(length, 'l');
            var specialChars = "!#&()=?{}[]";
            var password = "";

            while (pattern.Length > 0)
            {
                var randomNumb = Random.Next(0, pattern.Length - 1);
                var removedChar = pattern[randomNumb];
                pattern = pattern.Remove(randomNumb, 1);

                if (removedChar == 'L') password += WriteRandomUpperCaseLetter();
                else if (removedChar == 'l') password += WriteRandomLowerCaseLetter();
                else if (removedChar == 'd') password += WriteRandomDigit();
                else if (removedChar == 's') password += WriteRandomSpecialCharacter();
            }

            char WriteRandomUpperCaseLetter() => GetRandomLetter('A', 'Z');

            char WriteRandomLowerCaseLetter() => GetRandomLetter('a', 'z');

            int WriteRandomDigit() => Random.Next(0, 9);

            char WriteRandomSpecialCharacter() => specialChars[Random.Next(0, specialChars.Length - 1)];

            return password;
        }

        static char GetRandomLetter(char min, char max) => (char)Random.Next(min, max);
    }
}