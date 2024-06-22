using System;
using System.Collections.Generic;

namespace ChallengeBaekjone
{
    public class Baekjone14425
    {
        public static void Problem()
        {
            var str = Console.ReadLine().Split(' ');
            var find = new HashSet<string>(); 
            var N = int.Parse(str[0]);
            var M = int.Parse(str[1]);
            for (int i = 0; i < N; ++i)
                find.Add(Console.ReadLine());
            var count = 0;
            for (int i = 0; i < M; ++i)
                count += find.Contains(Console.ReadLine()) ? 1 : 0;
            Console.WriteLine(count);
        }
    }
}