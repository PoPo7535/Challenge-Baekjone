using System;

namespace ChallengeBaekjone
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var A = long.Parse(input[0]);
            var B = long.Parse(input[1]);
            var a = A;
            var b = B;
            while (a != b)
            {
                if (a < b)
                    a += A;
                else
                    b += B;
            }
            Console.WriteLine(a);
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
