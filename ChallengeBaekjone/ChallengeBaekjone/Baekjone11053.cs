using System;
using System.IO;

namespace ChallengeBaekjone
{
    public class Baekjone11053
    {
        public static void Problem()
        {
            var sr = new StreamReader(Console.OpenStandardInput());
            var sw = new StreamWriter(Console.OpenStandardOutput());
            int n = int.Parse(sr.ReadLine());
            int[] arr = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int[] dp = new int[n];

            for (int i = 0; i < n; i++)
            {
                dp[i] = 1; 
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                    }
                }
            }

            sw.WriteLine(Max(dp));
            sr.Close();
            sw.Close();
        }
        static int Max(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }
    }
}