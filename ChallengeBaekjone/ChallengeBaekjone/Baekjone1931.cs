using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ChallengeBaekjone
{
    public class Baekjone1931
    {
        void Problem()
        {
            var sr = new StreamReader(Console.OpenStandardInput());
            var sw = new StreamWriter(Console.OpenStandardOutput());
            var t=  int.Parse(sr.ReadLine());
            var list = new List<(int start, int end)>(t);
            for (int i = 0; i < t; i++)
            {
                var str = sr.ReadLine().Split(' ');
                list.Add((int.Parse(str[0]), int.Parse(str[1])));
            }
            list = list
                .OrderBy(m => m.end)
                .ThenBy(m => m.start)
                .ToList();
            int count = 0;
            int endTime = 0;
            foreach (var value in list)
            {
                if (value.start >= endTime)
                {
                    count++;
                    endTime = value.end;
                }
            }
            sw.WriteLine(count);
            sr.Close();
            sw.Close();
        }
    }
}