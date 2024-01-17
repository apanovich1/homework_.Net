//Create a function that will handle simple math expressions. The input is an expression in the form of a string.
using System.Data;

public class Program
{
    public static void Main()
    {
        string sentence = "49/7*2-3";
        Console.WriteLine(Calculate(sentence));
    }
    public static object  Calculate(string sentence)
    {
        DataTable dt = new DataTable();
        var result = dt.Compute(sentence, "");
        return result;
    }
}