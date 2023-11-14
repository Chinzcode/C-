namespace PasswordGenerator
{
    internal class Program
    {
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

            void ShowArgsApprovedText()
            {
                Console.WriteLine("Argumenter godkjent");
            }

            ShowArgsApprovedText();

            string pattern = Console.ReadLine() ?? string.Empty;

        }

        static bool IsValid(string[] args)
        {
            string charOptions = "Llds";

            if (args.Length != 2) return false;

            foreach (var c1 in args[0]) if (!char.IsDigit(c1)) return false;

            foreach (var c2 in args[1]) if (!charOptions.Contains(c2)) return false;

            return true;
        }
    }
}