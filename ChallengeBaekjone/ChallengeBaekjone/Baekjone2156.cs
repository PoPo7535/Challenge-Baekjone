using System;
using System.IO;

namespace ChallengeBaekjone
{
    public class Baekjone2156
    {
        public static void Problem()
        {
            var sr = new StreamReader(Console.OpenStandardInput());
            var sw = new StreamWriter(Console.OpenStandardOutput());
            var N = int.Parse(sr.ReadLine());
            var wine = new int[N];
            var dp = new int[N];
            if (1 <= N)
                dp[0] = wine[0] = int.Parse(sr.ReadLine());
            if (2 <= N)
            {
                wine[1] = int.Parse(sr.ReadLine());
                dp[1] = wine[0] + wine[1];
            }
            if (3 <= N)
            {
                wine[2] = int.Parse(sr.ReadLine());
                dp[2] = Max(wine[0] + wine[1], wine[1] + wine[2], wine[0] + wine[2]);
            }
            if (3 < N)
            {
                for (int i = 3; i < N; ++i)
                {
                    wine[i] = int.Parse(sr.ReadLine());
                    dp[i] = Max(
                        dp[i - 1], 
                        dp[i - 2] + wine[i], 
                        dp[i - 3] + wine[i - 1] + wine[i]);
                }
            }
            sw.WriteLine(dp[N - 1]);
            sr.Close();
            sw.Close();
        }
        public static int Max(int a, int b, int c)
        {
            if (b <= a && c <= a)
                return a;
            if (a <= b && c <= b)
                return b;
            return c;
        }
    }
}