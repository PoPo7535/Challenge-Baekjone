using System;
using System.Linq;

namespace ChallengeBaekjone
{
    public class Baekjone13018
    {
        void Problem()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0];
            int k = input[1];
            if (n == 1)
            {
                Console.WriteLine(k == 0 ? "1" : "Impossible");
                return;
            }
            if (k == n)
            {
                Console.WriteLine("Impossible");
                return;
            }
            int[] a = new int[n + 1];
            for (int i = 1; i <= n; i++)
                a[i] = i;
            for (int i = 1; i <= n - 1 - k; i++)
                (a[i], a[i + 1]) = (a[i + 1], a[i]);
            Console.WriteLine(string.Join(" ", a.Skip(1)));
        }
    }
}