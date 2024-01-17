using System.Text.RegularExpressions;
public class CensoredString
{
    public static void Main()
    {
        string input = "Wh*r* d*d my v*w*ls g*?";
        ReplaceVowels(input, "eeioeo");
    }

    public static string ReplaceVowels(string input, string withVowels)
    {
        string pattern = "\\*";
        Regex regex = new Regex(pattern);
        foreach (var letter in withVowels)
        {
            input = regex.Replace(input, letter.ToString(), 1);
        }

        return input;
    }
}
