class Program
{
    static void Main()
    {
        int[] numbers = { 1, 0, 3, 3, 7, 2, 1 };
        int length = numbers.Length;
        var result = numbers.Select(n => n * length);
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }

    }
}
