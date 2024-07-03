using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using System.Text;

namespace ChallengeBaekjone
{
    internal class Program
    {




     

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


// static int W(int a, int b, int c)
// {
//     if (a <= 0 || b <= 0 || c <= 0)
//     {
//         return 1;
//     }
//     if (a > 20 || b > 20 || c > 20)
//     {
//         return W(20, 20, 20);
//     }
//     if (a < b && b < c)
//     {
//         return W(a, b, c - 1) + W(a, b - 1, c - 1) - W(a, b - 1, c);
//     }
//     return W(a - 1, b, c) + W(a - 1, b - 1, c) + W(a - 1, b, c - 1) - W(a - 1, b - 1, c - 1);
// }