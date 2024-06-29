﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ChallengeBaekjone
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            using (var writer = new StreamWriter(Console.OpenStandardOutput(), Encoding.Default, bufferSize: 1024))
            {
                var n = int.Parse(Console.ReadLine());
                writer.WriteLine($"{(int)Math.Pow(2, n) - 1}");
                Hanoi(n, 1, 2, 3, writer);
            }

        }
        static void Hanoi(int n, int from, int by, int to, StreamWriter writer)
        {
            if (n == 0) return;
            Hanoi(n - 1, from, to, by, writer);
            writer.WriteLine($"{from} {to}");
            Hanoi(n - 1, by, from, to, writer);
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
