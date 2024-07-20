using System;
using System.IO;

namespace ChallengeBaekjone
{
    public class Baekjone11660
    {
        public static void Problem()
        {
            var sr = new StreamReader(Console.OpenStandardInput());
            var sw = new StreamWriter(Console.OpenStandardOutput());
            var NM = sr.ReadLine().Split();
            var N = int.Parse(NM[0]);
            var M = int.Parse(NM[1]);
            var arr = new int[2, N, N];
            for (int i = 0; i < N; ++i)
            {
                var numbers = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                for (int j = 0; j < N; ++j)
                {
                    arr[0, i, j] = j == 0 ? numbers[j] : arr[0, i, j - 1] + numbers[j];
                    arr[1, i, j] = i == 0 ? arr[0, i, j] : arr[1, i - 1, j] + arr[0, i, j];
                }
            }
            for (int i = 0; i < M; ++i)
            {
                var numbers = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                var yL = numbers[0] - 1;
                var xL = numbers[1] - 1;
                var yR = numbers[2] - 1;
                var xR = numbers[3] - 1;
                var result = arr[1, yR, xR];
                if (xL != 0)
                    result -= arr[1, yR, xL - 1];
    
                if (yL != 0)
                    result -= arr[1, yL - 1, xR];
                if (xL != 0 && yL != 0)
                    result += arr[1, yL - 1, xL - 1];
                sw.WriteLine(result);
            }
            sr.Close();
            sw.Close();
        }
    }
}