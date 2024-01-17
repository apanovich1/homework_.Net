/*Create a function that takes a string's characters as ASCII and
returns each character's hexadecimal value as a string.Each byte
must be seperated by a space. All alpha hex characters must be lowercase.*/
using System.Text;

class ConvertToHex
{
    public static void Main()
    {
        Console.WriteLine("Insert your phrase: ");
        string value = Console.ReadLine();

        byte[] hexCode = Encoding.Default.GetBytes(value);
        var hexString = BitConverter.ToString(hexCode);
        hexString = hexString.Replace("-", " ");

        Console.WriteLine(hexString.ToLower());
    }
}