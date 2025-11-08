using System;

namespace ChallengeBaekjone.Properties
{
    public class Baekjone10844
    {
        public class Baekjone10989
        {
            private static int maxDeepCount;
            private static long[,] dp; // [자릿수][끝자리 숫자]
            static void Problem()
            {
                int inputCount = int.Parse(Console.ReadLine() ?? string.Empty);
                maxDeepCount = inputCount;
                dp = new long[maxDeepCount + 1, 10];

                long result = 0;
                for (int i = 1; i < 10; ++i)
                    result = (result + StairsNum(i, 1)) % 1000000000;

                Console.Write(result);
            }

            static long StairsNum(int num, int depth)
            {
                if (depth == maxDeepCount)
                    return 1;

                if (dp[depth, num] != 0)
                    return dp[depth, num];

                long count = 0;
                if (num > 0)
                    count = (count + StairsNum(num - 1, depth + 1)) % 1000000000;
                if (num < 9)
                    count = (count + StairsNum(num + 1, depth + 1)) % 1000000000;

                dp[depth, num] = count;
                return count;
            }

        }
    }
}