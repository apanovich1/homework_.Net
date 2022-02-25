/*A hex code must begin with a pound key # and is exactly 6 characters in length.
Each character must be a digit from 0-9 or an alphabetic character from A-F.
All alphabetic characters may be uppercase or lowercase.*/

using System.Text.RegularExpressions;

class ValidHexCode
{
    static void Main()
    {
        Console.WriteLine("Insert your Hexcode: ");
        var input = Console.ReadLine();

        var reg = new Regex(@"^#([0-9a-fA-F]){6}$");
        if (!reg.IsMatch(input))
        {
            Console.WriteLine($"{input} is invalid");
        }
        else
        {
            Console.WriteLine($"{input} is valid");
        }
    }
}