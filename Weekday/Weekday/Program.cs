/*Write a method that when passed a date as year/month/day and returns the date's weekday name in the Dutch culture.
 The culture identifier to use is "nl-NL". Not "nl-BE".*/

using System.Globalization;

class Weekday
{
    public static void Main()
    {
        Console.WriteLine("Insert you bd(yyyy,mm,dd format): ");
        string day = Console.ReadLine();

        DateTime birthday = Convert.ToDateTime(day);
        Console.WriteLine(birthday.ToString("dddd", new CultureInfo("nl-NL")));
    }
}