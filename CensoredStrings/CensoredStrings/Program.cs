using System;
using System.Text.RegularExpressions;

public class CensoredString
{
    public static void Main()
    {
        string input = "Wh*r* d*d my v*w*ls g*?";
    }
    public string  ReplaceVowels(string input, string withVowels )
    {
        string pattern = "[eeioeo]";
        Regex regex = new Regex(pattern);
        return regex.Replace(input, withVowels);
    }
}
