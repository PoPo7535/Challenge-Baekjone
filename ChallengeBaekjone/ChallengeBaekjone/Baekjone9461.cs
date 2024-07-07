using System;

namespace ChallengeBaekjone
{
    public class Baekjone9461
    {
        public static void Problem()
        {
            var dp = new long[101];
            dp[1] = dp[2] = dp[3] = 1;
            dp[4] = dp[5] = 2;
            for (int i = 6; i < 101; ++i)
                dp[i] = dp[i - 1] + dp[i - 5];
            var N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; ++i)
                Console.WriteLine(dp[int.Parse(Console.ReadLine())]);
        }
    }
}