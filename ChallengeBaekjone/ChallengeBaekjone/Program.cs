using System;
namespace ChallengeBaekjone
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var num = long.Parse(Console.ReadLine());
            Console.WriteLine($"{num * num * num}\n{3}");
            //
            // int sum = 0;
            // for (int n = 0; n < 10; n++)
            // {
            //     for (int i = 0; i < n; i++)
            //     {
            //         for (int j = 0; j < n; j++)
            //         {
            //             for (int k = 0; k < n; k++)
            //             {
            //                 ++sum; // 코드1
            //             }
            //         }
            //     }
            //
            //     Console.WriteLine(sum);
            //     sum = 0;
            // }
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
