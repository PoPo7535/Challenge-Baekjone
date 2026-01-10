using System;
using System.IO;

namespace ChallengeBaekjone
{
    public class Baekjone13305
    {
        void Problem()
        {
            var sr = new StreamReader(Console.OpenStandardInput());
            var sw = new StreamWriter(Console.OpenStandardOutput());
            var t = int.Parse(sr.ReadLine());
            var dis = new long[t - 1];
            var str = sr.ReadLine().Split(' ');
            for (int i = 0; i < str.Length; i++)
                dis[i] = long.Parse(str[i]);
            str = sr.ReadLine().Split(' ');
            var gasValue = long.Parse(str[0]);
            var result = gasValue * dis[0];
            for (int i = 1; i < str.Length - 1; i++)
            {
                var newGasValue = long.Parse(str[i]);
                if (newGasValue < gasValue)
                    gasValue = newGasValue;
                result += gasValue * dis[i];
            }
            sw.WriteLine(result);
            sr.Close();
            sw.Close();
        }
    }
}