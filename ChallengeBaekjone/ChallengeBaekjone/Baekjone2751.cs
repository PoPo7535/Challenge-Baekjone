using System;
using System.Text;

namespace ChallengeBaekjone
{
    public class Baekjone2751
    {
        public static void Problem()
        {
            var N = int.Parse(Console.ReadLine());
            var array = new int[N];
            for (int i = 0; i < N; ++i)
                array[i] = int.Parse(Console.ReadLine());
            Array.Sort(array);
            StringBuilder sb = new StringBuilder(string.Join("\n", array));
            Console.WriteLine(sb);
        }
    }
}