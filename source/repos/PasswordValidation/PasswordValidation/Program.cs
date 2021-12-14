using System.Text.RegularExpressions;
class Program
{
    public static void Main()
    {
        Console.WriteLine("Insert your pass: ");
        string password = Console.ReadLine();
        var input = password;

        var hasMinimumChars = new Regex(@".{6,24}");
        var hasLowerCase = new Regex(@"[a-z]");
        var hasUpperChar = new Regex(@"[A-Z]");
        var hasNumber = new Regex(@"[0-9]");
        var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
        var hasRepeatedChars = new Regex(@"(.)\1\1\1");


        var isValidated = hasMinimumChars.IsMatch(input) &&
                          hasLowerCase.IsMatch(input) &&
                          hasUpperChar.IsMatch(input) &&
                          hasNumber.IsMatch(input) &&
                          hasSymbols.IsMatch(input) &&
                          !hasRepeatedChars.IsMatch(input);

        Console.WriteLine(isValidated);
    }
}