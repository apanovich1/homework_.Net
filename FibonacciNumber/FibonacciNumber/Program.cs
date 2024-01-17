using System.Numerics;
class FibonacciNth
{
    public static BigInteger Fibonacci(int num)
    {
        var previousValue = new BigInteger(-1);
        var currentResult = new BigInteger(1);

        for (var i = 0; i <= num; ++i)
        {
            var sum = currentResult + previousValue;
            previousValue = currentResult;
            currentResult = sum;
        }

        return currentResult;
    }
    public static void Main()
    {
       Console.WriteLine("Insert your fib nth(0-200): ");
       var num = Int32.Parse(Console.ReadLine());
       Console.WriteLine(Fibonacci(num));
    }

}
