using System;
using System.Collections.Generic;

namespace ChallengeBaekjone
{
    public class Baekjone26069
    {
        public static void Problem()
        {
            var N = int.Parse(Console.ReadLine());
            var rainbow = new HashSet<string> { "ChongChong" };
            for (int i = 0; i < N; ++i)
            {
                var rabbit = Console.ReadLine().Split(' ');
                if (rainbow.Contains(rabbit[0]) || rainbow.Contains(rabbit[1]))
                {
                    rainbow.Add(rabbit[0]);
                    rainbow.Add(rabbit[1]);
                }
            }
            Console.WriteLine(rainbow.Count);
        }
    }
}