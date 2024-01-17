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

        var allNames = String.Join(" ", peopleInLine, name).Split(" ");
        var sortedNames = allNames.OrderBy(c => c).ToArray();
        var indexOfName = Array.IndexOf(sortedNames, name);

        var time = ((indexOfName / availableAgents) +1) * 20;
        Console.WriteLine(time);
    }
}