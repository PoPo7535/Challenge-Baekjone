using System;
using System.Collections.Generic;

namespace ChallengeBaekjone
{
    public class Baekjone2485
    {
        public static void Problem()
        {
            var N = int.Parse(Console.ReadLine());
            var list = new List<int>();
            for (int i = 0; i < N; ++i)
                list.Add(int.Parse(Console.ReadLine()));
            list.Sort();
            var gcd = list[1] - list[0];
            for (int i = 2; i < list.Count; ++i)
                gcd = GCD(gcd, list[i] - list[i - 1]);
            var result = 0;
            for (int i = 1; i < list.Count; ++i)
                result += (list[i] - list[i - 1]) / gcd - 1;
            Console.WriteLine(result);
            int GCD(int a, int b)
            {
                while (b != 0)
                {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }
                return a;
            }
        }
    }
}