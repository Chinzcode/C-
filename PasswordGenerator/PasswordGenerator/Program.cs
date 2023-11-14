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

            var pattern = args[1];
            var lengthArg = Convert.ToInt32(args[0]);

            while (pattern.Length < lengthArg)
            {
                pattern += 'l';
            }

            while (pattern.Length > 1)
            {
                var randomNumb = Random.Next(0, pattern.Length);
                var removedChar = pattern[randomNumb];
                pattern = pattern.Remove(randomNumb, 1);

                if (removedChar == 'L') WriteRandomUpperCaseLetter();
                else if (removedChar == 'l') WriteRandomLowerCaseLetter();
                else if (removedChar == 'd') WriteRandomDigit();
                else if (removedChar == 's') WriteRandomSpecialCharacter();
            }

            void WriteRandomUpperCaseLetter()
            {
                Console.WriteLine(GetRandomLetter('A', 'Z'));
            }

            void WriteRandomLowerCaseLetter()
            {
                Console.WriteLine(GetRandomLetter('a', 'z'));
            }

            void WriteRandomDigit()
            {
                Console.WriteLine(Random.Next(1,20));
            }

            void WriteRandomSpecialCharacter()
            {
                var specialChars = "!#&()=?{}[]";
                Console.WriteLine(Random.Next(0, 10));
            }
        }

        static bool IsValid(string[] args)
        {
            var charOptions = "Llds";

            if (args.Length != 2) return false;

            foreach (var c1 in args[0]) if (!char.IsDigit(c1)) return false;

            foreach (var c2 in args[1]) if (!charOptions.Contains(c2)) return false;

            return true;
        }

        static char GetRandomLetter(char min, char max)
        {
            return (char)Random.Next(min, max);
        }
    }
}