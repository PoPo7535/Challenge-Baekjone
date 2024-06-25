﻿using System;
using System.Collections.Generic;

namespace ChallengeBaekjone
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                var str = Console.ReadLine();
                if (str == ".")
                    return;

                var aCount = 0;
                var bCount = 0;
                var cur = 0; // 1:a,  2,b
                var stack = new Stack<int>();
                foreach (var t in str)
                {
                    switch (t)
                    {
                        case '[':
                            stack.Push(1);
                            break;
                        case ']':
                            if (stack.Count == 0 || 1 != stack.Pop())
                            {
                                Console.WriteLine("no");
                                goto end;
                            }

                            break;
                        case '(':
                            stack.Push(2);
                            break;
                        case ')':
                            if (stack.Count == 0 || 2 != stack.Pop())
                            {
                                Console.WriteLine("no");
                                goto end;
                            }
                            break;
                    }
                }

                Console.WriteLine(stack.Count == 0 ? "yes" : "no");
                end:;
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
