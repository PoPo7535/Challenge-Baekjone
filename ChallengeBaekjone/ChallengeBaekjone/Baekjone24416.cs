using System;

namespace ChallengeBaekjone
{
    public class Baekjone24416
    {
        static void Problem()
        {
            var N = int.Parse(Console.ReadLine());
            Console.WriteLine($"{Fibonacci(N)} {N-2}");
        }
        static long Fibonacci(int n)
        {
            if (n <= 1) return n;
            long a = 0;
            long b = 1;
            long c = 0;
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }
    }
}