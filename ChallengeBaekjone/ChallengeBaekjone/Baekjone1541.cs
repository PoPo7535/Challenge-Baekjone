using System;
using System.IO;
using System.Linq;

namespace ChallengeBaekjone
{
    public class Baekjone1541
    {
        void Problem()
        {
            var sr = new StreamReader(Console.OpenStandardInput());
            var sw = new StreamWriter(Console.OpenStandardOutput());
            var input = sr.ReadLine();
            var parts = input.Split('-');
            var result = 0;
            for (int i = 0; i < parts.Length; i++)
            {
                int sum = parts[i].Split('+').Select(int.Parse).Sum();
                if (i == 0)
                    result += sum;
                else
                    result -= sum;
            }
            sw.WriteLine(result);
            sr.Close();
            sw.Close();
        }
    }
}