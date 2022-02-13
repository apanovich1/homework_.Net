using System;
class SamplesArray1
{

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your full name: ");
        string text = Console.ReadLine();
        string[] textSplit = text.Split(" ");
        string firstWord = textSplit.First();
        string secondWord = textSplit.Last();
        string Items = secondWord + ' ' + firstWord;
        Console.WriteLine(Items);
    }
}