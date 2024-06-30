using System;

namespace ChallengeBaekjone
{
    public class Baekjone24265
    {
        public static void Problem()
        {
            var n = long.Parse(Console.ReadLine());
            var sum = 0L;
            while (n!=0)
            {
                --n;
                sum += n;
            }
            Console.WriteLine($"{sum}\n{2}");
        }
    }
}