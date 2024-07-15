using System;
using System.IO;

namespace ChallengeBaekjone
{
    public class Baekjone16139
    {
        public static void Problem()
        {
            var sr = new StreamReader(Console.OpenStandardInput());
            var sw = new StreamWriter(Console.OpenStandardOutput());
            var str = sr.ReadLine();
            var size = 'z' - 'a' + 1;
            var sum = new int[size, str.Length];
            for (int i = 0; i < str.Length; ++i)
            {
                ++sum[str[i] - 'a', i];
                if (i == 0)
                    continue;
                for (var j = 0; j < size; ++j)
                    sum[j, i] += sum[j, i - 1];
            }
            var T = int.Parse(sr.ReadLine());
            for (int i = 0; i < T; ++i)
            {
                var inputs = sr.ReadLine().Split();
                var alpha = inputs[0][0] - 'a';
                var lenA = int.Parse(inputs[1]);
                var lenB = int.Parse(inputs[2]);
                var LenAvalue =
                    lenA == 0 ? 0 :
                    sum[alpha, lenA] == sum[alpha, lenA - 1] ? sum[alpha, lenA] : sum[alpha, lenA] - 1;
                var result = sum[alpha, lenB] - LenAvalue;
                sw.WriteLine(result);
            }
            sr.Close();
            sw.Close();
        }
    }
}