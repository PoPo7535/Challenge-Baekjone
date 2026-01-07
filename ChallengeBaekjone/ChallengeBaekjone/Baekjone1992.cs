using System;

namespace ChallengeBaekjone
{
    public class Baekjone1992
    {
        void Problem()
        {
            var N = int.Parse(Console.ReadLine());
            var arr = new int[N, N];
            for (int y = 0; y < N; ++y)
            {
                var line = Console.ReadLine();
                for (int x = 0; x < N; ++x)
                    arr[y,x] = line[x] - '0';
            }

            Quad(0, 0, N);
            void Quad(int startX, int startY, int size)
            {
                var startNum = arr[startY, startX];
                for (int y = 0; y < size; ++y)
                {
                    for (int x = 0; x < size; ++x)
                    {
                        if (startNum != arr[startY + y, startX + x])
                        {
                            var newSize = size / 2;
                            Console.Write('(');
                            Quad(startX, startY, newSize);
                            Quad(startX + newSize, startY, newSize);
                            Quad(startX, startY + newSize, newSize);
                            Quad(startX + newSize, startY + newSize, newSize);
                            Console.Write(')');
                            return;
                        }
                    }
                }
                Console.Write(startNum);
            }    
        }
    }
}