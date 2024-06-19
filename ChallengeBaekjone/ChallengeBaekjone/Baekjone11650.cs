using System;
using System.IO;
using System.Text;

namespace ChallengeBaekjone.Properties
{
    public class Baekjone11650
    {
        public struct Vector2 : IComparable<Vector2>
        {
            public int x;
            public int y;

            public Vector2(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public int CompareTo(Vector2 other)
            {
                var xCompare = x.CompareTo(other.x);
                var yCompare = y.CompareTo(other.y);
                return xCompare != 0 ? xCompare : yCompare;
            }
        }

        public static void Problem()
        {
            var N = int.Parse(Console.ReadLine());
            Vector2[] vec = new Vector2[N];
            for (int i = 0; i < N; ++i)
            {
                var input = Console.ReadLine().Split(' ');
                vec[i] = new Vector2(int.Parse(input[0]), int.Parse(input[1]));
            }

            Array.Sort(vec);
            using (StreamWriter writer =
                   new StreamWriter(Console.OpenStandardOutput(), Encoding.Default, bufferSize: 1024))
            {
                for (int i = 0; i < N; ++i)
                {
                    writer.WriteLine($"{vec[i].x} {vec[i].y}");

                }
            }

        }
    }
}