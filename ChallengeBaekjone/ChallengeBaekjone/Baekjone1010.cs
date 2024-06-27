using System;

namespace ChallengeBaekjone
{
    public class Baekjone1010
    {
        public static void Problem()
        {
            var arr = new int[30,30];
            for (int m = 0; m < 30; ++m)
                arr[0, m] = m + 1;
            for (int n = 1; n < 30; ++n)
            {
                for (int m = n; m < 30; ++m)
                {
                    if (m == n)
                        arr[n, m] = 1;
                    else
                        arr[n, m] = arr[n, m - 1] + arr[n - 1, m - 1];
                }
            }
            var T = int.Parse(Console.ReadLine());
            for (int t = 0; t < T; ++t)
            {
                var split = Console.ReadLine().Split(' ');
                var N = long.Parse(split[0]);
                var M = long.Parse(split[1]);
                Console.WriteLine(arr[N - 1, M - 1]);
            }
        }
    }
}