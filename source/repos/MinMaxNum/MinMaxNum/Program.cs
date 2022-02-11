class Program
{
    static void Main()
    {
        var numbers = new int[] { 1, 213124, 54, 4565676 };
        int maxValue = numbers.Max();
        int minValue = numbers.Min();
        Console.WriteLine($"minimum number = {minValue} \nmaximum number = {maxValue}");
    }

}