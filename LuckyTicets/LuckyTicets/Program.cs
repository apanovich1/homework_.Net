
namespace LuckyTicket
{
    class LuckyTicket
    {
        public static void Main()
        {
            long n = 4;
            long half = n / 2;
            var luckyTickets = new LuckyTicket();
            Console.WriteLine(luckyTickets.Run(half));
        }
        long count = 0;
        public long Run(long half)
        {
            RecursionSeach(half, 0, 0);
            return count;
        }

        public void RecursionSeach(long half, int sumA, int sumB)
        {
            if (half == 0)
            {
                if (sumA == sumB)
                {
                    count++;
                }
                return;
            }

            for (int a = 0; a <= 9; a++)
            {
                for (int b = 0; b <= 9; b++)
                {
                    for (b = 0; b <= 9; b++)
                    {
                        RecursionSeach(half - 1, sumA + a, sumB + b);
                    }
                }
            }
        }
    }
}
