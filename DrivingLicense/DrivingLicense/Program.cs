/* Your input will be a string of your name me, an integer of the number of available agents,
and a string of the other four names separated by spaces others.
Return the number of minutes it will take to get your license.*/

class DrivingLicense
{
    public static void Main()
    {

        Console.WriteLine("Insert your name: ");
        var name = Console.ReadLine();
        Console.WriteLine("how many agents are available? ");
        var availableAgents = int.Parse(Console.ReadLine());
        Console.WriteLine("Insert names of people in line: ");
        var peopleInLine = Console.ReadLine();

        var allNames = String.Join(" ", peopleInLine, name).ToArray();
        var sortedNames = allNames.Concat(allNames.OrderBy(c => c).ToArray());

        var splittedNames = peopleInLine.Split(" ");
        var indexOfName = Array.IndexOf(splittedNames, name);

        var time = (100 * indexOfName) / availableAgents;
        Console.WriteLine(time);
    }
}