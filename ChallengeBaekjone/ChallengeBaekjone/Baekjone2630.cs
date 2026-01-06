using System;
using System.Collections.Generic;

namespace ChallengeBaekjone
{
    public class Baekjone2630
    {
        public struct Rectangle
        {
            public int X, Y, Width, Height;

            public Rectangle(int x, int y, int width, int height)
            {
                this.X = x;
                this.Y = y;
                this.Width = width;
                this.Height = height;
            }
        }
        public static void Problem()
        {
            var N = int.Parse(Console.ReadLine());
            var arr = new int[N, N];
            var blueCount = 0;
            var whiteCount = 0;

            for (int y = 0; y < N; ++y)
            {
                var n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for (int x = 0; x < N; ++x)
                {
                    arr[y, x] = n[x];
                }
            }

            var queue = new Queue<Rectangle>();
            queue.Enqueue(new Rectangle(0, 0, N, N));
            while (0 != queue.Count)
            {
                var rect = queue.Dequeue();
                var startColor = IsWhite(rect.Y, rect.X);
                bool breaking = false;
                for (int y = 0; y < rect.Height; ++y)
                {
                    for (int x = 0; x < rect.Width; ++x)
                    {
                        if (startColor != IsWhite(y + rect.Y, x + rect.X))
                        {
                            breaking = true;
                            break;
                        }
                    }

                    if (breaking)
                        break;
                }

                if (false == breaking)
                {
                    if (startColor)
                        ++whiteCount;
                    else
                        ++blueCount;
                }
                else if (0 != rect.Width / 2)
                {
                    var size = rect.Width / 2;
                    queue.Enqueue(new Rectangle(rect.X, rect.Y, size, size));
                    queue.Enqueue(new Rectangle(rect.X + size, rect.Y, size, size));
                    queue.Enqueue(new Rectangle(rect.X, rect.Y + size, size, size));
                    queue.Enqueue(new Rectangle(rect.X + size, rect.Y + size, size, size));
                }
            }

            Console.WriteLine(whiteCount);
            Console.WriteLine(blueCount);
            bool IsWhite(int y, int x) => arr[y, x] == 0;

        
        }
    }
}