using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ChallengeBaekjone
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            List<int> sequence = new List<int>();
            bool[] visited = new bool[N + 1];
            using (var writer = new StreamWriter(Console.OpenStandardOutput(), Encoding.Default, bufferSize: 1024))
            {
                NM(1, N, M, sequence, visited, writer);
            }
        }

        static void NM(int I, int N, int M, List<int> sequence, bool[] visited, StreamWriter writer)
        {
            if (sequence.Count == M)
            {
                writer.WriteLine(string.Join(" ", sequence));
                return;
            }

            for (int i = I; i <= N; ++i)
            {
                if (!visited[i])
                {
                    visited[i] = true;
                    sequence.Add(i);
                    NM(i, N, M, sequence, visited, writer);
                    sequence.RemoveAt(sequence.Count - 1);
                    visited[i] = false;
                }
            }
        }
    }
}


/*
 * var input = Console.ReadLine().Split(' ');
 * var N = int.Parse(input[0]);
 * var M = int.Parse(input[1]);
 * 
 * using (var writer = new StreamWriter(Console.OpenStandardOutput(), Encoding.Default, bufferSize: 1024))
 * {
 *     for (int i = 0; i < N; ++i)
 *     {
 *         var key = Console.ReadLine();
 *         writer.WriteLine(dic[key]);
 *     }
 * }
 */
