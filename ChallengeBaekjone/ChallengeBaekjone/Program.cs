﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeBaekjone
{
    internal class Program
    {
        public static void MergeSortArray(int[] A, int p, int r)
        {
            if (p < r)
            {
                int q = (p + r) / 2;
                MergeSortArray(A, p, q);       // 전반부 정렬
                MergeSortArray(A, q + 1, r);   // 후반부 정렬
                Merge(A, p, q, r);             // 병합
            }
        }


        private static void Merge(int[] A, int p, int q, int r)
        {
            int i = p, j = q + 1, t = 0;
            int[] tmp = new int[r - p + 1];

            while (i <= q && j <= r)
            {
                if (A[i] <= A[j])
                    tmp[t++] = A[i++];
                else
                    tmp[t++] = A[j++];
            }

            while (i <= q)
            {
                tmp[t++] = A[i++];
            }

            while (j <= r)
            {
                tmp[t++] = A[j++];
            }

            for (i = p, t = 0; i <= r; i++, t++)
            {
                ++count;
                A[i] = tmp[t];
                if (K == count)
                    se = A[i];
            }
        }

        private static int count = 0;
        private static int K = 0;
        private static int se = -1;
        public static void Main(string[] args)
        {
            var str = Console.ReadLine().Split().Select(int.Parse).ToArray();
            K = str[1];
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            MergeSortArray(arr, 0, arr.Length - 1);
            Console.WriteLine(se);
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
