using System;
using System.Text;

namespace ChallengeBaekjone
{
    public class Baekjone1032
    {
        public static void Problem()
        {
            var N = int.Parse(Console.ReadLine());
            if (N == 0)
                return;
            var sb = new StringBuilder(Console.ReadLine());
            for (int i = 0; i < N - 1; ++i)
            {
                var str = Console.ReadLine();
                for (int j = 0; j < sb.Length; ++j)
                {
                    if (sb[j] != str[j])
                        sb[j] = '?';
                }
            }
            Console.WriteLine(sb);
        }
    }
}