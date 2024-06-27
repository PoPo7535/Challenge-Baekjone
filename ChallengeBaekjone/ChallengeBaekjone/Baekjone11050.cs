using System;

namespace ChallengeBaekjone
{
    public class Baekjone11050
    {
        public static void Problem()
        {
            var split = Console.ReadLine().Split(' ');
            var N = long.Parse(split[0]);
            var K = long.Parse(split[1]);
            Console.Write(BinomialCoefficient(N, K));
        }
        static long Factorial(long n)
        {
            long result = 1;
            for (long i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        public static long BinomialCoefficient(long N, long K)
        {
            if (K < 0 || K > N)
                return 0;
            var numerator = Factorial(N);
            var denominator = Factorial(K) * Factorial(N - K);
            if (numerator == 0 || denominator == 0)
                return 0;
            return numerator / denominator;
        }
    }
}