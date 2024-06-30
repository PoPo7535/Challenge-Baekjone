using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ChallengeBaekjone
{
    public class Baekjone15651
    {
        public static void Problem()
        {
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);
            List<int> sequence = new List<int>();
            using (var writer = new StreamWriter(Console.OpenStandardOutput(), Encoding.Default, bufferSize: 1024))
            {
                NM(N, M, sequence, writer);
            }
        }
        static void NM(int N, int M, List<int> sequence, StreamWriter writer)
        {
            if (sequence.Count == M)
            {
                writer.WriteLine(string.Join(" ", sequence));
                return;
            }
            for (int i = 1; i <= N; ++i)
            {
                sequence.Add(i);
                NM(N, M, sequence, writer);
                sequence.RemoveAt(sequence.Count - 1);
            }
        }
    }
}