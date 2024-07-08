using System;
using System.Linq;

namespace ChallengeBaekjone
{
    public class Baekjone1912
    {
        static void Problem()
        {
            var N = int.Parse(Console.ReadLine());
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var maxValue = arr[0];
            var previous = 0;
            for (int i = 0; i < N; ++i)
            {

                if (arr[i] < previous + arr[i])
                    previous += arr[i];
                else
                    previous = arr[i];
                if (maxValue < previous)
                    maxValue = previous;
            }
            Console.WriteLine(maxValue);
        }
    }
}