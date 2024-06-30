using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ChallengeBaekjone
{
    public class Baekjone15652
    {
        public static void Problem()
        {
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);
            var sequence = new List<int>();
            using (var writer = new StreamWriter(Console.OpenStandardOutput(), Encoding.Default, bufferSize: 1024))
            {
                NM(1, N, M, sequence, writer);
            }
        }
        static void NM(int I, int N, int M, List<int> sequence, StreamWriter writer)
        {
            if (sequence.Count == M)
            {
                writer.WriteLine(string.Join(" ", sequence));
                return;
            }
            for (int i = I; i <= N; ++i)
            {
                sequence.Add(i);
                NM(i, N, M, sequence, writer);
                sequence.RemoveAt(sequence.Count - 1);
            }
        }
    }
}