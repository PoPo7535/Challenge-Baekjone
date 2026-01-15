using System;
using System.IO;
using System.Linq;

namespace ChallengeBaekjone
{
    public class Baekjoon32334
    {
        void Problem()
        {
            var sr = new StreamReader(Console.OpenStandardInput());
            var sw = new StreamWriter(Console.OpenStandardOutput());
            var input = sr.ReadLine().Split(' ');
            var N = int.Parse(input[0]);
            var D = int.Parse(input[1]);
            var arr = new int[N, N];
            for (int y = 0; y < N; y++)
            {
                var numbers = sr.ReadLine().Split().Select(int.Parse).ToArray();
                for (int x = 0; x < N; x++)
                {
                    if (numbers[x] != 1)
                        continue;
                    arr[y, x] = 2;
                    for (int areaY = -D; areaY < D + 1; areaY++)
                    {
                        for (int areaX = -D; areaX < D + 1; areaX++)
                        {
                            var offX = areaX + x;
                            var offY = areaY + y;
                            if (offY < 0 || offY >= N ||
                                offX < 0 || offX >= N)
                                continue;
                            ++arr[offY, offX];
                        }
                    }
                }
            }
            (int y, int x) pos = (0, 0);
            for (int y = 0; y < N; y++)
            {
                for (int x = 0; x < N; x++)
                {
                    if (arr[y, x] < arr[pos.y, pos.x])
                        pos = (y, x);
                }
            }
            sw.WriteLine($"{pos.y + 1} {pos.x + 1}");
            if (1 <= arr[pos.y, pos.x])
                sw.WriteLine(arr[pos.y, pos.x]);
            sr.Close();
            sw.Close();
        }
    }
}