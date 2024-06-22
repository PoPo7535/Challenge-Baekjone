using System;
using System.Collections.Generic;

namespace ChallengeBaekjone
{
    public class Baekjone1269
    {
        public static void Problem()
        {
            var input = Console.ReadLine().Split(' ');
            var N = int.Parse(input[0]);
            var M = int.Parse(input[1]);
            var hash1 = new HashSet<int>();
            var hash2 = new HashSet<int>();

            input = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; ++i)
                hash1.Add(int.Parse(input[i]));
            
            input = Console.ReadLine().Split(' ');
            for (int i = 0; i < M; ++i)
                hash2.Add(int.Parse(input[i]));
            
            var count = 0;
            foreach (var num in hash1)
            {
                if (hash2.Contains(num))
                    ++count;
            }
            Console.WriteLine(hash1.Count + hash2.Count - count * 2);
        }
    }
}