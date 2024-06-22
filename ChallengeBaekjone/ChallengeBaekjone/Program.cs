﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ChallengeBaekjone
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var list = new List<int>();

            using (var writer = new StreamWriter(Console.OpenStandardOutput(), Encoding.Default, bufferSize: 1024))
            {
                for (int i = 0; i < N; ++i)
                {
                    var input = Console.ReadLine().Split(' ');
                    switch (int.Parse(input[0]))
                    {
                        case 1:
                            list.Add(int.Parse(input[1]));
                            break;
                        case 2:
                            if (list.Count != 0)
                            {
                                writer.WriteLine(list[list.Count-1]);
                                list.RemoveAt(list.Count - 1);
                                break;
                            }
                            writer.WriteLine(-1);
                            break;
                        case 3:
                            writer.WriteLine(list.Count);
                            break;
                        case 4:
                            writer.WriteLine(list.Count == 0 ? 1 : 0);
                            break;
                        case 5:
                            writer.WriteLine(list.Count == 0 ? -1 : list[list.Count - 1]);
                            break;
                    }
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
