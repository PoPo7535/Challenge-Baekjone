using System;

namespace ChallengeBaekjone
{
    public class Baekjone24313
    {
        public static void Problem()
        {
            var input = Console.ReadLine().Split();
            var a1 = int.Parse(input[0]);
            var a0 = int.Parse(input[1]);
            var c = int.Parse(Console.ReadLine());
            var n0 = int.Parse(Console.ReadLine());
            if (a1 <= c && a0 <= (c - a1) * n0)
                Console.WriteLine(1);
            else
                Console.WriteLine(0);
        }
    }
}