using System;

namespace ChallengeBaekjone
{
    public class Baekjone25501
    {
        public static void Problem()
        {
            var N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; ++i)
            {
                var str = Console.ReadLine();
                var result = Recursion(str, str.Length - 1);
                Console.WriteLine($"{result.Item1} {result.Item2}");
            }
            
            (int,int) Recursion(string s,  int r, int l = 0, int count = 1)
            {
                if (l >= r) return (1, count);
                if (s[l] != s[r]) return (0, count);
                return Recursion(s,  r - 1, l + 1,++count);
            }
        }
    }
}