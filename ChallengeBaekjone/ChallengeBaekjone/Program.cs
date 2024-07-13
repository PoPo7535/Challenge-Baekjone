﻿using System;
using System.Text;

namespace ChallengeBaekjone
{
    internal class Program
    {
        static void Main()
        {
            var N = int.Parse(Console.ReadLine());

            if (N == 0)
                return;
            var sb = new StringBuilder(Console.ReadLine());
            for (int i = 0; i < N - 1; ++i)
            {
                var str = Console.ReadLine();
                
                for (int j = 0; j < sb.Length; ++j)
                {
                    if (sb[j] != str[j])
                        sb[j] = '?';
                }
            }
            Console.WriteLine(sb);
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