using System;

namespace ChallengeBaekjone
{
    public class Baekjone1934
    {
        public static void Problem()
        {
            var N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; ++i)
            {
                var input = Console.ReadLine().Split(' ');
                var A = int.Parse(input[0]);
                var B = int.Parse(input[1]);
                var a = A;
                var b = B;
                while (a != b)
                {
                    if (a < b)
                        a += A;
                    else
                        b += B;
                }
                Console.WriteLine(a);
            }
        }
    }
}