using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] socks = new string[5] { "A", "B", "C", "A", "B"};
            int result = 0;
            foreach (string sock in socks)
            if (socks[0] == socks[1])
                {
                    result++;
                }
            if (socks[0] == socks[2])
            {
                result++;
            }
            if (socks[0] == socks[3])
            {
                result++;
            }
            if (socks[0] == socks[4])
            {
                result++;
            }
            if (socks[0] == socks[5])
            {
                result++;
            }
            if (socks[1] == socks[2])
            {
                result++;
            }
            if (socks[1] == socks[3])
            {
                result++;
            }
            if (socks[1] == socks[4])
            {
                result++;
            }
            if (socks[1] == socks[5])
            {
                result++;
            }
            if (socks[2] == socks[3])
            {
                result++;
            }
            if (socks[2] == socks[4])
            {
                result++;
            }
            if (socks[2] == socks[5])
            {
                result++;
            }
            if (socks[3] == socks[4])
            {
                result++;
            }
            if (socks[3] == socks[5])
            {
                result++;
            }

            Console.WriteLine(result);
        }
    }
}

