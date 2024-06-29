using System;
using System.IO;
using System.Text;

namespace ChallengeBaekjone
{
    public class Baekjone11729
    {
        public static void Problem()
        {
            using (var writer = new StreamWriter(Console.OpenStandardOutput(), Encoding.Default, bufferSize: 1024))
            {
                var n = int.Parse(Console.ReadLine());
                writer.WriteLine($"{(int)Math.Pow(2, n) - 1}");
                Hanoi(n, 1, 2, 3, writer);
            }
        }

        static void Hanoi(int n, int from, int by, int to, StreamWriter writer)
        {
            if (n == 0) return;
            Hanoi(n - 1, from, to, by, writer);
            writer.WriteLine($"{from} {to}");
            Hanoi(n - 1, by, from, to, writer);
        }
    }
}