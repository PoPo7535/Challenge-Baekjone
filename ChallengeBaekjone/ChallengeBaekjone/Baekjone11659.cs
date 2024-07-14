using System;
using System.IO;
using System.Linq;
using System.Text;

namespace ChallengeBaekjone
{
    public class Baekjone11659
    {
        public static void Problem()
        {
            var sr = new StreamReader(Console.OpenStandardInput());
            var sw = new StreamWriter(Console.OpenStandardOutput());
            var inputs = sr.ReadLine().Split().Select(int.Parse).ToArray();
            var N = inputs[0];
            var M = inputs[1];
            var arr = sr.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 1; i < N; ++i)
                arr[i] += arr[i - 1];
            for (int i = 0; i < M; ++i)
            {
                var len = sr.ReadLine().Split().Select(int.Parse).ToArray();
                var val = len[0] - 2 < 0 ? 0 : arr[len[0] - 2];
                var result = arr[len[1] - 1] - val;
                sw.WriteLine(result);
            }
            sr.Close();
            sw.Close();
        }
    }
}