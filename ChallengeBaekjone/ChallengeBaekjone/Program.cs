using System;
namespace ChallengeBaekjone
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var a1 = int.Parse(input[0]);
            var a0 = int.Parse(input[1]);
        
            var c = int.Parse(Console.ReadLine());
            var n0 = int.Parse(Console.ReadLine());
        
            if (a1 <= c && a0 <= (c - a1) * n0)
                Console.WriteLine(1);
            else
                Console.WriteLine(0);
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
