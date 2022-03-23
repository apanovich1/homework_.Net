/*Create a function that returns the letter position that the ball is at, once I finish swapping the cups.
The swaps will be given to you as an array.
A swap could be notated in two different ways, since both ways end up with the same outcome.
All swaps will be notated as capital letters and will be valid.
You cannot swap a cup with itself.*/

class Cups
{
    static void Main()
    {
        var currentPosition = "b";

        Console.WriteLine("Insert your swaps: ");
        var movementsInput = Console.ReadLine();

        if (movementsInput == null)
        {
            throw new Exception();
        }
        var movements = movementsInput.Split(" ").ToList();

        foreach (var move in movements)
        {
            if (move.Contains(currentPosition))
            {
                var nextPosition = move.Replace(currentPosition, "");
                currentPosition = nextPosition;
            }
            if (!move.Contains(currentPosition))
            {
                continue;
            }
        }
        Console.WriteLine(currentPosition);
    }
}