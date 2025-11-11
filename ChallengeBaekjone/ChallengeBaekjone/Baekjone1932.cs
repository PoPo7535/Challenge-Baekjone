using System;
using System.IO;

namespace ChallengeBaekjone
{
    public class Baekjone1932
    {
        public static void Problem()
        {
            var sr = new StreamReader(Console.OpenStandardInput());
            var sw = new StreamWriter(Console.OpenStandardOutput());
            var N = int.Parse(sr.ReadLine() ?? string.Empty);
            var ntriangle = new int[Size(N)];

            var cur = 0;
            for (int i = 0; i < N; ++i)
            {
                cur += i;
                var str = sr.ReadLine().Split(' ');
                ntriangle[cur] = ntriangle[cur - i] + int.Parse(str[0]);
                // sw.Write($"{ntriangle[cur]} ");
                for (int j = 0; j < i; ++j)
                {
                    var num = int.Parse(str[j + 1]);
                    var max = 0;
                    max = ntriangle[cur - i + j] + num;

                    if (j != i - 1)
                        max = Math.Max(max, ntriangle[cur - i + j + 1] + num);

                    ntriangle[cur + j + 1] = max;
                    // sw.Write($"{ntriangle[cur + j + 1]} ");
                }
            }

            var result = ntriangle[cur];
            for (int i = 1; i < N; ++i)
                result = Math.Max(result, ntriangle[cur + i]);

            sw.WriteLine(result);
            sr.Close();
            sw.Close();
        }

        private static int Size(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return n + Size(n - 1);
        }
    }
}