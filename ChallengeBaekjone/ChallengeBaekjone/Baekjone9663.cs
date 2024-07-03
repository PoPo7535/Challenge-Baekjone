using System;
using System.Collections.Generic;
using System.Numerics;

namespace ChallengeBaekjone
{
    public class Baekjone9663
    {
        static void Problem(string[] args)
        {
            N = int.Parse(Console.ReadLine());
            chessBoard = new int[N];
            NQueen(0);
            Console.WriteLine(count);
        
        }
        private static int N;
        private static int count;
        private static int[] chessBoard;
        public static void NQueen(int line)
        {
            for (int i = 0; i < N; ++i) 
            {
                if (false == IsSafe(line, i)) 
                    continue;
                chessBoard[line] = i;
                if (N - 1 == line)
                    ++count;
                if (line + 1 < N)
                    NQueen(line + 1);
                chessBoard[line] = 0;
            }
        }
        public static bool IsSafe(int line, int num)
        {
            for (int i = 0; i < line; ++i)
            {
                if (i == line)
                    continue;
                if (chessBoard[i] == num ||
                    Math.Abs(i - line) == Math.Abs(chessBoard[i] - num))
                {
                    return false;
                }
            }
            return true;
        }
    }
}