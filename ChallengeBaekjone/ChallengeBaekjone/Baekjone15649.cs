﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ChallengeBaekjone
{
    public class Baekjone15649
    {
        public static void Problem()
        {
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            List<int> sequence = new List<int>();
            bool[] visited = new bool[N + 1];
            using (var writer = new StreamWriter(Console.OpenStandardOutput(), Encoding.Default, bufferSize: 1024))
            {
                NM(N, M, sequence, visited, writer);
            }
        }
        static void NM(int N, int M, List<int> sequence, bool[] visited, StreamWriter writer)
        {
            if (sequence.Count == M)
            {
                writer.WriteLine(string.Join(" ", sequence));
                return;
            }

            for (int i = 1; i <= N; ++i)
            {
                if (!visited[i])
                {
                    visited[i] = true;
                    sequence.Add(i);
                    NM(N, M, sequence, visited, writer);
                    sequence.RemoveAt(sequence.Count - 1);
                    visited[i] = false;
                }
            }
        }
    }
}