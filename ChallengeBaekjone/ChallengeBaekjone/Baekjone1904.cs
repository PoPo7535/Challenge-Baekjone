using System;

namespace ChallengeBaekjone
{
    public class Baekjone1904
    {
        static void Problem()
        {
            int[] dp = new int[1000001];
            dp[1] = 1;
            dp[2] = 2;
            var N = int.Parse(Console.ReadLine());
            for (int i = 3; i <= N; ++i)
                dp[i] = (dp[i - 1] + dp[i - 2]) % 15746;
            Console.WriteLine(dp[N]);
        }
    }
}