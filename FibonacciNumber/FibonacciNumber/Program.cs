//using System.Numerics;
class FibonacciNumber
{
    public static int Fib(int num)
    {
        if (num <= 1)
        {
            return num;
        }
        else
        {
            return Fib(num - 1) + Fib(num - 2);
        }
    }

    public static void Main()
    {
        Console.WriteLine("Insert your number (0-200): ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Fib(num));
    }

}
