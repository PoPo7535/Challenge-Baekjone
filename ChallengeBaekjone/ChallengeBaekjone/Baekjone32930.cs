using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ChallengeBaekjone
{
    public class Baekjone32930
    {
        void Problem()
        {
            var sr = new StreamReader(Console.OpenStandardInput());
            var sw = new StreamWriter(Console.OpenStandardOutput());
            var input = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int N = input[0];
            int M = input[1];
            var list = new LinkedList<(int y, int x)>();
            for (int i = 0; i < N + M; i++)
            {
                input = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
                list.AddLast((input[0], input[1]));
            }
            var result = 0;
            (int y, int x) pos = (0, 0);
            for (int m = 0; m < M; m++)
            {
                var node = list.First;
                var removeNode = list.First;
                var max = 0;
                for (int n = 0; n < N; n++)
                {
                    var xVal = Math.Abs(pos.x - node.Value.x);
                    xVal *= xVal;
                    var yVal = Math.Abs(pos.y - node.Value.y);
                    yVal *= yVal;
                    if (max < xVal + yVal)
                    {
                        max = xVal + yVal;
                        removeNode = node;
                    }
                    node = node.Next;
                }
                pos = removeNode.Value;
                list.Remove(removeNode);
                result += max;
            }
            sw.WriteLine(result);
            sr.Close();
            sw.Close();
        }
    }
}