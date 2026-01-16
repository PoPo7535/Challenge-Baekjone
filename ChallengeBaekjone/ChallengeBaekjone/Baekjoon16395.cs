using System;
using System.Linq;

namespace ChallengeBaekjone
{
    public class Baekjoon16395
    {
        void Problem()
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var n = arr[0] - 1;
            var k = arr[1] - 1; 
            Console.WriteLine(Cal(n, k));

            static int Cal(int n, int k)
            {
                int result = 1;
                for (int i = 1; i <= k; i++)
                    result = result * (n - i + 1) / i;
                return result;
            }
        }
    }
}