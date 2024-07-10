using System;

namespace ChallengeBaekjone
{
    public class Baekjone2579
    {
        public static void Problem()
        {
            var n = int.Parse(Console.ReadLine());
            var stairs = new int[n];
            for (int i = 0; i < n; i++)
            {
                stairs[i] = int.Parse(Console.ReadLine());
            }
            if (n == 1)
            {
                Console.WriteLine(stairs[0]);
                return;
            }
            if (n == 2)
            {
                Console.WriteLine(stairs[0] + stairs[1]);
                return;
            }
            var dp = new int[n];
            dp[0] = stairs[0];
            dp[1] = stairs[0] + stairs[1];
            dp[2] = Math.Max(stairs[0] + stairs[2], stairs[1] + stairs[2]);
            for (int i = 3; i < n; i++)
                dp[i] = Math.Max(dp[i - 2] + stairs[i], dp[i - 3] + stairs[i - 1] + stairs[i]);
            Console.WriteLine(dp[n - 1]);
        }
    }
}