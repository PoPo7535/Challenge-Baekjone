using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using System.Text;

namespace ChallengeBaekjone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            N = int.Parse(Console.ReadLine());
            chessBoard = new int[N, N];
            NQueen(0,0);
            Console.WriteLine(count);
        }
        private static int N;
        private static int useQueen;
        private static int[,] chessBoard;
        private static int count = 0;
        private static void NQueen(int startX, int startY)
        {
            for (var y = startY; y < N; ++y)
            {
                for (var x = 0; x < N; ++x)
                {
                    if (0 == chessBoard[x, y])
                    {
                        Cal(true, x, y);
                        ++useQueen;
                        if (useQueen == N)
                            ++count;

                        NQueen(x, y+1);
                        Cal(false, x, y);
                        --useQueen;
                    }
                }
            }
        }

        private static void Cal(bool isPush, int x, int y)
        {
            var num = isPush ? 1 : -1;
            for (int i = 0; i < N; ++i)
            {
                chessBoard[x, i] += num;
                chessBoard[i, y] += num;
            }

            for (int i = 0; 0 <= x - i && 0 < y - i; ++i)
                chessBoard[x - i, y - i] += num;

            for (int i = 0; x + i < N && y + i < N; ++i)
                chessBoard[x + i, y + i] += num;
            
            for (int i = 0; 0 <= x - i && y + i < N; ++i)
                chessBoard[x - i, y + i] += num;
            
            for (int i = 0; x + i < N && 0 < y - i; ++i)
                chessBoard[x + i, y - i] += num;
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
