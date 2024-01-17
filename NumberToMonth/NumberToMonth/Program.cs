using System.Globalization;
class P
{
    static void Main(string[] args)
    {
        Console.Write("Enter Month Number (1 - 12): ");
        var monthNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(GetFullName(monthNumber));
    }
    static string GetFullName(int month)
    {
        DateTime date = new DateTime(2022, month, 1);

        return date.ToString("MMMM");
    }
}
