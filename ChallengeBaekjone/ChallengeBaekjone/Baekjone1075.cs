using System;
using System.IO;

namespace ChallengeBaekjone
{
    public class Baekjone1075
    {
        public static void Problem()
        {
            var sr = new StreamReader(Console.OpenStandardInput());
            var sw = new StreamWriter(Console.OpenStandardOutput());
            var N = sr.ReadLine();
            var F = int.Parse(sr.ReadLine());
            var val = int.Parse(N.Substring(0, N.Length - 2)) * 100;
            var n = val % F;
            sw.WriteLine(n == 0 ? "00" : F - n < 10 ? $"0{F - n}" : $"{F - n}");
            sr.Close();
            sw.Close();
        }
    }
}