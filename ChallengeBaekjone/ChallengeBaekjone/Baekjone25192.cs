using System;
using System.Collections.Generic;

namespace ChallengeBaekjone
{
    public class Baekjone25192
    {
        public static void Problem()
        {
            var hashSet = new HashSet<string>();
            var N = int.Parse(Console.ReadLine());
            var count = 0;
            for (var i = 0; i < N; ++i)
            {
                var input = Console.ReadLine();
                if (input == "ENTER")
                {
                    count += hashSet.Count;
                    hashSet.Clear();
                }
                else
                {
                    hashSet.Add(input);
                }
            }
            Console.WriteLine(count + hashSet.Count);
        }
    }
}