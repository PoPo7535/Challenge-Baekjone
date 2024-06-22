using System;
using System.Collections.Generic;

namespace ChallengeBaekjone
{
    public class Baekjone11478
    {
        public static void Problem()
        {
            var str = Console.ReadLine();
            var hash = new HashSet<string>();
            for (int i = 1; i <= str.Length; ++i)
            {
                for (int j = 0; j < str.Length - i+1; ++j)
                {
                    hash.Add(str.Substring(j, i));
                }
            }
            Console.WriteLine(hash.Count);
        }
    }
}