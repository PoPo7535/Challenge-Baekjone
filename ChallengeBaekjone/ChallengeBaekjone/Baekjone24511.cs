using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ChallengeBaekjone
{
    public class Baekjone24511
    {
        public static void Problem()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            var N = int.Parse(sr.ReadLine());
            var A = sr.ReadLine().Split(' ');
            var B = sr.ReadLine().Split(' ');
            var list = new LinkedList<int>();
            for (var i = 0; i < N; ++i)
            {
                if (A[i][0] == '0')
                    list.AddLast(int.Parse(B[i]));
            }
            var M = int.Parse(sr.ReadLine());
            var C = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
            using (var writer = new StreamWriter(Console.OpenStandardOutput(), Encoding.Default, bufferSize: 1024))
            {
                list.AddLast(int.MaxValue);
                var lastNode = list.Last;
                for (int i = 0; i < M; ++i)
                {
                    list.AddFirst(C[i]);
                    lastNode = lastNode.Previous;
                    writer.Write($"{lastNode.Value} ");
                }
            }
            sr.Close();
        }
    }
}