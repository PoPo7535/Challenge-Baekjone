using System;
using System.Linq;

namespace ChallengeBaekjone
{
    public class Baekjone1181
    {
        public static void Problem()
        {
            var N = int.Parse(Console.ReadLine());
            var str = new string[N];
            for (int i = 0; i < N; ++i)
                str[i] = Console.ReadLine();
            str = str.Distinct().ToArray();

            Array.Sort(str, (x, y) =>
            {
                if (x.Length != y.Length)
                    return x.Length.CompareTo(y.Length);
                for (int i = 0; i < x.Length; ++i)
                {
                    if (x[i] == y[i])
                        continue;
                    return x[i].CompareTo(y[i]);
                }
                return 0;
            });

            for (var i = 0; i < str.Length; ++i)
                Console.WriteLine(str[i]);
        }
    }
}