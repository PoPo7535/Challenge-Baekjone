using System;

namespace ChallengeBaekjone
{
    public class Baekjone13241
    {
        public static void Cal(long A, long B)
        {
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

        public static void Problem()
        {
            var input = Console.ReadLine().Split(' ');
            var A = long.Parse(input[0]);
            var B = long.Parse(input[1]);
            Cal(A, B);
        }
    }
}