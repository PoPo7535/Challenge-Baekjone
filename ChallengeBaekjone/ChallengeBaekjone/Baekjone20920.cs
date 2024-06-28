using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ChallengeBaekjone
{
    public class Baekjone20920
    {
        public static void Problem()
        {
            var inputs = Console.ReadLine().Split(' ');
            var N = int.Parse(inputs[0]);
            var M = int.Parse(inputs[1]);
            var dic = new Dictionary<string, int>();
            for (int i = 0; i < N; ++i)
            {
                var input = Console.ReadLine();
                if(input.Length < M)
                    continue;
                if (dic.ContainsKey(input))
                    ++dic[input];
                else
                    dic.Add(input, 1);
            }
            var list = dic.ToList();
            list.Sort((a, b) =>
            {
                var com = b.Value.CompareTo(a.Value);
                if (0 != com)
                    return com;
                com = b.Key.Length.CompareTo(a.Key.Length);
                if (0 != com)
                    return com;
                return string.Compare(a.Key, b.Key, StringComparison.Ordinal);
            });
            using (var writer = new StreamWriter(Console.OpenStandardOutput(), Encoding.Default, bufferSize: 1024))
            {
                for (int i = 0; i < list.Count; ++i)
                {
                    writer.WriteLine(list[i].Key);
                }
            }
        }
    }
}