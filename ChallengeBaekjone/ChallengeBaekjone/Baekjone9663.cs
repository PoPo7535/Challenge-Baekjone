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
            chessBoard = new int[N, N];
            NQueen(0,0);
            Console.WriteLine(count);
        }
        private static int N;
        private static int useQueen;
        private static int[,] chessBoard;
        private static int count = 0;
        private static HashSet<Vector2> hashSet = new HashSet<Vector2>();
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
                        hashSet.Add(new Vector2(x, y));
                        if (useQueen == N)
                        {
                            ++count;
                            Print(x, y);
                        }
                        NQueen(x, y);
                        Cal(false, x, y);
                        --useQueen;
                        hashSet.Remove(new Vector2(x, y));
                    }
                }
            }
        }
        private static void Print(int x, int y)
        {
            Console.WriteLine($"{x} {y}------------------------------------");
            for (int yPos = 0; yPos < N; ++yPos)
            {
                for (int xPos = 0; xPos < N; ++xPos)
                {
                    Console.Write(hashSet.Contains(new Vector2(xPos,yPos))
                        ? $"[{chessBoard[xPos, yPos]}]"
                        : $" {chessBoard[xPos, yPos]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"------------------------------------------");
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