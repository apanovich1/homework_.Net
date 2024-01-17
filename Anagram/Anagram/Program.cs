/*Create a function that takes two strings and determines
 if an anagram of the first string is in the second string*/
class Anagram
{
    public static void Main()
    {
        Console.WriteLine("Insert a first word: ");
        string firstWord = Console.ReadLine();
        Console.WriteLine("Insert an anagram: ");
        string secondWord = Console.ReadLine();
        string firstW = String.Concat(firstWord.OrderBy(c => c));
        string secondW = String.Concat(secondWord.OrderBy(c => c));

        bool isContain = secondW.Contains(firstW);
        Console.WriteLine(isContain == true ? "This is anagram!" : "This isn't anagram");

    }
}
