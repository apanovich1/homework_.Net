using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    public static void Main()
    {

        int number = 123;
        string numberConverted = Convert.ToString(number);
        string result = new string(numberConverted.ToCharArray().Reverse().ToArray());
        
        Console.WriteLine(result + number);

    }
}