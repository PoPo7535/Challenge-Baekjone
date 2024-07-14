using System;

namespace ChallengeBaekjone
{
    public class Baekjone2559
    {
        public static void Problem()
        {
            var input = Console.ReadLine().Split();
            var N = int.Parse(input[0]);
            var K = int.Parse(input[1]);
            var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            var maxVal = 0;
            for (int i = 0; i < K; ++i)
                maxVal += arr[i];
            var dp = maxVal;
            for (int i = K; i < N; ++i)
            {
                dp = dp + arr[i] - arr[i - K];
                if (maxVal < dp)
                    maxVal = dp;
            }
            Console.WriteLine(maxVal);
        }
    }
}