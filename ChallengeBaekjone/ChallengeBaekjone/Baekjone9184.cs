using System;
using System.Linq;

namespace ChallengeBaekjone
{
    public class Baekjone9184
    {
        static int W(int a, int b, int c)
        {
            if(a <= 0 || b <= 0 || c <= 0)
                return 1; //첫 번째 조건
            if (a > 20 || b > 20 || c > 20)
            {
                a = 20;
                b = 20;
                c = 20;
            }
            return dp[a, b, c];
        }

        static void Cal()
        {
            for (int i = 0; i < Max; ++i)
            {
                for (int j = 0; j < Max; ++j)
                {
                    for (int k = 0; k < Max; ++k)
                    {
                        if (i <= 0 || j <= 0 || k <= 0)
                            dp[i, j, k] = 1;
                        else if (i < j && j < k)
                            dp[i, j, k] =
                                dp[i, j, k - 1] +
                                dp[i, j - 1, k - 1] -
                                dp[i, j - 1, k];
                        else
                            dp[i, j, k] =
                                dp[i - 1, j, k] +
                                dp[i - 1, j - 1, k] +
                                dp[i - 1, j, k - 1] -
                                dp[i - 1, j - 1, k - 1];
                    }
                }
            }
        }
        private const int Max = 21;
        private static int[,,] dp = new int[Max, Max, Max];
        static void Problem()
        {
            Cal();
            while (true)
            {
                var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (numbers[0] == -1 && numbers[1] == -1 && numbers[2] == -1)
                    return;
                var result = W(numbers[0], numbers[1], numbers[2]);
                Console.WriteLine($"w({numbers[0]}, {numbers[1]}, {numbers[2]}) = {result}");
            }
        }
    }
}