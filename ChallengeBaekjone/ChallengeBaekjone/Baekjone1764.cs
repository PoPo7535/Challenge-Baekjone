using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ChallengeBaekjone.Properties
{
    public class Baekjone1764
    {
        public static void Problem()
        {
            var input = Console.ReadLine().Split(' ');
            var N = int.Parse(input[0]);
            var M = int.Parse(input[1]);
            var hashSet1 = new HashSet<string>();
            var hashSet2 = new HashSet<string>();
            for (int i = 0; i < N; ++i)
                hashSet1.Add(Console.ReadLine());
            for (int i = 0; i < M; ++i)
                hashSet2.Add(Console.ReadLine());
            using (var writer = new StreamWriter(Console.OpenStandardOutput(), Encoding.Default, bufferSize: 1024))
            {
                var list = hashSet1.Where(str => hashSet2.Contains(str)).ToList();
    
                list.Sort();
                writer.WriteLine(list.Count);
                foreach (var str in list)
                    writer.WriteLine(str);
            }
        }
    }
}