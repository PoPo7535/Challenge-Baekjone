﻿using System;
using System.Collections.Generic;
namespace ChallengeBaekjone
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var list = new List<int>();
            for (int i = 0; i < N; ++i)
                list.Add(int.Parse(Console.ReadLine()));
            list.Sort();
            var gcd = list[1] - list[0];
            for (int i = 2; i < list.Count; ++i)
                gcd = GCD(gcd, list[i] - list[i - 1]);
            
            var result = 0;
            for (int i = 1; i < list.Count; ++i)
                result += (list[i] - list[i - 1]) / gcd - 1;
            Console.WriteLine(result);
            int GCD(int a, int b)
            {
                while (b != 0)
                {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }
                return a;
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
