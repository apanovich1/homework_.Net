
class Robot
{
    public static void Main()
    {
        Console.WriteLine("Insert your moves: ");
        var movements = Console.ReadLine();
        var x = 0;
        var y = 0;
        foreach (var move in movements)
        {
            var word = movements.Split(' ');
            var number = Int32.Parse(word[1]);

            if (word[0] == "right")
            {
                x -= number;
            }
            if(word[0] == "left")
            {
                x += number;
            }
            else if(word[0] == "up")
            {
                y += number;
            }
            else
            {
                y -= number;
            }
            Console.WriteLine(x + y);
        }
    }
}