using System;

namespace ChallengeBaekjone
{
    public class Baekjone1924
    {
        static void Problem()
        {
            var str = new[] { "SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT" };
            var days = new[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            var input = Console.ReadLine().Split();
            var x = int.Parse(input[0]);
            var day = int.Parse(input[1]);
            for (int i = 0; i < x - 1; ++i)
                day += days[i];
            Console.WriteLine(str[day % 7]);
        }
    }
}