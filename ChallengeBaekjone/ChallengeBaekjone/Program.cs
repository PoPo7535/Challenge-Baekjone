using System;
namespace ChallengeBaekjone
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // var num = long.Parse(Console.ReadLine());
            // Console.WriteLine($"{num * num * num}\n{3}");
            var n = long.Parse(Console.ReadLine());
            long s = 0;
            for (long i = 1; i <= n - 2; i++) // 추후 long long i = 1 으로 수정
                s += (i * i + i) / 2; // i * i는 int형 범위 내에서만 계산됨. 상수x ?
            Console.WriteLine($"{s}\n{3}");

            // int sum = 0;
            // for (int n = 0; n < 10; n++)
            // {
            //     for (int i = 0; i < n - 2; i++)
            //     {
            //         for (int j = i + 1; j < n - 1; j++)
            //         {
            //             for (int k = j + 1; k < n; k++)
            //             {
            //                 ++sum;
            //             }
            //         }
            //     }
            //     Console.WriteLine($"{n}:{sum}");
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
