using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ChallengeBaekjone
{
    public class Baekjone1620
    {
        public static void Problem()
        {
            var input = Console.ReadLine().Split(' ');
            var N = int.Parse(input[0]);
            var M = int.Parse(input[1]);
            var dic = new Dictionary<string, string>();
            for (int i = 1; i <= N; ++i)
            {
                var name = Console.ReadLine();
                dic.Add(name, i.ToString());
                dic.Add(i.ToString(), name);
            }
            using (var writer = new StreamWriter(Console.OpenStandardOutput(), Encoding.Default, bufferSize: 1024))
            {
                for (int i = 1; i <= M; ++i)
                {
                    var key = Console.ReadLine();
                    writer.WriteLine(dic[key]);
                }
            }
        }
    }
}