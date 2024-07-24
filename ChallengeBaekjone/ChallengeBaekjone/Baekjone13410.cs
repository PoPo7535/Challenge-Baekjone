using System;
using System.Text;

namespace ChallengeBaekjone
{
    public class Baekjone13410
    {
        static void Problem()
        {
            var str= Console.ReadLine().Split();
            var N = int.Parse(str[0]);
            var M = int.Parse(str[1]);
            var max = int.MinValue;
            StringBuilder sb ;
            for (int i = 1; i <= M; ++i)
            {
                var val = 0;
                sb = new StringBuilder((N * i).ToString());
                for (int j = 0; j < sb.Length; ++j)
                    val += (int)Math.Pow(10, sb.Length - j) * (sb[sb.Length -j- 1] - '0');
                val /= 10;
                if (max < val)
                    max = val;
            }
            Console.WriteLine(max);
        }
    }
}