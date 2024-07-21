using System;
using System.IO;
using System.Linq;

namespace ChallengeBaekjone
{
    internal class Program
    {
        static void Main()
        {
            var sr = new StreamReader(Console.OpenStandardInput());
            var sw = new StreamWriter(Console.OpenStandardOutput());

            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0], m = input[1], k = input[2];
            var board = new char[n][];
        
            for (int i = 0; i < n; i++)
                board[i] = Console.ReadLine().ToCharArray();

            var wb = new int[n + 1, m + 1];
            var bw = new int[n + 1, m + 1];

            for (var i = 1; i <= n; i++)
            {
                for (var j = 1; j <= m; j++)
                {
                    wb[i, j] = wb[i - 1, j] + wb[i, j - 1] - wb[i - 1, j - 1];
                    bw[i, j] = bw[i - 1, j] + bw[i, j - 1] - bw[i - 1, j - 1];
                
                    if ((i + j) % 2 == 0)
                    {
                        if (board[i - 1][j - 1] == 'B')
                            ++wb[i, j];
                        else
                            ++bw[i, j];
                    }
                    else
                    {
                        if (board[i - 1][j - 1] == 'B')
                            ++bw[i, j];
                        else
                            ++wb[i, j];
                    }
                }
            }

            var minPaint = int.MaxValue;

            for (int i = k; i <= n; i++)
            {
                for (int j = k; j <= m; j++)
                {
                    var wbCount = wb[i, j] - wb[i - k, j] - wb[i, j - k] + wb[i - k, j - k];
                    var bwCount = bw[i, j] - bw[i - k, j] - bw[i, j - k] + bw[i - k, j - k];
                
                    minPaint = Math.Min(minPaint, Math.Min(wbCount, bwCount));
                }
            }
            Console.WriteLine(minPaint);
            sr.Close();
            sw.Close();
        }
    }
}


/*
 * var sr = new StreamReader(Console.OpenStandardInput());
 * var sw = new StreamWriter(Console.OpenStandardOutput());
 * sr.Close();
 * sw.Close();
 */