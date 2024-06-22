﻿using System;
using System.Collections.Generic;

namespace ChallengeBaekjone
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var str = Console.ReadLine();
            var hash = new HashSet<string>();

            for (int i = 1; i <= str.Length; ++i)
            {
                for (int j = 0; j < str.Length - i+1; ++j)
                {
                    hash.Add(str.Substring(j, i));
                }
            }
            Console.WriteLine(hash.Count);
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
