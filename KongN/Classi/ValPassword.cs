using System;
using System.Text.RegularExpressions;

namespace KongN.Classi
{
    internal static class ValPassword
    {
        public static bool ValidatePassword(string password, out string ErrorMessage)
        {


            var input = password;
            ErrorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new Exception("La Password non può essere vuota.");
            }


            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
            if (!hasLowerChar.IsMatch(input))
            {
                ErrorMessage = "La Password deve contenere almeno un carattere minuscolo.";
                return false;
            }
            else if (!hasUpperChar.IsMatch(input))
            {
                ErrorMessage = "La Password deve contenere almeno un carattere maiuscolo.";
                return false;
            }
            else if (!hasMiniMaxChars.IsMatch(input))
            {
                ErrorMessage = "La Password deve essere lunga da un minimo di 8 ad un massimo di 15 caratteri.";
                return false;
            }
            else if (!hasNumber.IsMatch(input))
            {
                ErrorMessage = "La Password deve contenere almeno un numero.";
                return false;
            }

            else if (!hasSymbols.IsMatch(input))
            {
                ErrorMessage = "La Password deve contenere almeno un simbolo speciale (es. @!#$£).";
                return false;
            }
            else
            {
                return true;
            }

        }

    }
}
