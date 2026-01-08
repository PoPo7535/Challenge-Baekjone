using System;

namespace ChallengeBaekjone
{
    public class Baekjone1780
    {
        void Problem()
        {
            var N = int.Parse(Console.ReadLine());
            var arr = new int[N, N];
            int a = 0, b = 0, c = 0;
            for (int y = 0; y < N; ++y)
            {
                var line = Console.ReadLine().Split(' ');
                for (int x = 0; x < N; ++x)
                    arr[y,x] = int.Parse(line[x]);
            }
            Quad(0, 0, N);
            Console.WriteLine($"{a}\n{b}\n{c}");
            void Quad(int startX, int startY, int size)
            {
                var startNum = arr[startY, startX];
                for (int y = 0; y < size; ++y)
                {
                    for (int x = 0; x < size; ++x)
                    {
                        if (startNum != arr[startY + y, startX + x])
                        {
                            var newSize = size / 3;
                            for (int i = 0; i < 3; ++i)
                            {
                                for (int j = 0; j < 3; ++j)
                                {
                                    Quad(startX + newSize * (j), 
                                        startY + newSize * (i), newSize);
                                }
                            }
                            return;
                        }
                    }
                }
                switch (startNum)
                {
                    case -1:
                        ++a;
                        break;
                    case -0:
                        ++b;
                        break;
                    case 1:
                        ++c;
                        break;
                }
            }
        }
    }
}