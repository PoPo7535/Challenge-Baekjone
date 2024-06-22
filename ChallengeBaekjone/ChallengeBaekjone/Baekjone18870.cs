using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ChallengeBaekjone
{
    public class Baekjone18870
    {
        public static void Problem()
        {
            var N = int.Parse(Console.ReadLine());
            var dic = new Dictionary<int, int>();
            var arr = new int[N];
            var split = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; ++i)
                arr[i] = int.Parse(split[i]);
            var dis = arr.Distinct().ToArray();
            Array.Sort(dis);
            for (int i = 0; i < dis.Length; ++i)
                dic.Add(dis[i], i);
            using (StreamWriter writer = new StreamWriter(Console.OpenStandardOutput(), Encoding.Default, bufferSize: 1024))
            {
                for (int i = 0; i < arr.Length; ++i)
                {
                    writer.Write($"{dic[arr[i]]} ");
                }
            }
        }
    }
}