using System;
namespace ChallengeBaekjone
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var split = Console.ReadLine().Split(' ');
            var N = long.Parse(split[0]);
            var K = long.Parse(split[1]);
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
